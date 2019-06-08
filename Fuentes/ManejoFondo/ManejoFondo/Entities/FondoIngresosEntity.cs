using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Entities
{
    /// <summary>
    /// Clase para el manejo de la tabla FondoIngresos
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoIngresosEntity : ErrorEntity
    {
        public int N_Id { get; set; }
        public long N_Id_Usuario { get; set; }
        public float N_Ingresos_Mensuales { get; set; }
        public string V_Tipo_Actividad { get; set; }
        public string V_Tipo_Animales { get; set; }
        public string V_Tipo_Cultivo { get; set; }
    }
}
