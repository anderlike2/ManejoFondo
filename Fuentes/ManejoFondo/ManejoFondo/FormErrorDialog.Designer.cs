namespace ManejoFondo
{
    partial class FormErrorDialog
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
            this.panelDifuminadoError = new ManejoFondo.PanelDifuminado();
            this.labelCerrarError = new System.Windows.Forms.Label();
            this.labelDescripcionError = new System.Windows.Forms.Label();
            this.labelTipoError = new System.Windows.Forms.Label();
            this.panelDifuminadoError.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDifuminadoError
            // 
            this.panelDifuminadoError.ColorAbajo = System.Drawing.Color.Empty;
            this.panelDifuminadoError.ColorArriba = System.Drawing.Color.Empty;
            this.panelDifuminadoError.Controls.Add(this.labelCerrarError);
            this.panelDifuminadoError.Controls.Add(this.labelDescripcionError);
            this.panelDifuminadoError.Controls.Add(this.labelTipoError);
            this.panelDifuminadoError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDifuminadoError.Location = new System.Drawing.Point(0, 0);
            this.panelDifuminadoError.Name = "panelDifuminadoError";
            this.panelDifuminadoError.Size = new System.Drawing.Size(420, 223);
            this.panelDifuminadoError.TabIndex = 0;
            // 
            // labelCerrarError
            // 
            this.labelCerrarError.AutoSize = true;
            this.labelCerrarError.BackColor = System.Drawing.Color.Transparent;
            this.labelCerrarError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCerrarError.Location = new System.Drawing.Point(388, 9);
            this.labelCerrarError.Name = "labelCerrarError";
            this.labelCerrarError.Size = new System.Drawing.Size(20, 19);
            this.labelCerrarError.TabIndex = 2;
            this.labelCerrarError.Text = "X";
            this.labelCerrarError.Click += new System.EventHandler(this.CerrarError);
            // 
            // labelDescripcionError
            // 
            this.labelDescripcionError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDescripcionError.BackColor = System.Drawing.Color.Transparent;
            this.labelDescripcionError.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionError.Location = new System.Drawing.Point(12, 87);
            this.labelDescripcionError.Name = "labelDescripcionError";
            this.labelDescripcionError.Size = new System.Drawing.Size(396, 104);
            this.labelDescripcionError.TabIndex = 1;
            // 
            // labelTipoError
            // 
            this.labelTipoError.AutoSize = true;
            this.labelTipoError.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoError.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoError.Location = new System.Drawing.Point(132, 25);
            this.labelTipoError.Name = "labelTipoError";
            this.labelTipoError.Size = new System.Drawing.Size(0, 34);
            this.labelTipoError.TabIndex = 0;
            // 
            // FormErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 223);
            this.Controls.Add(this.panelDifuminadoError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormErrorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mensaje";
            this.panelDifuminadoError.ResumeLayout(false);
            this.panelDifuminadoError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelDifuminado panelDifuminadoError;
        private System.Windows.Forms.Label labelDescripcionError;
        private System.Windows.Forms.Label labelTipoError;
        private System.Windows.Forms.Label labelCerrarError;
    }
}