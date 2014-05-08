using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Collections;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormRecepcionistaMascota : Form
    {
        #region Variables

        /** El controlador */
        private FormRecepcionistaMascotaController controller = null;

        /** El estado de la pantalla */
        public Utils.State state = Utils.State.NONE;

        /** EL identificador de la pantalla */
        public string ID = "MASCOTA";

        /** El menu superior */
        public ScreenControllerRecepcionista menu = null;

        #endregion

        #region Constructor

        /**
         * Contructor de clase de cuando lo llamamos para modificar/eliminar una mascota
         * @param session el ticket de sesion
         * @param mascota la mascota
         * @param action el tipo de accion (mod OR del)
         */
        public FormRecepcionistaMascota(ScreenControllerRecepcionista menu)
        {
            this.menu = menu;
            InitializeComponent();
            controller = new FormRecepcionistaMascotaController(this);          
        }

        /**
        * Cambiar el estado de la pantalla
        * @st el estado a cambiar
        */
        public void changeState(Utils.State st, ClienteEN cli, MascotaEN msc)
        {
           // controller.ClearForm();
            state = st;

            if (state == Utils.State.MODIFY || state == Utils.State.DESTROY)
            {
                text_cliente.Enabled = false;

                if (state == Utils.State.DESTROY)
                    btn_eliminar_Click(new object(), new EventArgs());
            }
            controller.loadDataCliente(cli, msc);
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
         * Desactivar formulario
         */
        public void DesactivateForm()
        {
            this.Visible= false;
        }

        /**
         * Bloquea los componentes del formulario dependiendo de la accion
         * @param action la accion
         * @param block el tipo de bloqueo
         */
        private void EnableForm(bool block)
        {
            text_cliente.Enabled = block;
            text_especie.Enabled = block;
            text_raza.Enabled = block;
            dateTime_fnac.Enabled = block;
            combo_sexo.Enabled = block;
            btn_add_NombreMascota.Enabled = block;

            if (state == Utils.State.DESTROY)
            {
                text_color.Enabled = block;
                combo_nombreAnimal.Enabled = block;
                text_peso.Enabled = block;
                combo_sexo.Enabled = block;
                combo_tamanyo.Enabled = block;
                combo_microchip.Enabled = block;
                btn_anaydir.Enabled = block;
                btn_buscar_cliente.Enabled = block;
                btn_erase.Enabled = block;
                dataGridView.Enabled = block;
                panel_clientes_opcion.Enabled = block;
                panel_top.Enabled = block;

                alerta_eliminar.Visible = alerta_eliminar.Enabled = !block;
                btn_eliminar_si.Visible = btn_eliminar_si.Enabled = !block;
                btn_eliminar_no.Visible = btn_eliminar_no.Enabled = !block;
                label_eliminar_box.Visible = label_eliminar_box.Enabled = !block;
            }
        }

        #endregion

        #region Botones_y_ComboBoxAnimal

        /**
         * Cuando se clickea el boton guardar
         */
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            controller.ProcesarInformacion();
        }

        /**
         * Cuando se clickea el boton eliminar
         */
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            state = Utils.State.DESTROY;
            EnableForm(false);
        }

        /**
         * Cuando se pulsa el boton anaydir de una nueva mascota
         */
        private void btn_add_NombreMascota_Click(object sender, EventArgs e)
        {
            btn_add_NombreMascota.Visible = false;
            box_NombreAnimal.Visible = true;
            box_NombreAnimal.Enabled = true;
        }

        /**
         * Cuando se clickea el boton (imagen) anaydir
         */
        private void btn_anaydir_Click(object sender, EventArgs e)
        {
            //ConsultaEN.Animal= mascotaEN;
            //if(State.NEW, consultaEN)
            //Hide();
            //Cargar consulta con mascota
            //Utils.State.NEW_CONSULTAS_MASCOTA,
            //new FormRecepcionistaConsulta(controller.sessionData, controller.mascotaEN);
        }

        /**
         * Cuando se clickea el boton buscar y apareceria en el combo_box de nombres el del animal
         */
        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            //Busca por cliente
        }

        /**
         * Borrar los campos del formulario
         */
        private void btn_erase_Click(object sender, EventArgs e)
        {
            controller.ClearForm();
        }

        /**
         * Cuando pulsamos el boton de no eliminar
         */
        private void btn_eliminar_no_Click(object sender, EventArgs e)
        {
            EnableForm(true);
            state = Utils.State.MODIFY;
        }

        /**
         * Cuando pasamos el boton de eliminar si
         */
        private void btn_eliminar_si_Click(object sender, EventArgs e)
        {
            controller.ProcesarInformacion();
            EnableForm(true);
            controller.ClearForm();
            state = Utils.State.NONE;
        }

       /**
        * Si se selecciona una mascota del cliente se cargan los datos de esta mascota
        */
        private void combo_nombreAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeState(Utils.State.MODIFY, null, null);
        }

        #endregion

        #region Box_Controller_Nombre_Animal

        /**
         * El boton cancelar
         */
        private void box_label_cancelar_Click(object sender, EventArgs e)
        {
            box_NombreAnimal.Visible = false;
            box_NombreAnimal.Enabled = false;
        }

        /**
         * El boton aceptar
         */
        private void box_label_aceptar_Click(object sender, EventArgs e)
        {
            string name_msc = box_text_nombre_mascota.Text;

            if (name_msc != "")
            {
                //agregar al combo_box de mascotas
                box_NombreAnimal.Visible = false;
                box_NombreAnimal.Enabled = false;
            }
        }

        #endregion

        #region DataGridView

        /**
        * Cuando se clickea en el dataGrid
        */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region MenuSuperior

        /**
         * Pinta el panel superior
         */
        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_clientes.BackColor = Color.White;
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

        #region SubMenuSuperior

        /**
        * Pinta el panel segun la pantalla
        */
        private void panel_clientes_opcion_Paint(object sender, PaintEventArgs e)
        {
            this.picture_cliente_opcion_mascota.BackColor = Color.White;
            this.panel_clientes_opcion.BackColor = Color.LightCyan;
        }

        /**
         * Si pulsa la opcion cliente
         */
        private void picture_cliente_opcion_cliente_Click(object sender, EventArgs e){
            picture_clientes_Click(sender, e);
        }

        /**
         * Si pulsa la opcion mascota
         */
        private void picture_cliente_opcion_mascota_Click(object sender, EventArgs e)
        {
            if (menu.LaunchMascotaScreen(Utils.State.NONE, null, null))
                DesactivateForm();
        }

        #endregion
    }
}
