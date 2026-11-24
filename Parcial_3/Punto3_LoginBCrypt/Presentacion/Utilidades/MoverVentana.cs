namespace Presentacion.Utilidades;

/// <summary>
/// Permite mover con el mouse una ventana sin borde (FormBorderStyle.None),
/// arrastrándola desde los controles indicados (por ejemplo, la barra superior).
/// </summary>
internal static class MoverVentana
{
    /// <summary>Activa el arrastre de <paramref name="ventana"/> desde cada uno de los <paramref name="controles"/>.</summary>
    public static void Habilitar(Form ventana, params Control[] controles)
    {
        bool arrastrando = false;
        Point distancia = Point.Empty;   // distancia entre el cursor y la esquina de la ventana

        foreach (Control control in controles)
        {
            control.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left && ventana.WindowState == FormWindowState.Normal)
                {
                    arrastrando = true;
                    distancia = new Point(Cursor.Position.X - ventana.Left, Cursor.Position.Y - ventana.Top);
                }
            };

            control.MouseMove += (s, e) =>
            {
                if (arrastrando)
                    ventana.Location = new Point(Cursor.Position.X - distancia.X, Cursor.Position.Y - distancia.Y);
            };

            control.MouseUp += (s, e) => arrastrando = false;
        }
    }
}
