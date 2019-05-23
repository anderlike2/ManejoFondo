using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Common
{
    /// <summary>
    /// Clase para el manejo de la conexion a Base de datos mediante SQlite
    /// Autor: Anderson Benavides
    /// 2019-05-23
    /// </summary>
    public class SqlLiteConexion
    {
        /// <summary>
        /// Obtiene el archivo de la ruta de la base de datos
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        public static string DbFile
        {
            get { return ConfigurationManager.AppSettings["filepathBaseDatos"] + "\\manejoFondo.sqlite"; }
        }

        /// <summary>
        /// Realiza una conexion a la base de datos SQlite
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        public static SQLiteConnection SimpleDbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }
    }
}
