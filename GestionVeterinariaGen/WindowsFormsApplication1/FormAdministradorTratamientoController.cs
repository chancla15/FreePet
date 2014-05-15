using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormTratamientoAdministradorController
     * Se encarga de la gestion de la vista de tratamientos del administrador
     * de esta vista se podran añadir, modificar y eliminar
     */
    class FormAdministradorTratamientoController
    {
        #region Variables

        /** El formulario a controlar */
        private FormAdministradorTratamiento form;

        /** la lista de mascotas buscadas */
        private IList<TratamientoEN> lista_tratamiento;

        /** El cliente actual en el formulario */
        public TratamientoEN tratamientoEN = null;

        #endregion

        #region Constructor

        /**
         * Constructor de clase
         * @param sesion el ticket de sesion
         * @param form el formulario
         */
        public FormAdministradorTratamientoController(FormAdministradorTratamiento form)
        {
            this.form = form;
            form.dataGrid_tratamientos.Refresh();
            tratamientoEN = new TratamientoEN();
        }

        #endregion

        #region Busquedas

        /**
         * Para buscar mascotas del cliente
         */
        public void Buscar()
        {
            if (lista_tratamiento != null)
            {
                lista_tratamiento.Clear();
                lista_tratamiento = null;
            }

            String id = form.text_nombre.Text;
            String dosis = "";

            //Actualizamos la tabla
            form.dataGrid_tratamientos.DataSource = null;
            form.dataGrid_tratamientos.Refresh();

            if (form.dataGrid_tratamientos.Rows.Count > 0)
                form.dataGrid_tratamientos.Rows.Clear();


            lista_tratamiento = Utils._ITratamientoCAD.DameTodosLosTratamientos(0, 0);

            if (lista_tratamiento != null && lista_tratamiento.Count > 0)
            {

                for (int x = 0; x < lista_tratamiento.Count; x++)
                {

                    if (lista_tratamiento[x].Nombre.Contains(form.text_nombre.Text))
                    {
                        if (lista_tratamiento[x].Dosis_diaria.ToString() == "Uno_al_dia")
                        {
                            dosis = "1";
                        }
                        else if (lista_tratamiento[x].Dosis_diaria.ToString() == "Dos_al_dia")
                        {
                            dosis = "2";
                        }
                        else
                        {
                            dosis = "3";

                        }
                        form.dataGrid_tratamientos.Rows.Add(lista_tratamiento[x].Nombre, lista_tratamiento[x].Precio, lista_tratamiento[x].Descripcion, lista_tratamiento[x].Stock, dosis);
                    }
                }
            }

            /*
            if (lista_tratamiento != null && lista_tratamiento.Count > 0)
                for (int i = 0; i < lista_tratamiento.Count; i++)
                    form.dataGrid_tratamientos.Rows.Add(lista_tratamiento[i].Nombre, lista_tratamiento[i].Precio, lista_tratamiento[i].Descripcion, lista_tratamiento[i].Stock, lista_tratamiento[i].Dosis_diaria);
        
             */
        }

        #endregion

        #region ProcesarDatos

        /**
         * Carga un cliente en los text_view
         */
        public void loadData(TratamientoEN tratamiento)
        {
            tratamientoEN = tratamiento;

            if (tratamientoEN == null)
                tratamientoEN = Utils._ITratamientoCAD.DameTratamientoPorOID(form.text_nombre.Text);

            if (tratamientoEN != null)
            {
                form.text_nombre.Text = tratamientoEN.Nombre;
                form.text_precio.Text = tratamientoEN.Precio.ToString();
                form.text_stock.Text = tratamientoEN.Stock.ToString();
                form.text_descripcion.Text = tratamientoEN.Descripcion;
                form.lista_dosis.SelectedItem = tratamientoEN.Dosis_diaria.ToString();
               // Buscar();
            }
        }

        /**
         * AÑADE, MODFIFICA O ELIMINA UN CLIENTE
         */
        public void ProcesarInformacion()
        {
            if (form.text_nombre.Text != "")
                tratamientoEN.Nombre = form.text_nombre.Text;

            if (form.text_descripcion.Text != "")
                tratamientoEN.Descripcion = form.text_descripcion.Text;

            if (form.lista_dosis.SelectedItem != null)
            {

                if (form.lista_dosis.SelectedItem.ToString() == "1")
                {
                    tratamientoEN.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;
                }
                else if (form.lista_dosis.SelectedItem.ToString() == "2")
                {

                    tratamientoEN.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                }
                else
                {

                    tratamientoEN.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                }

            }

            if (form.text_precio.Text != "")
                tratamientoEN.Precio = Convert.ToSingle(form.text_precio.Text);

            if (form.text_stock.Text != "")
                tratamientoEN.Stock = Convert.ToInt16(form.text_stock.Text);


            MessageBox.Show(tratamientoEN.Nombre + " " + tratamientoEN.Precio + " " + tratamientoEN.Descripcion + " " + tratamientoEN.Stock + " " + tratamientoEN.Dosis_diaria);

            if (tratamientoEN != null)
            {

                switch (form.state)
                {
                    case Utils.State.NONE:
                        break;
                    case Utils.State.NEW:
                        Utils._TratamientoCEN.New_(tratamientoEN.Nombre, tratamientoEN.Precio, tratamientoEN.Descripcion, tratamientoEN.Stock, tratamientoEN.Dosis_diaria);
                        break;
                    case Utils.State.MODIFY:
                        Utils._TratamientoCEN.Modify(tratamientoEN.Nombre, tratamientoEN.Precio, tratamientoEN.Descripcion, tratamientoEN.Stock, tratamientoEN.Dosis_diaria);
                        break;
                    case Utils.State.DESTROY:
                        Utils._TratamientoCEN.Destroy(tratamientoEN.Nombre);
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region DataGridView

        /**
         * Devuelve la columna pulsada del datagrid junto con su identficador
         */
        public TratamientoEN getDataGridViewState(DataGridViewCellEventArgs ev, ref Utils.State st)
        {
            string cli = "";
            TratamientoEN tratamiento = null;
            st = Utils.State.MODIFY;

            Console.WriteLine("EvlRow: " + ev.RowIndex +  " dato: " + form.dataGrid_tratamientos.Rows[ev.RowIndex].Cells[3].Value.ToString());

            cli = form.dataGrid_tratamientos.Rows[ev.RowIndex].Cells[0].Value.ToString();

            if (lista_tratamiento != null && lista_tratamiento.Count > 0 && cli != "")
            {
                for (int i = 0; i < lista_tratamiento.Count; i++)
                {
                    if (lista_tratamiento[i].Nombre == cli)
                    {
                        tratamiento = lista_tratamiento[i];
                        break;
                    }
                }
            }

            return tratamiento;
        }


        #endregion

        #region BorrarTodosLosCampos

        /**
         * Borra todos los campos del formulario
         */
        public void ClearForm()
        {
            tratamientoEN = null;
            if (lista_tratamiento != null)
            {
                lista_tratamiento.Clear();
                lista_tratamiento = null;
            }
            form.text_nombre.Text = "";
            form.text_nombre.Enabled = true;
            form.text_descripcion.Text = "";
            form.text_precio.Text = "";
            form.text_stock.Text = "";
            form.lista_dosis.SelectedItem = null;

            form.dataGrid_tratamientos.DataSource = null;
            form.dataGrid_tratamientos.Refresh();
            if (form.dataGrid_tratamientos.Rows.Count > 0)
                form.dataGrid_tratamientos.Rows.Clear();
        }
        #endregion
    }
}
