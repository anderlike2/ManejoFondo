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
            this.loginPicture = new System.Windows.Forms.PictureBox();
            this.loginPanelDerecho = new System.Windows.Forms.Panel();
            this.loginPanelLineaPassword = new System.Windows.Forms.Panel();
            this.loginPanelLineUsername = new System.Windows.Forms.Panel();
            this.loginButtonAceptar = new System.Windows.Forms.Button();
            this.loginTextBoxPassword = new System.Windows.Forms.TextBox();
            this.loginTextBoxUsername = new System.Windows.Forms.TextBox();
            this.loginLabelPassword = new System.Windows.Forms.Label();
            this.loginLabelUsername = new System.Windows.Forms.Label();
            this.loginPanelLinea = new System.Windows.Forms.Panel();
            this.loginLabelAhorra = new System.Windows.Forms.Label();
            this.loginLabelInicioSesion = new System.Windows.Forms.Label();
            this.loginLabelObligUsername = new System.Windows.Forms.Label();
            this.loginLabelObligPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
            this.loginPanelDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPicture
            // 
            this.loginPicture.BackColor = System.Drawing.Color.Transparent;
            this.loginPicture.BackgroundImage = global::ManejoFondo.Properties.Resources.loginLogo;
            this.loginPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPicture.Location = new System.Drawing.Point(165, 12);
            this.loginPicture.Name = "loginPicture";
            this.loginPicture.Size = new System.Drawing.Size(139, 111);
            this.loginPicture.TabIndex = 2;
            this.loginPicture.TabStop = false;
            // 
            // loginPanelDerecho
            // 
            this.loginPanelDerecho.BackgroundImage = global::ManejoFondo.Properties.Resources.loginBackground;
            this.loginPanelDerecho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPanelDerecho.Controls.Add(this.loginLabelObligPassword);
            this.loginPanelDerecho.Controls.Add(this.loginLabelObligUsername);
            this.loginPanelDerecho.Controls.Add(this.loginPanelLineaPassword);
            this.loginPanelDerecho.Controls.Add(this.loginPanelLineUsername);
            this.loginPanelDerecho.Controls.Add(this.loginButtonAceptar);
            this.loginPanelDerecho.Controls.Add(this.loginTextBoxPassword);
            this.loginPanelDerecho.Controls.Add(this.loginTextBoxUsername);
            this.loginPanelDerecho.Controls.Add(this.loginLabelPassword);
            this.loginPanelDerecho.Controls.Add(this.loginLabelUsername);
            this.loginPanelDerecho.Location = new System.Drawing.Point(-1, 203);
            this.loginPanelDerecho.Name = "loginPanelDerecho";
            this.loginPanelDerecho.Size = new System.Drawing.Size(470, 260);
            this.loginPanelDerecho.TabIndex = 1;
            // 
            // loginPanelLineaPassword
            // 
            this.loginPanelLineaPassword.BackColor = System.Drawing.Color.Transparent;
            this.loginPanelLineaPassword.Location = new System.Drawing.Point(99, 155);
            this.loginPanelLineaPassword.Name = "loginPanelLineaPassword";
            this.loginPanelLineaPassword.Size = new System.Drawing.Size(253, 2);
            this.loginPanelLineaPassword.TabIndex = 6;
            // 
            // loginPanelLineUsername
            // 
            this.loginPanelLineUsername.BackColor = System.Drawing.Color.Transparent;
            this.loginPanelLineUsername.Location = new System.Drawing.Point(99, 90);
            this.loginPanelLineUsername.Name = "loginPanelLineUsername";
            this.loginPanelLineUsername.Size = new System.Drawing.Size(253, 2);
            this.loginPanelLineUsername.TabIndex = 5;
            // 
            // loginButtonAceptar
            // 
            this.loginButtonAceptar.BackColor = System.Drawing.Color.White;
            this.loginButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButtonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButtonAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(112)))));
            this.loginButtonAceptar.Location = new System.Drawing.Point(103, 184);
            this.loginButtonAceptar.Name = "loginButtonAceptar";
            this.loginButtonAceptar.Size = new System.Drawing.Size(253, 39);
            this.loginButtonAceptar.TabIndex = 6;
            this.loginButtonAceptar.Text = "Aceptar";
            this.loginButtonAceptar.UseVisualStyleBackColor = false;
            this.loginButtonAceptar.Click += new System.EventHandler(this.Login);
            // 
            // loginTextBoxPassword
            // 
            this.loginTextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.loginTextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTextBoxPassword.Location = new System.Drawing.Point(99, 129);
            this.loginTextBoxPassword.Name = "loginTextBoxPassword";
            this.loginTextBoxPassword.PasswordChar = '*';
            this.loginTextBoxPassword.Size = new System.Drawing.Size(253, 19);
            this.loginTextBoxPassword.TabIndex = 5;
            // 
            // loginTextBoxUsername
            // 
            this.loginTextBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.loginTextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTextBoxUsername.Location = new System.Drawing.Point(99, 67);
            this.loginTextBoxUsername.Name = "loginTextBoxUsername";
            this.loginTextBoxUsername.Size = new System.Drawing.Size(253, 19);
            this.loginTextBoxUsername.TabIndex = 4;
            // 
            // loginLabelPassword
            // 
            this.loginLabelPassword.AutoSize = true;
            this.loginLabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.loginLabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelPassword.ForeColor = System.Drawing.Color.Black;
            this.loginLabelPassword.Location = new System.Drawing.Point(269, 106);
            this.loginLabelPassword.Name = "loginLabelPassword";
            this.loginLabelPassword.Size = new System.Drawing.Size(78, 20);
            this.loginLabelPassword.TabIndex = 3;
            this.loginLabelPassword.Text = "Password";
            // 
            // loginLabelUsername
            // 
            this.loginLabelUsername.AutoSize = true;
            this.loginLabelUsername.BackColor = System.Drawing.Color.Transparent;
            this.loginLabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelUsername.ForeColor = System.Drawing.Color.Black;
            this.loginLabelUsername.Location = new System.Drawing.Point(269, 44);
            this.loginLabelUsername.Name = "loginLabelUsername";
            this.loginLabelUsername.Size = new System.Drawing.Size(83, 20);
            this.loginLabelUsername.TabIndex = 2;
            this.loginLabelUsername.Text = "Username";
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
            // loginLabelAhorra
            // 
            this.loginLabelAhorra.AutoSize = true;
            this.loginLabelAhorra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelAhorra.Location = new System.Drawing.Point(227, 129);
            this.loginLabelAhorra.Name = "loginLabelAhorra";
            this.loginLabelAhorra.Size = new System.Drawing.Size(128, 16);
            this.loginLabelAhorra.TabIndex = 4;
            this.loginLabelAhorra.Text = "Ahorra con nosotros";
            // 
            // loginLabelInicioSesion
            // 
            this.loginLabelInicioSesion.AutoSize = true;
            this.loginLabelInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.loginLabelInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelInicioSesion.Location = new System.Drawing.Point(148, 176);
            this.loginLabelInicioSesion.Name = "loginLabelInicioSesion";
            this.loginLabelInicioSesion.Size = new System.Drawing.Size(164, 24);
            this.loginLabelInicioSesion.TabIndex = 4;
            this.loginLabelInicioSesion.Text = "INICIAR SESIÓN";
            // 
            // loginLabelObligUsername
            // 
            this.loginLabelObligUsername.AutoSize = true;
            this.loginLabelObligUsername.BackColor = System.Drawing.Color.Transparent;
            this.loginLabelObligUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelObligUsername.ForeColor = System.Drawing.Color.Red;
            this.loginLabelObligUsername.Location = new System.Drawing.Point(260, 49);
            this.loginLabelObligUsername.Name = "loginLabelObligUsername";
            this.loginLabelObligUsername.Size = new System.Drawing.Size(14, 16);
            this.loginLabelObligUsername.TabIndex = 7;
            this.loginLabelObligUsername.Text = "*";
            // 
            // loginLabelObligPassword
            // 
            this.loginLabelObligPassword.AutoSize = true;
            this.loginLabelObligPassword.BackColor = System.Drawing.Color.Transparent;
            this.loginLabelObligPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelObligPassword.ForeColor = System.Drawing.Color.Red;
            this.loginLabelObligPassword.Location = new System.Drawing.Point(260, 110);
            this.loginLabelObligPassword.Name = "loginLabelObligPassword";
            this.loginLabelObligPassword.Size = new System.Drawing.Size(14, 16);
            this.loginLabelObligPassword.TabIndex = 8;
            this.loginLabelObligPassword.Text = "*";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 459);
            this.Controls.Add(this.loginLabelInicioSesion);
            this.Controls.Add(this.loginLabelAhorra);
            this.Controls.Add(this.loginPicture);
            this.Controls.Add(this.loginPanelDerecho);
            this.Controls.Add(this.loginPanelLinea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
            this.loginPanelDerecho.ResumeLayout(false);
            this.loginPanelDerecho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel loginPanelDerecho;
        private System.Windows.Forms.Label loginLabelPassword;
        private System.Windows.Forms.Label loginLabelUsername;
        private System.Windows.Forms.Panel loginPanelLinea;
        private System.Windows.Forms.PictureBox loginPicture;
        private System.Windows.Forms.Button loginButtonAceptar;
        private System.Windows.Forms.TextBox loginTextBoxPassword;
        private System.Windows.Forms.TextBox loginTextBoxUsername;
        private System.Windows.Forms.Label loginLabelAhorra;
        private System.Windows.Forms.Label loginLabelInicioSesion;
        private System.Windows.Forms.Panel loginPanelLineaPassword;
        private System.Windows.Forms.Panel loginPanelLineUsername;
        private System.Windows.Forms.Label loginLabelObligPassword;
        private System.Windows.Forms.Label loginLabelObligUsername;
    }
}

