using ManejoFondo.Common;
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
    public partial class FormOptIngresoAsociado : MaterialForm
    {
        //Variable para guardar el usuario que inicio sesion
        FondoLoginEntity usuarioSesion;
        FondoUsuarioService fondoUsuarioService = new FondoUsuarioService();
        FondoProcUsuarioService fondoProcUsuarioService = new FondoProcUsuarioService();
        FondoAyudaGobUsuarioService fondoAyudaGobUsuarioService = new FondoAyudaGobUsuarioService();
        FondoFamiliaUsuarioService fondoFamiliaUsuarioService = new FondoFamiliaUsuarioService();
        FondoIngresosUsuarioService fondoIngresosUsuarioService = new FondoIngresosUsuarioService();

        public FormOptIngresoAsociado(FondoLoginEntity usuario)
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
            tabIngresarAsociado.Left = (this.ClientSize.Width - tabIngresarAsociado.Width) / 2;
            tabIngresarAsociado.Top = (this.ClientSize.Height - tabIngresarAsociado.Height) / 2;

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
            toolTip.SetToolTip(panelRegresarMenu, Constantes.MsjRegresar);

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
            FormMenu formOpciones = new FormMenu(usuarioSesion);
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
            FormModalAgregarNucleoFamiliar formNucleoFamiliar = new FormModalAgregarNucleoFamiliar();
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
            else
            {
                FondoDominiosEntity itemSeleccionado = (FondoDominiosEntity)comboBoxAyudaGobiernoRecibeSubsidio.SelectedItem;
                if (itemSeleccionado.V_Valor.ToUpper().Equals(Constantes.DescripcionSi.ToUpper()))
                {
                    if (General.EsVacioNulo(comboBoxAyudaGobiernoRecibeSubsidio.Text))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
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
            if (General.EsVacioNulo(comboBoxIngresosActividadEconomica.Text) || General.EsVacioNulo(textBoxIngresosIngresosMensuales.Text))
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
            try
            {
                //Para Ayuda Gobierno
                switch (tabIngresarAsociado.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        if (!ValidarInformacionPersona())
                        {
                            tabIngresarAsociado.SelectedIndex = 0;
                            General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjCamposObligatorios);
                        }
                        else
                        {
                            //Se valida la existencia del usuario
                            FondoDominiosEntity datosPersonaTipoIdentificacion = (FondoDominiosEntity)comboBoxDatosPersonaTipoIdentificacion.SelectedItem;
                            FondoUsuarioEntity usuarioValidar = new FondoUsuarioEntity();
                            usuarioValidar.V_Tipo_Identificacion = datosPersonaTipoIdentificacion.V_Codigo;
                            usuarioValidar.V_Numero_Identificacion = Convert.ToInt64(textBoxDatosPersonaNumeroIdentificacion.Text);
                            FondoUsuarioEntity resultado = fondoUsuarioService.ValidarUsuario(usuarioValidar);
                            if(resultado != null)
                            {
                                tabIngresarAsociado.SelectedIndex = 0;
                                General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjUsuarioExiste);
                            }
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
                        break;
                }
            }
            catch (BusinessException ex)
            {
                ingresoAsociadoAceptar.Enabled = true;
                ingresoAsociadoCancelar.Enabled = true;
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                ingresoAsociadoAceptar.Enabled = true;
                ingresoAsociadoCancelar.Enabled = true;
                Log.Registrar_Log(ex.Message, "FormIngresoAsociado - ValidarInformacion", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
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
                panelNucleoFamiliarOtrosFamiliares.Location = new Point(7, 415);
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
        /// Validar el tipo de subsidio
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void ValidarTipoSubsidio(object sender, EventArgs e)
        {
            FondoDominiosEntity itemSeleccionado = (FondoDominiosEntity)comboBoxAyudaGobiernoRecibeSubsidio.SelectedItem;
            if (itemSeleccionado.V_Valor.ToUpper().Equals(Constantes.DescripcionSi.ToUpper()))
            {
                comboBoxAyudaGobiernoTipoSubsidio.Visible = true;
                labelAyudaGobiernoTipoSubsidio.Visible = true;
                comboBoxAyudaGobiernoTipoSubsidio.SelectedIndex = 0;
            }
            else
            {
                comboBoxAyudaGobiernoTipoSubsidio.Visible = false;
                labelAyudaGobiernoTipoSubsidio.Visible = false;
            }
        }

        /// <summary>
        /// Cancelar Ingresar Asociado
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void ValidarActividadEconomica(object sender, EventArgs e)
        {
            FondoDominiosEntity itemSeleccionado = (FondoDominiosEntity)comboBoxIngresosActividadEconomica.SelectedItem;
            if (itemSeleccionado.V_Valor.ToUpper().Equals(Constantes.DescripcionAgricultura.ToUpper()))
            {
                labelIngresosTipoAnimales.Visible = false;
                textBoxIngresosTipoAnimales.Visible = false;
                labelIngresosTipoCultivo.Visible = true;
                textBoxIngresosTipoCultivo.Visible = true;

                labelIngresosTipoCultivo.Location = new Point(99, 146);
                textBoxIngresosTipoCultivo.Location = new Point(103, 171);
            }
            else if (itemSeleccionado.V_Valor.ToUpper().Equals(Constantes.DescripcionPecuario.ToUpper()))
            {
                labelIngresosTipoAnimales.Visible = true;
                textBoxIngresosTipoAnimales.Visible = true;
                labelIngresosTipoCultivo.Visible = false;
                textBoxIngresosTipoCultivo.Visible = false;

                labelIngresosTipoAnimales.Location = new Point(99, 146);
                textBoxIngresosTipoAnimales.Location = new Point(103, 171);
            }
            else
            {
                labelIngresosTipoAnimales.Visible = false;
                textBoxIngresosTipoAnimales.Visible = false;
                labelIngresosTipoCultivo.Visible = false;
                textBoxIngresosTipoCultivo.Visible = false;
            }
        }

        /// <summary>
        /// Limpiar datos formulario
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void LimpiarDatosFormulario()
        {
            //Limpiar datos persona
            textBoxDatosPersonaNombres.Text = "";
            textBoxDatosPersonasApellidos.Text = "";
            comboBoxDatosPersonaTipoIdentificacion.SelectedIndex = 0;
            textBoxDatosPersonaNumeroIdentificacion.Text = "";
            comboBoxDatosPersonaPais.SelectedIndex = 0;
            comboBoxDatosPersonaDepartamento.SelectedIndex = 0;
            comboBoxDatosPersonaMunicipio.SelectedIndex = 0;
            textBoxDatosPersonaVereda.Text = "";
            comboBoxDatosPersonaNivelEstudio.SelectedIndex = 0;
            textBoxDatosPersonaNombreInstitucion.Text = "";
            textBoxDatosPersonaTelefono.Text = "";
            textBoxDatosPersonaAntiguedadAsociacion.Text = "";
            comboBoxDatosPersonaEstadoCivil.SelectedIndex = 0;
            datePickerDatosPersonaFechaNacimiento.Value = DateTime.Now;

            //Limpiar datos ayuda gobierno
            textBoxAyudaGobiernoPuntajeSisben.Text = "";
            comboBoxAyudaGobiernoTipoVictima.SelectedIndex = 0;
            comboBoxAyudaGobiernoRecibeSubsidio.SelectedIndex = 0;
            comboBoxAyudaGobiernoTipoSubsidio.SelectedIndex = 0;

            //Limpiar datos nucleo familiar
            comboBoxNucleoFamiliarConyuge.SelectedIndex = 0;
            textBoxNucleoFamiliarConyugeNombres.Text = "";
            textBoxNucleoFamiliarConyugeApellidos.Text = "";
            comboBoxNucleoFamiliarConyugeTipoIdentificacion.SelectedIndex = 0;
            textBoxNucleoFamiliarConyugeNumeroIdentificacion.Text = "";
            textBoxNucleoFamiliarConyugeNumeroTelefono.Text = "";
            datePickerNucleoFamiliarConyugeFechaNacimiento.Value = DateTime.Now;
            comboBoxNucleoFamiliarConyugeTipoActividad.SelectedIndex = 0;
            textBoxNucleoFamiliarConyugeOtraActividad.Text = "";
            dataGridNucleoFamiliarIntegrantes.DataSource = null;

            //Limpiar datos Ingresos
            comboBoxIngresosActividadEconomica.SelectedIndex = 0;
            textBoxIngresosIngresosMensuales.Text = "";
            textBoxIngresosTipoAnimales.Text = "";
            textBoxIngresosTipoCultivo.Text = "";
        }

        /// <summary>
        /// Reiniciar Datos Ingresar Asociado
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void ReiniciarDatosFormulario(object sender, EventArgs e)
        {
            tabIngresarAsociado.SelectedIndex = 0;
            LimpiarDatosFormulario();

            General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjeReinicioFormulario);
        }

      

        /// <summary>
        /// Cancelar Ingresar Asociado
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void AceptarIngresarAsociado(object sender, EventArgs e)
        {
            try
            {
                ingresoAsociadoAceptar.Enabled = false;
                ingresoAsociadoCancelar.Enabled = false;
                if (!ValidarInformacionIngresos())
                {
                    tabIngresarAsociado.SelectedIndex = 3;
                    General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjCamposObligatorios);
                    ingresoAsociadoAceptar.Enabled = true;
                    ingresoAsociadoCancelar.Enabled = true;
                }
                else
                {
                    ingresoAsociadoAceptar.Enabled = false;

                    //Se setea la informacion del usuario
                    FondoDominiosEntity datosPersonaTipoIdentificacion = (FondoDominiosEntity)comboBoxDatosPersonaTipoIdentificacion.SelectedItem;
                    FondoDominiosEntity datosPersonaNivelEstudio = (FondoDominiosEntity)comboBoxDatosPersonaNivelEstudio.SelectedItem;
                    FondoDominiosEntity datosPersonaEstadoCivil = (FondoDominiosEntity)comboBoxDatosPersonaEstadoCivil.SelectedItem;
                    FondoUsuarioEntity usuario = new FondoUsuarioEntity();
                    usuario.V_Tipo_Identificacion = datosPersonaTipoIdentificacion.V_Codigo;
                    usuario.V_Numero_Identificacion = Convert.ToInt64(textBoxDatosPersonaNumeroIdentificacion.Text);
                    usuario.V_Nombres = textBoxDatosPersonaNombres.Text;
                    usuario.V_Apellidos = textBoxDatosPersonasApellidos.Text;
                    usuario.N_Telefono = Convert.ToInt64(textBoxDatosPersonaTelefono.Text);
                    usuario.V_Nivel_Estudio = datosPersonaNivelEstudio.V_Codigo;
                    usuario.V_Puntaje_Sisben = textBoxAyudaGobiernoPuntajeSisben.Text;
                    usuario.V_Estado_Civil = datosPersonaEstadoCivil.V_Codigo;
                    usuario.V_Nombre_Institucion = textBoxDatosPersonaNombreInstitucion.Text;
                    usuario.F_Fecha_Nacimiento = datePickerDatosPersonaFechaNacimiento.Value;
                    usuario.F_Fecha_Registro = DateTime.Now;
                    usuario.N_Antiguedad_Asociacion = Convert.ToInt64(textBoxDatosPersonaAntiguedadAsociacion.Text);

                    FondoDominiosEntity datosPersonaPais = (FondoDominiosEntity)comboBoxDatosPersonaPais.SelectedItem;
                    FondoDominiosEntity datosPersonaDepartamento = (FondoDominiosEntity)comboBoxDatosPersonaDepartamento.SelectedItem;
                    FondoDominiosEntity datosPersonaMunicipio = (FondoDominiosEntity)comboBoxDatosPersonaMunicipio.SelectedItem;
                    FondoProcUsuarioEntity procedencia = new FondoProcUsuarioEntity();
                    procedencia.N_Id_Usuario = Convert.ToInt64(textBoxDatosPersonaNumeroIdentificacion.Text);
                    procedencia.V_Pais = datosPersonaPais.V_Codigo;
                    procedencia.V_Departamento = datosPersonaDepartamento.V_Codigo;
                    procedencia.V_Municipio = datosPersonaMunicipio.V_Codigo;
                    procedencia.V_Vereda = textBoxDatosPersonaVereda.Text;

                    //Se setea la informacion de las ayudas del gobierno
                    FondoDominiosEntity ayudaGobTipoVictima = (FondoDominiosEntity)comboBoxAyudaGobiernoTipoVictima.SelectedItem;
                    FondoDominiosEntity ayudaGobRecibeSubsidio = (FondoDominiosEntity)comboBoxAyudaGobiernoRecibeSubsidio.SelectedItem;
                    FondoDominiosEntity ayudaGobTipoSubsidio = (FondoDominiosEntity)comboBoxAyudaGobiernoTipoSubsidio.SelectedItem;
                    FondoAyudaGobEntity ayudaGob = new FondoAyudaGobEntity();
                    ayudaGob.N_Id_Usuario = Convert.ToInt64(textBoxDatosPersonaNumeroIdentificacion.Text);
                    ayudaGob.V_Tipo_Victima = ayudaGobTipoVictima.V_Codigo;
                    ayudaGob.V_Recibe_Subsidio = ayudaGobRecibeSubsidio.V_Codigo;
                    ayudaGob.V_Tipo_Subsidio = ayudaGobRecibeSubsidio.V_Valor.ToUpper().Equals(Constantes.DescripcionSi.ToUpper()) ? ayudaGobTipoSubsidio.V_Codigo : "";
                    //Se setea la informacion familiar
                    List<FondoFamiliaEntity> fondoFamilia = new List<FondoFamiliaEntity>();
                    //Datos del grid
                    foreach (DataGridViewRow dr in dataGridNucleoFamiliarIntegrantes.Rows)
                    {
                        FondoFamiliaEntity item = new FondoFamiliaEntity();
                        item.N_Id_Usuario = Convert.ToInt64(textBoxDatosPersonaNumeroIdentificacion.Text);
                        item.V_Nombres = dr.Cells[0] != null ? dr.Cells[0].Value.ToString() : "";
                        item.V_Apellidos = dr.Cells[1] != null ? dr.Cells[1].Value.ToString() : "";
                        item.V_Tipo_Identificacion = dr.Cells[8] != null ? dr.Cells[8].Value.ToString() : ""; 
                        item.V_Numero_Identificacion = dr.Cells[3] != null ? Convert.ToInt64(dr.Cells[3].Value.ToString()) : 0;
                        item.F_Fecha_Nacimiento = dr.Cells[5] != null ? DateTime.Parse(dr.Cells[5].Value.ToString()) : DateTime.Now;
                        item.V_Tipo_Parentesco = dr.Cells[10] != null ? dr.Cells[10].Value.ToString() : "";
                        item.N_Telefono = dr.Cells[4] != null ? Convert.ToInt64(dr.Cells[4].Value.ToString()) : 0;
                        item.V_Tipo_Actividad = dr.Cells[9] != null ? dr.Cells[9].Value.ToString() : "";
                        item.V_Cual_Otra = 
                            dr.Cells[6] != null ? dr.Cells[6].Value.ToString().ToUpper() == Constantes.DescripcionOtro.ToUpper() ? (dr.Cells[7] != null ? dr.Cells[7].Value.ToString() : "") : "" : "";

                        fondoFamilia.Add(item);
                    }

                    FondoDominiosEntity nucleoFamiliarConyuge = (FondoDominiosEntity)comboBoxNucleoFamiliarConyuge.SelectedItem;
                    FondoDominiosEntity nucleoFamiliarTipoIdentificacion = (FondoDominiosEntity)comboBoxNucleoFamiliarConyugeTipoIdentificacion.SelectedItem;
                    FondoDominiosEntity nucleoFamiliarTipoActividad = (FondoDominiosEntity)comboBoxNucleoFamiliarConyugeTipoActividad.SelectedItem;
                    if (nucleoFamiliarConyuge.V_Valor.ToUpper().Equals(Constantes.DescripcionSi.ToUpper()))
                    {
                        FondoFamiliaEntity conyuge = new FondoFamiliaEntity();
                        conyuge.N_Id_Usuario = Convert.ToInt64(textBoxDatosPersonaNumeroIdentificacion.Text);
                        conyuge.V_Nombres = textBoxNucleoFamiliarConyugeNombres.Text;
                        conyuge.V_Apellidos = textBoxNucleoFamiliarConyugeApellidos.Text;
                        conyuge.V_Tipo_Identificacion = nucleoFamiliarTipoIdentificacion.V_Codigo;
                        conyuge.V_Numero_Identificacion = Convert.ToInt64(textBoxNucleoFamiliarConyugeNumeroIdentificacion.Text);
                        conyuge.F_Fecha_Nacimiento = datePickerNucleoFamiliarConyugeFechaNacimiento.Value;
                        conyuge.V_Tipo_Parentesco = Constantes.DominioConyuge;
                        conyuge.N_Telefono = Convert.ToInt64(textBoxNucleoFamiliarConyugeNumeroTelefono.Text);
                        conyuge.V_Tipo_Actividad = nucleoFamiliarTipoActividad.V_Codigo;
                        conyuge.V_Cual_Otra = nucleoFamiliarTipoActividad.V_Valor.ToUpper().Equals(Constantes.DescripcionOtro.ToUpper()) ? textBoxNucleoFamiliarConyugeOtraActividad.Text : "";
                        fondoFamilia.Add(conyuge);
                    }

                    //Se setea la informacion de los ingresos
                    FondoDominiosEntity ingresosTipoActividad = (FondoDominiosEntity)comboBoxIngresosActividadEconomica.SelectedItem;
                    FondoIngresosEntity ingresos = new FondoIngresosEntity();
                    ingresos.N_Id_Usuario = Convert.ToInt64(textBoxDatosPersonaNumeroIdentificacion.Text);
                    ingresos.N_Ingresos_Mensuales = float.Parse(textBoxIngresosIngresosMensuales.Text);
                    ingresos.V_Tipo_Actividad = ingresosTipoActividad.V_Codigo;
                    ingresos.V_Tipo_Animales = ingresosTipoActividad.V_Valor.ToUpper().Equals(Constantes.DescripcionPecuario.ToUpper()) ? textBoxIngresosTipoAnimales.Text : "";
                    ingresos.V_Tipo_Cultivo = ingresosTipoActividad.V_Valor.ToUpper().Equals(Constantes.DescripcionAgricultura.ToUpper()) ? textBoxIngresosTipoCultivo.Text : "";

                    //Se procede a almacenar la informacion en BD
                    fondoUsuarioService.InsertarUsuario(usuario);
                    fondoProcUsuarioService.InsertarProcedenciaUsuario(procedencia);
                    fondoAyudaGobUsuarioService.InsertarAyudaGobUsuario(ayudaGob);
                    foreach (FondoFamiliaEntity intFamilia in fondoFamilia)
                    {
                        fondoFamiliaUsuarioService.InsertarFamiliaUsuario(intFamilia);
                    }                    
                    fondoIngresosUsuarioService.InsertarIngresosUsuario(ingresos);

                    //Se limpia el formulario
                    LimpiarDatosFormulario();
                    tabIngresarAsociado.SelectedIndex = 0;
                    General.MostrarPanelError(Constantes.CodigoExito, Constantes.MsjExitoGuardar);

                    ingresoAsociadoAceptar.Enabled = true;
                    ingresoAsociadoCancelar.Enabled = true;
                }
            }
            catch (BusinessException ex)
            {
                ingresoAsociadoAceptar.Enabled = true;
                ingresoAsociadoCancelar.Enabled = true;
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                ingresoAsociadoAceptar.Enabled = true;
                ingresoAsociadoCancelar.Enabled = true;
                Log.Registrar_Log(ex.Message, "FormIngresoAsociado - AceptarIngresarAsociado", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }          
           
        }
    }
}
