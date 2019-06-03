using ManejoFondo.Common;
using ManejoFondo.Loggers;
using ManejoFondo.Services;
using MaterialSkin.Controls;
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
    /// Clase para iniciar el formulario de Agregar persona nucleo familiar
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>  
    public partial class FormAgregarNucleoFamiliar : MaterialForm
    {
        public FormAgregarNucleoFamiliar()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Cambiar Tema form
            General.InicializarTema(this);

            //Valores por defecto
            CargarCombobox();
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

                //Agregar persona
                comboBoxAgregarPersonaTipoIdentificacion.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTiposIdentificacion, false); ;
                comboBoxAgregarPersonaTipoIdentificacion.DisplayMember = "V_VALOR";
                comboBoxAgregarPersonaTipoIdentificacion.ValueMember = "V_CODIGO";
                comboBoxAgregarPersonaTipoActividad.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTipoActividad, false); ;
                comboBoxAgregarPersonaTipoActividad.DisplayMember = "V_VALOR";
                comboBoxAgregarPersonaTipoActividad.ValueMember = "V_CODIGO";
                comboBoxAgregarPersonaParentesco.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioParentesco, false); ;
                comboBoxAgregarPersonaParentesco.DisplayMember = "V_VALOR";
                comboBoxAgregarPersonaParentesco.ValueMember = "V_CODIGO";

            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "CargarCombobox - IngresoAsociado", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Cierra la modal de Agregar Personas
        /// Autor: Anderson Benavides
        /// 2019-06-02
        /// </summary>
        private void CerrarAgregarPersona(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Funcion que permite solo el ingreso de numeros
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
