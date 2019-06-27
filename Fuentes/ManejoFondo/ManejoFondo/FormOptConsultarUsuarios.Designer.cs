namespace ManejoFondo
{
    partial class FormOptConsultarUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.panelConsultaUsuarios = new System.Windows.Forms.Panel();
            this.labelTituloConsultaUsuarios = new System.Windows.Forms.Label();
            this.panelImagenParametrizacion = new System.Windows.Forms.Panel();
            this.panelRegresarMenu = new System.Windows.Forms.Panel();
            this.comboBoxConsultaUsuariosTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.textBoxConsultaUsuariosNumeroIdentificacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelConsultaUsuariosNumeroIdentificacion = new System.Windows.Forms.Label();
            this.labelConsultaUsuariosTipoIdentificacion = new System.Windows.Forms.Label();
            this.textBoxConsultaUsuariosApellidos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxConsultaUsuariosNombres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelConsultaUsuariosApellidos = new System.Windows.Forms.Label();
            this.labelConsultaUsuariosNombres = new System.Windows.Forms.Label();
            this.datePickerConsultaUsuariosFechaRegistroDesde = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.labelConsultaUsuariosFechaRegistroDesde = new System.Windows.Forms.Label();
            this.datePickerConsultaUsuariosFechaRegistroHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelConsultaUsuariosFechaRegistroHasta = new System.Windows.Forms.Label();
            this.dataGridConsultaUsuarios = new System.Windows.Forms.DataGridView();
            this.tipoIdentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTipoIdentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroIdentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioConsultaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonConsultarUsuariosLimpiar = new System.Windows.Forms.Button();
            this.buttonConsultarUsuariosConsultar = new System.Windows.Forms.Button();
            this.panelConsultaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioConsultaModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultaUsuarios
            // 
            this.panelConsultaUsuarios.BackColor = System.Drawing.Color.White;
            this.panelConsultaUsuarios.Controls.Add(this.buttonConsultarUsuariosLimpiar);
            this.panelConsultaUsuarios.Controls.Add(this.buttonConsultarUsuariosConsultar);
            this.panelConsultaUsuarios.Controls.Add(this.dataGridConsultaUsuarios);
            this.panelConsultaUsuarios.Controls.Add(this.datePickerConsultaUsuariosFechaRegistroHasta);
            this.panelConsultaUsuarios.Controls.Add(this.label1);
            this.panelConsultaUsuarios.Controls.Add(this.labelConsultaUsuariosFechaRegistroHasta);
            this.panelConsultaUsuarios.Controls.Add(this.datePickerConsultaUsuariosFechaRegistroDesde);
            this.panelConsultaUsuarios.Controls.Add(this.label13);
            this.panelConsultaUsuarios.Controls.Add(this.labelConsultaUsuariosFechaRegistroDesde);
            this.panelConsultaUsuarios.Controls.Add(this.textBoxConsultaUsuariosApellidos);
            this.panelConsultaUsuarios.Controls.Add(this.textBoxConsultaUsuariosNombres);
            this.panelConsultaUsuarios.Controls.Add(this.labelConsultaUsuariosApellidos);
            this.panelConsultaUsuarios.Controls.Add(this.labelConsultaUsuariosNombres);
            this.panelConsultaUsuarios.Controls.Add(this.comboBoxConsultaUsuariosTipoIdentificacion);
            this.panelConsultaUsuarios.Controls.Add(this.textBoxConsultaUsuariosNumeroIdentificacion);
            this.panelConsultaUsuarios.Controls.Add(this.labelConsultaUsuariosNumeroIdentificacion);
            this.panelConsultaUsuarios.Controls.Add(this.labelConsultaUsuariosTipoIdentificacion);
            this.panelConsultaUsuarios.Controls.Add(this.panelImagenParametrizacion);
            this.panelConsultaUsuarios.Controls.Add(this.labelTituloConsultaUsuarios);
            this.panelConsultaUsuarios.Controls.Add(this.panelRegresarMenu);
            this.panelConsultaUsuarios.Location = new System.Drawing.Point(15, 84);
            this.panelConsultaUsuarios.Name = "panelConsultaUsuarios";
            this.panelConsultaUsuarios.Size = new System.Drawing.Size(1344, 647);
            this.panelConsultaUsuarios.TabIndex = 0;
            // 
            // labelTituloConsultaUsuarios
            // 
            this.labelTituloConsultaUsuarios.AutoSize = true;
            this.labelTituloConsultaUsuarios.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloConsultaUsuarios.ForeColor = System.Drawing.Color.Black;
            this.labelTituloConsultaUsuarios.Location = new System.Drawing.Point(270, 47);
            this.labelTituloConsultaUsuarios.Name = "labelTituloConsultaUsuarios";
            this.labelTituloConsultaUsuarios.Size = new System.Drawing.Size(787, 22);
            this.labelTituloConsultaUsuarios.TabIndex = 6;
            this.labelTituloConsultaUsuarios.Text = "POR FAVOR INGRESAR LOS FILTROS PARA REALIZAR LA CONSULTA DE USUARIOS";
            // 
            // panelImagenParametrizacion
            // 
            this.panelImagenParametrizacion.BackColor = System.Drawing.Color.White;
            this.panelImagenParametrizacion.BackgroundImage = global::ManejoFondo.Properties.Resources.consultaUsuarios;
            this.panelImagenParametrizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImagenParametrizacion.Location = new System.Drawing.Point(1215, 12);
            this.panelImagenParametrizacion.Name = "panelImagenParametrizacion";
            this.panelImagenParametrizacion.Size = new System.Drawing.Size(85, 85);
            this.panelImagenParametrizacion.TabIndex = 7;
            // 
            // panelRegresarMenu
            // 
            this.panelRegresarMenu.BackColor = System.Drawing.Color.White;
            this.panelRegresarMenu.BackgroundImage = global::ManejoFondo.Properties.Resources.regresar;
            this.panelRegresarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegresarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelRegresarMenu.Font = new System.Drawing.Font("Arial", 12F);
            this.panelRegresarMenu.ForeColor = System.Drawing.Color.Transparent;
            this.panelRegresarMenu.Location = new System.Drawing.Point(26, 38);
            this.panelRegresarMenu.Name = "panelRegresarMenu";
            this.panelRegresarMenu.Size = new System.Drawing.Size(31, 31);
            this.panelRegresarMenu.TabIndex = 5;
            this.panelRegresarMenu.Click += new System.EventHandler(this.RegresarMenuPrincipal);
            // 
            // comboBoxConsultaUsuariosTipoIdentificacion
            // 
            this.comboBoxConsultaUsuariosTipoIdentificacion.BackColor = System.Drawing.Color.White;
            this.comboBoxConsultaUsuariosTipoIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.comboBoxConsultaUsuariosTipoIdentificacion.Location = new System.Drawing.Point(144, 174);
            this.comboBoxConsultaUsuariosTipoIdentificacion.Name = "comboBoxConsultaUsuariosTipoIdentificacion";
            this.comboBoxConsultaUsuariosTipoIdentificacion.Size = new System.Drawing.Size(427, 21);
            this.comboBoxConsultaUsuariosTipoIdentificacion.TabIndex = 36;
            // 
            // textBoxConsultaUsuariosNumeroIdentificacion
            // 
            this.textBoxConsultaUsuariosNumeroIdentificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxConsultaUsuariosNumeroIdentificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxConsultaUsuariosNumeroIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxConsultaUsuariosNumeroIdentificacion.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxConsultaUsuariosNumeroIdentificacion.HintText = "";
            this.textBoxConsultaUsuariosNumeroIdentificacion.isPassword = false;
            this.textBoxConsultaUsuariosNumeroIdentificacion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxConsultaUsuariosNumeroIdentificacion.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxConsultaUsuariosNumeroIdentificacion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxConsultaUsuariosNumeroIdentificacion.LineThickness = 3;
            this.textBoxConsultaUsuariosNumeroIdentificacion.Location = new System.Drawing.Point(705, 168);
            this.textBoxConsultaUsuariosNumeroIdentificacion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConsultaUsuariosNumeroIdentificacion.Name = "textBoxConsultaUsuariosNumeroIdentificacion";
            this.textBoxConsultaUsuariosNumeroIdentificacion.Size = new System.Drawing.Size(427, 29);
            this.textBoxConsultaUsuariosNumeroIdentificacion.TabIndex = 34;
            this.textBoxConsultaUsuariosNumeroIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelConsultaUsuariosNumeroIdentificacion
            // 
            this.labelConsultaUsuariosNumeroIdentificacion.AutoSize = true;
            this.labelConsultaUsuariosNumeroIdentificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaUsuariosNumeroIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.labelConsultaUsuariosNumeroIdentificacion.Location = new System.Drawing.Point(701, 145);
            this.labelConsultaUsuariosNumeroIdentificacion.Name = "labelConsultaUsuariosNumeroIdentificacion";
            this.labelConsultaUsuariosNumeroIdentificacion.Size = new System.Drawing.Size(184, 21);
            this.labelConsultaUsuariosNumeroIdentificacion.TabIndex = 33;
            this.labelConsultaUsuariosNumeroIdentificacion.Text = "Número Identificación";
            // 
            // labelConsultaUsuariosTipoIdentificacion
            // 
            this.labelConsultaUsuariosTipoIdentificacion.AutoSize = true;
            this.labelConsultaUsuariosTipoIdentificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaUsuariosTipoIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.labelConsultaUsuariosTipoIdentificacion.Location = new System.Drawing.Point(140, 145);
            this.labelConsultaUsuariosTipoIdentificacion.Name = "labelConsultaUsuariosTipoIdentificacion";
            this.labelConsultaUsuariosTipoIdentificacion.Size = new System.Drawing.Size(154, 21);
            this.labelConsultaUsuariosTipoIdentificacion.TabIndex = 32;
            this.labelConsultaUsuariosTipoIdentificacion.Text = "Tipo Identificación";
            // 
            // textBoxConsultaUsuariosApellidos
            // 
            this.textBoxConsultaUsuariosApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxConsultaUsuariosApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxConsultaUsuariosApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxConsultaUsuariosApellidos.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxConsultaUsuariosApellidos.HintText = "";
            this.textBoxConsultaUsuariosApellidos.isPassword = false;
            this.textBoxConsultaUsuariosApellidos.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxConsultaUsuariosApellidos.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxConsultaUsuariosApellidos.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxConsultaUsuariosApellidos.LineThickness = 3;
            this.textBoxConsultaUsuariosApellidos.Location = new System.Drawing.Point(705, 96);
            this.textBoxConsultaUsuariosApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConsultaUsuariosApellidos.Name = "textBoxConsultaUsuariosApellidos";
            this.textBoxConsultaUsuariosApellidos.Size = new System.Drawing.Size(427, 29);
            this.textBoxConsultaUsuariosApellidos.TabIndex = 43;
            this.textBoxConsultaUsuariosApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxConsultaUsuariosNombres
            // 
            this.textBoxConsultaUsuariosNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxConsultaUsuariosNombres.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxConsultaUsuariosNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxConsultaUsuariosNombres.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxConsultaUsuariosNombres.HintText = "";
            this.textBoxConsultaUsuariosNombres.isPassword = false;
            this.textBoxConsultaUsuariosNombres.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxConsultaUsuariosNombres.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxConsultaUsuariosNombres.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxConsultaUsuariosNombres.LineThickness = 3;
            this.textBoxConsultaUsuariosNombres.Location = new System.Drawing.Point(144, 96);
            this.textBoxConsultaUsuariosNombres.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConsultaUsuariosNombres.Name = "textBoxConsultaUsuariosNombres";
            this.textBoxConsultaUsuariosNombres.Size = new System.Drawing.Size(427, 29);
            this.textBoxConsultaUsuariosNombres.TabIndex = 42;
            this.textBoxConsultaUsuariosNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelConsultaUsuariosApellidos
            // 
            this.labelConsultaUsuariosApellidos.AutoSize = true;
            this.labelConsultaUsuariosApellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaUsuariosApellidos.ForeColor = System.Drawing.Color.Black;
            this.labelConsultaUsuariosApellidos.Location = new System.Drawing.Point(701, 76);
            this.labelConsultaUsuariosApellidos.Name = "labelConsultaUsuariosApellidos";
            this.labelConsultaUsuariosApellidos.Size = new System.Drawing.Size(80, 21);
            this.labelConsultaUsuariosApellidos.TabIndex = 39;
            this.labelConsultaUsuariosApellidos.Text = "Apellidos";
            // 
            // labelConsultaUsuariosNombres
            // 
            this.labelConsultaUsuariosNombres.AutoSize = true;
            this.labelConsultaUsuariosNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaUsuariosNombres.ForeColor = System.Drawing.Color.Black;
            this.labelConsultaUsuariosNombres.Location = new System.Drawing.Point(140, 76);
            this.labelConsultaUsuariosNombres.Name = "labelConsultaUsuariosNombres";
            this.labelConsultaUsuariosNombres.Size = new System.Drawing.Size(79, 21);
            this.labelConsultaUsuariosNombres.TabIndex = 38;
            this.labelConsultaUsuariosNombres.Text = "Nombres";
            // 
            // datePickerConsultaUsuariosFechaRegistroDesde
            // 
            this.datePickerConsultaUsuariosFechaRegistroDesde.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.datePickerConsultaUsuariosFechaRegistroDesde.Location = new System.Drawing.Point(142, 244);
            this.datePickerConsultaUsuariosFechaRegistroDesde.Name = "datePickerConsultaUsuariosFechaRegistroDesde";
            this.datePickerConsultaUsuariosFechaRegistroDesde.Size = new System.Drawing.Size(427, 20);
            this.datePickerConsultaUsuariosFechaRegistroDesde.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(589, 241);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 29);
            this.label13.TabIndex = 48;
            this.label13.Text = "*";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelConsultaUsuariosFechaRegistroDesde
            // 
            this.labelConsultaUsuariosFechaRegistroDesde.AutoSize = true;
            this.labelConsultaUsuariosFechaRegistroDesde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaUsuariosFechaRegistroDesde.ForeColor = System.Drawing.Color.Black;
            this.labelConsultaUsuariosFechaRegistroDesde.Location = new System.Drawing.Point(140, 218);
            this.labelConsultaUsuariosFechaRegistroDesde.Name = "labelConsultaUsuariosFechaRegistroDesde";
            this.labelConsultaUsuariosFechaRegistroDesde.Size = new System.Drawing.Size(178, 21);
            this.labelConsultaUsuariosFechaRegistroDesde.TabIndex = 47;
            this.labelConsultaUsuariosFechaRegistroDesde.Text = "Fecha Registro Desde";
            // 
            // datePickerConsultaUsuariosFechaRegistroHasta
            // 
            this.datePickerConsultaUsuariosFechaRegistroHasta.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.datePickerConsultaUsuariosFechaRegistroHasta.Location = new System.Drawing.Point(703, 244);
            this.datePickerConsultaUsuariosFechaRegistroHasta.Name = "datePickerConsultaUsuariosFechaRegistroHasta";
            this.datePickerConsultaUsuariosFechaRegistroHasta.Size = new System.Drawing.Size(427, 20);
            this.datePickerConsultaUsuariosFechaRegistroHasta.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1150, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelConsultaUsuariosFechaRegistroHasta
            // 
            this.labelConsultaUsuariosFechaRegistroHasta.AutoSize = true;
            this.labelConsultaUsuariosFechaRegistroHasta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaUsuariosFechaRegistroHasta.ForeColor = System.Drawing.Color.Black;
            this.labelConsultaUsuariosFechaRegistroHasta.Location = new System.Drawing.Point(701, 218);
            this.labelConsultaUsuariosFechaRegistroHasta.Name = "labelConsultaUsuariosFechaRegistroHasta";
            this.labelConsultaUsuariosFechaRegistroHasta.Size = new System.Drawing.Size(175, 21);
            this.labelConsultaUsuariosFechaRegistroHasta.TabIndex = 50;
            this.labelConsultaUsuariosFechaRegistroHasta.Text = "Fecha Registro Hasta";
            // 
            // dataGridConsultaUsuarios
            // 
            this.dataGridConsultaUsuarios.AllowUserToAddRows = false;
            this.dataGridConsultaUsuarios.AllowUserToDeleteRows = false;
            this.dataGridConsultaUsuarios.AutoGenerateColumns = false;
            this.dataGridConsultaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridConsultaUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridConsultaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoIdentificacionDataGridViewTextBoxColumn,
            this.codTipoIdentificacionDataGridViewTextBoxColumn,
            this.numeroIdentificacionDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.fechaRegistroDataGridViewTextBoxColumn});
            this.dataGridConsultaUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridConsultaUsuarios.DataSource = this.usuarioConsultaModelBindingSource;
            this.dataGridConsultaUsuarios.Location = new System.Drawing.Point(26, 360);
            this.dataGridConsultaUsuarios.Name = "dataGridConsultaUsuarios";
            this.dataGridConsultaUsuarios.ReadOnly = true;
            this.dataGridConsultaUsuarios.Size = new System.Drawing.Size(1284, 232);
            this.dataGridConsultaUsuarios.TabIndex = 53;
            // 
            // tipoIdentificacionDataGridViewTextBoxColumn
            // 
            this.tipoIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "TipoIdentificacion";
            this.tipoIdentificacionDataGridViewTextBoxColumn.HeaderText = "Tipo ID";
            this.tipoIdentificacionDataGridViewTextBoxColumn.Name = "tipoIdentificacionDataGridViewTextBoxColumn";
            this.tipoIdentificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codTipoIdentificacionDataGridViewTextBoxColumn
            // 
            this.codTipoIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "CodTipoIdentificacion";
            this.codTipoIdentificacionDataGridViewTextBoxColumn.HeaderText = "CodTipoIdentificacion";
            this.codTipoIdentificacionDataGridViewTextBoxColumn.Name = "codTipoIdentificacionDataGridViewTextBoxColumn";
            this.codTipoIdentificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.codTipoIdentificacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroIdentificacionDataGridViewTextBoxColumn
            // 
            this.numeroIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "NumeroIdentificacion";
            this.numeroIdentificacionDataGridViewTextBoxColumn.HeaderText = "Número ID";
            this.numeroIdentificacionDataGridViewTextBoxColumn.Name = "numeroIdentificacionDataGridViewTextBoxColumn";
            this.numeroIdentificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            this.fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            this.fechaRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioConsultaModelBindingSource
            // 
            this.usuarioConsultaModelBindingSource.DataSource = typeof(ManejoFondo.Modelos.UsuarioConsultaModel);
            // 
            // buttonConsultarUsuariosLimpiar
            // 
            this.buttonConsultarUsuariosLimpiar.BackColor = System.Drawing.Color.White;
            this.buttonConsultarUsuariosLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsultarUsuariosLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultarUsuariosLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultarUsuariosLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(66)))), ((int)(((byte)(45)))));
            this.buttonConsultarUsuariosLimpiar.Location = new System.Drawing.Point(675, 304);
            this.buttonConsultarUsuariosLimpiar.Name = "buttonConsultarUsuariosLimpiar";
            this.buttonConsultarUsuariosLimpiar.Size = new System.Drawing.Size(253, 39);
            this.buttonConsultarUsuariosLimpiar.TabIndex = 72;
            this.buttonConsultarUsuariosLimpiar.Text = "Limpiar";
            this.buttonConsultarUsuariosLimpiar.UseVisualStyleBackColor = false;
            // 
            // buttonConsultarUsuariosConsultar
            // 
            this.buttonConsultarUsuariosConsultar.BackColor = System.Drawing.Color.White;
            this.buttonConsultarUsuariosConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsultarUsuariosConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultarUsuariosConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultarUsuariosConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.buttonConsultarUsuariosConsultar.Location = new System.Drawing.Point(416, 304);
            this.buttonConsultarUsuariosConsultar.Name = "buttonConsultarUsuariosConsultar";
            this.buttonConsultarUsuariosConsultar.Size = new System.Drawing.Size(253, 39);
            this.buttonConsultarUsuariosConsultar.TabIndex = 71;
            this.buttonConsultarUsuariosConsultar.Text = "Consultar";
            this.buttonConsultarUsuariosConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultarUsuariosConsultar.Click += new System.EventHandler(this.ConsultarUsuarios);
            // 
            // FormOptConsultarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1368, 640);
            this.Controls.Add(this.panelConsultaUsuarios);
            this.MaximizeBox = false;
            this.Name = "FormOptConsultarUsuarios";
            this.Text = "Consulta de Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelConsultaUsuarios.ResumeLayout(false);
            this.panelConsultaUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioConsultaModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultaUsuarios;
        private System.Windows.Forms.Panel panelRegresarMenu;
        private System.Windows.Forms.Label labelTituloConsultaUsuarios;
        private System.Windows.Forms.Panel panelImagenParametrizacion;
        private System.Windows.Forms.ComboBox comboBoxConsultaUsuariosTipoIdentificacion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxConsultaUsuariosNumeroIdentificacion;
        private System.Windows.Forms.Label labelConsultaUsuariosNumeroIdentificacion;
        private System.Windows.Forms.Label labelConsultaUsuariosTipoIdentificacion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxConsultaUsuariosApellidos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxConsultaUsuariosNombres;
        private System.Windows.Forms.Label labelConsultaUsuariosApellidos;
        private System.Windows.Forms.Label labelConsultaUsuariosNombres;
        private System.Windows.Forms.DateTimePicker datePickerConsultaUsuariosFechaRegistroHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConsultaUsuariosFechaRegistroHasta;
        private System.Windows.Forms.DateTimePicker datePickerConsultaUsuariosFechaRegistroDesde;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelConsultaUsuariosFechaRegistroDesde;
        private System.Windows.Forms.DataGridView dataGridConsultaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoIdentificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoIdentificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroIdentificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuarioConsultaModelBindingSource;
        private System.Windows.Forms.Button buttonConsultarUsuariosLimpiar;
        private System.Windows.Forms.Button buttonConsultarUsuariosConsultar;
    }
}