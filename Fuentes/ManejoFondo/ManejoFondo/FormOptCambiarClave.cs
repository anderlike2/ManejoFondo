using ManejoFondo.Common;
using ManejoFondo.Entities;
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
    /// Clase para iniciar el formulario de Cambiar Contraseña
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary> 
    public partial class FormOptCambiarClave : MaterialForm
    {
        //Variable para guardar el usuario que inicio sesion
        FondoLoginEntity usuarioSesion;
        FondoLoginService fondoLoginService = new FondoLoginService();

        public FormOptCambiarClave(FondoLoginEntity usuario)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Centrar panel
            panelCambiarContrasenia.Location = new Point(
            this.ClientSize.Width / 2 - panelCambiarContrasenia.Size.Width / 2,
            this.ClientSize.Height / 2 - panelCambiarContrasenia.Size.Height / 3);
            panelCambiarContrasenia.Anchor = AnchorStyles.None;

            //Cambiar Tema form
            General.InicializarTema(this);

            //Valores por defecto
            usuarioSesion = usuario;
            textBoxCambiarClaveUsuario.Text = usuarioSesion.V_Usuario;
            buttonCambiarClaveLimpiar.Focus();
        }

        /// <summary>
        /// Regresar al menú principal
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void RegresarMenuPrincipal(object sender, EventArgs e)
        {
            //Se inicia el formulario de opciones
            FormMenu formOpciones = new FormMenu(usuarioSesion);
            Hide();
            formOpciones.ShowDialog();
            Close();
        }

        /// <summary>
        /// Limpiar los campos del formulario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void LimpiarInformacionCambiarClave(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        /// <summary>
        /// Resetear campos del formulario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void LimpiarFormulario()
        {
            textBoxCambiarClavePassword.Text = "";
            textBoxCambiarClavePasswordNuevo.Text = "";
            textBoxCambiarClavePasswordNuevoRepite.Text = "";
            labelVerPassword.Text = "Ver";
            labelVerPasswordNuevo.Text = "Ver";
            labelVerPasswordNuevoRepite.Text = "Ver";
        }

        /// <summary>
        /// Cambiar Clave del usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void CambiarClave(object sender, EventArgs e)
        {
            try
            {
                if (ValidarInformacionUsuario())
                {
                    fondoLoginService.ActualizarInformacionUsuario(usuarioSesion.N_Id, textBoxCambiarClaveUsuario.Text, textBoxCambiarClavePassword.Text,
                        textBoxCambiarClavePasswordNuevo.Text, textBoxCambiarClavePasswordNuevoRepite.Text);
                    LimpiarFormulario();
                    General.MostrarPanelError(Constantes.CodigoExito, Constantes.MsjExitoActualizarClave);
                }
                else
                {
                    General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjCamposObligatorios);
                }
            }
            catch (BusinessException ex)
            {
                LimpiarFormulario();
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                LimpiarFormulario();
                Log.Registrar_Log(ex.Message, "FormOptCambiarClave - CambiarClave", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Valida la obligatoriedad del usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private bool ValidarInformacionUsuario()
        {
            if(General.EsVacioNulo(textBoxCambiarClaveUsuario.Text) || General.EsVacioNulo(textBoxCambiarClavePassword.Text) 
              || General.EsVacioNulo(textBoxCambiarClavePasswordNuevo.Text) || General.EsVacioNulo(textBoxCambiarClavePasswordNuevoRepite.Text))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Metodo para iniciar la mascara del password nuevo
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void MascaraPasswordActual(object sender, EventArgs e)
        {
            textBoxCambiarClavePassword.isPassword = true;
        }

        /// <summary>
        /// Metodo para iniciar la mascara del password
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void MascaraPasswordNuevo(object sender, EventArgs e)
        {
            textBoxCambiarClavePasswordNuevo.isPassword = true;
        }        

        /// <summary>
        /// Metodo para iniciar la mascara del password nuevo repite
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void MascaraPasswordNuevoRepite(object sender, EventArgs e)
        {
            textBoxCambiarClavePasswordNuevoRepite.isPassword = true;
        }

        /// <summary>
        /// Metodo para ver el password actual
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void VerPasswordActual(object sender, EventArgs e)
        {
            textBoxCambiarClavePassword.isPassword = false;
        }

        /// <summary>
        /// Metodo para ocultar el password actual
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void OcultarPasswordActual(object sender, EventArgs e)
        {
            textBoxCambiarClavePassword.isPassword = true;
        }

        /// <summary>
        /// Metodo para ver el password actual
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void VerPasswordNuevo(object sender, EventArgs e)
        {
            textBoxCambiarClavePasswordNuevo.isPassword = false;
        }

        /// <summary>
        /// Metodo para ocultar el password actual
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void OcultarPasswordNuevo(object sender, EventArgs e)
        {
            textBoxCambiarClavePasswordNuevo.isPassword = true;
        }

        /// <summary>
        /// Metodo para ver el password nuevo repite
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void VerPasswordNuevoRepite(object sender, EventArgs e)
        {
            textBoxCambiarClavePasswordNuevoRepite.isPassword = false;
        }

        /// <summary>
        /// Metodo para ocultar el password nuevo repite
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        private void OcultarPasswordNuevoRepite(object sender, EventArgs e)
        {
            textBoxCambiarClavePasswordNuevoRepite.isPassword = true;
        }
    }
}
