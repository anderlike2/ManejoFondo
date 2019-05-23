using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Entities
{
    /// <summary>
    /// Clase para el manejo de la tabla FondoParametros
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoParametrosEntity : ErrorEntity
    {
        public int N_Id { get; set; }
        public string V_Nombre { get; set; }
        public string V_Valor { get; set; }
    }
}
