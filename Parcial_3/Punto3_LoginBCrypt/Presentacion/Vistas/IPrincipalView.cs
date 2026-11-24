namespace Presentacion.Vistas;

/// <summary>
/// Contrato de la VISTA principal: menú lateral, hora actual y sesión del usuario.
/// </summary>
public interface IPrincipalView
{
    /// <summary>Muestra en la parte inferior del menú quién inició sesión.</summary>
    /// <param name="nombreCompleto">Nombre real del usuario.</param>
    /// <param name="cuenta">Nombre de usuario, por ejemplo "@admin".</param>
    /// <param name="desde">Hora en que inició sesión.</param>
    void MostrarUsuarioSesion(string nombreCompleto, string cuenta, string desde);

    /// <summary>Actualiza la hora y fecha actuales en la barra superior.</summary>
    void MostrarHora(string hora, string fecha);

    /// <summary>Muestra el módulo Inicio (sumario y reloj).</summary>
    void AbrirInicio();

    /// <summary>Muestra el módulo Usuarios (registro con hash).</summary>
    void AbrirUsuarios();

    /// <summary>Muestra el módulo Historial de accesos.</summary>
    void AbrirHistorial();

    /// <summary>Pregunta algo al usuario con Sí / No.</summary>
    bool Confirmar(string pregunta);

    /// <summary>Cierra el menú principal y vuelve al login.</summary>
    void CerrarSesion();
}
