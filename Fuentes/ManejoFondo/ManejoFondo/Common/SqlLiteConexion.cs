using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Common
{
    public class SqlLiteConexion
    {
        public static string DbFile
        {
            get { return ConfigurationManager.AppSettings["filepathBaseDatos"] + "\\manejoFondo.sqlite"; }
        }

        public static SQLiteConnection SimpleDbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }
    }
}
