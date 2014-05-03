using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormRecepcionistaCliente : Form
    {
        /** El controlador */
        private FormRecepcionistaClienteController controller;

        /** EL tipo de accion, ADD,MOD,DEL */
        private char actionType;

        /**
         * Constructor
         * @param session el ticket de sesion
         * @param showType el tipo de accion
         */
        public FormRecepcionistaCliente(FormLoginDataSessionTicket session, char showType)
        {
            Activate();
            this.Visible = true;
            InitializeComponent();
            controller = new FormRecepcionistaClienteController(session, this);
            this.actionType = showType;

            dataGridView.AutoResizeColumns();
//            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        /**
        * Constructor para modificar y 
        * @param session el ticket de sesion
        * @param cliente el cliente a modificar/eliminar
        * @param showType el tipo de accion
        */
        public FormRecepcionistaCliente(FormLoginDataSessionTicket session, string cliente, char showType)
        {
            Activate();
            this.Visible = true;
            InitializeComponent();
            controller = new FormRecepcionistaClienteController(session, this);
            this.actionType = showType;
            controller.loadData(cliente,'\0');
            text_dni.Enabled = false;

            if (showType == 'E')
                EnableForm(false);
        }

        /**
         * Pinta panel superior menu
         */
        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_clientes.BackColor = Color.White;
            this.panel_top.BackColor = Color.LightBlue;
        }

        /**
         * Cuando se slecciona la opcion start
         */
        private void picture_start_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaAdministradorInicio(controller.sessionData);
        }

        /**
         * Cuando se slecciona la opcion clientes
         */
        private void picture_clientes_Click(object sender, EventArgs e)
        { }

        /**
         * Cuando se slecciona la opcion consultas
         */
        private void picture_consultas_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaConsulta(controller.sessionData);
        }

        /**
         * Cuando se slecciona la opcion facturas
         */
        private void picture_facturas_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaFactura(controller.sessionData);
        }

        /**
         * Cuando se slecciona la opcion ajustes
         */
        private void picture_ajustes_Click(object sender, EventArgs e)
        {
            //Esto solo le da a un formulario
            //donde puede cambiar algunos datos personales, la constraseña la foto y desconectarse
        }


        /**
         * Pinta el panel segun la pantalla
         */
        private void panel_clientes_opcion_Paint(object sender, PaintEventArgs e)
        {
            this.picture_cliente_opcion_cliente.BackColor = Color.White;
            this.panel_clientes_opcion.BackColor = Color.LightCyan;
        }

        /**
         * Si seleccionamos la opcion mascotas del panel clientes
         */
        private void picture_cliente_opcion_mascota_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaMascota(controller.sessionData, null, 'A');
        }

        /**
         *  Si seleccionamos la opcion cliente del panel clientes
         */
        private void picture_cliente_opcion_cliente_Click(object sender, EventArgs e)
        {}

        /**
         * Si buscamos una mascota
         */
        private void btn_buscar_Click(object sender, EventArgs e) {
            controller.Buscar();
        }

        /**
         * Si anaydimos una mascota nueva
         */
        private void btn_anaydir_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaMascota(controller.sessionData, null , 'A');
        }

        /**
        * Pinta el tamaño de las celdas
        */
        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGridView.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\close-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left, e.CellBounds.Top);

                //this.dataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                //this.dataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;

            }


            if (e.ColumnIndex >= 0 && this.dataGridView.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGridView.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\edit-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left, e.CellBounds.Top);

                //this.dataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                //this.dataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }
        }

        /**
         * Comprueba donde se ha pulsado
         */
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            char action = '\0';
            string msc = controller.getDataGridViewState(e, ref action);

            //Ir a formulario mascotas
            if (msc != "" && action == 'S')
            {
                controller.loadData(msc, 'S');
            }
            else if (msc != "" && (action == 'M' || action == 'E'))
            {
                Hide();
                new FormRecepcionistaMascota(controller.sessionData, msc, action);
            }
        }

        /**
         * Cuando se selecciona el boton guardar
         */
        private void btn_guardar_Click(object sender, EventArgs e) {
            controller.GuardaModificaEliminaCliente(actionType);
            EnableForm(true);
            actionType = 'A';
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mascotaTableAdapter.FillBy(this.formRecepcionistaCliente_DataSet.Mascota);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        /**
         * Cuadno se pulsa el boton de cancelar eliminacion
         */
        private void btn_eliminar_no_Click(object sender, EventArgs e) {
            EnableForm(true);
            actionType = 'M';
        }

        /**
         * Cuando se pulsa el boton de proceder a eliminar
         */
        private void btn_eliminar_si_Click(object sender, EventArgs e) {
            EnableForm(true);
            actionType = 'E';
            controller.GuardaModificaEliminaCliente(actionType);
        }

        /**
         * Pone typ todos los elementos del formulario menos los de eliminar
         * @param typ si estan disponibles o no
         */
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


        /**
         * Cuando se pulsa el boton eliminar principal
         */
        private void btn_eliminar_Click(object sender, EventArgs e) {
            EnableForm(false);
            //Borrar todos los campos del formulario
        }

        /**
         * Si clickea el boton de buscar cliente por dni desde la pantalla cliente
         */
        private void btn_buscar_dni_Click(object sender, EventArgs e) {
            controller.loadData(text_dni.Text,'\0');
        }

        /**
         * Cuando se pulsa el boton erase que es la gomita se borran todos los campos
         */
        private void btn_erase_Click(object sender, EventArgs e)
        {
            text_dni.Enabled = true;
            controller.Clear();
        }
    }
}
