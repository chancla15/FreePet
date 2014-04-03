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

        public string sesionUsuario;//especide de sesion de usuario

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
            f2.sesionUsuario = sesionUsuario; //sesion usuario
            f2.Activate();
            f2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex.Equals(1)){
            //añadir Recepcionista
            RecepcionistaCEN cen = new RecepcionistaCEN();

            try{
                float sueldo = float.Parse(tb_sueldo.Text.ToString());
                cen.New_(tb_dni.Text.ToString(), tb_nombre.Text.ToString(), tb_apellidos.Text.ToString(), tb_direccion.Text.ToString(), tb_tel.Text.ToString(), tb_localidad.Text.ToString(), comboBox2.Text.ToString(), tb_cp.Text.ToString(), sueldo, tb_pass.Text.ToString());
                MessageBox.Show("Recepcionista Creado Correctamente");
                FormAddEmpleado.ActiveForm.Close();
                Form2 f2 = new Form2();
                f2.sesionUsuario = sesionUsuario; //sesion usuario
                f2.Activate();
                f2.Visible = true;

            }catch (Exception ex){
                System.Console.WriteLine(ex);
                err_add.Visible = true;

            }

            }else{

             //añadir Vteterinario
            VeterinarioCEN cen = new VeterinarioCEN();

            try{
                float sueldo = float.Parse(tb_sueldo.Text.ToString());
                cen.New_(tb_dni.Text.ToString(), tb_nombre.Text.ToString(), tb_apellidos.Text.ToString(), tb_direccion.Text.ToString(), tb_tel.Text.ToString(), tb_localidad.Text.ToString(),comboBox2.Text.ToString(), tb_cp.Text.ToString(), sueldo, tb_pass.Text.ToString(),Convert.ToInt32(tb_colegiado.Text.ToString()));
                MessageBox.Show("Veterinario Creado Correctamente");
                FormAddEmpleado.ActiveForm.Close();
                Form2 f2 = new Form2();
                f2.sesionUsuario = sesionUsuario; //sesion usuario
                f2.Activate();
                f2.Visible = true;

            }catch (Exception ex){
                System.Console.WriteLine(ex);
                err_add.Visible = true;

            }

            }

        }

        private void FormAddEmpleado_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tb_dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tb_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(1))
            {

                label17.Visible = false;
                tb_colegiado.Visible = false;

            }
            else
            {

                label17.Visible = true;
                tb_colegiado.Visible = true;

            }
        }
    }
}
