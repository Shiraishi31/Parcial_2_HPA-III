namespace Entidades;

/// <summary>
/// Representa una fila de la tabla Usuarios.
/// Ojo: NO existe una propiedad "Password". Solo se guarda el hash BCrypt.
/// </summary>
public class Usuario
{
    /// <summary>Llave primaria (AUTO_INCREMENT).</summary>
    public int Id { get; set; }

    /// <summary>Nombre con el que se inicia sesión (único).</summary>
    public string NombreUsuario { get; set; } = "";

    /// <summary>Nombre real de la persona; se muestra al entrar al sistema.</summary>
    public string NombreCompleto { get; set; } = "";

    /// <summary>Hash BCrypt de la contraseña (siempre 60 caracteres, incluye la sal).</summary>
    public string PasswordHash { get; set; } = "";

    /// <summary>Fecha en que se registró el usuario.</summary>
    public DateTime FechaCreacion { get; set; }
}
