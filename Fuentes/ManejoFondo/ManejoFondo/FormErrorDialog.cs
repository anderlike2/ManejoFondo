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
                panelDifuminadoError.ColorArriba = ColorTranslator.FromHtml("#D4453F");
                panelDifuminadoError.ColorAbajo = ColorTranslator.FromHtml("#FF604B");
            }
            else if (codigo == Constantes.CodigoExito)
            {
                labelTipoError.Text = Constantes.DescripcionExito;
                panelDifuminadoError.ColorArriba = ColorTranslator.FromHtml("#679E00");
                panelDifuminadoError.ColorAbajo = ColorTranslator.FromHtml("#A0D801");
            }
            else if (codigo == Constantes.CodigoWarning)
            {
                labelTipoError.Text = Constantes.DescripcionWarning;
                panelDifuminadoError.ColorArriba = ColorTranslator.FromHtml("#DC661B");
                panelDifuminadoError.ColorAbajo = ColorTranslator.FromHtml("#FFC571");
            }
            else {
                labelTipoError.Text = Constantes.DescripcionError;
                panelDifuminadoError.ColorArriba = ColorTranslator.FromHtml("#D4453F");
                panelDifuminadoError.ColorAbajo = ColorTranslator.FromHtml("#FF604B");
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
