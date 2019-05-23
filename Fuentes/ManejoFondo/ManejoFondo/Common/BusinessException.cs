using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Common
{
    /// <summary>
    /// Clase que representa una excepción que se pueda 
    /// lanzar desde la capa de negocio para ser tratada
    /// en la capa de presentación
    /// </summary>
    [Serializable]
    public class BusinessException : Exception
    {
        //constructores
        public BusinessException() : base() { }
        public BusinessException(string message) : base(message) { }
        public BusinessException(string message, Exception e) : base(message, e) { }
        protected BusinessException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
        { }

        /// <summary>
        /// Propiedad que representa mayor información 
        /// de una excepción
        /// </summary>
        public string ExtendedMessage { get; set; }


    }
}
