using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Entities
{
    /// <summary>
    /// Clase para el manejo de la tabla FondoUsuario
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class FondoUsuarioEntity : ErrorEntity
    {
        public int N_Id { get; set; }
        public string V_Tipo_Identificacion { get; set; }
        public string V_Numero_Identificacion { get; set; }
        public string V_Nombres { get; set; }
        public string V_Apellidos { get; set; }
        public int N_Telefono { get; set; }
        public string V_Nivel_Estudio { get; set; }
        public string V_Puntaje_Sisben { get; set; }
        public string V_Estado_Civil { get; set; }
        public string V_Nombre_Institucion { get; set; }
        public DateTime F_Fecha_Nacimiento { get; set; }
        public DateTime F_Fecha_Registro { get; set; }
    }
}
