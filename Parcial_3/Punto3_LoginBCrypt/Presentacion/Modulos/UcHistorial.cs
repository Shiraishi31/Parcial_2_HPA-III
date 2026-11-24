using Negocio;
using Presentacion.Presentadores;
using Presentacion.Utilidades;
using Presentacion.Vistas;

namespace Presentacion.Modulos;

/// <summary>
/// VISTA del módulo Historial de accesos: todos los intentos (exitosos y fallidos)
/// con el usuario y la fecha, guardados en la tabla IntentosLogin.
/// </summary>
public partial class UcHistorial : UserControl, IHistorialView
{
    private readonly HistorialPresenter _presenter;

    public UcHistorial(IntentoLoginNegocio intentoNegocio)
    {
        InitializeComponent();
        _presenter = new HistorialPresenter(this, intentoNegocio);

        EstiloTabla.Aplicar(dgvHistorial);
        EstiloTabla.PintarResultado(dgvHistorial, colResultado);
        btnActualizar.Image = Iconos.Crear(Iconos.Actualizar, Color.White, 16);
    }

    private void UcHistorial_Load(object sender, EventArgs e) => _presenter.Cargar();

    private void btnActualizar_Click(object sender, EventArgs e) => _presenter.Cargar();

    // ----------------------------- IHistorialView -----------------------------

    public void MostrarHistorial(List<FilaIntento> filas) => dgvHistorial.DataSource = filas;

    public void MostrarTotales(string texto) => lblTotales.Text = texto;

    public void MostrarError(string mensaje)
    {
        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
