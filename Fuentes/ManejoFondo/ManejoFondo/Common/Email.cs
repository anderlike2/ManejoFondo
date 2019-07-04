using ManejoFondo.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Common
{
    /// <summary>
    /// Clase para el manejo de envio de Emails
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class Email
    {
        /// <summary>
        /// Propiedad tipo cadena con el asunto del mensaje
        /// </summary>
        public string Asunto { get; set; }

        /// <summary>
        /// Propiedad tipo cadena con la lista de correos electrónicos de los destinatarios separados por coma
        /// </summary>
        public string Destinatarios { get; set; }

        /// <summary>
        /// Propiedad tipo cadena con el cuerpo del mensaje
        /// </summary>
        public string Mensaje { get; set; }

        /// <summary>
        /// Propiedad tipo cadena con la dirección de correo electrónico del carbon copy
        /// </summary>
        public string CarbonCopy { get; set; }

        /// <summary>
        /// Propiedad tipo cadena con el path de la imagen del Header del Mail
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// Propiedad tipo cadena con el path de la imagen del Footer del Mail
        /// </summary>
        public string Footer { get; set; }

        /// <summary>
        /// Propiedad tipo cadena para la url del servidor SMTP
        /// </summary>
        public string SmtpServer { get; set; }

        /// <summary>
        /// Propiedad tipo cadena para el puerto del servidor SMTP
        /// </summary>
        public int SmtpPort { get; set; }

        /// <summary>
        /// Propiedad tipo cadena para el login del servidor SMTP
        /// </summary>
        public string SmtpLogin { get; set; }

        /// <summary>
        /// Propiedad tipo cadena para el password del servidor SMTP
        /// </summary>
        public string SmtpPassword { get; set; }

        /// <summary>
        /// Propiedad tipo cadena para el alias del nombre de  quien envia el correo
        /// </summary>
        public string AliasFromName { get; set; }

        /// <summary>
        /// Propiedad tipo cadena para el nombre de  quien envia el correo
        /// </summary>
        public string FromName { get; set; }

        /// <summary>
        /// Propiedad tipo cadena para la direccion que envia el correo
        /// </summary>
        public string FromEmail { get; set; }

        /// <summary>
        /// Propiedad tipo intero para el máximo rango de la nueva contraseña
        /// </summary>
        public int MaxLegthPassword { get; set; }


        /// <summary>
        /// Propiedad tipo intero para el mínimo rango de la nueva contraseña
        /// </summary>
        public int MinLegthPassword { get; set; }


        /// <summary>
        /// Propiedad tipo booleana para activar o no el cifrado ssl
        /// </summary>
        public bool EnableSsl { get; set; }

        /// <summary>
        /// Variable para el mensaje del correo
        /// </summary>
        private MailMessage mensaje;

        /// <summary>
        /// Variable que sirve de cliente para el envío de correos
        /// </summary>
        private SmtpClient client;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Email()
        {
            FondoParametrosService fondoParametrosService = new FondoParametrosService();
            String correoEmpresa = fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroCorreoEmpresa).V_Valor;
            String passwordCorreoEmpresa = fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroPasswordCorreoEmpresa).V_Valor;
            String nombreCorreo = fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroOrigenCorreos).V_Valor;

            //asigna las propiedades de conexion al servidor SMTP, eamil y nombre de quien envia
            SmtpServer = ConfigurationManager.AppSettings["SMTP_SERVER"];
            SmtpPort = int.Parse(ConfigurationManager.AppSettings["SMTP_PORT"]);
            SmtpLogin = correoEmpresa;
            SmtpPassword = passwordCorreoEmpresa;
            AliasFromName = correoEmpresa;
            FromName = nombreCorreo;
            FromEmail = correoEmpresa;
            EnableSsl = bool.Parse(ConfigurationManager.AppSettings["ENABLE_SSL"]);
        }

        /// <summary>
        /// Constructor que inicializa las propiedades Asunto, Carbon Copy, Destinarios, Mensaje, Remitente
        /// </summary>
        /// <param name="pDestinatarios"></param>
        /// <param name="pCC"></param>
        /// <param name="pAsunto"></param>
        /// <param name="pMensaje"></param>
        /// <param name="rutaHeader"></param>
        /// <param name="rutaFooter"></param>
        public Email(string pDestinatarios, string pCC, string pAsunto, string pMensaje, string rutaHeader, string rutaFooter)
        {
            FondoParametrosService fondoParametrosService = new FondoParametrosService();
            String correoEmpresa = fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroCorreoEmpresa).V_Valor;
            String passwordCorreoEmpresa = fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroPasswordCorreoEmpresa).V_Valor;
            String nombreCorreo = fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroOrigenCorreos).V_Valor;

            this.Destinatarios = pDestinatarios;
            this.CarbonCopy = pCC;
            this.Asunto = pAsunto;
            this.Mensaje = pMensaje;
            this.Header = rutaHeader;
            this.Footer = rutaFooter;

            //asigna las propiedades de conexion al servidor SMTP, eamil y nombre de quien envia
            SmtpServer = ConfigurationManager.AppSettings["SMTP_SERVER"];
            SmtpPort = int.Parse(ConfigurationManager.AppSettings["SMTP_PORT"]);
            SmtpLogin = correoEmpresa;
            SmtpPassword = passwordCorreoEmpresa;
            AliasFromName = correoEmpresa;
            FromName = nombreCorreo;
            FromEmail = correoEmpresa;
            EnableSsl = bool.Parse(ConfigurationManager.AppSettings["ENABLE_SSL"]);
        }

        /// <summary>
        /// Método que inicializa los parámetros para el envío de correos
        /// </summary>
        private void Inicializar()
        {
            try
            {
                //parametros de conexion al smtp
                int puertoSMTP = SmtpPort;
                string hostSMTP = SmtpServer;
                string userName = SmtpLogin;
                string password = SmtpPassword;
                string fromName = FromName;
                string fromEmail = FromEmail;

                client = new SmtpClient(hostSMTP);
                client.Port = puertoSMTP;
                client.Credentials = new System.Net.NetworkCredential(userName, password);
                client.EnableSsl = this.EnableSsl;

                client.DeliveryFormat = SmtpDeliveryFormat.International;
                MailAddress from = new MailAddress(fromEmail, fromName);

                mensaje = new MailMessage();
                mensaje.From = from;

                // Agregar destinatarios, separados por coma (,)
                mensaje.To.Add(Destinatarios);

                // Agregar carbon copy. CC 
                if (CarbonCopy != null)
                    mensaje.CC.Add(CarbonCopy);

                mensaje.Subject = new string(new char[] { '\u200B' }) + Asunto + new string(new char[] { '\u200B' });
                mensaje.SubjectEncoding = Encoding.UTF8;
                mensaje.Body = Mensaje;
                mensaje.BodyEncoding = Encoding.UTF8;
                mensaje.IsBodyHtml = true;

                if (System.IO.File.Exists(Header) && !System.IO.File.Exists(Footer))
                {
                    //Header
                    var headerMail = new LinkedResource(Header);
                    headerMail.ContentId = Guid.NewGuid().ToString();

                    string body = Mensaje.Replace("{0}", headerMail.ContentId);

                    var view = AlternateView.CreateAlternateViewFromString(body, null, "text/html");
                    view.LinkedResources.Add(headerMail);
                    mensaje.AlternateViews.Add(view);
                }

                if (!System.IO.File.Exists(Header) && System.IO.File.Exists(Footer))
                {
                    //Footer
                    var footerMail = new LinkedResource(Footer);
                    footerMail.ContentId = Guid.NewGuid().ToString();

                    string body = Mensaje.Replace("{1}", footerMail.ContentId);

                    var view = AlternateView.CreateAlternateViewFromString(body, null, "text/html");
                    view.LinkedResources.Add(footerMail);
                    mensaje.AlternateViews.Add(view);
                }

                if (System.IO.File.Exists(Header) && System.IO.File.Exists(Footer))
                {
                    //Header
                    var headerMail = new LinkedResource(Header);
                    headerMail.ContentId = Guid.NewGuid().ToString();

                    string body = Mensaje.Replace("{0}", headerMail.ContentId);

                    //Footer
                    var footerMail = new LinkedResource(Footer);
                    footerMail.ContentId = Guid.NewGuid().ToString();

                    body = body.Replace("{1}", footerMail.ContentId);

                    var view = AlternateView.CreateAlternateViewFromString(body, null, "text/html");
                    view.LinkedResources.Add(headerMail);
                    view.LinkedResources.Add(footerMail);
                    mensaje.AlternateViews.Add(view);
                }
                else
                {
                    mensaje.Body = Mensaje;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método para envíar los mensajes. El mismo se apoya en una configuración de un servidor SMTP.
        /// Los datos de configuración del SMTP están en el app.config de el proyecto pruebas, y en el web config 
        /// </summary>
        public bool Enviar()
        {
            try
            {
                Inicializar();
                client.Send(mensaje);
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
