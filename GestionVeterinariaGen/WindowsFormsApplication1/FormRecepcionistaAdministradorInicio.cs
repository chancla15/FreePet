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
    public partial class FormRecepcionistaAdministradorInicio : Form
    {
        /** El controlador */
        FormRecepcionistaAdministradorInicioController controller;

        /**
         * Constructor de la clase
         * @param sesion datos de la sesion
         */
        public FormRecepcionistaAdministradorInicio(FormLoginDataSessionTicket sesion)
        {
            ActivateForm();
            InitializeComponent();
            controller = new FormRecepcionistaAdministradorInicioController(this, sesion);
  

            //IMPLEMENTAR PARATE CONTROLADOR ADMINSITRADOR.........

            //....
            //....
            //....




                //mostraria la otra barra
                //sino muestra la normal de recepcionista
            
        }

        /** Activa el formulario */
        public void ActivateForm()
        {
            Activate();
            this.Visible = true;
        }

        /** Desactiva el formulario */
        public void DesactivateForm()
        {
            this.Visible = false;
        }

        /**
         * Cuando se pulsa el boton de buscar
         */
        private void btn_buscar_Click(object sender, EventArgs e)   {
            controller.buscar();
        }

        /**
         * Pinta el tamaño de las celdas
         */
        private void dataGridView1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            controller.paintDataGridView(e);
        }

        /**
         * Comprueba el tipo de dato que selecciona el usuario de la tabla
         */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Utils.State st = Utils.State.NONE;

            ClienteEN cliente = controller.getStateScreen(e, ref st);

            if(cliente!=null) {
                 Hide();
                 new FormRecepcionistaCliente(controller.sessionData, cliente, st);
            }
        }

        /**
         * Carga la pantalla para introducir un nuevo usuario
         */
        private void btn_add_Click(object sender, EventArgs e)
        {
            Hide();

            if (controller.sessionData.tipo.Equals("Administrador"))
            {
                new FormAdministradorEmpleado(controller.sessionData);
            }
            else if(controller.sessionData.tipo.Equals("Recepcionista"))
            {
                new FormRecepcionistaCliente(controller.sessionData, null, Utils.State.NEW);
            }
        }




























        ////////////// MENU SUPERIOR !!!!!!!!!!!!!!!!!!!!!!!
        ////////////// MENU SUPERIOR !!!!!!!!!!!!!!!!!!!!!!!
        ////////////// MENU SUPERIOR !!!!!!!!!!!!!!!!!!!!!!!



        /**
         * Pinta el panel superior
         */
        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_start.BackColor = Color.White;
            this.panel_top.BackColor = Color.LightBlue;
        }

        /**
         * Cuando se slecciona la opcion start
         */
        private void picture_start_Click(object sender, EventArgs e)
        {

        }

        /**
         * Cuando se slecciona la opcion clientes
         */
        private void picture_clientes_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaCliente(controller.sessionData, null, Utils.State.NONE);
        }

        /**
         * Cuando se slecciona la opcion consultas
         */
        private void picture_consultas_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaConsulta(controller.sessionData, Utils.State.NONE);
        }

        /**
         * Cuando se slecciona la opcion facturas
         */
        private void picture_facturas_Click(object sender, EventArgs e)
        {
            Hide();
            //new FormRecepcionistaFactura(controller.sessionData);
        }

        /**
         * Cuando se slecciona la opcion ajustes
         */
        private void picture_ajustes_Click(object sender, EventArgs e)
        {
            //Esto solo le da a un formulario
            //donde puede cambiar algunos datos personales, la constraseña la foto y desconectarse
        }
    }
}
