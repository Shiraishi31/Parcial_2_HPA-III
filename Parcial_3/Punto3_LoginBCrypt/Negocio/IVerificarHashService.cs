namespace Negocio;

/// <summary>
/// CONTRATO 2: su única responsabilidad es VERIFICAR si una contraseña en texto plano
/// coincide con el hash almacenado. Se usa cuando alguien intenta iniciar sesión.
/// Está separado de IHashService (Principio de Responsabilidad Única):
/// crear un hash y comprobarlo son dos acciones distintas.
/// </summary>
public interface IVerificarHashService
{
    /// <summary>Compara la contraseña escrita con el hash guardado en la base de datos.</summary>
    /// <param name="textoPlano">La contraseña que se escribió en el login.</param>
    /// <param name="hashAlmacenado">El hash leído de la tabla Usuarios.</param>
    /// <returns>true si la contraseña es la correcta.</returns>
    bool Verificar(string textoPlano, string hashAlmacenado);
}
