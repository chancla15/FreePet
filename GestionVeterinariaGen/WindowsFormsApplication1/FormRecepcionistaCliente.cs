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
    public partial class FormRecepcionistaCliente : Form
    {
        #region Variables

        /** El controlador */
        public FormRecepcionistaClienteController controller = null;

        /** EL tipo de accion, ADD,MOD,DEL */
        public Utils.State state = Utils.State.NONE;

        /** El identificador de la clase */
        public string ID = "CLIENTE";

        /** EL controlador del menu superior */
        public ScreenControllerRecepcionista menu = null;

        /** Por si borra el cliente que vuelva a cargar el cliente en la pantalla antes de salir */
        public Boolean haBorradoCliente = false;
        
        #endregion

        #region Constructor

        /**
         * Constructor
         * @param session el ticket de sesion
         * @param showType el tipo de accion
         */
        public FormRecepcionistaCliente(ScreenControllerRecepcionista menu)
        {
            this.menu = menu;
            InitializeComponent();
            controller = new FormRecepcionistaClienteController(this);
        }

        /**
         * Cambia el estado de la pantalla 
         * @param el estado de la pantalla
         * @param el cliente si es estado modificar o eliminar
         */
        public void changeState(Utils.State st)
        {
            state = st;
            if (state == Utils.State.MODIFY || state == Utils.State.DESTROY)
            {
                text_dni.Enabled = false;
                if (state == Utils.State.DESTROY) {
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

            if (haBorradoCliente)
            {
                controller.cargarDatosCliente(menu.clienteCompartido);
                haBorradoCliente = false;
            }
        }

       /**
        * Pone typ todos los elementos del formulario menos los de eliminar
        * @param typ si estan disponibles o no
        */
        private void EnableForm(Boolean typ)
        {
            text_dni.Enabled =  typ;
            text_nombre.Enabled = typ;
            text_apellidos.Enabled = typ;
            text_direccion.Enabled = typ;
            text_provincia.Enabled = typ;
            text_localidad.Enabled = typ;
            text_cp.Enabled = typ;
            text_telefono.Enabled = typ;
            text_buscar.Enabled = typ;
            btn_buscar_dni.Enabled = typ;
            btn_erase.Enabled = typ;
            btn_buscar.Enabled = typ;
            btn_guardar.Enabled = typ;
            btn_eliminar.Enabled = typ;
            dataGridView.Enabled = typ;
            panel_clientes_opcion.Enabled = typ;
            panel_top.Enabled = typ;
            btn_anaydir.Enabled = typ;

            alerta_eliminar.Enabled = !typ;
            alerta_eliminar.Visible = !typ;
            btn_eliminar_no.Enabled = !typ;
            btn_eliminar_si.Enabled = !typ;
        }

        #endregion

        #region Botones
        /**
         * Si buscamos una mascota
         */
        private void btn_buscar_Click(object sender, EventArgs e) {
            state = Utils.State.NEW;
            controller.Buscar();
        }

        /**
         * Si anaydimos una mascota nueva
         */
        private void btn_anaydir_Click(object sender, EventArgs e)
        {
            if(menu.LaunchMascotaScreen(Utils.State.NEW, null))
                    DesactivateForm();
        }

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
         * Cuadno se pulsa el boton de cancelar eliminacion
         */
        private void btn_eliminar_no_Click(object sender, EventArgs e)
        {
            state = Utils.State.MODIFY;
            EnableForm(true);
        }

        /**
         * Cuando se pulsa el boton de proceder a eliminar
         */
        private void btn_eliminar_si_Click(object sender, EventArgs e)
        {
            state = Utils.State.DESTROY;
            EnableForm(true);
            controller.ProcesarInformacion();
            state = Utils.State.NONE;
            menu.CargarClienteCompartidoRecepcionista(null);
        }


        /**
         * Cuando se pulsa el boton eliminar principal
         */
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EnableForm(false);
        }

        /**
         * Si clickea el boton de buscar cliente por dni desde la pantalla cliente
         */
        private void btn_buscar_dni_Click(object sender, EventArgs e)
        {
            if ((state==Utils.State.NONE || state==Utils.State.NEW) && menu.LaunchStartScreen())
                DesactivateForm();
        }

        /**
         * Cuando se pulsa el boton erase que es la gomita se borran todos los campos
         */
        private void btn_erase_Click(object sender, EventArgs e)
        {
            haBorradoCliente = true;
            text_dni.Enabled = true;
            controller.ClearForm();
            controller.Buscar();
            state = Utils.State.NONE;
        }


        /**
         * El boton que te llevara al formulario facturas de un determinado cliente
         */
        private void button_facturas_Click(object sender, EventArgs e)
        {
            if (state == Utils.State.MODIFY)
            {
                if(menu.LaunchFacturaScreen(Utils.State.MODIFY, text_dni.Text))
                     menu.f_cliente.DesactivateForm();
            }
        }

        #endregion

        #region DataGridView_Mascotas

        /**
        * Pinta el tamaño de las celdas
        */
        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e){
            //controller.paintDataGrid(e);
        }

        /**
         * Comprueba donde se ha pulsado
         */
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Utils.State aux_state = Utils.State.NONE;
            ClienteEN aux_cliente = null;
            MascotaEN msc = controller.getDataGridViewState(e, ref aux_state, ref aux_cliente);

            if (aux_cliente != null)
                menu.CargarClienteCompartidoRecepcionista(aux_cliente);

            if (msc != null)
                if (menu.LaunchMascotaScreen(aux_state, msc))
                    DesactivateForm();       
        }

        #endregion

        #region MenuSuperior

        /**
         * Pinta panel superior menu
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

            //Hide();
            //new FormRecepcionistaAdministradorInicio(controller.sessionData);
        }

        /**
         * Cuando se slecciona la opcion clientes
         */
        private void picture_clientes_Click(object sender, EventArgs e)
        {
            if (menu.LaunchClienteScreen())
                DesactivateForm();
        }

        /**
         * Cuando se slecciona la opcion consultas
         */
        private void picture_consultas_Click(object sender, EventArgs e)
        {
            if(menu.LaunchConsultaScreen(Utils.State.NONE, null))
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
            this.picture_cliente_opcion_cliente.BackColor = Color.White;
            this.panel_clientes_opcion.BackColor = Color.LightCyan;
        }

        /**
         * Si seleccionamos la opcion mascotas del panel clientes
         */
        private void picture_cliente_opcion_mascota_Click(object sender, EventArgs e)
        {
            if (menu.LaunchMascotaScreen(Utils.State.NEW, null))
                DesactivateForm();

            //Hide();
            //new FormRecepcionistaMascota(controller.sessionData, null, null, Utils.State.NONE);
        }

        /**
         *  Si seleccionamos la opcion cliente del panel clientes
         */
        private void picture_cliente_opcion_cliente_Click(object sender, EventArgs e){
            picture_clientes_Click(sender, e);
        }

        #endregion
    }
}
