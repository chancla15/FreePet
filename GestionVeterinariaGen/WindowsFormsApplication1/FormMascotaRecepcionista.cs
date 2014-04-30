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
    public partial class FormMascotaRecepcionista : Form
    {
        /** El controlador */
        private FormMascotaRecepcionistaController controller;

        /** 
         * Constructor de clase
         * @param session el ticket de sesion
         */
        public FormMascotaRecepcionista(FormLoginDataSessionTicket session)
        {
            InitializeComponent();
            controller = new FormMascotaRecepcionistaController(session, this);
        }


        /**
         * Cuando se pulsa el boton buscar
         */
        private void btn_buscar_Click(object sender, EventArgs e) {
            controller.Buscar();
        }

        /**
         * Comprueba el elemento seleccionado
         */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            char action = '\0';
            string mascota = controller.getStateScreen(e, action);

            if (mascota != "")
            {
                //Hide();
                //new FormUsuarioRecepcionista(controller.sessionData, cliente, action);
            }
        }

        /**
         * Pinta en pantalla la dataGrid
         */
        private void dataGridView1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGridView1.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\close-animal.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }


            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGridView1.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\edit-animal.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }
        }


        /**
         * Cuando se pulsa el boton añadir
         */
        private void btn_add_Click(object sender, EventArgs e)
        {
            //Anaydir animal
        }

        /**
         * Esta opcion desconecta
         */
        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
            controller.sessionData.Disconnect();
        }

        /**
         * Sale de la aplicacion
         */
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        /**
         *  Para ver las mascotas
         */
        private void verPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
            //new FormMascotaRecepcionista(controller.sessionData);
        }

        /**
         * Va al perfil del usuario
         */
        private void verPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        private void acercaDeGestionVetToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        private void verConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
            new FormConsultaRecepcionista(controller.sessionData);
        }

        /**
         * Al menu de añadir consultas  ESTO ES LO MISMO...
         */
        private void añadirConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
