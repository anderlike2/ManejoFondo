namespace ManejoFondo
{
    partial class FormIngresoAsociado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresoAsociado));
            this.tabIngresarAsociado = new System.Windows.Forms.TabControl();
            this.tabDatosPersona = new System.Windows.Forms.TabPage();
            this.tabAyudaGubernamental = new System.Windows.Forms.TabPage();
            this.ingresoAsociadoAceptar = new System.Windows.Forms.Button();
            this.ingresoAsociadoCancelar = new System.Windows.Forms.Button();
            this.panelIngresoAsociadoRegresar = new System.Windows.Forms.Panel();
            this.tabNucleoFamiliar = new System.Windows.Forms.TabPage();
            this.tabIngresos = new System.Windows.Forms.TabPage();
            this.tabIngresarAsociado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabIngresarAsociado
            // 
            this.tabIngresarAsociado.Controls.Add(this.tabDatosPersona);
            this.tabIngresarAsociado.Controls.Add(this.tabAyudaGubernamental);
            this.tabIngresarAsociado.Controls.Add(this.tabNucleoFamiliar);
            this.tabIngresarAsociado.Controls.Add(this.tabIngresos);
            this.tabIngresarAsociado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabIngresarAsociado.Location = new System.Drawing.Point(12, 35);
            this.tabIngresarAsociado.Name = "tabIngresarAsociado";
            this.tabIngresarAsociado.SelectedIndex = 0;
            this.tabIngresarAsociado.Size = new System.Drawing.Size(1212, 422);
            this.tabIngresarAsociado.TabIndex = 0;
            // 
            // tabDatosPersona
            // 
            this.tabDatosPersona.Location = new System.Drawing.Point(4, 27);
            this.tabDatosPersona.Name = "tabDatosPersona";
            this.tabDatosPersona.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosPersona.Size = new System.Drawing.Size(1204, 391);
            this.tabDatosPersona.TabIndex = 0;
            this.tabDatosPersona.Text = "Datos Persona";
            this.tabDatosPersona.UseVisualStyleBackColor = true;
            // 
            // tabAyudaGubernamental
            // 
            this.tabAyudaGubernamental.Location = new System.Drawing.Point(4, 27);
            this.tabAyudaGubernamental.Name = "tabAyudaGubernamental";
            this.tabAyudaGubernamental.Padding = new System.Windows.Forms.Padding(3);
            this.tabAyudaGubernamental.Size = new System.Drawing.Size(1204, 391);
            this.tabAyudaGubernamental.TabIndex = 1;
            this.tabAyudaGubernamental.Text = "Ayuda Gobierno";
            this.tabAyudaGubernamental.UseVisualStyleBackColor = true;
            // 
            // ingresoAsociadoAceptar
            // 
            this.ingresoAsociadoAceptar.BackColor = System.Drawing.Color.White;
            this.ingresoAsociadoAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresoAsociadoAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresoAsociadoAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoAsociadoAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(112)))));
            this.ingresoAsociadoAceptar.Location = new System.Drawing.Point(311, 483);
            this.ingresoAsociadoAceptar.Name = "ingresoAsociadoAceptar";
            this.ingresoAsociadoAceptar.Size = new System.Drawing.Size(253, 39);
            this.ingresoAsociadoAceptar.TabIndex = 7;
            this.ingresoAsociadoAceptar.Text = "Aceptar";
            this.ingresoAsociadoAceptar.UseVisualStyleBackColor = false;
            this.ingresoAsociadoAceptar.Click += new System.EventHandler(this.AceptarIngresarAsociado);
            // 
            // ingresoAsociadoCancelar
            // 
            this.ingresoAsociadoCancelar.BackColor = System.Drawing.Color.White;
            this.ingresoAsociadoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresoAsociadoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresoAsociadoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoAsociadoCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(112)))));
            this.ingresoAsociadoCancelar.Location = new System.Drawing.Point(570, 483);
            this.ingresoAsociadoCancelar.Name = "ingresoAsociadoCancelar";
            this.ingresoAsociadoCancelar.Size = new System.Drawing.Size(253, 39);
            this.ingresoAsociadoCancelar.TabIndex = 8;
            this.ingresoAsociadoCancelar.Text = "Cancelar";
            this.ingresoAsociadoCancelar.UseVisualStyleBackColor = false;
            // 
            // panelIngresoAsociadoRegresar
            // 
            this.panelIngresoAsociadoRegresar.BackgroundImage = global::ManejoFondo.Properties.Resources.regresar;
            this.panelIngresoAsociadoRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelIngresoAsociadoRegresar.Location = new System.Drawing.Point(1174, 483);
            this.panelIngresoAsociadoRegresar.Name = "panelIngresoAsociadoRegresar";
            this.panelIngresoAsociadoRegresar.Size = new System.Drawing.Size(46, 39);
            this.panelIngresoAsociadoRegresar.TabIndex = 9;
            this.panelIngresoAsociadoRegresar.Click += new System.EventHandler(this.RegresarMenuPrincipal);
            // 
            // tabNucleoFamiliar
            // 
            this.tabNucleoFamiliar.Location = new System.Drawing.Point(4, 27);
            this.tabNucleoFamiliar.Name = "tabNucleoFamiliar";
            this.tabNucleoFamiliar.Padding = new System.Windows.Forms.Padding(3);
            this.tabNucleoFamiliar.Size = new System.Drawing.Size(1204, 391);
            this.tabNucleoFamiliar.TabIndex = 2;
            this.tabNucleoFamiliar.Text = "Núcleo Familiar";
            this.tabNucleoFamiliar.UseVisualStyleBackColor = true;
            // 
            // tabIngresos
            // 
            this.tabIngresos.Location = new System.Drawing.Point(4, 27);
            this.tabIngresos.Name = "tabIngresos";
            this.tabIngresos.Padding = new System.Windows.Forms.Padding(3);
            this.tabIngresos.Size = new System.Drawing.Size(1204, 391);
            this.tabIngresos.TabIndex = 3;
            this.tabIngresos.Text = "Ingresos";
            this.tabIngresos.UseVisualStyleBackColor = true;
            // 
            // FormIngresoAsociado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 566);
            this.Controls.Add(this.panelIngresoAsociadoRegresar);
            this.Controls.Add(this.ingresoAsociadoCancelar);
            this.Controls.Add(this.ingresoAsociadoAceptar);
            this.Controls.Add(this.tabIngresarAsociado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormIngresoAsociado";
            this.Text = "Ingresar Asociado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabIngresarAsociado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabIngresarAsociado;
        private System.Windows.Forms.TabPage tabDatosPersona;
        private System.Windows.Forms.TabPage tabAyudaGubernamental;
        private System.Windows.Forms.Button ingresoAsociadoAceptar;
        private System.Windows.Forms.Button ingresoAsociadoCancelar;
        private System.Windows.Forms.Panel panelIngresoAsociadoRegresar;
        private System.Windows.Forms.TabPage tabNucleoFamiliar;
        private System.Windows.Forms.TabPage tabIngresos;
    }
}