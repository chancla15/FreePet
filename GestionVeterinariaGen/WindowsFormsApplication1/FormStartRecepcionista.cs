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
            //Hide();
            //new FormUsuarioRecepcionista(controller.sessionData);
        }

        /**
         * Esta opcion desconecta
         */
        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e) {
            salirToolStripMenuItem_Click(sender, e);
            controller.sessionData.Disconnect();
        }

        /**
         * Sale de la aplicacion
         */
        private void salirToolStripMenuItem_Click(object sender, EventArgs e){
            ActiveForm.Close();
        }

        /**
         *  Para ver las mascotas
         */
        private void verPacientesToolStripMenuItem_Click(object sender, EventArgs e) {
            salirToolStripMenuItem_Click(sender, e);
            //new FormMascotaRecepcionista(controller.sessionData);
        }

        /**
         * Va al perfil del usuario
         */
        private void verPerfilToolStripMenuItem_Click(object sender, EventArgs e) {
            salirToolStripMenuItem_Click(sender, e);
            //new FormUsuarioRecepcionista(controller.sessionData);
        }
        

        /**
         * 
         */
        private void modificarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
            //new FormUsuarioRecepcionista(controller.sessionData, 'M');
        }

        /**
         * ????
         */
        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTA OPCION DEBERIA ESTAR DESACTIVADA AQUI
        }

        /**
         * Va al formulario de añadir usuarios
         */
        private void añadirClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
            //new FormUsuarioRecepcionista(controller.sessionData);
        }

        /**
         * Va al formulario de añadir mascotas
         */
        private void añadirPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
            //new FormMascotaRecepcionista(controller.sessionData);
        }

        /**
         * ???
         */
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        /**
         * Va al menu de acercaDe
         */
        private void acercaDeGestionVetToolStripMenuItem_Click(object sender, EventArgs e){
            new AcercaDe();
        }

        /**
         * ???
         */
        private void verEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTA OPCION DEBERIA ESTAR DESACTIVADA AQUI
            //USUARIO ADMIN
        }

        /**
         * ???
         */
        private void añadirEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTA OPCION DEBERIA ESTAR DESACTIVADA AQUI
            //USUARIO ADMIN
        }

        /**
         * Va al menu de facturas pendientes
         */
        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
            //new FormFacturaRecepcionista(controller.sessionData);
        }

        /**
         * Abrir el menu de consultas   ESTO ES LO MISMO...
         */
        private void verConsultasToolStripMenuItem_Click(object sender, EventArgs e) {
            salirToolStripMenuItem_Click(sender, e);
            new FormConsultaRecepcionista(controller.sessionData);
        }

        /**
         * Al menu de añadir consultas  ESTO ES LO MISMO...
         */
        private void añadirConsultasToolStripMenuItem_Click(object sender, EventArgs e) {
            salirToolStripMenuItem_Click(sender, e);
            new FormConsultaRecepcionista(controller.sessionData);
        }

        /**
         * Va a la pantalla de añadir facturas
         */
        private void añadirFacturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
            //new FormFacturaRecepcionista(controller.sessionData);
        }
    }
}
