namespace Facturación
{
    partial class frmlogin
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
            this.grbImagen = new System.Windows.Forms.GroupBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.ckbOcultar = new System.Windows.Forms.CheckBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.grbImagen.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbImagen
            // 
            this.grbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbImagen.Controls.Add(this.grpLogin);
            this.grbImagen.Location = new System.Drawing.Point(-3, -8);
            this.grbImagen.Name = "grbImagen";
            this.grbImagen.Size = new System.Drawing.Size(385, 412);
            this.grbImagen.TabIndex = 0;
            this.grbImagen.TabStop = false;
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.Transparent;
            this.grpLogin.Controls.Add(this.ckbOcultar);
            this.grpLogin.Controls.Add(this.lblBienvenido);
            this.grpLogin.Controls.Add(this.btnConfirmar);
            this.grpLogin.Controls.Add(this.lblUsuario);
            this.grpLogin.Controls.Add(this.bntCancelar);
            this.grpLogin.Controls.Add(this.txtUsuario);
            this.grpLogin.Controls.Add(this.txtContraseña);
            this.grpLogin.Controls.Add(this.lblContraseña);
            this.grpLogin.Location = new System.Drawing.Point(35, 37);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(308, 335);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            // 
            // ckbOcultar
            // 
            this.ckbOcultar.AutoSize = true;
            this.ckbOcultar.BackColor = System.Drawing.Color.Transparent;
            this.ckbOcultar.Location = new System.Drawing.Point(99, 205);
            this.ckbOcultar.Name = "ckbOcultar";
            this.ckbOcultar.Size = new System.Drawing.Size(117, 17);
            this.ckbOcultar.TabIndex = 15;
            this.ckbOcultar.Text = "Mostrar contraseña";
            this.ckbOcultar.UseVisualStyleBackColor = false;
            this.ckbOcultar.UseWaitCursor = true;
            this.ckbOcultar.CheckedChanged += new System.EventHandler(this.ckbOcultar_CheckedChanged);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(82, 23);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(136, 28);
            this.lblBienvenido.TabIndex = 8;
            this.lblBienvenido.Text = "¡Bienvenido!";
            this.lblBienvenido.UseWaitCursor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(174, 251);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(119, 33);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.UseWaitCursor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(109, 60);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(81, 25);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.UseWaitCursor = true;
            // 
            // bntCancelar
            // 
            this.bntCancelar.BackColor = System.Drawing.Color.Transparent;
            this.bntCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCancelar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancelar.Location = new System.Drawing.Point(21, 251);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(119, 33);
            this.bntCancelar.TabIndex = 13;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = false;
            this.bntCancelar.UseWaitCursor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(99, 88);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(108, 29);
            this.txtUsuario.TabIndex = 10;
            this.txtUsuario.UseWaitCursor = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(99, 170);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(108, 29);
            this.txtContraseña.TabIndex = 12;
            this.txtContraseña.UseWaitCursor = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(94, 140);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(113, 25);
            this.lblContraseña.TabIndex = 11;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.UseWaitCursor = true;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 398);
            this.Controls.Add(this.grbImagen);
            this.Name = "frmlogin";
            this.Text = "Inicio sesión";
            this.grbImagen.ResumeLayout(false);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbImagen;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.CheckBox ckbOcultar;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
    }
}

