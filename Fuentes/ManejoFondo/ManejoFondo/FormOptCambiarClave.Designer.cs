namespace ManejoFondo
{
    partial class FormOptCambiarClave
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
            this.panelCambiarContrasenia = new System.Windows.Forms.Panel();
            this.labelVerPasswordNuevo = new System.Windows.Forms.Label();
            this.labelVerPasswordNuevoRepite = new System.Windows.Forms.Label();
            this.labelVerPassword = new System.Windows.Forms.Label();
            this.textBoxCambiarClavePasswordNuevoRepite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxCambiarClavePasswordNuevo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxCambiarClavePassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buttonCambiarClaveLimpiar = new System.Windows.Forms.Button();
            this.buttonCambiarClaveCambiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCambiarClavePasswordNuevoRepite = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCambiarClavePasswordNuevo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCambiarClavePassword = new System.Windows.Forms.Label();
            this.textBoxCambiarClaveUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCambiarClaveUsuario = new System.Windows.Forms.Label();
            this.panelImagenCambioContrasenia = new System.Windows.Forms.Panel();
            this.labelTituloCambiarContrasenia = new System.Windows.Forms.Label();
            this.panelRegresarMenu = new System.Windows.Forms.Panel();
            this.panelCambiarContrasenia.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCambiarContrasenia
            // 
            this.panelCambiarContrasenia.BackColor = System.Drawing.Color.White;
            this.panelCambiarContrasenia.Controls.Add(this.labelVerPasswordNuevo);
            this.panelCambiarContrasenia.Controls.Add(this.labelVerPasswordNuevoRepite);
            this.panelCambiarContrasenia.Controls.Add(this.labelVerPassword);
            this.panelCambiarContrasenia.Controls.Add(this.textBoxCambiarClavePasswordNuevoRepite);
            this.panelCambiarContrasenia.Controls.Add(this.textBoxCambiarClavePasswordNuevo);
            this.panelCambiarContrasenia.Controls.Add(this.textBoxCambiarClavePassword);
            this.panelCambiarContrasenia.Controls.Add(this.buttonCambiarClaveLimpiar);
            this.panelCambiarContrasenia.Controls.Add(this.buttonCambiarClaveCambiar);
            this.panelCambiarContrasenia.Controls.Add(this.label6);
            this.panelCambiarContrasenia.Controls.Add(this.labelCambiarClavePasswordNuevoRepite);
            this.panelCambiarContrasenia.Controls.Add(this.label4);
            this.panelCambiarContrasenia.Controls.Add(this.labelCambiarClavePasswordNuevo);
            this.panelCambiarContrasenia.Controls.Add(this.label1);
            this.panelCambiarContrasenia.Controls.Add(this.labelCambiarClavePassword);
            this.panelCambiarContrasenia.Controls.Add(this.textBoxCambiarClaveUsuario);
            this.panelCambiarContrasenia.Controls.Add(this.label3);
            this.panelCambiarContrasenia.Controls.Add(this.labelCambiarClaveUsuario);
            this.panelCambiarContrasenia.Controls.Add(this.panelImagenCambioContrasenia);
            this.panelCambiarContrasenia.Controls.Add(this.labelTituloCambiarContrasenia);
            this.panelCambiarContrasenia.Location = new System.Drawing.Point(20, 103);
            this.panelCambiarContrasenia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCambiarContrasenia.Name = "panelCambiarContrasenia";
            this.panelCambiarContrasenia.Size = new System.Drawing.Size(1792, 796);
            this.panelCambiarContrasenia.TabIndex = 0;
            // 
            // labelVerPasswordNuevo
            // 
            this.labelVerPasswordNuevo.AutoSize = true;
            this.labelVerPasswordNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVerPasswordNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.labelVerPasswordNuevo.Location = new System.Drawing.Point(760, 382);
            this.labelVerPasswordNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVerPasswordNuevo.Name = "labelVerPasswordNuevo";
            this.labelVerPasswordNuevo.Size = new System.Drawing.Size(30, 17);
            this.labelVerPasswordNuevo.TabIndex = 30;
            this.labelVerPasswordNuevo.Text = "Ver";
            this.labelVerPasswordNuevo.MouseLeave += new System.EventHandler(this.OcultarPasswordNuevo);
            this.labelVerPasswordNuevo.MouseHover += new System.EventHandler(this.VerPasswordNuevo);
            // 
            // labelVerPasswordNuevoRepite
            // 
            this.labelVerPasswordNuevoRepite.AutoSize = true;
            this.labelVerPasswordNuevoRepite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVerPasswordNuevoRepite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.labelVerPasswordNuevoRepite.Location = new System.Drawing.Point(1461, 382);
            this.labelVerPasswordNuevoRepite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVerPasswordNuevoRepite.Name = "labelVerPasswordNuevoRepite";
            this.labelVerPasswordNuevoRepite.Size = new System.Drawing.Size(30, 17);
            this.labelVerPasswordNuevoRepite.TabIndex = 29;
            this.labelVerPasswordNuevoRepite.Text = "Ver";
            this.labelVerPasswordNuevoRepite.MouseLeave += new System.EventHandler(this.OcultarPasswordNuevoRepite);
            this.labelVerPasswordNuevoRepite.MouseHover += new System.EventHandler(this.VerPasswordNuevoRepite);
            // 
            // labelVerPassword
            // 
            this.labelVerPassword.AutoSize = true;
            this.labelVerPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVerPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.labelVerPassword.Location = new System.Drawing.Point(1461, 240);
            this.labelVerPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVerPassword.Name = "labelVerPassword";
            this.labelVerPassword.Size = new System.Drawing.Size(30, 17);
            this.labelVerPassword.TabIndex = 28;
            this.labelVerPassword.Text = "Ver";
            this.labelVerPassword.MouseLeave += new System.EventHandler(this.OcultarPasswordActual);
            this.labelVerPassword.MouseHover += new System.EventHandler(this.VerPasswordActual);
            // 
            // textBoxCambiarClavePasswordNuevoRepite
            // 
            this.textBoxCambiarClavePasswordNuevoRepite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCambiarClavePasswordNuevoRepite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxCambiarClavePasswordNuevoRepite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCambiarClavePasswordNuevoRepite.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxCambiarClavePasswordNuevoRepite.HintText = "";
            this.textBoxCambiarClavePasswordNuevoRepite.isPassword = true;
            this.textBoxCambiarClavePasswordNuevoRepite.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxCambiarClavePasswordNuevoRepite.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxCambiarClavePasswordNuevoRepite.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxCambiarClavePasswordNuevoRepite.LineThickness = 3;
            this.textBoxCambiarClavePasswordNuevoRepite.Location = new System.Drawing.Point(885, 357);
            this.textBoxCambiarClavePasswordNuevoRepite.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxCambiarClavePasswordNuevoRepite.Name = "textBoxCambiarClavePasswordNuevoRepite";
            this.textBoxCambiarClavePasswordNuevoRepite.Size = new System.Drawing.Size(567, 41);
            this.textBoxCambiarClavePasswordNuevoRepite.TabIndex = 27;
            this.textBoxCambiarClavePasswordNuevoRepite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxCambiarClavePasswordNuevoRepite.OnValueChanged += new System.EventHandler(this.MascaraPasswordNuevoRepite);
            // 
            // textBoxCambiarClavePasswordNuevo
            // 
            this.textBoxCambiarClavePasswordNuevo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCambiarClavePasswordNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxCambiarClavePasswordNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCambiarClavePasswordNuevo.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxCambiarClavePasswordNuevo.HintText = "";
            this.textBoxCambiarClavePasswordNuevo.isPassword = true;
            this.textBoxCambiarClavePasswordNuevo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxCambiarClavePasswordNuevo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxCambiarClavePasswordNuevo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxCambiarClavePasswordNuevo.LineThickness = 3;
            this.textBoxCambiarClavePasswordNuevo.Location = new System.Drawing.Point(183, 362);
            this.textBoxCambiarClavePasswordNuevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxCambiarClavePasswordNuevo.Name = "textBoxCambiarClavePasswordNuevo";
            this.textBoxCambiarClavePasswordNuevo.Size = new System.Drawing.Size(568, 36);
            this.textBoxCambiarClavePasswordNuevo.TabIndex = 26;
            this.textBoxCambiarClavePasswordNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxCambiarClavePasswordNuevo.OnValueChanged += new System.EventHandler(this.MascaraPasswordNuevo);
            // 
            // textBoxCambiarClavePassword
            // 
            this.textBoxCambiarClavePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCambiarClavePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxCambiarClavePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCambiarClavePassword.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxCambiarClavePassword.HintText = "";
            this.textBoxCambiarClavePassword.isPassword = true;
            this.textBoxCambiarClavePassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxCambiarClavePassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxCambiarClavePassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxCambiarClavePassword.LineThickness = 3;
            this.textBoxCambiarClavePassword.Location = new System.Drawing.Point(885, 222);
            this.textBoxCambiarClavePassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxCambiarClavePassword.Name = "textBoxCambiarClavePassword";
            this.textBoxCambiarClavePassword.Size = new System.Drawing.Size(567, 34);
            this.textBoxCambiarClavePassword.TabIndex = 25;
            this.textBoxCambiarClavePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxCambiarClavePassword.OnValueChanged += new System.EventHandler(this.MascaraPasswordActual);
            // 
            // buttonCambiarClaveLimpiar
            // 
            this.buttonCambiarClaveLimpiar.BackColor = System.Drawing.Color.White;
            this.buttonCambiarClaveLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCambiarClaveLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCambiarClaveLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiarClaveLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(66)))), ((int)(((byte)(45)))));
            this.buttonCambiarClaveLimpiar.Location = new System.Drawing.Point(831, 471);
            this.buttonCambiarClaveLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCambiarClaveLimpiar.Name = "buttonCambiarClaveLimpiar";
            this.buttonCambiarClaveLimpiar.Size = new System.Drawing.Size(228, 48);
            this.buttonCambiarClaveLimpiar.TabIndex = 24;
            this.buttonCambiarClaveLimpiar.Text = "Limpiar";
            this.buttonCambiarClaveLimpiar.UseVisualStyleBackColor = false;
            this.buttonCambiarClaveLimpiar.Click += new System.EventHandler(this.LimpiarInformacionCambiarClave);
            // 
            // buttonCambiarClaveCambiar
            // 
            this.buttonCambiarClaveCambiar.BackColor = System.Drawing.Color.White;
            this.buttonCambiarClaveCambiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCambiarClaveCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCambiarClaveCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiarClaveCambiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.buttonCambiarClaveCambiar.Location = new System.Drawing.Point(580, 471);
            this.buttonCambiarClaveCambiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCambiarClaveCambiar.Name = "buttonCambiarClaveCambiar";
            this.buttonCambiarClaveCambiar.Size = new System.Drawing.Size(228, 48);
            this.buttonCambiarClaveCambiar.TabIndex = 23;
            this.buttonCambiarClaveCambiar.Text = "Aceptar";
            this.buttonCambiarClaveCambiar.UseVisualStyleBackColor = false;
            this.buttonCambiarClaveCambiar.Click += new System.EventHandler(this.CambiarClave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1523, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 35);
            this.label6.TabIndex = 21;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelCambiarClavePasswordNuevoRepite
            // 
            this.labelCambiarClavePasswordNuevoRepite.AutoSize = true;
            this.labelCambiarClavePasswordNuevoRepite.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambiarClavePasswordNuevoRepite.ForeColor = System.Drawing.Color.Black;
            this.labelCambiarClavePasswordNuevoRepite.Location = new System.Drawing.Point(881, 325);
            this.labelCambiarClavePasswordNuevoRepite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCambiarClavePasswordNuevoRepite.Name = "labelCambiarClavePasswordNuevoRepite";
            this.labelCambiarClavePasswordNuevoRepite.Size = new System.Drawing.Size(267, 23);
            this.labelCambiarClavePasswordNuevoRepite.TabIndex = 20;
            this.labelCambiarClavePasswordNuevoRepite.Text = "Repita Nueva Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(816, 367);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 35);
            this.label4.TabIndex = 18;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelCambiarClavePasswordNuevo
            // 
            this.labelCambiarClavePasswordNuevo.AutoSize = true;
            this.labelCambiarClavePasswordNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambiarClavePasswordNuevo.ForeColor = System.Drawing.Color.Black;
            this.labelCambiarClavePasswordNuevo.Location = new System.Drawing.Point(179, 325);
            this.labelCambiarClavePasswordNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCambiarClavePasswordNuevo.Name = "labelCambiarClavePasswordNuevo";
            this.labelCambiarClavePasswordNuevo.Size = new System.Drawing.Size(198, 23);
            this.labelCambiarClavePasswordNuevo.TabIndex = 17;
            this.labelCambiarClavePasswordNuevo.Text = "Nueva Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1523, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelCambiarClavePassword
            // 
            this.labelCambiarClavePassword.AutoSize = true;
            this.labelCambiarClavePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambiarClavePassword.ForeColor = System.Drawing.Color.Black;
            this.labelCambiarClavePassword.Location = new System.Drawing.Point(881, 198);
            this.labelCambiarClavePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCambiarClavePassword.Name = "labelCambiarClavePassword";
            this.labelCambiarClavePassword.Size = new System.Drawing.Size(197, 23);
            this.labelCambiarClavePassword.TabIndex = 14;
            this.labelCambiarClavePassword.Text = "Contraseña Actual";
            // 
            // textBoxCambiarClaveUsuario
            // 
            this.textBoxCambiarClaveUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCambiarClaveUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxCambiarClaveUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCambiarClaveUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxCambiarClaveUsuario.HintText = "";
            this.textBoxCambiarClaveUsuario.isPassword = false;
            this.textBoxCambiarClaveUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxCambiarClaveUsuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxCambiarClaveUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(88)))), ((int)(((byte)(160)))));
            this.textBoxCambiarClaveUsuario.LineThickness = 3;
            this.textBoxCambiarClaveUsuario.Location = new System.Drawing.Point(183, 222);
            this.textBoxCambiarClaveUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxCambiarClaveUsuario.Name = "textBoxCambiarClaveUsuario";
            this.textBoxCambiarClaveUsuario.Size = new System.Drawing.Size(568, 34);
            this.textBoxCambiarClaveUsuario.TabIndex = 13;
            this.textBoxCambiarClaveUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(816, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelCambiarClaveUsuario
            // 
            this.labelCambiarClaveUsuario.AutoSize = true;
            this.labelCambiarClaveUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambiarClaveUsuario.ForeColor = System.Drawing.Color.Black;
            this.labelCambiarClaveUsuario.Location = new System.Drawing.Point(179, 198);
            this.labelCambiarClaveUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCambiarClaveUsuario.Name = "labelCambiarClaveUsuario";
            this.labelCambiarClaveUsuario.Size = new System.Drawing.Size(79, 23);
            this.labelCambiarClaveUsuario.TabIndex = 11;
            this.labelCambiarClaveUsuario.Text = "Usuario";
            // 
            // panelImagenCambioContrasenia
            // 
            this.panelImagenCambioContrasenia.BackColor = System.Drawing.Color.White;
            this.panelImagenCambioContrasenia.BackgroundImage = global::ManejoFondo.Properties.Resources.cambiarClaveUsuario;
            this.panelImagenCambioContrasenia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImagenCambioContrasenia.Location = new System.Drawing.Point(1565, 15);
            this.panelImagenCambioContrasenia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelImagenCambioContrasenia.Name = "panelImagenCambioContrasenia";
            this.panelImagenCambioContrasenia.Size = new System.Drawing.Size(207, 130);
            this.panelImagenCambioContrasenia.TabIndex = 5;
            // 
            // labelTituloCambiarContrasenia
            // 
            this.labelTituloCambiarContrasenia.AutoSize = true;
            this.labelTituloCambiarContrasenia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCambiarContrasenia.ForeColor = System.Drawing.Color.Black;
            this.labelTituloCambiarContrasenia.Location = new System.Drawing.Point(364, 57);
            this.labelTituloCambiarContrasenia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloCambiarContrasenia.Name = "labelTituloCambiarContrasenia";
            this.labelTituloCambiarContrasenia.Size = new System.Drawing.Size(863, 27);
            this.labelTituloCambiarContrasenia.TabIndex = 4;
            this.labelTituloCambiarContrasenia.Text = "POR FAVOR INGRESAR LA INFORMACIÓN PARA CAMBIO DE CONTRASEÑA";
            // 
            // panelRegresarMenu
            // 
            this.panelRegresarMenu.BackColor = System.Drawing.Color.White;
            this.panelRegresarMenu.BackgroundImage = global::ManejoFondo.Properties.Resources.regresar;
            this.panelRegresarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegresarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelRegresarMenu.Font = new System.Drawing.Font("Arial", 12F);
            this.panelRegresarMenu.ForeColor = System.Drawing.Color.Transparent;
            this.panelRegresarMenu.Location = new System.Drawing.Point(55, 150);
            this.panelRegresarMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRegresarMenu.Name = "panelRegresarMenu";
            this.panelRegresarMenu.Size = new System.Drawing.Size(41, 38);
            this.panelRegresarMenu.TabIndex = 3;
            this.panelRegresarMenu.Click += new System.EventHandler(this.RegresarMenuPrincipal);
            // 
            // FormOptCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1824, 788);
            this.Controls.Add(this.panelRegresarMenu);
            this.Controls.Add(this.panelCambiarContrasenia);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormOptCambiarClave";
            this.Text = "Cambiar Contraseña";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelCambiarContrasenia.ResumeLayout(false);
            this.panelCambiarContrasenia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCambiarContrasenia;
        private System.Windows.Forms.Panel panelRegresarMenu;
        private System.Windows.Forms.Label labelTituloCambiarContrasenia;
        private System.Windows.Forms.Panel panelImagenCambioContrasenia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCambiarClavePasswordNuevoRepite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCambiarClavePasswordNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCambiarClavePassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxCambiarClaveUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCambiarClaveUsuario;
        private System.Windows.Forms.Button buttonCambiarClaveLimpiar;
        private System.Windows.Forms.Button buttonCambiarClaveCambiar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxCambiarClavePassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxCambiarClavePasswordNuevoRepite;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxCambiarClavePasswordNuevo;
        private System.Windows.Forms.Label labelVerPasswordNuevo;
        private System.Windows.Forms.Label labelVerPasswordNuevoRepite;
        private System.Windows.Forms.Label labelVerPassword;
    }
}