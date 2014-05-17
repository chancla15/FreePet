using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormAdministradorTratamiento : Form
    {

        #region Variables

        /** El controlador */
        private FormAdministradorTratamientoController controller = null;

        /** EL tipo de accion, ADD,MOD,DEL */
        public Utils.State state = Utils.State.NONE;

        /** El identificador de la clase */
        public string ID = "TRATAMIENTO";

        /** EL controlador del menu superior */
        public ScreenControllerAdministrador menu = null;

        #endregion

        #region Constructor

        /**
         * Constructor
         * @param session el ticket de sesion
         * @param showType el tipo de accion
         */
        public FormAdministradorTratamiento(ScreenControllerAdministrador menu)
        {
            this.menu = menu;
            InitializeComponent();
            controller = new FormAdministradorTratamientoController(this);
        }

        /**
         * Cambia el estado de la pantalla 
         * @param el estado de la pantalla
         * @param el cliente si es estado modificar o eliminar
         */
        public void changeState(Utils.State st, TratamientoEN tra)
        {
            // controller.ClearForm();
            
            state = st;
            if (state == Utils.State.MODIFY || state == Utils.State.DESTROY)
            {
                text_nombre.Enabled = false;
                controller.loadData(tra);

                if (state == Utils.State.DESTROY)
                {
                    btn_eliminar_Click(new object(), new EventArgs());
                }
            }
          
        }

        #endregion

        #region I/O_Form

        /** Activa el formulario */
        public void ActivateForm()
        {
            Activate();
            this.Visible = true;
        }

        /** Desactiva el formulario */
        public void DesactivateForm()
        {
            this.Visible = false;
        }

        /**
         * Pone typ todos los elementos del formulario menos los de eliminar
         * @param typ si estan disponibles o no
         */
        private void EnableForm(Boolean typ)
        {
            text_nombre.Enabled = typ;
            lista_dosis.Enabled = typ;
            text_precio.Enabled = typ;
            text_descripcion.Enabled = typ;
            text_stock.Enabled = typ;

            panel_top.Enabled = typ;
        }

        #endregion

        #region Botones

        /**
        * Cuando se selecciona el boton guardar
        */
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (state == Utils.State.NONE || state == Utils.State.NEW)
                state = Utils.State.NEW;
            else
                state = Utils.State.MODIFY;

            controller.ProcesarInformacion();
            EnableForm(true);
            state = Utils.State.MODIFY;
        }

        /**
         * Cuando se pulsa el boton eliminar principal
         */
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (state == Utils.State.MODIFY)
            {
                EnableForm(false);
                if (MessageBox.Show("¿Seguro que desea eliminar este tratamiento?", "Eliminar tratamiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    state = Utils.State.DESTROY;
                    controller.ProcesarInformacion();
                }
                else
                    state = Utils.State.MODIFY;

                EnableForm(true);
            }
        }

        /**
         * Si clickea el boton de buscar tratamientos
         */
        private void btn_buscar_id_Click(object sender, EventArgs e)
        {
            state = Utils.State.NEW;
            controller.Buscar();
        }

        /**
         * Cuando se pulsa el boton erase que es la gomita se borran todos los campos
         */
        private void btn_erase_Click(object sender, EventArgs e)
        {
            if (state == Utils.State.MODIFY)
                text_nombre.Enabled = true;

            controller.ClearForm();
            state = Utils.State.NONE;
            EnableForm(true);
        }

        #endregion

        #region DataGridView_Tratamientos

        /**
         * Comprueba donde se ha pulsado
         */
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Utils.State st = Utils.State.NONE;
            TratamientoEN tratamiento = controller.getDataGridViewState(e,ref st);

            if (tratamiento != null)
                changeState(st, tratamiento);
        }

        #endregion

        #region MenuSuperior

        /**
         * Pinta panel superior menu
         */
        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_empleado.BackColor = Color.White;
            this.panel_top.BackColor = Color.LightBlue;
        }

        /**
         * Cuando se slecciona la opcion start
         */
        private void picture_start_Click(object sender, EventArgs e)
        {
            if (menu.LaunchStartScreen())
                DesactivateForm();
        }

        /**
         * Cuando se slecciona la opcion clientes
         */
        private void picture_empleados_Click(object sender, EventArgs e)
        {
            if (menu.LaunchEmpleadoScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        /**
         * Cuando se slecciona la opcion consultas
         */
        private void picture_tratatamiento_Click(object sender, EventArgs e)
        {
            if (menu.LaunchTratamientoScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        /**
         * Cuando se slecciona la opcion ajustes
         */
        private void picture_desconectar_Click(object sender, EventArgs e)
        {
            menu.Disconnect();
        }

        #endregion
    }
}
