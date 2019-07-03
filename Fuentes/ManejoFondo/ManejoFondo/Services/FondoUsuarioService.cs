using ManejoFondo.Daos;
using ManejoFondo.Entities;
using ManejoFondo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Services
{
    /// <summary>
    /// Clase realizar la conexion entre la interfaz y los recursos de conexion para FondoUsuario
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoUsuarioService
    {
        // <summary>
        /// Metodo para insertar un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public bool InsertarUsuario(FondoUsuarioEntity usuario)
        {
            FondoUsuarioDao fondoUsuarioDao = new FondoUsuarioDao();
            return fondoUsuarioDao.InsertarUsuario(usuario);
        }

        // <summary>
        /// Metodo para validar la existencia de un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public FondoUsuarioEntity ConsultarUsuarioPorIdentificacion(FondoUsuarioEntity usuario)
        {
            FondoUsuarioDao fondoUsuarioDao = new FondoUsuarioDao();
            return fondoUsuarioDao.ConsultarUsuarioPorIdentificacion(usuario);
        }

        // <summary>
        /// Metodo para consultar los usuarios del sistema
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public List<FondoUsuarioEntity> ConsultarUsuarios(FondoUsuarioEntity usuario)
        {
            FondoUsuarioDao fondoUsuarioDao = new FondoUsuarioDao();
            return fondoUsuarioDao.ConsultarUsuarios(usuario);
        }

        // <summary>
        /// Metodo para consultar los usuarios del sistema mediante los filtros de pantalla
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public List<UsuarioConsultaModel> ConsultarUsuariosSistema(FondoUsuarioEntity usuario)
        {
            List<UsuarioConsultaModel> resultado = new List<UsuarioConsultaModel>();
            FondoDominiosService fondoDominiosService = new FondoDominiosService();

            List<FondoUsuarioEntity> lstUsuarios = ConsultarUsuarios(usuario);
            //Se transforma la informacion de Entidad a Modelo
            foreach(FondoUsuarioEntity usu in lstUsuarios)
            {
                List<FondoDominiosEntity> lstTipoIdentificacion = fondoDominiosService.ConsultarDominiosPorPadre(usu.V_Tipo_Identificacion, true);
                String valorTipoIdentificacion = lstTipoIdentificacion.Count > 0 ? lstTipoIdentificacion.FirstOrDefault().V_Valor : "";

                UsuarioConsultaModel usuarioModelo = new UsuarioConsultaModel();
                usuarioModelo.NumeroIdentificacion = usu.V_Numero_Identificacion;
                usuarioModelo.TipoIdentificacion = valorTipoIdentificacion;
                usuarioModelo.CodTipoIdentificacion = usu.V_Tipo_Identificacion;
                usuarioModelo.Nombres = usu.V_Nombres;
                usuarioModelo.Apellidos = usu.V_Apellidos;
                usuarioModelo.Telefono = usu.N_Telefono;
                usuarioModelo.FechaRegistro = usu.F_Fecha_Registro;
                resultado.Add(usuarioModelo);
            }
            return resultado;
        }
    }
}
