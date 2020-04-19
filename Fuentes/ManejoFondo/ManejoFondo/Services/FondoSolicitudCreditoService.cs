using ManejoFondo.Common;
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
            double respuesta = 0;
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
    }
}
