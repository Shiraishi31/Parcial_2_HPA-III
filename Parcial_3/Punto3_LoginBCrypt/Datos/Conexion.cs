using MySql.Data.MySqlClient;

namespace Datos;

/// <summary>
/// Un solo lugar para la cadena de conexión a MySQL.
/// NO se usa root: se usa 'app_login', un usuario con PRIVILEGIOS MÍNIMOS
/// (solo SELECT e INSERT en Usuarios e IntentosLogin).
/// Ese usuario lo crea el script BaseDeDatos/03_UsuarioAplicacion.sql;
/// si cambias la contraseña allá, cámbiala también aquí.
/// </summary>
public static class Conexion
{
    private const string CadenaConexion =
        "Server=localhost;Port=3306;Database=LoginBCryptDB;User ID=app_login;Password=LoginApp.2026!;";

    /// <summary>Crea una conexión nueva (todavía cerrada). Quien la usa la abre y la cierra con using.</summary>
    public static MySqlConnection Crear()
    {
        return new MySqlConnection(CadenaConexion);
    }
}
