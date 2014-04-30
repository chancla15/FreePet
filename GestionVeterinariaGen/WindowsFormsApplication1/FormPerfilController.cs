using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormPerfilRecepcionistaController
     * Esta sera la encargada de gestionar la vista de datos de clientes y empleados 
     * tanto para añadir/modificar/eliminar cliente, o para modificar datos opcionale
     * e irrelevantes del empleado
     */
    class FormPerfilController
    {
        /** El formulario a controlar */
        private FormPerfil form;

        /** El ticket de sesion */
        public FormLoginDataSessionTicket sessionData;

        /** El CAD para acceder a la DDBB de la tabla empleados */
        private EmpleadoCAD _IEmpleadoCAD = new EmpleadoCAD();

        /** Los ditintos estados de lo que puede hacer el controlador
         * Esto solo sirve para guiarme para refactorizar 
         */
        public enum State {
            NONE, CLI_ADD, CLI_MOD, CLI_DEL, EMP
        }

        /**
         * El constructor
         * @param s el ticket de sesion
         * @param f el formulario a controlar
         */
        public FormPerfilController(FormLoginDataSessionTicket s, FormPerfil f) {
            
            this.sessionData = s;
            this.form = f;
        }

        /**
         * Muestra los datos al poner un dni, FALTA PONER LA FOTO
         */
        public void showData()
        {
            EmpleadoEN empleado = _IEmpleadoCAD.DameEmpleadoPorOID(form.tb_dni.Text);

            if (empleado != null)
            {
                form.tb_nombre.Text = empleado.Nombre;
                form.tb_apellidos.Text = empleado.Apellidos;
                form.tb_direccion.Text = empleado.Direccion;
                form.tb_localidad.Text = empleado.Localidad;
                form.comboBox2.SelectedItem = empleado.Provincia;
                form.tb_cp.Text = empleado.Cp;
                form.tb_sueldo.Text = empleado.Sueldo.ToString();
                //la foto
            }
        }

        /**
         * Modifica el empleado
         */
        public Boolean modifiData()
        {
            EmpleadoEN empleado = _IEmpleadoCAD.DameEmpleadoPorOID(form.tb_dni.Text);

            if (empleado != null)
            {
                empleado.Nombre = form.tb_nombre.Text;
                empleado.Apellidos = form.tb_apellidos.Text;
                empleado.Direccion = form.tb_direccion.Text;
                empleado.Localidad = form.tb_localidad.Text;
                empleado.Provincia = form.comboBox2.SelectedItem.ToString();
                empleado.Cp = form.tb_cp.Text;
                empleado.Sueldo = Convert.ToInt32(form.tb_sueldo.Text);
                _IEmpleadoCAD.Modify(empleado);
                form.pictureBox1.Image.Save(Environment.CurrentDirectory + @"\" + form.tb_dni.Text + ".png");
                MessageBox.Show("Perfil Modificado Correctamente");
                return true;
            }
            return false;
        }


        /** 
         * Modifica la foto
         */
        public void clickInPhoto()
        {
            try
            {

                if (form.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = form.openFileDialog1.FileName;
                    form.pictureBox1.Image = Image.FromFile(imagen);
                    form.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es .PNG");
            }
        }
    
    }
}
