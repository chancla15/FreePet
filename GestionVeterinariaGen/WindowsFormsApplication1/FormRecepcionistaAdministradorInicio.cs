using System;
using System.Drawing;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormRecepcionistaAdministradorInicio : Form
    {
        #region Variables

        public FormRecepcionistaAdministradorInicioController controller = null;
        public ScreenController menu = null;
        public string ID = "START";

        #endregion

        #region Constructor
        
        public FormRecepcionistaAdministradorInicio(ScreenController menu)
        {
            Activate();
            Boolean admin = false;
            this.menu = menu;
            InitializeComponent();
            controller = new FormRecepcionistaAdministradorInicioController(this);

            if (menu.sessionData.tipo.Equals("Administrador"))
                admin = true;
                

            EnableMenuAdministrador(admin);

        }
        
        #endregion

        #region I/O_Form

        public void DesactivateForm()
        {
            Hide();
        }

        public void EnableMenuAdministrador(bool b)
        {
            label12.Visible = b;
            label13.Visible = b;
            label14.Visible = b;
            label15.Visible = b;

            ListaEmpleados.Visible = ListaEmpleados.Enabled = b;
            picture_start_admin.Visible = picture_start_admin.Enabled = b;
            picture_empleados_admin.Visible = picture_empleados_admin.Enabled = b;
            picture_tratamientos_admin.Visible = picture_tratamientos_admin.Enabled = b;
            picture_desconectar_admin.Visible = picture_desconectar_admin.Enabled = b;

            dataGrid_clientes.Visible = dataGrid_clientes.Enabled = !b;
            picture_start_recepcionista.Visible = picture_start_recepcionista.Enabled = !b;
            picture_consultas_recepcionista.Visible = picture_consultas_recepcionista.Enabled = !b;
            picture_clientes_recepcionista.Visible = picture_clientes_recepcionista.Enabled = !b;
            picture_facturas_recepcionista.Visible = picture_facturas_recepcionista.Enabled = !b;
            picture_ajustes_recepcionista.Visible = picture_ajustes_recepcionista.Enabled = !b;
        }

        #endregion

        #region DataGridClientes

        private void CellPainting_Clientes(object sender, DataGridViewCellPaintingEventArgs e)
        {
            controller.paintDataGridView_Clientes(e);
        }

        private void CellContentClick_Clientes(object sender, DataGridViewCellEventArgs e)
        {
            Utils.State st = Utils.State.NONE;
            ClienteEN cliente = controller.getStateScreen_Clientes(e, ref st);


            if (cliente != null)
            {
                menu.CargarClienteCompartidoRecepcionista(cliente);

                if (menu.LaunchClienteScreen())
                    DesactivateForm();
            }
        }

        #endregion

        #region ButtonsBuscarAnadyir

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            controller.buscar();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (menu.sessionData.tipo.Equals("Administrador"))
            {
                if (menu.LaunchEmpleadoScreen(Utils.State.NEW, null))
                    DesactivateForm();
            }
            else
            {
                menu.CargarClienteCompartidoRecepcionista(null);

                if (menu.LaunchClienteScreen())
                    DesactivateForm();
            }
        }

        #endregion

        #region MenuSuperior

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_start_recepcionista.BackColor = Color.White;
            this.panel_top.BackColor = Color.LightBlue;
        }

        private void picture_start_Click(object sender, EventArgs e)
        {
            if (menu.LaunchStartScreen())
                DesactivateForm();
        }

        private void picture_clientes_Click(object sender, EventArgs e)
        {
            if (menu.LaunchClienteScreen())
                DesactivateForm();
        }

        private void picture_consultas_Click(object sender, EventArgs e)
        {
            if (menu.LaunchConsultaScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        private void picture_facturas_Click(object sender, EventArgs e)
        {
            if (menu.LaunchFacturaScreen(Utils.State.NONE))
                DesactivateForm();
        }

        private void picture_ajustes_Click(object sender, EventArgs e)
        {
            menu.Disconnect();
        }

        #endregion

        #region DataGridEmpleados

        private void CellPainting_empleados(object sender, DataGridViewCellPaintingEventArgs e)
        {
            controller.paintDataGridView_Empleados(e);
        }

        private void CellContentClick_empleados(object sender, DataGridViewCellEventArgs e)
        {
            Utils.State aux_state = Utils.State.NONE;
            EmpleadoEN emp = controller.getStateScreen_Empleados(e, ref aux_state);

            if (emp != null)
                if (menu.LaunchEmpleadoScreen(aux_state, emp))
                    DesactivateForm();
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

        private void picture_desconectar_admin_Click(object sender, EventArgs e)
        {
            menu.Disconnect();
        }

        #endregion
    }
}
