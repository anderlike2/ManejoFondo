namespace ManejoFondo
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.loginPanelLinea = new System.Windows.Forms.Panel();
            this.loginLabelBienvenido = new System.Windows.Forms.Label();
            this.loginLabelInicioSesion = new System.Windows.Forms.Label();
            this.loginButtonAceptar = new System.Windows.Forms.Button();
            this.loginPanelDerecho = new System.Windows.Forms.Panel();
            this.linkLabelOlvidoPassword = new System.Windows.Forms.LinkLabel();
            this.linkLabelCrearUsuario = new System.Windows.Forms.LinkLabel();
            this.labelVerPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginPicture = new System.Windows.Forms.PictureBox();
            this.loginPanelDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanelLinea
            // 
            this.loginPanelLinea.AutoScroll = true;
            this.loginPanelLinea.BackColor = System.Drawing.Color.Black;
            this.loginPanelLinea.Location = new System.Drawing.Point(98, 124);
            this.loginPanelLinea.Name = "loginPanelLinea";
            this.loginPanelLinea.Size = new System.Drawing.Size(253, 2);
            this.loginPanelLinea.TabIndex = 1;
            // 
            // loginLabelBienvenido
            // 
            this.loginLabelBienvenido.AutoSize = true;
            this.loginLabelBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelBienvenido.Location = new System.Drawing.Point(269, 129);
            this.loginLabelBienvenido.Name = "loginLabelBienvenido";
            this.loginLabelBienvenido.Size = new System.Drawing.Size(82, 16);
            this.loginLabelBienvenido.TabIndex = 4;
            this.loginLabelBienvenido.Text = "Bienvenid@";
            // 
            // loginLabelInicioSesion
            // 
            this.loginLabelInicioSesion.AutoSize = true;
            this.loginLabelInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.loginLabelInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelInicioSesion.Location = new System.Drawing.Point(156, 176);
            this.loginLabelInicioSesion.Name = "loginLabelInicioSesion";
            this.loginLabelInicioSesion.Size = new System.Drawing.Size(164, 24);
            this.loginLabelInicioSesion.TabIndex = 4;
            this.loginLabelInicioSesion.Text = "INICIAR SESIÓN";
            // 
            // loginButtonAceptar
            // 
            this.loginButtonAceptar.BackColor = System.Drawing.Color.White;
            this.loginButtonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButtonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButtonAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.loginButtonAceptar.Location = new System.Drawing.Point(99, 140);
            this.loginButtonAceptar.Name = "loginButtonAceptar";
            this.loginButtonAceptar.Size = new System.Drawing.Size(253, 39);
            this.loginButtonAceptar.TabIndex = 6;
            this.loginButtonAceptar.Text = "Aceptar";
            this.loginButtonAceptar.UseVisualStyleBackColor = false;
            this.loginButtonAceptar.Click += new System.EventHandler(this.Login);
            // 
            // loginPanelDerecho
            // 
            this.loginPanelDerecho.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginPanelDerecho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPanelDerecho.Controls.Add(this.linkLabelOlvidoPassword);
            this.loginPanelDerecho.Controls.Add(this.linkLabelCrearUsuario);
            this.loginPanelDerecho.Controls.Add(this.labelVerPassword);
            this.loginPanelDerecho.Controls.Add(this.label1);
            this.loginPanelDerecho.Controls.Add(this.label3);
            this.loginPanelDerecho.Controls.Add(this.textBoxPassword);
            this.loginPanelDerecho.Controls.Add(this.textBoxUsuario);
            this.loginPanelDerecho.Controls.Add(this.loginButtonAceptar);
            this.loginPanelDerecho.Location = new System.Drawing.Point(-1, 203);
            this.loginPanelDerecho.Name = "loginPanelDerecho";
            this.loginPanelDerecho.Size = new System.Drawing.Size(470, 260);
            this.loginPanelDerecho.TabIndex = 1;
            // 
            // linkLabelOlvidoPassword
            // 
            this.linkLabelOlvidoPassword.AutoSize = true;
            this.linkLabelOlvidoPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelOlvidoPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.linkLabelOlvidoPassword.Location = new System.Drawing.Point(96, 234);
            this.linkLabelOlvidoPassword.Name = "linkLabelOlvidoPassword";
            this.linkLabelOlvidoPassword.Size = new System.Drawing.Size(113, 13);
            this.linkLabelOlvidoPassword.TabIndex = 33;
            this.linkLabelOlvidoPassword.TabStop = true;
            this.linkLabelOlvidoPassword.Text = "Olvidó su contraseña?";
            // 
            // linkLabelCrearUsuario
            // 
            this.linkLabelCrearUsuario.AutoSize = true;
            this.linkLabelCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelCrearUsuario.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.linkLabelCrearUsuario.Location = new System.Drawing.Point(11, 234);
            this.linkLabelCrearUsuario.Name = "linkLabelCrearUsuario";
            this.linkLabelCrearUsuario.Size = new System.Drawing.Size(71, 13);
            this.linkLabelCrearUsuario.TabIndex = 32;
            this.linkLabelCrearUsuario.TabStop = true;
            this.linkLabelCrearUsuario.Text = "Crear Usuario";
            this.linkLabelCrearUsuario.Click += new System.EventHandler(this.CrearUsuario);
            // 
            // labelVerPassword
            // 
            this.labelVerPassword.AutoSize = true;
            this.labelVerPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVerPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.labelVerPassword.Location = new System.Drawing.Point(394, 101);
            this.labelVerPassword.Name = "labelVerPassword";
            this.labelVerPassword.Size = new System.Drawing.Size(23, 13);
            this.labelVerPassword.TabIndex = 31;
            this.labelVerPassword.Text = "Ver";
            this.labelVerPassword.MouseLeave += new System.EventHandler(this.OcultarPassword);
            this.labelVerPassword.MouseHover += new System.EventHandler(this.MostrarPassword);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(437, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(437, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxPassword.HintText = "Ingrese su contraseña";
            this.textBoxPassword.isPassword = true;
            this.textBoxPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxPassword.LineThickness = 3;
            this.textBoxPassword.Location = new System.Drawing.Point(46, 81);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(344, 33);
            this.textBoxPassword.TabIndex = 10;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPassword.OnValueChanged += new System.EventHandler(this.MascaraPassword);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxUsuario.HintText = "Ingrese su usuario";
            this.textBoxUsuario.isPassword = false;
            this.textBoxUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxUsuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxUsuario.LineThickness = 3;
            this.textBoxUsuario.Location = new System.Drawing.Point(46, 24);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(344, 33);
            this.textBoxUsuario.TabIndex = 9;
            this.textBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginPicture
            // 
            this.loginPicture.BackColor = System.Drawing.Color.Transparent;
            this.loginPicture.BackgroundImage = global::ManejoFondo.Properties.Resources.loginLogo;
            this.loginPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPicture.Location = new System.Drawing.Point(177, 7);
            this.loginPicture.Name = "loginPicture";
            this.loginPicture.Size = new System.Drawing.Size(116, 111);
            this.loginPicture.TabIndex = 2;
            this.loginPicture.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 459);
            this.Controls.Add(this.loginLabelInicioSesion);
            this.Controls.Add(this.loginLabelBienvenido);
            this.Controls.Add(this.loginPicture);
            this.Controls.Add(this.loginPanelDerecho);
            this.Controls.Add(this.loginPanelLinea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "INICIO DE SESIÓN";
            this.loginPanelDerecho.ResumeLayout(false);
            this.loginPanelDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel loginPanelLinea;
        private System.Windows.Forms.PictureBox loginPicture;
        private System.Windows.Forms.Label loginLabelBienvenido;
        private System.Windows.Forms.Label loginLabelInicioSesion;
        private System.Windows.Forms.Button loginButtonAceptar;
        private System.Windows.Forms.Panel loginPanelDerecho;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVerPassword;
        private System.Windows.Forms.LinkLabel linkLabelCrearUsuario;
        private System.Windows.Forms.LinkLabel linkLabelOlvidoPassword;
    }
}

