using ManejoFondo.Services;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DominioService dominioService = new DominioService();
                label1.Text = dominioService.ConsultarDominios().FirstOrDefault().V_Codigo;
            }
            catch (Exception ex) {
                label1.Text = ex.Message;
            }
            
        }
    }
}
