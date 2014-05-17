using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class FormRecepcionistaConsultaController
    {
        #region Variables

        public FormRecepcionistaConsulta form;
        public ConsultaEN consultaEN;
        IList<ConsultaEN> lista_consultasToday;
        IList<VeterinarioEN> lista_veterinariosTotal;
        IList<MascotaEN> list_mascotasCliente;
        IList<VeterinarioEN> list_veterinariosToday;
        static string[] horas =
                {
                    "09:00", "09:30","10:00","10:30","11:00","11:30","12:00","12:30","13:00","13:30",
                    "17:00", "17:30","18:00","18:30","19:00","19:30","20:00","20:30"
                };

        #endregion

        #region Constructor

        public FormRecepcionistaConsultaController(FormRecepcionistaConsulta form)
        {
            this.form = form;
            consultaEN = new ConsultaEN();
            form.datetime_init.MinDate = DateTime.Today;
            form.datetime_fin.MinDate = DateTime.Today;
            form.datetime_init.Value = DateTime.Today;
            form.datetime_fin.Value = DateTime.Today;
            lista_veterinariosTotal = Utils._IVeterinarioCAD.DameTodosLosVeterinarios();   
        }

        public void cargarDatosCliente(ClienteEN cli)
        {
            if (cli != null)
            {
                form.box_text_cliente.Enabled = false;
                form.box_text_cliente.Text = cli.DNI;

                if (list_mascotasCliente != null)
                    list_mascotasCliente.Clear();

                list_mascotasCliente = Utils._IMascotaCAD.DameMascotaPorCliente(cli.DNI);
                form.box_combo_mascotas.Items.Clear();

                if (list_mascotasCliente != null)
                    for (int i = 0; i < list_mascotasCliente.Count; i++)
                        form.box_combo_mascotas.Items.Add(list_mascotasCliente[i].Nombre);

            }
        }

        public void cargarDatosMascota(MascotaEN mascota)
        {
            if (mascota != null)
            {
                if (consultaEN != null)
                    consultaEN = null;

                if (consultaEN == null)
                    consultaEN = new ConsultaEN();

                consultaEN.Mascota = mascota;
                form.box_combo_mascotas.SelectedItem = consultaEN.Mascota.Nombre;
            }
        }

        public void cargarDatosConsulta(ConsultaEN consulta)
        {
            consultaEN = consulta;

            if (consultaEN != null)
            {
                form.box_text_fecha.Text = consultaEN.Fecha.Value.Day + "/" + consultaEN.Fecha.Value.Month + "/" + consultaEN.Fecha.Value.Year;
                form.box_combo_hora.SelectedItem = consultaEN.Fecha.Value.Hour + ":" + consultaEN.Fecha.Value.Minute;
                form.box_text_lugar.Text = consultaEN.Lugar;
                form.box_text_motivo.Text = consultaEN.MotivoConsulta;

                consultaEN.Veterinario = Utils._IVeterinarioCAD.DameVetarinarioPorOID(consultaEN.Veterinario.DNI);
                form.box_combo_veterinario.SelectedItem = consultaEN.Veterinario.Nombre;
            }
        }

        public void cargarDatosConsultaDesdeTreeView()
        {

            string text = Convert.ToString(form.treeViewConsultas.SelectedNode);
            string date_hour = "";
            DateTime fecha;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                    date_hour += text[i];
                else
                    break;
            }

            fecha = Convert.ToDateTime(form.box_text_fecha + " " + date_hour);
            for (int i = 0; i < lista_consultasToday.Count; i++)
                if (fecha == lista_consultasToday[i].Fecha)
                {
                    consultaEN = lista_consultasToday[i];
                    break;
                }

            if (consultaEN != null)
            {
                form.box_text_motivo.Text = consultaEN.MotivoConsulta;
                form.box_text_lugar.Text = consultaEN.Lugar;
                if (consultaEN.Mascota != null)
                    form.box_text_cliente.Text = consultaEN.Mascota.Cliente.DNI;
                form.box_text_fecha.Text = consultaEN.Fecha.Value.Day + "/" + consultaEN.Fecha.Value.Month + "/" + consultaEN.Fecha.Value.Year;
                form.box_combo_hora.SelectedItem = consultaEN.Fecha.Value.Hour + ':' + consultaEN.Fecha.Value.Minute;
                form.box_combo_mascotas.SelectedItem = consultaEN.Mascota.Nombre;
                if (consultaEN.Veterinario != null)
                    form.box_combo_veterinario.SelectedItem = consultaEN.Veterinario.Nombre + ' ' + consultaEN.Veterinario.Apellidos;
                form.datetime_init.Value = DateTime.Today;
                form.datetime_fin.Value = DateTime.Today;
            }

        }

        #endregion

        #region Busquedas

        private Boolean ValidateDateTimer(DateTime init, DateTime fin) {
            return (init >= DateTime.Today && fin >= DateTime.Today && init <= fin);
        }
        
        public bool buscarPorFechas()
        {
            bool ret = false;
            form.treeViewConsultas.Nodes.Clear();

            if (ValidateDateTimer(form.datetime_init.Value.Date, form.datetime_fin.Value.Date))
            {
                ret = true;
                IList<ConsultaEN> lista=null;

                /** Recorro las fechas en el intervalo seleccionado */
                for (DateTime f = form.datetime_init.Value.Date; f <= form.datetime_fin.Value.Date; f = f.AddDays(1))
                {
                    /** Si no es dia laborable no muestra fecha */
                    if (f.DayOfWeek != System.DayOfWeek.Saturday && f.DayOfWeek != System.DayOfWeek.Sunday)
                    {
                        TreeNode node= new TreeNode(f.DayOfWeek.ToString() + " - " + f.Day.ToString() + "/" + f.Month.ToString() + "/" + f.Year.ToString());
                        // Console.Write("Fecha: " + f.ToString() + "\n");
                        try
                        {
                            lista = Utils._IConsultaCAD.BuscarConsultaPorFecha(f);

                            /* Si existen consultas para ese dia se las añado sus horas y pongo el nodo como importante */
                            if (lista != null && lista.Count > 0)
                            {
                                
                                Console.Write("Hay una consulta como minimo este dia" + f.ToString());// + " lista.Count: " + lista.Count);

                                for (int i = 0; i < lista.Count; i++)
                                {
                                    //string s = "";
                                    string s= (lista[i].Fecha.Value.Hour + ":" + lista[i].Fecha.Value.Minute); //+ " - " + lista[i].Veterinario.Nombre + " " + lista[i].Veterinario.Apellidos);
                                    node.Nodes.Add(s);
                                    Console.WriteLine(f.ToString() + " HORA: " + s);
                                }
                               lista.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Error.Write("...........ERROR...............\n" + ex.Message.ToString() + "\n");
                        }
                        form.treeViewConsultas.Nodes.Add(node);
                        node = null;
                    }
                }
            }

            return ret;
                
        }

        #endregion

        #region showDataOnClickTreeView

        public void cambiarFecha()
        {
            TreeNode nodeOp = form.treeViewConsultas.SelectedNode;
            String date = "";
            String text = Convert.ToString(nodeOp.Text);

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '-')
                    date += text[i];
                else
                {
                    date = "";
                    i++;
                }
            }
            form.box_text_fecha.Text = date;

            lista_consultasToday = Utils._IConsultaCAD.BuscarConsultaPorFecha(Convert.ToDateTime(form.box_text_fecha.Text));
            cargarHoras();
        }

        public void cargarHoras()
        {
            form.box_combo_hora.Items.Clear();

            form.box_combo_hora.Items.AddRange(horas);

            if (lista_consultasToday != null && lista_consultasToday.Count > 0)
            {
                string hour = "";

                for (int i = 0; i < lista_consultasToday.Count; i++)
                {
                    hour= lista_consultasToday[i].Fecha.Value.Hour + ":" + lista_consultasToday[i].Fecha.Value.Minute;
                    form.box_combo_hora.Items.Remove(hour);
                }
            }
        }

        public void checkBoxVeterinarios()
        {
            form.box_combo_veterinario.Items.Clear();

            if (form.box_text_fecha.Text != "" && form.box_combo_hora.Text!="")
            {
                Console.WriteLine("fecha: " + form.box_text_fecha.Text + " hora: " + form.box_combo_hora.Text);
                consultaEN.Fecha = Convert.ToDateTime(form.box_text_fecha.Text + ' ' + form.box_combo_hora.SelectedItem.ToString() + ":00");
                list_veterinariosToday = lista_veterinariosTotal;

                if (lista_consultasToday != null && lista_consultasToday.Count > 0)
                {

                    for (int i = 0; i < lista_consultasToday.Count; i++)
                    {
                        if (lista_consultasToday[i].Fecha == consultaEN.Fecha &&
                            !lista_veterinariosTotal.Contains(lista_consultasToday[i].Veterinario))
                            list_veterinariosToday.Remove(lista_consultasToday[i].Veterinario);
                    }
                }
            }
            else
                list_veterinariosToday = lista_veterinariosTotal;

            for (int i = 0; i < list_veterinariosToday.Count; i++)
                form.box_combo_veterinario.Items.Add(list_veterinariosToday[i].Nombre + ' ' + list_veterinariosToday[i].Apellidos);
        }

        #endregion

        #region ProcesarInformacion

        public void ProcesarInformacion()
        {
            form.label_error_mascota.Visible = false;
            form.label_error_veterinario.Visible = false;

            //Anadido datos del formulario a clienteEN
            consultaEN.MotivoConsulta = form.box_text_motivo.Text;
            consultaEN.Lugar = form.box_text_lugar.Text;

            //Necesita arreglo inicio
            consultaEN.Diagnostico = ""; //Necesitamos campo diagnostico
            consultaEN.Tratamiento = null; //Tratamiento temporal
            //Necesita arreglo fin

            /* Esto no hace nada con la nueva insercion, retesteado, lo dejo para que no se ponga de nuevo
            if(form.state==Utils.State.NEW)
                consultaEN.Factura = null;
            */
            if (form.box_combo_mascotas.SelectedItem != null)
            {
                if (list_mascotasCliente != null && list_mascotasCliente.Count > 0)
                {
                    for (int i = 0; i < list_mascotasCliente.Count; i++)
                    {
                        if (list_mascotasCliente[i].Nombre == Convert.ToString(form.box_combo_mascotas.SelectedItem))
                        {
                            consultaEN.Mascota = list_mascotasCliente[i];
                            break;
                        }
                    }
                }
            }
            else
            {
                form.label_error_mascota.Visible = true;
                return;
            }

            if (form.box_combo_veterinario.SelectedItem != null)
            {
                if (list_veterinariosToday != null && list_veterinariosToday.Count > 0)
                {
                    string name = "";
                    for (int i = 0; i < list_veterinariosToday.Count; i++)
                    {
                        name = list_veterinariosToday[i].Nombre + " " + list_veterinariosToday[i].Apellidos;
                        if (name == Convert.ToString(form.box_combo_veterinario.SelectedItem))
                        {
                            consultaEN.Veterinario = list_veterinariosToday[i];
                            break;
                        }
                    }
                }
            }
            else
            {
                form.label_error_veterinario.Visible = true;
                return;
            }

            Console.WriteLine("Me dispongo a crear consulta");

            if (consultaEN != null)
            {
                switch (form.state)
                {
                    case Utils.State.NONE:
                        break;
                    case Utils.State.NEW:
                        //Utils._ConsultaCEN.New_(consultaEN.Fecha, consultaEN.MotivoConsulta, "", consultaEN.Mascota.IdMascota, consultaEN.Veterinario.DNI, null, consultaEN.Lugar);
                        //El total en la factura es temporal, habrá que obtenerlo de los tratamientos + coste por consulta
                        Utils._FacturaCEN.New_(consultaEN.Fecha, 20, form.box_text_cliente.Text, consultaEN, false);
                        break;
                    case Utils.State.MODIFY:
                        //Utils._ConsultaCEN.Modify(consultaEN.IdConsulta, consultaEN.Fecha, consultaEN.MotivoConsulta, consultaEN.Diagnostico, consultaEN.Lugar);
                        //La unica manera de modificar una consulta que está ligada a una factura es borrar la factura y recrearla con la nueva consulta
                        //Sin testear, se necesita poder borrar consultas para probarlo
                        Utils._FacturaCEN.Destroy(consultaEN.Factura.IdFactura);
                        Utils._FacturaCEN.New_(consultaEN.Fecha, 20, form.box_text_cliente.Text, consultaEN, false);
                        break;
                    case Utils.State.DESTROY:
                        //Utils._ConsultaCEN.Destroy(consultaEN.IdConsulta);
                        Utils._FacturaCEN.Destroy(consultaEN.Factura.IdFactura);
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region BorrarDatosFormulario

        /**
        * Borrar todos los campos del box_controller asi como su informacoin asociada
        */
        public void ClearForm()
        {
            form.box_text_motivo.Text = "";
            form.box_text_lugar.Text = "";
            form.box_text_cliente.Text = "";
            form.box_text_fecha.Text = "";
            form.box_combo_hora.SelectedItem = null;
            form.box_combo_hora.Items.Clear();
            form.box_combo_mascotas.SelectedItem = null;
            form.box_combo_mascotas.Items.Clear();
            form.box_combo_veterinario.Text = "";
            form.box_combo_veterinario.SelectedItem = null;
            form.box_combo_veterinario.Items.Clear();
            form.treeViewConsultas.Nodes.Clear();
            lista_consultasToday = null;
            list_mascotasCliente = null;
            list_veterinariosToday = null;
        }

        #endregion
    }
}
