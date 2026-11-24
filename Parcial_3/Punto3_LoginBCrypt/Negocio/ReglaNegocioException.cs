namespace Negocio;

/// <summary>
/// Error de una regla del negocio (por ejemplo, "las contraseñas no coinciden").
/// El mensaje está pensado para mostrárselo directamente al usuario.
/// </summary>
public class ReglaNegocioException : Exception
{
    /// <summary>Crea la excepción con el mensaje que verá el usuario.</summary>
    public ReglaNegocioException(string mensaje) : base(mensaje)
    {
    }
}
