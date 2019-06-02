using ManejoFondo.Common;
using ManejoFondo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
using ManejoFondo.Services;
using ManejoFondo.Loggers;

namespace ManejoFondo
{
    /// <summary>
    /// Clase para iniciar el formulario de Ingreso de Asociados
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>  
    public partial class FormIngresoAsociado : MaterialForm
    {
        //Variable para guardar el usuario que inicio sesion
        FondoLoginEntity usuarioSesion;
        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();

        public FormIngresoAsociado(FondoLoginEntity usuario)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Cambiar Tema form
            General.InicializarTema(this);

            //Width del tabControl
            tabIngresarAsociado.ItemSize = new Size(tabIngresarAsociado.Width / tabIngresarAsociado.TabCount, 0);

            //Ajustar height
            var bounds = Screen.FromControl(this).Bounds;
            this.Height = bounds.Height - 100;

            //Valores por defecto
            InicializarTooltips();
            usuarioSesion = usuario;
            InicializarCombobox();
            CargarCombobox();
        }

        /// <summary>
        /// Inicializar Tooltips
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void InicializarTooltips()
        {
            //Crear Tooltips
            ToolTip toolTip = new ToolTip();

            //Se agrega atributos del tooltip
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 500;
            //Mostrar tooltip en elemento activo
            toolTip.ShowAlways = true;

            //Se establece los tooltips a los controles
            toolTip.SetToolTip(ingresoAsociadoAceptar, Constantes.MsjAceptar);
            toolTip.SetToolTip(ingresoAsociadoCancelar, Constantes.MsjCancelar);
            toolTip.SetToolTip(panelIngresoAsociadoRegresar, Constantes.MsjRegresar);
        }

        /// <summary>
        /// Regresar al menú principal
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void RegresarMenuPrincipal(object sender, EventArgs e)
        {
            //Se inicia el formulario de opciones
            FormOpciones formOpciones = new FormOpciones(usuarioSesion);
            Hide();
            formOpciones.ShowDialog();
            Close();
        }

        /// <summary>
        /// Inicializar los valores por defecto de los combobox
        /// Autor: Anderson Benavides
        /// 2019-06-02
        /// </summary>
        private void InicializarCombobox()
        {
            comboBoxDatosPersonaTipoIdentificacion.Text = Constantes.DescripcionSeleccione;
            comboBoxDatosPersonaPais.Text = Constantes.DescripcionSeleccione;
            comboBoxDatosPersonaDepartamento.Text = Constantes.DescripcionSeleccione;
            comboBoxDatosPersonaMunicipio.Text = Constantes.DescripcionSeleccione;
            comboBoxDatosPersonaNivelEstudio.Text = Constantes.DescripcionSeleccione;
            comboBoxDatosPersonaEstadoCivil.Text = Constantes.DescripcionSeleccione;
        }

        /// <summary>
        /// Cargar los valores de los combobox principales
        /// Autor: Anderson Benavides
        /// 2019-06-02
        /// </summary>
        private void CargarCombobox()
        {
            try
            {
                FondoDominiosService fondoDominioService = new FondoDominiosService();

            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "CargarCombobox - IngresoAsociado", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }            
        }

        /// <summary>
        /// Aceptar Ingresar Asociado
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void AceptarIngresarAsociado(object sender, EventArgs e)
        {

        }
    }
}
