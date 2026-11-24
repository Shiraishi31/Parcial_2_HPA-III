using Negocio;
using Presentacion.Presentadores;
using Presentacion.Utilidades;
using Presentacion.Vistas;

namespace Presentacion.Modulos;

/// <summary>
/// VISTA del módulo Usuarios: registro de usuarios nuevos y lista con el hash guardado.
/// </summary>
public partial class UcUsuarios : UserControl, IUsuariosView
{
    private readonly UsuariosPresenter _presenter;

    public UcUsuarios(UsuarioNegocio usuarioNegocio)
    {
        InitializeComponent();
        _presenter = new UsuariosPresenter(this, usuarioNegocio);

        EstiloTabla.Aplicar(dgvUsuarios);
        btnRegistrar.Image = Iconos.Crear(Iconos.AgregarUsuario, Color.White, 18);
    }

    private void UcUsuarios_Load(object sender, EventArgs e) => _presenter.CargarUsuarios();

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        Cursor = Cursors.WaitCursor;   // generar el hash BCrypt tarda unos milisegundos a propósito
        _presenter.Registrar();
        Cursor = Cursors.Default;
    }

    // ----------------------------- IUsuariosView -----------------------------

    public string NuevoUsuario => txtNuevoUsuario.Text;

    public string NombreCompleto => txtNombreCompleto.Text;

    public string Password => txtPassword.Text;

    public string Confirmacion => txtConfirmacion.Text;

    public void MostrarUsuarios(List<FilaUsuario> filas) => dgvUsuarios.DataSource = filas;

    public void MostrarExito(string mensaje)
    {
        MessageBox.Show(mensaje, "Usuario registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void MostrarError(string mensaje)
    {
        MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public void LimpiarFormulario()
    {
        txtNuevoUsuario.Clear();
        txtNombreCompleto.Clear();
        txtPassword.Clear();
        txtConfirmacion.Clear();
        txtNuevoUsuario.Focus();
    }
}
