using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Modelos
{
    /// <summary>
    /// Clase para el manejo de la simulacion del credito
    /// Autor: Anderson Benavides
    /// 2020-06-04
    /// </summary>
    public class SimulacionCreditoModel
    {
        public long NumeroCuota { get; set; }
        public DateTime FechaPagoCuota { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal ValorCuota { get; set; }
        public decimal Saldo { get; set; }
    }
}
