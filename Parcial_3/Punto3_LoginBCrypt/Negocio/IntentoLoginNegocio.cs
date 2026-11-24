using Datos;
using Entidades;

namespace Negocio;

/// <summary>
/// Consultas sobre el historial de accesos (tabla IntentosLogin),
/// para el análisis posterior que pide el enunciado.
/// </summary>
public class IntentoLoginNegocio
{
    private readonly IntentoLoginRepositorio _intentos = new IntentoLoginRepositorio();
    private readonly UsuarioRepositorio _usuarios = new UsuarioRepositorio();

    /// <summary>Últimos intentos de inicio de sesión, del más reciente al más antiguo.</summary>
    /// <param name="cantidad">Cuántos intentos traer (entre 1 y 500).</param>
    public List<IntentoLogin> ObtenerHistorial(int cantidad)
    {
        cantidad = Math.Max(1, Math.Min(cantidad, 500));
        return _intentos.ObtenerUltimos(cantidad);
    }

    /// <summary>Totales para las tarjetas del Inicio: usuarios, accesos exitosos y fallidos.</summary>
    public ResumenAccesos ObtenerResumen()
    {
        return new ResumenAccesos
        {
            TotalUsuarios = _usuarios.Contar(),
            AccesosExitosos = _intentos.ContarPorResultado(true),
            AccesosFallidos = _intentos.ContarPorResultado(false)
        };
    }
}
