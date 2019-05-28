using ManejoFondo.Loggers;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Common
{
    /// <summary>
    /// Clase para el manejo de los logs de la aplicacion
    /// Autor: Anderson Benavides
    /// 2019-05-27
    /// </summary>
    public static class Log
    {
        /// <summary>
        /// Metodo para escribir log error
        /// </summary>
        /// <param name="message">mensaje</param>
        public static void WriteLogError(string message)
        {
            WriteLog(message, System.Diagnostics.TraceEventType.Error);
        }

        /// <summary>
        /// Metodo para escribir log informacion
        /// </summary>
        /// <param name="message">mensaje</param>
        public static void WriteLogInformation(string message)
        {
            WriteLog(message, System.Diagnostics.TraceEventType.Information);
        }

        /// <summary>
        /// método para dejar un registro de log
        /// </summary>
        /// <param name="message">mensaje</param>
        /// <param name="severity">severidad</param>
        private static void WriteLog(string message, System.Diagnostics.TraceEventType severity)
        {
            LogEntry logEntry = new LogEntry { Message = message, Severity = severity, TimeStamp = DateTime.Now };
            Logger.Write(logEntry);

        }

        /// <summary>
        /// registra un Log de error
        /// </summary>
        /// <param name="Mensaje"></param>
        /// <param name="pantalla"></param>
        /// <param name="logError"></param>
        public static void Registrar_Log(string Mensaje, string pantalla, LogErrorEnumeration logError)
        {
            LogEntry logEntry = new LogEntry();
            logEntry.Severity = (System.Diagnostics.TraceEventType)logError;
            logEntry.Title = pantalla;
            logEntry.Message = Mensaje;
            Logger.Write(logEntry);
        }

        /// <summary>
        /// construye el detalle del mensaje segun la excepcion
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="esExNegocio"></param>
        /// <returns>mensaje de error de la excepcion</returns>
        public static string ConstruyeMensajeError(Exception ex, bool esExNegocio)
        {
            string error = string.Empty;
            string tipoEx = esExNegocio ? "BE" : "E";

            error += Environment.NewLine;
            error += "*****************************************************************************************************";
            error += Environment.NewLine;
            error += string.Format("Tipo: {0}", tipoEx);
            error += Environment.NewLine;
            error += string.Format("Mensaje: {0}", ex.Message);
            error += Environment.NewLine;
            error += string.Format("StackTrace: {0}", ex.StackTrace);
            error += Environment.NewLine;
            error += "*****************************************************************************************************";

            return error;
        }
    }
}
