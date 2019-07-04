namespace ManejoFondo
{
    partial class FormModalEliminarUsuario
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
            this.labelTextoEliminarUsuario2 = new System.Windows.Forms.Label();
            this.labelTextoEliminarUsuario = new System.Windows.Forms.Label();
            this.buttonAceptarEliminarUsuario = new System.Windows.Forms.Button();
            this.labelVerPassword = new System.Windows.Forms.Label();
            this.textBoxEliminarUsuarioPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelElimininarUsuarioPassword = new System.Windows.Forms.Label();
            this.textBoxEliminarUsuarioUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEliminarUsuarioUsuario = new System.Windows.Forms.Label();
            this.buttonLimpiarEliminarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTextoEliminarUsuario2
            // 
            this.labelTextoEliminarUsuario2.AutoSize = true;
            this.labelTextoEliminarUsuario2.Font = new System.Drawing.Font("Arial", 12F);
            this.labelTextoEliminarUsuario2.Location = new System.Drawing.Point(319, 241);
            this.labelTextoEliminarUsuario2.Name = "labelTextoEliminarUsuario2";
            this.labelTextoEliminarUsuario2.Size = new System.Drawing.Size(131, 18);
            this.labelTextoEliminarUsuario2.TabIndex = 40;
            this.labelTextoEliminarUsuario2.Text = "Desea continuar?";
            // 
            // labelTextoEliminarUsuario
            // 
            this.labelTextoEliminarUsuario.AutoSize = true;
            this.labelTextoEliminarUsuario.Font = new System.Drawing.Font("Arial", 12F);
            this.labelTextoEliminarUsuario.Location = new System.Drawing.Point(221, 223);
            this.labelTextoEliminarUsuario.Name = "labelTextoEliminarUsuario";
            this.labelTextoEliminarUsuario.Size = new System.Drawing.Size(328, 18);
            this.labelTextoEliminarUsuario.TabIndex = 39;
            this.labelTextoEliminarUsuario.Text = "El sistema eliminará su usuario Administrador.";
            // 
            // buttonAceptarEliminarUsuario
            // 
            this.buttonAceptarEliminarUsuario.BackColor = System.Drawing.Color.White;
            this.buttonAceptarEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAceptarEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptarEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptarEliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.buttonAceptarEliminarUsuario.Location = new System.Drawing.Point(214, 279);
            this.buttonAceptarEliminarUsuario.Name = "buttonAceptarEliminarUsuario";
            this.buttonAceptarEliminarUsuario.Size = new System.Drawing.Size(171, 39);
            this.buttonAceptarEliminarUsuario.TabIndex = 38;
            this.buttonAceptarEliminarUsuario.Text = "Eliminar";
            this.buttonAceptarEliminarUsuario.UseVisualStyleBackColor = false;
            this.buttonAceptarEliminarUsuario.Click += new System.EventHandler(this.EliminarUsuario);
            // 
            // labelVerPassword
            // 
            this.labelVerPassword.AutoSize = true;
            this.labelVerPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVerPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.labelVerPassword.Location = new System.Drawing.Point(701, 142);
            this.labelVerPassword.Name = "labelVerPassword";
            this.labelVerPassword.Size = new System.Drawing.Size(23, 13);
            this.labelVerPassword.TabIndex = 47;
            this.labelVerPassword.Text = "Ver";
            this.labelVerPassword.MouseLeave += new System.EventHandler(this.OcultarPassword);
            this.labelVerPassword.MouseHover += new System.EventHandler(this.VerPassword);
            // 
            // textBoxEliminarUsuarioPassword
            // 
            this.textBoxEliminarUsuarioPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEliminarUsuarioPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxEliminarUsuarioPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEliminarUsuarioPassword.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxEliminarUsuarioPassword.HintText = "";
            this.textBoxEliminarUsuarioPassword.isPassword = true;
            this.textBoxEliminarUsuarioPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxEliminarUsuarioPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxEliminarUsuarioPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxEliminarUsuarioPassword.LineThickness = 3;
            this.textBoxEliminarUsuarioPassword.Location = new System.Drawing.Point(398, 132);
            this.textBoxEliminarUsuarioPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEliminarUsuarioPassword.Name = "textBoxEliminarUsuarioPassword";
            this.textBoxEliminarUsuarioPassword.Size = new System.Drawing.Size(296, 28);
            this.textBoxEliminarUsuarioPassword.TabIndex = 46;
            this.textBoxEliminarUsuarioPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxEliminarUsuarioPassword.OnValueChanged += new System.EventHandler(this.MascaraPassword);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(723, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelElimininarUsuarioPassword
            // 
            this.labelElimininarUsuarioPassword.AutoSize = true;
            this.labelElimininarUsuarioPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElimininarUsuarioPassword.ForeColor = System.Drawing.Color.Black;
            this.labelElimininarUsuarioPassword.Location = new System.Drawing.Point(393, 110);
            this.labelElimininarUsuarioPassword.Name = "labelElimininarUsuarioPassword";
            this.labelElimininarUsuarioPassword.Size = new System.Drawing.Size(103, 21);
            this.labelElimininarUsuarioPassword.TabIndex = 44;
            this.labelElimininarUsuarioPassword.Text = "Contraseña";
            // 
            // textBoxEliminarUsuarioUsuario
            // 
            this.textBoxEliminarUsuarioUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEliminarUsuarioUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxEliminarUsuarioUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEliminarUsuarioUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxEliminarUsuarioUsuario.HintText = "";
            this.textBoxEliminarUsuarioUsuario.isPassword = false;
            this.textBoxEliminarUsuarioUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxEliminarUsuarioUsuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxEliminarUsuarioUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxEliminarUsuarioUsuario.LineThickness = 3;
            this.textBoxEliminarUsuarioUsuario.Location = new System.Drawing.Point(41, 129);
            this.textBoxEliminarUsuarioUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEliminarUsuarioUsuario.Name = "textBoxEliminarUsuarioUsuario";
            this.textBoxEliminarUsuarioUsuario.Size = new System.Drawing.Size(297, 28);
            this.textBoxEliminarUsuarioUsuario.TabIndex = 43;
            this.textBoxEliminarUsuarioUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(347, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelEliminarUsuarioUsuario
            // 
            this.labelEliminarUsuarioUsuario.AutoSize = true;
            this.labelEliminarUsuarioUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminarUsuarioUsuario.ForeColor = System.Drawing.Color.Black;
            this.labelEliminarUsuarioUsuario.Location = new System.Drawing.Point(38, 110);
            this.labelEliminarUsuarioUsuario.Name = "labelEliminarUsuarioUsuario";
            this.labelEliminarUsuarioUsuario.Size = new System.Drawing.Size(66, 21);
            this.labelEliminarUsuarioUsuario.TabIndex = 41;
            this.labelEliminarUsuarioUsuario.Text = "Usuario";
            // 
            // buttonLimpiarEliminarUsuario
            // 
            this.buttonLimpiarEliminarUsuario.BackColor = System.Drawing.Color.White;
            this.buttonLimpiarEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiarEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiarEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiarEliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(66)))), ((int)(((byte)(45)))));
            this.buttonLimpiarEliminarUsuario.Location = new System.Drawing.Point(391, 279);
            this.buttonLimpiarEliminarUsuario.Name = "buttonLimpiarEliminarUsuario";
            this.buttonLimpiarEliminarUsuario.Size = new System.Drawing.Size(171, 39);
            this.buttonLimpiarEliminarUsuario.TabIndex = 48;
            this.buttonLimpiarEliminarUsuario.Text = "Limpiar";
            this.buttonLimpiarEliminarUsuario.UseVisualStyleBackColor = false;
            this.buttonLimpiarEliminarUsuario.Click += new System.EventHandler(this.LimpiarFormulario);
            // 
            // FormModalEliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(773, 345);
            this.Controls.Add(this.buttonLimpiarEliminarUsuario);
            this.Controls.Add(this.labelVerPassword);
            this.Controls.Add(this.textBoxEliminarUsuarioPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelElimininarUsuarioPassword);
            this.Controls.Add(this.textBoxEliminarUsuarioUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelEliminarUsuarioUsuario);
            this.Controls.Add(this.labelTextoEliminarUsuario2);
            this.Controls.Add(this.labelTextoEliminarUsuario);
            this.Controls.Add(this.buttonAceptarEliminarUsuario);
            this.MaximizeBox = false;
            this.Name = "FormModalEliminarUsuario";
            this.Text = "Eliminar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextoEliminarUsuario2;
        private System.Windows.Forms.Label labelTextoEliminarUsuario;
        private System.Windows.Forms.Button buttonAceptarEliminarUsuario;
        private System.Windows.Forms.Label labelVerPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxEliminarUsuarioPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelElimininarUsuarioPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxEliminarUsuarioUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEliminarUsuarioUsuario;
        private System.Windows.Forms.Button buttonLimpiarEliminarUsuario;
    }
}