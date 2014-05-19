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
            Activate();
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
        
        public void DesactivateForm()
        {
            Hide();
            if (haBorradoCliente)
            {
                state= Utils.State.MODIFY;
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
            panel_recepcionista.Enabled = typ;
            btn_anaydir.Enabled = typ;

            alerta_eliminar.Enabled = !typ;
            alerta_eliminar.Visible = !typ;
            btn_eliminar_no.Enabled = !typ;
            btn_eliminar_si.Enabled = !typ;
        }

        #endregion

        #region Botones

        private void foto_cliente_Click(object sender, EventArgs e)
        {
            controller.clickInPhoto();
        }

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
            menu.CargarClienteCompartido(null);
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
            state= Utils.State.NEW;
            haBorradoCliente = true;
            text_dni.Enabled = true;
            controller.clienteEN = null;
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

            if (e.ColumnIndex >= 0 && dataGridView.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = dataGridView.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\ver.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left, e.CellBounds.Top);

                dataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                dataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;

            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Utils.State aux_state = Utils.State.NONE;
            ClienteEN aux_cliente = null;
            MascotaEN msc = controller.getDataGridViewState(e, ref aux_state, ref aux_cliente);

            if (aux_cliente != null)
                menu.CargarClienteCompartido(aux_cliente);

            if (msc != null)
                if (menu.LaunchMascotaScreen(aux_state, msc))
                    DesactivateForm();       
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
