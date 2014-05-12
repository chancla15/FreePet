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
        
        /** Factura */
        private FacturaEN factura = null;
        /** DNI del cliente*/
        private String DNI = "";

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

        }

        /**
         * Carga los datos de un cliente que le pasas por parametro
         * @param dni el dni del cliente a cargar
         */
        public void loadData(string dni)
        {
            List<String> lista = new List<String>();
            lista.Add("hola");
            lista.Add("adios");
            //Cliente creado aqui ya que se necesita poner a null y solo se utiliza aqui
            ClienteEN cliente = null;

            if (dni != "")
                cliente = Utils._IClienteCAD.DameClientePorOID(dni);

            if(cliente == null)
            {
                form.text_dni.Text = "DNI Incorrecto";
                form.text_dni.Enabled = false;
            }
            
            if (cliente != null)
            {
                this.DNI = dni; //Lo guardo aqui porque puede dar problemas al introducir un dni incorrecto cuando ya has cargado uno correcto
                mascotas = Utils._IMascotaCAD.DameMascotaPorCliente(cliente.DNI);

                facturas = Utils._IFacturaCAD.DameFacturasPorCliente(cliente.DNI);
                form.l_Nombre.Text = cliente.Nombre + " " + cliente.Apellidos;

                form.dataGridView1.Rows.Clear();

                
                for (int i = 0; i < facturas.Count; i++)
                {
                    //Num, pagar, fecha, total, mascota, motivo, tratamiento, pagada
                    form.dataGridView1.Rows.Add(facturas[i].IdFactura, facturas[i].Fecha, facturas[i].Total, Utils._IMascotaCAD.BuscarMascotaPorOID(facturas[i].Consulta.Mascota.IdMascota).Nombre,
                        facturas[i].Consulta.MotivoConsulta, null, facturas[i].Pagada == true ? "Si" : "No", "");
                    /*DataGridViewComboBoxColumn cb_tratamientos = form.dataGridView1.Columns["Tratamiento"] as DataGridViewComboBoxColumn;
                    cb_tratamientos.DataSource = lista;
                    form.dataGridView1.Update();*/
                }
                /*foreach (DataGridViewRow row in form.dataGridView1.Rows)
                {

                    for (int j = 0; j < lista.Count; j++)
                    {
                        ((DataGridViewComboBoxCell)row.Cells[5]).Items.Add(lista[j]);
                    }
                }*/
            }
        }

        #endregion

        #region DataGridView
        public FacturaEN getScreenState(DataGridViewCellEventArgs ev, ref Utils.State state)
        {
            factura = null;

            if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Pagar"))
                state = Utils.State.MODIFY;
            else
                state = Utils.State.NONE;

            int id_fact = Convert.ToInt32(form.dataGridView1.Rows[ev.RowIndex].Cells[0].Value.ToString());

            if (state != Utils.State.NONE)
                factura = Utils._IFacturaCAD.DameFacturaPorOID(id_fact);

            return factura;

        }

        /**
         * Pinta el datagrid /BOTON PAGAR
         */
        public void paintDataGrid(DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && form.dataGridView1.Columns[e.ColumnIndex].Name == "Pagar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.dataGridView1.Rows[e.RowIndex].Cells["Pagar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\edit-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                form.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                form.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }
        }

        public void AlertaPagar(Boolean activar, int indice)
        {
            Boolean ignorar = false;
            if (indice != -1)
                ignorar = facturas[indice].Pagada;  //SI ESTA PAGADA LA FACTURA NO MUESTRA LA ALERTA NI HACE NADA
            if(ignorar == false)
            {
                form.alerta_pagar.Visible = activar;
                form.texto_alerta.Enabled = activar;
                if (indice != -1)
                    form.texto_alerta.Text = "¿Pagar Factura " + facturas[indice].IdFactura + "?";
                form.btn_pagar_no.Enabled = activar;
                form.btn_pagar_si.Enabled = activar;
            }
            
            
        }
        public void pagarFactura()
        {
            //Pone el campo pagada a verdadero, mantiene los demas
            Utils._FacturaCEN.Modify(factura.IdFactura, factura.Fecha, factura.Total, true);
            form.changeState(Utils.State.MODIFY, DNI);
        }
        #endregion



       
     }
}
