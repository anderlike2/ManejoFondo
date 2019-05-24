using ManejoFondo.Common;
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
    /// Clase para el manejo de las modales (Error, Succes, Warning)
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public partial class FormErrorDialog : Form
    {
        /// <summary>
        /// Metodo para iniciar la modal de (Error, informacion o exito)
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="codigo">1-> Error, 2-> Succes, 3-> Warning</param>
        /// <param name="descripcion"></param>
        public FormErrorDialog(int codigo, String descripcion)
        {           
            InitializeComponent();
            if (codigo == Constantes.CodigoError)
            {
                labelTipoError.Text = Constantes.DescripcionError;
            }
            else if (codigo == Constantes.CodigoExito)
            {
                labelTipoError.Text = Constantes.DescripcionExito;
            }
            else if (codigo == Constantes.CodigoWarning)
            {
                labelTipoError.Text = Constantes.DescripcionWarning;
            }
            else {
                labelTipoError.Text = Constantes.DescripcionError;
            }
            labelDescripcionError.Text = descripcion;
        }

        /// <summary>
        /// Metodo para cerrar la ventana
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CerrarError(object sender, EventArgs e)
        {
            Close();
        }
    }
}
