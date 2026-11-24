namespace Presentacion.Modulos
{
    partial class UcHistorial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHistorial = new System.Windows.Forms.Panel();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTotales = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHistorial
            //
            this.pnlHistorial.BackColor = System.Drawing.Color.White;
            this.pnlHistorial.Controls.Add(this.dgvHistorial);
            this.pnlHistorial.Controls.Add(this.pnlEncabezado);
            this.pnlHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistorial.Location = new System.Drawing.Point(0, 0);
            this.pnlHistorial.Name = "pnlHistorial";
            this.pnlHistorial.Padding = new System.Windows.Forms.Padding(12);
            this.pnlHistorial.Size = new System.Drawing.Size(780, 536);
            this.pnlHistorial.TabIndex = 0;
            //
            // dgvHistorial
            //
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colUsuario,
            this.colResultado,
            this.colDetalle});
            this.dgvHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorial.Location = new System.Drawing.Point(12, 60);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(756, 464);
            this.dgvHistorial.TabIndex = 1;
            //
            // colFecha
            //
            this.colFecha.DataPropertyName = "Fecha";
            this.colFecha.HeaderText = "Fecha y hora";
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 170;
            //
            // colUsuario
            //
            this.colUsuario.DataPropertyName = "Usuario";
            this.colUsuario.HeaderText = "Usuario ingresado";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Width = 170;
            //
            // colResultado
            //
            this.colResultado.DataPropertyName = "Resultado";
            this.colResultado.HeaderText = "Resultado";
            this.colResultado.Name = "colResultado";
            this.colResultado.Width = 110;
            //
            // colDetalle
            //
            this.colDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDetalle.DataPropertyName = "Detalle";
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.Name = "colDetalle";
            //
            // pnlEncabezado
            //
            this.pnlEncabezado.Controls.Add(this.lblTotales);
            this.pnlEncabezado.Controls.Add(this.btnActualizar);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(12, 12);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlEncabezado.Size = new System.Drawing.Size(756, 48);
            this.pnlEncabezado.TabIndex = 0;
            //
            // lblTotales
            //
            this.lblTotales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotales.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTotales.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblTotales.Location = new System.Drawing.Point(0, 0);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(606, 40);
            this.lblTotales.TabIndex = 0;
            this.lblTotales.Text = "Cargando...";
            this.lblTotales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnActualizar
            //
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(606, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 40);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "  Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            //
            // UcHistorial
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.pnlHistorial);
            this.Name = "UcHistorial";
            this.Size = new System.Drawing.Size(780, 536);
            this.Load += new System.EventHandler(this.UcHistorial_Load);
            this.pnlHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHistorial;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
    }
}
