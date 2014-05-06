using System;
using System.Drawing;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormRecepcionistaAdministradorInicio : Form
    {
        #region Variables

        /** El controlador */
        public FormRecepcionistaAdministradorInicioController controller = null;

        /** El menu superior */
        public ScreenControllerRecepcionista menu = null;

        /** IDENTIFICADOR */
        public string ID = "START";

        #endregion

        #region Constructor
        /**
         * Constructor de la clase
         * @param sesion datos de la sesion
         */
        public FormRecepcionistaAdministradorInicio(ScreenControllerRecepcionista menu)
        {
           // ActivateForm();
            this.menu = menu;
            InitializeComponent();
            controller = new FormRecepcionistaAdministradorInicioController(this, this.menu.sessionData);

            //IMPLEMENTAR PARATE CONTROLADOR ADMINSITRADOR.........

            //....
            //....
            //....




                //mostraria la otra barra
                //sino muestra la normal de recepcionista
            
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

        /**
         * Pinta el tamaño de las celdas
         */
        private void dataGridView1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            controller.paintDataGridView(e);
        }

        /**
         * Comprueba el tipo de dato que selecciona el usuario de la tabla
         */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Utils.State st = Utils.State.NONE;

            ClienteEN cliente = controller.getStateScreen(e, ref st);

            if (cliente!=null && cliente.Mascota != null)
                Console.WriteLine("mascotas in");

            if(cliente!=null) {
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
            controller.buscar();
        }


        /**
         * Carga la pantalla para introducir un nuevo usuario
         */
        private void btn_add_Click(object sender, EventArgs e)
        {
            Hide();

            if (controller.sessionData.tipo.Equals("Administrador"))
            {
                new FormAdministradorEmpleado(controller.sessionData);
            }
            else if(controller.sessionData.tipo.Equals("Recepcionista"))
            {
                //new FormRecepcionistaCliente(controller.sessionData, null, Utils.State.NEW);
            }
        }

        #endregion

        #region MenuSuperior



        /**
         * Pinta el panel superior
         */
        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_start.BackColor = Color.White;
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
            if(menu.LaunchFacturaScreen())
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
