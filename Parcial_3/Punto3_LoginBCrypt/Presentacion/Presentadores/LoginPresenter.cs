using Entidades;
using Negocio;
using Presentacion.Vistas;

namespace Presentacion.Presentadores;

/// <summary>
/// PRESENTADOR del login: recibe la acción de la vista, le pide a la capa de Negocio
/// que verifique la contraseña (con el contrato IVerificarHashService) y le devuelve
/// el resultado a la vista. No sabe qué es un TextBox ni qué algoritmo de hash se usa.
/// </summary>
public class LoginPresenter
{
    private readonly ILoginView _vista;
    private readonly UsuarioNegocio _usuarioNegocio;

    public LoginPresenter(ILoginView vista, UsuarioNegocio usuarioNegocio)
    {
        _vista = vista;
        _usuarioNegocio = usuarioNegocio;
    }

    /// <summary>Se llama al presionar "Ingresar".</summary>
    public void IniciarSesion()
    {
        string usuario = _vista.Usuario.Trim();
        string password = _vista.Password;

        // Validación de la interfaz: campos obligatorios
        if (usuario.Length == 0 || password.Length == 0)
        {
            _vista.MostrarError("Escribe el usuario y la contraseña.");
            return;
        }

        Usuario usuarioValido;
        try
        {
            usuarioValido = _usuarioNegocio.IniciarSesion(usuario, password);   // BCrypt.Verify + registro del intento
        }
        catch (Exception ex)
        {
            _vista.MostrarError(Mensajes.ErrorBaseDeDatos(ex));
            return;
        }

        if (usuarioValido == null)
        {
            // Mensaje genérico: no se revela si falló el usuario o la contraseña
            _vista.MostrarError("Usuario o contraseña incorrectos.");
            _vista.LimpiarPassword();
            return;
        }

        // Requisito: al tener un acceso exitoso, indicar el nombre del usuario
        _vista.MostrarBienvenida($"¡Bienvenido(a), {usuarioValido.NombreCompleto}!");
        _vista.AbrirPrincipal(usuarioValido);
    }
}
