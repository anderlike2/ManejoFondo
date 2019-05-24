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
    }
}
