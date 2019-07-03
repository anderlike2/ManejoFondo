using ManejoFondo.Modelos;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoFondo.Common
{
    /// <summary>
    /// Clase para el manejo de funciones generales
    /// Autor: Anderson Benavides
    /// 2019-05-23
    /// </summary>
    public class General
    {

        private static byte[] Clave = Encoding.ASCII.GetBytes("4FC76A4EB7BBA");
        private static byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

        /// <summary>
        /// Metodo para Encriptar una cadena de Texto
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        public static string EncriptarCadena(string Cadena)
        {

            byte[] inputBytes = Encoding.ASCII.GetBytes(Cadena);
            byte[] encripted;
            RijndaelManaged cripto = new RijndaelManaged();
            using (MemoryStream ms = new MemoryStream(inputBytes.Length))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateEncryptor(Clave, IV), CryptoStreamMode.Write))
                {
                    objCryptoStream.Write(inputBytes, 0, inputBytes.Length);
                    objCryptoStream.FlushFinalBlock();
                    objCryptoStream.Close();
                }
                encripted = ms.ToArray();
            }
            return Convert.ToBase64String(encripted);
        }

        /// <summary>
        /// Metodo para DesEncriptar una cadena de Texto
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        public static string DesencriptarCadena(string Cadena)
        {
            byte[] inputBytes = Convert.FromBase64String(Cadena);
            string textoLimpio = String.Empty;
            RijndaelManaged cripto = new RijndaelManaged();
            using (MemoryStream ms = new MemoryStream(inputBytes))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(Clave, IV), CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(objCryptoStream, true))
                    {
                        textoLimpio = sr.ReadToEnd();
                    }
                }
            }
            return textoLimpio;
        }

        /// <summary>
        /// Metodo para mostrar el panel de error, succes o warning
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="descripcion"></param>
        public static void MostrarPanelError(int codigo, String descripcion)
        {
            FormModalError formError = new FormModalError(codigo, descripcion);
            formError.ShowDialog();
        }

        /// <summary>
        /// Metodo para validar un string vacio o null
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="descripcion"></param>
        public static bool EsVacioNulo(String texto)
        {
            if (texto != null && texto != "") {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Metodo para inicializar temas del formulario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        public static void InicializarTema(MaterialForm formulario)
        {
            var skinManejador = MaterialSkinManager.Instance;
            skinManejador.AddFormToManage(formulario);
            skinManejador.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManejador.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue600, Accent.Amber700, TextShade.WHITE);
        }

        /// <summary>
        /// Metodo para obtener los meses del año
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        public static List<ValoresModel> ObtenerMeses()
        {
            List<ValoresModel> listaMeses = new List<ValoresModel>();
            ValoresModel enero = new ValoresModel();
            enero.Codigo = "01";
            enero.Valor = "Enero";
            ValoresModel febrero = new ValoresModel();
            febrero.Codigo = "02";
            febrero.Valor = "Febrero";
            ValoresModel marzo = new ValoresModel();
            marzo.Codigo = "03";
            marzo.Valor = "Marzo";
            ValoresModel abril = new ValoresModel();
            abril.Codigo = "04";
            abril.Valor = "Abril";
            ValoresModel mayo = new ValoresModel();
            mayo.Codigo = "05";
            mayo.Valor = "Mayo";
            ValoresModel junio = new ValoresModel();
            junio.Codigo = "06";
            junio.Valor = "Junio";
            ValoresModel julio = new ValoresModel();
            julio.Codigo = "07";
            julio.Valor = "Julio";
            ValoresModel agosto = new ValoresModel();
            agosto.Codigo = "08";
            agosto.Valor = "Agosto";
            ValoresModel septiembre = new ValoresModel();
            septiembre.Codigo = "09";
            septiembre.Valor = "Septiembre";
            ValoresModel octubre = new ValoresModel();
            octubre.Codigo = "10";
            octubre.Valor = "Octubre";
            ValoresModel noviembre = new ValoresModel();
            noviembre.Codigo = "11";
            noviembre.Valor = "Noviembre";
            ValoresModel diciembre = new ValoresModel();
            diciembre.Codigo = "12";
            diciembre.Valor = "Diciembre";

            listaMeses.Add(enero);
            listaMeses.Add(febrero);
            listaMeses.Add(marzo);
            listaMeses.Add(abril);
            listaMeses.Add(mayo);
            listaMeses.Add(junio);
            listaMeses.Add(julio);
            listaMeses.Add(agosto);
            listaMeses.Add(septiembre);
            listaMeses.Add(octubre);
            listaMeses.Add(noviembre);
            listaMeses.Add(diciembre);
            return listaMeses;
        }

        /// <summary>
        /// Metodo para verificar si tiene conexion a internet
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        public static bool TestConexionInternet()
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
