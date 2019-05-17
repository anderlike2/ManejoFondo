using ManejoFondo.Entities;
using ManejoFondo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoFondo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DominioService dominioService = new DominioService();
            List<FondoDominios> lstDominios = dominioService.ConsultarDominios();
            label1.Text = lstDominios.FirstOrDefault().V_Codigo;
            //label1.Text = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\BaseDatos\\manejoFondo.sqlite";
        }
    }
}
