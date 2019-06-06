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
        public const string DescripcionSeleccione = "Seleccione...";
        public const string DescripcionSi = "Si";
        public const string DescripcionNo = "No";
        public const string DescripcionOtro = "Otro";
        #endregion

        #region Mensajes
        public const string MsjLoginInvalido = "El usuario y/o la contraseña son incorrectos, por favor verifique e inténtelo nuevamente.";
        public const string MsjCamposObligatorios = "Los campos marcados con * son obligatorios, por favor verifique su información.";
        public const string MsjErrorInesperado = "Ha ocurrido un error inesperado, por favor contactar al Administrador del sistema.";
        public const string MsjErrorSeguridad = "Su sistema ha caducado, por favor consulte con el Administrador del Sistema.";
        #endregion

        #region MensajesTooltips
        public const string MsjTooltipConsultarUsuarios = "Realice aquí la consulta de los asociados.";
        public const string MsjTooltipAsociados = "Ingrese un nuevo asociado a la entidad.";
        public const string MsjTooltipAhorro = "Haga el ahorro mensual de un asociado.";
        public const string MsjTooltipSolicitudCredito = "Realice aquí una solicitud de crédito para el asociado.";
        public const string MsjTooltipReportes = "Genere un reporte de información de los asociados.";
        public const string MsjTooltipIndicadores = "Consulte los indicadores relacionados con los ahorros de los asociados.";
        public const string MsjTooltipCambiarClave = "Realice un cambio de clave para el usuario Administrador.";
        public const string MsjTooltipParametrizacion = "Realice parametrización de informacion básica del sistema.";

        public const string MsjAceptar = "Almacenar información.";
        public const string MsjCancelar = "Limpiar información.";
        public const string MsjRegresar = "Regresar al menú principal.";
        #endregion

        #region Dominios
        public const string DominioPais = "PAIS_COL";
        public const string DominioTiposIdentificacion = "TIPOS_IDENTIFICACION";
        public const string DominioNivelEstudio = "NIVEL_ESTUDIO";
        public const string DominioEstadoCivil = "ESTADO_CIVIL";
        public const string DominioTipoVictima = "VICTIMA";
        public const string DominioOpcionesSiyNo = "SINO";
        public const string DominioTipoSubsidio = "TIPO_SUBSIDIO";
        public const string DominioTipoActividad = "TIPO_ACTIVIDAD";
        public const string DominioParentesco = "PARENTESCO";
        #endregion
    }
}
