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
    public partial class FormVeterinarioInicio : Form
    {
        public string ID = "INICIO";
        public ScreenController menu;
        private MascotaEN mascota;

        /** El controlador */
        private FormVeterinarioInicioController controller;

        /**
         * Constructor
         * @param session el ticket de sesion
         */
        public FormVeterinarioInicio(ScreenController menu)
        {
            this.menu = menu;
            InitializeComponent();
            controller = new FormVeterinarioInicioController(this);
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
            controller.mostrarConsultas(Calendar.SelectionRange.Start);
        }

        private void dataGrid_consultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //mascota = dataGrid_consultas.TabIndexChanged();
            //int indice = dataGrid_consultas.Columns[e.RowIndex].Index;
            //Console.WriteLine("Cerdo :"+dataGrid_consultas.Columns[indice].Selected);
            DataGridViewRow fila = dataGrid_consultas.Rows[e.RowIndex];
            String s = Convert.ToString(fila.Cells["Nombre"].Value);
            MessageBox.Show(s);
            if (menu.LaunchConsultaScreenVeterinario(mascota))
                DesactivateForm();
        }

        private void CellPainting_veterinario(object sender, DataGridViewCellPaintingEventArgs e)
        {
            controller.paintDataGridView(e);
        }


        private void picture_inicio_veterinario_Click(object sender, EventArgs e)
        {
            if (menu.LaunchStartScreenVeterinario())
                DesactivateForm();
        }

        private void picture_consulta_veterinario_Click(object sender, EventArgs e)
        {
            if (menu.LaunchConsultaScreenVeterinario(mascota))
                DesactivateForm();
        }

        private void picture_ajustes_veterinario_Click(object sender, EventArgs e)
        {
            //Solucion Provisional
            menu.sessionData.Disconnect();
            this.Hide();
        }
    }
}
