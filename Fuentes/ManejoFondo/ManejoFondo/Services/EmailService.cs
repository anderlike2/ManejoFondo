using ManejoFondo.Common;
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
    /// Clase para el manejo de envio de Emails
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    class EmailService
    {
        /// <summary>
        /// Service para enviar correos
        /// Author: Luisa
        /// 2019-04-04
        /// </summary>
        /// <param name="plantilla"></param>
        /// <param name="emailDto"></param>
        /// <returns>Envia un correo con los parámetros asignados</returns>
        public void enviarEmail(string plantilla, EmailDTO emailDto)
        {
            // Obtener plantilla
            // Obtener el mensaje del correo
            Email correo = new Email();
            correo.Destinatarios = emailDto.Destinatarios;
            correo.Asunto = emailDto.Asunto;
            correo.Mensaje = plantilla;
            correo.Enviar();
        }

        /// <summary>
        /// Metodo para enviar el correo con las credenciales de acceso al sistema
        /// Author: Miguel
        /// 2019-04-04
        /// </summary>
        /// <param name="loginUsuario"></param>
        /// <returns></returns>
        public void enviarEmailCreacionUsuario(FondoLoginEntity loginUsuario)
        {
            EmailDTO emailDTO = new EmailDTO();
            FondoParametrosService fondoParametrosService = new FondoParametrosService();
            // se lee la plantila de html
            string template = fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroPlantillaCorreoCreacionUsuario).V_Valor;

            // se reemplazan los codigos claves de la plantilla por los datos del usuario
            template = template.Replace("{usuario}", loginUsuario.V_Nombre_Usuario);
            template = template.Replace("{username}", loginUsuario.V_Usuario);
            template = template.Replace("{password}", loginUsuario.V_Password);

            //se envia el destinatario y el mensaje al metodo de envio de correo electrónico
            emailDTO.Asunto = "Creación de Usuario";
            emailDTO.Destinatarios = fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroCorreoEmpresa).V_Valor;
            enviarEmail(template, emailDTO);
        }

        /// <summary>
        /// Metodo para enviar el correo con la recuperacion de su password
        /// Author: Miguel
        /// 2019-04-04
        /// </summary>
        /// <param name="loginUsuario"></param>
        /// <returns></returns>
        public void enviarEmailRecuperarPassword(FondoLoginEntity loginUsuario)
        {
            EmailDTO emailDTO = new EmailDTO();
            FondoParametrosService fondoParametrosService = new FondoParametrosService();
            // se lee la plantila de html
            string template = fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroPlantillaCorreoRecuperarPassword).V_Valor;

            // se reemplazan los codigos claves de la plantilla por los datos del usuario
            template = template.Replace("{usuario}", loginUsuario.V_Nombre_Usuario);
            template = template.Replace("{username}", loginUsuario.V_Usuario);
            template = template.Replace("{password}", General.DesencriptarCadena(loginUsuario.V_Password));

            //se envia el destinatario y el mensaje al metodo de envio de correo electrónico
            emailDTO.Asunto = "Recuperar Password";
            emailDTO.Destinatarios = fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroCorreoEmpresa).V_Valor;
            enviarEmail(template, emailDTO);
        }
    }
}
