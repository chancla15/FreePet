/* 
    FreePet. OpenSource Software Veterinarian Management
    Copyright (C) 2014  Jesus Manresa Parres

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

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
            if (b)
            {
                ListaEmpleados.Visible = ListaEmpleados.Enabled =true;
                dataGrid_clientes.SendToBack();
                panel_recepcionista.SendToBack();
                panel_top.BringToFront(); 
                panel_top.Enabled = panel_top.Visible= true;
            }
            else
            {
                dataGrid_clientes.Visible = dataGrid_clientes.Enabled = true;
                dataGrid_clientes.BringToFront();
                panel_top.SendToBack();
                ListaEmpleados.SendToBack();
                panel_recepcionista.BringToFront();
                panel_recepcionista.Visible = panel_recepcionista.Enabled = true;
            }
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

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.panel_top.BackColor = Color.LightBlue;
        }

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
