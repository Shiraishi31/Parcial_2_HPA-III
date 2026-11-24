using System.ComponentModel;
using System.Drawing.Drawing2D;
using Entidades;
using Negocio;
using Presentacion.Modulos;
using Presentacion.Presentadores;
using Presentacion.Utilidades;
using Presentacion.Vistas;

namespace Presentacion.Formularios;

/// <summary>
/// VISTA principal: menú lateral a la izquierda, hora actual en la barra superior,
/// y en la parte inferior del menú, el usuario que inició sesión.
/// Los módulos (Inicio, Usuarios, Historial) se muestran dentro de pnlContenido.
/// </summary>
public partial class FrmPrincipal : Form, IPrincipalView
{
    private readonly PrincipalPresenter _presenter;
    private readonly Usuario _usuario;
    private readonly UsuarioNegocio _usuarioNegocio;
    private readonly IntentoLoginNegocio _intentoNegocio;

    /// <summary>true cuando se cerró con "Cerrar sesión" (el login vuelve a aparecer).</summary>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]   // el diseñador no debe guardarla
    public bool SesionCerrada { get; private set; }

    /// <param name="usuario">El usuario que inició sesión.</param>
    /// <param name="usuarioNegocio">Reglas de usuarios (para el módulo Usuarios).</param>
    /// <param name="intentoNegocio">Consultas del historial (para Inicio e Historial).</param>
    public FrmPrincipal(Usuario usuario, UsuarioNegocio usuarioNegocio, IntentoLoginNegocio intentoNegocio)
    {
        InitializeComponent();

        _usuario = usuario;
        _usuarioNegocio = usuarioNegocio;
        _intentoNegocio = intentoNegocio;
        _presenter = new PrincipalPresenter(this, usuario);

        PonerIconosDelMenu();
        RedondearAvatar();
        MoverVentana.Habilitar(this, pnlBarraSuperior, lblTituloModulo, pnlReloj, lblHoraBarra, lblFechaBarra);
    }

    private void FrmPrincipal_Load(object sender, EventArgs e)
    {
        // Si la pantalla es más pequeña que la ventana, se abre maximizada
        Rectangle area = Screen.FromControl(this).WorkingArea;
        if (Width > area.Width || Height > area.Height)
            CambiarMaximizado();

        _presenter.Iniciar();
        timerReloj.Start();
    }

    // ---------------------------- IPrincipalView ----------------------------

    public void MostrarUsuarioSesion(string nombreCompleto, string cuenta, string desde)
    {
        lblSesionNombre.Text = nombreCompleto;
        lblSesionCuenta.Text = cuenta;
        lblSesionDesde.Text = desde;
    }

    public void MostrarHora(string hora, string fecha)
    {
        lblHoraBarra.Text = hora;
        lblFechaBarra.Text = fecha;
    }

    public void AbrirInicio() => MostrarModulo(new UcInicio(_intentoNegocio, _usuario), "Inicio", btnInicio);

    public void AbrirUsuarios() => MostrarModulo(new UcUsuarios(_usuarioNegocio), "Usuarios", btnUsuarios);

    public void AbrirHistorial() => MostrarModulo(new UcHistorial(_intentoNegocio), "Historial de accesos", btnHistorial);

    public bool Confirmar(string pregunta)
    {
        return MessageBox.Show(pregunta, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }

    public void CerrarSesion()
    {
        SesionCerrada = true;
        Close();
    }

    // ------------------------------- Eventos --------------------------------

    private void btnInicio_Click(object sender, EventArgs e) => _presenter.MostrarInicio();

    private void btnUsuarios_Click(object sender, EventArgs e) => _presenter.MostrarUsuarios();

    private void btnHistorial_Click(object sender, EventArgs e) => _presenter.MostrarHistorial();

    private void btnCerrarSesion_Click(object sender, EventArgs e) => _presenter.SolicitarCerrarSesion();

    private void timerReloj_Tick(object sender, EventArgs e) => _presenter.ActualizarHora();

    private void btnMinimizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

    private void btnMaximizar_Click(object sender, EventArgs e) => CambiarMaximizado();

    private void lblTituloModulo_DoubleClick(object sender, EventArgs e) => CambiarMaximizado();

    private void btnCerrar_Click(object sender, EventArgs e) => Close();   // cierra la aplicación

    // --------------------------- Métodos de apoyo ---------------------------

    /// <summary>Cambia el módulo que se ve en el panel de contenido y marca su botón en el menú.</summary>
    private void MostrarModulo(UserControl modulo, string titulo, Button botonDelMenu)
    {
        // Se libera el módulo anterior (y su Timer, si tenía)
        while (pnlContenido.Controls.Count > 0)
            pnlContenido.Controls[0].Dispose();

        modulo.Dock = DockStyle.Fill;
        pnlContenido.Controls.Add(modulo);
        lblTituloModulo.Text = titulo;

        foreach (Button boton in new[] { btnInicio, btnUsuarios, btnHistorial })
            boton.BackColor = boton == botonDelMenu ? Colores.PrimarioOscuro : Colores.Primario;
    }

    /// <summary>Maximiza sin tapar la barra de tareas, o restaura el tamaño normal.</summary>
    private void CambiarMaximizado()
    {
        if (WindowState == FormWindowState.Maximized)
        {
            WindowState = FormWindowState.Normal;
            btnMaximizar.Text = Iconos.Maximizar;
        }
        else
        {
            MaximizedBounds = Screen.FromControl(this).WorkingArea;
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Text = Iconos.Restaurar;
        }
    }

    private void PonerIconosDelMenu()
    {
        btnInicio.Image = Iconos.Crear(Iconos.Inicio, Color.White, 18);
        btnUsuarios.Image = Iconos.Crear(Iconos.Usuarios, Color.White, 18);
        btnHistorial.Image = Iconos.Crear(Iconos.Historial, Color.White, 18);
        btnCerrarSesion.Image = Iconos.Crear(Iconos.CerrarSesion, Color.White, 18);
    }

    /// <summary>Deja el avatar del usuario en forma de círculo.</summary>
    private void RedondearAvatar()
    {
        using var circulo = new GraphicsPath();
        circulo.AddEllipse(0, 0, lblAvatar.Width, lblAvatar.Height);
        lblAvatar.Region = new Region(circulo);
    }
}
