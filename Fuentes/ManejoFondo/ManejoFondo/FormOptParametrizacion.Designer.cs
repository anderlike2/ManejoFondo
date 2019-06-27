namespace ManejoFondo
{
    partial class FormOptParametrizacion
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
            this.panelParametrizacion = new System.Windows.Forms.Panel();
            this.labelTextoSeleccionarEditar = new System.Windows.Forms.Label();
            this.buttonEditarParametro = new System.Windows.Forms.Button();
            this.dataGridParametrizacion = new System.Windows.Forms.DataGridView();
            this.labelTituloParametrizacionSistema = new System.Windows.Forms.Label();
            this.panelImagenConsultaUsuarios = new System.Windows.Forms.Panel();
            this.panelRegresarMenu = new System.Windows.Forms.Panel();
            this.nIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vValorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fondoParametrosEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelParametrizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParametrizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoParametrosEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelParametrizacion
            // 
            this.panelParametrizacion.BackColor = System.Drawing.Color.White;
            this.panelParametrizacion.Controls.Add(this.labelTextoSeleccionarEditar);
            this.panelParametrizacion.Controls.Add(this.buttonEditarParametro);
            this.panelParametrizacion.Controls.Add(this.dataGridParametrizacion);
            this.panelParametrizacion.Controls.Add(this.panelImagenConsultaUsuarios);
            this.panelParametrizacion.Controls.Add(this.labelTituloParametrizacionSistema);
            this.panelParametrizacion.Controls.Add(this.panelRegresarMenu);
            this.panelParametrizacion.Location = new System.Drawing.Point(15, 84);
            this.panelParametrizacion.Name = "panelParametrizacion";
            this.panelParametrizacion.Size = new System.Drawing.Size(1344, 647);
            this.panelParametrizacion.TabIndex = 0;
            // 
            // labelTextoSeleccionarEditar
            // 
            this.labelTextoSeleccionarEditar.AutoSize = true;
            this.labelTextoSeleccionarEditar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoSeleccionarEditar.Location = new System.Drawing.Point(62, 127);
            this.labelTextoSeleccionarEditar.Name = "labelTextoSeleccionarEditar";
            this.labelTextoSeleccionarEditar.Size = new System.Drawing.Size(559, 20);
            this.labelTextoSeleccionarEditar.TabIndex = 10;
            this.labelTextoSeleccionarEditar.Text = "Por favor seleccione la fila deseada y a continuación presione \"Editar\" para modi" +
    "ficar la información.";
            // 
            // buttonEditarParametro
            // 
            this.buttonEditarParametro.BackColor = System.Drawing.Color.White;
            this.buttonEditarParametro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarParametro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarParametro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.buttonEditarParametro.Location = new System.Drawing.Point(505, 437);
            this.buttonEditarParametro.Name = "buttonEditarParametro";
            this.buttonEditarParametro.Size = new System.Drawing.Size(253, 39);
            this.buttonEditarParametro.TabIndex = 9;
            this.buttonEditarParametro.Text = "Editar";
            this.buttonEditarParametro.UseVisualStyleBackColor = false;
            this.buttonEditarParametro.Click += new System.EventHandler(this.AbrirModalEditarParametro);
            // 
            // dataGridParametrizacion
            // 
            this.dataGridParametrizacion.AllowUserToAddRows = false;
            this.dataGridParametrizacion.AllowUserToDeleteRows = false;
            this.dataGridParametrizacion.AutoGenerateColumns = false;
            this.dataGridParametrizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridParametrizacion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridParametrizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParametrizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIdDataGridViewTextBoxColumn,
            this.vNombreDataGridViewTextBoxColumn,
            this.vValorDataGridViewTextBoxColumn,
            this.vDescripcionDataGridViewTextBoxColumn});
            this.dataGridParametrizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridParametrizacion.DataSource = this.fondoParametrosEntityBindingSource;
            this.dataGridParametrizacion.Location = new System.Drawing.Point(65, 154);
            this.dataGridParametrizacion.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridParametrizacion.Name = "dataGridParametrizacion";
            this.dataGridParametrizacion.ReadOnly = true;
            this.dataGridParametrizacion.Size = new System.Drawing.Size(1205, 252);
            this.dataGridParametrizacion.TabIndex = 7;
            // 
            // labelTituloParametrizacionSistema
            // 
            this.labelTituloParametrizacionSistema.AutoSize = true;
            this.labelTituloParametrizacionSistema.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloParametrizacionSistema.ForeColor = System.Drawing.Color.Black;
            this.labelTituloParametrizacionSistema.Location = new System.Drawing.Point(350, 46);
            this.labelTituloParametrizacionSistema.Name = "labelTituloParametrizacionSistema";
            this.labelTituloParametrizacionSistema.Size = new System.Drawing.Size(578, 22);
            this.labelTituloParametrizacionSistema.TabIndex = 5;
            this.labelTituloParametrizacionSistema.Text = "POR FAVOR INGRESAR LA PARAMETRIZACIÓN DEL SISTEMA";
            // 
            // panelImagenConsultaUsuarios
            // 
            this.panelImagenConsultaUsuarios.BackColor = System.Drawing.Color.White;
            this.panelImagenConsultaUsuarios.BackgroundImage = global::ManejoFondo.Properties.Resources.parametrizacionSistema;
            this.panelImagenConsultaUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImagenConsultaUsuarios.Location = new System.Drawing.Point(1215, 12);
            this.panelImagenConsultaUsuarios.Name = "panelImagenConsultaUsuarios";
            this.panelImagenConsultaUsuarios.Size = new System.Drawing.Size(85, 85);
            this.panelImagenConsultaUsuarios.TabIndex = 6;
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
            this.panelRegresarMenu.TabIndex = 4;
            this.panelRegresarMenu.Click += new System.EventHandler(this.RegresarMenuPrincipal);
            // 
            // nIdDataGridViewTextBoxColumn
            // 
            this.nIdDataGridViewTextBoxColumn.DataPropertyName = "N_Id";
            this.nIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.nIdDataGridViewTextBoxColumn.Name = "nIdDataGridViewTextBoxColumn";
            this.nIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vNombreDataGridViewTextBoxColumn
            // 
            this.vNombreDataGridViewTextBoxColumn.DataPropertyName = "V_Nombre";
            this.vNombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.vNombreDataGridViewTextBoxColumn.Name = "vNombreDataGridViewTextBoxColumn";
            this.vNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vValorDataGridViewTextBoxColumn
            // 
            this.vValorDataGridViewTextBoxColumn.DataPropertyName = "V_Valor";
            this.vValorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vValorDataGridViewTextBoxColumn.Name = "vValorDataGridViewTextBoxColumn";
            this.vValorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDescripcionDataGridViewTextBoxColumn
            // 
            this.vDescripcionDataGridViewTextBoxColumn.DataPropertyName = "V_Descripcion";
            this.vDescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.vDescripcionDataGridViewTextBoxColumn.Name = "vDescripcionDataGridViewTextBoxColumn";
            this.vDescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fondoParametrosEntityBindingSource
            // 
            this.fondoParametrosEntityBindingSource.DataSource = typeof(ManejoFondo.Entities.FondoParametrosEntity);
            // 
            // FormOptParametrizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1368, 640);
            this.Controls.Add(this.panelParametrizacion);
            this.MaximizeBox = false;
            this.Name = "FormOptParametrizacion";
            this.Text = "Parametrización";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelParametrizacion.ResumeLayout(false);
            this.panelParametrizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParametrizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoParametrosEntityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelParametrizacion;
        private System.Windows.Forms.Panel panelRegresarMenu;
        private System.Windows.Forms.Label labelTituloParametrizacionSistema;
        private System.Windows.Forms.Panel panelImagenConsultaUsuarios;
        private System.Windows.Forms.BindingSource fondoParametrosEntityBindingSource;
        private System.Windows.Forms.DataGridView dataGridParametrizacion;
        private System.Windows.Forms.Button buttonEditarParametro;
        private System.Windows.Forms.Label labelTextoSeleccionarEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDescripcionDataGridViewTextBoxColumn;
    }
}