using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Collections;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using System.Drawing;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApplication1
{
    public class FormRecepcionistaFacturaController
    {
        #region Variables

        private FormRecepcionistaFactura form = null;
        private IList<FacturaEN> lista_facturas_cliente = null;
        private ClienteEN clienteEN = null;
        private FacturaEN facturaEN = null;

        #endregion

        #region Constructor

        public FormRecepcionistaFacturaController(FormRecepcionistaFactura form) {
            this.form = form;
        }

        public void cargarDatosCliente(ClienteEN cli)
        {
            clienteEN = cli;

            if (clienteEN != null)
            {
                form.text_dni.Text = clienteEN.Nombre + " " + clienteEN.Apellidos;
                lista_facturas_cliente = Utils._IFacturaCAD.DameFacturasPorCliente(clienteEN.DNI);

                if (lista_facturas_cliente != null)
                {
                    for(int i=0;i<lista_facturas_cliente.Count;i++)
                    {
                        lista_facturas_cliente[i].Cliente = clienteEN;
                        lista_facturas_cliente[i].Consulta = Utils._IConsultaCAD.DameConsultaPorOID(lista_facturas_cliente[i].Consulta.IdConsulta);


                        if (lista_facturas_cliente[i].Consulta != null)
                            lista_facturas_cliente[i].Consulta.Mascota = Utils._IMascotaCAD.BuscarMascotaPorOID(lista_facturas_cliente[i].Consulta.Mascota.IdMascota);

                        //Num, pagar, fecha, total, mascota, motivo, boton tratamiento, pagada, boton pagar
                         form.dataGridFacturas.Rows.Add(lista_facturas_cliente[i].IdFactura, lista_facturas_cliente[i].Fecha, lista_facturas_cliente[i].Total, lista_facturas_cliente[i].Consulta.Mascota.Nombre,
                            lista_facturas_cliente[i].Consulta.MotivoConsulta, "", lista_facturas_cliente[i].Pagada == true ? "Si" : "No", "");
                    }
                }

                /*

                // INICIO ZONA BORRADOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                IList<TratamientoEN> listaprueba = new TratamientoCEN().DameTodosLosTratamientos();

                if (listaprueba != null)
                {
                    facturas[0].Consulta.Tratamiento = listaprueba;
                    facturas[1].Consulta.Tratamiento = listaprueba;
                    // FINAL ZONA BORRADOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

                    form.dataGridFacturas.Rows.Clear();



                    for (int i = 0; i < facturas.Count; i++)
                    {
                        //Num, pagar, fecha, total, mascota, motivo, boton tratamiento, pagada, boton pagar
                        mascota = Utils._IMascotaCAD.BuscarMascotaPorOID(facturas[i].Consulta.Mascota.IdMascota);
                        form.dataGridFacturas.Rows.Add(facturas[i].IdFactura, facturas[i].Fecha, facturas[i].Total, mascota.Nombre,
                            facturas[i].Consulta.MotivoConsulta, "", facturas[i].Pagada == true ? "Si" : "No", "");
                    }
                }
                 
                 */
                 
            }
        }

        #endregion

        #region DataGridView

        public FacturaEN getScreenState(DataGridViewCellEventArgs ev, ref Utils.State state)
        {
            facturaEN = null;
            String nombreCol = form.dataGridFacturas.Columns[ev.ColumnIndex].Name;

            if (nombreCol.Equals("Pagar") || nombreCol.Equals("Tratamiento") || nombreCol.Equals("Exportar"))
                state = Utils.State.MODIFY;
            else
                state = Utils.State.NONE;

            int id_fact = Convert.ToInt32(form.dataGridFacturas.Rows[ev.RowIndex].Cells[0].Value.ToString());

            if (state != Utils.State.NONE)
                facturaEN = Utils._IFacturaCAD.DameFacturaPorOID(id_fact);

            return facturaEN;

        }

        public void paintDataGrid(DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && form.dataGridFacturas.Columns[e.ColumnIndex].Name == "Pagar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.dataGridFacturas.Rows[e.RowIndex].Cells["Pagar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\edit-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                form.dataGridFacturas.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                form.dataGridFacturas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;
            }

        }

        public void AlertaPagar(Boolean activar, int indice)
        {
            Boolean ignorar = false;
            if (indice != -1)
                ignorar = lista_facturas_cliente[indice].Pagada;  //SI ESTA PAGADA LA FACTURA NO MUESTRA LA ALERTA NI HACE NADA
            if (ignorar == false)
            {
                form.alerta_pagar.Visible = activar;
                form.texto_alerta.Enabled = activar;
                
                if (indice != -1)
                    form.texto_alerta.Text = "¿Pagar Factura " + lista_facturas_cliente[indice].IdFactura + "?";
                
                form.btn_pagar_no.Enabled = activar;
                form.btn_pagar_si.Enabled = activar;
            }
        }
        
        public void MostrarTratamientos(Boolean activar, int indice)
        {
            form.panel_tratamientos.Visible = activar;
            form.dataGridTratamientos.Rows.Clear();

            if (lista_facturas_cliente != null && indice<=lista_facturas_cliente.Count)
            {
                int oid_factura = Convert.ToInt32(form.dataGridFacturas.Rows[indice].Cells[0].Value.ToString());
                IList<TratamientoEN> tratamientos_consulta = Utils._ITratamientoCAD.DameTratamientosPorConsulta(oid_factura);

                if (tratamientos_consulta != null)
                    for (int i = 0; i < tratamientos_consulta.Count; i++)
                        form.dataGridTratamientos.Rows.Add(tratamientos_consulta[i].Nombre, tratamientos_consulta[i].Descripcion, tratamientos_consulta[i].Precio);
            }
            
            
           
            //SELECT trat FROM TratamientoEN AS trat INNER JOIN SELECT cons ConsultaEN AS cons WHERE cons.IdConsulta=:id_consulta INNER JOIN cons.Tratamiento AS cons_trart WHERE cons_trat.Nombre=trat.Nombre                             
        }

        public void ExportarFactura(int indice)
        {
            //Aver, esto deberia estar ya cargado....o deberia cargarse al final
            MostrarTratamientos(false, indice); //Hago esto para cargar el datagrid, si no se puede exportar
            
            
            FacturaEN expFact = lista_facturas_cliente[indice]; 
            Document doc = new Document();
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Factura" + expFact.IdFactura + ".pdf", FileMode.Create));
            doc.Open();
            var phrase = new Phrase();
            var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 13);
            var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13);
            phrase.Add(new Chunk("Factura " + expFact.IdFactura, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
            phrase.Add(new Chunk("                                                                      " + DateTime.Now, normalFont));
            phrase.Add(new Chunk("\n\n\nCliente: ", boldFont));
            phrase.Add(new Chunk(clienteEN.Nombre + " " + clienteEN.Apellidos, normalFont));
            phrase.Add(new Chunk("\n\nDNI: ", boldFont));
            phrase.Add(new Chunk(clienteEN.DNI, normalFont));
            phrase.Add(new Chunk("\n\nMascota: ", boldFont));
            phrase.Add(new Chunk(expFact.Consulta.Mascota.Nombre , normalFont));
            phrase.Add(new Chunk("\n\nMotivo consulta: ", boldFont));
            phrase.Add(new Chunk(expFact.Consulta.MotivoConsulta, normalFont));
            phrase.Add(new Chunk("\n\nDiagnostico: ", boldFont));
            phrase.Add(new Chunk(expFact.Consulta.Diagnostico, normalFont));
            phrase.Add(new Chunk("\n\nTratamientos: \n", boldFont));
            doc.Add(phrase);
            phrase.Clear();
            if (!TratamientoEN.ReferenceEquals(expFact.Consulta.Tratamiento, null))
                doc.Add(TablaParaPDF(expFact, expFact.Consulta.Tratamiento));
            phrase.Add(new Chunk("\n\n\n\n\n\nGracias por su visita.", boldFont));
            doc.Add(phrase);
            phrase.Clear();
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("Logo.png");
            imagen.Alignment = 6;
            doc.Add(imagen);
            phrase.Add(new Chunk("\n\nHospital veterinario San Anton. www.sananton.com.es/", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)));
            doc.Add(phrase);
            doc.Close();
            System.Diagnostics.Process.Start("Factura" + expFact.IdFactura + ".pdf");
        }
       
        public PdfPTable TablaParaPDF(FacturaEN expFact, IList<TratamientoEN> tratamientos)
        {
            PdfPTable tabla = new PdfPTable(form.dataGridTratamientos.Columns.Count);
            for (int i = 0; i < form.dataGridTratamientos.Columns.Count; i++)
                tabla.AddCell(new Phrase(form.dataGridTratamientos.Columns[i].HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13)));
            
            tabla.HeaderRows = 1;
            for (int j = 0; j < form.dataGridTratamientos.Rows.Count; j++)
            {
                for (int k = 0; k < form.dataGridTratamientos.Columns.Count; k++)
                {
                    if (form.dataGridTratamientos[k, j].Value != null)
                        tabla.AddCell(new Phrase(form.dataGridTratamientos[k, j].Value.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 13)));
                }
            }
            float total = 0;
            for (int i = 0; i < tratamientos.Count; i++)
                total += tratamientos[i].Precio;
            //10 euros por haberle pasado consulta
            total += 10;
            tabla.AddCell(new Phrase(""));
            tabla.AddCell(new Phrase("Total", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13)));
            tabla.AddCell(new Phrase(total.ToString(), FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13)));
            return tabla;
        }
      
        public void PagarFactura()
        {
            //Pone el campo pagada a verdadero, mantiene los demas
            Utils._FacturaCEN.Modify(facturaEN.IdFactura, facturaEN.Fecha, facturaEN.Total, true);
            form.changeState(Utils.State.MODIFY);
        }
        
        #endregion

        #region BorrarCamposFormulario

        public void ClearForm()
        {
            form.text_dni.Text = "";
            
            if(form.dataGridFacturas!=null)
                form.dataGridFacturas.Rows.Clear();

            if(form.dataGridTratamientos!=null)
                form.dataGridTratamientos.Rows.Clear();
        }

        #endregion
    }
}
