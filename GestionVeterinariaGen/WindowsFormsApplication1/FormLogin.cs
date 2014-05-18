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
using WindowsFormsApplication1.Properties;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;


namespace WindowsFormsApplication1
{
    public partial class FormLogin : Form
    {
        /**
         * Esta contendra los datos del login para guardarlos y asi no tener que cargarlos
         * cada vez que cambiemos de pantalla
         * Cuando se desloguea esto se borra con metodo clear
         */
        private FormLoginDataSessionTicket sessionData;

        /**
         * Constructor
         */
        public FormLogin()
        {
            Activate();
            this.Visible = true;
            InitializeComponent();
            sessionData = new FormLoginDataSessionTicket();
        }

        /**
         * Boton aceptar
         */
        private void btn_accept_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            label1.Text = "";

            Boolean login = sessionData.Login(text_user.Text, text_pass.Text);
         
            if (login) {
                Hide();
                if (sessionData.tipo == "Recepcionista")
                    new ScreenControllerRecepcionista(sessionData);
                else if (sessionData.tipo == "Veterinario")
                    new ScreenControllerVeterinario(sessionData);
                else if (sessionData.tipo == "Administrador")
                    new ScreenControllerAdministrador(sessionData);
            
            }
            
            label1.Text = "Datos incorrectos";
            Clear();
        }

        /**
         * Sale de la aplicacion
         */
        private void btn_salir_Click(object sender, EventArgs e)
        {
            FormLogin.ActiveForm.Close();
            Application.Exit();
            
        }

        /**
         * Funcion para limpiar la pantalla de login
         */
        public void Clear()
        {
            text_user.Text = "";
            text_pass.Text = "";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
