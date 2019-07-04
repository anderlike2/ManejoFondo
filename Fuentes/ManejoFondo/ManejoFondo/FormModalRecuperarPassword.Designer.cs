namespace ManejoFondo
{
    partial class FormModalRecuperarPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAceptarRecuperarPassword = new System.Windows.Forms.Button();
            this.labelTextoRecuperarPassword = new System.Windows.Forms.Label();
            this.labelTextoRecuperarPassword2 = new System.Windows.Forms.Label();
            this.labelTextoRecuperarPassword3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAceptarRecuperarPassword
            // 
            this.buttonAceptarRecuperarPassword.BackColor = System.Drawing.Color.White;
            this.buttonAceptarRecuperarPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAceptarRecuperarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptarRecuperarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptarRecuperarPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.buttonAceptarRecuperarPassword.Location = new System.Drawing.Point(261, 215);
            this.buttonAceptarRecuperarPassword.Name = "buttonAceptarRecuperarPassword";
            this.buttonAceptarRecuperarPassword.Size = new System.Drawing.Size(171, 39);
            this.buttonAceptarRecuperarPassword.TabIndex = 35;
            this.buttonAceptarRecuperarPassword.Text = "Recuperar";
            this.buttonAceptarRecuperarPassword.UseVisualStyleBackColor = false;
            this.buttonAceptarRecuperarPassword.Click += new System.EventHandler(this.RecuperarPassword);
            // 
            // labelTextoRecuperarPassword
            // 
            this.labelTextoRecuperarPassword.AutoSize = true;
            this.labelTextoRecuperarPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.labelTextoRecuperarPassword.Location = new System.Drawing.Point(148, 91);
            this.labelTextoRecuperarPassword.Name = "labelTextoRecuperarPassword";
            this.labelTextoRecuperarPassword.Size = new System.Drawing.Size(424, 18);
            this.labelTextoRecuperarPassword.TabIndex = 36;
            this.labelTextoRecuperarPassword.Text = "El sistema enviará un mensaje al Administrador del sistema,";
            // 
            // labelTextoRecuperarPassword2
            // 
            this.labelTextoRecuperarPassword2.AutoSize = true;
            this.labelTextoRecuperarPassword2.Font = new System.Drawing.Font("Arial", 12F);
            this.labelTextoRecuperarPassword2.Location = new System.Drawing.Point(203, 109);
            this.labelTextoRecuperarPassword2.Name = "labelTextoRecuperarPassword2";
            this.labelTextoRecuperarPassword2.Size = new System.Drawing.Size(318, 18);
            this.labelTextoRecuperarPassword2.TabIndex = 37;
            this.labelTextoRecuperarPassword2.Text = "dicho correo cotiene el password del usuario";
            // 
            // labelTextoRecuperarPassword3
            // 
            this.labelTextoRecuperarPassword3.AutoSize = true;
            this.labelTextoRecuperarPassword3.Font = new System.Drawing.Font("Arial", 12F);
            this.labelTextoRecuperarPassword3.Location = new System.Drawing.Point(142, 159);
            this.labelTextoRecuperarPassword3.Name = "labelTextoRecuperarPassword3";
            this.labelTextoRecuperarPassword3.Size = new System.Drawing.Size(426, 18);
            this.labelTextoRecuperarPassword3.TabIndex = 38;
            this.labelTextoRecuperarPassword3.Text = "(Esta acción requiere conexión a Internet). Desea continuar?";
            // 
            // FormModalRecuperarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 278);
            this.Controls.Add(this.labelTextoRecuperarPassword3);
            this.Controls.Add(this.labelTextoRecuperarPassword2);
            this.Controls.Add(this.labelTextoRecuperarPassword);
            this.Controls.Add(this.buttonAceptarRecuperarPassword);
            this.MaximizeBox = false;
            this.Name = "FormModalRecuperarPassword";
            this.Text = "Recuperar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptarRecuperarPassword;
        private System.Windows.Forms.Label labelTextoRecuperarPassword;
        private System.Windows.Forms.Label labelTextoRecuperarPassword2;
        private System.Windows.Forms.Label labelTextoRecuperarPassword3;
    }
}