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
    public partial class FormConsultaVeterinario : Form
    {
        private FormConsultaVeterinarioController controller;

        public FormConsultaVeterinario(FormLoginDataSessionTicket session)
        {
            Activate();
            this.Visible = true;
            InitializeComponent();
            controller = new FormConsultaVeterinarioController(session, this);
        }

        private void FormConsultaVeterinario_Load(object sender, EventArgs e)
        {

        }
    }
}
