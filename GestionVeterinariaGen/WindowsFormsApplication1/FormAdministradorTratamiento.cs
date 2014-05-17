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

        private FormAdministradorTratamientoController controller = null;
        public Utils.State state = Utils.State.NONE;
        public string ID = "TRATAMIENTO";
        public ScreenControllerAdministrador menu = null;

        #endregion

        #region Constructor

        public FormAdministradorTratamiento(ScreenControllerAdministrador menu)
        {
            this.menu = menu;
            InitializeComponent();
            controller = new FormAdministradorTratamientoController(this);
        }

        public void changeState(Utils.State st, TratamientoEN tra)
        {
            state = st;
            if (state == Utils.State.MODIFY || state == Utils.State.DESTROY)
            {
                text_nombre.Enabled = false;
                controller.cargarDatosTratamiento(tra);

                if (state == Utils.State.DESTROY)
                {
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
        }

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

        private void btn_buscar_id_Click(object sender, EventArgs e)
        {
            state = Utils.State.NEW;
            controller.Buscar();
        }

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

        private void dataGrid_tratamientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Utils.State st = Utils.State.NONE;
            TratamientoEN tratamiento = controller.getDataGridViewState(e,ref st);

            if (tratamiento != null)
                changeState(st, tratamiento);
        }

        #endregion

        #region MenuSuperior

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_empleado.BackColor = Color.White;
            this.panel_top.BackColor = Color.LightBlue;
        }

        private void picture_start_Click(object sender, EventArgs e)
        {
            if (menu.LaunchStartScreen())
                DesactivateForm();
        }

        private void picture_empleados_Click(object sender, EventArgs e)
        {
            if (menu.LaunchEmpleadoScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        private void picture_tratatamiento_Click(object sender, EventArgs e)
        {
            if (menu.LaunchTratamientoScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        private void picture_desconectar_Click(object sender, EventArgs e)
        {
            menu.Disconnect();
        }

        #endregion
    }
}
