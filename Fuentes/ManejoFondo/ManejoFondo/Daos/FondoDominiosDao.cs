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
    /// Clase realizar las consultas a la tabla FondoDominios
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoDominiosDao
    {
        /// <summary>
        /// Metodo para consultar todos los dominios
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        public List<FondoDominiosEntity> ConsultarDominios()
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                List<FondoDominiosEntity> result = cnn.Query<FondoDominiosEntity>(
                    @"SELECT N_ID, V_CODIGO, V_VALOR, V_VALOR_AUXILIAR1, V_VALOR_AUXILIAR2, V_PADRE
                    FROM FONDODOMINIOS").ToList();
                return result;
            }
        }

        /// <summary>
        /// Metodo para consultar todos los dominios por Codigo
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="codigoDominio"></param>
        public List<FondoDominiosEntity> ConsultarDominiosPorCodigo(string codigoDominio)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                List<FondoDominiosEntity> result = cnn.Query<FondoDominiosEntity>(
                    @"SELECT N_ID, V_CODIGO, V_VALOR, V_VALOR_AUXILIAR1, V_VALOR_AUXILIAR2, V_PADRE
                    FROM FONDODOMINIOS WHERE V_CODIGO = @V_CODIGO",
                    new { codigoDominio }).ToList();
                return result;
            }
        }

        /// <summary>
        /// Metodo para consultar todos los dominios por Padre
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="codigoPadre"></param>
        public List<FondoDominiosEntity> ConsultarDominiosPorPadre(int codigoPadre)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                List<FondoDominiosEntity> result = cnn.Query<FondoDominiosEntity>(
                    @"SELECT N_ID, V_CODIGO, V_VALOR, V_VALOR_AUXILIAR1, V_VALOR_AUXILIAR2, V_PADRE
                    FROM FONDODOMINIOS WHERE V_PADRE = @V_PADRE",
                    new { codigoPadre }).ToList();
                return result;
            }
        }
    }
}
