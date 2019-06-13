using ManejoFondo.Common;
using ManejoFondo.Entities;
using ManejoFondo.Loggers;
using ManejoFondo.Modelos;
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
    /// Clase para iniciar el formulario de Agregar persona nucleo familiar
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary>  
    public partial class FormModalAgregarNucleoFamiliar : MaterialForm
    {
        public String jsonUsuario { get; set; }

        public FormModalAgregarNucleoFamiliar()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Cambiar Tema form
            General.InicializarTema(this);

            //Valores por defecto
            CargarCombobox();

            //Precargar fecha
            datePickerAgregarPersonaFechaNacimiento.Value = DateTime.Now;
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

                //Agregar persona
                comboBoxAgregarPersonaTipoIdentificacion.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTiposIdentificacion, false); ;
                comboBoxAgregarPersonaTipoIdentificacion.DisplayMember = "V_VALOR";
                comboBoxAgregarPersonaTipoIdentificacion.ValueMember = "V_CODIGO";
                comboBoxAgregarPersonaTipoActividad.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTipoActividad, false); ;
                comboBoxAgregarPersonaTipoActividad.DisplayMember = "V_VALOR";
                comboBoxAgregarPersonaTipoActividad.ValueMember = "V_CODIGO";
                comboBoxAgregarPersonaParentesco.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioParentesco, false); ;
                comboBoxAgregarPersonaParentesco.DisplayMember = "V_VALOR";
                comboBoxAgregarPersonaParentesco.ValueMember = "V_CODIGO";

            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "CargarCombobox - IngresoAsociado", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Cierra la modal de Agregar Personas
        /// Autor: Anderson Benavides
        /// 2019-06-02
        /// </summary>
        private void CerrarAgregarPersona(object sender, EventArgs e)
        {
            LimpiarInformacionModal();
            jsonUsuario = "";
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
        /// Funcion que permite limpiar la informacion de la modal
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void LimpiarInformacionModal()
        {
            textAgregarPersonaNombres.Text = "";
            textBoxAgregarPersonaApellidos.Text = "";
            comboBoxAgregarPersonaTipoIdentificacion.SelectedIndex = 0;
            textBoxAgregarPersonaNumeroIdentificacion.Text = "";
            textBoxAgregarPersonaNumeroTelefono.Text = "";            
            datePickerAgregarPersonaFechaNacimiento.Value = DateTime.Now;
            comboBoxAgregarPersonaTipoActividad.SelectedIndex = 0;
            textBoxAgregarPersonaOtraActividad.Text = "";
            comboBoxAgregarPersonaParentesco.SelectedIndex = 0;
        }

        /// <summary>
        /// Funcion para ocultar o mostrar la informacion "Cual otro" de Actividad
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void ValidarTipoActividadAgregarPersona(object sender, EventArgs e)
        {
            FondoDominiosEntity itemSeleccionado = (FondoDominiosEntity)comboBoxAgregarPersonaTipoActividad.SelectedItem;
            if (itemSeleccionado.V_Valor.ToUpper().Equals(Constantes.DescripcionOtro.ToUpper()))
            {
                labelAgregarPersonaOtraActividad.Visible = true;
                textBoxAgregarPersonaOtraActividad.Visible = true;
                labelObligatorioCualTipoActividadAgregarPersona.Visible = true;

                labelAgregarPersonaParentesco.Location = new Point(37, 435);
                comboBoxAgregarPersonaParentesco.Location = new Point(40, 466);
                labelObligatorioParentescoAgregarPersona.Location = new Point(375, 466);
            }
            else
            {
                labelAgregarPersonaOtraActividad.Visible = false;
                textBoxAgregarPersonaOtraActividad.Visible = false;
                labelObligatorioCualTipoActividadAgregarPersona.Visible = false;

                labelAgregarPersonaParentesco.Location = new Point(458, 377);
                comboBoxAgregarPersonaParentesco.Location = new Point(462, 402);
                labelObligatorioParentescoAgregarPersona.Location = new Point(797, 402);
            }
        }

        /// <summary>
        /// Funcion para validar los campos de la persona a almacenar
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private bool ValidarInformacionAgregarPersona()
        {
            if (General.EsVacioNulo(textAgregarPersonaNombres.Text) || General.EsVacioNulo(textBoxAgregarPersonaApellidos.Text) ||
                General.EsVacioNulo(comboBoxAgregarPersonaTipoIdentificacion.Text) || General.EsVacioNulo(textBoxAgregarPersonaNumeroIdentificacion.Text) ||
                General.EsVacioNulo(textBoxAgregarPersonaNumeroTelefono.Text) || General.EsVacioNulo(datePickerAgregarPersonaFechaNacimiento.Text) ||
                General.EsVacioNulo(comboBoxAgregarPersonaTipoActividad.Text) || General.EsVacioNulo(comboBoxAgregarPersonaParentesco.Text))
            {
                return false;
            }
            else
            {
                FondoDominiosEntity itemTipoActividad = (FondoDominiosEntity)comboBoxAgregarPersonaTipoActividad.SelectedItem;
                if (itemTipoActividad.V_Valor.ToUpper().Equals(Constantes.DescripcionOtro.ToUpper()) && General.EsVacioNulo(textBoxAgregarPersonaOtraActividad.Text))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// Funcion para validar la informacion a almacenar
        /// Autor: Anderson Benavides
        /// 2019-05-23
        /// </summary>
        private void ValidarInformacionGuardar(object sender, EventArgs e)
        {
            if (!ValidarInformacionAgregarPersona())
            {
                General.MostrarPanelError(Constantes.CodigoWarning, Constantes.MsjCamposObligatorios);
            }
            else
            {
                FondoDominiosEntity agregarTipoIdentificacion = (FondoDominiosEntity)comboBoxAgregarPersonaTipoIdentificacion.SelectedItem;
                FondoDominiosEntity agregarTipoActividad = (FondoDominiosEntity)comboBoxAgregarPersonaTipoActividad.SelectedItem;
                FondoDominiosEntity agregarParentesco = (FondoDominiosEntity)comboBoxAgregarPersonaParentesco.SelectedItem;

                UsuarioModel usuario = new UsuarioModel();
                //Almacenar provisionalmente la informacion
                usuario.Nombres = textAgregarPersonaNombres.Text;
                usuario.Apellidos = textBoxAgregarPersonaApellidos.Text;
                usuario.TipoIdentificacion = agregarTipoIdentificacion.V_Valor;
                usuario.NumeroIdentificacion = textBoxAgregarPersonaNumeroIdentificacion.Text;
                usuario.Telefono = Convert.ToInt32(textBoxAgregarPersonaNumeroTelefono.Text);
                usuario.FechaNacimiento = datePickerAgregarPersonaFechaNacimiento.Value;
                usuario.TipoActividad = agregarTipoActividad.V_Valor;
                usuario.OtraActividad = textBoxAgregarPersonaOtraActividad.Text;
                usuario.Parentesco = agregarParentesco.V_Valor;
                //Almacenar los codigos de los combos
                usuario.CodTipoIdentificacion = agregarTipoIdentificacion.V_Codigo;
                usuario.CodTipoActividad = agregarTipoActividad.V_Codigo;
                usuario.CodParentesco = agregarParentesco.V_Codigo;
                jsonUsuario = new JavaScriptSerializer().Serialize(usuario);
                Close();
            }
        }
    }
}
