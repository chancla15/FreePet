using System;
using System.IO;
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
    class FormAdministradorEmpleadoController
    {

        #region Variables

        /** El formulario a controlar */
        private FormAdministradorEmpleado form;

        /** El ticket de sesion */
        public FormLoginDataSessionTicket sessionData;

        /** El CAD para acceder a la DDBB de la tabla empleados */
        private EmpleadoCAD _IEmpleadoCAD = new EmpleadoCAD();

        /** El empleado actual en el formulario */
        public EmpleadoEN empleadoEN = null;

        /** Los ditintos estados de lo que puede hacer el controlador
         * Esto solo sirve para guiarme para refactorizar 
         */
        public enum State {
            NONE, CLI_ADD, CLI_MOD, CLI_DEL, EMP
        }

        #endregion

        #region Constructor

        /**
         * Constructor de clase
         * @param sesion el ticket de sesion
         * @param form el formulario
         */
        public FormAdministradorEmpleadoController(FormAdministradorEmpleado form)
        {
            this.form = form;
            //form.dataGridView.Refresh();//lsta mascotas
            empleadoEN = new EmpleadoEN();
        }

        #endregion

        #region ProcesarDatos

        /**
         * Carga un empleado en los text_view
         */
        public void loadData(EmpleadoEN empleado)
        {
            empleadoEN = empleado;

            if (empleadoEN == null)
                empleadoEN = Utils._IEmpleadoCAD.DameEmpleadoPorOID(form.tb_dni.Text);

            if (empleadoEN != null)
            {
                form.tb_dni.Text = empleadoEN.DNI;
                form.tb_nombre.Text = empleadoEN.Nombre;
                form.tb_apellidos.Text = empleadoEN.Apellidos;
                form.tb_direccion.Text = empleadoEN.Direccion;
                form.tb_provincia.Text = empleadoEN.Provincia;
                form.tb_localidad.Text = empleadoEN.Localidad;
                form.tb_cp.Text = empleadoEN.Cp;
                form.tb_tel.Text = empleadoEN.Telefono;
                form.tb_sueldo.Text = Convert.ToString(empleadoEN.Sueldo);
                form.tb_pass.Text = empleadoEN.Password;

                //falta el numero de colegiado

                VeterinarioEN vet = new VeterinarioEN();
                vet = Utils._IVeterinarioCAD.DameVetarinarioPorOID(form.tb_dni.Text);

                if (vet != null)
                {
                    form.tb_tipo.SelectedIndex = 0;
                    //mostrar numero de colegiado
                    form.tb_colegiado.Text = vet.NumColegiado.ToString();
                }
                else
                {

                    form.tb_tipo.SelectedIndex = 1;
                    form.tb_colegiado.Visible = false;
                    form.label_col.Visible = false;
                }
                //form.tb_tipo.Text
                Buscar();
            }
        }

        /**
         * AÑADE, MODFIFICA O ELIMINA UN CLIENTE
         */
        public void ProcesarInformacion()
        {
            if (empleadoEN == null && (form.state == Utils.State.NEW)
                || (empleadoEN != null && form.state == Utils.State.MODIFY)
                || (empleadoEN != null && form.state == Utils.State.DESTROY))
            {
                empleadoEN.Nombre = form.tb_nombre.Text;
                empleadoEN.DNI = form.tb_dni.Text;
                empleadoEN.Apellidos = form.tb_apellidos.Text;
                empleadoEN.Direccion = form.tb_direccion.Text;
                empleadoEN.Provincia = form.tb_provincia.Text;
                empleadoEN.Localidad = form.tb_localidad.Text;
                empleadoEN.Cp = form.tb_cp.Text;
                empleadoEN.Telefono = form.tb_tel.Text;
                empleadoEN.Sueldo = Convert.ToInt32(form.tb_sueldo.Text);
                empleadoEN.Password = form.tb_pass.Text;
                


                if (form.tb_tipo.SelectedIndex ==0)
                {

                    switch (form.state)
                    {
                        case Utils.State.NONE:
                            break;
                        case Utils.State.NEW:
                            Utils._EmpleadoCEN.New_(empleadoEN.DNI, empleadoEN.Nombre, empleadoEN.Apellidos, empleadoEN.Direccion, empleadoEN.Telefono, empleadoEN.Localidad, empleadoEN.Provincia, empleadoEN.Cp, empleadoEN.Sueldo, empleadoEN.Password);
                            break;
                        case Utils.State.MODIFY:
                            Utils._EmpleadoCEN.Modify(empleadoEN.DNI, empleadoEN.Nombre, empleadoEN.Apellidos, empleadoEN.Direccion, empleadoEN.Telefono, empleadoEN.Localidad, empleadoEN.Provincia, empleadoEN.Cp, empleadoEN.Sueldo, empleadoEN.Password);
                            break;
                        case Utils.State.DESTROY:
                            Utils._EmpleadoCEN.Destroy(empleadoEN.DNI);
                            break;
                        default:
                            break;
                    }
                }
                else
                {

                    switch (form.state)
                    {
                        case Utils.State.NONE:
                            break;
                        case Utils.State.NEW:
                            Utils._RecepcionistaCEN.New_(empleadoEN.DNI, empleadoEN.Nombre, empleadoEN.Apellidos, empleadoEN.Direccion, empleadoEN.Telefono, empleadoEN.Localidad, empleadoEN.Provincia, empleadoEN.Cp, empleadoEN.Sueldo, empleadoEN.Password);
                            break;
                        case Utils.State.MODIFY:
                            Utils._RecepcionistaCEN.Modify(empleadoEN.DNI, empleadoEN.Nombre, empleadoEN.Apellidos, empleadoEN.Direccion, empleadoEN.Telefono, empleadoEN.Localidad, empleadoEN.Provincia, empleadoEN.Cp, empleadoEN.Sueldo, empleadoEN.Password);
                            break;
                        case Utils.State.DESTROY:
                            Utils._EmpleadoCEN.Destroy(empleadoEN.DNI);
                            break;
                        default:
                            break;
                    }

                }
            }
            else
            {
                //ERROR....DNI MAL (ESTA SI) O OPCION INCORRECTA(QUE NO CREO, PERO X SIACASO)
            }
        }

        #endregion

        #region Busquedas

        /**
         * Para buscar mascotas del cliente
         */
        public void Buscar()
        {

            String dni = form.tb_dni.Text;

            //Buscamos por cliente si el dni se ha introducido para buscar
            if (dni != "")
            {
                empleadoEN.DNI = dni;
            }
        }

        #endregion




        /**
         * Muestra los datos al poner un dni
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
                form.tb_provincia.SelectedItem = empleado.Provincia;
                form.tb_cp.Text = empleado.Cp;
                form.tb_sueldo.Text = empleado.Sueldo.ToString();
                form.tb_pass.Text = empleado.Password;

                try
                {
                    System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\" + sessionData.TOKEN_SESSION + ".png", System.IO.FileMode.Open);
                    form.log_photo.Image = Image.FromStream(fs);
                    form.log_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                    fs.Close();
                }
                catch
                {
                    System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\sinFoto.png", System.IO.FileMode.Open);
                    form.log_photo.Image = Image.FromStream(fs);
                    fs.Close();
                }
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
                empleado.Provincia = form.tb_provincia.SelectedItem.ToString();
                empleado.Cp = form.tb_cp.Text;
                empleado.Sueldo = Convert.ToInt32(form.tb_sueldo.Text);
                _IEmpleadoCAD.Modify(empleado);
                form.log_photo.Image.Save(Environment.CurrentDirectory + @"\" + form.tb_dni.Text + ".png");
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
                    form.log_photo.Image = Image.FromFile(imagen);
                    form.log_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es .PNG");
            }
        }


        #region BorrarTodosLosCampos

        /**
         * Borra todos los campos del formulario
         */
        public void ClearForm()
        {
            empleadoEN = null;
            form.tb_dni.Text = "";
            form.tb_dni.Enabled = true;
            form.tb_nombre.Text = "";
            form.tb_apellidos.Text = "";
            form.tb_direccion.Text = "";
            form.tb_provincia.Text = "";
            form.tb_localidad.Text = "";
            form.tb_cp.Text = "";
            form.tb_tel.Text = "";
        }
        #endregion
    
    }
}
