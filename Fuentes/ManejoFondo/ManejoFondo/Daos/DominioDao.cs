using Dapper;
using ManejoFondo.Common;
using ManejoFondo.Entities;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Daos
{
    public class DominioDao
    {
        public List<FondoDominios> ConsultarDominios() {
            using (var cnn = SqlLiteConexion.SimpleDbConnection())
            {
                List<FondoDominios> result = cnn.Query<FondoDominios>(
                    @"SELECT N_ID, V_CODIGO, V_VALOR, V_VALOR_AUXILIAR1, V_VALOR_AUXILIAR2, V_PADRE
                    FROM FONDODOMINIOS").ToList();
                return result;
            }
        }
    }
}
