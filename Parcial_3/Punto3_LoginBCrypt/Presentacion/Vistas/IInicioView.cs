namespace Presentacion.Vistas;

/// <summary>
/// Contrato de la VISTA de Inicio: saludo, tarjetas con el sumario, últimos accesos y reloj grande.
/// </summary>
public interface IInicioView
{
    /// <summary>Muestra el saludo con el nombre del usuario.</summary>
    void MostrarSaludo(string saludo);

    /// <summary>Llena las tarjetas del sumario.</summary>
    void MostrarResumen(string usuarios, string exitosos, string fallidos);

    /// <summary>Llena la tabla de últimos accesos.</summary>
    void MostrarUltimosAccesos(List<FilaIntento> filas);

    /// <summary>Actualiza el reloj grande.</summary>
    void MostrarHora(string hora, string fecha);

    /// <summary>Muestra un mensaje de error.</summary>
    void MostrarError(string mensaje);
}
