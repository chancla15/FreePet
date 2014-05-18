/* 
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class FormRecepcionistaClienteController
    {
        #region Variables
        private FormRecepcionistaCliente form;
        private IList<MascotaEN> lista_mascotas;
        public ClienteEN clienteEN = null;

        #endregion

        #region Constructor

        public FormRecepcionistaClienteController(FormRecepcionistaCliente form)
        {
            this.form = form;
            form.dataGridView.Refresh();
            clienteEN = new ClienteEN();
        }

        #endregion

        #region Busquedas

        public void Buscar()
        {
            if (lista_mascotas != null) {
                lista_mascotas.Clear();
                lista_mascotas = null;
            }

            String buscar = form.text_buscar.Text;
            String dni = form.text_dni.Text;

            //Actualizamos la tabla
            form.dataGridView.DataSource = null;
            form.dataGridView.Refresh();

            if (form.dataGridView.Rows.Count > 0)
                form.dataGridView.Rows.Clear();

            //Buscamos por cliente si el dni se ha introducido para buscar
            if (dni != "") {
                lista_mascotas = Utils._IMascotaCAD.DameMascotaPorCliente(dni);
                clienteEN.DNI = dni;
            }

            //Buscamos por termino si se ha introducido un termino de busqueda
            if (buscar != "")
            {
                //Si no se ha buscado por cliente buscamos por nombre
                //Sino buscamos con ese nombre las que tengan ese cliente
                if (lista_mascotas == null)
                    lista_mascotas = Utils._IMascotaCAD.DameMascotaPorNombre(buscar);
                else
                {
                    ///Hago esto porque la lista de mascotas que he buscado es la del cliente, y para no tener
                    /////que volver a calcular esa llamada a la DDBB mas tarde
                    clienteEN.Mascota = lista_mascotas;

                    lista_mascotas = null;
                    lista_mascotas = Utils._IMascotaCAD.DameMascotaPorNombre(buscar);

                    //Si tambien se ha introducido un cliente solo se muestran las de ese nombre 
                    //que tengas ese cliente
                    if (lista_mascotas != null && lista_mascotas.Count > 0)
                    {
                        Console.WriteLine("Cantidad mascotas antes: " + lista_mascotas.Count);
                        for (int i = 0; i < lista_mascotas.Count; i++)
                        {
                            Console.WriteLine("Mascota: " + lista_mascotas[i].Cliente.DNI + " Cliente: " + clienteEN.DNI);
                            if (lista_mascotas[i].Cliente.DNI != clienteEN.DNI)
                            {
                                Console.WriteLine("bORRO MASCot");
                                lista_mascotas.Remove(lista_mascotas[i]);
                            }
                        }
                        Console.WriteLine("Cantidad mascotas despues: " + lista_mascotas.Count);
                    }
                }
            }
            else
            {
                //Si no se ha introducido nada mostramos todas las mascotas
                if (lista_mascotas == null)
                    lista_mascotas = Utils._IMascotaCAD.ContadorMascotas();
            }

            //Console.WriteLine("Macotas a mostrar: " + lista_mascotas.Count);
            //Al final, mostramos la lista de mascotas
            if (lista_mascotas != null && lista_mascotas.Count > 0)
                for (int i = 0; i < lista_mascotas.Count; i++)
                    form.dataGridView.Rows.Add(lista_mascotas[i].IdMascota, lista_mascotas[i].Nombre, lista_mascotas[i].Especie, lista_mascotas[i].Raza, lista_mascotas[i].Cliente.DNI);
        }

        #endregion

        #region ProcesarDatos

        public void cargarDatosCliente(ClienteEN cliente)
        {
            clienteEN = cliente;

            if (clienteEN != null)
            {
                form.changeState(Utils.State.MODIFY);
                form.text_dni.Text = clienteEN.DNI;
                form.text_nombre.Text = clienteEN.Nombre;
                form.text_apellidos.Text = clienteEN.Apellidos;
                form.text_direccion.Text = clienteEN.Direccion;
                form.text_provincia.Text = clienteEN.Provincia;
                form.text_localidad.Text = clienteEN.Localidad;
                form.text_cp.Text = clienteEN.Cp;
                form.text_telefono.Text = clienteEN.Telefono;

                //Cargamos la imagen
                try
                {

                    System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\" + clienteEN.DNI + ".png", System.IO.FileMode.Open);
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

                Buscar();
            }
        }

        public void ProcesarInformacion()
        {

            Boolean fail = false;

                if (form.text_nombre.Text != "")
                {
                    clienteEN.Nombre = form.text_nombre.Text;
                }
                else
                {
                    fail = true;

                }

                if (form.text_dni.Text != "")
                {
                    clienteEN.DNI = form.text_dni.Text;
                }
                else
                {
                    fail = true;
                }

                if (form.text_apellidos.Text != "")
                {
                    clienteEN.Apellidos = form.text_apellidos.Text;
                }
                else
                {
                    fail = true;
                }

                if (form.text_direccion.Text != "")
                {
                    clienteEN.Direccion = form.text_direccion.Text;
                }
                else
                {
                    fail = true;
                }

                if (form.text_provincia.Text != "")
                {
                    clienteEN.Provincia = form.text_provincia.Text;
                }
                else
                {
                    fail = true;
                }

                if (form.text_localidad.Text != "")
                {
                    clienteEN.Localidad = form.text_localidad.Text;
                }
                else
                {
                    fail = true;
                }

                if (form.text_cp.Text != "")
                {
                    clienteEN.Cp = form.text_cp.Text;
                }
                else
                {
                    fail = true;
                }

                if (form.text_telefono.Text != "")
                {
                    clienteEN.Telefono = form.text_telefono.Text;
                }
                else
                {
                    fail = true;
                }

                IList<MascotaEN> mascotas = Utils._IMascotaCAD.DameMascotaPorCliente(clienteEN.DNI);

                if (mascotas.Count == 0)
                {

                    mascotas = null;
                }

                if (!fail)
                {

                    switch (form.state)
                    {
                        case Utils.State.NONE:
                            break;
                        case Utils.State.NEW:
                            Utils._ClienteCEN.New_(clienteEN.DNI, clienteEN.Nombre, clienteEN.Apellidos, clienteEN.Direccion, clienteEN.Telefono, clienteEN.Localidad, clienteEN.Provincia, clienteEN.Cp, mascotas);
                            MessageBox.Show("Cliente creado con exito");
                            form.log_photo.Image.Save(Environment.CurrentDirectory + @"\" + clienteEN.DNI + ".png");
                            break;
                        case Utils.State.MODIFY:
                            Utils._ClienteCEN.Modify(clienteEN.DNI, clienteEN.Nombre, clienteEN.Apellidos, clienteEN.Direccion, clienteEN.Telefono, clienteEN.Localidad, clienteEN.Provincia, clienteEN.Cp);
                            MessageBox.Show("Cliente modiificada con exito");
                            form.log_photo.Image.Save(Environment.CurrentDirectory + @"\" + clienteEN.DNI + ".png");
                            break;
                        case Utils.State.DESTROY:
                            Utils._ClienteCEN.Destroy(clienteEN.DNI);
                            MessageBox.Show("Cliente eliminado con exito");
                            System.IO.File.Delete(Environment.CurrentDirectory + @"\" + clienteEN.DNI.ToString() + ".png");
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("Revisa los campos");
                }
            }

        #endregion

        #region DataGridView

        public MascotaEN getDataGridViewState(DataGridViewCellEventArgs ev, ref Utils.State st, ref ClienteEN aux_cliente)
        {
            string IdMascota = "", idCliente = "";
            MascotaEN mascota = null;

            if (form.dataGridView.Columns[ev.ColumnIndex].Name.Equals("Ver"))
            {
                st = Utils.State.MODIFY;
                IdMascota = form.dataGridView.Rows[ev.RowIndex].Cells[0].Value.ToString();
                if (lista_mascotas != null && lista_mascotas.Count > 0 && IdMascota != "")
                {
                    for (int i = 0; i < lista_mascotas.Count; i++)
                    {
                        if (lista_mascotas[i].IdMascota == Convert.ToInt32(IdMascota))
                        {
                            mascota = lista_mascotas[i];
                            break;
                        }
                    }
                }
            }
            else 
            {
                idCliente = form.dataGridView.Rows[ev.RowIndex].Cells[4].Value.ToString();
                if (idCliente != "")
                    aux_cliente = Utils._IClienteCAD.DameClientePorOID(idCliente);
            }
           
            return mascota;
        }

        public void paintDataGrid(DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && form.dataGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                /*e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.dataGridView.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\close-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left, e.CellBounds.Top);

               // form.dataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                //form.dataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;*/

            }

            if (e.ColumnIndex >= 0 && form.dataGridView.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
               /* e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.dataGridView.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\edit-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left, e.CellBounds.Top);

                //form.dataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                //form.dataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;*/
            }
        }

        #endregion

        #region BorrarTodosLosCampos

        /**
         * Borra todos los campos del formulario
         */
        public void ClearForm()
        {
            clienteEN = null;
            if (lista_mascotas != null)
            {
                lista_mascotas.Clear();
                lista_mascotas = null;
            }
            form.text_dni.Text = "";
            form.text_dni.Enabled = true;
            form.text_nombre.Text = "";
            form.text_apellidos.Text = "";
            form.text_direccion.Text = "";
            form.text_provincia.Text = "";
            form.text_localidad.Text = "";
            form.text_cp.Text = "";
            form.text_telefono.Text = "";
            form.dataGridView.DataSource = null;
            form.dataGridView.Refresh();
            if (form.dataGridView.Rows.Count > 0)
                form.dataGridView.Rows.Clear();

            System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\sinFoto.png", System.IO.FileMode.Open);
            form.log_photo.Image = Image.FromStream(fs);
            fs.Close();


        }
        #endregion

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
    }
}
