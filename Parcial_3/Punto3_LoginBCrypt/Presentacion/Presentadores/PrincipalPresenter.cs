using Entidades;
using Presentacion.Utilidades;
using Presentacion.Vistas;

namespace Presentacion.Presentadores;

/// <summary>
/// PRESENTADOR del menú principal: muestra quién inició sesión, actualiza la hora
/// y decide qué módulo se abre con cada opción del menú lateral.
/// </summary>
public class PrincipalPresenter
{
    private readonly IPrincipalView _vista;
    private readonly Usuario _usuarioSesion;
    private readonly DateTime _inicioSesion = DateTime.Now;

    /// <param name="vista">El formulario principal.</param>
    /// <param name="usuarioSesion">El usuario que inició sesión.</param>
    public PrincipalPresenter(IPrincipalView vista, Usuario usuarioSesion)
    {
        _vista = vista;
        _usuarioSesion = usuarioSesion;
    }

    /// <summary>Se llama al cargar el formulario.</summary>
    public void Iniciar()
    {
        _vista.MostrarUsuarioSesion(_usuarioSesion.NombreCompleto,
                                    "@" + _usuarioSesion.NombreUsuario,
                                    "Sesión desde: " + Formato.HoraCorta(_inicioSesion));
        ActualizarHora();
        _vista.AbrirInicio();
    }

    /// <summary>Se llama cada segundo desde el Timer de la vista.</summary>
    public void ActualizarHora()
    {
        DateTime ahora = DateTime.Now;
        _vista.MostrarHora(Formato.Hora(ahora), Formato.FechaLarga(ahora));
    }

    public void MostrarInicio() => _vista.AbrirInicio();

    public void MostrarUsuarios() => _vista.AbrirUsuarios();

    public void MostrarHistorial() => _vista.AbrirHistorial();

    /// <summary>Se llama al presionar "Cerrar sesión".</summary>
    public void SolicitarCerrarSesion()
    {
        if (_vista.Confirmar($"¿Cerrar la sesión de {_usuarioSesion.NombreCompleto}?"))
            _vista.CerrarSesion();
    }
}
