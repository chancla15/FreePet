using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormStartRecepcionistaController
     * Se encarga del control de los botones de la pantalla principal de recepcionista
     */
    public partial class FormRecepcionistaAdministradorInicioController
    {
        #region Variables
        /** Datos de sesion */
        public FormLoginDataSessionTicket sessionData;

        /** Formulario a controlar */
        private FormRecepcionistaAdministradorInicio form;

        /** Lista de clientes obtenidos en la busqueda */
        private List<ClienteEN> clientes_buscados;

        /** Lista de empleados mostrados */
        private List<EmpleadoEN> empleados_buscados;
        #endregion

        #region Constructor
        /**
         * Constructor
         * @param view la vista
         * @param sesion datos de sesion
         */
        public FormRecepcionistaAdministradorInicioController(FormRecepcionistaAdministradorInicio f, FormLoginDataSessionTicket sesion) {
            this.form = f;
            this.sessionData = sesion;
            initPerfil();
            clientes_buscados = new List<ClienteEN>();
            empleados_buscados = new List<EmpleadoEN>();
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
        #endregion

        #region Busquedas
        //Busca segun el tipo de usuario
        public void buscar()
        {
            if (sessionData.tipo == "Recepcionista")
                buscarClientes();
            else if (sessionData.tipo == "Administrador")
                buscarEmpleados();
        }
        
        /**
         * Busca clientes y los muetra en la dataGrid
         */
        public void buscarClientes()
        {
            form.dataGrid_clientes.DataSource = null;
            form.dataGrid_clientes.Refresh();

            if(clientes_buscados!=null)
                clientes_buscados.Clear();

            String buscar = form.text_buscar.Text.ToString();

            if (buscar != "")
            {
                ClienteEN cliente_dni = Utils._IClienteCAD.DameClientePorOID(buscar);
                IList<ClienteEN> clientes_nombre = Utils._IClienteCAD.BuscarClientePorNombre(buscar);
                IList<ClienteEN> clientes_apellidos = Utils._IClienteCAD.BuscarClientePorApellidos(buscar);
                List<string> dni = new List<string>();

                if (cliente_dni == null && clientes_nombre.Count == 0 && clientes_apellidos.Count == 0)
                    MessageBox.Show("La búsqueda no ha producido ningún resultado");
                else
                {
                    if (cliente_dni != null)
                    {
                        clientes_buscados.Add(cliente_dni);
                        dni.Add(cliente_dni.DNI);
                    }

                    if (clientes_nombre != null && clientes_nombre.Count > 0)
                    {
                        for (int i = 0; i < clientes_nombre.Count; i++)
                        {
                            if (!dni.Contains(clientes_nombre[i].DNI))
                            {
                                clientes_buscados.Add(clientes_nombre[i]);
                                dni.Add(clientes_nombre[i].DNI);
                            }
                        }
                    }

                    if (clientes_apellidos != null && clientes_apellidos.Count > 0)
                    {
                        for (int i = 0; i < clientes_apellidos.Count; i++)
                        {
                            if (!dni.Contains(clientes_apellidos[i].DNI))
                            {
                                clientes_buscados.Add(clientes_apellidos[i]);
                                dni.Add(clientes_apellidos[i].DNI);
                            }
                        }
                    }

                    dni.Clear();

                    for (int i = 0; i < clientes_buscados.Count; i++)
                        form.dataGrid_clientes.Rows.Add(clientes_buscados[i].DNI, clientes_buscados[i].Nombre, clientes_buscados[i].Apellidos);



                    /*for (int x = 0; x < en_cli_nombre.Count; x++)
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
                    }*/
                }
            }
        }


        /**
         * Busca empleados aplicar mismo metodo que clientes pero con empleados
         */
        public void buscarEmpleados()
        {
            String buscar = form.text_buscar.Text;

            EmpleadoEN empleado_dni = null;
            IList<EmpleadoEN> empleado_name = null;
            IList<EmpleadoEN> empleado_surname = null;
            ArrayList dniOnDataGrind = new ArrayList();


            if (buscar != "")
            {
                form.dataGrid_clientes.DataSource = null;
                form.dataGrid_clientes.Refresh();
                form.dataGrid_clientes.Rows.Clear();

                empleado_dni = Utils._IEmpleadoCAD.DameEmpleadoPorOID(buscar);
                //empleado_name = _IEmpleadoCAD.DameEmpleadoPorNombre(buscar);
                //empleado_surname = _IEmpleadoCAD.DameEmpleadoPorApellidos(buscar);

                if (empleado_name == null && empleado_surname == null && empleado_dni==null)
                    MessageBox.Show("La búsqueda no ha producido ningún resultado");
                else
                {
                    if (empleado_dni != null) {
                        form.dataGrid_clientes.Rows.Add(empleado_dni.DNI, empleado_dni.Nombre, empleado_dni.Apellidos);
                        dniOnDataGrind.Add(empleado_dni.DNI);
                    }

                    if (empleado_name!=null && empleado_name.Count > 0) {
                        for (int x = 0; x < empleado_name.Count; x++) {
                            if (!dniOnDataGrind.Contains(empleado_name[x].DNI)) {
                                form.dataGrid_clientes.Rows.Add(empleado_name[x].DNI, empleado_name[x].Nombre, empleado_name[x].Apellidos);
                                dniOnDataGrind.Add(empleado_name[x].DNI);
                            }
                        }
                    }
                    if (empleado_surname!=null && empleado_surname.Count > 0) {
                        for (int x = 0; x < empleado_surname.Count; x++) {
                            if (!dniOnDataGrind.Contains(empleado_surname[x].DNI)) {
                                form.dataGrid_clientes.Rows.Add(empleado_surname[x].DNI, empleado_surname[x].Nombre, empleado_surname[x].Apellidos);
                                dniOnDataGrind.Add(empleado_surname[x].DNI);
                            }
                        }
                    }
                    dniOnDataGrind.Clear();
                }
            }
            else
                form.dataGrid_clientes.Rows.Clear();
        }
        #endregion

        #region DataGridView_Clientes
        
        /**
         * Pinta el datagrid
         */
        public void paintDataGridView(DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && form.dataGrid_clientes.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.dataGrid_clientes.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\close-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                form.dataGrid_clientes.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                form.dataGrid_clientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;

            }

            if (e.ColumnIndex >= 0 && form.dataGrid_clientes.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.dataGrid_clientes.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\edit-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                form.dataGrid_clientes.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                form.dataGrid_clientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }
        }

        /** 
         * Devuelve un cliente dependiendo de donde se haya pulsado en el datagrid
         */
        public ClienteEN getStateScreen(DataGridViewCellEventArgs ev, ref Utils.State action)
        {
            ClienteEN cliEN = null;
            string cli = "";

            if (form.dataGrid_clientes.Columns[ev.ColumnIndex].Name.Equals("Eliminar"))
                action = Utils.State.DESTROY;
            else if (form.dataGrid_clientes.Columns[ev.ColumnIndex].Name.Equals("Modificar"))
                action = Utils.State.MODIFY;

            if (action == Utils.State.DESTROY || action == Utils.State.MODIFY)
                cli = form.dataGrid_clientes.Rows[ev.RowIndex].Cells[0].Value.ToString();

            for(int i=0;i<clientes_buscados.Count;i++)
                if (cli.Equals(clientes_buscados[i].DNI))
                {
                    cliEN = clientes_buscados[i];
                    break;
                }

            return cliEN;
        }

        #endregion
    }
}
