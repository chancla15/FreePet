using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Collections;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormFacturaRecepcionistaController
     * La encargada de controlar la vista facturas
     */
    class FormFacturaRecepcionistaController
    {
        /** El formulario a controlar */
        private FormFacturaRecepcionista form;

        /** El ticket de sesion */
        public FormLoginDataSessionTicket sessionData;

        /**
         * El constructor
         * @param s el ticket de sesion
         * @param f el formulario a controlar
         */
        public FormFacturaRecepcionistaController(FormLoginDataSessionTicket s, FormFacturaRecepcionista f)
        {
            this.sessionData = s;
            this.form = f;
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
         * Buscar facturas
         */
        public void Buscar()
        {
            String buscar = form.text_buscar.Text.ToString();//String a buscar

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
                    form.dataGridView1.DataSource = null;
                    form.dataGridView1.Refresh();

                    if (form.dataGridView1.Rows.Count != 0)
                        form.dataGridView1.Rows.Clear();

                    for (int x = 0; x < en_cli_nombre.Count; x++) {
                        form.dataGridView1.Rows.Add(en_cli_nombre[x].DNI, en_cli_nombre[x].Nombre, en_cli_nombre[x].Apellidos);
                        dni.Add(en_cli_nombre[x].DNI);//metemos el dni en el array auxiliar
                    }

                    for (int i = 0; i < en_cli_apellido.Count; i++) {
                        for (int z = 0; z < dni.Count; z++) {
                            if (en_cli_apellido[i].DNI.Equals(dni[z].ToString()))//Si el dni esta repetido ya no lo ponemos en la busqueda
                                dni_repetido = true;
                        }

                        if (!dni_repetido)
                            form.dataGridView1.Rows.Add(en_cli_apellido[i].DNI, en_cli_apellido[i].Nombre, en_cli_apellido[i].Apellidos);

                        dni_repetido = false;
                    }
                }
            }
        }


        public string getScreenState(DataGridViewCellEventArgs ev, char action)
        {
            string cli = "";

            if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Eliminar"))
                action = 'E';
            else if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Modificar"))
                action = 'M';
            else if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Añadir"))
                action = 'A';

            if (action == 'E' || action == 'M' || action == 'A')
                cli = form.dataGridView1.Rows[ev.RowIndex].Cells[0].Value.ToString();

            return cli;
        }
    }
}
