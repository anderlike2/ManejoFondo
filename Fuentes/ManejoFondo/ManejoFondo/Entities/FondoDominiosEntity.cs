using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Entities
{
    /// <summary>
    /// Clase para el manejo de la tabla FondoDominio
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoDominiosEntity :  ErrorEntity
    {
        public int N_Id { get; set; }
        public string V_Codigo { get; set; }
        public string V_Valor { get; set; }
        public string V_Valor_Auxiliar1 { get; set; }
        public string V_Valor_Auxiliar2 { get; set; }
        public string V_Padre { get; set; }
    }
}
