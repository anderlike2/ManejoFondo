using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoFondo
{
    /// <summary>
    /// Clase para el manejo del color de la modal
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    class PanelDifuminado : Panel
    {
        public Color ColorArriba { get; set; }
        public Color ColorAbajo{ get; set; }

        /// <summary>
        /// Metodo para pintar el cuadro de dialogo
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linea = new LinearGradientBrush(this.ClientRectangle, this.ColorArriba, this.ColorAbajo, 90F);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(linea, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
