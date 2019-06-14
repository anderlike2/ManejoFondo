using ManejoFondo.Common;
using ManejoFondo.Entities;
using ManejoFondo.Loggers;
using ManejoFondo.Services;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoFondo
{
    /// <summary>
    /// Clase para iniciar el formulario de Ahorro Cuota Mensual
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary> 
    public partial class FormOptAhorroCuotaMensual : MaterialForm
    {
        //Variable para guardar el usuario que inicio sesion
        FondoLoginEntity usuarioSesion;
        FondoUsuarioService fondoUsuarioService = new FondoUsuarioService();
        FondoParametrosService fondoParametrosService = new FondoParametrosService();

        public FormOptAhorroCuotaMensual(FondoLoginEntity usuario)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Cambiar Tema form
            General.InicializarTema(this);

            //Valores por defecto
            usuarioSesion = usuario;
            InicializarTooltips();
            CargarCombobox();
        }

        /// <summary>
        /// Inicializar Tooltips
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void InicializarTooltips()
        {
            //Crear Tooltips
            ToolTip toolTip = new ToolTip();

            //Se agrega atributos del tooltip
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 500;
            //Mostrar tooltip en elemento activo
            toolTip.ShowAlways = true;

            //Se establece los tooltips a los controles
            toolTip.SetToolTip(panelRegresarMenu, Constantes.MsjRegresar);
        }

        /// <summary>
        /// Cargar los valores de los combobox principales
        /// Autor: Anderson Benavides
        /// 2019-06-02
        /// </summary>
        private void CargarCombobox()
        {
            try
            {
                FondoDominiosService fondoDominioService = new FondoDominiosService();

                //Para Datos Persona
                comboBoxCuotaMensualTipoIdentificacion.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTiposIdentificacion, false); ;
                comboBoxCuotaMensualTipoIdentificacion.DisplayMember = "V_VALOR";
                comboBoxCuotaMensualTipoIdentificacion.ValueMember = "V_CODIGO";

            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "FormOptAhorroCuotaMensual - CargarCombobox", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Regresar al menú principal
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void RegresarMenuPrincipal(object sender, EventArgs e)
        {
            //Se inicia el formulario de opciones
            FormMenu formOpciones = new FormMenu(usuarioSesion);
            Hide();
            formOpciones.ShowDialog();
            Close();
        }

        /// <summary>
        /// Funcion que permite solo el ingreso de numeros
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Funcion que permite buscar informacion del usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void BuscarInformacionUsuario(object sender, EventArgs e)
        {
            try
            {
                InhabilitarBotonesConsulta();
                if (General.EsVacioNulo(comboBoxCuotaMensualTipoIdentificacion.Text) || General.EsVacioNulo(textBoxCuotaMensualNumeroIdentificacion.Text))
                {
                    General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjCamposObligatorios);
                    HabilitarBotonesConsulta();
                    return;
                }
                else
                {
                    FondoDominiosEntity datosPersonaTipoIdentificacion = (FondoDominiosEntity)comboBoxCuotaMensualTipoIdentificacion.SelectedItem;
                    FondoUsuarioEntity usuarioValidar = new FondoUsuarioEntity();
                    usuarioValidar.V_Tipo_Identificacion = datosPersonaTipoIdentificacion.V_Codigo;
                    usuarioValidar.V_Numero_Identificacion = Convert.ToInt64(textBoxCuotaMensualNumeroIdentificacion.Text);
                    FondoUsuarioEntity resultado = fondoUsuarioService.ConsultarUsuarioPorIdentificacion(usuarioValidar);
                    if (resultado == null)
                    {
                        throw new BusinessException(Constantes.MsjUsuarioNoExiste);
                    }
                    //Se muestra informacion del usuario
                    textBoxCuotaMensualNombres.Text = resultado.V_Nombres;
                    textBoxCuotaMensualApellidos.Text = resultado.V_Apellidos;
                    string fechaRegistro = resultado.F_Fecha_Registro.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
                    textBoxCuotaMensualFechaIngreso.Text = fechaRegistro;
                    textBoxCuotaMensualValorProximaCuota.Text = ""; //TODO preguntar de donde calcularla
                    textBoxCuotaMensualValorMinimaCuota.Text = fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroAhorroCuotaMinima).V_Valor;
                    textBoxCuotaMensualValorMaximaCuota.Text = fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroAhorroCuotaMaxima).V_Valor; ;

                    HabilitarBotonesConsulta();
                    HabilitarBotonesGuardar();
                }                
            }
            catch (BusinessException ex)
            {
                HabilitarBotonesConsulta();
                InhabilitarBotonesGuardar();
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                HabilitarBotonesConsulta();
                InhabilitarBotonesGuardar();
                Log.Registrar_Log(ex.Message, "FormOptAhorroCuotaMensual - BuscarInformacionUsuario", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Funcion que permite buscar limpiar del usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void LimpiarInformacionUsuario(object sender, EventArgs e)
        {
            InhabilitarBotonesConsulta();
            InhabilitarBotonesGuardar();
            LimpiarDatosUsuario();
            HabilitarBotonesConsulta();
        }

        /// <summary>
        /// Funcion para habilitar los botones de consulta del formulario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        public void HabilitarBotonesConsulta()
        {
            cuotaMensualBuscarPersona.Enabled = true;
            buttonCuotaMensualLimpiarPersona.Enabled = true;
        }

        /// <summary>
        /// Funcion para inhabilitar los botones de consulta del formulario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        public void InhabilitarBotonesConsulta()
        {
            cuotaMensualBuscarPersona.Enabled = false;
            buttonCuotaMensualLimpiarPersona.Enabled = false;
        }

        /// <summary>
        /// Funcion para habilitar los botones de guardar del formulario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        public void HabilitarBotonesGuardar()
        {
            textBoxCuotaMensualAhorroMensual.Enabled = true;
            buttonCuotaMensualGuardarCuota.Enabled = true;
        }

        /// <summary>
        /// Funcion para inhabilitar los botones de guardar del formulario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        public void InhabilitarBotonesGuardar()
        {
            textBoxCuotaMensualAhorroMensual.Enabled = false;
            buttonCuotaMensualGuardarCuota.Enabled = false;
        }

        /// <summary>
        /// Funcion para limpiar los datos del usuario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        public void LimpiarDatosUsuario()
        {
            textBoxCuotaMensualNombres.Text = "";
            textBoxCuotaMensualApellidos.Text = "";
            textBoxCuotaMensualFechaIngreso.Text = "";
            textBoxCuotaMensualValorProximaCuota.Text = "";
            textBoxCuotaMensualValorMinimaCuota.Text = "";
            textBoxCuotaMensualValorMaximaCuota.Text = "";
            comboBoxCuotaMensualTipoIdentificacion.SelectedIndex = 0;
            textBoxCuotaMensualNumeroIdentificacion.Text = "";
        }
    }
}
