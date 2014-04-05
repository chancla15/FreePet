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
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public string sesionUsuario;//especide de sesion de usuario

        //Sesion para eliminar
        public bool eliminarMascota;
        public string idEliminarMascota;

        //Sesion para modificar
        public bool modificarMascota;
        public string idModificarMascota;

        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MascotaCEN cen = new MascotaCEN();

            if (MessageBox.Show("Seguro que desea eliminar esta mascota", "Eliminar mascota", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                cen.Destroy(idEliminarMascota);
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
            m_sexo.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

            ClienteCEN cen_c = new ClienteCEN();
            IList<ClienteEN> en_cli_nombre = cen_c.BuscarClientePorNombre("");
            
            for (int c=0;c<en_cli_nombre.Count;c++){

                comboBox2.Items.Add(en_cli_nombre[c].DNI + " - " + en_cli_nombre[c].Nombre + " " + en_cli_nombre[c].Apellidos);
            }

            comboBox2.SelectedIndex = 0;

            bt_eliminar.Visible = false;
            bt_modificar.Visible = false;
            bt_anyadir.Visible = false;

            if (eliminarMascota == true)
            {
                mostrarDatosMascota(idEliminarMascota);
                bt_eliminar.Visible = true;
                
            }
            
            if (modificarMascota == true)
            {
                mostrarDatosMascota(idModificarMascota);
                bt_modificar.Visible = true;
                
            }

            if (modificarMascota != true && eliminarMascota != true)
            {

                bt_anyadir.Visible = true;

            }


        }

        private void m_fecha_nac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mostrarDatosMascota(String id)
        {
            MascotaCEN cen = new MascotaCEN();
            MascotaEN en = cen.BuscarMascotaPorOID(id);

            //m_id.Text = en.IdMascota;
            m_nombre.Text = en.Nombre;
            m_raza.Text = en.Raza;
            m_sexo.Text = en.Sexo.ToString();
            m_peso.Text = en.Peso.ToString();
            m_especie.Text = en.Especie;
            m_color.Text = en.Color;
            m_fecha_nac.Value = en.FNacimiento.Value.Date;
            comboBox1.SelectedItem = en.Microchip;
            comboBox2.SelectedItem = en.Cliente;
            comboBox3.Text = en.Tamanyo.ToString();

            //comboBox1.Visible = false;
            //label17.Visible = false;
            //bt_modificar.Visible = false;
            //bt_eliminar.Visible = ;
            //bt_anyadir.Visible = true;
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            MascotaCEN cen = new MascotaCEN();

            bool chip = false;

            if (comboBox1.SelectedIndex.Equals(0))
            {
                chip = true;
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
            else if (comboBox3.SelectedIndex.Equals(1))
            {
                tam = TamanyoMascotaEnum.S;

            }
            else if (comboBox3.SelectedIndex.Equals(2))
            {
                tam = TamanyoMascotaEnum.M;

            }
            else if (comboBox3.SelectedIndex.Equals(3))
            {
                tam = TamanyoMascotaEnum.L;

            }
            else if (comboBox3.SelectedIndex.Equals(3))
            {
                tam = TamanyoMascotaEnum.XL;
            }

            try
            {

            cen.Modify(idModificarMascota, m_nombre.Text.ToString(), m_raza.Text.ToString(),sexo, Convert.ToInt32(m_peso.Text.ToString()), m_especie.Text.ToString(), Convert.ToDateTime(m_fecha_nac.Value.Date.ToString()), tam, m_color.Text.ToString(),chip, "");
                MessageBox.Show("Mascota Modificada Correctamente");
                Form4.ActiveForm.Close();
                Form2 f2 = new Form2();
                f2.sesionUsuario = sesionUsuario; //sesion usuario
                f2.Activate();
                f2.Visible = true;

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                err_add.Text = "*Error al Modificar Mascota";
                err_add.Visible = true;

            }
            
        }

        private void bt_anyadir_Click(object sender, EventArgs e)
        {

            MascotaCEN cen = new MascotaCEN();

            bool chip = false;

            if (comboBox1.SelectedIndex.Equals(0))
            {
                chip = true;
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
            else if (comboBox3.SelectedIndex.Equals(1))
            {
                tam = TamanyoMascotaEnum.S;

            }
            else if (comboBox3.SelectedIndex.Equals(2))
            {
                tam = TamanyoMascotaEnum.M;

            }
            else if (comboBox3.SelectedIndex.Equals(3))
            {
                tam = TamanyoMascotaEnum.L;

            }
            else if (comboBox3.SelectedIndex.Equals(3))
            {
                tam = TamanyoMascotaEnum.XL;
            }

            MascotaCEN cen_m = new MascotaCEN();
            IList<MascotaEN> en_m = cen_m.ContadorMascotas();

            string clienteDNI = comboBox2.SelectedItem.ToString();

            clienteDNI = clienteDNI.Substring(0, 9);


            int num_id = (en_m.Count + 1);
            String id = num_id.ToString();

            try
            {
                cen.New_(id.ToString(), m_nombre.Text.ToString(), m_raza.Text.ToString(), sexo, Convert.ToInt32(m_peso.Text.ToString()), m_especie.Text.ToString(), Convert.ToDateTime(m_fecha_nac.Value.Date.ToString()), tam, clienteDNI.ToString(), m_color.Text.ToString(), chip, "");
                MessageBox.Show("Mascota añadida Correctamente");
                Form4.ActiveForm.Close();
                Form2 f2 = new Form2();
                f2.sesionUsuario = sesionUsuario; //sesion usuario
                f2.Activate();
                f2.Visible = true;

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                err_add.Text = "Error al añadir Mascota";
                err_add.Visible = true;

            }
        }
    }
}
