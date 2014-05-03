using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Windows.Forms;

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

        /** El CAD para acceder a la tabla mascotas */
        private MascotaCAD _IMascotaCAD = new MascotaCAD();

        /** EL CEN para acceder a losd atos de la tabla mascotas */
        private MascotaCEN  MascotaCEN;

        /** El CAD para acceder a la tabla cliente */
        private ClienteCAD _IClienteCAD = new ClienteCAD();

        /** EL CEN para acceder a losd atos de la tabla cliente */
        private ClienteCEN ClienteCEN;

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
            ClienteCEN = new ClienteCEN(_IClienteCAD);
            MascotaCEN = new MascotaCEN(_IMascotaCAD);
        }

        /**
         * Para buscar mascotas del cliente
         */
        public void Buscar()
        {
            String buscar = form.text_buscar.Text;
            String dni = form.text_dni.Text;

            if (form.dataGridView.Rows.Count > 0)
                form.dataGridView.Refresh();

            if (dni != "")
            {
                IList<MascotaEN> mascotas = _IMascotaCAD.DameMascotaPorCliente(dni);

                if (mascotas.Count > 0)
                {
                    if (buscar != "")
                    {
                        //buscamos por nombre
                        for (int i = 0; i < mascotas.Count; i++)
                        {
                            //insertar en datagrid los que coinicdan con el termino a buscar
                        }
                    }
                    else
                    {
                        for (int i = 0; i < mascotas.Count; i++)
                        {
                            //form.dataGridView.Rows.Add(mascotas[i].Nombre, mascotas[i].Especie, mascotas[i].Raza, mascotas[i].Cliente.DNI);
                        }
                    }
                }
            }
            else
            {
                //Error no ha introducido un cliente
            }
        }

        /**
         * Carga un cliente en los text_view
         */
        public void loadData(string cli)
        {
            ClienteEN cliente = _IClienteCAD.DameClientePorOID(cli);

            if (cliente != null)
            {
                form.text_dni.Text = cliente.DNI;
                form.text_nombre.Text = cliente.Nombre;
                form.text_apellidos.Text = cliente.Apellidos;
                form.text_direccion.Text = cliente.Direccion;
                form.text_provincia.Text = cliente.Provincia;
                form.text_localidad.Text = cliente.Localidad;
                form.text_cp.Text = cliente.Cp;
                form.text_telefono.Text = cliente.Telefono;

                IList<MascotaEN> mascotas = MascotaCEN.DameMascotaPorCliente(cliente.DNI);
                form.dataGridView.DataSource = null;
                form.dataGridView.Refresh();

                if (mascotas != null && mascotas.Count>0)
                {
                    for (int i = 0; i < mascotas.Count; i++)
                    {
                        form.dataGridView.Rows.Add(mascotas[i].IdMascota, mascotas[i].Nombre, mascotas[i].Especie, mascotas[i].Raza, mascotas[i].Cliente.DNI);
                    }
                }
            }
            else
            {
                ///ERROR, CLIENTE NO EXISTE
            }
        }

        /**
         * Guarda un nuevo cliente o un cliente modificado
         * @param showType indica si es añadir o modificar
         */
        public void GuardaModificaEliminaCliente(char actionType)
        {
            ClienteEN cliente= _IClienteCAD.DameClientePorOID(form.text_dni.Text);

            if ((cliente == null && (actionType == 'A' || actionType == 'M'))
                || (cliente != null && actionType == 'M')
                || (cliente!=null && actionType=='E'))
            {
                cliente.Nombre = form.text_nombre.Text;
                cliente.DNI = form.text_dni.Text;
                cliente.Apellidos = form.text_apellidos.Text;
                cliente.Direccion = form.text_direccion.Text;
                cliente.Provincia = form.text_provincia.Text;
                cliente.Localidad = form.text_localidad.Text;
                cliente.Cp = form.text_cp.Text;
                cliente.Telefono = form.text_telefono.Text;
                IList<MascotaEN> mascotas = MascotaCEN.DameMascotaPorCliente(cliente.DNI);

                if (actionType == 'A')
                    ClienteCEN.New_(cliente.DNI, cliente.Nombre, cliente.Apellidos, cliente.Direccion, cliente.Telefono, cliente.Localidad, cliente.Provincia, cliente.Cp, mascotas);
                else if (actionType == 'M')
                    ClienteCEN.Modify(cliente.DNI, cliente.Nombre, cliente.Apellidos, cliente.Direccion, cliente.Telefono, cliente.Localidad, cliente.Provincia, cliente.Cp);
                else if (actionType == 'E')
                    ClienteCEN.Destroy(cliente.DNI);
            }
            else
            {
                //ERROR....DNI MAL (ESTA SI) O OPCION INCORRECTA(QUE NO CREO, PERO X SIACASO)
            }
        }

        public string getDataGridViewState(DataGridViewCellEventArgs ev, char action)
        {
            string cli = "";

            if (form.dataGridView.Columns[ev.ColumnIndex].Name.Equals("Eliminar"))
                action = 'E';
            else if (form.dataGridView.Columns[ev.ColumnIndex].Name.Equals("Modificar"))
                action = 'M';

            if (action == 'E' || action == 'M')
                cli = form.dataGridView.Rows[ev.RowIndex].Cells[0].Value.ToString();

            return cli;
        }

        
    }
}
