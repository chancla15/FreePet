using System;
using System.Drawing;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormRecepcionistaAdministradorInicio : Form
    {
        #region Variables

        /** El controlador Recepcionista*/
        public FormRecepcionistaAdministradorInicioController controller_recep = null;


        /** El controlador Admin*/
        public FormRecepcionistaAdministradorInicioController controller_admin = null;

        /** El menu superior */
        public ScreenController menu = null;

        /** IDENTIFICADOR */
        public string ID = "START";

        /** EL tipo de accion, ADD,MOD,DEL */
        public Utils.State state = Utils.State.NONE;

        #endregion

        #region Constructor
        /**
         * Constructor de la clase
         * @param sesion datos de la sesion
         */
        public FormRecepcionistaAdministradorInicio(ScreenController menu)
        {


            // ActivateForm();
            this.menu = menu;
            InitializeComponent();


            if (menu.sessionData.tipo.Equals("Recepcionista"))
            {

                controller_recep = new FormRecepcionistaAdministradorInicioController(this, this.menu.sessionData);
                EnableMenuAdministrador(false);
                EnableMenuRecepcionista(true);
                
            }
            else
            {
                controller_admin = new FormRecepcionistaAdministradorInicioController(this, this.menu.sessionData);
                EnableMenuRecepcionista(false);
                EnableMenuAdministrador(true);

            }

        }

        //Activa menu recepcionista
        public void EnableMenuRecepcionista(bool b)
        {
            picture_start_recepcionista.Visible = picture_start_recepcionista.Enabled = b;
            picture_consultas_recepcionista.Visible = picture_consultas_recepcionista.Enabled = b;
            picture_clientes_recepcionista.Visible = picture_clientes_recepcionista.Enabled = b;
            picture_facturas_recepcionista.Visible = picture_facturas_recepcionista.Enabled = b;
            picture_ajustes_recepcionista.Visible = picture_ajustes_recepcionista.Enabled = b;
        }

        //Activa menu administrador
        public void EnableMenuAdministrador(bool b)
        {
            picture_start_admin.Visible = picture_start_admin.Enabled = b;
            picture_empleados_admin.Visible = picture_empleados_admin.Enabled = b;
            picture_tratamientos_admin.Visible = picture_tratamientos_admin.Enabled = b;
            picture_desconectar_admin.Visible = picture_desconectar_admin.Enabled = b;

        }

        /**
         * Cambia el estado de la pantalla 
         * @param el estado de la pantalla
         * @param el cliente si es estado modificar o eliminar
         */
        public void changeState_admin(Utils.State st, EmpleadoEN emp)
        {
            // controller.ClearForm();
            state = st;
            if (state == Utils.State.MODIFY || state == Utils.State.DESTROY)
            {
                //text_dni.Enabled = false;
                //controller_admin.loadData(emp);

                if (state == Utils.State.DESTROY)
                {
                    //btn_eliminar_Click(new object(), new EventArgs());
                }
            }
        }

        public void changeState_recep(Utils.State st, EmpleadoEN emp)
        {
            // controller.ClearForm();
            state = st;
            if (state == Utils.State.MODIFY || state == Utils.State.DESTROY)
            {
                //text_dni.Enabled = false;
                //controller_admin.loadData(emp);

                if (state == Utils.State.DESTROY)
                {
                    //btn_eliminar_Click(new object(), new EventArgs());
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
        #endregion

        #region DataGridClientes

        private void CellPainting_Clientes(object sender, DataGridViewCellPaintingEventArgs e)
        {
            controller_recep.paintDataGridView_Clientes(e);
        }

        private void CellContentClick_Clientes(object sender, DataGridViewCellEventArgs e)
        {
            Utils.State st = Utils.State.NONE;

            ClienteEN cliente = controller_recep.getStateScreen_Clientes(e, ref st);

            if (cliente != null && cliente.Mascota != null)
                Console.WriteLine("mascotas in");

            if (cliente != null)
            {
                //Hide();
                Console.WriteLine(cliente.DNI + "   " + cliente.Direccion);
                menu.LaunchClienteScreen(st, cliente);
                //new FormRecepcionistaCliente(controller.sessionData, cliente, st);
            }
        }

        #endregion

        #region ButtonsBuscar

        /**
         * Cuando se pulsa el boton de buscar
         */
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (menu.sessionData.tipo.Equals("Recepcionista"))
            {
                controller_recep.buscar();
            }
            else
            {
                controller_admin.buscar();
            }
        }


        /**
         * Carga la pantalla para introducir un nuevo usuario
         */
        private void btn_add_Click(object sender, EventArgs e)
        {
            Hide();

            if (menu.sessionData.tipo.Equals("Administrador"))
            {
                //new FormAdministradorEmpleado(controller_admin.sessionData);
            }
            else
            {
                //new FormRecepcionistaCliente(controller_recep.sessionData, null, Utils.State.NEW);
            }
        }

        #endregion

        #region MenuSuperior



        /**
         * Pinta el panel superior
         */
        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_start_recepcionista.BackColor = Color.White;
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

        #region DataGridEmpleados

        private void CellPainting_empleados(object sender, DataGridViewCellPaintingEventArgs e)
        {
            controller_admin.paintDataGridView_Empleados(e);
        }

        private void CellContentClick_empleados(object sender, DataGridViewCellEventArgs e)
        {
            Utils.State aux_state = Utils.State.NONE;
            EmpleadoEN msc = controller_admin.getStateScreen_Empleados(e, ref aux_state);

            // Console.WriteLine("Estado: " + mscState + "ANIMAL: " + msc.IdMascota);
            //Ir a formulario mascotas
            if (msc != null && aux_state != Utils.State.NONE)
            {
                if (menu.LaunchEmpleadoScreen(aux_state,msc))
                    DesactivateForm();
            }
            else if (msc != null && aux_state == Utils.State.NONE)
            {
                changeState_admin(Utils.State.MODIFY, Utils._IEmpleadoCAD.DameEmpleadoPorOID(""));
            }

        }
        #endregion

        #region MenuSuperiorAdministrador

        private void picture_start_admin_Click(object sender, EventArgs e)
        {
            if (menu.LaunchStartScreen())
                DesactivateForm();
        }

        private void picture_empleados_admin_Click(object sender, EventArgs e)
        {
            if (menu.LaunchEmpleadoScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        private void picture_tratamientos_admin_Click(object sender, EventArgs e)
        {
            if (menu.LaunchTratamientoScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        #endregion

        private void picture_desconectar_admin_Click(object sender, EventArgs e)
        {
            menu.sessionData.Disconnect();
        }

    }
}
