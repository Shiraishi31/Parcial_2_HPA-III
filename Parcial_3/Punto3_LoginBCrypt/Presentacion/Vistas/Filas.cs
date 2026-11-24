namespace Presentacion.Vistas;

/// <summary>
/// Una fila de las tablas de intentos, con los datos YA FORMATEADOS por el presentador.
/// La vista solo la muestra; no tiene que convertir fechas ni valores true/false.
/// </summary>
public class FilaIntento
{
    public string Fecha { get; set; }
    public string Usuario { get; set; }
    public string Resultado { get; set; }
    public string Detalle { get; set; }

    /// <summary>No se muestra como columna: la vista lo usa para pintar la fila de verde o rojo.</summary>
    public bool Exitoso { get; set; }
}

/// <summary>
/// Una fila de la tabla de usuarios, con los datos ya formateados.
/// </summary>
public class FilaUsuario
{
    public int Id { get; set; }
    public string Usuario { get; set; }
    public string NombreCompleto { get; set; }
    public string Hash { get; set; }
    public string FechaRegistro { get; set; }
}
