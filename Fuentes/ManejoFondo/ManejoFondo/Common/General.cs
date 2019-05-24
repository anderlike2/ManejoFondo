using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Common
{
    /// <summary>
    /// Clase para el manejo de funciones generales
    /// Autor: Anderson Benavides
    /// 2019-05-23
    /// </summary>
    public class General
    {

        private static byte[] Clave = Encoding.ASCII.GetBytes("ManejoFondoLinaresTeam");
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
            FormErrorDialog formError = new FormErrorDialog(codigo, descripcion);
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
    }
}
