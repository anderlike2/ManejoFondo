﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneracionArchivoClave
{
    public partial class GeneracionCrack : Form
    {
        public GeneracionCrack()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void GenerarCrack(object sender, EventArgs e)
        {
            String message = "";
            String caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            if (textBoxPalabraClave.Text.Length != 10) {
                message = "La palabra clave NO contiene 10 caracteres";
                caption = "Validar!";
                MessageBox.Show(message, caption, buttons);
                return;
            }

            if (textBoxPalabraClave.Text != "Admin1980.")
            {
                message = "La palabra clave es incorrecta";
                caption = "Validar!";
                MessageBox.Show(message, caption, buttons);
                return;
            }

            bool activadoSiempre = chkTiempo.Checked;
            if (activadoSiempre)
            {
                GenerarArchivo();
            }
            else {
                if (timeDesde.Value >= timeHasta.Value) {
                    message = "La fecha Desde debe ser menor a la fecha Hasta";
                    caption = "Validar!";
                    MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    GenerarArchivo();
                }
            }

           
        }

        private void GenerarArchivo()
        {
            String message = "";
            String caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            try
            {
                String resultado = "";

                //Se obtiene la fecha de inicio
                String fechaInicioArchivo = "";
                if (chkTiempo.Checked)
                {
                    fechaInicioArchivo = "00000000";
                }
                else
                {
                    fechaInicioArchivo = timeDesde.Value.ToString("ddMMyyyy");
                }

                //Se obtiene la palabra clave
                String palabraClaveArchivo = textBoxPalabraClave.Text;

                //Se obtiene la fecha de fin
                String fechaFinArchivo = "";
                if (chkTiempo.Checked)
                {
                    fechaFinArchivo = "00000000";
                }
                else
                {
                    fechaFinArchivo = timeHasta.Value.ToString("ddMMyyyy");
                }

                //Se obtiene el serial
                String serialProcesadorArchivo = ObtenerSerialProcesador();

                resultado = fechaInicioArchivo + palabraClaveArchivo + fechaFinArchivo + serialProcesadorArchivo;

                //Ruta del archivo
                String pathFile = ConfigurationManager.AppSettings["filePathCrack"];
                // This text is added only once to the file.
                if (!File.Exists(pathFile))
                {
                    message = "No se encuentra la ruta del archivo.";
                    caption = "Error!";
                    MessageBox.Show(message, caption, buttons);
                    return;
                }

                File.AppendAllText(pathFile, General.EncriptarCadena(resultado));

                message = "El archivo de configuración se ha generado con exito";
                caption = "Exito!";
                MessageBox.Show(message, caption, buttons);
            }
            catch(Exception e)
            {
                message = "El archivo de configuración NO se ha generado, por favor contactar al Administrador del sistema -> " + e.Message;
                caption = "Error!";
                MessageBox.Show(message, caption, buttons);
            }
           
        }

        private void validarFechas(object sender, EventArgs e)
        {
            if (chkTiempo.Checked)
            {
                timeDesde.Enabled = false;
                timeHasta.Enabled = false;
            }
            else
            {
                timeDesde.Enabled = true;
                timeHasta.Enabled = true;
            }
        }

        /// <summary> 
        /// Returns the processor ID of the first 
        /// CPU found on the machine 
        /// </summary> 
        public static string ObtenerSerialProcesador()
        {
            string cpuInfo = String.Empty;
            ManagementClass managementClass =
                 new ManagementClass("Win32_Processor");
            ManagementObjectCollection managementObjCol =
                 managementClass.GetInstances();

            foreach (ManagementObject managementObj in managementObjCol)
            {
                if (cpuInfo == String.Empty)
                {
                    cpuInfo =
                    managementObj.Properties["ProcessorId"].Value.ToString();
                }
            }
            return cpuInfo;
        }
    }
}
