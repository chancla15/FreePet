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
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class FormRecepcionistaFactura : Form
    {
        #region Variables

        public FormRecepcionistaFacturaController controller;
        private ScreenControllerRecepcionista menu;
        public Utils.State state = Utils.State.NONE;
        public string ID = "FACTURA";
        public Boolean haBorradoCliente = false;

        #endregion

        #region Constructor

        public FormRecepcionistaFactura(ScreenControllerRecepcionista menu)
        {
            this.menu = menu;
            InitializeComponent();
            controller = new FormRecepcionistaFacturaController(this);
        }

        public void changeState(Utils.State st)
        {
            //AQUI COMPRUEBO EL ESTADO ACTUAL DE LA PANTALLA, PORQUE ESTE METODO SOLO SE EJECUTARA
            //CADA VEZ QUE HAGAMOS UNA ACCION REFERIDA CON AÑADIR, MODIFICAR O ELIMINAR EN LA PANTALLA
            //TANTO SI PINCHAMOS EN EL DATAGRID COMO SI NOS LA INFORMACION DE OTRA PANTALLA

            state = st;

            if (state == Utils.State.MODIFY)
                text_dni.Enabled = false;
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
                text_dni.Enabled=haBorradoCliente = false;
            }
        }

        #endregion

        #region Botones

        private void btn_buscar_dni_Click(object sender, EventArgs e)
        {
            if (menu.LaunchStartScreen())
                DesactivateForm();
        }

        private void btn_pagar_si_Click(object sender, EventArgs e)
        {
            controller.PagarFactura();   //Si pulsamos Si en la alerta pagamos la factura
            controller.AlertaPagar(false, -1); //Desactiva la alerta de pagar factura
        }

        private void btn_pagar_no_Click(object sender, EventArgs e)
        {
            controller.AlertaPagar(false, -1); //Desactiva la alerta de pagar factura
        }

        private void btn_trata_ok_Click(object sender, EventArgs e)
        {
            panel_tratamientos.Visible = false;
        }
        
        #endregion

        #region DataGridView

        private void dataGridView1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            controller.paintDataGrid(e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                FacturaEN factura = controller.getScreenState(e, ref state);
                if (factura != null)
                {
                    //Activa la alerta de pagar factura
                    if (dataGridFacturas.Columns[e.ColumnIndex].Name.Equals("Pagar"))
                        controller.AlertaPagar(true, e.RowIndex);
                    //Activa el panel que muestra los tratamientos
                    if (dataGridFacturas.Columns[e.ColumnIndex].Name.Equals("Tratamiento"))
                        controller.ExportarFacturaOMostrarTratamientos(e.RowIndex, "Tratamiento");
                    //Exporta la factura en formato PDF
                    if (dataGridFacturas.Columns[e.ColumnIndex].Name.Equals("Exportar"))
                        controller.ExportarFacturaOMostrarTratamientos(e.RowIndex, "Exportar");
                }
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

        }

        private void picture_ajustes_Click(object sender, EventArgs e)
        {
            menu.Disconnect();
        }

        #endregion
    }
}
