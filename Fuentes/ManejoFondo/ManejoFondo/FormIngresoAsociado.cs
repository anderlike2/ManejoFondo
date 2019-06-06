﻿using ManejoFondo.Common;
using ManejoFondo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
using ManejoFondo.Services;
using ManejoFondo.Loggers;
using ManejoFondo.Modelos;
using System.Web.Script.Serialization;

namespace ManejoFondo
{
    /// <summary>
    /// Clase para iniciar el formulario de Ingreso de Asociados
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>  
    public partial class FormIngresoAsociado : MaterialForm
    {
        //Variable para guardar el usuario que inicio sesion
        FondoLoginEntity usuarioSesion;

        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();

        public FormIngresoAsociado(FondoLoginEntity usuario)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Cambiar Tema form
            General.InicializarTema(this);

            //Width del tabControl
            tabIngresarAsociado.ItemSize = new Size(tabIngresarAsociado.Width / tabIngresarAsociado.TabCount, 0);

            //Ajustar height
            var bounds = Screen.FromControl(this).Bounds;
            this.Height = bounds.Height - 100;

            //Valores por defecto
            InicializarTooltips();
            usuarioSesion = usuario;
            CargarCombobox();

            //Inicializar fechas
            datePickerDatosPersonaFechaNacimiento.Value = DateTime.Now;
            datePickerNucleoFamiliarConyugeFechaNacimiento.Value = DateTime.Now;            
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
            toolTip.SetToolTip(ingresoAsociadoAceptar, Constantes.MsjAceptar);
            toolTip.SetToolTip(ingresoAsociadoCancelar, Constantes.MsjCancelar);
            toolTip.SetToolTip(panelIngresoAsociadoRegresar, Constantes.MsjRegresar);

            dataGridNucleoFamiliarIntegrantes.EnableHeadersVisualStyles = false;
        }

