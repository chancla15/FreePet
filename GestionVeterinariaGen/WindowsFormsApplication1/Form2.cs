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
            ((ComboBox)f3.Controls["comboBox1"]).Visible = false;
            ((Label)f3.Controls["label14"]).Visible = false;
            ((Label)f3.Controls["label17"]).Visible = false;
            ((TextBox)f3.Controls["tb_colegiado"]).Visible = false;
            
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
            ((ComboBox)f3.Controls["comboBox1"]).Visible = false;
            ((Label)f3.Controls["label14"]).Visible = false;
            ((Label)f3.Controls["label17"]).Visible = false;
            ((TextBox)f3.Controls["tb_colegiado"]).Visible = false;
            ((TextBox)f3.Controls["tb_pass"]).Visible = false;
            ((Label)f3.Controls["label11"]).Visible = false;
            ((Label)f3.Controls["label10"]).Visible = false;
            ((TextBox)f3.Controls["tb_confPass"]).Visible = false;
            ((Label)f3.Controls["label13"]).Visible = false;
            ((TextBox)f3.Controls["tb_sueldo"]).Visible = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            FormAddEmpleado f3 = new FormAddEmpleado();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
            ((ComboBox)f3.Controls["comboBox1"]).Visible = false;
            ((Label)f3.Controls["label14"]).Visible = false;
            ((Label)f3.Controls["label17"]).Visible = false;
            ((TextBox)f3.Controls["tb_colegiado"]).Visible = false;
            ((TextBox)f3.Controls["tb_pass"]).Visible = false;
            ((Label)f3.Controls["label11"]).Visible = false;
            ((Label)f3.Controls["label10"]).Visible = false;
            ((TextBox)f3.Controls["tb_confPass"]).Visible = false;
            ((Label)f3.Controls["label13"]).Visible = false;
            ((TextBox)f3.Controls["tb_sueldo"]).Visible = false;

            //desabilitar
            ((TextBox)f3.Controls["tb_dni"]).Enabled = false;
            ((TextBox)f3.Controls["tb_nombre"]).Enabled = false;
            ((TextBox)f3.Controls["tb_apellidos"]).Enabled = false;
            ((TextBox)f3.Controls["tb_direccion"]).Enabled = false;
            ((TextBox)f3.Controls["tb_pass"]).Enabled = false;
            ((TextBox)f3.Controls["tb_tel"]).Enabled = false;
            ((TextBox)f3.Controls["tb_localidad"]).Enabled = false;
            ((TextBox)f3.Controls["tb_confPass"]).Enabled = false;
            ((TextBox)f3.Controls["tb_cp"]).Enabled = false;
            ((ComboBox)f3.Controls["comboBox2"]).Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            FormAddEmpleado f3 = new FormAddEmpleado();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;

            ((ComboBox)f3.Controls["comboBox1"]).Visible = false;
            ((Label)f3.Controls["label14"]).Visible = false;
            ((Label)f3.Controls["label17"]).Visible = false;
            ((TextBox)f3.Controls["tb_colegiado"]).Visible = false;
            ((Label)f3.Controls["label13"]).Visible = false;
            ((TextBox)f3.Controls["tb_sueldo"]).Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form4 f3 = new Form4();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;

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

        }

        private void label7_Click(object sender, EventArgs e)
        {

            Form2.ActiveForm.Close();
            FormAddEmpleado f3 = new FormAddEmpleado();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;

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
