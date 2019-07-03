using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Modelos
{
    /// <summary>
    /// Se utilizan para que el usuario mande parametros a los correos electrónicos
    /// </summary>
    public class EmailDTO
    {
        public string Destinatarios { get; set; }
        public string Asunto { get; set; }
    }
}
