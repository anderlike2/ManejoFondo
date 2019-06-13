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
    /// Clase realizar la conexion entre la interfaz y los recursos de conexion para FondoFamilia
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoFamiliaUsuarioService
    {
        // <summary>
        /// Metodo para insertar un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="familiaUsuario"></param>
        public bool InsertarFamiliaUsuario(FondoFamiliaEntity familiaUsuario)
        {
            FondoFamiliaUsuarioDao fondoFamiliaUsuarioDao = new FondoFamiliaUsuarioDao();
            return fondoFamiliaUsuarioDao.InsertarFamiliaUsuario(familiaUsuario);
        }
    }
}
