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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoCEN cen = new EmpleadoCEN();

            String User, Pass;
            User = textBox1.Text;
            Pass = textBox2.Text;

            if (cen.Login(User, Pass)){

                Form1.ActiveForm.Hide(); //ocultamos pantalla login
                Form2 f2 = new Form2();
                f2.Activate(); 
                f2.Visible = true; //mostramos la pantalla de gestion
            }
            else{

                label3.Text = "Datos incorrectos";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
