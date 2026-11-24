namespace Presentacion.Vistas;

/// <summary>
/// Contrato de la VISTA de Usuarios: formulario de registro y lista de usuarios con su hash.
/// </summary>
public interface IUsuariosView
{
    /// <summary>Nombre de usuario que se quiere registrar.</summary>
    string NuevoUsuario { get; }

    /// <summary>Nombre completo de la persona.</summary>
    string NombreCompleto { get; }

    /// <summary>Contraseña en texto plano (se convierte en hash en la capa de Negocio).</summary>
    string Password { get; }

    /// <summary>Confirmación de la contraseña.</summary>
    string Confirmacion { get; }

    /// <summary>Llena la tabla de usuarios registrados.</summary>
    void MostrarUsuarios(List<FilaUsuario> filas);

    /// <summary>Muestra un mensaje de éxito.</summary>
    void MostrarExito(string mensaje);

    /// <summary>Muestra un mensaje de error.</summary>
    void MostrarError(string mensaje);

    /// <summary>Deja vacíos los campos del registro.</summary>
    void LimpiarFormulario();
}
