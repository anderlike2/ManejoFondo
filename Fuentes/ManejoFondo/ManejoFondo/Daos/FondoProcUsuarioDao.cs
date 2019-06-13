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
    /// Clase realizar las consultas a la tabla FondoProcUsuario
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoProcUsuarioDao
    {
        // <summary>
        /// Metodo para insertar la procedencia de un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="procUsuario"></param>
        public bool InsertarProcedenciaUsuario(FondoProcUsuarioEntity procUsuario)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                int result = cnn.Execute(
                    @"INSERT INTO FONDOPROCUSUARIO (N_ID_USUARIO, V_PAIS, V_DEPARTAMENTO, V_MUNICIPIO, V_VEREDA)
                      VALUES(@N_ID_USUARIO, @V_PAIS, @V_DEPARTAMENTO, @V_MUNICIPIO, @V_VEREDA)",
                    procUsuario);
                return result > 0;
            }
        }
    }
}
