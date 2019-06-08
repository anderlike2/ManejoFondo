using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Entities
{
    /// <summary>
    /// Clase para el manejo de la tabla FondoAhorroMensual
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoAhorroMensualEntity : ErrorEntity
    {
        public int N_Id { get; set; }
        public long N_Id_Usuario { get; set; }
        public double N_Valor_Cuota { get; set; }
        public DateTime F_Fecha_Registro { get; set; }
    }
}
