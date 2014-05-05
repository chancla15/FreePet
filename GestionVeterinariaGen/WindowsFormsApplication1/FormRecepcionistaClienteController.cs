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
    /**
     * El controlador de la pantalla de informacion del cliente del recepcionista
     */
    class FormRecepcionistaClienteController
    {
        /** El ticket de sesion */
        public FormLoginDataSessionTicket sessionData;

        /** El formulario a controlar */
        private FormRecepcionistaCliente form;

        /** la lista de mascotas buscadas */
        private IList<MascotaEN> lista_mascotas;

        /** El cliente actual en el formulario */
        public ClienteEN clienteEN = null;

        /**
         * Constructor de clase
         * @param sesion el ticket de sesion
         * @param form el formulario
         */
        public FormRecepcionistaClienteController(FormLoginDataSessionTicket session, FormRecepcionistaCliente form)
        {
            this.sessionData = session;
            this.form = form;
            form.dataGridView.Refresh();
            clienteEN = new ClienteEN();
        }

        /**
         * Para buscar mascotas del cliente
         */
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

        /**
         * Carga un cliente en los text_view
         */
        public void loadData(ClienteEN cliente)
        {
            clienteEN = cliente;

            if (clienteEN != null)
            {
                form.text_dni.Text = clienteEN.DNI;
                Buscar();
            }
            else
                clienteEN = Utils._IClienteCAD.DameClientePorOID(form.text_dni.Text);

            if (clienteEN != null)
            {
                form.text_dni.Text = clienteEN.DNI;
                form.text_nombre.Text = clienteEN.Nombre;
                form.text_apellidos.Text = clienteEN.Apellidos;
                form.text_direccion.Text = clienteEN.Direccion;
                form.text_provincia.Text = clienteEN.Provincia;
                form.text_localidad.Text = clienteEN.Localidad;
                form.text_cp.Text = clienteEN.Cp;
                form.text_telefono.Text = clienteEN.Telefono;
            } 
        }

        /**
         * AÑADE, MODFIFICA O ELIMINA UN CLIENTE
         */
        public void ProcesarInformacion()
        {
            if (clienteEN == null && (form.state==Utils.State.NEW)
                || (clienteEN != null && form.state==Utils.State.MODIFY)
                || (clienteEN!=null && form.state==Utils.State.DESTROY))
            {
                clienteEN.Nombre = form.text_nombre.Text;
                clienteEN.DNI = form.text_dni.Text;
                clienteEN.Apellidos = form.text_apellidos.Text;
                clienteEN.Direccion = form.text_direccion.Text;
                clienteEN.Provincia = form.text_provincia.Text;
                clienteEN.Localidad = form.text_localidad.Text;
                clienteEN.Cp = form.text_cp.Text;
                clienteEN.Telefono = form.text_telefono.Text;
                IList<MascotaEN> mascotas = Utils._IMascotaCAD.DameMascotaPorCliente(clienteEN.DNI);

                switch(form.state)
                {
                    case Utils.State.NONE:
                        break;
                    case Utils.State.NEW:
                            Utils._ClienteCEN.New_(clienteEN.DNI, clienteEN.Nombre, clienteEN.Apellidos, clienteEN.Direccion, clienteEN.Telefono, clienteEN.Localidad, clienteEN.Provincia, clienteEN.Cp, mascotas);
                        break;
                    case Utils.State.MODIFY:
                            Utils._ClienteCEN.Modify(clienteEN.DNI, clienteEN.Nombre, clienteEN.Apellidos, clienteEN.Direccion, clienteEN.Telefono, clienteEN.Localidad, clienteEN.Provincia, clienteEN.Cp);
                        break;
                    case Utils.State.DESTROY:
                             Utils._ClienteCEN.Destroy(clienteEN.DNI);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                //ERROR....DNI MAL (ESTA SI) O OPCION INCORRECTA(QUE NO CREO, PERO X SIACASO)
            }
        }


        /**
         * Devuelve la columna pulsada del datagrid junto con su identficador
         */
        public string getDataGridViewState(DataGridViewCellEventArgs ev, Utils.State st)
        {
            string cli = "";

            if (form.dataGridView.Columns[ev.ColumnIndex].Name.Equals("Eliminar"))
                st = Utils.State.DESTROY;
            else if (form.dataGridView.Columns[ev.ColumnIndex].Name.Equals("Modificar"))
                st = Utils.State.MODIFY;
            else //if (form.dataGridView.Columns[ev.ColumnIndex].Name.Equals("Cliente"))
                form.state = Utils.State.MODIFY;
            //else
              //  st = Utils.State.NONE;

            if (st==Utils.State.DESTROY || st==Utils.State.MODIFY)
                cli = form.dataGridView.Rows[ev.RowIndex].Cells[0].Value.ToString();
            else if (st==Utils.State.NONE && form.state==Utils.State.MODIFY)
                cli = form.dataGridView.Rows[ev.RowIndex].Cells[4].Value.ToString();
            else
                cli = "";

            return cli;
        }

        /** 
         * Pinta el datagridView de la aplicacion
         */
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
        }
    }
}
