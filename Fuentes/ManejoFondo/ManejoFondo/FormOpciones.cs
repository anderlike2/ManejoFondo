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

namespace ManejoFondo
{
    /// <summary>
    /// Clase para iniciar el formulario de Opciones
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>    
    public partial class FormOpciones : Form
    {
        /// <summary>
        /// Inicializa el componente de Opciones
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public FormOpciones(FondoLoginEntity usuario)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Datos del usuario
            opcionLabelUsername.Text = usuario.V_Username;

            //Tooltips
            InicializarTooltips();
        }

        /// <summary>
        /// Cerrar Sesion del usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CerrarSesion(object sender, EventArgs e)
        {
            //Se inicia el formulario de login
            FormLogin formLogin = new FormLogin();
            Hide();
            formLogin.ShowDialog();
            Close();
        }

        /// <summary>
        /// Inicializar Tooltips
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void InicializarTooltips() {
            //Crear Tooltips
            ToolTip toolTip = new ToolTip();

            //Se agrega atributos del tooltip
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 500;
            //Mostrar tooltip en elemento activo
            toolTip.ShowAlways = true;

            //Se establece los tooltips a los controles
            toolTip.SetToolTip(opcionesPanelConsultarUsuarios, Constantes.MsjTooltipConsultarUsuarios);
            toolTip.SetToolTip(opcionesPanelAsociado, Constantes.MsjTooltipAsociados);
            toolTip.SetToolTip(opcionesPanelAhorro, Constantes.MsjTooltipAhorro);
            toolTip.SetToolTip(opcionesPanelSolicitudCredito, Constantes.MsjTooltipSolicitudCredito);
            toolTip.SetToolTip(opcionesPanelReportes, Constantes.MsjTooltipReportes);
            toolTip.SetToolTip(opcionesPanelIndicadores, Constantes.MsjTooltipIndicadores);
            toolTip.SetToolTip(opcionesPanelCambiarClave, Constantes.MsjTooltipCambiarClave);
            toolTip.SetToolTip(opcionesPanelParametrizacion, Constantes.MsjTooltipParametrizacion);
        }
    }
}
