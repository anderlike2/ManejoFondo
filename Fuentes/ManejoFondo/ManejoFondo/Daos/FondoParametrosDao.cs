﻿using Dapper;
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
    /// Clase realizar las consultas a la tabla FondoParametros
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoParametrosDao
    {
        /// <summary>
        /// Metodo para consultar todos los parametros del sistema
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        public List<FondoParametrosEntity> ConsultarParametrosSistema()
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                List<FondoParametrosEntity> result = cnn.Query<FondoParametrosEntity>(
                    @"SELECT N_ID, V_NOMBRE, V_VALOR, V_DESCRIPCION
                    FROM FONDOPARAMETROS").ToList();
                return result;
            }
        }

        /// <summary>
        /// Metodo para consultar todos los parametros por nombre
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="nombreParametro"></param>
        public FondoParametrosEntity ConsultarParametroPorNombre(String nombreParametro)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                FondoParametrosEntity result = cnn.Query<FondoParametrosEntity>(
                    @"SELECT N_ID, V_NOMBRE, V_VALOR, V_DESCRIPCION
                    FROM FONDOPARAMETROS WHERE V_NOMBRE = @V_NOMBRE", new { v_nombre = nombreParametro }).FirstOrDefault();
                return result;
            }
        }

        /// <summary>
        /// Metodo para actualizar la informacion de un parametro
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="parametro"></param>
        public bool ActualizarInformacionParametro(FondoParametrosEntity parametro)
        {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                int result = cnn.Execute(
                    @"UPDATE FONDOPARAMETROS SET V_VALOR = @V_VALOR, V_DESCRIPCION = @V_DESCRIPCION
                    WHERE N_ID = @N_ID",
                    new { parametro.V_Valor, parametro.V_Descripcion, parametro.N_Id });
                return result > 0;
            }
        }
    }
}
