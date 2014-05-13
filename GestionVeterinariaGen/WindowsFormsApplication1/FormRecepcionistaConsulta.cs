using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormRecepcionistaConsulta : Form
    {
        #region Variables

        /** El controlador de esta vista */
        private FormRecepcionistaConsultaController controller = null;

        /** El estado actual de la pantalla. Se modifica en algunos metodos */
        public Utils.State state = Utils.State.NONE;

        /** El identificador del formulario */
        public string ID = "CONSULTA";

        /** El menu superior */
        public ScreenControllerRecepcionista menu = null;

        #endregion

        #region Constructor

        /**
         * Contructor de clase
         */
        public FormRecepcionistaConsulta(ScreenControllerRecepcionista menu)
        {
            this.menu = menu;
            InitializeComponent();
            controller = new FormRecepcionistaConsultaController(this);
        }

        public void changeState(Utils.State state, ConsultaEN consulta)
        {
            //Si se crea con el estado normal no se carga normalemente sino
            //se carga la consulta pasada
            if (state == Utils.State.NONE)
            {
                controller.ClearForm();
            }
            else
            {
                //consultaEN = consulta;
                //Aqui cargaria los datos de una consulta
                // cargarDatosConsultaDesdeConsultaEN();
            }
        }

        #endregion

        #region I/O_Form

        /**
         * Activa el formulario
         */
        public void ActivateForm()
        {
            Activate();
            this.Visible = true;
        }

        /**
         * Desactiva el formulario
         */
        public void DesactivateForm()
        {
            this.Visible = false;
        }

        /**
         * Desbloquea o bloquea el formulario
         * @param t indica si se bloquea o no
         */
        private void EnableForm(bool t)
        {
            box_text_motivo.Enabled = t;
            box_text_lugar.Enabled = t;
            box_text_cliente.Enabled = t;
            box_text_fecha.Enabled = t;
            box_combo_hora.Enabled = t;
            box_combo_hora.Enabled = t;
            box_combo_mascotas.Enabled = t;
            box_combo_mascotas.Enabled = t;
            box_combo_veterinario.Enabled = t;
            box_label_veterinario.Enabled = t;
            datetime_init.Enabled = t;
            datetime_fin.Enabled = t;
            treeViewConsultas.Enabled = t;

            alerta_eliminar.Enabled = !t;
            alerta_eliminar.Visible = !t;
        }

        #endregion

        #region Botones

        /**
         * Boton buscar por fecha, el boton ADD, MOD y DEL estaran disponibles. El cuadro del cliente se borrar
         * si hay escrito algo
         */
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            state = Utils.State.NEW;
            label_error_fecha.Visible = false;
            
            if(!controller.buscarPorFechas())
                label_error_fecha.Visible=true;
        }

        /**
        * Cuando se pulsa el boton de buscar del cliente pa que muestre sus mascotas
        */
        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            box_error_cliente.Visible = false;

            if (!controller.checkClienteAndShowPets())
                box_error_cliente.Visible = true;
        }  

        /**
        * Boton Añadir, comprobar si se ha buscado por fecha o por cliente 
        */
        private void image_add_Click(object sender, EventArgs e)
        {

            if (state == Utils.State.NONE)
                state = Utils.State.NEW;


            if (treeViewConsultas.SelectedNode == null
                || (treeViewConsultas.SelectedNode != null && treeViewConsultas.SelectedNode.Level == 0 && state == Utils.State.MODIFY))
                state = Utils.State.NONE;
            else if (treeViewConsultas.SelectedNode == null
                    || (treeViewConsultas.SelectedNode != null && treeViewConsultas.SelectedNode.Level == 1) && state == Utils.State.NEW)
                state = Utils.State.NONE;

            controller.ProcesarInformacion();

            treeViewConsultas.SelectedNode = null;
            state = Utils.State.NONE;
        }

        /**
        * Boton Eliminar, comprobar si se ha buscado por fecha o por cliente 
        */
        private void image_del_Click(object sender, EventArgs e)
        {
            state = Utils.State.DESTROY;

            if (treeViewConsultas.SelectedNode == null
                || (treeViewConsultas.SelectedNode != null && treeViewConsultas.SelectedNode.Level == 1))
                state = Utils.State.NONE;

            EnableForm(false);
        }


        /**
         * Cuando clickemaos no en la opcion de eliminar de la alerta
         */
        private void btn_eliminar_no_Click(object sender, EventArgs e)
        {
            EnableForm(true);
            state = Utils.State.NONE;
        }

        /**
         * Cuando clickeamos si en la opcion eliminar de la alerta
         */
        private void btn_eliminar_si_Click(object sender, EventArgs e)
        {
            controller.ProcesarInformacion();
            EnableForm(true);
            state = Utils.State.NONE;
        }

        /**
         * Si pulsa el boton de la goma de borrar borra todos los campos del formulario y el datagrid
         */
        private void btn_erase_Click(object sender, EventArgs e)
        {
            controller.ClearForm();
            state = Utils.State.NONE;
        }


        #endregion

        #region ComboBox

        /**
        * Dada una fecha determinada mostrara todas las horas libres disponibles para ese dia
        */
        private void box_combo_hora_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.checkBoxVeterinarios();
        }

        #endregion

        #region TreeView_Consultas
        
        /** 
         * CUando clikeamos en una fecha de la pantalla principal se cambia a la de introducir datos consulta
         */
        private void treeViewConsultas_AfterSelect(object sender, TreeViewEventArgs e){
            controller.cambiarFecha();

            if (treeViewConsultas.SelectedNode.Level == 0)
            {
                state = Utils.State.NEW;
            }
            else if (treeViewConsultas.SelectedNode.Level == 1)
            {
                state = Utils.State.MODIFY;
                controller.cargarDatosConsultaDesdeTreeView();
            }
        }  
 
        #endregion

        #region MenuSuperior

        /**
         * Pinta panel superior menu
         */
        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_consultas.BackColor = Color.White;
            this.panel_top.BackColor = Color.LightBlue;
        }

        /**
         * Cuando se selecciona la opcion start
         */
        private void picture_start_Click(object sender, EventArgs e)
        {
            if (menu.LaunchStartScreen())
                DesactivateForm();
        }

        /**
         * Cuando se slecciona la opcion clientes
         */
        private void picture_clientes_Click(object sender, EventArgs e)
        {
            if (menu.LaunchClienteScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        /**
         * Cuando se slecciona la opcion consultas
         */
        private void picture_consultas_Click(object sender, EventArgs e)
        {
            if (menu.LaunchConsultaScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        /**
         * Cuando se slecciona la opcion facturas
         */
        private void picture_facturas_Click(object sender, EventArgs e)
        {
            if (menu.LaunchFacturaScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        /**
         * Cuando se slecciona la opcion ajustes
         */
        private void picture_ajustes_Click(object sender, EventArgs e)
        {
            //Esto solo le da a un formulario
            //donde puede cambiar algunos datos personales, la constraseña la foto y desconectarse
        }

        #endregion
    }
}
