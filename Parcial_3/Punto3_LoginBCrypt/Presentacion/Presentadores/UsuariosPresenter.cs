using Entidades;
using Negocio;
using Presentacion.Vistas;

namespace Presentacion.Presentadores;

/// <summary>
/// PRESENTADOR de Usuarios: registra usuarios nuevos (la capa de Negocio genera el hash
/// con el contrato IHashService) y muestra la lista con el hash guardado en la base de datos.
/// </summary>
public class UsuariosPresenter
{
    private readonly IUsuariosView _vista;
    private readonly UsuarioNegocio _usuarioNegocio;

    public UsuariosPresenter(IUsuariosView vista, UsuarioNegocio usuarioNegocio)
    {
        _vista = vista;
        _usuarioNegocio = usuarioNegocio;
    }

    /// <summary>Carga la tabla de usuarios registrados.</summary>
    public void CargarUsuarios()
    {
        try
        {
            List<Usuario> usuarios = _usuarioNegocio.ListarUsuarios();
            _vista.MostrarUsuarios(usuarios.Select(ConvertirFila.Usuario).ToList());
        }
        catch (Exception ex)
        {
            _vista.MostrarError(Mensajes.ErrorBaseDeDatos(ex));
        }
    }

    /// <summary>Se llama al presionar "Registrar usuario".</summary>
    public void Registrar()
    {
        if (_vista.NuevoUsuario.Trim().Length == 0 || _vista.NombreCompleto.Trim().Length == 0 ||
            _vista.Password.Length == 0 || _vista.Confirmacion.Length == 0)
        {
            _vista.MostrarError("Todos los campos son obligatorios.");
            return;
        }

        try
        {
            Usuario nuevo = _usuarioNegocio.RegistrarUsuario(_vista.NuevoUsuario, _vista.NombreCompleto,
                                                             _vista.Password, _vista.Confirmacion);
            _vista.LimpiarFormulario();
            _vista.MostrarExito($"Usuario '{nuevo.NombreUsuario}' registrado con Id {nuevo.Id}.\n\n" +
                                $"Hash BCrypt guardado en la base de datos:\n{nuevo.PasswordHash}");
            CargarUsuarios();
        }
        catch (ReglaNegocioException ex)
        {
            _vista.MostrarError(ex.Message);   // regla del negocio: el mensaje ya es para el usuario
        }
        catch (Exception ex)
        {
            _vista.MostrarError(Mensajes.ErrorBaseDeDatos(ex));
        }
    }
}
