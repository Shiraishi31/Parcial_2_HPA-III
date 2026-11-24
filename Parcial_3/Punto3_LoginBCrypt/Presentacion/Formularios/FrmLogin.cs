using Entidades;
using Negocio;
using Presentacion.Presentadores;
using Presentacion.Utilidades;
using Presentacion.Vistas;

namespace Presentacion.Formularios;

/// <summary>
/// VISTA de inicio de sesión. Solo muestra controles y le avisa al presentador;
/// no sabe qué es un hash ni toca la base de datos.
/// </summary>
public partial class FrmLogin : Form, ILoginView
{
    private readonly LoginPresenter _presenter;
    private readonly UsuarioNegocio _usuarioNegocio;
    private readonly IntentoLoginNegocio _intentoNegocio;

    /// <param name="usuarioNegocio">Reglas de usuarios (login y registro).</param>
    /// <param name="intentoNegocio">Consultas del historial de accesos.</param>
    public FrmLogin(UsuarioNegocio usuarioNegocio, IntentoLoginNegocio intentoNegocio)
    {
        InitializeComponent();

        _usuarioNegocio = usuarioNegocio;
        _intentoNegocio = intentoNegocio;
        _presenter = new LoginPresenter(this, usuarioNegocio);

        // La ventana no tiene borde: se mueve arrastrando el panel azul
        MoverVentana.Habilitar(this, pnlMarca, lblIconoMarca, lblNombreSistema, lblDescripcion);
        ActiveControl = txtUsuario;
    }

    // ----------------------------- ILoginView -----------------------------

    public string Usuario => txtUsuario.Text;

    public string Password => txtPassword.Text;   // sin Trim: los espacios también son parte de la contraseña

    public void MostrarError(string mensaje)
    {
        // Los errores largos (por ejemplo, de conexión) se muestran completos en un cuadro de mensaje
        if (mensaje.Contains("\n"))
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            mensaje = mensaje.Substring(0, mensaje.IndexOf("\n", StringComparison.Ordinal));
        }

        lblError.Text = mensaje;
    }

    public void MostrarBienvenida(string mensaje)
    {
        MessageBox.Show(mensaje, "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void LimpiarPassword()
    {
        txtPassword.Clear();
        txtPassword.Focus();
    }

    public void AbrirPrincipal(Usuario usuario)
    {
        var principal = new FrmPrincipal(usuario, _usuarioNegocio, _intentoNegocio);
        principal.FormClosed += Principal_FormClosed;

        Hide();
        principal.Show();
    }

    // ------------------------------ Eventos -------------------------------

    private void btnIngresar_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        Cursor = Cursors.WaitCursor;   // BCrypt tarda unos milisegundos a propósito
        _presenter.IniciarSesion();
        Cursor = Cursors.Default;
    }

    private void chkMostrarPassword_CheckedChanged(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = !chkMostrarPassword.Checked;
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>Al cerrar el menú principal: si fue "Cerrar sesión" se vuelve al login; si no, se sale.</summary>
    private void Principal_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (sender is FrmPrincipal principal && principal.SesionCerrada)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            lblError.Text = "";
            Show();
            txtUsuario.Focus();
        }
        else
        {
            Close();   // cierra la aplicación
        }
    }
}
