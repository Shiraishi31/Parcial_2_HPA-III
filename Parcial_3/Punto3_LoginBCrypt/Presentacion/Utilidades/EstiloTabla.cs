using Presentacion.Vistas;

namespace Presentacion.Utilidades;

/// <summary>
/// Da el mismo estilo a todas las tablas (DataGridView) del sistema.
/// </summary>
internal static class EstiloTabla
{
    private static readonly Font FuenteNormal = new Font("Segoe UI", 9F);
    private static readonly Font FuenteNegrita = new Font("Segoe UI", 9F, FontStyle.Bold);

    /// <summary>Tabla de solo lectura, con encabezado azul y filas alternas.</summary>
    public static void Aplicar(DataGridView tabla)
    {
        tabla.AutoGenerateColumns = false;   // solo se muestran las columnas definidas en el diseñador
        tabla.ReadOnly = true;
        tabla.AllowUserToAddRows = false;
        tabla.AllowUserToDeleteRows = false;
        tabla.AllowUserToResizeRows = false;
        tabla.MultiSelect = false;
        tabla.RowHeadersVisible = false;
        tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        tabla.BackgroundColor = Color.White;
        tabla.BorderStyle = BorderStyle.None;
        tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        tabla.GridColor = Colores.Linea;

        tabla.EnableHeadersVisualStyles = false;
        tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        tabla.ColumnHeadersHeight = 36;
        tabla.ColumnHeadersDefaultCellStyle.BackColor = Colores.Primario;
        tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        tabla.ColumnHeadersDefaultCellStyle.SelectionBackColor = Colores.Primario;
        tabla.ColumnHeadersDefaultCellStyle.Font = FuenteNegrita;
        tabla.ColumnHeadersDefaultCellStyle.Padding = new Padding(4, 0, 0, 0);

        tabla.DefaultCellStyle.Font = FuenteNormal;
        tabla.DefaultCellStyle.ForeColor = Colores.Texto;
        tabla.DefaultCellStyle.SelectionBackColor = Colores.PrimarioClaro;
        tabla.DefaultCellStyle.SelectionForeColor = Colores.Texto;
        tabla.DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
        tabla.AlternatingRowsDefaultCellStyle.BackColor = Colores.FilaAlterna;
        tabla.RowTemplate.Height = 30;
    }

    /// <summary>Pinta de verde "EXITOSO" y de rojo "FALLIDO" en la columna indicada.</summary>
    public static void PintarResultado(DataGridView tabla, DataGridViewColumn columnaResultado)
    {
        tabla.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0 || e.ColumnIndex != columnaResultado.Index)
                return;

            if (tabla.Rows[e.RowIndex].DataBoundItem is FilaIntento fila)
            {
                e.CellStyle.ForeColor = fila.Exitoso ? Colores.Exito : Colores.Error;
                e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
                e.CellStyle.Font = FuenteNegrita;
            }
        };
    }
}
