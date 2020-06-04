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
    /// Clase para iniciar el formulario de Amortizacion de Credito
    /// Autor: Anderson Benavides
    /// 2020-04-19
    /// </summary> 
    public partial class FormOptAmortizacionCredito : MaterialForm
    {
        //Variable para guardar el usuario que inicio sesion
        FondoLoginEntity usuarioSesion;
        FondoSolicitudCreditoService fondoSolicitudCreditoService = new FondoSolicitudCreditoService();

        public FormOptAmortizacionCredito(FondoLoginEntity usuario)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Centrar panel
            panelAmortizacionCredito.Location = new Point(
            this.ClientSize.Width / 2 - panelAmortizacionCredito.Size.Width / 2,
            this.ClientSize.Height / 2 - panelAmortizacionCredito.Size.Height / 3);
            panelAmortizacionCredito.Anchor = AnchorStyles.None;

            //Cambiar Tema form
            General.InicializarTema(this);

            //Valores por defecto
            usuarioSesion = usuario;
            CargarCombobox();
        }

        /// <summary>
        /// Regresar al menú principal
        /// Autor: Anderson Benavides
        /// 2020-05-31
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
                comboBoxAmortizacionCreditoTipoIdentificacion.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTiposIdentificacion, false);
                comboBoxAmortizacionCreditoTipoIdentificacion.DisplayMember = "V_VALOR";
                comboBoxAmortizacionCreditoTipoIdentificacion.ValueMember = "V_CODIGO";
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
        /// Ejecuta la simulacion con los valores descritos
        /// Autor: Anderson Benavides
        /// 2020-06-04
        /// </summary>
        private void EjecutarSimulacion(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarInformacionSimulacion())
                {
                    General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjCamposObligatorios);
                    return;
                }
            }
            catch (BusinessException ex)
            {
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "FormOptAmortizacionCredito - EjecutarSimulacion", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Funcion para validar datos vacios
        /// Autor: Anderson Benavides
        /// 2020-06-04
        /// </summary>
        public bool ValidarInformacionSimulacion()
        {
            if (General.EsVacioNulo(textBoxAmortizacionCreditoNumeroIdentificacion.Text) || General.EsVacioNulo(textBoxAmortizacionCreditoNombres.Text) ||
               General.EsVacioNulo(textBoxAmortizacionCreditoMontoSolicitado.Text) || General.EsVacioNulo(textBoxAmortizacionCreditoPlazoMeses.Text) ||
               General.EsVacioNulo(textBoxAmortizacionCreditoTasaInteres.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Permite limpiar el formulario para una nueva consulta
        /// Autor: Anderson Benavides
        /// 2020-06-04
        /// </summary>
        private void LimpiarFormulario(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            comboBoxAmortizacionCreditoTipoIdentificacion.SelectedIndex = 0;
            textBoxAmortizacionCreditoNumeroIdentificacion.Text = "";
            textBoxAmortizacionCreditoNombres.Text = "";
            textBoxAmortizacionCreditoMontoSolicitado.Text = "";
            textBoxAmortizacionCreditoPlazoMeses.Text = "";
            textBoxAmortizacionCreditoTasaInteres.Text = "";
        }

        /// <summary>
        /// Consulta la informacion del usuario (Nombres)
        /// Autor: Anderson Benavides
        /// 2020-06-04
        /// </summary>
        private void ConsultarInformacionUsuario(object sender, EventArgs e)
        {
            try
            {
                if (General.EsVacioNulo(textBoxAmortizacionCreditoNumeroIdentificacion.Text))
                {
                    General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjIngresarNumeroIdentificacion);
                    return;
                }

                //Consulta nombre del asociado
                FondoUsuarioEntity fondoUsuarioConsulta = new FondoUsuarioEntity();
                FondoDominiosEntity tipoIdentificacion = (FondoDominiosEntity)comboBoxAmortizacionCreditoTipoIdentificacion.SelectedItem;
                fondoUsuarioConsulta.V_Tipo_Identificacion = tipoIdentificacion.V_Codigo;
                fondoUsuarioConsulta.V_Numero_Identificacion = Convert.ToInt64(textBoxAmortizacionCreditoNumeroIdentificacion.Text);
                textBoxAmortizacionCreditoNombres.Text = fondoSolicitudCreditoService.ConsultarNombreAsociado(fondoUsuarioConsulta);

                //Consulta valor credito activo solicitado
                FondoSolicitudCreditoEntity solicitudCredito = new FondoSolicitudCreditoEntity();
                solicitudCredito.N_Id_Usuario = Convert.ToInt64(textBoxAmortizacionCreditoNumeroIdentificacion.Text);
                textBoxAmortizacionCreditoMontoSolicitado.Text = fondoSolicitudCreditoService.ConsultarMontoCreditoAsociado(solicitudCredito);
            }
            catch (BusinessException ex)
            {
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "FormOptAmortizacionCredito - ConsultarInformacionUsuario", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }            
        }
    }
}
