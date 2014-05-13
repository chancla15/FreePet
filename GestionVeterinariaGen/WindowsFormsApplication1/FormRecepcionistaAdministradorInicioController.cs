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


        //Inicializa los datos de sesion
        private void initPerfil()
        {
            form.log_name.Text = sessionData.name;
            form.log_id.Text = sessionData.TOKEN_SESSION;
            form.log_type.Text = sessionData.tipo;
            form.log_date.Text = sessionData.fecha;

            try
            {

                System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\" + sessionData.TOKEN_SESSION + ".png", System.IO.FileMode.Open);
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
        #endregion

        #region Busquedas
        //Busca segun el tipo de usuario
        public void buscar()
        {
            if (sessionData.tipo == "Recepcionista"){
                buscarClientes();
                form.dataGrid_clientes.Visible=true;
                form.ListaEmpleados.Visible=false;

            }else if (sessionData.tipo == "Administrador"){
                buscarEmpleados();
                form.ListaEmpleados.Visible=true;
                form.dataGrid_clientes.Visible=false;
            }
        }
        
        /**
         * Busca clientes y los muetra en la dataGrid
         */
        public void buscarClientes()
        {
            String buscar = form.text_buscar.Text.ToString();//String a buscar

            ClienteCEN cen_c = new ClienteCEN();
            /** 
             * BUSQUEDA POR NOMBRE Y APELLIDOS DE CLIENTE
             * **/
            IList<ClienteEN> en_cli_nombre = cen_c.BuscarClientePorNombre(buscar);
            IList<ClienteEN> en_cli_apellido = cen_c.BuscarClientePorApellidos(buscar);

            ArrayList dni = new ArrayList(); //para que no aparezca personas repetidas
            bool dni_repetido = false;

            if (en_cli_nombre.Count == 0 && en_cli_apellido.Count == 0)
            {

                MessageBox.Show("La búsqueda no ha producido ningún resultado");

            }
            else
            {
                form.dataGrid_clientes.DataSource = null;
                form.dataGrid_clientes.Refresh();

                if (form.dataGrid_clientes.Rows.Count != 0)
                {
                    form.dataGrid_clientes.Rows.Clear();
                }


                for (int x = 0; x < en_cli_nombre.Count; x++)
                {
                    form.dataGrid_clientes.Rows.Add(en_cli_nombre[x].DNI, en_cli_nombre[x].Nombre, en_cli_nombre[x].Apellidos);
                    dni.Add(en_cli_nombre[x].DNI);//metemos el dni en el array auxiliar
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

        /**
         * Busca empleados aplicar mismo metodo que clientes pero con empleados
         */
        public void buscarEmpleados()
        {

            String buscar = form.text_buscar.Text.ToString();//String a buscar

            IList<VeterinarioEN> en_vet_apellido = Utils._IVeterinarioCAD.BuscarVetPorApellidos(buscar);
            IList<RecepcionistaEN> en_rec_apellido = Utils._IRecepcionistaCAD.BuscarRecepPorApellidos(buscar);

            VeterinarioEN empleadovet_dni = Utils._IVeterinarioCAD.DameVetarinarioPorOID(buscar);
            IList<VeterinarioEN> en_vet_nombre = Utils._IVeterinarioCAD.BuscarVetPorNombre(buscar);

            RecepcionistaEN empleadore_dni = Utils._IRecepcionistaCAD.BuscarRecepPorOID(buscar);
            IList<RecepcionistaEN> en_rec_nombre = Utils._IRecepcionistaCAD.BuscarRecepPorNombre(buscar);

            ArrayList dni_vet = new ArrayList(); //para que no aparezca personas repetidas
            bool dni_repetido_vet = false;

            ArrayList dni_rec = new ArrayList(); //para que no aparezca personas repetidas
            bool dni_repetido_rece = false;

            if (empleadovet_dni==null && en_vet_nombre.Count == 0 && empleadore_dni==null && en_vet_apellido.Count == 0 && en_rec_nombre.Count == 0 && en_rec_apellido.Count == 0)
            {
                MessageBox.Show("La búsqueda no ha producido ningún resultado");
            }
            else
            {

                form.ListaEmpleados.DataSource = null;
                form.ListaEmpleados.Refresh();

                if (form.ListaEmpleados.Rows.Count != 0)
                {
                    form.ListaEmpleados.Rows.Clear();
                }

                if (empleadovet_dni != null)
                {

                    form.ListaEmpleados.Rows.Add(empleadovet_dni.DNI, empleadovet_dni.Nombre, empleadovet_dni.Apellidos, "Veterinario");
                }
                else
                {

                    for (int x = 0; x < en_vet_nombre.Count; x++)
                    {
                        form.ListaEmpleados.Rows.Add(en_vet_nombre[x].DNI, en_vet_nombre[x].Nombre, en_vet_nombre[x].Apellidos, "Veterinario");
                        dni_vet.Add(en_vet_nombre[x].DNI);//metemos el dni en el array auxiliar
                    }

                    for (int i = 0; i < en_vet_apellido.Count; i++)
                    {

                        for (int z = 0; z < dni_vet.Count; z++)
                        {
                            if (en_vet_apellido[i].DNI.Equals(dni_vet[z].ToString()))//Si el dni esta repetido ya no lo ponemos en la busqueda
                                dni_repetido_vet = true;
                        }

                        if (!dni_repetido_vet)
                            form.ListaEmpleados.Rows.Add(en_vet_apellido[i].DNI, en_vet_apellido[i].Nombre, en_vet_apellido[i].Apellidos, "Veterinario");

                        dni_repetido_vet = false;
                    }
                }

                if (empleadore_dni != null)
                {
                    form.ListaEmpleados.Rows.Add(empleadore_dni.DNI, empleadore_dni.Nombre, empleadore_dni.Apellidos, "Recepcionista");
                }
                else
                {

                    for (int x = 0; x < en_rec_nombre.Count; x++)
                    {
                        form.ListaEmpleados.Rows.Add(en_rec_nombre[x].DNI, en_rec_nombre[x].Nombre, en_rec_nombre[x].Apellidos, "Recepcionista");
                        dni_rec.Add(en_rec_nombre[x].DNI);//metemos el dni en el array auxiliar
                    }
                    for (int i = 0; i < en_rec_apellido.Count; i++)
                    {

                        for (int z = 0; z < dni_rec.Count; z++)
                        {
                            if (en_rec_apellido[i].DNI.Equals(dni_rec[z].ToString()))//Si el dni esta repetido ya no lo ponemos en la busqueda
                                dni_repetido_rece = true;
                        }

                        if (!dni_repetido_rece)
                            form.ListaEmpleados.Rows.Add(en_rec_apellido[i].DNI, en_rec_apellido[i].Nombre, en_rec_apellido[i].Apellidos, "Recepcionista");

                        dni_repetido_rece = false;
                    }
                }
            }
        }

        #endregion

        #region DataGridView_Clientes
        
        /**
         * Pinta el datagrid
         */
        public void paintDataGridView_Clientes(DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && form.dataGrid_clientes.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.dataGrid_clientes.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\delete.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                form.dataGrid_clientes.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                form.dataGrid_clientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;

            }

            if (e.ColumnIndex >= 0 && form.dataGrid_clientes.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.dataGrid_clientes.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\edit.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                form.dataGrid_clientes.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                form.dataGrid_clientes.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }

            
        }

        /** 
         * Devuelve un cliente dependiendo de donde se haya pulsado en el datagrid
         */
        public ClienteEN getStateScreen_Clientes(DataGridViewCellEventArgs ev, ref Utils.State action)
        {
            ClienteEN cliEN = null;
            string cli = "";

            if (form.dataGrid_clientes.Columns[ev.ColumnIndex].Name.Equals("Eliminar"))
                action = Utils.State.DESTROY;
            else if (form.dataGrid_clientes.Columns[ev.ColumnIndex].Name.Equals("Modificar"))
                action = Utils.State.MODIFY;

            if (action == Utils.State.DESTROY || action == Utils.State.MODIFY)
                cli = form.dataGrid_clientes.Rows[ev.RowIndex].Cells[0].Value.ToString();

            for (int i = 0; i < clientes_buscados.Count; i++)
                if (cli.Equals(clientes_buscados[i].DNI))
                {
                    cliEN = clientes_buscados[i];
                    break;
                }

            return cliEN;
        }

        #endregion

        #region DataGrid_EMPELADOS

        public void paintDataGridView_Empleados(DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex >= 0 && form.ListaEmpleados.Columns[e.ColumnIndex].Name == "EliminarEmpleado" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.ListaEmpleados.Rows[e.RowIndex].Cells["EliminarEmpleado"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\delete.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                form.ListaEmpleados.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                form.ListaEmpleados.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;

            }

            if (e.ColumnIndex >= 0 && form.ListaEmpleados.Columns[e.ColumnIndex].Name == "ModificarEmpleado" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.ListaEmpleados.Rows[e.RowIndex].Cells["ModificarEmpleado"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\edit.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+3, e.CellBounds.Top+3);

                form.ListaEmpleados.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                form.ListaEmpleados.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }

        }


        public EmpleadoEN getStateScreen_Empleados(DataGridViewCellEventArgs ev, ref Utils.State action)
        {
            EmpleadoEN empEN = null;
            string emp = "";

            if (form.ListaEmpleados.Columns[ev.ColumnIndex].Name.Equals("EliminarEmpleado"))
                action = Utils.State.DESTROY;
            else if (form.ListaEmpleados.Columns[ev.ColumnIndex].Name.Equals("ModificarEmpleado"))
                action = Utils.State.MODIFY;

            if (action == Utils.State.DESTROY || action == Utils.State.MODIFY)
                emp = form.ListaEmpleados.Rows[ev.RowIndex].Cells[0].Value.ToString();

            for(int i=0;i<empleados_buscados.Count;i++)
                if (emp.Equals(empleados_buscados[i].DNI))
                {
                    empEN = empleados_buscados[i];
                    break;
                }

            return empEN;
        }
        

        #endregion

    }
}
