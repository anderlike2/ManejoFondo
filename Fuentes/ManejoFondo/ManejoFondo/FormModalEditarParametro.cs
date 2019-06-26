using ManejoFondo.Common;
using ManejoFondo.Entities;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ManejoFondo
{
    /// <summary>
    /// Clase para iniciar el formulario de Editar un parámetro
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>  
    public partial class FormModalEditarParametro : MaterialForm
    {
        public String jsonParametro { get; set; }

        public FormModalEditarParametro(FondoParametrosEntity parametro)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Cambiar Tema form
            General.InicializarTema(this);

            //Precargar informacion
            PrecargarInformacionParametro(parametro);
        }

        /// <summary>
        /// Funcion para precargar la informacion del parametro en la modal
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="parametro"></param>
        public void PrecargarInformacionParametro(FondoParametrosEntity parametro)
        {
            textBoxEditarParametroId.Text = parametro.N_Id.ToString();
            textBoxEditarParametroNombre.Text = parametro.V_Nombre;
            textBoxEditarParametroValor.Text = parametro.V_Valor;
            textBoxEditarParametroDescripcion.Text = parametro.V_Descripcion;
        }

        /// <summary>
        /// Funcion para cerrar la modal de edicion de parametros
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void CerrarEditarParametro(object sender, EventArgs e)
        {
            LimpiarInformacionModal();
            jsonParametro = "";
            Close();
        }

        /// <summary>
        /// Funcion que permite limpiar la informacion de la modal
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void LimpiarInformacionModal()
        {
            textBoxEditarParametroId.Text = "";
            textBoxEditarParametroNombre.Text = "";
            textBoxEditarParametroValor.Text = "";
            textBoxEditarParametroDescripcion.Text = "";
        }

        /// <summary>
        /// Funcion para validar los campos del parametro a actualizar
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private bool ValidarInformacionEditarParametro()
        {
            if (General.EsVacioNulo(textBoxEditarParametroId.Text) || General.EsVacioNulo(textBoxEditarParametroNombre.Text) ||
                General.EsVacioNulo(textBoxEditarParametroValor.Text) || General.EsVacioNulo(textBoxEditarParametroDescripcion.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Funcion para validar la informacion a almacenar
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void ValidarInformacionGuardar(object sender, EventArgs e)
        {
            if (!ValidarInformacionEditarParametro())
            {
                General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjCamposObligatorios);
            }
            else
            {
                FondoParametrosEntity parametroEditado = new FondoParametrosEntity();
                parametroEditado.N_Id = Convert.ToInt32(textBoxEditarParametroId.Text);
                parametroEditado.V_Nombre = textBoxEditarParametroNombre.Text;
                parametroEditado.V_Valor = textBoxEditarParametroValor.Text;
                parametroEditado.V_Descripcion = textBoxEditarParametroDescripcion.Text;
                jsonParametro = new JavaScriptSerializer().Serialize(parametroEditado);
                Close();
            }
        }
    }
}
