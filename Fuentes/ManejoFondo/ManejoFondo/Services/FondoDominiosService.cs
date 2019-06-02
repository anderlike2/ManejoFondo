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
    /// Clase realizar la conexion entre la interfaz y los recursos de conexion para FondoDominios
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoDominiosService
    {
        /// <summary>
        /// Metodo para consultar todos los dominios
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param></param>
        public List<FondoDominiosEntity> ConsultarDominios()
        {
            FondoDominiosDao dominioDao = new FondoDominiosDao();
            return dominioDao.ConsultarDominios();
        }

        /// <summary>
        /// Metodo para consultar todos los dominios por Codigo
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="codigoDominio"></param>
        public List<FondoDominiosEntity> ConsultarDominiosPorCodigo(string codigoDominio)
        {
            FondoDominiosDao dominioDao = new FondoDominiosDao();
            return dominioDao.ConsultarDominiosPorCodigo(codigoDominio);
        }

        /// <summary>
        /// Metodo para consultar todos los dominios por Padre
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="codigoPadre"></param>
        public List<FondoDominiosEntity> ConsultarDominiosPorPadre(int codigoPadre)
        {
            FondoDominiosDao dominioDao = new FondoDominiosDao();
            return dominioDao.ConsultarDominiosPorPadre(codigoPadre);
        }
    }
}
