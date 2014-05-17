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
        private IList<TratamientoEN> lista_tratamientoTotal = null;

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
            lista_tratamientoTotal = Utils._ITratamientoCAD.DameTodosLosTratamientos();
        }

        #endregion

        #region Busquedas

        /**
         * Para buscar mascotas del cliente
         */
        public void Buscar()
        {
            string id = form.text_nombre.Text;
            string dosis = "";

            //Actualizamos la tabla
            form.dataGrid_tratamientos.DataSource = null;
            form.dataGrid_tratamientos.Refresh();

            if (form.dataGrid_tratamientos.Rows.Count > 0)
                form.dataGrid_tratamientos.Rows.Clear();

            if (lista_tratamientoTotal != null)
            {
                if (id != "")
                {
                    for (int i = 0; i < lista_tratamientoTotal.Count; i++)
                    {
                        if (lista_tratamientoTotal[i].Nombre.Contains(id))
                        {
                            if (lista_tratamientoTotal[i].Dosis_diaria.ToString() == "Uno_al_dia")
                                dosis = "1";
                            else if (lista_tratamientoTotal[i].Dosis_diaria.ToString() == "Dos_al_dia")
                                dosis = "2";
                            else
                                dosis = "3";
                            form.dataGrid_tratamientos.Rows.Add(lista_tratamientoTotal[i].Nombre, lista_tratamientoTotal[i].Precio, lista_tratamientoTotal[i].Descripcion, lista_tratamientoTotal[i].Stock, dosis);
                        }
                    }
                }
                else
                {

                    for (int i = 0; i < lista_tratamientoTotal.Count; i++)
                    {
                        if (lista_tratamientoTotal[i].Dosis_diaria.ToString() == "Uno_al_dia")
                            dosis = "1";
                        else if (lista_tratamientoTotal[i].Dosis_diaria.ToString() == "Dos_al_dia")
                            dosis = "2";
                        else
                            dosis = "3";

                        form.dataGrid_tratamientos.Rows.Add(lista_tratamientoTotal[i].Nombre, lista_tratamientoTotal[i].Precio, lista_tratamientoTotal[i].Descripcion, lista_tratamientoTotal[i].Stock, dosis);

                        
                    }

                    
                }


                if (form.dataGrid_tratamientos.RowCount == 0)
                {
                    MessageBox.Show("La búsqueda no ha producido ningún resultado");
                }
            }


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

                if (tratamientoEN.Dosis_diaria.ToString() == "Uno_al_dia")
                {
                    form.lista_dosis.SelectedIndex = 0;
                }
                else if (tratamientoEN.Dosis_diaria.ToString() == "Dos_al_dia")
                {
                    form.lista_dosis.SelectedIndex = 1;
                }
                else
                {
                    form.lista_dosis.SelectedIndex = 2;

                }

                form.lista_dosis.Refresh();
            }
        }

        /**
         * AÑADE, MODFIFICA O ELIMINA UN CLIENTE
         */
        public void ProcesarInformacion()
        {
            string id = form.text_nombre.Text;
            bool ok = false;

            if (Utils._ITratamientoCAD.DameTratamientoPorOID(id) == null)
                form.state = Utils.State.NEW;


            if (form.text_nombre.Text != "")
                tratamientoEN.Nombre = form.text_nombre.Text;
            else
                ok = true;

            if (form.text_descripcion.Text != "")
                tratamientoEN.Descripcion = form.text_descripcion.Text;
            else
                ok = true;

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
            else
                ok = true;

           
            decimal number = 0;
            if (form.text_precio.Text != "" && decimal.TryParse(form.text_stock.Text, out number))
                tratamientoEN.Precio = Convert.ToSingle(form.text_precio.Text);
            else
                ok = true;

            int i = 0;
            if (form.text_stock.Text != "" && int.TryParse(form.text_precio.Text.ToString(), out i))
                tratamientoEN.Stock = Convert.ToInt16(form.text_stock.Text);
            else
                ok = true;


            if (tratamientoEN != null && !ok)
            {
                switch (form.state)
                {
                    case Utils.State.NONE:
                        break;
                    case Utils.State.NEW:
                        Utils._TratamientoCEN.New_(tratamientoEN.Nombre, tratamientoEN.Precio, tratamientoEN.Descripcion, tratamientoEN.Stock, tratamientoEN.Dosis_diaria);
                        MessageBox.Show("Tratamiento insertado con exito");
                        lista_tratamientoTotal.Add(tratamientoEN);
                        break;
                    case Utils.State.MODIFY:
                        lista_tratamientoTotal.Remove(tratamientoEN);
                        Utils._TratamientoCEN.Modify(tratamientoEN.Nombre, tratamientoEN.Precio, tratamientoEN.Descripcion, tratamientoEN.Stock, tratamientoEN.Dosis_diaria);
                        MessageBox.Show("Tratamiento modificado con exito");
                        lista_tratamientoTotal.Add(tratamientoEN);
                        break;
                    case Utils.State.DESTROY:
                        Utils._TratamientoCEN.Destroy(tratamientoEN.Nombre);
                        MessageBox.Show("Tratamiento eliminado con exito");
                        lista_tratamientoTotal.Remove(tratamientoEN);
                        break;
                    default:
                        break;
                }

                ClearForm();
                Buscar();


            }else
                MessageBox.Show("Revisa los campos");

            
           
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

            if (lista_tratamientoTotal != null && lista_tratamientoTotal.Count > 0 && cli != "")
            {
                for (int i = 0; i < lista_tratamientoTotal.Count; i++)
                {
                    if (lista_tratamientoTotal[i].Nombre == cli)
                    {
                        tratamiento = lista_tratamientoTotal[i];
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
            tratamientoEN = new TratamientoEN();
            form.text_nombre.Text = "";
            form.text_nombre.Enabled = true;
            form.text_descripcion.Text = "";
            form.text_precio.Text = "";
            form.text_stock.Text = "";
            form.lista_dosis.SelectedItem = null;
        }
        #endregion
    }
}
