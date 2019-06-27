using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Modelos
{
    /// <summary>
    /// Clase para el manejo de la consulta de usuarios
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    public class UsuarioConsultaModel
    {
        public string TipoIdentificacion { get; set; }
        public string CodTipoIdentificacion { get; set; }
        public long NumeroIdentificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public long Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
