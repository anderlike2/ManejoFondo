using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Entities
{
    /// <summary>
    /// Clase para el manejo de la tabla FondoProcUsuario
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoProcUsuarioEntity : ErrorEntity
    {
        public int N_Id { get; set; }
        public long N_Id_Usuario { get; set; }
        public string V_Pais { get; set; }
        public string V_Departamento { get; set; }
        public string V_Municipio { get; set; }
        public string V_Vereda { get; set; }
    }
}
