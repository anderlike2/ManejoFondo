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
    /// Clase realizar la conexion entre la interfaz y los recursos de conexion para FondoIngresos
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoIngresosUsuarioService
    {
        // <summary>
        /// Metodo para insertar los ingresos de un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="ingresosUsuario"></param>
        public bool InsertarIngresosUsuario(FondoIngresosEntity ingresosUsuario)
        {
            FondoIngresosUsuarioDao fondoIngresosUsuarioDao = new FondoIngresosUsuarioDao();
            return fondoIngresosUsuarioDao.InsertarIngresosUsuario(ingresosUsuario);
        }
    }
}
