using Entidades;
using Presentacion.Utilidades;
using Presentacion.Vistas;

namespace Presentacion.Presentadores;

/// <summary>
/// Convierte las entidades en filas listas para mostrar (fechas y resultados ya como texto).
/// </summary>
internal static class ConvertirFila
{
    public static FilaIntento Intento(IntentoLogin intento) => new FilaIntento
    {
        Fecha = Formato.FechaHora(intento.FechaIntento),
        Usuario = intento.NombreUsuarioIngresado,
        Resultado = intento.Exitoso ? "EXITOSO" : "FALLIDO",
        Detalle = intento.Detalle ?? "",
        Exitoso = intento.Exitoso
    };

    public static FilaUsuario Usuario(Usuario usuario) => new FilaUsuario
    {
        Id = usuario.Id,
        Usuario = usuario.NombreUsuario,
        NombreCompleto = usuario.NombreCompleto,
        Hash = usuario.PasswordHash,
        FechaRegistro = Formato.FechaHora(usuario.FechaCreacion)
    };
}
