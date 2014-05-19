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
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Collections;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormRecepcionistaMascota : Form
    {
        #region Variables

        public FormRecepcionistaMascotaController controller = null;
        public Utils.State state = Utils.State.NONE;
        public string ID = "MASCOTA";
        public ScreenControllerRecepcionista menu = null;

        #endregion

        #region Constructor

        public FormRecepcionistaMascota(ScreenControllerRecepcionista menu)
        {
            Activate();
            this.menu = menu;
            InitializeComponent();
            controller = new FormRecepcionistaMascotaController(this);
            text_cliente.Enabled = false;
        }

        public void changeState(Utils.State st, MascotaEN msc)
        {
            state = st;

            if (state == Utils.State.NEW)
                btn_add_NombreMascota_Click(new object(), new EventArgs());

            if(msc!=null)
                controller.cargarDatosMascota(msc);
            
            if (state == Utils.State.DESTROY)
                btn_eliminar_Click(new object(), new EventArgs());

           
        }

        #endregion

        #region I/O_Form

        public void DesactivateForm()
        {
            Hide();
            state = Utils.State.NONE;
        }

        private void EnableForm(bool block)
        {
            text_especie.Enabled = block;
            text_raza.Enabled = block;
            dateTime_fnac.Enabled = block;
            combo_sexo.Enabled = block;
            btn_add_NombreMascota.Enabled = block;
            text_color.Enabled = block;
            combo_nombreAnimal.Enabled = block;
            text_peso.Enabled = block;
            combo_sexo.Enabled = block;
            combo_tamanyo.Enabled = block;
            combo_microchip.Enabled = block;
            btn_anaydir.Enabled = block;
            btn_buscar_cliente.Enabled = block;
            dataGridView.Enabled = block;
            panel_clientes_opcion.Enabled = block;
            panel_recepcionista.Enabled = block;

        }

        #endregion

        #region Botones

        private void picture_foto_Click(object sender, EventArgs e)
        {
            controller.clickInPhoto();
        }

        private void btn_anaydir_Click(object sender, EventArgs e)
        {
            ConsultaEN c= new ConsultaEN();
            c.Mascota= controller.mascotaEN;

            if (menu.LaunchConsultaScreen(Utils.State.NEW, c))
                DesactivateForm();
        }

        private void btn_guardar_Click(object sender, EventArgs e) {
            controller.ProcesarInformacion();
        }

        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            if ((state == Utils.State.NONE || state == Utils.State.NEW || state == Utils.State.MODIFY) && menu.LaunchStartScreen())
                DesactivateForm();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Seguro que desea eliminar a esta mascota", "Eliminar Mascota", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    state = Utils.State.DESTROY;
                    EnableForm(true);
                    controller.ProcesarInformacion();
                    state = Utils.State.NONE;
                    menu.CargarClienteCompartido(null);
                    controller.DevolverMascotaENComboBox();
                }
                else
                {
                    EnableForm(true);
                    state = Utils.State.MODIFY;
                }
          
        }

        private void btn_eliminar_no_Click(object sender, EventArgs e)
        {
            EnableForm(true);
            state = Utils.State.MODIFY;
        }

        private void btn_eliminar_si_Click(object sender, EventArgs e)
        {
            state = Utils.State.DESTROY;
            EnableForm(true);
            controller.ProcesarInformacion();
            state = Utils.State.NONE;
            menu.CargarClienteCompartido(null);
        }

        #endregion

        #region ComboBox_NombreAnimal

        private void btn_add_NombreMascota_Click(object sender, EventArgs e)
        {
            EnableForm(false);
            box_text_nombre_mascota.Text = "";
            box_NombreAnimal.Enabled = true;
            box_NombreAnimal.Visible = true;
        }

        private void box_label_cancelar_Click(object sender, EventArgs e)
        {
            EnableForm(true);
            box_NombreAnimal.Visible = false;
            box_NombreAnimal.Enabled = false;
        }

        private void box_label_aceptar_Click(object sender, EventArgs e)
        {
            string name_msc = box_text_nombre_mascota.Text;

            if (name_msc != "")
            {
                state = Utils.State.NEW;
                controller.cargarDatosMascota(null);
                combo_nombreAnimal.Items.Add(name_msc);
                combo_nombreAnimal.SelectedItem = name_msc;
                EnableForm(true);
                box_NombreAnimal.Visible = false;
                box_NombreAnimal.Enabled = false;
            }
        }

        private void combo_nombreAnimal_SelectedIndexChanged(object sender, EventArgs e) {

                changeState(Utils.State.MODIFY, controller.DevolverMascotaENComboBox());

        }
        
        #endregion

        #region DataGridView

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Utils.State aux_state= Utils.State.NONE;
            ConsultaEN aux_consulta = controller.getStateScreen(e, ref aux_state);

            if (aux_consulta != null)
                if (menu.LaunchConsultaScreen(aux_state, aux_consulta))
                    DesactivateForm();
        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
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

        #region SubMenuSuperior

        private void picture_cliente_opcion_cliente_Click(object sender, EventArgs e){
            picture_clientes_Click(sender, e);
        }

        private void picture_cliente_opcion_mascota_Click(object sender, EventArgs e) {
            if (menu.LaunchMascotaScreen(Utils.State.NEW, null)) 
                DesactivateForm();
        }

        #endregion 

        
    }
}
