using System.Text.RegularExpressions;
using Datos;
using Entidades;

namespace Negocio;

/// <summary>
/// Reglas de negocio de los usuarios: iniciar sesión y registrar usuarios.
/// Recibe los DOS contratos por el constructor (inyección de dependencias):
/// esta clase no sabe que detrás está BCrypt, solo usa las interfaces.
/// </summary>
public class UsuarioNegocio
{
    private const int LongitudMinimaPassword = 6;
    private const int LongitudMaximaPassword = 72;   // BCrypt solo toma en cuenta los primeros 72 bytes

    private readonly IHashService _servicioHash;
    private readonly IVerificarHashService _servicioVerificacion;
    private readonly UsuarioRepositorio _usuarios = new UsuarioRepositorio();
    private readonly IntentoLoginRepositorio _intentos = new IntentoLoginRepositorio();

    /// <param name="servicioHash">Contrato que genera hashes (se usa al registrar).</param>
    /// <param name="servicioVerificacion">Contrato que verifica contraseñas (se usa en el login).</param>
    public UsuarioNegocio(IHashService servicioHash, IVerificarHashService servicioVerificacion)
    {
        _servicioHash = servicioHash;
        _servicioVerificacion = servicioVerificacion;
    }

    /// <summary>
    /// Intenta iniciar sesión. Verifica la contraseña con el contrato IVerificarHashService
    /// y guarda el intento (exitoso o fallido) en la tabla IntentosLogin.
    /// </summary>
    /// <returns>El usuario si la contraseña es correcta; null si el usuario no existe o la contraseña es incorrecta.</returns>
    public Usuario? IniciarSesion(string nombreUsuario, string password)
    {
        Usuario? usuario = _usuarios.BuscarPorNombreUsuario(nombreUsuario);

        if (usuario is null)
        {
            _intentos.Registrar(null, nombreUsuario, false, "Usuario no existe");
            return null;
        }

        bool esCorrecta = _servicioVerificacion.Verificar(password, usuario.PasswordHash);   // BCrypt.Verify

        _intentos.Registrar(usuario.Id, nombreUsuario, esCorrecta,
                            esCorrecta ? "Acceso concedido" : "Contraseña incorrecta");

        return esCorrecta ? usuario : null;
    }

    /// <summary>
    /// Registra un usuario nuevo. Valida las reglas, GENERA el hash con el contrato
    /// IHashService y manda a la capa de Datos solo el hash (nunca la contraseña).
    /// </summary>
    /// <exception cref="ReglaNegocioException">Si algún dato no cumple las reglas.</exception>
    /// <returns>El usuario registrado, con su Id y su hash.</returns>
    public Usuario RegistrarUsuario(string nombreUsuario, string nombreCompleto, string password, string confirmacion)
    {
        nombreUsuario = nombreUsuario.Trim();
        nombreCompleto = nombreCompleto.Trim();

        if (!Regex.IsMatch(nombreUsuario, @"^[a-zA-Z0-9_]{3,50}$"))
            throw new ReglaNegocioException("El nombre de usuario debe tener entre 3 y 50 caracteres: solo letras, números o guion bajo (_).");

        if (nombreCompleto.Length == 0 || nombreCompleto.Length > 100)
            throw new ReglaNegocioException("El nombre completo es obligatorio (máximo 100 caracteres).");

        if (password.Length < LongitudMinimaPassword || password.Length > LongitudMaximaPassword)
            throw new ReglaNegocioException($"La contraseña debe tener entre {LongitudMinimaPassword} y {LongitudMaximaPassword} caracteres.");

        if (password != confirmacion)
            throw new ReglaNegocioException("Las contraseñas no coinciden.");

        if (_usuarios.Existe(nombreUsuario))
            throw new ReglaNegocioException($"El nombre de usuario '{nombreUsuario}' ya existe.");

        string hash = _servicioHash.GenerarHash(password);                     // BCrypt.HashPassword
        int id = _usuarios.Insertar(nombreUsuario, nombreCompleto, hash);       // se guarda el HASH

        return new Usuario
        {
            Id = id,
            NombreUsuario = nombreUsuario,
            NombreCompleto = nombreCompleto,
            PasswordHash = hash,
            FechaCreacion = DateTime.Now
        };
    }

    /// <summary>Devuelve todos los usuarios registrados (con su hash, para demostrar que no se guarda la contraseña).</summary>
    public List<Usuario> ListarUsuarios()
    {
        return _usuarios.ObtenerTodos();
    }
}
