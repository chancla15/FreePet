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
using System.IO;
///////
namespace WindowsFormsApplication1
{
    public partial class FormPerfilRecepcionista : Form
    {
        /** El controlador */
        private FormPerfilRecepcionistaController controller;


        /**
         * El contructor de la clase
         * @param session la session
         */
        public FormPerfilRecepcionista(FormLoginDataSessionTicket session)
        {
            InitializeComponent();
            controller = new FormPerfilRecepcionistaController(session, this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPerfilRecepcionista.ActiveForm.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex.Equals(1))
            {
                //añadir Recepcionista
                RecepcionistaCEN cen = new RecepcionistaCEN();

                try
                {
                    float sueldo = float.Parse(tb_sueldo.Text.ToString());
                    cen.New_(text_dni.Text.ToString(), text_nombre.Text.ToString(), text_apellidos.Text.ToString(), text_direccion.Text.ToString(), text_telefono.Text.ToString(), text_localidad.Text.ToString(), combo_provincia.Text.ToString(), text_cp.Text.ToString(), sueldo, tb_pass.Text.ToString());
                    MessageBox.Show("Recepcionista Creado Correctamente");
                    FormPerfilRecepcionista.ActiveForm.Close();


                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                    err_anaydir.Text = "*Error al Añadir Recepcionista";
                    err_anaydir.Visible = true;

                }

            }

            if (comboBox1.SelectedIndex.Equals(0))
            {

                //añadir Vteterinario
                VeterinarioCEN cen = new VeterinarioCEN();

                try
                {
                    float sueldo = float.Parse(tb_sueldo.Text.ToString());
                    cen.New_(text_dni.Text.ToString(), text_nombre.Text.ToString(), text_apellidos.Text.ToString(), text_direccion.Text.ToString(), text_telefono.Text.ToString(), text_localidad.Text.ToString(), combo_provincia.Text.ToString(), text_cp.Text.ToString(), sueldo, tb_pass.Text.ToString(), Convert.ToInt32(tb_colegiado.Text.ToString()));
                    MessageBox.Show("Veterinario Creado Correctamente");
                    FormPerfilRecepcionista.ActiveForm.Close();

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                    err_anaydir.Text = "*Error al Añadir Veterinario";
                    err_anaydir.Visible = true;

                }

            }

        }

        private void FormAddEmpleado_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            combo_provincia.SelectedIndex = 0;
            bt_despedir.Visible = false;//por defecto oculto.
            bt_modificar.Visible = false;//por defecto oculto
            bt_eliminar_cliente.Visible = false;//por defecto oculto.
            bt_modificar_cliente.Visible = false;//por defecto oculto
            bt_anyadir_cliente.Visible = false;//por defecto oculto.
            bt_aceptar.Visible = false;//por defecto oculto

            if (eliminarUsuario == true)
            {

                mostrarDatos(dniEliminarUsuario);
                bt_despedir.Visible = true;
            }
            else if (modificarUsuario == true)
            {

                mostrarDatos(dniModificarUsuario);
                bt_modificar.Visible = true;// mostramos el boton de modificar
            }

            if (eliminarCliente == true)
            {
                mostrarDatosCliente(dniEliminarCliente);
                bt_eliminar_cliente.Visible = true;

            }
            else if (modificarCliente == true)
            {

                mostrarDatosCliente(dniModificarCliente);
                bt_modificar_cliente.Visible = true;// mostramos el boton de modificar
            }

            if (anyadirCliente == true)
            {

                bt_anyadir_cliente.Visible = true;

            }
            else if (anyadirEmpleado == true)
            {
                bt_aceptar.Visible = true;
            }

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

