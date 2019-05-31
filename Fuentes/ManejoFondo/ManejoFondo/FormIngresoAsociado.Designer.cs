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
            this.labelTituloDatosPersonales = new System.Windows.Forms.Label();
            this.panelImagenDatosPersonales = new System.Windows.Forms.Panel();
            this.tabAyudaGubernamental = new System.Windows.Forms.TabPage();
            this.labelTituloAyudasGobierno = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabNucleoFamiliar = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabIngresos = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.ingresoAsociadoCancelar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ingresoAsociadoAceptar = new System.Windows.Forms.Button();
            this.panelIngresoAsociadoRegresar = new System.Windows.Forms.Panel();
            this.labelDatosPersonalesNombres = new System.Windows.Forms.Label();
            this.labelDatosPersonalesApellidos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDatosPersonaNombres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxDatosPersonasApellidos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelDatosPersonalesTipoIdentificacion = new System.Windows.Forms.Label();
            this.labelDatosPersonalesNumeroIdentificacion = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.dropDownTipoIdentificacion = new Bunifu.Framework.UI.BunifuDropdown();
            this.tabIngresarAsociado.SuspendLayout();
            this.tabDatosPersona.SuspendLayout();
            this.tabAyudaGubernamental.SuspendLayout();
            this.tabNucleoFamiliar.SuspendLayout();
            this.tabIngresos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabIngresarAsociado
            // 
            this.tabIngresarAsociado.Controls.Add(this.tabDatosPersona);
            this.tabIngresarAsociado.Controls.Add(this.tabAyudaGubernamental);
            this.tabIngresarAsociado.Controls.Add(this.tabNucleoFamiliar);
            this.tabIngresarAsociado.Controls.Add(this.tabIngresos);
            this.tabIngresarAsociado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabIngresarAsociado.Location = new System.Drawing.Point(-1, 74);
            this.tabIngresarAsociado.Name = "tabIngresarAsociado";
            this.tabIngresarAsociado.SelectedIndex = 0;
            this.tabIngresarAsociado.Size = new System.Drawing.Size(962, 453);
            this.tabIngresarAsociado.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabIngresarAsociado.TabIndex = 0;
            // 
            // tabDatosPersona
            // 
            this.tabDatosPersona.BackColor = System.Drawing.Color.White;
            this.tabDatosPersona.Controls.Add(this.dropDownTipoIdentificacion);
            this.tabDatosPersona.Controls.Add(this.label5);
            this.tabDatosPersona.Controls.Add(this.bunifuMaterialTextbox2);
            this.tabDatosPersona.Controls.Add(this.labelDatosPersonalesNumeroIdentificacion);
            this.tabDatosPersona.Controls.Add(this.labelDatosPersonalesTipoIdentificacion);
            this.tabDatosPersona.Controls.Add(this.textBoxDatosPersonasApellidos);
            this.tabDatosPersona.Controls.Add(this.textBoxDatosPersonaNombres);
            this.tabDatosPersona.Controls.Add(this.label4);
            this.tabDatosPersona.Controls.Add(this.label3);
            this.tabDatosPersona.Controls.Add(this.labelDatosPersonalesApellidos);
            this.tabDatosPersona.Controls.Add(this.labelDatosPersonalesNombres);
            this.tabDatosPersona.Controls.Add(this.labelTituloDatosPersonales);
            this.tabDatosPersona.Controls.Add(this.panelImagenDatosPersonales);
            this.tabDatosPersona.ForeColor = System.Drawing.Color.Transparent;
            this.tabDatosPersona.Location = new System.Drawing.Point(4, 27);
            this.tabDatosPersona.Name = "tabDatosPersona";
            this.tabDatosPersona.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosPersona.Size = new System.Drawing.Size(954, 422);
            this.tabDatosPersona.TabIndex = 0;
            this.tabDatosPersona.Text = "Datos Persona";
            // 
            // labelTituloDatosPersonales
            // 
            this.labelTituloDatosPersonales.AutoSize = true;
            this.labelTituloDatosPersonales.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloDatosPersonales.ForeColor = System.Drawing.Color.Black;
            this.labelTituloDatosPersonales.Location = new System.Drawing.Point(187, 42);
            this.labelTituloDatosPersonales.Name = "labelTituloDatosPersonales";
            this.labelTituloDatosPersonales.Size = new System.Drawing.Size(510, 22);
            this.labelTituloDatosPersonales.TabIndex = 1;
            this.labelTituloDatosPersonales.Text = "POR FAVOR INGRESAR SU INFORMACIÓN PERSONAL";
            // 
            // panelImagenDatosPersonales
            // 
            this.panelImagenDatosPersonales.BackgroundImage = global::ManejoFondo.Properties.Resources.datosPersonales;
            this.panelImagenDatosPersonales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImagenDatosPersonales.Location = new System.Drawing.Point(808, 2);
            this.panelImagenDatosPersonales.Name = "panelImagenDatosPersonales";
            this.panelImagenDatosPersonales.Size = new System.Drawing.Size(119, 110);
            this.panelImagenDatosPersonales.TabIndex = 0;
            // 
            // tabAyudaGubernamental
            // 
            this.tabAyudaGubernamental.BackColor = System.Drawing.Color.Transparent;
            this.tabAyudaGubernamental.Controls.Add(this.labelTituloAyudasGobierno);
            this.tabAyudaGubernamental.Controls.Add(this.panel1);
            this.tabAyudaGubernamental.Location = new System.Drawing.Point(4, 27);
            this.tabAyudaGubernamental.Name = "tabAyudaGubernamental";
            this.tabAyudaGubernamental.Padding = new System.Windows.Forms.Padding(3);
            this.tabAyudaGubernamental.Size = new System.Drawing.Size(954, 422);
            this.tabAyudaGubernamental.TabIndex = 1;
            this.tabAyudaGubernamental.Text = "Ayuda Gobierno";
            // 
            // labelTituloAyudasGobierno
            // 
            this.labelTituloAyudasGobierno.AutoSize = true;
            this.labelTituloAyudasGobierno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloAyudasGobierno.ForeColor = System.Drawing.Color.Black;
            this.labelTituloAyudasGobierno.Location = new System.Drawing.Point(89, 47);
            this.labelTituloAyudasGobierno.Name = "labelTituloAyudasGobierno";
            this.labelTituloAyudasGobierno.Size = new System.Drawing.Size(663, 22);
            this.labelTituloAyudasGobierno.TabIndex = 3;
            this.labelTituloAyudasGobierno.Text = "POR FAVOR INGRESAR LAS AYUDAS GUBERNAMENTALES RECIBIDAS";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ManejoFondo.Properties.Resources.ayudasGobierno;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(814, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 114);
            this.panel1.TabIndex = 2;
            // 
            // tabNucleoFamiliar
            // 
            this.tabNucleoFamiliar.BackColor = System.Drawing.Color.Transparent;
            this.tabNucleoFamiliar.Controls.Add(this.label1);
            this.tabNucleoFamiliar.Controls.Add(this.panel2);
            this.tabNucleoFamiliar.Location = new System.Drawing.Point(4, 27);
            this.tabNucleoFamiliar.Name = "tabNucleoFamiliar";
            this.tabNucleoFamiliar.Padding = new System.Windows.Forms.Padding(3);
            this.tabNucleoFamiliar.Size = new System.Drawing.Size(954, 422);
            this.tabNucleoFamiliar.TabIndex = 2;
            this.tabNucleoFamiliar.Text = "Núcleo Familiar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(97, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "POR FAVOR INGRESAR LA INFORMACIÓN DE SU NÚCLEO FAMILIAR";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ManejoFondo.Properties.Resources.nucleoFamiliar;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(814, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 114);
            this.panel2.TabIndex = 4;
            // 
            // tabIngresos
            // 
            this.tabIngresos.BackColor = System.Drawing.Color.Transparent;
            this.tabIngresos.Controls.Add(this.label2);
            this.tabIngresos.Controls.Add(this.ingresoAsociadoCancelar);
            this.tabIngresos.Controls.Add(this.panel3);
            this.tabIngresos.Controls.Add(this.ingresoAsociadoAceptar);
            this.tabIngresos.Location = new System.Drawing.Point(4, 27);
            this.tabIngresos.Name = "tabIngresos";
            this.tabIngresos.Padding = new System.Windows.Forms.Padding(3);
            this.tabIngresos.Size = new System.Drawing.Size(954, 422);
            this.tabIngresos.TabIndex = 3;
            this.tabIngresos.Text = "Ingresos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(129, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "POR FAVOR INGRESAR LA INFORMACIÓN DE SUS INGRESOS";
            // 
            // ingresoAsociadoCancelar
            // 
            this.ingresoAsociadoCancelar.BackColor = System.Drawing.Color.White;
            this.ingresoAsociadoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresoAsociadoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresoAsociadoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoAsociadoCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(112)))));
            this.ingresoAsociadoCancelar.Location = new System.Drawing.Point(456, 373);
            this.ingresoAsociadoCancelar.Name = "ingresoAsociadoCancelar";
            this.ingresoAsociadoCancelar.Size = new System.Drawing.Size(253, 39);
            this.ingresoAsociadoCancelar.TabIndex = 8;
            this.ingresoAsociadoCancelar.Text = "Cancelar";
            this.ingresoAsociadoCancelar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ManejoFondo.Properties.Resources.ingresos;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(813, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 114);
            this.panel3.TabIndex = 6;
            // 
            // ingresoAsociadoAceptar
            // 
            this.ingresoAsociadoAceptar.BackColor = System.Drawing.Color.White;
            this.ingresoAsociadoAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresoAsociadoAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresoAsociadoAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoAsociadoAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(112)))));
            this.ingresoAsociadoAceptar.Location = new System.Drawing.Point(197, 373);
            this.ingresoAsociadoAceptar.Name = "ingresoAsociadoAceptar";
            this.ingresoAsociadoAceptar.Size = new System.Drawing.Size(253, 39);
            this.ingresoAsociadoAceptar.TabIndex = 7;
            this.ingresoAsociadoAceptar.Text = "Aceptar";
            this.ingresoAsociadoAceptar.UseVisualStyleBackColor = false;
            this.ingresoAsociadoAceptar.Click += new System.EventHandler(this.AceptarIngresarAsociado);
            // 
            // panelIngresoAsociadoRegresar
            // 
            this.panelIngresoAsociadoRegresar.BackgroundImage = global::ManejoFondo.Properties.Resources.regresar;
            this.panelIngresoAsociadoRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelIngresoAsociadoRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelIngresoAsociadoRegresar.Location = new System.Drawing.Point(906, 529);
            this.panelIngresoAsociadoRegresar.Name = "panelIngresoAsociadoRegresar";
            this.panelIngresoAsociadoRegresar.Size = new System.Drawing.Size(42, 43);
            this.panelIngresoAsociadoRegresar.TabIndex = 9;
            this.panelIngresoAsociadoRegresar.Click += new System.EventHandler(this.RegresarMenuPrincipal);
            // 
            // labelDatosPersonalesNombres
            // 
            this.labelDatosPersonalesNombres.AutoSize = true;
            this.labelDatosPersonalesNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosPersonalesNombres.ForeColor = System.Drawing.Color.Black;
            this.labelDatosPersonalesNombres.Location = new System.Drawing.Point(35, 139);
            this.labelDatosPersonalesNombres.Name = "labelDatosPersonalesNombres";
            this.labelDatosPersonalesNombres.Size = new System.Drawing.Size(79, 21);
            this.labelDatosPersonalesNombres.TabIndex = 3;
            this.labelDatosPersonalesNombres.Text = "Nombres";
            // 
            // labelDatosPersonalesApellidos
            // 
            this.labelDatosPersonalesApellidos.AutoSize = true;
            this.labelDatosPersonalesApellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosPersonalesApellidos.ForeColor = System.Drawing.Color.Black;
            this.labelDatosPersonalesApellidos.Location = new System.Drawing.Point(505, 139);
            this.labelDatosPersonalesApellidos.Name = "labelDatosPersonalesApellidos";
            this.labelDatosPersonalesApellidos.Size = new System.Drawing.Size(80, 21);
            this.labelDatosPersonalesApellidos.TabIndex = 4;
            this.labelDatosPersonalesApellidos.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(423, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(893, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBoxDatosPersonaNombres
            // 
            this.textBoxDatosPersonaNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDatosPersonaNombres.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxDatosPersonaNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxDatosPersonaNombres.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxDatosPersonaNombres.HintText = "";
            this.textBoxDatosPersonaNombres.isPassword = false;
            this.textBoxDatosPersonaNombres.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxDatosPersonaNombres.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxDatosPersonaNombres.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxDatosPersonaNombres.LineThickness = 3;
            this.textBoxDatosPersonaNombres.Location = new System.Drawing.Point(39, 161);
            this.textBoxDatosPersonaNombres.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDatosPersonaNombres.Name = "textBoxDatosPersonaNombres";
            this.textBoxDatosPersonaNombres.Size = new System.Drawing.Size(379, 29);
            this.textBoxDatosPersonaNombres.TabIndex = 8;
            this.textBoxDatosPersonaNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxDatosPersonasApellidos
            // 
            this.textBoxDatosPersonasApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDatosPersonasApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxDatosPersonasApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxDatosPersonasApellidos.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxDatosPersonasApellidos.HintText = "";
            this.textBoxDatosPersonasApellidos.isPassword = false;
            this.textBoxDatosPersonasApellidos.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxDatosPersonasApellidos.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxDatosPersonasApellidos.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBoxDatosPersonasApellidos.LineThickness = 3;
            this.textBoxDatosPersonasApellidos.Location = new System.Drawing.Point(509, 161);
            this.textBoxDatosPersonasApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDatosPersonasApellidos.Name = "textBoxDatosPersonasApellidos";
            this.textBoxDatosPersonasApellidos.Size = new System.Drawing.Size(379, 29);
            this.textBoxDatosPersonasApellidos.TabIndex = 9;
            this.textBoxDatosPersonasApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelDatosPersonalesTipoIdentificacion
            // 
            this.labelDatosPersonalesTipoIdentificacion.AutoSize = true;
            this.labelDatosPersonalesTipoIdentificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosPersonalesTipoIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.labelDatosPersonalesTipoIdentificacion.Location = new System.Drawing.Point(35, 203);
            this.labelDatosPersonalesTipoIdentificacion.Name = "labelDatosPersonalesTipoIdentificacion";
            this.labelDatosPersonalesTipoIdentificacion.Size = new System.Drawing.Size(154, 21);
            this.labelDatosPersonalesTipoIdentificacion.TabIndex = 10;
            this.labelDatosPersonalesTipoIdentificacion.Text = "Tipo Identificación";
            // 
            // labelDatosPersonalesNumeroIdentificacion
            // 
            this.labelDatosPersonalesNumeroIdentificacion.AutoSize = true;
            this.labelDatosPersonalesNumeroIdentificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosPersonalesNumeroIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.labelDatosPersonalesNumeroIdentificacion.Location = new System.Drawing.Point(505, 203);
            this.labelDatosPersonalesNumeroIdentificacion.Name = "labelDatosPersonalesNumeroIdentificacion";
            this.labelDatosPersonalesNumeroIdentificacion.Size = new System.Drawing.Size(184, 21);
            this.labelDatosPersonalesNumeroIdentificacion.TabIndex = 11;
            this.labelDatosPersonalesNumeroIdentificacion.Text = "Número Identificación";
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(509, 228);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(379, 29);
            this.bunifuMaterialTextbox2.TabIndex = 13;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(893, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // dropDownTipoIdentificacion
            // 
            this.dropDownTipoIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.dropDownTipoIdentificacion.BorderRadius = 3;
            this.dropDownTipoIdentificacion.DisabledColor = System.Drawing.Color.Gray;
            this.dropDownTipoIdentificacion.ForeColor = System.Drawing.Color.White;
            this.dropDownTipoIdentificacion.Items = new string[0];
            this.dropDownTipoIdentificacion.Location = new System.Drawing.Point(39, 228);
            this.dropDownTipoIdentificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropDownTipoIdentificacion.Name = "dropDownTipoIdentificacion";
            this.dropDownTipoIdentificacion.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.dropDownTipoIdentificacion.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.dropDownTipoIdentificacion.selectedIndex = -1;
            this.dropDownTipoIdentificacion.Size = new System.Drawing.Size(379, 29);
            this.dropDownTipoIdentificacion.TabIndex = 15;
            // 
            // FormIngresoAsociado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 606);
            this.Controls.Add(this.panelIngresoAsociadoRegresar);
            this.Controls.Add(this.tabIngresarAsociado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormIngresoAsociado";
            this.Text = "Ingresar Asociado";
            this.tabIngresarAsociado.ResumeLayout(false);
            this.tabDatosPersona.ResumeLayout(false);
            this.tabDatosPersona.PerformLayout();
            this.tabAyudaGubernamental.ResumeLayout(false);
            this.tabAyudaGubernamental.PerformLayout();
            this.tabNucleoFamiliar.ResumeLayout(false);
            this.tabNucleoFamiliar.PerformLayout();
            this.tabIngresos.ResumeLayout(false);
            this.tabIngresos.PerformLayout();
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
        private System.Windows.Forms.Label labelTituloDatosPersonales;
        private System.Windows.Forms.Panel panelImagenDatosPersonales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTituloAyudasGobierno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDatosPersonalesApellidos;
        private System.Windows.Forms.Label labelDatosPersonalesNombres;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxDatosPersonasApellidos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxDatosPersonaNombres;
        private Bunifu.Framework.UI.BunifuDropdown dropDownTipoIdentificacion;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Label labelDatosPersonalesNumeroIdentificacion;
        private System.Windows.Forms.Label labelDatosPersonalesTipoIdentificacion;
    }
}