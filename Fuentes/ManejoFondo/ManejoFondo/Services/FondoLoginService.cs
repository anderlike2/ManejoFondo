using ManejoFondo.Common;
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
    /// Clase realizar la conexion entre la interfaz y los recursos de conexion para FondoLogin
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoLoginService
    {
        /// <summary>
        /// Metodo para consultar un usuario mediante usuario y password
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public FondoLoginEntity ConsultarUsuario(String username, String password)
        {
            if (General.EsVacioNulo(username) || General.EsVacioNulo(password)) {
                throw new BusinessException(Constantes.MsjCamposObligatorios);
            }

            FondoLoginDao fondoLoginDao = new FondoLoginDao();
            FondoLoginEntity usuarioFiltro = new FondoLoginEntity
            {
                V_Username = username,
                V_Password = General.EncriptarCadena(password)
            };
            FondoLoginEntity respuesta = fondoLoginDao.ConsultarUsuario(usuarioFiltro);
            if (respuesta == null) {
                throw new BusinessException(Constantes.MsjLoginInvalido);
            }

            return respuesta;
        }

        /// <summary>
        /// Metodo para actualizar la fecha de inicio de sesion
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="id"></param>
        public bool ActualizarFechaInicioSesion(int id)
        {
            FondoLoginDao fondoLoginDao = new FondoLoginDao();
            FondoLoginEntity usuarioFiltro = new FondoLoginEntity
            {
                N_Id = id,
                F_Ultimo_Inicio_Sesion = DateTime.Now
            };
            return fondoLoginDao.ActualizarFechaInicioSesion(usuarioFiltro);
        }

        /// <summary>
        /// Metodo para actualizar la informacion de inicio de sesion
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="passwordNuevo"></param>
        /// <param name="passwordNuevoRepite"></param>
        public bool ActualizarInformacionUsuario(int id, String username, String password, String passwordNuevo, String passwordNuevoRepite)
        {
            FondoLoginDao fondoLoginDao = new FondoLoginDao();

            if (!passwordNuevo.Equals(passwordNuevoRepite))
            {
                throw new BusinessException(Constantes.MsjPasswordNoCoincide);
            }
            //Se consulta el usuario
            FondoLoginEntity usuarioFiltro = new FondoLoginEntity
            {
                N_Id = id,
                V_Username = username,
                V_Password = General.EncriptarCadena(password)
            };
            FondoLoginEntity respuesta = fondoLoginDao.ConsultarUsuarioPorId(usuarioFiltro);
            if (respuesta == null)
            {
                throw new BusinessException(Constantes.MsjLoginInvalido);
            }
            //Se actualiza con la nueva contraseña
            usuarioFiltro.V_Password = General.EncriptarCadena(passwordNuevo);
            return fondoLoginDao.ActualizarInformacionUsuario(usuarioFiltro);
        }
    }
}
