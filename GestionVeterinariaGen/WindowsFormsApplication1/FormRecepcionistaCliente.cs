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

        public FormRecepcionistaClienteController controller = null;
        public Utils.State state = Utils.State.NONE;
        public string ID = "CLIENTE";
        public ScreenControllerRecepcionista menu = null;
        public Boolean haBorradoCliente = false;
        
        #endregion

        #region Constructor

        public FormRecepcionistaCliente(ScreenControllerRecepcionista menu)
        {
            this.menu = menu;
            InitializeComponent();
            controller = new FormRecepcionistaClienteController(this);
        }

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
        
        public void ActivateForm()
        {
            Activate();
            this.Visible = true;
        }

        public void DesactivateForm()
        {
            this.Visible = false;

            if (haBorradoCliente)
            {
                controller.cargarDatosCliente(menu.clienteCompartido);
                haBorradoCliente = false;
            }
        }

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

        private void btn_buscar_Click(object sender, EventArgs e) {
            state = Utils.State.NEW;
            controller.Buscar();
        }

        private void btn_anaydir_Click(object sender, EventArgs e)
        {
            if(menu.LaunchMascotaScreen(Utils.State.NEW, null))
                    DesactivateForm();
        }

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

        private void btn_eliminar_no_Click(object sender, EventArgs e)
        {
            state = Utils.State.MODIFY;
            EnableForm(true);
        }

        private void btn_eliminar_si_Click(object sender, EventArgs e)
        {
            state = Utils.State.DESTROY;
            EnableForm(true);
            controller.ProcesarInformacion();
            state = Utils.State.NONE;
            menu.CargarClienteCompartidoRecepcionista(null);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EnableForm(false);
        }

        private void btn_buscar_dni_Click(object sender, EventArgs e)
        {
            if ((state==Utils.State.NONE || state==Utils.State.NEW) && menu.LaunchStartScreen())
                DesactivateForm();
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            haBorradoCliente = true;
            text_dni.Enabled = true;
            controller.ClearForm();
            controller.Buscar();
            state = Utils.State.NONE;
        }

        private void button_facturas_Click(object sender, EventArgs e)
        {
            if (state == Utils.State.MODIFY)
            {
                if(menu.LaunchFacturaScreen(Utils.State.MODIFY))
                     menu.f_cliente.DesactivateForm();
            }
        }

        #endregion

        #region DataGridView_Mascotas

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e){
            //controller.paintDataGrid(e);
        }

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

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_clientes.BackColor = Color.White;
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
            if(menu.LaunchConsultaScreen(Utils.State.NONE, null))
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

        #region SubMenuSuperior

        private void panel_clientes_opcion_Paint(object sender, PaintEventArgs e)
        {
            this.picture_cliente_opcion_cliente.BackColor = Color.White;
            this.panel_clientes_opcion.BackColor = Color.LightCyan;
        }

        private void picture_cliente_opcion_mascota_Click(object sender, EventArgs e)
        {
            if (menu.LaunchMascotaScreen(Utils.State.NEW, null))
                DesactivateForm();
        }

        private void picture_cliente_opcion_cliente_Click(object sender, EventArgs e){
            picture_clientes_Click(sender, e);
        }

        #endregion
    }
}
