namespace Presentacion.Modulos
{
    partial class UcInicio
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
            this.components = new System.ComponentModel.Container();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblSumario = new System.Windows.Forms.Label();
            this.flpTarjetas = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTarjetaUsuarios = new System.Windows.Forms.Panel();
            this.lblUsuariosValor = new System.Windows.Forms.Label();
            this.lblUsuariosTitulo = new System.Windows.Forms.Label();
            this.pnlUsuariosBarra = new System.Windows.Forms.Panel();
            this.pnlTarjetaExitosos = new System.Windows.Forms.Panel();
            this.lblExitososValor = new System.Windows.Forms.Label();
            this.lblExitososTitulo = new System.Windows.Forms.Label();
            this.pnlExitososBarra = new System.Windows.Forms.Panel();
            this.pnlTarjetaFallidos = new System.Windows.Forms.Panel();
            this.lblFallidosValor = new System.Windows.Forms.Label();
            this.lblFallidosTitulo = new System.Windows.Forms.Label();
            this.pnlFallidosBarra = new System.Windows.Forms.Panel();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlRelojGrande = new System.Windows.Forms.Panel();
            this.lblHoraGrande = new System.Windows.Forms.Label();
            this.lblFechaGrande = new System.Windows.Forms.Label();
            this.pnlUltimos = new System.Windows.Forms.Panel();
            this.dgvUltimos = new System.Windows.Forms.DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUltimos = new System.Windows.Forms.Label();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.flpTarjetas.SuspendLayout();
            this.pnlTarjetaUsuarios.SuspendLayout();
            this.pnlTarjetaExitosos.SuspendLayout();
            this.pnlTarjetaFallidos.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.pnlRelojGrande.SuspendLayout();
            this.pnlUltimos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimos)).BeginInit();
            this.SuspendLayout();
            //
            // lblSaludo
            //
            this.lblSaludo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblSaludo.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblSaludo.Location = new System.Drawing.Point(0, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(780, 40);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "Bienvenido(a)";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblSumario
            //
            this.lblSumario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSumario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSumario.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblSumario.Location = new System.Drawing.Point(0, 40);
            this.lblSumario.Name = "lblSumario";
            this.lblSumario.Size = new System.Drawing.Size(780, 28);
            this.lblSumario.TabIndex = 1;
            this.lblSumario.Text = "Sumario del sistema:";
            this.lblSumario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // flpTarjetas
            //
            this.flpTarjetas.Controls.Add(this.pnlTarjetaUsuarios);
            this.flpTarjetas.Controls.Add(this.pnlTarjetaExitosos);
            this.flpTarjetas.Controls.Add(this.pnlTarjetaFallidos);
            this.flpTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpTarjetas.Location = new System.Drawing.Point(0, 68);
            this.flpTarjetas.Name = "flpTarjetas";
            this.flpTarjetas.Size = new System.Drawing.Size(780, 122);
            this.flpTarjetas.TabIndex = 2;
            //
            // pnlTarjetaUsuarios
            //
            this.pnlTarjetaUsuarios.BackColor = System.Drawing.Color.White;
            this.pnlTarjetaUsuarios.Controls.Add(this.lblUsuariosValor);
            this.pnlTarjetaUsuarios.Controls.Add(this.lblUsuariosTitulo);
            this.pnlTarjetaUsuarios.Controls.Add(this.pnlUsuariosBarra);
            this.pnlTarjetaUsuarios.Location = new System.Drawing.Point(0, 3);
            this.pnlTarjetaUsuarios.Margin = new System.Windows.Forms.Padding(0, 3, 16, 3);
            this.pnlTarjetaUsuarios.Name = "pnlTarjetaUsuarios";
            this.pnlTarjetaUsuarios.Size = new System.Drawing.Size(230, 108);
            this.pnlTarjetaUsuarios.TabIndex = 0;
            //
            // lblUsuariosValor
            //
            this.lblUsuariosValor.AutoSize = true;
            this.lblUsuariosValor.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblUsuariosValor.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblUsuariosValor.Location = new System.Drawing.Point(12, 40);
            this.lblUsuariosValor.Name = "lblUsuariosValor";
            this.lblUsuariosValor.Size = new System.Drawing.Size(48, 60);
            this.lblUsuariosValor.TabIndex = 2;
            this.lblUsuariosValor.Text = "0";
            //
            // lblUsuariosTitulo
            //
            this.lblUsuariosTitulo.AutoSize = true;
            this.lblUsuariosTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblUsuariosTitulo.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblUsuariosTitulo.Location = new System.Drawing.Point(16, 16);
            this.lblUsuariosTitulo.Name = "lblUsuariosTitulo";
            this.lblUsuariosTitulo.Size = new System.Drawing.Size(155, 23);
            this.lblUsuariosTitulo.TabIndex = 1;
            this.lblUsuariosTitulo.Text = "Usuarios registrados";
            //
            // pnlUsuariosBarra
            //
            this.pnlUsuariosBarra.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.pnlUsuariosBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuariosBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuariosBarra.Name = "pnlUsuariosBarra";
            this.pnlUsuariosBarra.Size = new System.Drawing.Size(230, 5);
            this.pnlUsuariosBarra.TabIndex = 0;
            //
            // pnlTarjetaExitosos
            //
            this.pnlTarjetaExitosos.BackColor = System.Drawing.Color.White;
            this.pnlTarjetaExitosos.Controls.Add(this.lblExitososValor);
            this.pnlTarjetaExitosos.Controls.Add(this.lblExitososTitulo);
            this.pnlTarjetaExitosos.Controls.Add(this.pnlExitososBarra);
            this.pnlTarjetaExitosos.Location = new System.Drawing.Point(246, 3);
            this.pnlTarjetaExitosos.Margin = new System.Windows.Forms.Padding(0, 3, 16, 3);
            this.pnlTarjetaExitosos.Name = "pnlTarjetaExitosos";
            this.pnlTarjetaExitosos.Size = new System.Drawing.Size(230, 108);
            this.pnlTarjetaExitosos.TabIndex = 1;
            //
            // lblExitososValor
            //
            this.lblExitososValor.AutoSize = true;
            this.lblExitososValor.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblExitososValor.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblExitososValor.Location = new System.Drawing.Point(12, 40);
            this.lblExitososValor.Name = "lblExitososValor";
            this.lblExitososValor.Size = new System.Drawing.Size(48, 60);
            this.lblExitososValor.TabIndex = 2;
            this.lblExitososValor.Text = "0";
            //
            // lblExitososTitulo
            //
            this.lblExitososTitulo.AutoSize = true;
            this.lblExitososTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblExitososTitulo.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblExitososTitulo.Location = new System.Drawing.Point(16, 16);
            this.lblExitososTitulo.Name = "lblExitososTitulo";
            this.lblExitososTitulo.Size = new System.Drawing.Size(129, 23);
            this.lblExitososTitulo.TabIndex = 1;
            this.lblExitososTitulo.Text = "Accesos exitosos";
            //
            // pnlExitososBarra
            //
            this.pnlExitososBarra.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.pnlExitososBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExitososBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlExitososBarra.Name = "pnlExitososBarra";
            this.pnlExitososBarra.Size = new System.Drawing.Size(230, 5);
            this.pnlExitososBarra.TabIndex = 0;
            //
            // pnlTarjetaFallidos
            //
            this.pnlTarjetaFallidos.BackColor = System.Drawing.Color.White;
            this.pnlTarjetaFallidos.Controls.Add(this.lblFallidosValor);
            this.pnlTarjetaFallidos.Controls.Add(this.lblFallidosTitulo);
            this.pnlTarjetaFallidos.Controls.Add(this.pnlFallidosBarra);
            this.pnlTarjetaFallidos.Location = new System.Drawing.Point(492, 3);
            this.pnlTarjetaFallidos.Margin = new System.Windows.Forms.Padding(0, 3, 16, 3);
            this.pnlTarjetaFallidos.Name = "pnlTarjetaFallidos";
            this.pnlTarjetaFallidos.Size = new System.Drawing.Size(230, 108);
            this.pnlTarjetaFallidos.TabIndex = 2;
            //
            // lblFallidosValor
            //
            this.lblFallidosValor.AutoSize = true;
            this.lblFallidosValor.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblFallidosValor.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.lblFallidosValor.Location = new System.Drawing.Point(12, 40);
            this.lblFallidosValor.Name = "lblFallidosValor";
            this.lblFallidosValor.Size = new System.Drawing.Size(48, 60);
            this.lblFallidosValor.TabIndex = 2;
            this.lblFallidosValor.Text = "0";
            //
            // lblFallidosTitulo
            //
            this.lblFallidosTitulo.AutoSize = true;
            this.lblFallidosTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFallidosTitulo.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblFallidosTitulo.Location = new System.Drawing.Point(16, 16);
            this.lblFallidosTitulo.Name = "lblFallidosTitulo";
            this.lblFallidosTitulo.Size = new System.Drawing.Size(121, 23);
            this.lblFallidosTitulo.TabIndex = 1;
            this.lblFallidosTitulo.Text = "Accesos fallidos";
            //
            // pnlFallidosBarra
            //
            this.pnlFallidosBarra.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.pnlFallidosBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFallidosBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlFallidosBarra.Name = "pnlFallidosBarra";
            this.pnlFallidosBarra.Size = new System.Drawing.Size(230, 5);
            this.pnlFallidosBarra.TabIndex = 0;
            //
            // pnlInferior
            //
            this.pnlInferior.Controls.Add(this.pnlRelojGrande);
            this.pnlInferior.Controls.Add(this.pnlUltimos);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInferior.Location = new System.Drawing.Point(0, 190);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlInferior.Size = new System.Drawing.Size(780, 346);
            this.pnlInferior.TabIndex = 3;
            //
            // pnlRelojGrande
            //
            this.pnlRelojGrande.Controls.Add(this.lblHoraGrande);
            this.pnlRelojGrande.Controls.Add(this.lblFechaGrande);
            this.pnlRelojGrande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRelojGrande.Location = new System.Drawing.Point(400, 8);
            this.pnlRelojGrande.Name = "pnlRelojGrande";
            this.pnlRelojGrande.Size = new System.Drawing.Size(380, 338);
            this.pnlRelojGrande.TabIndex = 1;
            //
            // lblHoraGrande
            //
            this.lblHoraGrande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoraGrande.Font = new System.Drawing.Font("Segoe UI Light", 36F);
            this.lblHoraGrande.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.lblHoraGrande.Location = new System.Drawing.Point(0, 0);
            this.lblHoraGrande.Name = "lblHoraGrande";
            this.lblHoraGrande.Size = new System.Drawing.Size(380, 188);
            this.lblHoraGrande.TabIndex = 0;
            this.lblHoraGrande.Text = "00:00:00";
            this.lblHoraGrande.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //
            // lblFechaGrande
            //
            this.lblFechaGrande.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFechaGrande.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblFechaGrande.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblFechaGrande.Location = new System.Drawing.Point(0, 188);
            this.lblFechaGrande.Name = "lblFechaGrande";
            this.lblFechaGrande.Size = new System.Drawing.Size(380, 150);
            this.lblFechaGrande.TabIndex = 1;
            this.lblFechaGrande.Text = "Fecha";
            this.lblFechaGrande.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // pnlUltimos
            //
            this.pnlUltimos.BackColor = System.Drawing.Color.White;
            this.pnlUltimos.Controls.Add(this.dgvUltimos);
            this.pnlUltimos.Controls.Add(this.lblUltimos);
            this.pnlUltimos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUltimos.Location = new System.Drawing.Point(0, 8);
            this.pnlUltimos.Name = "pnlUltimos";
            this.pnlUltimos.Padding = new System.Windows.Forms.Padding(12);
            this.pnlUltimos.Size = new System.Drawing.Size(400, 338);
            this.pnlUltimos.TabIndex = 0;
            //
            // dgvUltimos
            //
            this.dgvUltimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colUsuario,
            this.colResultado});
            this.dgvUltimos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUltimos.Location = new System.Drawing.Point(12, 42);
            this.dgvUltimos.Name = "dgvUltimos";
            this.dgvUltimos.Size = new System.Drawing.Size(376, 284);
            this.dgvUltimos.TabIndex = 1;
            //
            // colFecha
            //
            this.colFecha.DataPropertyName = "Fecha";
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 145;
            //
            // colUsuario
            //
            this.colUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUsuario.DataPropertyName = "Usuario";
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            //
            // colResultado
            //
            this.colResultado.DataPropertyName = "Resultado";
            this.colResultado.HeaderText = "Resultado";
            this.colResultado.Name = "colResultado";
            this.colResultado.Width = 95;
            //
            // lblUltimos
            //
            this.lblUltimos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUltimos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUltimos.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblUltimos.Location = new System.Drawing.Point(12, 12);
            this.lblUltimos.Name = "lblUltimos";
            this.lblUltimos.Size = new System.Drawing.Size(376, 30);
            this.lblUltimos.TabIndex = 0;
            this.lblUltimos.Text = "Últimos accesos";
            //
            // timerReloj
            //
            this.timerReloj.Interval = 1000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            //
            // UcInicio
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.flpTarjetas);
            this.Controls.Add(this.lblSumario);
            this.Controls.Add(this.lblSaludo);
            this.Name = "UcInicio";
            this.Size = new System.Drawing.Size(780, 536);
            this.Load += new System.EventHandler(this.UcInicio_Load);
            this.flpTarjetas.ResumeLayout(false);
            this.pnlTarjetaUsuarios.ResumeLayout(false);
            this.pnlTarjetaUsuarios.PerformLayout();
            this.pnlTarjetaExitosos.ResumeLayout(false);
            this.pnlTarjetaExitosos.PerformLayout();
            this.pnlTarjetaFallidos.ResumeLayout(false);
            this.pnlTarjetaFallidos.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            this.pnlRelojGrande.ResumeLayout(false);
            this.pnlUltimos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblSumario;
        private System.Windows.Forms.FlowLayoutPanel flpTarjetas;
        private System.Windows.Forms.Panel pnlTarjetaUsuarios;
        private System.Windows.Forms.Label lblUsuariosValor;
        private System.Windows.Forms.Label lblUsuariosTitulo;
        private System.Windows.Forms.Panel pnlUsuariosBarra;
        private System.Windows.Forms.Panel pnlTarjetaExitosos;
        private System.Windows.Forms.Label lblExitososValor;
        private System.Windows.Forms.Label lblExitososTitulo;
        private System.Windows.Forms.Panel pnlExitososBarra;
        private System.Windows.Forms.Panel pnlTarjetaFallidos;
        private System.Windows.Forms.Label lblFallidosValor;
        private System.Windows.Forms.Label lblFallidosTitulo;
        private System.Windows.Forms.Panel pnlFallidosBarra;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel pnlRelojGrande;
        private System.Windows.Forms.Label lblHoraGrande;
        private System.Windows.Forms.Label lblFechaGrande;
        private System.Windows.Forms.Panel pnlUltimos;
        private System.Windows.Forms.DataGridView dgvUltimos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultado;
        private System.Windows.Forms.Label lblUltimos;
        private System.Windows.Forms.Timer timerReloj;
    }
}
