using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Entities
{
    /// <summary>
    /// Clase para el manejo de la tabla FondoAyudaGob
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoAyudaGobEntity : ErrorEntity
    {
        public int N_Id { get; set; }
        public long N_Id_Usuario { get; set; }
        public string V_Tipo_Victima { get; set; }
        public string V_Recibe_Subsidio { get; set; }
        public string V_Tipo_Subsidio { get; set; }
    }
}
