namespace Presentacion.Presentadores;

/// <summary>Mensajes que comparten varios presentadores.</summary>
internal static class Mensajes
{
    /// <summary>Texto para cuando falla la conexión o una consulta a MySQL.</summary>
    public static string ErrorBaseDeDatos(Exception ex) =>
        "No se pudo conectar con la base de datos.\n" +
        "Revisa que MySQL esté encendido y que ejecutaste los scripts 01 y 03 de la carpeta BaseDeDatos.\n\n" +
        "Detalle: " + ex.Message;
}
