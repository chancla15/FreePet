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
///////
namespace WindowsFormsApplication1
{
    public partial class FormAddEmpleado : Form
    {

        //especide de sesion de usuario
        public string sesionUsuario;
        
        //Sesion para eliminar
        public bool eliminarUsuario;
        public string dniEliminarUsuario;

        //Sesion para modificar
        public bool modificarUsuario;
        public string dniModificarUsuario;

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

            if (comboBox1.SelectedIndex.Equals(1))
            {
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
                err_add.Text = "*Error al Añadir Recepcionista";
                err_add.Visible = true;

            }

            }

            if (comboBox1.SelectedIndex.Equals(0))
            {

                //añadir Vteterinario
                VeterinarioCEN cen = new VeterinarioCEN();

                try
                {
                    float sueldo = float.Parse(tb_sueldo.Text.ToString());
                    cen.New_(tb_dni.Text.ToString(), tb_nombre.Text.ToString(), tb_apellidos.Text.ToString(), tb_direccion.Text.ToString(), tb_tel.Text.ToString(), tb_localidad.Text.ToString(), comboBox2.Text.ToString(), tb_cp.Text.ToString(), sueldo, tb_pass.Text.ToString(), Convert.ToInt32(tb_colegiado.Text.ToString()));
                    MessageBox.Show("Veterinario Creado Correctamente");
                    FormAddEmpleado.ActiveForm.Close();
                    Form2 f2 = new Form2();
                    f2.sesionUsuario = sesionUsuario; //sesion usuario
                    f2.Activate();
                    f2.Visible = true;

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                    err_add.Text = "*Error al Añadir Veterinario";
                    err_add.Visible = true;

                }

            }

        }

        private void FormAddEmpleado_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            bt_despedir.Visible = false;//por defecto oculto.
            bt_modificar.Visible = false;
            if (eliminarUsuario == true){
                bt_despedir.Visible = true;
                mostrarDatos(dniEliminarUsuario);

            }
            else if (modificarUsuario == true)
            {
                
                mostrarDatos(dniModificarUsuario);
                bt_aceptar.Visible = false;//ocultamos el boton de despedir
                bt_modificar.Visible = true;
            }
 
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

        private void mostrarDatos(String dni){
            EmpleadoCEN cen = new EmpleadoCEN();
            EmpleadoEN en = cen.DameEmpleadoPorOID(dni);

            tb_dni.Text = en.DNI;
            tb_nombre.Text = en.Nombre;
            tb_pass.Text = en.Password;
            tb_confPass.Text = en.Password;
            tb_sueldo.Text = en.Sueldo.ToString();
            tb_localidad.Text = en.Localidad;
            tb_tel.Text = en.Telefono;
            tb_apellidos.Text = en.Apellidos;
            tb_direccion.Text = en.Direccion ;
            tb_cp.Text = en.Cp;
            comboBox2.SelectedItem = en.Provincia;
            tb_colegiado.Visible = false;
            label14.Visible = false;
            comboBox1.Visible = false;
            label17.Visible = false;
            bt_aceptar.Visible = false;
        }

        //Mostrar Datos Cliente
        private void mostrarDatosCliente(String dni)
        {
            ClienteCEN cen = new ClienteCEN();
            ClienteEN en = cen.DameClientePorOID(dni);

            tb_dni.Text = en.DNI;
            tb_nombre.Text = en.Nombre;
            //tb_pass.Text = en.Password;
            //tb_confPass.Text = en.Password;
            //tb_sueldo.Text = en.Sueldo.ToString();
            tb_localidad.Text = en.Localidad;
            tb_tel.Text = en.Telefono;
            tb_apellidos.Text = en.Apellidos;
            tb_direccion.Text = en.Direccion;
            tb_cp.Text = en.Cp;
            comboBox2.SelectedItem = en.Provincia;

            tb_colegiado.Visible = false;
            label14.Visible = false;
            comboBox1.Visible = false;
            label17.Visible = false;
            bt_aceptar.Visible = false;
        }

        private void bt_despedir_Click(object sender, EventArgs e)
        {
            UsuarioCEN cen = new UsuarioCEN();

            if ( MessageBox.Show("Seguro que desea despedir a este empleado","Despedir usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK )
            cen.Destroy(dniEliminarUsuario);
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {   
            EmpleadoCEN cen2 = new EmpleadoCEN();
            
            cen2.Modify(tb_dni.Text.ToString(),tb_nombre.Text.ToString(),tb_apellidos.Text.ToString(),tb_direccion.Text.ToString(),tb_direccion.Text.ToString(),tb_localidad.Text.ToString(),comboBox2.SelectedItem.ToString(),tb_cp.Text.ToString(), Convert.ToInt32(tb_sueldo.Text.ToString()), tb_pass.Text.ToString()); 
        }
    }
}
