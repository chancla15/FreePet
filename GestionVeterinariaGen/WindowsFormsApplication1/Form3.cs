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
    public partial class Form3 : Form
    {
        public string sesionUsuario;//especide de sesion de usuario
        public Form3()
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
            Form3.ActiveForm.Close();
            Form2 f2 = new Form2();
            f2.sesionUsuario = sesionUsuario;
            f2.Activate();
            f2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (sesionUsuario != null)
            {
                mostrarDatos(sesionUsuario);
                
            }
            else
            {
                Form3.ActiveForm.Close();
                Form2 f2 = new Form2();
                f2.Activate();
                f2.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Modificar

            //Ver
        }

        private void mostrarDatos(String dni)
        {
            EmpleadoCEN cen = new EmpleadoCEN();
            EmpleadoEN en = cen.DameEmpleadoPorOID(dni);

            tb_dni.Text = en.DNI;
            tb_nombre.Text = en.Nombre;
            tb_sueldo.Text = en.Sueldo.ToString();
            tb_localidad.Text = en.Localidad;
            tb_tel.Text = en.Telefono;
            tb_apellidos.Text = en.Apellidos;
            tb_direccion.Text = en.Direccion;
            tb_cp.Text = en.Cp;
            comboBox2.SelectedItem = en.Provincia;
            //tb_colegiado.Visible = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            EmpleadoCEN cen2 = new EmpleadoCEN();

            EmpleadoEN en2=cen2.DameEmpleadoPorOID(tb_dni.Text);

            string pass=en2.Password;

            cen2.Modify(tb_dni.Text.ToString(), tb_nombre.Text.ToString(), tb_apellidos.Text.ToString(), tb_direccion.Text.ToString(), tb_direccion.Text.ToString(), tb_localidad.Text.ToString(), comboBox2.SelectedItem.ToString(), tb_cp.Text.ToString(), Convert.ToInt32(tb_sueldo.Text.ToString()),"1");

        }
    }
}
