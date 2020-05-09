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
    /// Clase realizar la conexion entre la interfaz y los recursos de conexion para FondoAhorroMensual
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoAhorroMensualService
    {
        FondoParametrosService fondoParametrosService = new FondoParametrosService();

        // <summary>
        /// Metodo para insertar un ahorro de un usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="ahorroMensual"></param>
        public bool InsertarAhorroUsuario(FondoAhorroMensualEntity ahorroMensual)
        {
            FondoAhorroMensualDao fondoAhorroMensualDao = new FondoAhorroMensualDao();

            //Se valida si el usuario ya ingreso su ahorro para el mes correspondiente
            FondoLoginEntity validarAhorroMes = ConsultarAhorroMensualUsuario(ahorroMensual);
            if(validarAhorroMes != null)
            {
                throw new BusinessException(Constantes.MsjAhorroExistenteMes);
            }

            //Se valida los topes maximos y minimos de la cuota
            decimal valorMinimoCuota = Convert.ToDecimal(fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroAhorroCuotaMinima).V_Valor);
            decimal valorMaximoCuota = Convert.ToDecimal(fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroAhorroCuotaMaxima).V_Valor);
            if(ahorroMensual.N_Valor_Cuota < valorMinimoCuota)
            {
                throw new BusinessException(Constantes.MsjValidarMinimoCuota.Replace("<minimoCuota>", valorMinimoCuota.ToString()));
            }
            if (ahorroMensual.N_Valor_Cuota > valorMaximoCuota)
            {
                throw new BusinessException(Constantes.MsjValidarMaximoCuota.Replace("<maximoCuota>", valorMaximoCuota.ToString()));
            }

            return fondoAhorroMensualDao.InsertarAhorroUsuario(ahorroMensual);
        }

        /// <summary>
        /// Metodo para consultar un ahorro de un usuario mediante identificacion, mes y año
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        /// <param name="ahorroMensual"></param>
        public FondoLoginEntity ConsultarAhorroMensualUsuario(FondoAhorroMensualEntity ahorroMensual)
        {
            FondoAhorroMensualDao fondoAhorroMensualDao = new FondoAhorroMensualDao();
            return fondoAhorroMensualDao.ConsultarAhorroMensualUsuario(ahorroMensual);
        }

        /// <summary>
        /// Metodo para consultar un ahorro de un usuario mediante identificacion
        /// Autor: Anderson Benavides
        /// 2020-04-19
        /// </summary>
        /// <param name="ahorroMensual"></param>
        public List<FondoAhorroMensualEntity> ConsultarAhorroMensualUsuarioIdentificacion(FondoAhorroMensualEntity ahorroMensual)
        {
            FondoAhorroMensualDao fondoAhorroMensualDao = new FondoAhorroMensualDao();
            return fondoAhorroMensualDao.ConsultarAhorroMensualUsuarioIdentificacion(ahorroMensual);
        }
    }
}
