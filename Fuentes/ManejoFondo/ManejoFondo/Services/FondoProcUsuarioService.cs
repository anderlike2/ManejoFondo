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
    /// Clase realizar la conexion entre la interfaz y los recursos de conexion para FondoProcUsuario
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoProcUsuarioService
    {
        // <summary>
        /// Metodo para insertar la procedencia de un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="procUsuario"></param>
        public bool InsertarProcedenciaUsuario(FondoProcUsuarioEntity procUsuario)
        {
            FondoProcUsuarioDao fondoProcUsuarioDao = new FondoProcUsuarioDao();
            return fondoProcUsuarioDao.InsertarProcedenciaUsuario(procUsuario);
        }
    }
}
