using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;


namespace WindowsFormsApplication1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoCEN cen = new EmpleadoCEN();

            String User, Pass;
            User = textBox1.Text.ToString();
            Pass = GestionVeterinariaGenNHibernate.Utils.Util.GetEncondeMD5(textBox2.Text.ToString());

            if (cen.Login(User, Pass)){
               
                FormLogin.ActiveForm.Hide(); //ocultamos pantalla login
                FormStartScreen f2 = new FormStartScreen();
                f2.sesionUsuario = User;
                f2.Activate();
                f2.Visible = true; //mostramos la pantalla de gestion
            }else{

                label1.Text = "Datos incorrectos";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin.ActiveForm.Close();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormLogin.ActiveForm.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          


        }
    }
}
