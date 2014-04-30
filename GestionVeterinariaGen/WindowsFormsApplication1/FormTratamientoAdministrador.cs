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
    public partial class FormTratamientoAdministrador : Form
    {
        /** El controlador */
        private FormTratamientoAdministradorController controller;

        /**
         * Constructor de clase
         * @param session
         */
        public FormTratamientoAdministrador(FormLoginDataSessionTicket session)
        {
            Activate();
            this.Visible = true;
            InitializeComponent();
            controller = new FormTratamientoAdministradorController(session, this);
        }

        /**
         * Cuando se pulsa el boton buscar
         */
        private void btn_buscar_Click(object sender, EventArgs e) {
            controller.BuscarFactura();
        }

        /**
         * Cuando se clickea la opcion añadir
         */
        private void btn_add_Click(object sender, EventArgs e) {
            //Hide();
            //COMO AÑADO??
            //new FormTratamientoAdministrado(sessionData);
        }

        /** 
         * Cuando se clickea la opcion del datagrid
         * @param e el dato pulsado
         */
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            char action = '\0';
            string tratamiento = controller.getStateScreen(e, action);

            if (tratamiento != "")
            {

            }
        }
    }
}
