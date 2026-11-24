using Entidades;
using Negocio;
using Presentacion.Vistas;

namespace Presentacion.Presentadores;

/// <summary>
/// PRESENTADOR del Historial de accesos: muestra los intentos guardados en IntentosLogin
/// para el análisis posterior.
/// </summary>
public class HistorialPresenter
{
    private const int CantidadIntentos = 100;

    private readonly IHistorialView _vista;
    private readonly IntentoLoginNegocio _intentoNegocio;

    public HistorialPresenter(IHistorialView vista, IntentoLoginNegocio intentoNegocio)
    {
        _vista = vista;
        _intentoNegocio = intentoNegocio;
    }

    /// <summary>Carga (o recarga) la tabla y los totales.</summary>
    public void Cargar()
    {
        try
        {
            List<IntentoLogin> intentos = _intentoNegocio.ObtenerHistorial(CantidadIntentos);
            ResumenAccesos resumen = _intentoNegocio.ObtenerResumen();

            _vista.MostrarHistorial(intentos.Select(ConvertirFila.Intento).ToList());
            _vista.MostrarTotales($"Mostrando los últimos {intentos.Count} intentos   ·   " +
                                  $"Total exitosos: {resumen.AccesosExitosos}   ·   " +
                                  $"Total fallidos: {resumen.AccesosFallidos}");
        }
        catch (Exception ex)
        {
            _vista.MostrarError(Mensajes.ErrorBaseDeDatos(ex));
        }
    }
}
