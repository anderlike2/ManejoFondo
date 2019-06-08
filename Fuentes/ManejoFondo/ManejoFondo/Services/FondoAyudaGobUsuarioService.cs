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
    /// Clase realizar la conexion entre la interfaz y los recursos de conexion para FondoAyudaGob
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoAyudaGobUsuarioService
    {
        // <summary>
        /// Metodo para insertar la ayuda del gobierno para un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="ayudaGobUsuario"></param>
        public bool InsertarAyudaGobUsuario(FondoAyudaGobEntity ayudaGobUsuario)
        {
            FondoAyudaGobUsuarioDao fondoAyudaGobUsuarioDao = new FondoAyudaGobUsuarioDao();
            return fondoAyudaGobUsuarioDao.InsertarAyudaGobUsuario(ayudaGobUsuario);
        }
    }
}