        private void mostrarDatos(String dni)
        {

            EmpleadoCEN cen = new EmpleadoCEN();
            EmpleadoEN en = cen.DameEmpleadoPorOID(dni);

            text_dni.Text = en.DNI;
            text_nombre.Text = en.Nombre;
            tb_pass.Text = en.Password;
            tb_confPass.Text = en.Password;
            tb_sueldo.Text = en.Sueldo.ToString();
            text_localidad.Text = en.Localidad;
            text_telefono.Text = en.Telefono;
            text_apellidos.Text = en.Apellidos;
            text_direccion.Text = en.Direccion;
            text_cp.Text = en.Cp;
            combo_provincia.SelectedItem = en.Provincia;

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

            text_dni.Text = en.DNI;
            text_nombre.Text = en.Nombre;
            text_localidad.Text = en.Localidad;
            text_telefono.Text = en.Telefono;
            text_apellidos.Text = en.Apellidos;
            text_direccion.Text = en.Direccion;
            text_cp.Text = en.Cp;
            combo_provincia.SelectedItem = en.Provincia;

            tb_colegiado.Visible = false;
            label14.Visible = false;
            comboBox1.Visible = false;
            label17.Visible = false;
            bt_anyadir_cliente.Visible = false;


            //COMPROBACION DE IMAGEN SI NO HAY ASOCIADA YA QUE AL INSERTAR CON EL SCRIPT NO LAS ASOCIAMOS
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

        private void bt_despedir_Click(object sender, EventArgs e)
        {
            UsuarioCEN cen = new UsuarioCEN();

            if (MessageBox.Show("Seguro que desea despedir a este empleado", "Despedir usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                cen.Destroy(dniEliminarUsuario);
                FormPerfilRecepcionista.ActiveForm.Close();
            }
            else
            {
                err_anaydir.Text = "*Error al Eliminar Cliente";
                err_anaydir.Visible = true;
            }
        }

        private void bt_eliminar_cliente_Click(object sender, EventArgs e)
        {
            UsuarioCEN cen = new UsuarioCEN();

            if (MessageBox.Show("Seguro que desea eliminar a este cliente", "Eliminar cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                cen.Destroy(dniEliminarCliente);
                FormPerfilRecepcionista.ActiveForm.Close();
            }
            else
            {
                err_anaydir.Text = "*Error al Eliminar Cliente";
                err_anaydir.Visible = true;
            }

        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            EmpleadoCEN cen2 = new EmpleadoCEN();
            try
            {
                cen2.Modify(text_dni.Text.ToString(), text_nombre.Text.ToString(), text_apellidos.Text.ToString(), text_direccion.Text.ToString(), text_telefono.Text.ToString(), text_localidad.Text.ToString(), combo_provincia.SelectedItem.ToString(), text_cp.Text.ToString(), Convert.ToInt32(tb_sueldo.Text.ToString()), tb_pass.Text.ToString());

                //GUARDAMOS LA IMAGEN
                pictureBox1.Image.Save(Environment.CurrentDirectory + @"\" + text_dni.Text.ToString() + ".png");
                
                MessageBox.Show("Empleado Modificado Correctamente");
                FormPerfilRecepcionista.ActiveForm.Close();



            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                err_anaydir.Text = "*Error al Modificar Empleado";
                err_anaydir.Visible = true;

            }
        }

        private void bt_modificar_cliente_Click(object sender, EventArgs e)
        {
            ClienteCEN cen3 = new ClienteCEN();
            try
            {
                cen3.Modify(text_dni.Text.ToString(), text_nombre.Text.ToString(), text_apellidos.Text.ToString(), text_direccion.Text.ToString(), text_telefono.Text.ToString(), text_localidad.Text.ToString(), combo_provincia.SelectedItem.ToString(), text_cp.Text.ToString());

                //GUARDAMOS LA IMAGEN
                pictureBox1.Image.Save(Environment.CurrentDirectory + @"\" + text_dni.Text.ToString() + ".png");


                MessageBox.Show("Cliente Modificado Correctamente");
                FormPerfilRecepcionista.ActiveForm.Close();

                //ACTUALIZAR AL MODIFICAR

                FormStartRecepcionista.ActiveForm.Close();
                FormStartRecepcionista f2 = new FormStartRecepcionista();
                f2.sesionUsuario = sesionUsuario; //sesion usuario
                f2.Activate();
                f2.Visible = true;

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                err_anaydir.Text = "*Error al Modificar Cliente";
                err_anaydir.Visible = true;

            }
        }

        private void bt_anyadir_cliente_Click(object sender, EventArgs e)
        {
            ClienteCEN cenCliente = new ClienteCEN();

            IList<MascotaEN> mascota;

            try
            {

                cenCliente.New_(text_dni.Text.ToString(), text_nombre.Text.ToString(), text_apellidos.Text.ToString(), text_direccion.Text.ToString(), text_telefono.Text.ToString(), text_localidad.Text.ToString(), combo_provincia.Text.ToString(), text_cp.Text.ToString(), null);

                //GUARDAR IMAGEN

                pictureBox1.Image.Save(Environment.CurrentDirectory + @"\" + text_dni.Text.ToString() + ".png");

                MessageBox.Show("Cliente Creado Correctamente");
                FormPerfilRecepcionista.ActiveForm.Close();

                //ACTUALIZAR AL AÑADIR

                FormStartRecepcionista.ActiveForm.Close();
                FormStartRecepcionista f2 = new FormStartRecepcionista();
                f2.sesionUsuario = sesionUsuario; //sesion usuario
                f2.Activate();
                f2.Visible = true;


            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                err_anaydir.Text = "*Error al Añadir Cliente";
                err_anaydir.Visible = true;

            }
        }

        private void bt_eliminar_cliente_Click_1(object sender, EventArgs e)
        {
            UsuarioCEN cen = new UsuarioCEN();

            if (MessageBox.Show("Seguro que desea eliminar a este cliente", "Eliminar cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                cen.Destroy(dniEliminarCliente);

            //cerramos el form actual
            Close();

                if (System.IO.File.Exists(Environment.CurrentDirectory + @"\" + dniEliminarCliente.ToString() + ".png"))
                {
                    System.IO.File.Delete(Environment.CurrentDirectory + @"\" + dniEliminarCliente.ToString() + ".png");
                }

            //ACTUALIZAR AL AÑADIR

            FormStartRecepcionista.ActiveForm.Close();
            FormStartRecepcionista f2 = new FormStartRecepcionista();
            f2.sesionUsuario = sesionUsuario; //sesion usuario
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
