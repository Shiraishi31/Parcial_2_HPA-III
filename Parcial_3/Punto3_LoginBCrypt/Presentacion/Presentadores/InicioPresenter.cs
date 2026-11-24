using Entidades;
using Negocio;
using Presentacion.Utilidades;
using Presentacion.Vistas;

namespace Presentacion.Presentadores;

/// <summary>
/// PRESENTADOR del Inicio: sumario del sistema, últimos accesos y reloj grande.
/// </summary>
public class InicioPresenter
{
    private const int CantidadUltimosAccesos = 10;

    private readonly IInicioView _vista;
    private readonly IntentoLoginNegocio _intentoNegocio;
    private readonly Usuario _usuarioSesion;

    public InicioPresenter(IInicioView vista, IntentoLoginNegocio intentoNegocio, Usuario usuarioSesion)
    {
        _vista = vista;
        _intentoNegocio = intentoNegocio;
        _usuarioSesion = usuarioSesion;
    }

    /// <summary>Carga el saludo, las tarjetas y los últimos accesos.</summary>
    public void Cargar()
    {
        _vista.MostrarSaludo($"Bienvenido(a), {_usuarioSesion.NombreCompleto}");
        ActualizarHora();

        try
        {
            ResumenAccesos resumen = _intentoNegocio.ObtenerResumen();
            _vista.MostrarResumen(resumen.TotalUsuarios.ToString(),
                                  resumen.AccesosExitosos.ToString(),
                                  resumen.AccesosFallidos.ToString());

            List<IntentoLogin> intentos = _intentoNegocio.ObtenerHistorial(CantidadUltimosAccesos);
            _vista.MostrarUltimosAccesos(intentos.Select(ConvertirFila.Intento).ToList());
        }
        catch (Exception ex)
        {
            _vista.MostrarError(Mensajes.ErrorBaseDeDatos(ex));
        }
    }

    /// <summary>Se llama cada segundo desde el Timer de la vista.</summary>
    public void ActualizarHora()
    {
        DateTime ahora = DateTime.Now;
        _vista.MostrarHora(Formato.Hora(ahora), Formato.FechaLarga(ahora));
    }
}
