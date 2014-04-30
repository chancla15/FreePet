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
    public partial class FormStartAdministrador : Form
    {
        /** El controlador */
        private FormStartAdministradorController controller;

        /**
         * El contructor de form
         * @param session el ticket de sesion 
         */
        public FormStartAdministrador(FormLoginDataSessionTicket session) {
            Activate();
            this.Visible = true;
            InitializeComponent();
            controller = new FormStartAdministradorController(session, this);
        }

        /**
         * Button buscar
         */
        private void btn_buscar_Click(object sender, EventArgs e) {
            controller.Buscar();
        }

        /**
         * Boton Anaydir
         */
        private void btn_add_Click(object sender, EventArgs e) {
            Hide();
            new FormPerfil(controller.sessionData);
        }

        /**
         * Cuando se clicka el el datagrid
         * @param e la columna/fila pulsada
         */
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            char action = '\0';
            string empleado = controller.getStateScreen(e, action);

            if (empleado != "")
            {
                //Hide();
                //new FormEmpleadoAdministrador(controller.sessionData);
            }
        }
    }
}
