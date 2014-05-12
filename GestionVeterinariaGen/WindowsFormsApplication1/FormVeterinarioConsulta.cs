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
    public partial class FormVeterinarioConsulta : Form
    {

        public string ID = "CONSULTA";
        public ScreenControllerVeterinario menu;

        private FormVeterinarioConsultaController controller;

        public FormVeterinarioConsulta(ScreenControllerVeterinario menu)
        {
            this.menu = menu;
            InitializeComponent();
            controller = new FormVeterinarioConsultaController(this);
        }


        #region IO

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
        #endregion

        private void FormConsultaVeterinario_Load(object sender, EventArgs e)
        {

        }

        private void label_tratamientos_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void picture_inicio_veterinario_Click(object sender, EventArgs e)
        {
            if (menu.LaunchStartScreen())
                DesactivateForm();
        }

        private void picture_consulta_veterinario_Click(object sender, EventArgs e)
        {
            //añadir launchConsultasScreen
            if (menu.LaunchConsultaScreen())
              DesactivateForm();
        }
    }
}
