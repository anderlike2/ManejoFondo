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
    /// Clase realizar las consultas a la tabla FondoAhorroMensual
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoAhorroMensualDao
    {
        // <summary>
        /// Metodo para insertar un ahorro de un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="ahorroMensual"></param>
        public bool InsertarAhorroUsuario(FondoAhorroMensualEntity ahorroMensual)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                int result = cnn.Execute(
                    @"INSERT INTO FONDOAHORROMENSUAL (N_ID_USUARIO, N_VALOR_CUOTA, F_FECHA_REGISTRO, N_MES_AHORRO, N_ANIO_AHORRO)
                      VALUES(@N_ID_USUARIO, @N_VALOR_CUOTA, @F_FECHA_REGISTRO, @N_MES_AHORRO, @N_ANIO_AHORRO)",
                    ahorroMensual);
                return result > 0;
            }
        }

        /// <summary>
        /// Metodo para consultar un ahorro de un usuario mediante identificacion, mes y año
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="ahorroMensual"></param>
        public FondoLoginEntity ConsultarAhorroMensualUsuario(FondoAhorroMensualEntity ahorroMensual)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                FondoLoginEntity result = cnn.Query<FondoLoginEntity>(
                   @"SELECT N_ID, N_ID_USUARIO, N_VALOR_CUOTA, F_FECHA_REGISTRO, N_MES_AHORRO, N_ANIO_AHORRO
                    FROM FONDOAHORROMENSUAL WHERE N_ID_USUARIO = @N_ID_USUARIO AND N_MES_AHORRO = @N_MES_AHORRO AND N_ANIO_AHORRO = @N_ANIO_AHORRO",
                   new { ahorroMensual.N_Id_Usuario, ahorroMensual.N_Mes_Ahorro, ahorroMensual.N_Anio_Ahorro }).FirstOrDefault();
                return result;
            }
        }

        /// <summary>
        /// Metodo para consultar un ahorro de un usuario mediante identificacion
        /// Autor: Anderson Benavides
        /// 2020-04-19
        /// </summary>
        /// <param name="ahorroMensual"></param>
        public List<FondoAhorroMensualEntity> ConsultarAhorroMensualUsuarioIdentificacion(FondoAhorroMensualEntity ahorroMensual)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                List<FondoAhorroMensualEntity> result = cnn.Query<FondoAhorroMensualEntity>(
                   @"SELECT N_ID, N_ID_USUARIO, N_VALOR_CUOTA, F_FECHA_REGISTRO, N_MES_AHORRO, N_ANIO_AHORRO
                    FROM FONDOAHORROMENSUAL WHERE N_ID_USUARIO = @N_ID_USUARIO",
                   new { ahorroMensual.N_Id_Usuario }).ToList();
                return result;
            }
        }
    }
}
