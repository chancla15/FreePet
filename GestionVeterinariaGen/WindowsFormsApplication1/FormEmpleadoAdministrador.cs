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
    public partial class FormEmpleadoAdministrador : Form
    {
        /** El controlador */
        private FormEmpleadoAdministradorController controller;
       
        /**
         * El contructor de clase
         * @param session el ticket de sesion
         */
        public FormEmpleadoAdministrador(FormLoginDataSessionTicket session)
        {
            Activate();
            this.Visible = true;
            InitializeComponent();
            controller = new FormEmpleadoAdministradorController(session, this);
        }

        private void FormEmpleadoAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
