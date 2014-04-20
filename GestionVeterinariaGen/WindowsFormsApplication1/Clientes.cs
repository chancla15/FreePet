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
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Clientes : Form
    {

        public string sesionUsuario;//especide de sesion de usuario

        public Clientes()
        {
            InitializeComponent();
        }
        

        private void Clientes_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'gestionVeterinariaGenNHibernateDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.FillBy(this.gestionVeterinariaGenNHibernateDataSet.Usuario);

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

        private void button4_Click(object sender, EventArgs e)
        {


            String buscar = textBox1.Text.ToString();//String a buscar

            ClienteCEN cen_c = new ClienteCEN();
            /** 
             * BUSQUEDA POR NOMBRE Y APELLIDOS DE CLIENTE
             * **/
            IList<ClienteEN> en_cli_nombre = cen_c.BuscarClientePorNombre(buscar);
            IList<ClienteEN> en_cli_apellido = cen_c.BuscarClientePorApellidos(buscar);

            ArrayList dni = new ArrayList(); //para que no aparezca personas repetidas
            bool dni_repetido = false;

            if (en_cli_nombre.Count == 0 && en_cli_apellido.Count == 0)
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


                for (int x = 0; x < en_cli_nombre.Count; x++)
                {
                    dataGridView1.Rows.Add(en_cli_nombre[x].DNI, en_cli_nombre[x].Nombre, en_cli_nombre[x].Apellidos);
                    dni.Add(en_cli_nombre[x].DNI);//metemos el dni en el array auxiliar
                }
                for (int i = 0; i < en_cli_apellido.Count; i++)
                {

                    for (int z = 0; z < dni.Count; z++)
                    {
                        if (en_cli_apellido[i].DNI.Equals(dni[z].ToString()))//Si el dni esta repetido ya no lo ponemos en la busqueda
                            dni_repetido = true;
                    }

                    if (!dni_repetido)
                        dataGridView1.Rows.Add(en_cli_apellido[i].DNI, en_cli_apellido[i].Nombre, en_cli_apellido[i].Apellidos);

                    dni_repetido = false;
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuarioTableAdapter.FillBy(this.gestionVeterinariaGenNHibernateDataSet.Usuario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGridView1.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\close-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;

            }


            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGridView1.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\edit-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dataGridView1.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {

                bool eliCliente = false;
                string clienteaborrar = "";

                clienteaborrar = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                eliCliente = true;

                //Form2.ActiveForm.Close();
                FormEmpleadoCliente f3 = new FormEmpleadoCliente();
                f3.sesionUsuario = sesionUsuario;//sesion usuario
                f3.eliminarCliente = eliCliente;
                f3.dniEliminarCliente = clienteaborrar;
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

            if (this.dataGridView1.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {

                string modCliente = "";
                bool clienteMod = true;
                modCliente = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                //Form2.ActiveForm.Close();
                FormEmpleadoCliente f3 = new FormEmpleadoCliente();
                f3.sesionUsuario = sesionUsuario;//sesion usuario
                f3.modificarCliente = clienteMod;
                f3.dniModificarCliente = modCliente;
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

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.ActiveForm.Close();
            Login f1 = new Login();
            f1.Activate();
            f1.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.ActiveForm.Close();
        }

        private void verPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.ActiveForm.Close();
            Mascotas f3 = new Mascotas();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
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

        private void verEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.ActiveForm.Close();
            Empleados f3 = new Empleados();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
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

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.ActiveForm.Close();
            Facturas f3 = new Facturas();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void verConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.ActiveForm.Close();
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

        private void añadirFacturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool ok = true;
            //Form2.ActiveForm.Close();
            FormFactura f3 = new FormFactura();
            //f3.sesionUsuario = sesionUsuario;//sesion usuario
            //f3.anyadirEmpleado = ok;
            f3.Activate();
            f3.Visible = true;
        }



    }
}
