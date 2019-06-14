using ManejoFondo.Daos;
using ManejoFondo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Services
{
    /// <summary>
    /// Clase realizar la conexion entre la interfaz y los recursos de conexion para FondoParametros
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoParametrosService
    {
        /// <summary>
        /// Metodo para consultar todos los parametros por nombre
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="nombreParametro"></param>
        public FondoParametrosEntity ConsultarParametroPorNombre(String nombreParametro)
        {
            FondoParametrosDao fondoParametrosDao = new FondoParametrosDao();
            return fondoParametrosDao.ConsultarParametroPorNombre(nombreParametro);
        }
    }
}
