﻿/* 
    FreePet. OpenSource Software Veterinarian Management
    Copyright (C) 2014  Jesus Manresa Parres

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormPerfilRecepcionistaController
     * Esta sera la encargada de gestionar la vista de datos de clientes y empleados 
     * tanto para añadir/modificar/eliminar cliente, o para modificar datos opcionale
     * e irrelevantes del empleado
     */
    public class FormAdministradorEmpleadoController
    {

        #region Variables

        private FormAdministradorEmpleado form;
        public FormLoginDataSessionTicket sessionData;
        public EmpleadoEN empleadoEN = null;

        #endregion

        #region Constructor

        public FormAdministradorEmpleadoController(FormAdministradorEmpleado form)
        {
            this.form = form;
            //form.dataGridView.Refresh();//lsta mascotas
            empleadoEN = new EmpleadoEN();
        }

        #endregion

        #region ProcesarDatos

        public void cargarDatosEmpleado(EmpleadoEN empleado)
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
                    form.tb_colegiado.Visible = true;
                    form.label_col.Visible = true;
                    form.tb_colegiado.Text = vet.NumColegiado.ToString();
                }
                else
                {

                    form.tb_tipo.SelectedIndex = 1;
                    form.tb_colegiado.Visible = false;
                    form.label_col.Visible = false;
                }

                //Cargamos la imagen
                try
                {

                    System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\" + empleadoEN.DNI + ".png", System.IO.FileMode.Open);
                    form.log_photo.Image = Image.FromStream(fs);
                    form.log_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                    fs.Close();

                }
                catch (Exception ex)
                {
                    System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\sinFoto.png", System.IO.FileMode.Open);
                    form.log_photo.Image = Image.FromStream(fs);
                    fs.Close();
                }
            }
        }

        public void ProcesarInformacion()
        {
            bool ok = false;

            if (empleadoEN == null)
                empleadoEN = Utils._IEmpleadoCAD.DameEmpleadoPorOID(form.tb_dni.Text);

            if (empleadoEN == null || form.state == Utils.State.NEW)
                empleadoEN = new EmpleadoEN();

            if (empleadoEN != null)
            {

                if (form.tb_nombre.Text != "")
                    empleadoEN.Nombre = form.tb_nombre.Text;
                else
                    ok = true;

                if (form.tb_dni.Text != "")
                    empleadoEN.DNI = form.tb_dni.Text;
                else
                    ok = true;

                if (form.tb_apellidos.Text != "")
                    empleadoEN.Apellidos = form.tb_apellidos.Text;
                else
                    ok = true;
                if (form.tb_direccion.Text != "")
                    empleadoEN.Direccion = form.tb_direccion.Text;
                else
                    ok = true;

                if (form.tb_provincia.Text != "")
                    empleadoEN.Provincia = form.tb_provincia.SelectedItem.ToString();
                else
                    ok = true;

                if (form.tb_localidad.Text != "")
                    empleadoEN.Localidad = form.tb_localidad.Text;
                else
                    ok = true;

                if (form.tb_cp.Text != "")
                    empleadoEN.Cp = form.tb_cp.Text;
                else
                    ok = true;

                if (form.tb_tel.Text != "")
                    empleadoEN.Telefono = form.tb_tel.Text;
                else
                    ok = true;

                int i = 0;
                if (form.tb_sueldo.Text != "" && int.TryParse(form.tb_sueldo.Text.ToString(), out i))
                    empleadoEN.Sueldo = Convert.ToInt32(form.tb_sueldo.Text);
                else
                    ok = true;

                if (form.tb_pass.Text.ToString()!="")
                    empleadoEN.Password = form.tb_pass.Text;
                else
                    ok = true;


                if (empleadoEN != null && !ok)
                {
                    //Veterinario

                    if (form.tb_tipo.SelectedIndex == 0)
                    {

                        switch (form.state)
                        {
                            case Utils.State.NONE:
                                break;
                            case Utils.State.NEW:
                                Utils._EmpleadoCEN.New_(empleadoEN.DNI, empleadoEN.Nombre, empleadoEN.Apellidos, empleadoEN.Direccion, empleadoEN.Telefono, empleadoEN.Localidad, empleadoEN.Provincia, empleadoEN.Cp, empleadoEN.Sueldo, empleadoEN.Password);
                                form.log_photo.Image.Save(Environment.CurrentDirectory + @"\" + empleadoEN.DNI + ".png");
                                MessageBox.Show("Veterinario insertado con exito");
                                break;
                            case Utils.State.MODIFY:
                                Utils._EmpleadoCEN.Modify(empleadoEN.DNI, empleadoEN.Nombre, empleadoEN.Apellidos, empleadoEN.Direccion, empleadoEN.Telefono, empleadoEN.Localidad, empleadoEN.Provincia, empleadoEN.Cp, empleadoEN.Sueldo, empleadoEN.Password);
                                form.log_photo.Image.Save(Environment.CurrentDirectory + @"\" + empleadoEN.DNI + ".png");
                                MessageBox.Show("Veterinario modificado con exito");
                                break;
                            case Utils.State.DESTROY:
                                Utils._EmpleadoCEN.Destroy(empleadoEN.DNI);
                                //eliminamos la imagen
                                System.IO.File.Delete(Environment.CurrentDirectory + @"\" + empleadoEN.DNI.ToString() + ".png");
                                MessageBox.Show("Veterinario eliminado con exito");

                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        ////recepcionista

                        switch (form.state)
                        {
                            case Utils.State.NONE:
                                break;
                            case Utils.State.NEW:
                                Utils._RecepcionistaCEN.New_(empleadoEN.DNI, empleadoEN.Nombre, empleadoEN.Apellidos, empleadoEN.Direccion, empleadoEN.Telefono, empleadoEN.Localidad, empleadoEN.Provincia, empleadoEN.Cp, empleadoEN.Sueldo, empleadoEN.Password);
                                form.log_photo.Image.Save(Environment.CurrentDirectory + @"\" + empleadoEN.DNI + ".png");
                                MessageBox.Show("Recepcionista creado con exito");
                                break;
                            case Utils.State.MODIFY:
                                Utils._RecepcionistaCEN.Modify(empleadoEN.DNI, empleadoEN.Nombre, empleadoEN.Apellidos, empleadoEN.Direccion, empleadoEN.Telefono, empleadoEN.Localidad, empleadoEN.Provincia, empleadoEN.Cp, empleadoEN.Sueldo, empleadoEN.Password);
                                form.log_photo.Image.Save(Environment.CurrentDirectory + @"\" + empleadoEN.DNI + ".png");
                                MessageBox.Show("Recepcionista modificado con exito");
                                break;
                            case Utils.State.DESTROY:
                                Utils._EmpleadoCEN.Destroy(empleadoEN.DNI);
                                //eliminamos la imagen
                                System.IO.File.Delete(Environment.CurrentDirectory + @"\" + empleadoEN.DNI + ".png");
                                MessageBox.Show("Recepcionista eliminado con exito");

                                break;
                            default:
                                break;
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Revisa los campos");
                }
            }
        }

        public bool mostrarDatosEmpleado()
        {
            if (form.tb_dni.Text != "")
                empleadoEN = Utils._IEmpleadoCAD.DameEmpleadoPorOID(form.tb_dni.Text);

            if (empleadoEN != null)
            {
                form.tb_nombre.Text = empleadoEN.Nombre;
                form.tb_apellidos.Text = empleadoEN.Apellidos;
                form.tb_direccion.Text = empleadoEN.Direccion;
                form.tb_localidad.Text = empleadoEN.Localidad;
                form.tb_provincia.SelectedItem = empleadoEN.Provincia;
                form.tb_cp.Text = empleadoEN.Cp;
                form.tb_tel.Text = empleadoEN.Telefono;
                form.tb_sueldo.Text = empleadoEN.Sueldo.ToString();
                form.tb_pass.Text = empleadoEN.Password.ToString();

                VeterinarioEN vet = new VeterinarioEN();
                vet = Utils._IVeterinarioCAD.DameVetarinarioPorOID(form.tb_dni.Text);

                if (vet != null)
                {
                    form.tb_tipo.SelectedIndex = 0;
                    //mostrar numero de colegiado
                    form.tb_colegiado.Visible = true;
                    form.tb_colegiado.Text = vet.NumColegiado.ToString();
                }
                else
                {

                    form.tb_tipo.SelectedIndex = 1;
                    form.tb_colegiado.Visible = false;
                    form.label_col.Visible = false;
                }

                form.tb_tipo.Refresh();

                try
                {
                    System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\" + empleadoEN.DNI + ".png", System.IO.FileMode.Open);
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

                return true;
            }
            else
            {
                ClearForm();
                MessageBox.Show("La búsqueda no ha producido ningún resultado");
                return false;
            }

        }

        #endregion

        #region Botones

        public void clickInPhoto()
        {
            form.openFileDialog1.Filter = "PNG Files(*.png)|*.png";

            if (form.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagen = form.openFileDialog1.FileName;
                form.log_photo.Image = Image.FromFile(imagen);
                form.log_photo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void clickInTipo()
        {
            if (form.tb_tipo.SelectedIndex == 0)
            {
                form.tb_colegiado.Visible = true;
                form.label_col.Visible = true;
            }
            else
            {
                form.tb_colegiado.Visible = false;
                form.label_col.Visible = false;
            }
        }

        #endregion

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
            form.tb_provincia.SelectedIndex = -1;
            form.tb_localidad.Text = "";
            form.tb_cp.Text = "";
            form.tb_tel.Text = "";
            form.tb_pass.Text = "";
            form.tb_tipo.SelectedIndex = -1;
            form.tb_sueldo.Text = "";
            form.tb_colegiado.Text = "";

            System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\sinFoto.png", System.IO.FileMode.Open);
            form.log_photo.Image = Image.FromStream(fs);
            fs.Close();
        }
        #endregion

    }
}
