using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public string sesionUsuario;//especide de sesion de usuario

        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           MascotaCEN cen = new MascotaCEN();

            bool chip=false;

            try
            {

                if(comboBox1.SelectedIndex.Equals(0)){
                    chip=true;
                }
                
                SexoEnum sexo = new SexoEnum();
                TamanyoMascotaEnum tam = new TamanyoMascotaEnum();

                if (m_sexo.SelectedIndex.Equals(0))
                {
                    sexo = SexoEnum.Macho;
                }
                else
                {
                    sexo = SexoEnum.Hembra;
                }


                if (comboBox3.SelectedIndex.Equals(0))
                {
                    tam = TamanyoMascotaEnum.XS;
                }
                else if(comboBox3.SelectedIndex.Equals(1))
                {
                    tam=TamanyoMascotaEnum.S;

                }else if(comboBox3.SelectedIndex.Equals(2))
                {
                    tam=TamanyoMascotaEnum.M;

                }else if(comboBox3.SelectedIndex.Equals(3))
                {
                    tam=TamanyoMascotaEnum.L;
                
                }else if(comboBox3.SelectedIndex.Equals(3))
                {
                    tam=TamanyoMascotaEnum.XL;
                }


                cen.New_(m_nombre.Text.ToString(), m_raza.Text.ToString(), sexo, Convert.ToInt32(m_peso.Text.ToString()), m_especie.Text.ToString(), Convert.ToDateTime(m_fecha_nac.Text.ToString()),tam, M_clienteDNI.Text.ToString(), m_color.Text.ToString(), chip, "");
                MessageBox.Show("Mascota añadido Correctamente");
                FormAddEmpleado.ActiveForm.Close();
                Form2 f2 = new Form2();
                f2.Activate();
                f2.Visible = true;

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                err_add.Visible = true;

            }

            if (m_sexo.Enabled.Equals(false))
            {

                ClienteCEN cenCliente = new ClienteCEN();

                try
                {

                    cenCliente.New_(tb_dni.Text.ToString(), tb_nombre.Text.ToString(), tb_apellidos.Text.ToString(), tb_direccion.Text.ToString(), tb_tel.Text.ToString(), tb_localidad.Text.ToString(), comboBox2.Text.ToString(), tb_cp.Text.ToString(), null);
                    MessageBox.Show("Cliente Creado Correctamente");
                    FormAddEmpleado.ActiveForm.Close();
                    Form2 f2 = new Form2();
                    f2.sesionUsuario = sesionUsuario; //sesion usuario
                    f2.Activate();
                    f2.Visible = true;

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                    err_add.Text = "*Error al Añadir Cliente";
                    err_add.Visible = true;

                }



            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Close();
            Form2 f2 = new Form2(); 
            f2.sesionUsuario = sesionUsuario; //sesion usuario
            f2.Activate();
            f2.Visible = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void m_fecha_nac_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
