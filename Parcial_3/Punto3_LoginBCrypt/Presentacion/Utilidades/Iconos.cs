using System.Drawing.Text;

namespace Presentacion.Utilidades;

/// <summary>
/// Íconos del menú dibujados con la fuente "Segoe MDL2 Assets", que viene instalada en
/// Windows 10 y 11. Así no hace falta agregar imágenes al proyecto.
/// Cada constante es el carácter (glifo) de un ícono de esa fuente.
/// </summary>
internal static class Iconos
{
    public const string Inicio = "";
    public const string Usuarios = "";
    public const string Historial = "";
    public const string CerrarSesion = "";
    public const string Candado = "";
    public const string Persona = "";
    public const string AgregarUsuario = "";
    public const string Actualizar = "";
    public const string Minimizar = "";
    public const string Maximizar = "";
    public const string Restaurar = "";
    public const string Cerrar = "";

    /// <summary>Nombre de la fuente de íconos de Windows.</summary>
    public const string Fuente = "Segoe MDL2 Assets";

    /// <summary>Dibuja un ícono en una imagen transparente para ponerlo en un Button.</summary>
    /// <param name="glifo">Una de las constantes de esta clase.</param>
    /// <param name="color">Color del ícono.</param>
    /// <param name="tamano">Tamaño del ícono en píxeles.</param>
    public static Bitmap Crear(string glifo, Color color, int tamano)
    {
        var imagen = new Bitmap(tamano + 8, tamano + 8);

        using (Graphics g = Graphics.FromImage(imagen))
        using (var fuente = new Font(Fuente, tamano, FontStyle.Regular, GraphicsUnit.Pixel))
        using (var pincel = new SolidBrush(color))
        using (var formato = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
        {
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            g.DrawString(glifo, fuente, pincel, new RectangleF(0, 0, imagen.Width, imagen.Height), formato);
        }

        return imagen;
    }
}
