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
    public partial class Empleados : Form
    {

        public string sesionUsuario;//especide de sesion de usuario

        public Empleados()
        {
            InitializeComponent();
        }
        

        private void Empleados_Load(object sender, EventArgs e)
        {

            //Para cargar por defecto los usuarios con el tipo

            String buscar = textBox1.Text.ToString();//String a buscar

            VeterinarioCEN vet_v = new VeterinarioCEN();
            IList<VeterinarioEN> en_vet_nombre = vet_v.BuscarVetPorNombre(buscar);
            IList<VeterinarioEN> en_vet_apellido = vet_v.BuscarVetPorApellidos(buscar);

            ArrayList dni_vet = new ArrayList(); //para que no aparezca personas repetidas
            bool dni_repetido_vet = false;

            /**
            * Busqueda de Recepcionistas
            * **/

            RecepcionistaCEN cen_re = new RecepcionistaCEN();
            IList<RecepcionistaEN> en_rec_nombre = cen_re.BuscarRecepPorNombre(buscar);
            IList<RecepcionistaEN> en_rec_apellido = cen_re.BuscarRecepPorApellidos(buscar);

            ArrayList dni_rec = new ArrayList(); //para que no aparezca personas repetidas
            bool dni_repetido_rece = false;

            if (en_vet_nombre.Count == 0 && en_vet_apellido.Count == 0 || en_rec_nombre.Count == 0 && en_rec_apellido.Count == 0)
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

                for (int x = 0; x < en_vet_nombre.Count; x++)
                {
                    dataGridView1.Rows.Add(en_vet_nombre[x].DNI, en_vet_nombre[x].Nombre, en_vet_nombre[x].Apellidos, "Veterinario");
                    dni_vet.Add(en_vet_nombre[x].DNI);//metemos el dni en el array auxiliar
                }

                for (int i = 0; i < en_vet_apellido.Count; i++)
                {

                    for (int z = 0; z < dni_vet.Count; z++)
                    {
                        if (en_vet_apellido[i].DNI.Equals(dni_vet[z].ToString()))//Si el dni esta repetido ya no lo ponemos en la busqueda
                            dni_repetido_vet = true;
                    }

                    if (!dni_repetido_vet)
                        dataGridView1.Rows.Add(en_vet_apellido[i].DNI, en_vet_apellido[i].Nombre, en_vet_apellido[i].Apellidos, "Veterinario");

                    dni_repetido_vet = false;
                }

                for (int x = 0; x < en_rec_nombre.Count; x++)
                {
                    dataGridView1.Rows.Add(en_rec_nombre[x].DNI, en_rec_nombre[x].Nombre, en_rec_nombre[x].Apellidos, "Recepcionista");
                    dni_rec.Add(en_rec_nombre[x].DNI);//metemos el dni en el array auxiliar
                }
                for (int i = 0; i < en_rec_apellido.Count; i++)
                {

                    for (int z = 0; z < dni_rec.Count; z++)
                    {
                        if (en_rec_apellido[i].DNI.Equals(dni_rec[z].ToString()))//Si el dni esta repetido ya no lo ponemos en la busqueda
                            dni_repetido_rece = true;
                    }

                    if (!dni_repetido_rece)
                        dataGridView1.Rows.Add(en_rec_apellido[i].DNI, en_rec_apellido[i].Nombre, en_rec_apellido[i].Apellidos, "Recepcionista");

                    dni_repetido_rece = false;
                }
            }

            //cargo todo lo demas

            UsuarioCEN user_cen = new UsuarioCEN();
            UsuarioEN datosUsuario = user_cen.DameUsuarioPorDNI(sesionUsuario);

            label2.Text = sesionUsuario;
            label1.Text = "Bienvenido " + datosUsuario.Nombre;

            //Sacar el trabajo que desenpeña el trabajador
            //Es veterinaio? si no lo es será recepcionista
            VeterinarioCEN vet_cen = new VeterinarioCEN();
            VeterinarioEN vet_en = vet_cen.DameVetarinarioPorOID(sesionUsuario);

            if (vet_en != null)
            {
                empleadosToolStripMenuItem.Visible = false;
                label3.Text = "VETERINARIO";

            }
            else
            {
                label3.Text = "RECEPCIONISTA";
            }


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

            VeterinarioCEN vet_v = new VeterinarioCEN();
            IList<VeterinarioEN> en_vet_nombre = vet_v.BuscarVetPorNombre(buscar);
            IList<VeterinarioEN> en_vet_apellido = vet_v.BuscarVetPorApellidos(buscar);

            ArrayList dni_vet = new ArrayList(); //para que no aparezca personas repetidas
            bool dni_repetido_vet = false;

            /**
            * Busqueda de Recepcionistas
            * **/

            RecepcionistaCEN cen_re = new RecepcionistaCEN();
            IList<RecepcionistaEN> en_rec_nombre = cen_re.BuscarRecepPorNombre(buscar);
            IList<RecepcionistaEN> en_rec_apellido = cen_re.BuscarRecepPorApellidos(buscar);

            ArrayList dni_rec = new ArrayList(); //para que no aparezca personas repetidas
            bool dni_repetido_rece = false;

                if (en_vet_nombre.Count == 0 && en_vet_apellido.Count == 0 || en_rec_nombre.Count == 0 && en_rec_apellido.Count == 0)
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

                for (int x = 0; x < en_vet_nombre.Count; x++)
                {
                    dataGridView1.Rows.Add(en_vet_nombre[x].DNI,en_vet_nombre[x].Nombre,en_vet_nombre[x].Apellidos,"Veterinario");
                    dni_vet.Add(en_vet_nombre[x].DNI);//metemos el dni en el array auxiliar
                }

                for (int i = 0; i < en_vet_apellido.Count; i++)
                {

                    for (int z = 0; z < dni_vet.Count; z++)
                    {
                        if (en_vet_apellido[i].DNI.Equals(dni_vet[z].ToString()))//Si el dni esta repetido ya no lo ponemos en la busqueda
                            dni_repetido_vet = true;
                    }

                    if (!dni_repetido_vet)
                        dataGridView1.Rows.Add(en_vet_apellido[i].DNI,en_vet_apellido[i].Nombre,en_vet_apellido[i].Apellidos,"Veterinario");

                    dni_repetido_vet = false;
                }

                for (int x = 0; x < en_rec_nombre.Count; x++)
                {
                    dataGridView1.Rows.Add(en_rec_nombre[x].DNI, en_rec_nombre[x].Nombre, en_rec_nombre[x].Apellidos, "Recepcionista");
                    dni_rec.Add(en_rec_nombre[x].DNI);//metemos el dni en el array auxiliar
                }
                for (int i = 0; i < en_rec_apellido.Count; i++)
                {

                    for (int z = 0; z < dni_rec.Count; z++)
                    {
                        if (en_rec_apellido[i].DNI.Equals(dni_rec[z].ToString()))//Si el dni esta repetido ya no lo ponemos en la busqueda
                            dni_repetido_rece = true;
                    }

                    if (!dni_repetido_rece)
                        dataGridView1.Rows.Add(en_rec_apellido[i].DNI, en_rec_apellido[i].Nombre, en_rec_apellido[i].Apellidos, "Recepcionista");

                    dni_repetido_rece = false;
                }
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
                string empleadoborrar = "";

                empleadoborrar = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                bool eliminar = true;

                FormEmpleadoCliente f3 = new FormEmpleadoCliente();

                ((TextBox)f3.Controls["tb_dni"]).Enabled = false;
                ((TextBox)f3.Controls["tb_nombre"]).Enabled = false;
                ((TextBox)f3.Controls["tb_pass"]).Enabled = false;
                ((TextBox)f3.Controls["tb_confPass"]).Enabled = false;
                ((TextBox)f3.Controls["tb_confPass"]).Enabled = false;
                ((TextBox)f3.Controls["tb_sueldo"]).Enabled = false;
                ((TextBox)f3.Controls["tb_localidad"]).Enabled = false;
                ((TextBox)f3.Controls["tb_tel"]).Enabled = false;
                ((TextBox)f3.Controls["tb_apellidos"]).Enabled = false;
                ((TextBox)f3.Controls["tb_direccion"]).Enabled = false;
                ((ComboBox)f3.Controls["comboBox2"]).Enabled = false;
                ((TextBox)f3.Controls["tb_cp"]).Enabled = false;

                f3.sesionUsuario = sesionUsuario;//sesion usuario
                f3.eliminarUsuario = eliminar;
                f3.dniEliminarUsuario = empleadoborrar;
                f3.Activate();
                f3.Visible = true;

            }

            if (this.dataGridView1.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {

                string empleadoMod = "";
                bool modEmpleado = true;
                empleadoMod = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                //Form2.ActiveForm.Close();
                FormEmpleadoCliente f3 = new FormEmpleadoCliente();
                f3.sesionUsuario = sesionUsuario;//sesion usuario
                f3.modificarUsuario = modEmpleado;
                f3.dniModificarUsuario = empleadoMod;
                f3.Activate();
                f3.Visible = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = true;
            FormEmpleadoCliente f3 = new FormEmpleadoCliente();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.anyadirEmpleado = ok;
            f3.Activate();
            f3.Visible = true;
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados.ActiveForm.Close();
            Login f1 = new Login();
            f1.Activate();
            f1.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados.ActiveForm.Close();
        }

        private void verPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados.ActiveForm.Close();
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

        private void verEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void añadirEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = true;
            FormEmpleadoCliente f3 = new FormEmpleadoCliente();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.anyadirEmpleado = ok;
            f3.Activate();
            f3.Visible = true;
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

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
            Close();
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
