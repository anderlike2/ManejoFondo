using ManejoFondo.Common;
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
using System.Windows.Forms;

namespace ManejoFondo
{
    /// <summary>
    /// Clase para iniciar el formulario de Recuperar Contraseña
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public partial class FormModalRecuperarPassword : MaterialForm
    {
        public bool enviarCorreo { get; set; }

        public FormModalRecuperarPassword()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Cambiar Tema form
            General.InicializarTema(this);
        }

        /// <summary>
        /// Ejecuta la opcion de Recuperacion de Password
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void RecuperarPassword(object sender, EventArgs e)
        {
            try
            {
                enviarCorreo = true;
                Close();
            }
            catch (BusinessException ex)
            {
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "FormModalRecuperarPassword - RecuperarPassword", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }
    }
}
