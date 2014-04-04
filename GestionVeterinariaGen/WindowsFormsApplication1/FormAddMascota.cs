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
    public partial class FormAddMascota : Form
    {
        public string sesionUsuario;//especide de sesion de usuario

        public FormAddMascota()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* MascotaCEN cen = new MascotaCEN();

            try
            {
               
                cen.New_(
                MessageBox.Show("Recepcionista añadido Correctamente");
                FormAddEmpleado.ActiveForm.Close();
                Form2 f2 = new Form2();
                f2.Activate();
                f2.Visible = true;

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                err_add.Visible = true;

            }*/
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAddMascota.ActiveForm.Close();
            FormStartScreen f2 = new FormStartScreen(); 
            f2.sesionUsuario = sesionUsuario; //sesion usuario
            f2.Activate();
            f2.Visible = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
