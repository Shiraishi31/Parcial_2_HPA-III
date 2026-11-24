namespace Negocio;

/// <summary>
/// CONTRATO 1: su única responsabilidad es GENERAR el hash de una contraseña.
/// Se usa cuando se registra un usuario.
/// Quien use este contrato no sabe qué algoritmo hay detrás (BCrypt, SHA-256, Argon2...):
/// para cambiar de algoritmo solo se cambia la clase que lo implementa.
/// </summary>
public interface IHashService
{
    /// <summary>Convierte una contraseña en texto plano en su hash.</summary>
    /// <param name="textoPlano">La contraseña tal como la escribió el usuario.</param>
    /// <returns>El hash que se guarda en la base de datos.</returns>
    string GenerarHash(string textoPlano);
}
