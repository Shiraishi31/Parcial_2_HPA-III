using System.Globalization;

namespace Presentacion.Utilidades;

/// <summary>
/// Formatos de fecha y hora en español de Panamá (es-PA).
/// Se fija la cultura para que la fecha salga en español aunque Windows esté en inglés.
/// </summary>
internal static class Formato
{
    private static readonly CultureInfo Cultura = new CultureInfo("es-PA");

    /// <summary>Hora con segundos. Ejemplo: 06:46:14 p. m.</summary>
    public static string Hora(DateTime fecha) => fecha.ToString("hh:mm:ss tt", Cultura);

    /// <summary>Hora sin segundos. Ejemplo: 06:46 p. m.</summary>
    public static string HoraCorta(DateTime fecha) => fecha.ToString("hh:mm tt", Cultura);

    /// <summary>Fecha larga. Ejemplo: Domingo, 21 de enero de 2018</summary>
    public static string FechaLarga(DateTime fecha)
    {
        string texto = fecha.ToString("dddd, d 'de' MMMM 'de' yyyy", Cultura);
        return char.ToUpper(texto[0], Cultura) + texto.Substring(1);   // primera letra en mayúscula
    }

    /// <summary>Fecha y hora para las tablas. Ejemplo: 21/01/2018 06:46 p. m.</summary>
    public static string FechaHora(DateTime fecha) => fecha.ToString("dd/MM/yyyy hh:mm tt", Cultura);
}
