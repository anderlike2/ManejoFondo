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
    /// Clase realizar las consultas a la tabla FondoUsuario
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoUsuarioDao
    {
        // <summary>
        /// Metodo para insertar un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public bool InsertarUsuario(FondoUsuarioEntity usuario)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                int result = cnn.Execute(
                    @"INSERT INTO FONDOUSUARIO (V_TIPO_IDENTIFICACION, V_NUMERO_IDENTIFICACION, V_NOMBRES, V_APELLIDOS, N_TELEFONO,
                      V_NIVEL_ESTUDIO, V_PUNTAJE_SISBEN, V_ESTADO_CIVIL, V_NOMBRE_INSTITUCION, F_FECHA_NACIMIENTO, F_FECHA_REGISTRO, N_ANTIGUEDAD_ASOCIACION)
                      VALUES(@V_TIPO_IDENTIFICACION, @V_NUMERO_IDENTIFICACION, @V_NOMBRES, @V_APELLIDOS, @N_TELEFONO,
                      @V_NIVEL_ESTUDIO, @V_PUNTAJE_SISBEN, @V_ESTADO_CIVIL, @V_NOMBRE_INSTITUCION, @F_FECHA_NACIMIENTO, @F_FECHA_REGISTRO, @N_ANTIGUEDAD_ASOCIACION)",
                    usuario);
                return result > 0;
            }
        }

        // <summary>
        /// Metodo para validar la existencia de un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public FondoUsuarioEntity ConsultarUsuarioPorIdentificacion(FondoUsuarioEntity usuario)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                FondoUsuarioEntity result = cnn.Query<FondoUsuarioEntity>(
                    @"SELECT N_ID, V_TIPO_IDENTIFICACION, V_NUMERO_IDENTIFICACION, V_NOMBRES, V_APELLIDOS, N_TELEFONO,
                      V_NIVEL_ESTUDIO, V_PUNTAJE_SISBEN, V_ESTADO_CIVIL, V_NOMBRE_INSTITUCION, F_FECHA_NACIMIENTO, F_FECHA_REGISTRO, N_ANTIGUEDAD_ASOCIACION
                    FROM FONDOUSUARIO WHERE V_TIPO_IDENTIFICACION = @V_TIPO_IDENTIFICACION AND V_NUMERO_IDENTIFICACION = @V_NUMERO_IDENTIFICACION",
                    new { usuario.V_Tipo_Identificacion, usuario.V_Numero_Identificacion }).FirstOrDefault();
                return result;
            }
        }
    }
}
