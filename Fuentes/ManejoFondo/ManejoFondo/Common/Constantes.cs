﻿using System;
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
        public const string DescripcionAgricultura = "Agricultura";
        public const string DescripcionPecuario = "Pecuario";
        #endregion

        #region Mensajes
        public const string MsjLoginInvalido = "El usuario y/o la contraseña son incorrectos, por favor verifique e inténtelo nuevamente.";
        public const string MsjCamposObligatorios = "Los campos marcados con * son obligatorios, por favor verifique su información.";
        public const string MsjErrorInesperado = "Ha ocurrido un error inesperado, por favor contactar al Administrador del sistema.";
        public const string MsjErrorSeguridad = "Su sistema ha caducado, por favor consulte con el Administrador del Sistema.";
        public const string MsjeReinicioFormulario = "Se ha eliminado la información ingresada. Por favor diligencie nuevamente toda la información requerida.";
        public const string MsjExitoGuardar = "La información se ha almacenado con éxito.";
        public const string MsjExitoEliminar = "La información se ha eliminado con éxito.";
        public const string MsjExitoEnviarCorreo = "El correo se ha enviado satisfactoriamente al Administrador del sistema.";
        public const string MsjUsuarioExiste = "El usuario que usted desea ingresar ya se encuentra registrado en el sistema.";
        public const string MsjUsuarioNoExiste = "El usuario que usted ha ingresado no se encuentra registrado en el sistema.";
        public const string MsjAhorroExistenteMes = "El usuario ya tiene un ahorro para el mes seleccionado.";
        public const string MsjExitoAhorroMes = "El ahorro mensual se ha almacenado correctamente.";
        public const string MsjValidarMinimoCuota = "La cuota mensual ingresada debe ser mayor a: $ <minimoCuota>.";
        public const string MsjValidarMaximoCuota = "La cuota mensual ingresada debe ser menor a: $ <maximoCuota>.";
        public const string MsjPasswordNoCoincide = "La nueva contraseña no coincide.";
        public const string MsjExitoActualizarClave = "El usuario y la contraseña se han actualizado con éxito.";
        public const string MsjPasswordCrearUsuarioNoCoincide = "Las contraseñas del usuario no coinciden.";
        public const string MsjCorreoCrearUsuarioNoCoincide = "Los correos del usuario no coinciden.";
        public const string MsjCorreoCrearUsuarioInvalido = "El correo ingresado es inválido.";
        public const string MsjNoInternetErrorEnviarCorreo = "Usted no se encuentra conectado a internet, no ha sido posible enviar el correo electrónico.";
        public const string MsjCrearUsuarioYaTieneAdministrador = "Usted ya tiene un usuario registrado en el Sistema, si ha olvidado su contraseña por favor seleccione la opción 'Olvidó su credenciales de Acceso?'";
        public const string MsjNoTieneAdministrador = "Usted no tiene un usuario registrado en el Sistema. Por favor crear un nuevo usuario.";
        public const string MsjUsuarioNoEncontrado = "El usuario no se encuentra registrado en el sistema.";
        public const string MsjUsuarioNoAhorro = "El usuario no tiene ningún ahorro registrado.";
        public const string MsjUsuarioNoCreditoActivo = "El usuario no tiene ninguna solicitud de crédito Activa.";
        public const string MsjIngresarNumeroIdentificacion= "Por favor ingrese el número de identificación del asociado.";
        public const string MsjExitoSolicitudCredito = "La solicitud de crédito se ha almacenado correctamente.";
        public const string MsjSolicitudDobleAhorro = "La solicitud es más del doble de su ahorro, no es posible realizar la solicitud.";
        public const string MsjSolicitudActiva = "El Asociado tiene un crédito pendiente por pagar, no es posible realizar la solicitud.";
        #endregion

        #region MensajesTooltips
        public const string MsjTooltipConsultarUsuarios = "Realice aquí la consulta de los asociados.";
        public const string MsjTooltipAsociados = "Ingrese un nuevo asociado a la entidad.";
        public const string MsjTooltipAhorro = "Haga el ahorro mensual de un asociado.";
        public const string MsjTooltipSolicitudCredito = "Realice aquí una solicitud de crédito para el asociado.";
        public const string MsjTooltipAmortizacionCredito = "Realice aquí amortización de su crédito.";
        public const string MsjTooltipReportes = "Genere un reporte de información de los asociados.";
        public const string MsjTooltipIndicadores = "Consulte los indicadores relacionados con los ahorros de los asociados.";
        public const string MsjTooltipCambiarClave = "Realice un cambio de clave para el usuario Administrador.";
        public const string MsjTooltipParametrizacion = "Realice parametrización de informacion básica del sistema.";
        public const string MsjTooltipCerrarSesion = "Cerrar sesión.";

        public const string MsjAceptar = "Almacenar información.";
        public const string MsjCancelar = "Limpiar información.";
        public const string MsjRegresar = "Regresar al menú principal.";
        #endregion

        #region Dominios
        public const string DominioPais = "CO57";
        public const string DominioTiposIdentificacion = "TIPOS_IDENTIFICACION";
        public const string DominioNivelEstudio = "NIVEL_ESTUDIO";
        public const string DominioEstadoCivil = "ESTADO_CIVIL";
        public const string DominioTipoVictima = "VICTIMA";
        public const string DominioOpcionesSiyNo = "SINO";
        public const string DominioTipoSubsidio = "TIPO_SUBSIDIO";
        public const string DominioTipoActividad = "TIPO_ACTIVIDAD";
        public const string DominioParentesco = "PARENTESCO";
        public const string DominioConyuge = "PARENT_CONYUGE";
        public const string DominioTipoPersona = "TIPO_PERSONA";
        public const string DominioTipoPersonaAsociado = "TIPO_PERSONA_ASOCIADO";
        public const string DominioTipoPersonaNoAsociado = "TIPO_PERSONA_NO_ASOCIADO";
        #endregion

        #region Parametros
        public const string ParametroAhorroCuotaMinima = "AHORRO_CUOTA_MINIMA";
        public const string ParametroAhorroCuotaMaxima = "AHORRO_CUOTA_MAXIMA";
        public const string ParametroPlantillaCorreoCreacionUsuario = "PLANTILLA_CORREO_CREACION_USUARIO";
        public const string ParametroPlantillaCorreoRecuperarPassword = "PLANTILLA_CORREO_RECUPERAR_PASSWORD";
        public const string ParametroNombreEmpresa = "NOMBRE_EMPRESA";
        public const string ParametroTelefonoEmpresa = "TELEFONO_EMPRESA";
        public const string ParametroCorreoEmpresa = "CORREO_EMPRESA";
        public const string ParametroPasswordCorreoEmpresa = "PASSWORD_CORREO_EMPRESA";
        public const string ParametroOrigenCorreos = "ORIGEN_CORREOS";
        public const string ParametroPorcentajeCapacidadPago = "PORCENTAJE_CAPACIDAD_PAGO";
        #endregion
    }
}
