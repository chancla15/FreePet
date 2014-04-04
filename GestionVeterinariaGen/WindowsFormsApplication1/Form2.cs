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
using System.Collections;

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

        private void label3_Click(object sender, EventArgs e)///VER PERFIL
        {
            Form2.ActiveForm.Close();
            Form3 f3 = new Form3();

            ((TextBox)f3.Controls["tb_nombre"]).Enabled = false;
            ((TextBox)f3.Controls["tb_apellidos"]).Enabled = false;
            ((TextBox)f3.Controls["tb_sueldo"]).Enabled = false;
            ((TextBox)f3.Controls["tb_direccion"]).Enabled = false;
            ((TextBox)f3.Controls["tb_localidad"]).Enabled = false;
            ((TextBox)f3.Controls["tb_sueldo"]).Enabled = false;
            ((TextBox)f3.Controls["tb_dni"]).Enabled = false;
            ((TextBox)f3.Controls["tb_tel"]).Enabled = false;
            ((TextBox)f3.Controls["tb_provincia"]).Enabled = false;
            ((TextBox)f3.Controls["tb_cp"]).Enabled = false;

            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)//modificar mascota
        {
            string mascmod = "";
            bool modMascota = false;

            if (listBox2.SelectedIndex >= 0)
            {

                mascmod = listBox2.SelectedItem.ToString();

                mascmod = mascmod.Substring(0, 9);

                modMascota = true;

            }


            if (modMascota != true)
            {
                MessageBox.Show("Selecciona Una Mascota","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
            else
            {

                Form2.ActiveForm.Close();
                Form4 f3 = new Form4();
                f3.sesionUsuario = sesionUsuario;//sesion usuario
                f3.Activate();
                f3.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)//añadir mascota
        {
            Form2.ActiveForm.Close();
            Form4 f3 = new Form4();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)//modificar empleado
        {
            string empleadoMod = "";
            bool modEmpleado = false;

            if (listBox3.SelectedIndex >= 0)
            {
                empleadoMod = listBox3.SelectedItem.ToString();
                empleadoMod = empleadoMod.Substring(0, 9);
                modEmpleado = true;
            }


            if (modEmpleado != true)
            {
                MessageBox.Show("Selecciona Un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                Form2.ActiveForm.Close();
                FormAddEmpleado f3 = new FormAddEmpleado();
                f3.sesionUsuario = sesionUsuario;//sesion usuario
                f3.modificarUsuario = true;
                f3.dniModificarUsuario = empleadoMod;
                f3.Activate();
                f3.Visible = true;

            }
        }

        private void button10_Click(object sender, EventArgs e)//añadir cliente
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

        private void button9_Click(object sender, EventArgs e)/** ELIMINAR CLIENTE **/
        {
            bool eliCliente = false;
            string clienteaborrar;

            if (listBox1.SelectedIndex >= 0)
            {
                clienteaborrar = listBox1.SelectedItem.ToString();

                clienteaborrar = clienteaborrar.Substring(0, 9);

                eliCliente = true;

            }


            if (eliCliente != true)
            {
                MessageBox.Show("Selecciona Un Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
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



        }

        private void button8_Click(object sender, EventArgs e)//modificar cliente
        {

            string modCliente = "";
            bool clienteMod = false;

            if (listBox3.SelectedIndex >= 0)
            {

                modCliente = listBox3.SelectedItem.ToString();

                modCliente = modCliente.Substring(0, 9);

                clienteMod = true;

            }


            if (clienteMod != true)
            {
                MessageBox.Show("Selecciona Una Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
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
        }

        private void button7_Click(object sender, EventArgs e)//eliminar mascota
        {

            string empleadoborrar = "";
            bool eliminarMascota = false;

            if (listBox3.SelectedIndex >= 0)
            {

                empleadoborrar = listBox3.SelectedItem.ToString();

                empleadoborrar = empleadoborrar.Substring(0, 9);

                eliminarMascota = true;

            }


            if (eliminarMascota != true)
            {
                MessageBox.Show("Selecciona Una Mascota", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                Form2.ActiveForm.Close();
                Form4 f4 = new Form4();
                f4.sesionUsuario = sesionUsuario;//sesion usuario
                f4.Activate();
                f4.Visible = true;
            }



        }

        private void button6_Click(object sender, EventArgs e)//añadir empleados
        {
            Form2.ActiveForm.Close();
            FormAddEmpleado f3 = new FormAddEmpleado();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e) /** ELIMINAR EMPLEADO**/
        {





            string empleadoborrar = "";
            bool eliminar = false;


            if (listBox3.SelectedIndex >= 0)
            {
                empleadoborrar = listBox3.SelectedItem.ToString();

                empleadoborrar = empleadoborrar.Substring(0, 9);

                eliminar = true;
            }

            /*string trabajo = "";
            if (listBox3.SelectedIndex >= 0)
            {

                trabajo = listBox3.SelectedItem.ToString();
                trabajo = trabajo.Substring(trabajo.IndexOf("("), trabajo.IndexOf(")"));

            }*/

            if (eliminar != true)
            {
                MessageBox.Show("Selecciona Un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                Form2.ActiveForm.Close();
                FormAddEmpleado f3 = new FormAddEmpleado();

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
                //f3.trabajo = trabajo;
                f3.dniEliminarUsuario = empleadoborrar;
                f3.Activate();
                f3.Visible = true;

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

            Form2.ActiveForm.Close();
            Form3 f3 = new Form3();
            f3.sesionUsuario = sesionUsuario;//sesion usuario
            f3.Activate();
            f3.Visible = true;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)/////////BUSCAR
        {
            //borrar el listBox1 
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            String buscar = textBox1.Text.ToString();//String a buscar

            switch (comboBox1.SelectedIndex)
            {

                case 0://CLIENTE
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

                        listBox1.Items.Add("La búsqueda no ha producido ningún resultado");

                    }
                    else
                    {

                        for (int x = 0; x < en_cli_nombre.Count; x++)
                        {
                            listBox1.Items.Add(en_cli_nombre[x].DNI + " - " + en_cli_nombre[x].Nombre + " " + en_cli_nombre[x].Apellidos);
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
                                listBox1.Items.Add(en_cli_apellido[i].DNI + " - " + en_cli_apellido[i].Nombre + " " + en_cli_apellido[i].Apellidos);

                            dni_repetido = false;
                        }
                    }

                    tabControl1.SelectedTab = tabPage1;
                    break;
                case 1://MASCOTA
                    MascotaCEN cen_m = new MascotaCEN();

                    IList<MascotaEN> en_mas_nombre = cen_m.DameMascotaPorNombre(buscar);

                    if (en_mas_nombre.Count == 0)
                    {

                        listBox1.Items.Add("La búsqueda no ha producido ningún resultado");

                    }
                    else
                    {

                        for (int x = 0; x < en_mas_nombre.Count; x++)
                        {
                            listBox1.Items.Add(en_mas_nombre[x].Nombre + " - " + en_mas_nombre[x].Raza + " " + en_mas_nombre[x].Cliente);
                        }

                    }

                    tabControl1.SelectedTab = tabPage2;
                    break;
                case 2://Veterinarios solo por ahora 
                    /**
                     * Busqueda de Veterinarios
                     * **/
                    bool no_hay_veterinarios = false;
                    VeterinarioCEN vet_v = new VeterinarioCEN();
                    IList<VeterinarioEN> en_vet_nombre = vet_v.BuscarVetPorNombre(buscar);
                    IList<VeterinarioEN> en_vet_apellido = vet_v.BuscarVetPorApellidos(buscar);

                    ArrayList dni_vet = new ArrayList(); //para que no aparezca personas repetidas
                    bool dni_repetido_vet = false;

                    if (en_vet_nombre.Count == 0 && en_vet_apellido.Count == 0)
                    {
                        //listBox3.Items.Add("La búsqueda no ha producido ningún resultado");
                        no_hay_veterinarios = true;
                    }
                    else
                    {

                        for (int x = 0; x < en_vet_nombre.Count; x++)
                        {
                            listBox3.Items.Add(en_vet_nombre[x].DNI + " - " + en_vet_nombre[x].Nombre + " " + en_vet_nombre[x].Apellidos + " (Veterinario)");
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
                                listBox3.Items.Add(en_vet_apellido[i].DNI + " - " + en_vet_apellido[i].Nombre + " " + en_vet_apellido[i].Apellidos + " (Veterinario)");

                            dni_repetido_vet = false;
                        }
                    }

                    /**
                     * Busqueda de Recepcionistas
                     * **/

                    RecepcionistaCEN cen_re = new RecepcionistaCEN();
                    IList<RecepcionistaEN> en_rec_nombre = cen_re.BuscarRecepPorNombre(buscar);
                    IList<RecepcionistaEN> en_rec_apellido = cen_re.BuscarRecepPorApellidos(buscar);

                    ArrayList dni_rec = new ArrayList(); //para que no aparezca personas repetidas
                    bool dni_repetido_rece = false;

                    if (en_rec_nombre.Count == 0 && en_rec_apellido.Count == 0 && no_hay_veterinarios)
                    { //Si no encuentra nada
                        listBox3.Items.Add("La búsqueda no ha producido ningún resultado");
                    }
                    else
                    {
                        for (int x = 0; x < en_rec_nombre.Count; x++)
                        {
                            listBox3.Items.Add(en_rec_nombre[x].DNI + " - " + en_rec_nombre[x].Nombre + " " + en_rec_nombre[x].Apellidos + " (Recepcionista)");
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
                                listBox3.Items.Add(en_rec_apellido[i].DNI + " - " + en_rec_apellido[i].Nombre + " " + en_rec_apellido[i].Apellidos + " (Recepcionista)");

                            dni_repetido_rece = false;
                        }
                    }
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

            if (vet_en != null)
            {
                //Cuando sea veterinario oculto cerdo
                //cerdo
                panel1.Visible = false;
                label5.Visible = false;
                tabPage3.Parent = null;
                comboBox1.Items.RemoveAt(2);

            }

            label1.Text = "Bienvenido " + datosUsuario.Nombre;
        }
    }
}
