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
using System.Windows.Forms;

namespace ManejoFondo
{
    /// <summary>
    /// Clase para iniciar el formulario de Consulta de Usuarios
    /// Autor: Anderson Benavides
    /// 2019-05-22
    /// </summary> 
    public partial class FormOptConsultarUsuarios : MaterialForm
    {
        //Variable para guardar el usuario que inicio sesion
        FondoLoginEntity usuarioSesion;
        FondoUsuarioService fondoUsuarioService = new FondoUsuarioService();

        public FormOptConsultarUsuarios(FondoLoginEntity usuario)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //Centrar panel
            panelConsultaUsuarios.Location = new Point(
            this.ClientSize.Width / 2 - panelConsultaUsuarios.Size.Width / 2,
            this.ClientSize.Height / 2 - panelConsultaUsuarios.Size.Height / 3);
            panelConsultaUsuarios.Anchor = AnchorStyles.None;

            //Cambiar Tema form
            General.InicializarTema(this);

            //Valores por defecto
            usuarioSesion = usuario;
            CargarCombobox();

            //Se consulta todos los usuarios
            FondoUsuarioEntity filtro = new FondoUsuarioEntity();
            FondoDominiosEntity consultarUsuarioTipoIdentificacion = (FondoDominiosEntity)comboBoxConsultaUsuariosTipoIdentificacion.SelectedItem;
            filtro.V_Tipo_Identificacion = consultarUsuarioTipoIdentificacion.V_Codigo;
            filtro.F_Fecha_Registro_Inicio = datePickerConsultaUsuariosFechaRegistroDesde.Value;
            filtro.F_Fecha_Registro_Fin = datePickerConsultaUsuariosFechaRegistroHasta.Value;
            BuscarUsuarios(filtro);
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
                comboBoxConsultaUsuariosTipoIdentificacion.DataSource = fondoDominioService.ConsultarDominiosPorPadre(Constantes.DominioTiposIdentificacion, false);
                comboBoxConsultaUsuariosTipoIdentificacion.DisplayMember = "V_VALOR";
                comboBoxConsultaUsuariosTipoIdentificacion.ValueMember = "V_CODIGO";
            }
            catch (BusinessException ex)
            {
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "FormOptConsultarUsuarios - CargarCombobox", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }
        }

        /// <summary>
        /// Metodo para buscar los usuarios segun los filtros
        /// Autor: Anderson Benavides
        /// 2019-06-02
        /// </summary>
        /// <param name="usuarioFiltro"></param>
        private void BuscarUsuarios(FondoUsuarioEntity usuarioFiltro)
        {
            try
            {
                List<UsuarioConsultaModel> lstUsuarios = fondoUsuarioService.ConsultarUsuariosSistema(usuarioFiltro);
                dataGridConsultaUsuarios.DataSource = lstUsuarios;
            }
            catch (BusinessException ex)
            {
                General.MostrarPanelError(Constantes.CodigoWarning, ex.Message);
            }
            catch (Exception ex)
            {
                Log.Registrar_Log(ex.Message, "FormOptConsultarUsuarios - ConsultarUsuarios", LogErrorEnumeration.Critico);
                General.MostrarPanelError(Constantes.CodigoError, Constantes.MsjErrorInesperado);
            }            
        }

        /// <summary>
        /// Metodo para consultar los usuarios por los filtros de la pantalla
        /// Autor: Anderson Benavides
        /// 2019-06-02
        /// </summary>
        /// <param name="usuarioFiltro"></param>
        private void ConsultarUsuarios(object sender, EventArgs e)
        {
            FondoUsuarioEntity filtros = new FondoUsuarioEntity();

            FondoDominiosEntity consultarUsuarioTipoIdentificacion = (FondoDominiosEntity)comboBoxConsultaUsuariosTipoIdentificacion.SelectedItem;
            filtros.V_Tipo_Identificacion = consultarUsuarioTipoIdentificacion.V_Codigo;
            filtros.V_Numero_Identificacion = General.EsVacioNulo(textBoxConsultaUsuariosNumeroIdentificacion.Text) ? 0 : Convert.ToInt64(textBoxConsultaUsuariosNumeroIdentificacion.Text);
            filtros.V_Nombres = textBoxConsultaUsuariosNombres.Text;
            filtros.V_Apellidos = textBoxConsultaUsuariosApellidos.Text;
            filtros.F_Fecha_Registro_Inicio = datePickerConsultaUsuariosFechaRegistroDesde.Value;
            filtros.F_Fecha_Registro_Fin = datePickerConsultaUsuariosFechaRegistroHasta.Value;
            BuscarUsuarios(filtros);
        }
    }
}
