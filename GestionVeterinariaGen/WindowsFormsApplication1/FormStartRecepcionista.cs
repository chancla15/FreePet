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
    public partial class FormStartRecepcionista : Form
    {
        /** El controlador */
        FormStartRecepcionistaController controller;

        /**
         * Constructor de la clase
         * @param sesion datos de la sesion
         */
        public FormStartRecepcionista(FormLoginDataSessionTicket sesion)
        {
            Activate();
            this.Visible = true;
            InitializeComponent();
            controller = new FormStartRecepcionistaController(this, sesion);
        }

        /**
         * Cuando se pulsa el boton de buscar
         */
        private void btn_buscar_Click(object sender, EventArgs e)   {
            controller.buscarClientes();
        }

        /**
         * ???
         */
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuarioTableAdapter.FillBy(this.FormStartRecepcionistaDataSet.Usuario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        /**
         * ???
         */
        private void dataGridView1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGrid_clientes.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGrid_clientes.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\close-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dataGrid_clientes.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dataGrid_clientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;

            }


            if (e.ColumnIndex >= 0 && this.dataGrid_clientes.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGrid_clientes.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\edit-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dataGrid_clientes.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dataGrid_clientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }
        }

        /**
         * Comprueba el tipo de dato que selecciona el usuario de la tabla
         */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            char action = '\0';
            string cliente = controller.getStateScreen(e, action);

            if(cliente!="") {
                 //Hide();
                 //new FormUsuarioRecepcionista(controller.sessionData, cliente, action);
            }
        }

        /**
         * Carga la pantalla para introducir un nuevo usuario
         */
        private void btn_add_Click(object sender, EventArgs e)
        {
            Hide();
            //new FormPerfilCliente(controller.sessionData);
        }

        private void label_consultas_Click(object sender, EventArgs e)
        {
            Hide();
            new FormConsultaRecepcionista(this.controller.sessionData);
        }

        private void label_facturas_Click(object sender, EventArgs e)
        {
            Hide();
            new FormFacturaRecepcionista(this.controller.sessionData);
        }

    }
}
