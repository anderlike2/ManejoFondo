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
    /// Clase realizar la conexion entre la interfaz y los recursos de conexion para FondoSolicitudCredito
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoSolicitudCreditoService
    {
        FondoSolicitudCreditoDao fondoSolicitudCreditoDao = new FondoSolicitudCreditoDao();
        FondoUsuarioService fondoUsuarioService = new FondoUsuarioService();
        FondoAhorroMensualService fondoAhorroMensualService = new FondoAhorroMensualService();

        // <summary>
        /// Metodo para consultar el nombre del asociado
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public string ConsultarNombreAsociado(FondoUsuarioEntity usuario)
        {
            string respuesta = "";
            FondoUsuarioEntity usuarioConsulta = fondoUsuarioService.ConsultarUsuarioPorIdentificacion(usuario);
            if (usuarioConsulta == null)
            {
                throw new BusinessException(Constantes.MsjUsuarioNoEncontrado);
            }
            respuesta = usuarioConsulta.V_Nombres + " " + usuarioConsulta.V_Apellidos;
            return respuesta;
        }

        // <summary>
        /// Metodo para consultar el ahorro de un asociado
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="usuario"></param>
        public string ConsultarAhorroAsociado(FondoAhorroMensualEntity ahorroMensual)
        {
            decimal respuesta = 0;
            List<FondoAhorroMensualEntity> resultado = fondoAhorroMensualService.ConsultarAhorroMensualUsuarioIdentificacion(ahorroMensual);
            if (resultado == null || resultado.Count <= 0)
            {
                throw new BusinessException(Constantes.MsjUsuarioNoAhorro);
            }
           
            foreach(FondoAhorroMensualEntity ahorro in resultado)
            {
                respuesta = respuesta + ahorro.N_Valor_Cuota;
            }
            return respuesta.ToString();
        }

        /// <summary>
        /// Metodo para consultar creditos Activos del Asociado o No Asociado
        /// Autor: Anderson Benavides
        /// 2020-05-09
        /// </summary>
        /// <param name="solicitudCredito"></param>
        public List<FondoSolicitudCreditoEntity> ConsultarCreditosActivos(FondoSolicitudCreditoEntity solicitudCredito)
        {
            return fondoSolicitudCreditoDao.ConsultarCreditosActivos(solicitudCredito);
        }

        // <summary>
        /// Metodo para insertar una solicitud de Credito
        /// Autor: Anderson Benavides
        /// 2020-04-23
        /// </summary>
        /// <param name="usuario"></param>
        public bool InsertarSolicitudCredito(FondoSolicitudCreditoEntity solicitudCredito)
        {
            //Validacion para solicitud doble de ahorro para Asociados
            if (solicitudCredito.V_Tipo_Persona.Equals(Constantes.DominioTipoPersonaAsociado))
            {
                if (2 * (solicitudCredito.N_Valor_Aportes) < solicitudCredito.N_Valor_Solicitado)
                {
                    throw new BusinessException(Constantes.MsjSolicitudDobleAhorro);
                }
            }            

            //Validacion de credito unico Activo por Asociado
            List<FondoSolicitudCreditoEntity> lstSolicitudesActivas = ConsultarCreditosActivos(solicitudCredito);
            if(lstSolicitudesActivas != null && lstSolicitudesActivas.Count > 0)
            {
                throw new BusinessException(Constantes.MsjSolicitudActiva);
            }

            //Validacion de Capacidad de pago (Pendiente)
            //************************************************

            return fondoSolicitudCreditoDao.InsertarSolicitudCredito(solicitudCredito);
        }
    }
}
