namespace Presentacion.Formularios
{
    partial class FrmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlSesion = new System.Windows.Forms.Panel();
            this.lblSesionDesde = new System.Windows.Forms.Label();
            this.lblSesionCuenta = new System.Windows.Forms.Label();
            this.lblSesionNombre = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogoSubtitulo = new System.Windows.Forms.Label();
            this.lblLogoTitulo = new System.Windows.Forms.Label();
            this.lblLogoIcono = new System.Windows.Forms.Label();
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.lblTituloModulo = new System.Windows.Forms.Label();
            this.pnlReloj = new System.Windows.Forms.Panel();
            this.lblHoraBarra = new System.Windows.Forms.Label();
            this.lblFechaBarra = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlLineaBarra = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlSesion.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlBarraSuperior.SuspendLayout();
            this.pnlReloj.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlMenu
            //
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnHistorial);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.pnlSesion);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 640);
            this.pnlMenu.TabIndex = 0;
            //
            // btnCerrarSesion
            //
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 480);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(240, 50);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "   Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            //
            // btnHistorial
            //
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(0, 200);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnHistorial.Size = new System.Drawing.Size(240, 50);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.Text = "   Historial de accesos";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            //
            // btnUsuarios
            //
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 150);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(240, 50);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "   Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            //
            // btnInicio
            //
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 100);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(240, 50);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "   Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            //
            // pnlSesion
            //
            this.pnlSesion.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlSesion.Controls.Add(this.lblSesionDesde);
            this.pnlSesion.Controls.Add(this.lblSesionCuenta);
            this.pnlSesion.Controls.Add(this.lblSesionNombre);
            this.pnlSesion.Controls.Add(this.lblAvatar);
            this.pnlSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSesion.Location = new System.Drawing.Point(0, 530);
            this.pnlSesion.Name = "pnlSesion";
            this.pnlSesion.Size = new System.Drawing.Size(240, 110);
            this.pnlSesion.TabIndex = 4;
            //
            // lblSesionDesde
            //
            this.lblSesionDesde.AutoEllipsis = true;
            this.lblSesionDesde.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSesionDesde.ForeColor = System.Drawing.Color.FromArgb(187, 222, 251);
            this.lblSesionDesde.Location = new System.Drawing.Point(74, 80);
            this.lblSesionDesde.Name = "lblSesionDesde";
            this.lblSesionDesde.Size = new System.Drawing.Size(160, 18);
            this.lblSesionDesde.TabIndex = 3;
            this.lblSesionDesde.Text = "Sesión desde:";
            //
            // lblSesionCuenta
            //
            this.lblSesionCuenta.AutoEllipsis = true;
            this.lblSesionCuenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSesionCuenta.ForeColor = System.Drawing.Color.FromArgb(187, 222, 251);
            this.lblSesionCuenta.Location = new System.Drawing.Point(74, 60);
            this.lblSesionCuenta.Name = "lblSesionCuenta";
            this.lblSesionCuenta.Size = new System.Drawing.Size(160, 20);
            this.lblSesionCuenta.TabIndex = 2;
            this.lblSesionCuenta.Text = "@usuario";
            //
            // lblSesionNombre
            //
            this.lblSesionNombre.AutoEllipsis = true;
            this.lblSesionNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSesionNombre.ForeColor = System.Drawing.Color.White;
            this.lblSesionNombre.Location = new System.Drawing.Point(74, 14);
            this.lblSesionNombre.Name = "lblSesionNombre";
            this.lblSesionNombre.Size = new System.Drawing.Size(160, 46);
            this.lblSesionNombre.TabIndex = 1;
            this.lblSesionNombre.Text = "Nombre del usuario";
            this.lblSesionNombre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblAvatar
            //
            this.lblAvatar.BackColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.lblAvatar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20F);
            this.lblAvatar.ForeColor = System.Drawing.Color.White;
            this.lblAvatar.Location = new System.Drawing.Point(16, 31);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(48, 48);
            this.lblAvatar.TabIndex = 0;
            this.lblAvatar.Text = "";
            this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlLogo
            //
            this.pnlLogo.Controls.Add(this.lblLogoSubtitulo);
            this.pnlLogo.Controls.Add(this.lblLogoTitulo);
            this.pnlLogo.Controls.Add(this.lblLogoIcono);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(240, 100);
            this.pnlLogo.TabIndex = 5;
            //
            // lblLogoSubtitulo
            //
            this.lblLogoSubtitulo.AutoSize = true;
            this.lblLogoSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLogoSubtitulo.ForeColor = System.Drawing.Color.FromArgb(187, 222, 251);
            this.lblLogoSubtitulo.Location = new System.Drawing.Point(72, 56);
            this.lblLogoSubtitulo.Name = "lblLogoSubtitulo";
            this.lblLogoSubtitulo.Size = new System.Drawing.Size(140, 20);
            this.lblLogoSubtitulo.TabIndex = 2;
            this.lblLogoSubtitulo.Text = "Parcial 3 · Capas + MVP";
            //
            // lblLogoTitulo
            //
            this.lblLogoTitulo.AutoSize = true;
            this.lblLogoTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblLogoTitulo.ForeColor = System.Drawing.Color.White;
            this.lblLogoTitulo.Location = new System.Drawing.Point(68, 22);
            this.lblLogoTitulo.Name = "lblLogoTitulo";
            this.lblLogoTitulo.Size = new System.Drawing.Size(141, 35);
            this.lblLogoTitulo.TabIndex = 1;
            this.lblLogoTitulo.Text = "LoginBCrypt";
            //
            // lblLogoIcono
            //
            this.lblLogoIcono.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F);
            this.lblLogoIcono.ForeColor = System.Drawing.Color.White;
            this.lblLogoIcono.Location = new System.Drawing.Point(14, 26);
            this.lblLogoIcono.Name = "lblLogoIcono";
            this.lblLogoIcono.Size = new System.Drawing.Size(52, 48);
            this.lblLogoIcono.TabIndex = 0;
            this.lblLogoIcono.Text = "";
            this.lblLogoIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlBarraSuperior
            //
            this.pnlBarraSuperior.BackColor = System.Drawing.Color.White;
            this.pnlBarraSuperior.Controls.Add(this.lblTituloModulo);
            this.pnlBarraSuperior.Controls.Add(this.pnlReloj);
            this.pnlBarraSuperior.Controls.Add(this.btnMinimizar);
            this.pnlBarraSuperior.Controls.Add(this.btnMaximizar);
            this.pnlBarraSuperior.Controls.Add(this.btnCerrar);
            this.pnlBarraSuperior.Controls.Add(this.pnlLineaBarra);
            this.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSuperior.Location = new System.Drawing.Point(240, 0);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Size = new System.Drawing.Size(820, 64);
            this.pnlBarraSuperior.TabIndex = 1;
            //
            // lblTituloModulo
            //
            this.lblTituloModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloModulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloModulo.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTituloModulo.Location = new System.Drawing.Point(0, 0);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTituloModulo.Size = new System.Drawing.Size(382, 63);
            this.lblTituloModulo.TabIndex = 0;
            this.lblTituloModulo.Text = "Inicio";
            this.lblTituloModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloModulo.DoubleClick += new System.EventHandler(this.lblTituloModulo_DoubleClick);
            //
            // pnlReloj
            //
            this.pnlReloj.Controls.Add(this.lblHoraBarra);
            this.pnlReloj.Controls.Add(this.lblFechaBarra);
            this.pnlReloj.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlReloj.Location = new System.Drawing.Point(382, 0);
            this.pnlReloj.Name = "pnlReloj";
            this.pnlReloj.Padding = new System.Windows.Forms.Padding(0, 8, 18, 8);
            this.pnlReloj.Size = new System.Drawing.Size(300, 63);
            this.pnlReloj.TabIndex = 1;
            //
            // lblHoraBarra
            //
            this.lblHoraBarra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoraBarra.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblHoraBarra.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblHoraBarra.Location = new System.Drawing.Point(0, 8);
            this.lblHoraBarra.Name = "lblHoraBarra";
            this.lblHoraBarra.Size = new System.Drawing.Size(282, 27);
            this.lblHoraBarra.TabIndex = 0;
            this.lblHoraBarra.Text = "00:00:00";
            this.lblHoraBarra.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            //
            // lblFechaBarra
            //
            this.lblFechaBarra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFechaBarra.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaBarra.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblFechaBarra.Location = new System.Drawing.Point(0, 35);
            this.lblFechaBarra.Name = "lblFechaBarra";
            this.lblFechaBarra.Size = new System.Drawing.Size(282, 20);
            this.lblFechaBarra.TabIndex = 1;
            this.lblFechaBarra.Text = "Fecha";
            this.lblFechaBarra.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // btnMinimizar
            //
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F);
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.btnMinimizar.Location = new System.Drawing.Point(682, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(46, 63);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Text = "";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            //
            // btnMaximizar
            //
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F);
            this.btnMaximizar.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.btnMaximizar.Location = new System.Drawing.Point(728, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(46, 63);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Text = "";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            //
            // btnCerrar
            //
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 17, 35);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.btnCerrar.Location = new System.Drawing.Point(774, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(46, 63);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            //
            // pnlLineaBarra
            //
            this.pnlLineaBarra.BackColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.pnlLineaBarra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineaBarra.Location = new System.Drawing.Point(0, 63);
            this.pnlLineaBarra.Name = "pnlLineaBarra";
            this.pnlLineaBarra.Size = new System.Drawing.Size(820, 1);
            this.pnlLineaBarra.TabIndex = 5;
            //
            // pnlContenido
            //
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(240, 64);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContenido.Size = new System.Drawing.Size(820, 576);
            this.pnlContenido.TabIndex = 2;
            //
            // timerReloj
            //
            this.timerReloj.Interval = 1000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            //
            // FrmPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 640);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginBCrypt - Menú principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlSesion.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlBarraSuperior.ResumeLayout(false);
            this.pnlReloj.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogoIcono;
        private System.Windows.Forms.Label lblLogoTitulo;
        private System.Windows.Forms.Label lblLogoSubtitulo;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlSesion;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblSesionNombre;
        private System.Windows.Forms.Label lblSesionCuenta;
        private System.Windows.Forms.Label lblSesionDesde;
        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.Label lblTituloModulo;
        private System.Windows.Forms.Panel pnlReloj;
        private System.Windows.Forms.Label lblHoraBarra;
        private System.Windows.Forms.Label lblFechaBarra;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlLineaBarra;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Timer timerReloj;
    }
}
