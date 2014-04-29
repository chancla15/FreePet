using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormStartRecepcionistaController
     * Se encarga del control de los botones de la pantalla principal de recepcionista
     */
    public partial class FormStartRecepcionistaController
    {
        /** Datos de sesion */
        public FormLoginDataSessionTicket sessionData;

        /** Formulario a controlar */
        private FormStartRecepcionista form;

        /** Cliente para acer las nbsuquedas a la DB */
        private ClienteCAD _IClienteCAD = new ClienteCAD();

        /**
         * Constructor
         * @param view la vista
         * @param sesion datos de sesion
         */
        public FormStartRecepcionistaController(FormStartRecepcionista f, FormLoginDataSessionTicket sesion) {
            this.form = f;
            this.sessionData = sesion;
        }

        /**
        * Inicializa los datos de sesion FALTA LA FOTO!!!!!!!!!!!!!!!!!!!!!
        */
        private void initPerfil()
        {
            form.log_name.Text = sessionData.name;
            form.log_id.Text = sessionData.TOKEN_SESSION;
            form.log_type.Text = sessionData.tipo;
            form.log_date.Text = sessionData.fecha;
            //la foto
        }


        /**
         * Busca clientes y los muetra en la dataGrid
         */
        public void buscarClientes()
        {
            String buscar = form.text_buscar.Text.ToString();

            if (buscar != "")
            {
                ClienteCEN cen_c = new ClienteCEN();

                IList<ClienteEN> en_cli_nombre = cen_c.BuscarClientePorNombre(buscar);
                IList<ClienteEN> en_cli_apellido = cen_c.BuscarClientePorApellidos(buscar);

                ArrayList dni = new ArrayList(); //para que no aparezca personas repetidas
                bool dni_repetido = false;

                if (en_cli_nombre.Count == 0 && en_cli_apellido.Count == 0)
                    MessageBox.Show("La búsqueda no ha producido ningún resultado");
                else
                {
                    form.dataGrid_clientes.DataSource = null;
                    form.dataGrid_clientes.Refresh();

                    // EStA CONDICION LA QUITO, PORQUE SINO ENCUENTRA NO MOSTRARIA NADA??
                    //if (form.dataGrid_clientes.Rows.Count != 0)
                        form.dataGrid_clientes.Rows.Clear();


                    for (int x = 0; x < en_cli_nombre.Count; x++)
                    {
                        form.dataGrid_clientes.Rows.Add(en_cli_nombre[x].DNI, en_cli_nombre[x].Nombre, en_cli_nombre[x].Apellidos);
                        //metemos el dni en el array auxiliar
                        dni.Add(en_cli_nombre[x].DNI);
                    }

                    for (int i = 0; i < en_cli_apellido.Count; i++)
                    {
                        for (int z = 0; z < dni.Count; z++)
                        {
                            if (en_cli_apellido[i].DNI.Equals(dni[z].ToString()))//Si el dni esta repetido ya no lo ponemos en la busqueda
                                dni_repetido = true;
                        }

                        if (!dni_repetido)
                            form.dataGrid_clientes.Rows.Add(en_cli_apellido[i].DNI, en_cli_apellido[i].Nombre, en_cli_apellido[i].Apellidos);

                        dni_repetido = false;
                    }
                }
            }
            else
                form.dataGrid_clientes.Rows.Clear();
        }

        /** 
         * Devuelve un cliente dependiendo de donde se haya pulsado en el datagrid
         */
        public string getStateScreen(DataGridViewCellEventArgs ev, char action)
        {
            string cli = "";

            if (form.dataGrid_clientes.Columns[ev.ColumnIndex].Name.Equals("Eliminar"))
                action = 'E';
            else if (form.dataGrid_clientes.Columns[ev.ColumnIndex].Name.Equals("Modificar"))
                action = 'M';

            if(action=='E' || action=='M')
                cli = form.dataGrid_clientes.Rows[ev.RowIndex].Cells[0].Value.ToString();

            return cli;
        }    
    }
}
