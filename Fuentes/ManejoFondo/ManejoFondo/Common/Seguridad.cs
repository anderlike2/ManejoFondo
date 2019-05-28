using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Common
{
    /// <summary>
    /// Clase para el manejo de la seguridad de la aplicacion
    /// Autor: Anderson Benavides
    /// 2019-05-27
    /// </summary>
    public class Seguridad
    {
        /// <summary>
        /// Metodo para validar el vencimiento del Crack de la aplicacion
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="descripcion"></param>
        public static bool CrackActivo()
        {
            //Lectura archivo Crack
            String path = ConfigurationManager.AppSettings["filePathCrack"];
            if (!File.Exists(path))
            {
                throw new BusinessException(Constantes.MsjErrorSeguridad);
            }

            //Validacion si el archivo tiene informacion
            String crack = System.IO.File.ReadAllText(@path);
            if (General.EsVacioNulo(crack)) {
                throw new BusinessException(Constantes.MsjErrorSeguridad);
            }

            //Se procede a realizar la consulta del permiso
            String info = General.DesencriptarCadena(crack);

            //Validacion del serial
            String procArchivo = info.Substring(26, info.Length - 26);
            if(procArchivo != ObtenerSerialBios())
            {
                throw new BusinessException(Constantes.MsjErrorSeguridad);
            }

            //Validacion de las fechas
            String diaIni = info[0].ToString() + info[2].ToString();
            String mesIni = info[4].ToString() + info[6].ToString();
            String anioIni = info[8].ToString() + info[10].ToString() + info[11].ToString() + info[12].ToString();
            String fechaInicialArchivo = diaIni + mesIni + anioIni;

            String diaFin = info[13].ToString() + info[15].ToString();
            String mesFin = info[17].ToString() + info[19].ToString();
            String anioFin = info[21].ToString() + info[23].ToString() + info[24].ToString() + info[25].ToString();
            String fechaFinalArchivo = diaFin + mesFin + anioFin;
            if(fechaInicialArchivo == "00000000" && fechaFinalArchivo == "00000000")
            {
                return true;
            }
            else
            {
                DateTime fechaIni = new DateTime(Convert.ToInt32(anioIni), Convert.ToInt32(mesIni), Convert.ToInt32(diaIni));
                DateTime fechaFin = new DateTime(Convert.ToInt32(anioFin), Convert.ToInt32(mesFin), Convert.ToInt32(diaFin));
                DateTime fechaSistema = DateTime.Now;
                int fechaInicioCompare = DateTime.Compare(fechaSistema, fechaIni);
                int fechaFinCompare = DateTime.Compare(fechaSistema, fechaFin);

                if (fechaInicioCompare < 0)
                {
                    throw new BusinessException(Constantes.MsjErrorSeguridad);
                }
                if (fechaFinCompare > 0)
                {
                    throw new BusinessException(Constantes.MsjErrorSeguridad);
                }
            }

            return true;
        }

        /// <summary> 
        /// Returns el serial de la Bios 
        /// CPU found on the machine 
        /// </summary> 
        public static string ObtenerSerialBios()
        {
            string serialNumber = string.Empty;
              
            ManagementObjectSearcher MOS = new ManagementObjectSearcher(" Select * From Win32_BIOS ");
            foreach (ManagementObject getserial in MOS.Get())
            {
                serialNumber = getserial["SerialNumber"].ToString();
            }
            return serialNumber;
        }
    }
}
