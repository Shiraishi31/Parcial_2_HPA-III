using Entidades;
using MySql.Data.MySqlClient;

namespace Datos;

/// <summary>
/// Acceso a la tabla IntentosLogin: guarda cada intento (exitoso o fallido)
/// con el usuario y la fecha, para poder analizarlos después.
/// </summary>
public class IntentoLoginRepositorio
{
    /// <summary>Guarda un intento de inicio de sesión.</summary>
    /// <param name="usuarioId">Id del usuario, o null si el nombre de usuario no existe.</param>
    /// <param name="nombreUsuarioIngresado">Lo que se escribió en el campo Usuario.</param>
    /// <param name="exitoso">true si entró al sistema.</param>
    /// <param name="detalle">Motivo del resultado.</param>
    public void Registrar(int? usuarioId, string nombreUsuarioIngresado, bool exitoso, string detalle)
    {
        // FechaIntento no se envía: la pone MySQL con DEFAULT CURRENT_TIMESTAMP
        const string sql = @"INSERT INTO IntentosLogin (UsuarioId, NombreUsuarioIngresado, Exitoso, Detalle)
                             VALUES (@UsuarioId, @NombreUsuarioIngresado, @Exitoso, @Detalle);";

        using MySqlConnection cn = Conexion.Crear();
        using MySqlCommand cmd = new MySqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@UsuarioId", (object?)usuarioId ?? DBNull.Value);   // null de C# -> NULL de SQL
        cmd.Parameters.AddWithValue("@NombreUsuarioIngresado", nombreUsuarioIngresado);
        cmd.Parameters.AddWithValue("@Exitoso", exitoso);
        cmd.Parameters.AddWithValue("@Detalle", detalle);

        cn.Open();
        cmd.ExecuteNonQuery();
    }

    /// <summary>Devuelve los últimos intentos, del más reciente al más antiguo.</summary>
    public List<IntentoLogin> ObtenerUltimos(int cantidad)
    {
        const string sql = @"SELECT Id, NombreUsuarioIngresado, Exitoso, FechaIntento, Detalle
                             FROM IntentosLogin
                             ORDER BY FechaIntento DESC, Id DESC
                             LIMIT @Cantidad;";

        var lista = new List<IntentoLogin>();

        using MySqlConnection cn = Conexion.Crear();
        using MySqlCommand cmd = new MySqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@Cantidad", cantidad);

        cn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            lista.Add(new IntentoLogin
            {
                Id = reader.GetInt32(0),
                NombreUsuarioIngresado = reader.GetString(1),
                Exitoso = reader.GetBoolean(2),
                FechaIntento = reader.GetDateTime(3),
                Detalle = reader.IsDBNull(4) ? null : reader.GetString(4)
            });
        }

        return lista;
    }

    /// <summary>Cuenta los intentos exitosos (true) o los fallidos (false).</summary>
    public int ContarPorResultado(bool exitoso)
    {
        const string sql = "SELECT COUNT(*) FROM IntentosLogin WHERE Exitoso = @Exitoso;";

        using MySqlConnection cn = Conexion.Crear();
        using MySqlCommand cmd = new MySqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@Exitoso", exitoso);

        cn.Open();
        return Convert.ToInt32(cmd.ExecuteScalar());
    }
}
