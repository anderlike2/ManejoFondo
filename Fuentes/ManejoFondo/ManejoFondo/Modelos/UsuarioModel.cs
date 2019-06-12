using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Modelos
{
    /// <summary>
    /// Clase para el manejo de la creacion de un usuario
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class UsuarioModel
    {
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TipoActividad { get; set; }
        public string OtraActividad { get; set; }
        public string Parentesco { get; set; }

        public string CodTipoIdentificacion { get; set; }
        public string CodTipoActividad { get; set; }
        public string CodParentesco { get; set; }
    }
}
