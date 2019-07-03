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
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ManejoFondo
{
    /// <summary>
    /// Clase para iniciar el formulario de Creacion de Usuario Administrador
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public partial class FormModalCrearUsuario : MaterialForm
    {
        public String jsonUsuario { get; set; }
        public bool enviarCorreo { get; set; }

        public FormModalCrearUsuario()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Cambiar Tema form
            General.InicializarTema(this);
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
            textBoxCrearUsuarioUsuario.Text = "";
            textBoxCrearUsuarioNombreUsuario.Text = "";
            textBoxCrearUsuarioPassword.Text = "";
            textBoxCrearUsuarioPasswordRepetir.Text = "";
            textBoxCrearUsuarioCorreo.Text = "";
            textBoxCrearUsuarioCorreoRepetir.Text = "";
        }

        /// <summary>
        /// Permite la Creacion del Usuario Administrador
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void CrearUsuario(object sender, EventArgs e)
        {
            try
            {
                if (ValidarInformacionUsuario())
                {
                    //Validar igualdad password
                    if (!textBoxCrearUsuarioPassword.Text.Equals(textBoxCrearUsuarioPasswordRepetir.Text))
                    {
                        throw new BusinessException(Constantes.MsjPasswordCrearUsuarioNoCoincide);
                    }
                    //Validar igualdad correos
                    if (!textBoxCrearUsuarioCorreo.Text.Equals(textBoxCrearUsuarioCorreoRepetir.Text))
                    {
                        throw new BusinessException(Constantes.MsjCorreoCrearUsuarioNoCoincide);
                    }
                    //Validar validez correo
                    if (!esCorreoValido(textBoxCrearUsuarioCorreo.Text))
                    {
                        throw new BusinessException(Constantes.MsjCorreoCrearUsuarioInvalido);
                    }

                    //Se retorna el objeto con el usuario
                    FondoLoginEntity crearUsuario = new FondoLoginEntity();
                    crearUsuario.V_Usuario = textBoxCrearUsuarioUsuario.Text;
                    crearUsuario.V_Nombre_Usuario = textBoxCrearUsuarioNombreUsuario.Text;
                    crearUsuario.V_Password = textBoxCrearUsuarioPassword.Text;
                    crearUsuario.V_Correo = textBoxCrearUsuarioCorreo.Text;
                    jsonUsuario = new JavaScriptSerializer().Serialize(crearUsuario);

                    //Enviar correo
                    enviarCorreo = checkBoxCrearUsuarioEnviarCorreo.Checked;

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
                Log.Registrar_Log(ex.Message, "FormModalCrearUsuario - CrearUsuario", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Valida la obligatoriedad del formulario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private bool ValidarInformacionUsuario()
        {
            if (General.EsVacioNulo(textBoxCrearUsuarioUsuario.Text) || General.EsVacioNulo(textBoxCrearUsuarioNombreUsuario.Text) ||
                General.EsVacioNulo(textBoxCrearUsuarioPassword.Text) || General.EsVacioNulo(textBoxCrearUsuarioPasswordRepetir.Text) ||
                General.EsVacioNulo(textBoxCrearUsuarioCorreo.Text) || General.EsVacioNulo(textBoxCrearUsuarioCorreoRepetir.Text))
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
        private void MascarPassword(object sender, EventArgs e)
        {
            textBoxCrearUsuarioPassword.isPassword = true;
        }

        /// <summary>
        /// Metodo para iniciar la mascara del password repetir
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void MascaraPasswordRepetir(object sender, EventArgs e)
        {
            textBoxCrearUsuarioPasswordRepetir.isPassword = true;
        }

        /// <summary>
        /// Metodo para ver el password
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void VerPassword(object sender, EventArgs e)
        {
            textBoxCrearUsuarioPassword.isPassword = false;
        }

        /// <summary>
        /// Metodo para ocultar el password
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void OcultarPassword(object sender, EventArgs e)
        {
            textBoxCrearUsuarioPassword.isPassword = true;
        }

        /// <summary>
        /// Metodo para ver el password repetir
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void VerPasswordRepetir(object sender, EventArgs e)
        {
            textBoxCrearUsuarioPasswordRepetir.isPassword = false;
        }

        /// <summary>
        /// Metodo para ocultar el password repetir
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void OcultarPasswordRepetir(object sender, EventArgs e)
        {
            textBoxCrearUsuarioPasswordRepetir.isPassword = true;
        }

        /// <summary>
        /// Metodo para validar el correo ingresado
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="correo"></param>
        public bool esCorreoValido(string correo)
        {
            try
            {
                MailAddress m = new MailAddress(correo);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
