using System;
using System.Collections.Generic;
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
            get {return "D:\\Anderson\\Proyecto ManejoFondo\\ManejoFondo\\Fuentes\\ManejoFondo\\ManejoFondo\\BaseDatos\\manejoFondo.sqlite"; }
        }

        public static SQLiteConnection SimpleDbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }
    }
}
