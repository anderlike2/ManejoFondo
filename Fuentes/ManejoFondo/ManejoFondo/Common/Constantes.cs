using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Common
{
    /// <summary>
    /// Clase para manejar las constantes del sistema
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>
    static class Constantes
    {
        #region Codigos
        public const int CodigoError = 1;
        public const int CodigoExito = 2;
        public const int CodigoWarning = 3;
        public const string DescripcionError = "Error!";
        public const string DescripcionExito = "Muy bien!";
        public const string DescripcionWarning = "Cuidado!";
        #endregion

        #region Mensajes
        public const string MsjLoginInvalido = "El Usuario o la Contraseña es incorrecta, por favor verifique e inténtelo nuevamente.";
        public const string MsjCamposObligatorios = "Existen campos obligatorios, por favor verifique su información.";
        public const string MsjErrorInesperado = "Ha ocurrido un error inesperado, por favor contactar al Administrador del sistema.";
        #endregion
    }
}
