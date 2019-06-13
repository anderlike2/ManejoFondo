using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Entities
{
    /// <summary>
    /// Clase para el manejo de la tabla FondoFamilia
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoFamiliaEntity : ErrorEntity
    {
        public int N_Id { get; set; }
        public long N_Id_Usuario { get; set; }
        public string V_Nombres { get; set; }
        public string V_Apellidos { get; set; }
        public string V_Tipo_Identificacion { get; set; }
        public long V_Numero_Identificacion { get; set; }
        public DateTime F_Fecha_Nacimiento { get; set; }
        public string V_Tipo_Parentesco { get; set; }
        public long N_Telefono { get; set; }
        public string V_Tipo_Actividad { get; set; }
        public string V_Cual_Otra { get; set; }
    }
}
