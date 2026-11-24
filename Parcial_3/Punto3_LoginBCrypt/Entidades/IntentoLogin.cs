namespace Entidades;

/// <summary>
/// Representa una fila de la tabla IntentosLogin (historial de accesos).
/// Se guarda cada intento, exitoso o fallido, para un análisis posterior.
/// </summary>
public class IntentoLogin
{
    /// <summary>Llave primaria (AUTO_INCREMENT).</summary>
    public int Id { get; set; }

    /// <summary>Lo que la persona escribió en el campo Usuario (aunque no exista).</summary>
    public string NombreUsuarioIngresado { get; set; } = "";

    /// <summary>true = entró al sistema; false = falló.</summary>
    public bool Exitoso { get; set; }

    /// <summary>Fecha y hora del intento (la pone MySQL).</summary>
    public DateTime FechaIntento { get; set; }

    /// <summary>Motivo: "Acceso concedido", "Contraseña incorrecta" o "Usuario no existe".</summary>
    public string? Detalle { get; set; }
}
