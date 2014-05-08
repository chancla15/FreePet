using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Collections;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using System.Drawing;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormFacturaRecepcionistaController
     * La encargada de controlar la vista facturas
     */
    class FormRecepcionistaFacturaController
    {
        #region Variables

        /** El formulario a controlar */
        private FormRecepcionistaFactura form = null;

        private IList<FacturaEN> facturas = null;
        private IList<MascotaEN> mascotas = null;
        private IList<ConsultaEN> consultas = null;
        private IList<TratamientoEN> tratamientos = null;

        /** Cliente */
        private ClienteEN cliente;

        /** Factura */
        private FacturaEN factura = null;

        #endregion

        #region Constructor

        /**
         * El constructor
         * @param s el ticket de sesion
         * @param f el formulario a controlar
         */
        public FormRecepcionistaFacturaController(FormRecepcionistaFactura form)
        {
            this.form = form;

            /**
             * Cambiado a LOAD_DATA
             * 
             * 
             * BORRAR ESTO DESPUES DE LEERLO
             * 
             * 
            tratamientos = Utils._ITratamientoCAD.DameTodosLosTratamientos(0, 17);
            cliente = Utils._IClienteCAD.DameClientePorOID(dni);
            mascotas = Utils._IMascotaCAD.DameMascotaPorCliente(cliente.DNI);
             * 
             */
        }

        /**
         * Carga los datos de un cliente que le pasas por parametro
         * @param dni el dni del cliente a cargar
         */
        public void loadData(string dni)
        {
            //Este READ_ALL HAY QUE MEJORARLO.....(0,17)...LOL XD jajajajajajajajajajajaja 
            //OHH4RIA   smoking real resionosous weed VERY VERY VERYYYY....... JAJAJAJAJA
            tratamientos = Utils._ITratamientoCAD.DameTodosLosTratamientos(0, 17);

            if (dni != "")
                cliente = Utils._IClienteCAD.DameClientePorOID(dni);
            else
            {
                //ERRROR; DEBE INTRODUCIR UN CLIENTE
            }

            //Aver meto esto de aqui para los demas metodos para que si le paso un dni nulo
            //por paramtetro cargue las consultas del cliente que hay en el text_box

            if (cliente != null)
            {
                mascotas = Utils._IMascotaCAD.DameMascotaPorCliente(cliente.DNI);

                facturas = new FacturaCEN().DameFacturasPorCliente(cliente.DNI);
                form.l_Nombre.Text = cliente.Nombre + " " + cliente.Apellidos;

                form.dataGridView1.Rows.Clear();

                for (int i = 0; i < facturas.Count; i++)
                {
                    //Num, fecha, total, mascota, motivo, tratamiento, pagada
                    //
                    //  CAMBIO BORRAR COMENTARIO DESPUES DE LEER
                    //
                    //Es cambio el num (i+1) opr el facturas[i].IdFactura
                    form.dataGridView1.Rows.Add(facturas[i].IdFactura, facturas[i].Fecha, facturas[i].Total, new MascotaCEN().BuscarMascotaPorOID(facturas[i].Consulta.Mascota.IdMascota).Nombre,
                        facturas[i].Consulta.MotivoConsulta, facturas[i].Consulta.Tratamiento.Nombre, facturas[i].Pagada == true ? "Si" : "No");
                }
            }
        }

        #endregion

        #region DataGridView

        /**
         * Esto es cuando se pulsa en un campo del dataGridView
         * Te devuelve una factura con sus datos y un estado pasado por paramtros
         * @param state el estado a modificar si se debe
         */
        public FacturaEN getScreenState(DataGridViewCellEventArgs ev, ref Utils.State state)
        {
            FacturaEN factAux = null;

            if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Eliminar"))
                state = Utils.State.DESTROY;
            else if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Modificar"))
                state = Utils.State.MODIFY;
            else if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Añadir"))
                state = Utils.State.NEW;
            else
                state = Utils.State.NONE;

            int id_fact= Convert.ToInt32(form.dataGridView1.Rows[ev.RowIndex].Cells[0].Value.ToString());

            if (state != Utils.State.NONE)
                factAux = Utils._IFacturaCAD.DameFacturaPorOID(id_fact);

            return factAux;

            
            
            /**
             * ESTO LEER Y BORRARLO
             * 
             * 
             * string cli = "";

            if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Eliminar"))
                action = 'E';
            else if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Modificar"))
                action = 'M';
            else if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Añadir"))
                action = 'A';

            if (action == 'E' || action == 'M' || action == 'A')
                cli = form.dataGridView1.Rows[ev.RowIndex].Cells[0].Value.ToString();

            return cli;**/
        }

        /**
         * Pinta el datagrid /BOTONES MODIFICAR Y ELIMINAR
         */
        public void paintDataGrid(DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && form.dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.dataGridView1.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\close-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                form.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                form.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;

            }

            if (e.ColumnIndex >= 0 && form.dataGridView1.Columns[e.ColumnIndex].Name == "Añadir" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.dataGridView1.Rows[e.RowIndex].Cells["Añadir"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\add-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                form.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                form.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;

            }


            if (e.ColumnIndex >= 0 && form.dataGridView1.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.dataGridView1.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\edit-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                form.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                form.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }
        }

        #endregion


        /*
         *  SUSTITUIDO_POR_LOAD_DATA EN REGION CONSTRUCTOR
         *  
         *  BORRAR ESTE CODIGO DESPUES DE LEER ESTO 
         * 
         * public void CargarFacturasDataGrid()
        {
            if (cliente != null && cliente.DNI != "")
            {

                facturas = new FacturaCEN().DameFacturasPorCliente(cliente.DNI);
                form.l_Nombre.Text = cliente.Nombre + " " + cliente.Apellidos;

                form.dataGridView1.Rows.Clear();

                for (int i = 0; i < facturas.Count; i++)
                {
                    //Num, fecha, total, mascota, motivo, tratamiento, pagada
                    form.dataGridView1.Rows.Add(i + 1, facturas[i].Fecha, facturas[i].Total, new MascotaCEN().BuscarMascotaPorOID(facturas[i].Consulta.Mascota.IdMascota).Nombre,
                        facturas[i].Consulta.MotivoConsulta, facturas[i].Consulta.Tratamiento.Nombre, facturas[i].Pagada == true ? "Si" : "No");

                }
            }

        }*/



        #region ProcesarDatos





        #endregion



        public void CargarGroupBoxModificar(int indiceFactura)
        {
            form.gp_ModificarFactura.Visible = true;

            factura = facturas[indiceFactura];

            String nombreMascota = new MascotaCEN().BuscarMascotaPorOID(factura.Consulta.Mascota.IdMascota).Nombre;

            form.tb_Fecha.Text = factura.Fecha.ToString();
            form.tb_Total_gpModificar.Text = factura.Total.ToString();
            form.tb_Pagada_gpModificar.Text = factura.Pagada ? "Si" : "No";
            form.tb_Motivo.Text = factura.Consulta.MotivoConsulta;
            form.tb_Mascota.Text = nombreMascota;
            form.tb_Tratamiento.Text = factura.Consulta.Tratamiento.Nombre;

            for (int i = 0; i < mascotas.Count; i++)
                form.cb_Mascota.Items.Add(mascotas[i].Nombre);

            for (int i = 0; i < tratamientos.Count; i++)
                form.cb_Tratamiento.Items.Add(tratamientos[i].Nombre + " (" + tratamientos[i].Precio + ")");
        }
        

        public void CargarGroupBoxCrear()
        {
             
            form.tb_Pagada_gpCrear.Clear();
            form.tb_Total_gpCrear.Clear();
            form.cb_Consultas.Items.Clear();
            form.cb_Consultas.Refresh();
            form.cb_Consultas.ResetText();
            form.gp_CrearFactura.Visible = true;
            consultas = new List<ConsultaEN>();
            IList<ConsultaEN> consultasaux = null;
            
            //AQUI TE METO ALGUNAS COMPROBACIONES
            if (mascotas != null)
            {


                //Estos 2 for sirven para meter las consultas asignadas a todas las mascotas(del cliente en cuestion) al combobox
                for (int i = 0; i < mascotas.Count; i++)
                {
                    consultasaux = new ConsultaCEN().DameConsultaPorAnimal(mascotas[i].IdMascota);

                    //TE METO OTRA COMPROBACION
                    if (consultasaux != null)
                    {
                        for (int j = 0; j < consultasaux.Count; j++)
                        {
                            //Metemos al combobox solo las consultas que tengan la clave ajena de factura a null
                            //porque eso signfica que no estan asiganadas a ninguna factura
                            if (FacturaEN.ReferenceEquals(consultasaux[j].Factura, null))
                                consultas.Add(consultasaux[j]);
                        }
                        consultasaux.Clear();
                    }
                }

                //TE METO OTRA COMPROBACION
                if (consultas != null)
                {
                    for (int i = 0; i < consultas.Count; i++)
                    {
                        form.cb_Consultas.Items.Add("Fecha: " + consultas[i].Fecha.ToString() + ", Mascota: "
                            + new MascotaCEN().BuscarMascotaPorOID(consultas[i].Mascota.IdMascota).Nombre + ", Motivo: "
                            + consultas[i].MotivoConsulta + ", Tratamiento: " + consultas[i].Tratamiento.Nombre + ", Coste: "
                            + new TratamientoCEN().DameTratamientoPorOID(consultas[i].Tratamiento.Nombre).Precio);
                    }
                }
            }
        }
        public void EliminarFactura()
        {
            new FacturaCEN().Destroy(factura.IdFactura);
            form.gp_ModificarFactura.Visible = false;
            form.dataGridView1.Rows.Clear();


            //CAMBIO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //CargarFacturasDataGrid();
            loadData("");
        }

        public void ModificarFactura()
        {
            FacturaCEN FacturaCEN = new FacturaCEN();
            //Guardamos la consulta de la factura actual para modificar los campos necesarios e introducirla en la factura nueva(ya que al modificar no deja modificar la consulta)
            ConsultaEN c1 = factura.Consulta;
            c1.MotivoConsulta = form.tb_Motivo.Text;
            //Si no has seleccionado una mascota del combobox o es la misma no modifica la mascota
            if (!String.IsNullOrEmpty(form.cb_Mascota.Text))
                c1.Mascota = mascotas[form.cb_Mascota.SelectedIndex];

            //Lo mismo para los tratamientos
            //Los tratamientos petan ahora mismo al cambiarlos por alguna razon, para ver el error modificar 2 veces un tratamiento
            if (!String.IsNullOrEmpty(form.cb_Tratamiento.Text))
                c1.Tratamiento = tratamientos[form.cb_Tratamiento.SelectedIndex];
            
            if (!c1.Equals(factura.Consulta))
            {
                FacturaCEN.Destroy(factura.IdFactura);
                FacturaCEN.New_(DateTime.Parse(form.tb_Fecha.Text), float.Parse(form.tb_Total_gpModificar.Text), factura.Cliente.DNI, c1, form.tb_Pagada_gpModificar.Text.Equals("Si") ? true : false);
            }
            else
                FacturaCEN.Modify(factura.IdFactura, DateTime.Parse(form.tb_Fecha.Text), float.Parse(form.tb_Total_gpModificar.Text), form.tb_Pagada_gpModificar.Text.Equals("Si") ? true : false);

            form.gp_ModificarFactura.Visible = false;
            form.dataGridView1.Rows.Clear();
            
            
            
            //CAMBIO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            
            //CargarFacturasDataGrid();
            loadData("");
        }

        public void CrearFactura()
        {
            ConsultaEN c = new ConsultaEN(consultas[form.cb_Consultas.SelectedIndex]);
            new FacturaCEN().New_(c.Fecha, float.Parse(form.tb_Total_gpCrear.Text), cliente.DNI, c, form.tb_Pagada_gpCrear.Text.Equals("Si") ? true : false);
            //Aqui hay que borrar la consulta por que si no se creara duplicada pero con la clave ajena a factura apuntando a la consulta
            //esta consulta que borramos tiene la clave ajena a factura null
            new ConsultaCEN().Destroy(consultas[form.cb_Consultas.SelectedIndex].IdConsulta);
            consultas.RemoveAt(form.cb_Consultas.SelectedIndex);
            form.gp_CrearFactura.Visible = false;
           
            
            //CAMBIO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //CargarFacturasDataGrid();
            loadData("");
        }

    }
}
