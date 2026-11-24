using Entidades;
using MySql.Data.MySqlClient;

namespace Datos;

/// <summary>
/// Acceso a la tabla Usuarios.
/// Todas las consultas usan PARÁMETROS (@NombreUsuario...) para evitar inyección SQL.
/// Esta clase no sabe nada de BCrypt: recibe el hash ya generado por la capa de Negocio.
/// </summary>
public class UsuarioRepositorio
{
    /// <summary>Indica si ya hay un usuario con ese nombre de usuario.</summary>
    public bool Existe(string nombreUsuario)
    {
        const string sql = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario;";

        using MySqlConnection cn = Conexion.Crear();
        using MySqlCommand cmd = new MySqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

        cn.Open();
        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
    }

    /// <summary>Guarda el usuario con su HASH (nunca la contraseña) y devuelve el Id generado.</summary>
    public int Insertar(string nombreUsuario, string nombreCompleto, string passwordHash)
    {
        const string sql = @"INSERT INTO Usuarios (NombreUsuario, NombreCompleto, PasswordHash)
                             VALUES (@NombreUsuario, @NombreCompleto, @PasswordHash);";

        using MySqlConnection cn = Conexion.Crear();
        using MySqlCommand cmd = new MySqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
        cmd.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

        cn.Open();
        cmd.ExecuteNonQuery();
        return (int)cmd.LastInsertedId;   // el Id AUTO_INCREMENT que MySQL acaba de generar
    }

    /// <summary>Busca un usuario por su nombre de usuario. Devuelve null si no existe.</summary>
    public Usuario? BuscarPorNombreUsuario(string nombreUsuario)
    {
        const string sql = @"SELECT Id, NombreUsuario, NombreCompleto, PasswordHash, FechaCreacion
                             FROM Usuarios
                             WHERE NombreUsuario = @NombreUsuario;";

        using MySqlConnection cn = Conexion.Crear();
        using MySqlCommand cmd = new MySqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

        cn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();

        return reader.Read() ? LeerUsuario(reader) : null;
    }

    /// <summary>Devuelve todos los usuarios registrados, ordenados por Id.</summary>
    public List<Usuario> ObtenerTodos()
    {
        const string sql = @"SELECT Id, NombreUsuario, NombreCompleto, PasswordHash, FechaCreacion
                             FROM Usuarios
                             ORDER BY Id;";

        var lista = new List<Usuario>();

        using MySqlConnection cn = Conexion.Crear();
        using MySqlCommand cmd = new MySqlCommand(sql, cn);

        cn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
            lista.Add(LeerUsuario(reader));

        return lista;
    }

    /// <summary>Cantidad de usuarios registrados (para la tarjeta del Inicio).</summary>
    public int Contar()
    {
        const string sql = "SELECT COUNT(*) FROM Usuarios;";

        using MySqlConnection cn = Conexion.Crear();
        using MySqlCommand cmd = new MySqlCommand(sql, cn);

        cn.Open();
        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    /// <summary>Convierte la fila actual del reader en un objeto Usuario (mismo orden de columnas en todas las consultas).</summary>
    private static Usuario LeerUsuario(MySqlDataReader reader)
    {
        return new Usuario
        {
            Id = reader.GetInt32(0),
            NombreUsuario = reader.GetString(1),
            NombreCompleto = reader.GetString(2),
            PasswordHash = reader.GetString(3),
            FechaCreacion = reader.GetDateTime(4)
        };
    }
}
