using ManejoFondo.Common;
using ManejoFondo.Entities;
using ManejoFondo.Loggers;
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
    /// Clase para iniciar el formulario de Eliminar Usuario
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public partial class FormModalEliminarUsuario : MaterialForm
    {
        public String jsonUsuario { get; set; }

        public FormModalEliminarUsuario()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Cambiar Tema form
            General.InicializarTema(this);
        }

        /// <summary>
        /// Ejecuta la opcion de Eliminar usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void EliminarUsuario(object sender, EventArgs e)
        {
            try
            {
                if (ValidarInformacionUsuario())
                {
                    //Se retorna el objeto con el usuario
                    FondoLoginEntity crearUsuario = new FondoLoginEntity();
                    crearUsuario.V_Usuario = textBoxEliminarUsuarioUsuario.Text;
                    crearUsuario.V_Password = textBoxEliminarUsuarioPassword.Text;
                    jsonUsuario = new JavaScriptSerializer().Serialize(crearUsuario);

                    Close();
                }
                else
                {
                    General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjCamposObligatorios);
                }
            }
            catch (BusinessException ex)
            {
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                LimpiarDatosFormulario();
                Log.Registrar_Log(ex.Message, "FormModalEliminarUsuario - EliminarUsuario", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Limpiar los campos del formulario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void LimpiarFormulario(object sender, EventArgs e)
        {
            LimpiarDatosFormulario();
        }

        /// <summary>
        /// Resetear campos del formulario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void LimpiarDatosFormulario()
        {
            textBoxEliminarUsuarioUsuario.Text = "";
            textBoxEliminarUsuarioPassword.Text = "";
        }

        /// <summary>
        /// Valida la obligatoriedad del formulario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private bool ValidarInformacionUsuario()
        {
            if (General.EsVacioNulo(textBoxEliminarUsuarioUsuario.Text) || General.EsVacioNulo(textBoxEliminarUsuarioPassword.Text))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Metodo para iniciar la mascara del password
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void MascaraPassword(object sender, EventArgs e)
        {
            textBoxEliminarUsuarioPassword.isPassword = true;
        }

        /// <summary>
        /// Metodo para ver el password
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void VerPassword(object sender, EventArgs e)
        {
            textBoxEliminarUsuarioPassword.isPassword = false;
        }

        /// <summary>
        /// Metodo para ocultar el password
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void OcultarPassword(object sender, EventArgs e)
        {
            textBoxEliminarUsuarioPassword.isPassword = true;
        }
    }
}
