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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoFondo
{
    /// <summary>
    /// Clase para iniciar el formulario de Solicitud de Credito
    /// Autor: Anderson Benavides
    /// 2020-04-19
    /// </summary> 
    public partial class FormOptSolicitudCredito : MaterialForm
    {
        //Variable para guardar el usuario que inicio sesion
        FondoLoginEntity usuarioSesion;
        FondoSolicitudCreditoService fondoSolicitudCreditoService = new FondoSolicitudCreditoService();
        FondoParametrosService fondoParametrosService = new FondoParametrosService();

        public FormOptSolicitudCredito(FondoLoginEntity usuario)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Centrar panel
            panelSolicitudCredito.Location = new Point(
            this.ClientSize.Width / 2 - panelSolicitudCredito.Size.Width / 2,
            this.ClientSize.Height / 2 - panelSolicitudCredito.Size.Height / 3);
            panelSolicitudCredito.Anchor = AnchorStyles.None;

            //Cambiar Tema form
            General.InicializarTema(this);

            //Valores por defecto
            usuarioSesion = usuario;
            CargarCombobox();
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
        /// Cargar los valores de los combobox principales
        /// Autor: Anderson Benavides
        /// 2020-04-19
        /// </summary>
        private void CargarCombobox()
        {
            try
            {
                FondoDominiosService fondoDominioService = new FondoDominiosService();

                //Para Datos Persona
                comboBoxSolicitudCreditoTipoIdentificacion.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTiposIdentificacion, false);
                comboBoxSolicitudCreditoTipoIdentificacion.DisplayMember = "V_VALOR";
                comboBoxSolicitudCreditoTipoIdentificacion.ValueMember = "V_CODIGO";

                //Para tipo de Actividad
                comboBoxSolicitudCreditoTipoActividad.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTipoActividad, false); ;
                comboBoxSolicitudCreditoTipoActividad.DisplayMember = "V_VALOR";
                comboBoxSolicitudCreditoTipoActividad.ValueMember = "V_CODIGO";

                //Para tipo de Actividad Otros Ingresos
                comboBoxSolicitudCreditoTipoActividadOtrosIngresos.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTipoActividad, false); ;
                comboBoxSolicitudCreditoTipoActividadOtrosIngresos.DisplayMember = "V_VALOR";
                comboBoxSolicitudCreditoTipoActividadOtrosIngresos.ValueMember = "V_CODIGO";
            }
            catch (BusinessException ex)
            {
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "FormOptSolicitudCredito - CargarCombobox", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Consulta la informacion del usuario (Ahorro y nombres)
        /// Autor: Anderson Benavides
        /// 2020-04-19
        /// </summary>
        private void ConsultarInformacionUsuario(object sender, EventArgs e)
        {
            try
            {
                textBoxSolicitudCreditoNombres.Text = "";
                textBoxSolicitudCreditoValorAportes.Text = "";
                if (General.EsVacioNulo(textBoxSolicitudCreditoNumeroIdentificacion.Text))
                {
                    General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjIngresarNumeroIdentificacion);
                    return;
                }

                //Consulta nombre del asociado
                FondoUsuarioEntity fondoUsuarioConsulta = new FondoUsuarioEntity();
                FondoDominiosEntity tipoIdentificacion = (FondoDominiosEntity)comboBoxSolicitudCreditoTipoIdentificacion.SelectedItem;                
                fondoUsuarioConsulta.V_Tipo_Identificacion = tipoIdentificacion.V_Codigo;
                fondoUsuarioConsulta.V_Numero_Identificacion = Convert.ToInt64(textBoxSolicitudCreditoNumeroIdentificacion.Text);
                textBoxSolicitudCreditoNombres.Text = fondoSolicitudCreditoService.ConsultarNombreAsociado(fondoUsuarioConsulta);

                //Consulta ahorro del asociado
                FondoAhorroMensualEntity fondoAhorroMensualEntity = new FondoAhorroMensualEntity();
                fondoAhorroMensualEntity.N_Id_Usuario = Convert.ToInt64(textBoxSolicitudCreditoNumeroIdentificacion.Text);
                textBoxSolicitudCreditoValorAportes.Text = fondoSolicitudCreditoService.ConsultarAhorroAsociado(fondoAhorroMensualEntity);
            }
            catch (BusinessException ex)
            {
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "FormOptSolicitudCredito - ConsultarInformacionUsuario", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Limpiar los datos precargados
        /// Autor: Anderson Benavides
        /// 2020-04-19
        /// </summary>
        private void LimpiarCampos(object sender, EventArgs e)
        {
            EjecutarLimpiarFormulario();
        }

        /// <summary>
        /// Funcion para limpiar todos los datos del formulario
        /// Autor: Anderson Benavides
        /// 2020-04-19
        /// </summary>
        private void EjecutarLimpiarFormulario()
        {
            comboBoxSolicitudCreditoTipoIdentificacion.SelectedIndex = 0;
            textBoxSolicitudCreditoNumeroIdentificacion.Text = "";
            textBoxSolicitudCreditoNombres.Text = "";
            textBoxSolicitudCreditoValorAportes.Text = "";
            textBoxSolicitudCreditoValorSolicitado.Text = "";
            comboBoxSolicitudCreditoTipoActividad.SelectedIndex = 0;
            textBoxSolicitudCreditoCual.Text = "";
            textBoxSolicitudCreditoValor.Text = "";
            textBoxSolicitudCreditoCadaCuanto.Text = "";
            comboBoxSolicitudCreditoTipoActividadOtrosIngresos.SelectedIndex = 0;
            textBoxSolicitudCreditoCualOtrosIngresos.Text = "";
            textBoxSolicitudCreditoValorOtrosIngresos.Text = "";
            textBoxSolicitudCreditoCadaCuantoOtrosIngresos.Text = "";
            textBoxSolicitudCreditoGastosFamiliares.Text = "";
            textBoxSolicitudCreditoGastosProduccion.Text = "";
            textBoxSolicitudCreditoCuotasEntidadesFinancieras.Text = "";
            textBoxSolicitudCreditoCuotasParticulares.Text = "";
            textBoxSolicitudCreditoTotalDisponible.Text = "";
            textBoxSolicitudCreditoCapacidadPago.Text = "";
            textBoxSolicitudCreditoTotalIngresos.Text = "";
            textBoxSolicitudCreditoTotalEgresos.Text = "";
        }

        /// <summary>
        /// Solicitar Credito
        /// Autor: Anderson Benavides
        /// 2020-04-19
        /// </summary>
        private void SolicitarCredito(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarInformacionSolicitudCredito())
                {
                    General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjCamposObligatorios);
                    return;
                }

                //Se procede a almacenar la informacion en base de datos
                FondoSolicitudCreditoEntity fondoSolicitudCreditoEntity = new FondoSolicitudCreditoEntity();
                FondoDominiosEntity solicitudCreditoTipoIdentificacion = (FondoDominiosEntity)comboBoxSolicitudCreditoTipoIdentificacion.SelectedItem;
                FondoDominiosEntity solicitudCreditoTipoActividad = (FondoDominiosEntity)comboBoxSolicitudCreditoTipoActividad.SelectedItem;
                FondoDominiosEntity solicitudCreditoTipoActividadOtro = (FondoDominiosEntity)comboBoxSolicitudCreditoTipoActividadOtrosIngresos.SelectedItem;

                fondoSolicitudCreditoEntity.V_Tipo_Identificacion = solicitudCreditoTipoIdentificacion.V_Codigo;
                fondoSolicitudCreditoEntity.N_Id_Usuario = Convert.ToInt64(textBoxSolicitudCreditoNumeroIdentificacion.Text);
                fondoSolicitudCreditoEntity.D_Fecha_Solicitud = DateTime.Now;
                fondoSolicitudCreditoEntity.V_Estado = "A"; //Estado Activo

                fondoSolicitudCreditoEntity.N_Valor_Solicitado = Convert.ToInt64(textBoxSolicitudCreditoValorSolicitado.Text);

                fondoSolicitudCreditoEntity.V_Ing_Tipo_Actividad = solicitudCreditoTipoActividad.V_Codigo;
                fondoSolicitudCreditoEntity.V_Ing_Cual = textBoxSolicitudCreditoCual.Text;
                fondoSolicitudCreditoEntity.N_Ing_Valor = Convert.ToInt64(textBoxSolicitudCreditoValor.Text);
                fondoSolicitudCreditoEntity.N_Ing_Cada_Cuanto = Convert.ToInt64(textBoxSolicitudCreditoCadaCuanto.Text);

                //Como hacer para inactivar esta parte y no almacenarla
                fondoSolicitudCreditoEntity.V_Ot_Ing_Tipo_Actividad = solicitudCreditoTipoActividadOtro.V_Codigo;
                fondoSolicitudCreditoEntity.V_Ot_Ing_Cual = textBoxSolicitudCreditoCualOtrosIngresos.Text;
                fondoSolicitudCreditoEntity.N_Ot_Ing_Valor = Convert.ToInt64(textBoxSolicitudCreditoValorOtrosIngresos.Text);
                fondoSolicitudCreditoEntity.N_Ot_Ing_Cada_Cuanto = Convert.ToInt64(textBoxSolicitudCreditoCadaCuantoOtrosIngresos.Text);

                fondoSolicitudCreditoEntity.N_Egr_Gastos_Fam = Convert.ToInt64(textBoxSolicitudCreditoGastosFamiliares.Text);
                fondoSolicitudCreditoEntity.N_Egr_Gastos_Prod = Convert.ToInt64(textBoxSolicitudCreditoGastosProduccion.Text);
                fondoSolicitudCreditoEntity.N_Egr_Cuotas_Financ = Convert.ToInt64(textBoxSolicitudCreditoCuotasEntidadesFinancieras.Text);
                fondoSolicitudCreditoEntity.N_Egr_Cuotas_Partic = Convert.ToInt64(textBoxSolicitudCreditoCuotasParticulares.Text);

                fondoSolicitudCreditoEntity.N_Total_Disponible = Convert.ToInt64(textBoxSolicitudCreditoTotalDisponible.Text);
                fondoSolicitudCreditoEntity.N_Capacidad_Pago = Convert.ToInt64(textBoxSolicitudCreditoCapacidadPago.Text);
                fondoSolicitudCreditoEntity.N_Total_Ingresos = Convert.ToInt64(textBoxSolicitudCreditoTotalIngresos.Text);
                fondoSolicitudCreditoEntity.N_Total_Egresos = Convert.ToInt64(textBoxSolicitudCreditoTotalEgresos.Text);

                fondoSolicitudCreditoService.InsertarSolicitudCredito(fondoSolicitudCreditoEntity);
                General.MostrarPanelError(Constantes.CodigoExito, Constantes.MsjExitoSolicitudCredito);
                EjecutarLimpiarFormulario();
            }
            catch (BusinessException ex)
            {
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "FormOptSolicitudCredito - SolicitarCredito", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }

        }

        /// <summary>
        /// Funcion para validar los campos de la solicitud de Credito
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private bool ValidarInformacionSolicitudCredito()
        {
            if(General.EsVacioNulo(textBoxSolicitudCreditoNumeroIdentificacion.Text) || General.EsVacioNulo(textBoxSolicitudCreditoNombres.Text) ||
               General.EsVacioNulo(textBoxSolicitudCreditoValorAportes.Text) || General.EsVacioNulo(textBoxSolicitudCreditoValorSolicitado.Text) ||
               General.EsVacioNulo(textBoxSolicitudCreditoCual.Text) || General.EsVacioNulo(textBoxSolicitudCreditoValor.Text) ||
               General.EsVacioNulo(textBoxSolicitudCreditoCadaCuanto.Text) || General.EsVacioNulo(textBoxSolicitudCreditoGastosFamiliares.Text) ||
               General.EsVacioNulo(textBoxSolicitudCreditoGastosProduccion.Text) || General.EsVacioNulo(textBoxSolicitudCreditoTotalDisponible.Text) ||
               General.EsVacioNulo(textBoxSolicitudCreditoCapacidadPago.Text) || General.EsVacioNulo(textBoxSolicitudCreditoTotalIngresos.Text) ||
               General.EsVacioNulo(textBoxSolicitudCreditoTotalEgresos.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Funcion para calcular el total de ingressos
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void CalcularTotalIngresos(object sender, EventArgs e)
        {
            double valor = 0, valorOtro = 0, valorCuanto = 1, valorCuantoOtro = 1;
            if (!General.EsVacioNulo(textBoxSolicitudCreditoValor.Text))
            {
                if (!General.EsVacioNulo(textBoxSolicitudCreditoCadaCuanto.Text))
                {
                    valorCuanto = Convert.ToDouble(textBoxSolicitudCreditoCadaCuanto.Text);
                    valor = Convert.ToDouble(textBoxSolicitudCreditoValor.Text) / valorCuanto;
                }
                else
                {
                    valor = Convert.ToDouble(textBoxSolicitudCreditoValor.Text);
                }                    
            }
            if (!General.EsVacioNulo(textBoxSolicitudCreditoValorOtrosIngresos.Text))
            {
                if (!General.EsVacioNulo(textBoxSolicitudCreditoCadaCuantoOtrosIngresos.Text))
                {
                    valorCuantoOtro = Convert.ToDouble(textBoxSolicitudCreditoCadaCuantoOtrosIngresos.Text);
                    valorOtro = Convert.ToDouble(textBoxSolicitudCreditoValorOtrosIngresos.Text) / valorCuantoOtro;
                }
                else
                {
                    valorOtro = Convert.ToDouble(textBoxSolicitudCreditoValorOtrosIngresos.Text);
                }
            }
            textBoxSolicitudCreditoTotalIngresos.Text = (valor + valorOtro).ToString();
            CalcularDatosFinales();
        }

        /// <summary>
        /// Funcion para calcular el total de egresos
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void CalcularTotalEgresos(object sender, EventArgs e)
        {
            double valorGastosFam = 0, valorGastosProd = 0, valorCuotasFin = 0, valorCuotasPar = 0;
            if (!General.EsVacioNulo(textBoxSolicitudCreditoGastosFamiliares.Text))
            {
                valorGastosFam = Convert.ToDouble(textBoxSolicitudCreditoGastosFamiliares.Text);
            }
            if (!General.EsVacioNulo(textBoxSolicitudCreditoGastosProduccion.Text))
            {
                valorGastosProd = Convert.ToDouble(textBoxSolicitudCreditoGastosProduccion.Text);
            }
            if (!General.EsVacioNulo(textBoxSolicitudCreditoCuotasEntidadesFinancieras.Text))
            {
                valorCuotasFin = Convert.ToDouble(textBoxSolicitudCreditoCuotasEntidadesFinancieras.Text);
            }
            if (!General.EsVacioNulo(textBoxSolicitudCreditoCuotasParticulares.Text))
            {
                valorCuotasPar = Convert.ToDouble(textBoxSolicitudCreditoCuotasParticulares.Text);
            }
            textBoxSolicitudCreditoTotalEgresos.Text = (valorGastosFam + valorGastosProd + valorCuotasFin + valorCuotasPar).ToString();
            CalcularDatosFinales();
        }

        /// <summary>
        /// Funcion para calcular los valores de Total Disponible y Capacidad de Pago
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void CalcularDatosFinales()
        {
            //Para Total Disponible
            double valorIngresos = 0, valorEgresos = 0, porcentajeCapacidadPago = 0;
            if (!General.EsVacioNulo(textBoxSolicitudCreditoTotalIngresos.Text))
            {
                valorIngresos = Convert.ToDouble(textBoxSolicitudCreditoTotalIngresos.Text);
            }
            if (!General.EsVacioNulo(textBoxSolicitudCreditoTotalEgresos.Text))
            {
                valorEgresos = Convert.ToDouble(textBoxSolicitudCreditoTotalEgresos.Text);
            }
            textBoxSolicitudCreditoTotalDisponible.Text = (valorIngresos - valorEgresos).ToString();

            //Para Capacidad de Pago     
            porcentajeCapacidadPago = Convert.ToDouble(fondoParametrosService.ConsultarParametroPorNombre(Constantes.ParametroPorcentajeCapacidadPago).V_Valor) / 100;
            textBoxSolicitudCreditoCapacidadPago.Text = (Convert.ToDouble(textBoxSolicitudCreditoTotalDisponible.Text) * porcentajeCapacidadPago).ToString();
        }
    }
}
