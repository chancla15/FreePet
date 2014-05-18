/* 
    FreePet. OpenSource Software Veterinarian Management
    Copyright (C) 2014  Jesus Manresa Parres

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

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
        private ConsultaEN consulta;

        /** El controlador */
        private FormVeterinarioInicioController controller;

        /**
         * Constructor
         * @param session el ticket de sesion
         */
        public FormVeterinarioInicio(ScreenController menu)
        {
            Activate();
            this.menu = menu;
            InitializeComponent();
            controller = new FormVeterinarioInicioController(this);
        }

        #region IO

        public void DesactivateForm()
        {
            Hide();
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
            
            DataGridViewRow fila = dataGrid_consultas.Rows[e.RowIndex];
            String s = Convert.ToString(fila.Cells["Nombre"].Value);
            String num = Convert.ToString(fila.Cells["Numero"].Value);
            IList<MascotaEN> m = Utils._MascotaCEN.DameMascotaPorNombre(s);
            mascota = m[0];

            ConsultaEN c = Utils._ConsultaCEN.DameConsultaPorOID(Convert.ToInt32(num));

            if (menu.LaunchConsultaScreenVeterinario(mascota,c))
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
            if (menu.LaunchConsultaScreenVeterinario(mascota, consulta))
                DesactivateForm();
        }

        private void picture_ajustes_veterinario_Click(object sender, EventArgs e)
        {
            //Solucion Provisional
            menu.sessionData.Disconnect();
            this.Hide();
        }

        private void FormVeterinarioInicio_Load(object sender, EventArgs e)
        {
            
        }
    }
}
