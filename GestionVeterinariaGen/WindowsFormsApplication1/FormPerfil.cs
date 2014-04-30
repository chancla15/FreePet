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
    public partial class FormPerfil : Form
    {

        /** El controlador de esta vista */
        private FormPerfilController controller;

        /** Controlador de sesion */
        public FormLoginDataSessionTicket sessionData;

        /**
         * Contructor de clase
         */
        public FormPerfil(FormLoginDataSessionTicket log) {
            
            sessionData = log;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (sessionData != null)
            {
                mostrarDatos(sessionData.ToString());
                
            }
            else
            {
                FormPerfil.ActiveForm.Close();
                FormStartRecepcionista f2 = new FormStartRecepcionista(sessionData);
                f2.Activate();
                f2.Visible = true;
            }
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

            try
            {

                System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\" + en.DNI.ToString() + ".png", System.IO.FileMode.Open);
                pictureBox1.Image = Image.FromStream(fs);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                fs.Close();

            }
            catch (Exception ex)
            {
                System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\sinFoto.png", System.IO.FileMode.Open);
                pictureBox1.Image = Image.FromStream(fs);
                fs.Close();
            }
        }

        

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            EmpleadoCEN cen2 = new EmpleadoCEN();

            EmpleadoEN en2=cen2.DameEmpleadoPorOID(tb_dni.Text);

            string pass=en2.Password;

            cen2.Modify(tb_dni.Text.ToString(), tb_nombre.Text.ToString(), tb_apellidos.Text.ToString(), tb_direccion.Text.ToString(), tb_direccion.Text.ToString(), tb_localidad.Text.ToString(), comboBox2.SelectedItem.ToString(), tb_cp.Text.ToString(), Convert.ToInt32(tb_sueldo.Text.ToString()),"1");

            //GUARDAMOS LA IMAGEN
            pictureBox1.Image.Save(Environment.CurrentDirectory + @"\" + tb_dni.Text.ToString() + ".png");


            MessageBox.Show("Perfil Modificado Correctamente");
            Close();

            //ACTUALIZAR AL MODIFICAR
            FormStartRecepcionista f2 = new FormStartRecepcionista(sessionData);
            //f2.sesionUsuario = sesionUsuario; //sesion usuario
            f2.Activate();
            f2.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es .PNG");
            }
        }
    }
}
