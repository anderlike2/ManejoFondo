using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Entities
{
    /// <summary>
    /// Clase para el manejo de la tabla FondoSolicitudCredito
    /// Autor: Anderson Benavides
    /// 2020-04-22
    /// </summary>
    public class FondoSolicitudCreditoEntity
    {
        public int N_Id { get; set; }
        public long N_Id_Usuario { get; set; }
        public string V_Tipo_Identificacion { get; set; }
        public decimal N_Valor_Aportes { get; set; }
        public DateTime D_Fecha_Solicitud { get; set; }
        public string V_Estado { get; set; } // A -> Activo, P -> Pagado
        public decimal N_Valor_Solicitado { get; set; }
        public string V_Ing_Tipo_Actividad { get; set; }
        public string V_Ing_Cual { get; set; }
        public decimal N_Ing_Valor { get; set; }
        public long N_Ing_Cada_Cuanto { get; set; }
        public string V_Ot_Ing_Tipo_Actividad { get; set; }
        public string V_Ot_Ing_Cual { get; set; }
        public decimal N_Ot_Ing_Valor { get; set; }
        public long N_Ot_Ing_Cada_Cuanto { get; set; }
        public decimal N_Egr_Gastos_Fam { get; set; }
        public decimal N_Egr_Gastos_Prod { get; set; }
        public long N_Egr_Cuotas_Financ { get; set; }
        public long N_Egr_Cuotas_Partic { get; set; }
        public decimal N_Total_Disponible { get; set; }
        public decimal N_Capacidad_Pago { get; set; }
        public decimal N_Total_Ingresos { get; set; }
        public decimal N_Total_Egresos { get; set; }
        public string V_Tipo_Persona { get; set; } // A -> Asociado, NA -> No Asociado
        public string V_Nombre_Completo { get; set; }
    }
}
