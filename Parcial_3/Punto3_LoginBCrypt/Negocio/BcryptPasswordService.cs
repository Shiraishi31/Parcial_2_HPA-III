namespace Negocio;

/// <summary>
/// IMPLEMENTACIÓN de los dos contratos usando el algoritmo BCrypt (biblioteca BCrypt.Net-Next).
/// Se escribe BCrypt.Net.BCrypt (namespace.namespace.clase) a propósito:
/// si solo pones "using BCrypt.Net;" y luego "BCrypt.HashPassword(...)",
/// C# confunde el namespace BCrypt con la clase BCrypt y no compila.
/// </summary>
public class BcryptPasswordService : IHashService, IVerificarHashService
{
    // Factor de trabajo (work factor / cost): 2^11 = 2048 rondas.
    // Más alto = más difícil de atacar por fuerza bruta, pero cada login tarda más.
    private const int FactorTrabajo = 11;

    /// <summary>
    /// Genera el hash BCrypt (BCrypt.HashPassword). La sal (salt) se crea sola y queda
    /// guardada dentro del mismo hash, por eso no hace falta una columna "Salt".
    /// </summary>
    public string GenerarHash(string textoPlano)
    {
        return BCrypt.Net.BCrypt.HashPassword(textoPlano, FactorTrabajo);
    }

    /// <summary>
    /// Verifica la contraseña con BCrypt.Verify(): toma la sal que está dentro del hash,
    /// vuelve a calcular el hash de lo que se escribió y compara.
    /// </summary>
    public bool Verificar(string textoPlano, string hashAlmacenado)
    {
        try
        {
            return BCrypt.Net.BCrypt.Verify(textoPlano, hashAlmacenado);
        }
        catch (BCrypt.Net.SaltParseException)
        {
            // El valor guardado no es un hash BCrypt válido: se trata como contraseña incorrecta.
            return false;
        }
    }
}
