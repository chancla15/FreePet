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
        private IList<TratamientoEN> tratamientos_consulta = null;
        private ClienteEN clienteEN = null;
        private FacturaEN facturaEN = null;

        #endregion

        #region Constructor

        public FormRecepcionistaFacturaController(FormRecepcionistaFactura form)
        {
            this.form = form;
        }

        public void cargarDatosCliente(ClienteEN cli)
        {
            clienteEN = cli;

            if (clienteEN != null)
            {
                form.text_dni.Text = clienteEN.Nombre + " " + clienteEN.Apellidos;
                lista_facturas_cliente = Utils._IFacturaCAD.DameFacturasPorCliente(clienteEN.DNI);

                form.dataGridFacturas.Rows.Clear(); //Hay que limpiar aqui el datagrid tb o salen duplicadas en cierto escenario(testeado)

                if (lista_facturas_cliente != null)
                {
                    for (int i = 0; i < lista_facturas_cliente.Count; i++)
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

        public void ExportarFacturaOMostrarTratamientos(int indice, String opcion)
        {
            int oid_factura = Convert.ToInt32(lista_facturas_cliente[indice].IdFactura);
            tratamientos_consulta = Utils._ITratamientoCAD.DameTratamientosPorConsulta(oid_factura);
            //Lo cargo sea tratamientos o exportar para tenerlo cargado, lo necesito para los 2
            //En exportar es necesario ya que exporto todo el contenido del datagrid al pdf y si no esta cargado no exporta nada
            CargarDataGridTratamientos(indice);

            //Activa el panel que muestra los tratamientos
            if (opcion.Equals("Tratamiento"))
                form.panel_tratamientos.Visible = true;
            //Exporta la factura en formato PDF
            if (opcion.Equals("Exportar"))
                ExportarFactura(indice);
        }

        public void CargarDataGridTratamientos(int indice)
        {
            //form.panel_tratamientos.Visible = false;
            form.dataGridTratamientos.Rows.Clear();

            //Ya que no se puede acceder a esta funcion si no hay ninguna factura no merece la pena hacer comprobaciones de si hay facturas
            if (tratamientos_consulta != null)
                for (int i = 0; i < tratamientos_consulta.Count; i++)
                    form.dataGridTratamientos.Rows.Add(tratamientos_consulta[i].Nombre, tratamientos_consulta[i].Descripcion, tratamientos_consulta[i].Precio);

            //SELECT trat FROM TratamientoEN AS trat INNER JOIN SELECT cons ConsultaEN AS cons WHERE cons.IdConsulta=:id_consulta INNER JOIN cons.Tratamiento AS cons_trart WHERE cons_trat.Nombre=trat.Nombre                             
        }

        public void ExportarFactura(int indice)
        {
            FacturaEN expFact = lista_facturas_cliente[indice];
            Document doc = new Document();
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Factura" + expFact.IdFactura + ".pdf", FileMode.Create));
            doc.Open();
            PdfContentByte pcb = wri.DirectContent;
            var phrase = new Phrase();
            var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 13);
            var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13);
            phrase.Add(new Chunk("Factura: " + expFact.IdFactura, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
            pcb.BeginText();
            pcb.SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA, 13, iTextSharp.text.Font.NORMAL).BaseFont, 13);
            pcb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT,DateTime.Now.ToString(),520,806,0); //Esto pone la fecha en la esquina derecha
            pcb.EndText();
            phrase.Add(new Chunk("\n\n\n\n\nCliente: ", boldFont));
            phrase.Add(new Chunk(clienteEN.Nombre + " " + clienteEN.Apellidos, normalFont));
            phrase.Add(new Chunk("\n\nDNI: ", boldFont));
            phrase.Add(new Chunk(clienteEN.DNI, normalFont));
            phrase.Add(new Chunk("\n\nMascota: ", boldFont));
            phrase.Add(new Chunk(expFact.Consulta.Mascota.Nombre, normalFont));
            phrase.Add(new Chunk("\n\nMotivo consulta: ", boldFont));
            phrase.Add(new Chunk(expFact.Consulta.MotivoConsulta, normalFont));
            phrase.Add(new Chunk("\n\nDiagnostico: ", boldFont));
            phrase.Add(new Chunk(expFact.Consulta.Diagnostico, normalFont));
            if (tratamientos_consulta.Count > 0) //Duplico esta comprobación para ahorrarme un doc.ADD y un phrase.Clear
                phrase.Add(new Chunk("\n\nTratamientos: \n", boldFont));
            doc.Add(phrase);
            phrase.Clear();
            if (tratamientos_consulta.Count > 0)
                doc.Add(TablaParaPDF(expFact));
           
            phrase.Add(new Chunk("\n\nPrecio total: ", boldFont));
            phrase.Add(new Chunk(expFact.Total.ToString(), normalFont));
            
            
            doc.Add(phrase);
            phrase.Clear();
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("LOGO.gif");
            imagen.SetAbsolutePosition(400, 45);
            doc.Add(imagen);
            pcb.BeginText();
            pcb.SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD).BaseFont, 15);
            pcb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Gracias por su visita.", 50, 80, 0);
            pcb.SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD).BaseFont, 10);
            pcb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Hospital veterinario Free Pet. www.freepetvet.es", 50, 50, 0);
            pcb.EndText();
            doc.Close();
            System.Diagnostics.Process.Start("Factura" + expFact.IdFactura + ".pdf");
        }

        public PdfPTable TablaParaPDF(FacturaEN expFact)
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
            //De esta manera se puede fijar un coste por consulta base y luego se suma el total con los tratamientos
            //Aunque la clave reside en que la factura se cree cuando se realiza la consulta
            
            tabla.AddCell(new Phrase(""));
            tabla.AddCell(new Phrase("Consulta", FontFactory.GetFont(FontFactory.HELVETICA, 13)));
            tabla.AddCell(new Phrase("10", FontFactory.GetFont(FontFactory.HELVETICA, 13)));
            return tabla;
        }

        public void PagarFactura()
        {
            //Pone el campo pagada a verdadero, mantiene los demas
            Utils._FacturaCEN.Modify(facturaEN.IdFactura, facturaEN.Fecha, facturaEN.Total, true);
            //Cargamos los datos de nuevo para que se muestre la factura como pagada
            cargarDatosCliente(clienteEN);
        }

        #endregion

        #region BorrarCamposFormulario

        public void ClearForm()
        {
            form.text_dni.Text = "";

            if (form.dataGridFacturas != null)
                form.dataGridFacturas.Rows.Clear();

            if (form.dataGridTratamientos != null)
                form.dataGridTratamientos.Rows.Clear();
        }

        #endregion
    }
}
