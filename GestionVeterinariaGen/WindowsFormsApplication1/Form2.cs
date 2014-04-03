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
    public partial class Form2 : Form
    {
        public string sesionUsuario;//especide de sesion de usuario

        public Form2()
        {
            InitializeComponent();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form1 f1 = new Form1();
            f1.Activate();
            f1.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            FormAddEmpleado f3 = new FormAddEmpleado();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
            ((TextBox)f3.Controls["textBox1"]).Enabled = false;
            ((TextBox)f3.Controls["textBox2"]).Enabled = false;
            ((TextBox)f3.Controls["textBox3"]).Enabled = false;
            ((TextBox)f3.Controls["textBox4"]).Enabled = false;
            ((TextBox)f3.Controls["textBox5"]).Enabled = false;
            ((TextBox)f3.Controls["textBox6"]).Enabled = false;
            ((TextBox)f3.Controls["textBox7"]).Enabled = false;
            ((TextBox)f3.Controls["textBox8"]).Enabled = false;
            ((TextBox)f3.Controls["textBox9"]).Enabled = false;
            ((TextBox)f3.Controls["textBox10"]).Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form4 f3 = new Form4();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form4 f3 = new Form4();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            FormAddEmpleado f3 = new FormAddEmpleado();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            FormAddEmpleado f3 = new FormAddEmpleado();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            FormAddEmpleado f3 = new FormAddEmpleado();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
            ((TextBox)f3.Controls["textBox1"]).Enabled = false;
            ((TextBox)f3.Controls["textBox2"]).Enabled = false;
            ((TextBox)f3.Controls["textBox3"]).Enabled = false;
            ((TextBox)f3.Controls["textBox4"]).Enabled = false;
            ((TextBox)f3.Controls["textBox5"]).Enabled = false;
            ((TextBox)f3.Controls["textBox6"]).Enabled = false;
            ((TextBox)f3.Controls["textBox7"]).Enabled = false;
            ((TextBox)f3.Controls["textBox8"]).Enabled = false;
            ((TextBox)f3.Controls["textBox9"]).Enabled = false;
            ((TextBox)f3.Controls["textBox10"]).Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            FormAddEmpleado f3 = new FormAddEmpleado();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form4 f3 = new Form4();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
            ((TextBox)f3.Controls["textBox1"]).Enabled = false;
            ((TextBox)f3.Controls["textBox2"]).Enabled = false;
            ((TextBox)f3.Controls["textBox3"]).Enabled = false;
            ((TextBox)f3.Controls["textBox4"]).Enabled = false;
            ((TextBox)f3.Controls["textBox5"]).Enabled = false;
            ((TextBox)f3.Controls["textBox6"]).Enabled = false;
            ((TextBox)f3.Controls["textBox7"]).Enabled = false;
            ((TextBox)f3.Controls["textBox8"]).Enabled = false;
            ((TextBox)f3.Controls["textBox9"]).Enabled = false;
            ((TextBox)f3.Controls["textBox10"]).Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            FormAddEmpleado f3 = new FormAddEmpleado();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            FormAddEmpleado f3 = new FormAddEmpleado();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
            ((TextBox)f3.Controls["textBox1"]).Enabled = false;
            ((TextBox)f3.Controls["textBox2"]).Enabled = false;
            ((TextBox)f3.Controls["textBox3"]).Enabled = false;
            ((TextBox)f3.Controls["textBox4"]).Enabled = false;
            ((TextBox)f3.Controls["textBox5"]).Enabled = false;
            ((TextBox)f3.Controls["textBox6"]).Enabled = false;
            ((TextBox)f3.Controls["textBox7"]).Enabled = false;
            ((TextBox)f3.Controls["textBox8"]).Enabled = false;
            ((TextBox)f3.Controls["textBox9"]).Enabled = false;
            ((TextBox)f3.Controls["textBox10"]).Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

            Form2.ActiveForm.Close();
            FormAddEmpleado f3 = new FormAddEmpleado();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
            ((TextBox)f3.Controls["textBox1"]).Enabled = false;
            ((TextBox)f3.Controls["textBox2"]).Enabled = false;
            ((TextBox)f3.Controls["textBox3"]).Enabled = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e){
            //borrar el listBox1 
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            String buscar = textBox1.Text.ToString();

            listBox1.Items.Add("Adolfito hitler");
            listBox1.Items.Add("JoseMari Ansar");
            listBox1.Items.Add("ZetaParo");
            listBox1.Items.Add("Maria Rajao");

            switch (comboBox1.SelectedIndex)
            {

                case 0://CLIENTE
                    ClienteCEN cen_c = new ClienteCEN();

                    tabControl1.SelectedTab = tabPage1;
                    break;
                case 1://MASCOTA
                    MascotaCEN cen_m = new MascotaCEN();

                    tabControl1.SelectedTab = tabPage2;
                    break;
                case 2://VETERINARIO
                    EmpleadoCEN cen_v = new EmpleadoCEN();

                    tabControl1.SelectedTab = tabPage3;
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            //Sacar los datos del usuario con el uso de la variable global
            UsuarioCEN user_cen = new UsuarioCEN();
            UsuarioEN datosUsuario = user_cen.DameUsuarioPorDNI(sesionUsuario);

            //Sacar el trabajo que desenpeña el trabajador
            //Es veterinaio? si no lo es será recepcionista
            VeterinarioCEN vet_cen = new VeterinarioCEN();
            VeterinarioEN vet_en = vet_cen.DameVetarinarioPorOID(sesionUsuario);

            if (vet_en != null){
                //Cuando sea veterinario oculto
                panel1.Visible = false;
                label5.Visible = false;
                tabPage3.Parent = null;
            }

            label1.Text = "Bienvenido " + datosUsuario.Nombre;
        }
    }
}
