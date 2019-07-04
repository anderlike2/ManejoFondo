using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Entities
{
    /// <summary>
    /// Clase para el manejo de la tabla FondoLogin
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoLoginEntity : ErrorEntity
    {
        public int N_Id { get; set; }
        public string V_Usuario { get; set; }
        public string V_Password { get; set; }
        public DateTime F_Ultimo_Inicio_Sesion { get; set; }
        public string V_Nombre_Usuario { get; set; }
    }
}
