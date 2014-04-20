using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Collections;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class Mascotas : Form
    {

        public string sesionUsuario;//especide de sesion de usuario

        public Mascotas()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            String buscar = textBox1.Text.ToString();//String a buscar

            MascotaCEN cen_m = new MascotaCEN();

            IList<MascotaEN> en_mas_nombre = cen_m.DameMascotaPorNombre(buscar);

            if (en_mas_nombre.Count == 0)
            {

                MessageBox.Show("La búsqueda no ha producido ningún resultado");

            }
            else
            {

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();

                if (dataGridView1.Rows.Count != 0)
                {
                    dataGridView1.Rows.Clear();
                }

                for (int x = 0; x < en_mas_nombre.Count; x++)
                {
                    dataGridView1.Rows.Add(en_mas_nombre[x].IdMascota,en_mas_nombre[x].Nombre,en_mas_nombre[x].Cliente.DNI);
                }

            }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                string mascotaEliminar = "";

                mascotaEliminar = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                //Form2.ActiveForm.Close();
                FormAnimal f4 = new FormAnimal();
                f4.sesionUsuario = sesionUsuario;//sesion usuario
                f4.idEliminarMascota = mascotaEliminar;
                f4.Activate();
                f4.Visible = true;

                ((TextBox)f4.Controls["m_id"]).Enabled = false;
                ((TextBox)f4.Controls["m_nombre"]).Enabled = false;
                ((TextBox)f4.Controls["m_raza"]).Enabled = false;
                ((ComboBox)f4.Controls["m_sexo"]).Enabled = false;
                ((TextBox)f4.Controls["m_especie"]).Enabled = false;
                ((TextBox)f4.Controls["m_color"]).Enabled = false;
                ((DateTimePicker)f4.Controls["m_fecha_nac"]).Enabled = false;
                ((TextBox)f4.Controls["m_peso"]).Enabled = false;
                ((ComboBox)f4.Controls["comboBox2"]).Enabled = false;
                ((ComboBox)f4.Controls["comboBox3"]).Enabled = false;
                ((ComboBox)f4.Controls["comboBox1"]).Enabled = false;


                }

            if (this.dataGridView1.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {

                string mascmod = "";

                mascmod = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                Form2.ActiveForm.Close();
                FormAnimal f4 = new FormAnimal();
                f4.sesionUsuario = sesionUsuario;//sesion usuario
                f4.idModificarMascota = mascmod;
                f4.Activate();
                f4.Visible = true;
     
            }

        }

        private void dataGridView1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGridView1.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\close-animal.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }


            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGridView1.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\edit-animal.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }
        }

        private void Mascotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionVeterinariaGenNHibernateDataSet1.Mascota' Puede moverla o quitarla según sea necesario.
            this.mascotaTableAdapter.Fill(this.gestionVeterinariaGenNHibernateDataSet1.Mascota);

            UsuarioCEN user_cen = new UsuarioCEN();
            UsuarioEN datosUsuario = user_cen.DameUsuarioPorDNI(sesionUsuario);

            Text = "Bienvenido " + datosUsuario.Nombre;
            label2.Text = sesionUsuario;
            label1.Text = datosUsuario.Nombre;
            label3.Text = "RECEPCIONISTA";
            DateTime date3 = DateTime.Now;
            label4.Text = date3.ToString();

            try
            {

                System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\" + datosUsuario.DNI.ToString() + ".png", System.IO.FileMode.Open);
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

        private void anyadirmascota_Click(object sender, EventArgs e)
        {
            FormAnimal f3 = new FormAnimal();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mascotas.ActiveForm.Close();
            Login f1 = new Login();
            f1.Activate();
            f1.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mascotas.ActiveForm.Close();
        }

        private void verPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void verPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil f3 = new Perfil();

            ((TextBox)f3.Controls["tb_nombre"]).Enabled = false;
            ((TextBox)f3.Controls["tb_apellidos"]).Enabled = false;
            ((TextBox)f3.Controls["tb_sueldo"]).Enabled = false;
            ((TextBox)f3.Controls["tb_direccion"]).Enabled = false;
            ((TextBox)f3.Controls["tb_localidad"]).Enabled = false;
            ((TextBox)f3.Controls["tb_sueldo"]).Enabled = false;
            ((TextBox)f3.Controls["tb_dni"]).Enabled = false;
            ((TextBox)f3.Controls["tb_tel"]).Enabled = false;
            ((ComboBox)f3.Controls["comboBox2"]).Enabled = false;
            ((TextBox)f3.Controls["tb_cp"]).Enabled = false;
            ((Button)f3.Controls["bt_modificar"]).Visible = false;
            ((PictureBox)f3.Controls["pictureBox1"]).Enabled = false;

            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void modificarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil f3 = new Perfil();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mascotas.ActiveForm.Close();
            Clientes f3 = new Clientes();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void añadirClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = true;
            FormEmpleadoCliente f3 = new FormEmpleadoCliente();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.anyadirCliente = ok;
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
            ((TextBox)f3.Controls["tb_sueldo"]).Visible = false;
        }

        private void añadirPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAnimal f3 = new FormAnimal();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeGestionVetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe f3 = new AcercaDe();
            f3.Activate();
            f3.Visible = true;
        }

        private void añadirEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = true;
            //Form2.ActiveForm.Close();
            FormEmpleadoCliente f3 = new FormEmpleadoCliente();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.anyadirEmpleado = ok;
            f3.Activate();
            f3.Visible = true;
        }

        private void verEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mascotas.ActiveForm.Close();
            Empleados f3 = new Empleados();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mascotas.ActiveForm.Close();
            Facturas f3 = new Facturas();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void añadirFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = true;
            //Form2.ActiveForm.Close();
            FormFactura f3 = new FormFactura();
            //f3.sesionUsuario = sesionUsuario;//sesion usuario
            //f3.anyadirEmpleado = ok;
            f3.Activate();
            f3.Visible = true;
        }

        private void verConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mascotas.ActiveForm.Close();
            Consultas f3 = new Consultas();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void añadirConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = true;
            //Form2.ActiveForm.Close();
            FormConsulta f3 = new FormConsulta();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            //f3.anyadirConsulta = ok;
            f3.Activate();
            f3.Visible = true;
        }
    }
}
