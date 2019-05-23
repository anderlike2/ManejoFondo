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
            this.SuspendLayout();
            // 
            // panelDifuminadoError
            // 
            this.panelDifuminadoError.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelDifuminadoError.ColorArriba = System.Drawing.Color.Green;
            this.panelDifuminadoError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDifuminadoError.Location = new System.Drawing.Point(0, 0);
            this.panelDifuminadoError.Name = "panelDifuminadoError";
            this.panelDifuminadoError.Size = new System.Drawing.Size(466, 223);
            this.panelDifuminadoError.TabIndex = 0;
            // 
            // FormErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 223);
            this.Controls.Add(this.panelDifuminadoError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormErrorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mensaje";
            this.ResumeLayout(false);

        }

        #endregion

        private PanelDifuminado panelDifuminadoError;
    }
}