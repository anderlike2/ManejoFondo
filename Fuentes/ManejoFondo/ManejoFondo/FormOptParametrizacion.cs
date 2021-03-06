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
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ManejoFondo
{
    /// <summary>
    /// Clase para iniciar el formulario de Parametrizacion
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary> 
    public partial class FormOptParametrizacion : MaterialForm
    {
        //Variable para guardar el usuario que inicio sesion
        FondoLoginEntity usuarioSesion;
        FondoParametrosService fondoParametrosService = new FondoParametrosService();

        public FormOptParametrizacion(FondoLoginEntity usuario)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Centrar panel
            panelParametrizacion.Location = new Point(
            this.ClientSize.Width / 2 - panelParametrizacion.Size.Width / 2,
            this.ClientSize.Height / 2 - panelParametrizacion.Size.Height / 3);
            panelParametrizacion.Anchor = AnchorStyles.None;

            //Cambiar Tema form
            General.InicializarTema(this);

            //Valores por defecto
            usuarioSesion = usuario;

            //Consultar los parametros del sistema
            dataGridParametrizacion.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridParametrizacion.DefaultCellStyle.Font = new Font("Arial", 10F);
            ConsultarParametrosSistema();
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
        /// Consultar Parametros del Sistema
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void ConsultarParametrosSistema()
        {
            try
            {
                List<FondoParametrosEntity> lstParametros = fondoParametrosService.ConsultarParametrosSistema();
                dataGridParametrizacion.DataSource = lstParametros;
            }
            catch (BusinessException ex)
            {
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "FormOptParametrizacion - ConsultarParametrosSistema", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Funcion para abrir la modal de editar Parametros
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void AbrirModalEditarParametro(object sender, EventArgs e)
        {
            try
            {
                FondoParametrosEntity parametroSeleccionado = (FondoParametrosEntity)dataGridParametrizacion.CurrentRow.DataBoundItem;
                FormModalEditarParametro formModalEditarParametro = new FormModalEditarParametro(parametroSeleccionado);
                formModalEditarParametro.ShowDialog();
                String resultado = formModalEditarParametro.jsonParametro;
                if (!General.EsVacioNulo(resultado))
                {
                    FondoParametrosEntity parametroModificado = new JavaScriptSerializer().Deserialize<FondoParametrosEntity>(resultado);
                    fondoParametrosService.ActualizarInformacionParametro(parametroModificado);

                    General.MostrarPanelError(Constantes.CodigoExito, Constantes.MsjExitoGuardar);

                    //Se refresca la consulta
                    ConsultarParametrosSistema();
                }               
            }
            catch (BusinessException ex)
            {
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "FormOptParametrizacion - AbrirModalEditarParametro", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }
    }
}
