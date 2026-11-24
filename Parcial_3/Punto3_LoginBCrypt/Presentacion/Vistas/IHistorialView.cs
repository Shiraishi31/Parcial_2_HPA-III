namespace Presentacion.Vistas;

/// <summary>
/// Contrato de la VISTA del Historial de accesos (tabla IntentosLogin).
/// </summary>
public interface IHistorialView
{
    /// <summary>Llena la tabla con los intentos de inicio de sesión.</summary>
    void MostrarHistorial(List<FilaIntento> filas);

    /// <summary>Muestra el texto con los totales (exitosos y fallidos).</summary>
    void MostrarTotales(string texto);

    /// <summary>Muestra un mensaje de error.</summary>
    void MostrarError(string mensaje);
}
