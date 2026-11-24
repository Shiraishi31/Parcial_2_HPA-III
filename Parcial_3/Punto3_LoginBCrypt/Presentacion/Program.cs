using Negocio;
using Presentacion.Formularios;

namespace Presentacion;

internal static class Program
{
    /// <summary>
    /// Punto de entrada de la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // RAÍZ DE COMPOSICIÓN: aquí se decide qué implementación usar.
        // Una sola clase (BcryptPasswordService) cumple los DOS contratos y se entrega como
        // IHashService y como IVerificarHashService. Para cambiar de algoritmo (por ejemplo,
        // a Argon2) solo se cambia esta línea; la Vista, el Presentador y Datos no se tocan.
        var servicioPassword = new BcryptPasswordService();
        var usuarioNegocio = new UsuarioNegocio(servicioPassword, servicioPassword);
        var intentoNegocio = new IntentoLoginNegocio();

        Application.Run(new FrmLogin(usuarioNegocio, intentoNegocio));
    }
}
