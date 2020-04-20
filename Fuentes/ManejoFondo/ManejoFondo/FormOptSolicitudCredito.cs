﻿using ManejoFondo.Common;
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
                LimpiarCamposCredito();
                if (General.EsVacioNulo(textBoxSolicitudCreditoNumeroIdentificacion.Text))
                {
                    General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjCamposObligatorios);
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
        private void LimpiarCamposCredito()
        {
            textBoxSolicitudCreditoNombres.Text = "";
            textBoxSolicitudCreditoValorAportes.Text = "";
            textBoxSolicitudCreditoValorSolicitado.Text = "";
        }
    }
}
