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
    public partial class FormVeterinarioInicio : Form
    {
        public string ID = "INICIO";
        public ScreenControllerVeterinario menu;
        /** El controlador */
        private FormVeterinarioInicioController controller;

        /**
         * Constructor
         * @param session el ticket de sesion
         */
        public FormVeterinarioInicio(ScreenControllerVeterinario menu)
        {
            this.menu = menu;
            InitializeComponent();
            controller= new FormVeterinarioInicioController(this);
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


        /**
         * Cuando seleccionamos una fecha del calendario
         */
        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            controller.mostrarConsultas();
        }

        private void dataGrid_consultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            //if (menu.LaunchConsultaScreen())
              //  DesactivateForm();
        }

        private void picture_ajustes_veterinario_Click(object sender, EventArgs e)
        {

        }
    }
}
