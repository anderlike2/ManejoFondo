using Dapper;
using ManejoFondo.Common;
using ManejoFondo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Daos
{
    /// <summary>
    /// Clase realizar las consultas a la tabla FondoIngresos
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoIngresosUsuarioDao
    {
        // <summary>
        /// Metodo para insertar los ingresos de un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="ingresosUsuario"></param>
        public bool InsertarIngresosUsuario(FondoIngresosEntity ingresosUsuario)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                int result = cnn.Execute(
                    @"INSERT INTO FONDOINGRESOS (N_ID_USUARIO, N_INGRESOS_MENSUALES, V_TIPO_ACTIVIDAD, V_TIPO_ANIMALES, V_TIPO_CULTIVO)
                      VALUES(@N_ID_USUARIO, @N_INGRESOS_MENSUALES, @V_TIPO_ACTIVIDAD, @V_TIPO_ANIMALES, @V_TIPO_CULTIVO)",
                    ingresosUsuario);
                return result > 0;
            }
        }
    }
}
