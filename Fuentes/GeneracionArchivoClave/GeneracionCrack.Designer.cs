namespace GeneracionArchivoClave
{
    partial class GeneracionCrack
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
            this.labelPalabraClave = new System.Windows.Forms.Label();
            this.labelFechaDesde = new System.Windows.Forms.Label();
            this.labelFechaHasta = new System.Windows.Forms.Label();
            this.textBoxPalabraClave = new System.Windows.Forms.TextBox();
            this.timeDesde = new System.Windows.Forms.DateTimePicker();
            this.timeHasta = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.chkTiempo = new System.Windows.Forms.CheckBox();
            this.chkSerial = new System.Windows.Forms.CheckBox();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPalabraClave
            // 
            this.labelPalabraClave.AutoSize = true;
            this.labelPalabraClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalabraClave.Location = new System.Drawing.Point(68, 105);
            this.labelPalabraClave.Name = "labelPalabraClave";
            this.labelPalabraClave.Size = new System.Drawing.Size(110, 20);
            this.labelPalabraClave.TabIndex = 0;
            this.labelPalabraClave.Text = "Palabra Clave:";
            // 
            // labelFechaDesde
            // 
            this.labelFechaDesde.AutoSize = true;
            this.labelFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaDesde.Location = new System.Drawing.Point(68, 197);
            this.labelFechaDesde.Name = "labelFechaDesde";
            this.labelFechaDesde.Size = new System.Drawing.Size(60, 20);
            this.labelFechaDesde.TabIndex = 1;
            this.labelFechaDesde.Text = "Desde:";
            // 
            // labelFechaHasta
            // 
            this.labelFechaHasta.AutoSize = true;
            this.labelFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaHasta.Location = new System.Drawing.Point(409, 197);
            this.labelFechaHasta.Name = "labelFechaHasta";
            this.labelFechaHasta.Size = new System.Drawing.Size(56, 20);
            this.labelFechaHasta.TabIndex = 2;
            this.labelFechaHasta.Text = "Hasta:";
            // 
            // textBoxPalabraClave
            // 
            this.textBoxPalabraClave.Location = new System.Drawing.Point(185, 104);
            this.textBoxPalabraClave.Name = "textBoxPalabraClave";
            this.textBoxPalabraClave.PasswordChar = '*';
            this.textBoxPalabraClave.Size = new System.Drawing.Size(524, 20);
            this.textBoxPalabraClave.TabIndex = 4;
            // 
            // timeDesde
            // 
            this.timeDesde.Location = new System.Drawing.Point(185, 197);
            this.timeDesde.Name = "timeDesde";
            this.timeDesde.Size = new System.Drawing.Size(200, 20);
            this.timeDesde.TabIndex = 6;
            // 
            // timeHasta
            // 
            this.timeHasta.Location = new System.Drawing.Point(509, 197);
            this.timeHasta.Name = "timeHasta";
            this.timeHasta.Size = new System.Drawing.Size(200, 20);
            this.timeHasta.TabIndex = 7;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(335, 323);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(119, 23);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar Crack";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.GenerarCrack);
            // 
            // chkTiempo
            // 
            this.chkTiempo.AutoSize = true;
            this.chkTiempo.Location = new System.Drawing.Point(72, 149);
            this.chkTiempo.Name = "chkTiempo";
            this.chkTiempo.Size = new System.Drawing.Size(124, 17);
            this.chkTiempo.TabIndex = 9;
            this.chkTiempo.Text = "Activado de por vida";
            this.chkTiempo.UseVisualStyleBackColor = true;
            this.chkTiempo.CheckedChanged += new System.EventHandler(this.validarFechas);
            // 
            // chkSerial
            // 
            this.chkSerial.AutoSize = true;
            this.chkSerial.Location = new System.Drawing.Point(72, 256);
            this.chkSerial.Name = "chkSerial";
            this.chkSerial.Size = new System.Drawing.Size(104, 17);
            this.chkSerial.TabIndex = 10;
            this.chkSerial.Text = "Ingresar el Serial";
            this.chkSerial.UseVisualStyleBackColor = true;
            this.chkSerial.CheckedChanged += new System.EventHandler(this.ValidarSerial);
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Enabled = false;
            this.textBoxSerial.Location = new System.Drawing.Point(194, 256);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.PasswordChar = '*';
            this.textBoxSerial.Size = new System.Drawing.Size(515, 20);
            this.textBoxSerial.TabIndex = 11;
            // 
            // GeneracionCrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 432);
            this.Controls.Add(this.textBoxSerial);
            this.Controls.Add(this.chkSerial);
            this.Controls.Add(this.chkTiempo);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.timeHasta);
            this.Controls.Add(this.timeDesde);
            this.Controls.Add(this.textBoxPalabraClave);
            this.Controls.Add(this.labelFechaHasta);
            this.Controls.Add(this.labelFechaDesde);
            this.Controls.Add(this.labelPalabraClave);
            this.Name = "GeneracionCrack";
            this.Text = "Generación Clave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPalabraClave;
        private System.Windows.Forms.Label labelFechaDesde;
        private System.Windows.Forms.Label labelFechaHasta;
        private System.Windows.Forms.TextBox textBoxPalabraClave;
        private System.Windows.Forms.DateTimePicker timeDesde;
        private System.Windows.Forms.DateTimePicker timeHasta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.CheckBox chkTiempo;
        private System.Windows.Forms.CheckBox chkSerial;
        private System.Windows.Forms.TextBox textBoxSerial;
    }
}

