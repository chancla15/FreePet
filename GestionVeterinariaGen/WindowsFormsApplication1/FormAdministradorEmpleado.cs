using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormAdministradorEmpleado : Form
    {

        #region Variables

        private FormAdministradorEmpleadoController controller = null;
        public Utils.State state = Utils.State.NONE;
        public string ID = "EMPLEADO";
        public ScreenControllerAdministrador menu = null;

        #endregion

        #region Constructor

        public FormAdministradorEmpleado(ScreenControllerAdministrador menu) 
        {
            Activate();
            this.menu = menu;
            InitializeComponent();
            controller=new FormAdministradorEmpleadoController(this);
        }

        public void changeState(Utils.State st, EmpleadoEN emp)
        {
           // controller.ClearForm();
            state = st;
            if (state == Utils.State.MODIFY || state == Utils.State.DESTROY)
            {
                tb_dni.Enabled = false;
                controller.loadData(emp);

                if (state == Utils.State.DESTROY) {
                    btn_eliminar_Click(new object(), new EventArgs());
                }
            }
        }

        #endregion

        #region IO

        public void DesactivateForm()
        {
            Hide();
        }

        private void EnableForm(Boolean typ)
        {
            tb_dni.Enabled = typ;
            tb_nombre.Enabled = typ;
            tb_apellidos.Enabled = typ;
            tb_direccion.Enabled = typ;
            tb_provincia.Enabled = typ;
            tb_localidad.Enabled = typ;
            tb_cp.Enabled = typ;
            tb_tel.Enabled = typ;

            tb_sueldo.Enabled = typ;
            tb_tipo.Enabled = typ;

            btn_buscar_dni.Enabled = typ;
            btn_erase.Enabled = typ;
            btn_guardar.Enabled = typ;
            btn_eliminar.Enabled = typ;
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
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (state == Utils.State.MODIFY)
            {
                EnableForm(false);
                if (MessageBox.Show("Seguro que desea despedir a este empleado", "Despedir usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    state = Utils.State.DESTROY;
                    controller.ProcesarInformacion();
                    controller.ClearForm();
                }
                else
                    state = Utils.State.MODIFY;

                EnableForm(true);
            }
        }

        private void btn_buscar_dni_Click(object sender, EventArgs e)
        {
            /*if ((state == Utils.State.NONE || state == Utils.State.NEW) && menu.LaunchStartScreen())
                DesactivateForm();*/
            if ((state == Utils.State.NONE || state == Utils.State.NEW) && controller.showData())
            {
                tb_dni.Enabled=false;
                state = Utils.State.MODIFY;
            }
            else
            {
                state = Utils.State.NONE;
            }

            
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            if (state == Utils.State.MODIFY)
                tb_dni.Enabled = true;

            controller.ClearForm();
            state = Utils.State.NONE;
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            controller.clickInPhoto();
        }

        private void picture_desconectar_admin_Click(object sender, EventArgs e)
        {
            menu.Disconnect();
        }

        // Tipo
        private void tb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.clickInTipo();
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

        private void picture_tratamientos_Click(object sender, EventArgs e)
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
