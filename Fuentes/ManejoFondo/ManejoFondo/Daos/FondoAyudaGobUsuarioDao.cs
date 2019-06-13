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
    /// Clase realizar las consultas a la tabla FondoAyudaGob
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoAyudaGobUsuarioDao
    {

        // <summary>
        /// Metodo para insertar la ayuda del gobierno para un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="ayudaGobUsuario"></param>
        public bool InsertarAyudaGobUsuario(FondoAyudaGobEntity ayudaGobUsuario)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                int result = cnn.Execute(
                    @"INSERT INTO FONDOAYUDAGOB (N_ID_USUARIO, V_TIPO_VICTIMA, V_RECIBE_SUBSIDIO, V_TIPO_SUBSIDIO)
                      VALUES(@N_ID_USUARIO, @V_TIPO_VICTIMA, @V_RECIBE_SUBSIDIO, @V_TIPO_SUBSIDIO)",
                    ayudaGobUsuario);
                return result > 0;
            }
        }
    }
}
