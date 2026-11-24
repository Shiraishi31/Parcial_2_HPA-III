using Entidades;

namespace Presentacion.Vistas;

/// <summary>
/// Contrato de la VISTA de inicio de sesión (patrón MVP).
/// El presentador solo conoce esta interfaz, no el formulario: así no depende de Windows Forms.
/// </summary>
public interface ILoginView
{
    /// <summary>Lo que se escribió en el campo Usuario.</summary>
    string Usuario { get; }

    /// <summary>Lo que se escribió en el campo Contraseña (sin recortar espacios).</summary>
    string Password { get; }

    /// <summary>Muestra un mensaje de error debajo del botón Ingresar.</summary>
    void MostrarError(string mensaje);

    /// <summary>Muestra el mensaje de bienvenida con el nombre del usuario.</summary>
    void MostrarBienvenida(string mensaje);

    /// <summary>Borra la contraseña escrita (después de un intento fallido).</summary>
    void LimpiarPassword();

    /// <summary>Oculta el login y abre el menú principal con el usuario que inició sesión.</summary>
    void AbrirPrincipal(Usuario usuario);
}