        /// <summary>
        /// Regresar al menú principal
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void RegresarMenuPrincipal(object sender, EventArgs e)
        {
            //Se inicia el formulario de opciones
            FormOpciones formOpciones = new FormOpciones(usuarioSesion);
            Hide();
            formOpciones.ShowDialog();
            Close();
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
                comboBoxDatosPersonaTipoIdentificacion.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTiposIdentificacion, false); ;
                comboBoxDatosPersonaTipoIdentificacion.DisplayMember = "V_VALOR";
                comboBoxDatosPersonaTipoIdentificacion.ValueMember = "V_CODIGO";
                comboBoxDatosPersonaPais.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioPais, true); ;
                comboBoxDatosPersonaPais.DisplayMember = "V_VALOR";
                comboBoxDatosPersonaPais.ValueMember = "V_CODIGO";          
                comboBoxDatosPersonaNivelEstudio.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioNivelEstudio, false); ;
                comboBoxDatosPersonaNivelEstudio.DisplayMember = "V_VALOR";
                comboBoxDatosPersonaNivelEstudio.ValueMember = "V_CODIGO";
                comboBoxDatosPersonaEstadoCivil.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioEstadoCivil, false); ;
                comboBoxDatosPersonaEstadoCivil.DisplayMember = "V_VALOR";
                comboBoxDatosPersonaEstadoCivil.ValueMember = "V_CODIGO";

                //Para Ayuda Gobierno
                comboBoxAyudaGobiernoTipoVictima.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTipoVictima, false); ;
                comboBoxAyudaGobiernoTipoVictima.DisplayMember = "V_VALOR";
                comboBoxAyudaGobiernoTipoVictima.ValueMember = "V_CODIGO";
                comboBoxAyudaGobiernoRecibeSubsidio.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioOpcionesSiyNo, false); ;
                comboBoxAyudaGobiernoRecibeSubsidio.DisplayMember = "V_VALOR";
                comboBoxAyudaGobiernoRecibeSubsidio.ValueMember = "V_CODIGO";
                comboBoxAyudaGobiernoTipoSubsidio.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTipoSubsidio, false); ;
                comboBoxAyudaGobiernoTipoSubsidio.DisplayMember = "V_VALOR";
                comboBoxAyudaGobiernoTipoSubsidio.ValueMember = "V_CODIGO";

                //Informacion Familiar
                comboBoxNucleoFamiliarConyuge.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioOpcionesSiyNo, false); ;
                comboBoxNucleoFamiliarConyuge.DisplayMember = "V_VALOR";
                comboBoxNucleoFamiliarConyuge.ValueMember = "V_CODIGO";
                comboBoxNucleoFamiliarConyugeTipoIdentificacion.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTiposIdentificacion, false); ;
                comboBoxNucleoFamiliarConyugeTipoIdentificacion.DisplayMember = "V_VALOR";
                comboBoxNucleoFamiliarConyugeTipoIdentificacion.ValueMember = "V_CODIGO";
                comboBoxNucleoFamiliarConyugeTipoActividad.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTipoActividad, false); ;
                comboBoxNucleoFamiliarConyugeTipoActividad.DisplayMember = "V_VALOR";
                comboBoxNucleoFamiliarConyugeTipoActividad.ValueMember = "V_CODIGO";

                //Ingresos
                comboBoxIngresosActividadEconomica.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTipoActividad, false); ;
                comboBoxIngresosActividadEconomica.DisplayMember = "V_VALOR";
                comboBoxIngresosActividadEconomica.ValueMember = "V_CODIGO";

            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "CargarCombobox - IngresoAsociado", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }            
        }

        /// <summary>
        /// Cargar Municipios
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void CargarDepartamentos(object sender, EventArgs e)
        {
            FondoDominiosService fondoDominioService = new FondoDominiosService();
            try
            {
                ComboBox comboBox = (ComboBox)sender;
                FondoDominiosEntity seleccionado = (FondoDominiosEntity)comboBox.SelectedItem;
                comboBoxDatosPersonaDepartamento.DataSource = null;
                comboBoxDatosPersonaDepartamento.DataSource = fondoDominioService.ConsultarDominiosPorPadre(seleccionado.V_Codigo, false);
                comboBoxDatosPersonaDepartamento.DisplayMember = "V_VALOR";
                comboBoxDatosPersonaDepartamento.ValueMember = "V_CODIGO";
            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "CargarMunicpios - IngresoAsociado", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Cargar Municipios
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void CargarMunicipios(object sender, EventArgs e)
        {
            FondoDominiosService fondoDominioService = new FondoDominiosService();
            try
            {
                ComboBox comboBox = (ComboBox)sender;
                FondoDominiosEntity seleccionado = (FondoDominiosEntity)comboBox.SelectedItem;
                comboBoxDatosPersonaMunicipio.DataSource = null;
                comboBoxDatosPersonaMunicipio.DataSource = fondoDominioService.ConsultarDominiosPorPadre(seleccionado.V_Codigo, false);
                comboBoxDatosPersonaMunicipio.DisplayMember = "V_VALOR";
                comboBoxDatosPersonaMunicipio.ValueMember = "V_CODIGO";
            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "CargarMunicpios - IngresoAsociado", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }           
        }

        /// <summary>
        /// Funcion para Agregar persona al nucleo familiar
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void AgregarPersona(object sender, EventArgs e)
        {
            FormAgregarNucleoFamiliar formNucleoFamiliar = new FormAgregarNucleoFamiliar();
            formNucleoFamiliar.ShowDialog();
            String resultado = formNucleoFamiliar.jsonUsuario;
            if (!General.EsVacioNulo(resultado))
            {
                UsuarioModel desUsuario = new JavaScriptSerializer().Deserialize<UsuarioModel>(resultado);
                BindingSource bs = (BindingSource)this.dataGridNucleoFamiliarIntegrantes.DataSource;
                bs.Add(desUsuario);
            }
            
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
        /// Funcion para validar los campos de los datos persona
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private bool ValidarInformacionPersona()
        {
            if(General.EsVacioNulo(textBoxDatosPersonaNombres.Text) || General.EsVacioNulo(textBoxDatosPersonasApellidos.Text) ||
               General.EsVacioNulo(comboBoxDatosPersonaTipoIdentificacion.Text) || General.EsVacioNulo(textBoxDatosPersonaNumeroIdentificacion.Text) ||
               General.EsVacioNulo(comboBoxDatosPersonaPais.Text) || General.EsVacioNulo(comboBoxDatosPersonaDepartamento.Text) ||
               General.EsVacioNulo(comboBoxDatosPersonaMunicipio.Text) || General.EsVacioNulo(comboBoxDatosPersonaNivelEstudio.Text) ||
               General.EsVacioNulo(textBoxDatosPersonaTelefono.Text) || General.EsVacioNulo(comboBoxDatosPersonaEstadoCivil.Text) ||
               General.EsVacioNulo(datePickerDatosPersonaFechaNacimiento.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Funcion para validar los campos de los datos ayuda gobierno
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private bool ValidarInformacionAyudaGobierno()
        {
            if (General.EsVacioNulo(textBoxAyudaGobiernoPuntajeSisben.Text) || General.EsVacioNulo(comboBoxAyudaGobiernoTipoVictima.Text) ||
               General.EsVacioNulo(comboBoxAyudaGobiernoRecibeSubsidio.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Funcion para validar los campos de los datos nucleo familiar
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private bool ValidarInformacionNucleoFamiliar()
        {
            FondoDominiosEntity itemSeleccionado = (FondoDominiosEntity)comboBoxNucleoFamiliarConyuge.SelectedItem;
            if (itemSeleccionado.V_Valor.ToUpper().Equals(Constantes.DescripcionSi.ToUpper()))
            {
                if (General.EsVacioNulo(textBoxNucleoFamiliarConyugeNombres.Text) || General.EsVacioNulo(textBoxNucleoFamiliarConyugeApellidos.Text) ||
                    General.EsVacioNulo(comboBoxNucleoFamiliarConyugeTipoIdentificacion.Text) || General.EsVacioNulo(textBoxNucleoFamiliarConyugeNumeroIdentificacion.Text) ||
                    General.EsVacioNulo(textBoxNucleoFamiliarConyugeNumeroTelefono.Text) || General.EsVacioNulo(datePickerNucleoFamiliarConyugeFechaNacimiento.Text) ||
                    General.EsVacioNulo(comboBoxNucleoFamiliarConyugeTipoActividad.Text))
                {
                    return false;
                }
                else
                {
                    FondoDominiosEntity itemTipoActividad = (FondoDominiosEntity)comboBoxNucleoFamiliarConyugeTipoActividad.SelectedItem;
                    if (itemTipoActividad.V_Valor.ToUpper().Equals(Constantes.DescripcionOtro.ToUpper()) && General.EsVacioNulo(textBoxNucleoFamiliarConyugeOtraActividad.Text))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Funcion para validar los campos de los datos de Ingresos
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private bool ValidarInformacionIngresos()
        {
            if (General.EsVacioNulo(comboBoxIngresosActividadEconomica.Text) || General.EsVacioNulo(textBoxIngresosIngresosMensuales.Text) ||
                General.EsVacioNulo(textBoxIngresosTipoAnimales.Text) || General.EsVacioNulo(textBoxIngresosTipoAnimales.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Funcion para validar toda la informacion de los Tabs
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void ValidarInformacion(object sender, EventArgs e)
        {
            //Para Ayuda Gobierno
            switch (tabIngresarAsociado.SelectedIndex)
            {
                /*case 0:
                    break;
                case 1:
                    if (!ValidarInformacionPersona())
                    {
                        tabIngresarAsociado.SelectedIndex = 0;
                        General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjCamposObligatorios);
                    }
                    break;
                case 2:
                    if (!ValidarInformacionPersona() || !ValidarInformacionAyudaGobierno())
                    {
                        tabIngresarAsociado.SelectedIndex = 1;
                        General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjCamposObligatorios);
                    }
                    break;
                case 3:
                    if (!ValidarInformacionPersona() || !ValidarInformacionAyudaGobierno() || !ValidarInformacionNucleoFamiliar())
                    {
                        tabIngresarAsociado.SelectedIndex = 2;
                        General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjCamposObligatorios);
                    }
                    break;*/
            }
        }


        /// <summary>
        /// Funcion para ocultar los paneles de nucleo familiar
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void ValidarPaneles(object sender, EventArgs e)
        {
            FondoDominiosEntity itemSeleccionado = (FondoDominiosEntity)comboBoxNucleoFamiliarConyuge.SelectedItem;
            if (itemSeleccionado.V_Valor.ToUpper().Equals(Constantes.DescripcionSi.ToUpper()))
            {
                panelNucleoFamiliarConyuge.Visible = true;
                panelNucleoFamiliarOtrosFamiliares.Location = new Point(7, 391);
            }
            else
            {
                panelNucleoFamiliarConyuge.Visible = false;
                panelNucleoFamiliarOtrosFamiliares.Location = new Point(7, 167);
            }
        }

        /// <summary>
        /// Funcion para ocultar o mostrar la informacion "Cual otro" de Actividad
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void ValidarTipoActividadConyuge(object sender, EventArgs e)
        {
            FondoDominiosEntity itemSeleccionado = (FondoDominiosEntity)comboBoxNucleoFamiliarConyugeTipoActividad.SelectedItem;
            if (itemSeleccionado.V_Valor.ToUpper().Equals(Constantes.DescripcionOtro.ToUpper()))
            {
                labelNucleoFamiliarConyugeOtraActividad.Visible = true;
                textBoxNucleoFamiliarConyugeOtraActividad.Visible = true;
                labelObligatorioCualTipoActividadConyuge.Visible = true;
            }
            else
            {
                labelNucleoFamiliarConyugeOtraActividad.Visible = false;
                textBoxNucleoFamiliarConyugeOtraActividad.Visible = false;
                labelObligatorioCualTipoActividadConyuge.Visible = false;
            }
        }

        /// <summary>
        /// Aceptar Ingresar Asociado
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void AceptarIngresarAsociado(object sender, EventArgs e)
        {

        }

       
    }
}
