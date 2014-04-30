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
    public partial class FormStartVeterinario : Form
    {
        /** El controlador */
        private FormStartVeterinarioController controller;

        /**
         * Constructor
         * @param session el ticket de sesion
         */
        public FormStartVeterinario(FormLoginDataSessionTicket session)
        {
            Activate();
            this.Visible = true;
            InitializeComponent();
            controller= new FormStartVeterinarioController(session, this);
        }

        /**
         * Cuando seleccionamos una fecha del calendario
         */
        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
