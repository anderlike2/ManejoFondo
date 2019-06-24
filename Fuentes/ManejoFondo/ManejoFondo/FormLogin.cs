using ManejoFondo.Common;
using ManejoFondo.Entities;
using ManejoFondo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Management;
using ManejoFondo.Loggers;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace ManejoFondo
{
    /// <summary>
    /// Clase para iniciar el formulario de Login
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public partial class FormLogin : Form
    {

        /// <summary>
        /// Inicializa el componente de Login
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //Quitar
            textBoxUsuario.Text = "Anderson";
            textBoxPassword.Text = "Admin1980";
        }

        /// <summary>
        /// Metodo para iniciar sesion
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void Login(object sender, EventArgs e)
        {
            try
            {
                loginButtonAceptar.Enabled = false;
                //Validar Seguridad
                Seguridad seguridad = new Seguridad();
                seguridad.CrackActivo();

                FondoLoginService fondoLoginServie = new FondoLoginService();
                //Consulta de usuario
                FondoLoginEntity respuesta =
                    fondoLoginServie.ConsultarUsuario(textBoxUsuario.Text, textBoxPassword.Text);
                
                //Actualizacion inicio de sesion
                fondoLoginServie.ActualizarFechaInicioSesion(respuesta.N_Id);

                //Se inicia el formulario de opciones
                FormMenu formOpciones = new FormMenu(respuesta);
                Hide();
                formOpciones.ShowDialog();
                Close();
                
            }
            catch (BusinessException ex)
            {
                textBoxPassword.Text = "";
                textBoxUsuario.Text = "";
                labelVerPassword.Text = "Ver";
                loginButtonAceptar.Enabled = true;
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                textBoxPassword.Text = "";
                textBoxUsuario.Text = "";
                labelVerPassword.Text = "Ver";
                loginButtonAceptar.Enabled = true;
                Log.Registrar_Log(ex.Message, "FormLogin - Login", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Metodo para iniciar la mascara del password
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void MascaraPassword(object sender, EventArgs e)
        {
            textBoxPassword.isPassword = true;

        }

        /// <summary>
        /// Metodo para ver el campo password
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void MostrarPassword(object sender, EventArgs e)
        {
            textBoxPassword.isPassword = false;
        }

        /// <summary>
        /// Metodo para ocultar el campo password
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void OcultarPassword(object sender, EventArgs e)
        {
            textBoxPassword.isPassword = true;
        }
    }
}
