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
        private IList<FacturaEN> facturas = null;
        private IList<MascotaEN> mascotas = null;
        private IList<ConsultaEN> consultas = null;
        private ClienteEN cliente = null;
        private MascotaEN mascota = null;
        private FacturaEN factura = null;
        private String DNI = "";

        #endregion

        #region Constructor

        public FormRecepcionistaFacturaController(FormRecepcionistaFactura form) {
            this.form = form;
        }

        public void cargarDatosCliente(ClienteEN cli)
        {
            List<String> lista = new List<String>();
            lista.Add("hola");
            lista.Add("adios");

            cliente = cli;

            if (cliente != null)
            {

                mascotas = Utils._IMascotaCAD.DameMascotaPorCliente(cliente.DNI);
                facturas = Utils._IFacturaCAD.DameFacturasPorCliente(cliente.DNI);
                form.text_dni.Text = cliente.Nombre + " " + cliente.Apellidos;

                if (facturas != null)
                {
                    for (int i = 0; i < facturas.Count; i++)
                    {
                        //Num, pagar, fecha, total, mascota, motivo, boton tratamiento, pagada, boton pagar
                        mascota = Utils._IMascotaCAD.BuscarMascotaPorOID(facturas[i].Consulta.Mascota.IdMascota);
                        form.dataGridFacturas.Rows.Add(facturas[i].IdFactura, facturas[i].Fecha, facturas[i].Total, mascota.Nombre,
                            facturas[i].Consulta.MotivoConsulta, "", facturas[i].Pagada == true ? "Si" : "No", "");
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
            factura = null;
            String nombreCol = form.dataGridFacturas.Columns[ev.ColumnIndex].Name;

            if (nombreCol.Equals("Pagar") || nombreCol.Equals("Tratamiento") || nombreCol.Equals("Exportar"))
                state = Utils.State.MODIFY;
            else
                state = Utils.State.NONE;

            int id_fact = Convert.ToInt32(form.dataGridFacturas.Rows[ev.RowIndex].Cells[0].Value.ToString());

            if (state != Utils.State.NONE)
                factura = Utils._IFacturaCAD.DameFacturaPorOID(id_fact);

            return factura;

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
                ignorar = facturas[indice].Pagada;  //SI ESTA PAGADA LA FACTURA NO MUESTRA LA ALERTA NI HACE NADA
            if (ignorar == false)
            {
                form.alerta_pagar.Visible = activar;
                form.texto_alerta.Enabled = activar;
                if (indice != -1)
                    form.texto_alerta.Text = "¿Pagar Factura " + facturas[indice].IdFactura + "?";
                form.btn_pagar_no.Enabled = activar;
                form.btn_pagar_si.Enabled = activar;
            }


        }
        
        public void MostrarTratamientos(Boolean activar, int indice)
        {
            form.panel_tratamientos.Visible = activar;
            form.dataGridTratamientos.Rows.Clear();
            IList<TratamientoEN> t = facturas[indice].Consulta.Tratamiento;
            if (t!=null)
            {
                for (int i = 0; i < t.Count; i++)
                    form.dataGridTratamientos.Rows.Add(t[i].Nombre, t[i].Descripcion, t[i].Precio);
            }
            
        }

        public void ExportarFactura(int indice)
        {
            MostrarTratamientos(false, indice); //Hago esto para cargar el datagrid, si no se puede exportar
            FacturaEN expFact = facturas[indice]; 
            Document doc = new Document();
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Factura" + expFact.IdFactura + ".pdf", FileMode.Create));
            doc.Open();
            var phrase = new Phrase();
            var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 13);
            var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13);
            phrase.Add(new Chunk("Factura " + expFact.IdFactura, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
            phrase.Add(new Chunk("                                                                      " + DateTime.Now, normalFont));
            phrase.Add(new Chunk("\n\n\nCliente: ", boldFont));
            phrase.Add(new Chunk(cliente.Nombre + " " + cliente.Apellidos, normalFont));
            phrase.Add(new Chunk("\n\nDNI: ", boldFont));
            phrase.Add(new Chunk(cliente.DNI, normalFont));
            phrase.Add(new Chunk("\n\nMascota: ", boldFont));
            phrase.Add(new Chunk(mascota.Nombre, normalFont));
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
            Utils._FacturaCEN.Modify(factura.IdFactura, factura.Fecha, factura.Total, true);
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
