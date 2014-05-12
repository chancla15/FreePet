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
            label1.Text = "";

            Boolean login = sessionData.Login(text_user.Text, text_pass.Text);
         
            if (login) {
                Hide();
                Console.WriteLine("Empezar con pantalla: " + sessionData.tipo + " " + sessionData.TOKEN_SESSION );
                if (sessionData.tipo == "Recepcionista")
                    new ScreenControllerRecepcionista(sessionData);
                //new FormRecepcionistaAdministradorInicio(sessionData);
                else if (sessionData.tipo == "Veterinario")
                    new ScreenControllerVeterinario(sessionData);
                else if (sessionData.tipo == "Administrador")
                    new ScreenControllerRecepcionista(sessionData);
                    
                    
                    //new FormRecepcionistaAdministradorInicio(sessionData);
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

        }
    }
}
