namespace Presentacion.Modulos
{
    partial class UcUsuarios
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
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtConfirmacion = new System.Windows.Forms.TextBox();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.lblRegistroAyuda = new System.Windows.Forms.Label();
            this.lblRegistroTitulo = new System.Windows.Forms.Label();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLista = new System.Windows.Forms.Label();
            this.pnlRegistro.SuspendLayout();
            this.pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            //
            // pnlRegistro
            //
            this.pnlRegistro.BackColor = System.Drawing.Color.White;
            this.pnlRegistro.Controls.Add(this.btnRegistrar);
            this.pnlRegistro.Controls.Add(this.txtConfirmacion);
            this.pnlRegistro.Controls.Add(this.lblConfirmacion);
            this.pnlRegistro.Controls.Add(this.txtPassword);
            this.pnlRegistro.Controls.Add(this.lblPassword);
            this.pnlRegistro.Controls.Add(this.txtNombreCompleto);
            this.pnlRegistro.Controls.Add(this.lblNombreCompleto);
            this.pnlRegistro.Controls.Add(this.txtNuevoUsuario);
            this.pnlRegistro.Controls.Add(this.lblNuevoUsuario);
            this.pnlRegistro.Controls.Add(this.lblRegistroAyuda);
            this.pnlRegistro.Controls.Add(this.lblRegistroTitulo);
            this.pnlRegistro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRegistro.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(320, 536);
            this.pnlRegistro.TabIndex = 0;
            //
            // btnRegistrar
            //
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(20, 356);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(280, 44);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "  Registrar usuario";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            //
            // txtConfirmacion
            //
            this.txtConfirmacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmacion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmacion.Location = new System.Drawing.Point(20, 306);
            this.txtConfirmacion.MaxLength = 72;
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(280, 32);
            this.txtConfirmacion.TabIndex = 3;
            this.txtConfirmacion.UseSystemPasswordChar = true;
            //
            // lblConfirmacion
            //
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmacion.Location = new System.Drawing.Point(18, 284);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(155, 20);
            this.lblConfirmacion.TabIndex = 10;
            this.lblConfirmacion.Text = "Confirmar contraseña";
            //
            // txtPassword
            //
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(20, 242);
            this.txtPassword.MaxLength = 72;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 32);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(18, 220);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(196, 20);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Contraseña (mínimo 6 caracteres)";
            //
            // txtNombreCompleto
            //
            this.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreCompleto.Location = new System.Drawing.Point(20, 178);
            this.txtNombreCompleto.MaxLength = 100;
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(280, 32);
            this.txtNombreCompleto.TabIndex = 1;
            //
            // lblNombreCompleto
            //
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreCompleto.Location = new System.Drawing.Point(18, 156);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(126, 20);
            this.lblNombreCompleto.TabIndex = 8;
            this.lblNombreCompleto.Text = "Nombre completo";
            //
            // txtNuevoUsuario
            //
            this.txtNuevoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNuevoUsuario.Location = new System.Drawing.Point(20, 114);
            this.txtNuevoUsuario.MaxLength = 50;
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(280, 32);
            this.txtNuevoUsuario.TabIndex = 0;
            //
            // lblNuevoUsuario
            //
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNuevoUsuario.Location = new System.Drawing.Point(18, 92);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(134, 20);
            this.lblNuevoUsuario.TabIndex = 7;
            this.lblNuevoUsuario.Text = "Nombre de usuario";
            //
            // lblRegistroAyuda
            //
            this.lblRegistroAyuda.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRegistroAyuda.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblRegistroAyuda.Location = new System.Drawing.Point(18, 48);
            this.lblRegistroAyuda.Name = "lblRegistroAyuda";
            this.lblRegistroAyuda.Size = new System.Drawing.Size(284, 38);
            this.lblRegistroAyuda.TabIndex = 6;
            this.lblRegistroAyuda.Text = "La contraseña se convierte en un hash BCrypt (IHashService). Solo se guarda el hash.";
            //
            // lblRegistroTitulo
            //
            this.lblRegistroTitulo.AutoSize = true;
            this.lblRegistroTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblRegistroTitulo.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblRegistroTitulo.Location = new System.Drawing.Point(16, 16);
            this.lblRegistroTitulo.Name = "lblRegistroTitulo";
            this.lblRegistroTitulo.Size = new System.Drawing.Size(181, 30);
            this.lblRegistroTitulo.TabIndex = 5;
            this.lblRegistroTitulo.Text = "Registrar usuario";
            //
            // pnlSeparador
            //
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSeparador.Location = new System.Drawing.Point(320, 0);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(16, 536);
            this.pnlSeparador.TabIndex = 1;
            //
            // pnlLista
            //
            this.pnlLista.BackColor = System.Drawing.Color.White;
            this.pnlLista.Controls.Add(this.dgvUsuarios);
            this.pnlLista.Controls.Add(this.lblLista);
            this.pnlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLista.Location = new System.Drawing.Point(336, 0);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Padding = new System.Windows.Forms.Padding(12);
            this.pnlLista.Size = new System.Drawing.Size(444, 536);
            this.pnlLista.TabIndex = 2;
            //
            // dgvUsuarios
            //
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colUsuario,
            this.colNombre,
            this.colHash,
            this.colFecha});
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 42);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(420, 482);
            this.dgvUsuarios.TabIndex = 1;
            //
            // colId
            //
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 45;
            //
            // colUsuario
            //
            this.colUsuario.DataPropertyName = "Usuario";
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Width = 95;
            //
            // colNombre
            //
            this.colNombre.DataPropertyName = "NombreCompleto";
            this.colNombre.HeaderText = "Nombre completo";
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 170;
            //
            // colHash
            //
            this.colHash.DataPropertyName = "Hash";
            this.colHash.HeaderText = "Hash BCrypt guardado en la BD";
            this.colHash.Name = "colHash";
            this.colHash.Width = 430;
            //
            // colFecha
            //
            this.colFecha.DataPropertyName = "FechaRegistro";
            this.colFecha.HeaderText = "Registrado";
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 145;
            //
            // lblLista
            //
            this.lblLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLista.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblLista.Location = new System.Drawing.Point(12, 12);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(420, 30);
            this.lblLista.TabIndex = 0;
            this.lblLista.Text = "Usuarios registrados (solo se guarda el hash)";
            //
            // UcUsuarios
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.pnlLista);
            this.Controls.Add(this.pnlSeparador);
            this.Controls.Add(this.pnlRegistro);
            this.Name = "UcUsuarios";
            this.Size = new System.Drawing.Size(780, 536);
            this.Load += new System.EventHandler(this.UcUsuarios_Load);
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Label lblRegistroTitulo;
        private System.Windows.Forms.Label lblRegistroAyuda;
        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.TextBox txtConfirmacion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
    }
}
