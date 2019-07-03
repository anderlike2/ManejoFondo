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
    /// Clase realizar las consultas a la tabla FondoLogin
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoLoginDao
    {
        /// <summary>
        /// Metodo para consultar un usuario mediante usuario y password
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public FondoLoginEntity ConsultarUsuario(FondoLoginEntity usuario)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                FondoLoginEntity result = cnn.Query<FondoLoginEntity>(
                    @"SELECT N_ID, V_USUARIO, V_PASSWORD, F_ULTIMO_INICIO_SESION, V_CORREO, V_NOMBRE_USUARIO
                    FROM FONDOLOGIN WHERE V_USUARIO = @V_USUARIO AND V_PASSWORD = @V_PASSWORD", 
                    new { usuario.V_Usuario, usuario.V_Password}).FirstOrDefault();
                return result;
            }
        }

        /// <summary>
        /// Metodo para consultar un usuario mediante el id usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public FondoLoginEntity ConsultarUsuarioPorId(FondoLoginEntity usuario)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                FondoLoginEntity result = cnn.Query<FondoLoginEntity>(
                    @"SELECT N_ID, V_USUARIO, V_PASSWORD, F_ULTIMO_INICIO_SESION, V_CORREO, V_NOMBRE_USUARIO
                    FROM FONDOLOGIN WHERE N_ID = @N_ID",
                    new { usuario.N_Id}).FirstOrDefault();
                return result;
            }
        }

        /// <summary>
        /// Metodo para actualizar la fecha de inicio de sesion
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public bool ActualizarFechaInicioSesion(FondoLoginEntity usuario)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                int result = cnn.Execute(
                    @"UPDATE FONDOLOGIN SET F_ULTIMO_INICIO_SESION = @F_ULTIMO_INICIO_SESION
                    WHERE N_ID = @N_ID",
                    new { usuario.F_Ultimo_Inicio_Sesion, usuario.N_Id });
                return result > 0;
            }
        }

        /// <summary>
        /// Metodo para actualizar la informacion del usuario de sesion
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public bool ActualizarInformacionUsuario(FondoLoginEntity usuario)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                int result = cnn.Execute(
                    @"UPDATE FONDOLOGIN SET V_USUARIO = @V_USUARIO, V_PASSWORD = @V_PASSWORD
                    WHERE N_ID = @N_ID",
                    new { usuario.V_Usuario, usuario.V_Password, usuario.N_Id });
                return result > 0;
            }
        }

        // <summary>
        /// Metodo para insertar el usuario para el login
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public bool InsertarUsuarioLogin(FondoLoginEntity usuario)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                int result = cnn.Execute(
                    @"INSERT INTO FONDOLOGIN (V_USUARIO, V_PASSWORD, V_CORREO, V_NOMBRE_USUARIO)
                      VALUES(@V_USUARIO, @V_PASSWORD, @V_CORREO, @V_NOMBRE_USUARIO)",
                    new { usuario.V_Usuario, usuario.V_Password, usuario.V_Correo, usuario.V_Nombre_Usuario });
                return result > 0;
            }
        }

        /// <summary>
        /// Metodo para consultar todos los usuarios
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        public List<FondoLoginEntity> ConsultarTodosUsuarios()
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                List<FondoLoginEntity> result = cnn.Query<FondoLoginEntity>(
                    @"SELECT N_ID, V_USUARIO, V_PASSWORD, F_ULTIMO_INICIO_SESION, V_CORREO, V_NOMBRE_USUARIO
                    FROM FONDOLOGIN").ToList();
                return result;
            }
        }
    }
}
