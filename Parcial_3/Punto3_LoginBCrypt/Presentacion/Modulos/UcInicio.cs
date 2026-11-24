using Entidades;
using Negocio;
using Presentacion.Presentadores;
using Presentacion.Utilidades;
using Presentacion.Vistas;

namespace Presentacion.Modulos;

/// <summary>
/// VISTA del módulo Inicio: saludo, tarjetas del sumario, últimos accesos y reloj grande
/// (igual que la pantalla de referencia del laboratorio).
/// </summary>
public partial class UcInicio : UserControl, IInicioView
{
    private readonly InicioPresenter _presenter;

    public UcInicio(IntentoLoginNegocio intentoNegocio, Usuario usuarioSesion)
    {
        InitializeComponent();
        _presenter = new InicioPresenter(this, intentoNegocio, usuarioSesion);

        EstiloTabla.Aplicar(dgvUltimos);
        EstiloTabla.PintarResultado(dgvUltimos, colResultado);
    }

    private void UcInicio_Load(object sender, EventArgs e)
    {
        _presenter.Cargar();
        timerReloj.Start();
    }

    private void timerReloj_Tick(object sender, EventArgs e) => _presenter.ActualizarHora();

    // ------------------------------ IInicioView ------------------------------

    public void MostrarSaludo(string saludo) => lblSaludo.Text = saludo;

    public void MostrarResumen(string usuarios, string exitosos, string fallidos)
    {
        lblUsuariosValor.Text = usuarios;
        lblExitososValor.Text = exitosos;
        lblFallidosValor.Text = fallidos;
    }

    public void MostrarUltimosAccesos(List<FilaIntento> filas) => dgvUltimos.DataSource = filas;

    public void MostrarHora(string hora, string fecha)
    {
        lblHoraGrande.Text = hora;
        lblFechaGrande.Text = fecha;
    }

    public void MostrarError(string mensaje)
    {
        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
