namespace Entidades;

/// <summary>
/// Totales que se muestran en las tarjetas del Inicio ("sumario del sistema").
/// </summary>
public class ResumenAccesos
{
    /// <summary>Cantidad de usuarios registrados.</summary>
    public int TotalUsuarios { get; set; }

    /// <summary>Cantidad de intentos de inicio de sesión exitosos.</summary>
    public int AccesosExitosos { get; set; }

    /// <summary>Cantidad de intentos de inicio de sesión fallidos.</summary>
    public int AccesosFallidos { get; set; }
}
