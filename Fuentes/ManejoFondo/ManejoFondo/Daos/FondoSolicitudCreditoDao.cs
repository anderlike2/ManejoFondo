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
    /// Clase realizar las consultas a la tabla FondoSolicitudCredito
    /// Autor: Anderson Benavides
    /// 2020-04-22
    /// </summary>
    public class FondoSolicitudCreditoDao
    {
        // <summary>
        /// Metodo para insertar una solicitud de Credito
        /// Autor: Anderson Benavides
        /// 2020-04-23
        /// </summary>
        /// <param name="usuario"></param>
        public bool InsertarSolicitudCredito(FondoSolicitudCreditoEntity solicitudCredito)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                int result = cnn.Execute(
                    @"INSERT INTO FONDOSOLICITUDCREDITO (N_ID_USUARIO, V_TIPO_IDENTIFICACION, D_FECHA_SOLICITUD, V_ESTADO, N_VALOR_SOLICITADO,
                      V_ING_TIPO_ACTIVIDAD, V_ING_CUAL, N_ING_VALOR, N_ING_CADA_CUANTO, V_OT_ING_TIPO_ACTIVIDAD, V_OT_ING_CUAL, N_OT_ING_VALOR, N_OT_ING_CADA_CUANTO,
                      N_EGR_GASTOS_FAM, N_EGR_GASTOS_PROD, N_EGR_CUOTAS_FINANC, N_EGR_CUOTAS_PARTIC, N_TOTAL_DISPONIBLE, N_CAPACIDAD_PAGO, N_TOTAL_INGRESOS, N_TOTAL_EGRESOS, 
                      V_TIPO_PERSONA, V_NOMBRE_COMPLETO)
                      VALUES(@N_ID_USUARIO, @V_TIPO_IDENTIFICACION, @D_FECHA_SOLICITUD, @V_ESTADO, @N_VALOR_SOLICITADO,
                      @V_ING_TIPO_ACTIVIDAD, @V_ING_CUAL, @N_ING_VALOR, @N_ING_CADA_CUANTO, @V_OT_ING_TIPO_ACTIVIDAD, @V_OT_ING_CUAL, @N_OT_ING_VALOR, @N_OT_ING_CADA_CUANTO,
                      @N_EGR_GASTOS_FAM, @N_EGR_GASTOS_PROD, @N_EGR_CUOTAS_FINANC, @N_EGR_CUOTAS_PARTIC, @N_TOTAL_DISPONIBLE, @N_CAPACIDAD_PAGO, @N_TOTAL_INGRESOS, @N_TOTAL_EGRESOS, 
                      @V_TIPO_PERSONA, @V_NOMBRE_COMPLETO)",
                    solicitudCredito);
                return result > 0;
            }
        }

        /// <summary>
        /// Metodo para consultar creditos Activos del Asociado o No Asociado
        /// Autor: Anderson Benavides
        /// 2020-05-09
        /// </summary>
        /// <param name="solicitudCredito"></param>
        public List<FondoSolicitudCreditoEntity> ConsultarCreditosActivos(FondoSolicitudCreditoEntity solicitudCredito)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                List<FondoSolicitudCreditoEntity> result = cnn.Query<FondoSolicitudCreditoEntity>(
                   @"SELECT N_ID_USUARIO, V_TIPO_IDENTIFICACION, D_FECHA_SOLICITUD, V_ESTADO, N_VALOR_SOLICITADO,
                      V_ING_TIPO_ACTIVIDAD, V_ING_CUAL, N_ING_VALOR, N_ING_CADA_CUANTO, V_OT_ING_TIPO_ACTIVIDAD, V_OT_ING_CUAL, N_OT_ING_VALOR, N_OT_ING_CADA_CUANTO,
                      N_EGR_GASTOS_FAM, N_EGR_GASTOS_PROD, N_EGR_CUOTAS_FINANC, N_EGR_CUOTAS_PARTIC, N_TOTAL_DISPONIBLE, N_CAPACIDAD_PAGO, N_TOTAL_INGRESOS, N_TOTAL_EGRESOS, 
                      V_TIPO_PERSONA, V_NOMBRE_COMPLETO
                    FROM FONDOSOLICITUDCREDITO WHERE N_ID_USUARIO = @N_ID_USUARIO AND V_ESTADO = 'A'",
                   new { solicitudCredito.N_Id_Usuario}).ToList();
                return result;
            }
        }
    }
}
