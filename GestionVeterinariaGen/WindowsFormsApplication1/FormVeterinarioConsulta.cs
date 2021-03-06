﻿/* 
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
    public partial class FormVeterinarioConsulta : Form
    {

        public string ID = "CONSULTA";
        public ScreenControllerVeterinario menu;

        private MascotaEN mascota;
        private ConsultaEN consulta;
        public int contador = 0;

        private FormVeterinarioConsultaController controller;

        public FormVeterinarioConsulta(ScreenControllerVeterinario menu)
        {
            Activate();
            this.menu = menu;
            InitializeComponent();
            controller = new FormVeterinarioConsultaController(this);
        }


        #region IO

       
        public void DesactivateForm()
        {
            Hide();
        }

        #endregion

        public void changeState(MascotaEN mascota, ConsultaEN consulta)
        {
            controller.cargarDatosMascotaConsulta(mascota,consulta);
        }


        private void FormConsultaVeterinario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'formAdministradorTratamientoDataSet.Tratamiento' Puede moverla o quitarla según sea necesario.
            this.tratamientoTableAdapter.Fill(this.formAdministradorTratamientoDataSet.Tratamiento);

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

        private void button_realizar_Click(object sender, EventArgs e)
        {
            //realizar consulta
            controller.addTratamientos();
            MessageBox.Show("Consulta realizada ");
            if (menu.LaunchStartScreenVeterinario())
                DesactivateForm();
        }

        private void listBox_addTratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_ConsultaPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_tratamientos.Visible = false;
        }

        private void textBox_tam_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            panel_tratamientos.Visible = true;

            if (contador > 0)
            {
                int indice = Convert.ToInt32(dataGridView_ConsultaPet.CurrentRow.Index);
                DataGridViewRow fila = dataGridView_ConsultaPet.Rows[indice];
                String s = Convert.ToString(fila.Cells[0].Value);

                //controlar repetido
                if(!listBox_addTratamiento.Items.Contains(s))
                    listBox_addTratamiento.Items.Add(s);
            }

            contador++;
        }

        private void button_cerrartrat_Click(object sender, EventArgs e)
        {
            contador = 0;
            panel_tratamientos.Visible = false;
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            listBox_addTratamiento.Items.Remove(listBox_addTratamiento.SelectedItem);
        }

        private void button_anular_Click(object sender, EventArgs e)
        {
            if (menu.LaunchStartScreenVeterinario())
                DesactivateForm();
        }

        #region MenuSuperior

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

        private void picture_desconectar_veterinario_Click(object sender, EventArgs e)
        {
            menu.Disconnect();
        }

        #endregion

    }
}
