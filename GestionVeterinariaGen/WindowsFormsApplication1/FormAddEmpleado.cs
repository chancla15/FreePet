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
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormAddEmpleado : Form
    {
        public FormAddEmpleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAddEmpleado.ActiveForm.Close();
            Form2 f2 = new Form2();
            f2.Activate();
            f2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //añadir Empleados
            EmpleadoCEN cen = new EmpleadoCEN();
            try{
              

                //cen.New_(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString(), textBox5.Text.ToString(), textBox6.Text.ToString(), textBox7.Text.ToString(), textBox7.Text.ToString(), textBox8.Text.ToString(), 10, textBox10.Text.ToString());
            }catch (Exception ex){
                System.Console.WriteLine(ex);
            }
        }
    }
}
