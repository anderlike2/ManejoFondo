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
    /// Clase realizar las consultas a la tabla FondoFamilia
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoFamiliaUsuarioDao
    {
        // <summary>
        /// Metodo para insertar un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="familiaUsuario"></param>
        public bool InsertarFamiliaUsuario(FondoFamiliaEntity familiaUsuario)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                int result = cnn.Execute(
                    @"INSERT INTO FONDOFAMILIA (N_ID_USUARIO, V_NOMBRES, V_APELLIDOS, V_TIPO_IDENTIFICACION, V_NUMERO_IDENTIFICACION, F_FECHA_NACIMIENTO, V_TIPO_PARENTESCO, 
                      N_TELEFONO, V_TIPO_ACTIVIDAD, V_CUAL_OTRA)
                      VALUES(@N_ID_USUARIO, @V_NOMBRES, @V_APELLIDOS, @V_TIPO_IDENTIFICACION, @V_NUMERO_IDENTIFICACION, @F_FECHA_NACIMIENTO, @V_TIPO_PARENTESCO, 
                      @N_TELEFONO, @V_TIPO_ACTIVIDAD, @V_CUAL_OTRA)",
                    familiaUsuario);
                return result > 0;
            }
        }
    }
}
