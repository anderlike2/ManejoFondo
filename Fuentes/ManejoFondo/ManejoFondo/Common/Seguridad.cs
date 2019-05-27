using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
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
            String fechaInicialArchivo = (info[0] + info[2] + info[4] + info[6] + info[8] + info[10] + info[11] + info[12]).ToString();
            String fechaFinalArchivo = (info[13] + info[15] + info[17] + info[19] + info[21] + info[23] + info[24] + info[25]).ToString();
            if(fechaInicialArchivo == "00000000" && fechaFinalArchivo == "00000000")
            {
                return true;
            }
            else
            {
                DateTime fechaIni = new DateTime(info[0] + info[2] + info[4] + info[6] + info[8] + info[10] + info[11] + info[12]);
                DateTime fechaFin = new DateTime(info[13] + info[15] + info[17] + info[19] + info[21] + info[23] + info[24] + info[25]);
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
    }
}
