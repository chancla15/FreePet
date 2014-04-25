using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;


namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoCEN cen = new EmpleadoCEN();

            String User, Pass;
            User = textBox1.Text.ToString();
            //Pass = GestionVeterinariaGenNHibernate.Utils.Util.GetEncondeMD5(textBox2.Text.ToString());
            Pass = textBox2.Text.ToString();

            if (User.Equals("") || Pass.Equals(""))
            {
                label1.Text = "Campos Vacios";
            }
            else if (cen.Login(User, Pass))
            {

                Hide(); //ocultamos pantalla login


                //Sacar los datos del usuario con el uso de la variable global
                UsuarioCEN user_cen = new UsuarioCEN();
                UsuarioEN datosUsuario = user_cen.DameUsuarioPorDNI(User);

                //Sacar el trabajo que desenpeña el trabajador
                //Es veterinaio? si no lo es será recepcionista
                VeterinarioCEN vet_cen = new VeterinarioCEN();
                VeterinarioEN vet_en = vet_cen.DameVetarinarioPorOID(User);

                if (vet_en != null)
                {
                    //Cuando sea veterinario oculto cerdo
                    //cerdo
                    Consultas f2 = new Consultas();
                    f2.sesionUsuario = User;
                    f2.Activate();
                    f2.Visible = true; //mostramos la pantalla de gestion
                }
                else
                {
                    //pictureBox1.Visible = true;
                    Clientes f2 = new Clientes();
                    f2.sesionUsuario = User;
                    f2.Activate();
                    f2.Visible = true; //mostramos la pantalla de gestion
                }

            }
            else
            {

                label1.Text = "Datos incorrectos";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login.ActiveForm.Close();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login.ActiveForm.Close();
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          


        }
    }
}
