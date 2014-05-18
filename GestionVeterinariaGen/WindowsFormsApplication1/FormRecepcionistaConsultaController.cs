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
                string hora = "";
                form.box_text_fecha.Text = consultaEN.Fecha.Value.Day + "/" + consultaEN.Fecha.Value.Month + "/" + consultaEN.Fecha.Value.Year;
                hora = consultaEN.Fecha.Value.Hour + ":";

                if (consultaEN.Fecha.Value.Minute == 0)
                    hora += "00";
                else
                    hora += consultaEN.Fecha.Value.Minute;

                form.box_combo_hora.SelectedItem = hora;
                form.box_text_lugar.Text = consultaEN.Lugar;
                form.box_text_motivo.Text = consultaEN.MotivoConsulta;


                if (consultaEN.Veterinario != null)
                {
                    consultaEN.Veterinario = Utils._IVeterinarioCAD.DameVetarinarioPorOID(consultaEN.Veterinario.DNI);
                    form.box_combo_veterinario.SelectedItem = consultaEN.Veterinario.Nombre + ' ' + consultaEN.Veterinario.Apellidos;

                    if (consultaEN.Mascota != null)
                    {
                        consultaEN.Mascota = Utils._IMascotaCAD.BuscarMascotaPorOID(consultaEN.IdConsulta);
                        consultaEN.Mascota.Cliente = Utils._IMascotaCAD.DameClientePorMascota(consultaEN.Mascota.IdMascota);
 
                        if (consultaEN.Mascota.Cliente != null)
                           cargarDatosCliente(consultaEN.Mascota.Cliente);

                        form.box_combo_mascotas.SelectedItem = consultaEN.Mascota.Nombre;
                    }
                }
            }
        }

        public void cargarDatosConsultaDesdeTreeView()
        {
            string text = form.treeViewConsultas.SelectedNode.Text;
            string date_hour = "";
            string aux_hora_lista = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                    date_hour += text[i];
                else
                    break;
            }

            for (int i = 0; i < lista_consultasToday.Count; i++)
            {
                aux_hora_lista = lista_consultasToday[i].Fecha.Value.Hour + ":";

                if (lista_consultasToday[i].Fecha.Value.Minute == 0)
                    aux_hora_lista += "00";
                else
                    aux_hora_lista += lista_consultasToday[i].Fecha.Value.Minute;
                
                if (date_hour==aux_hora_lista)
                {
                    consultaEN = lista_consultasToday[i];
                    break;
                }
            }

            cargarDatosConsulta(consultaEN);
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

                for (DateTime f = form.datetime_init.Value.Date; f <= form.datetime_fin.Value.Date; f = f.AddDays(1))
                {
                    if (f.DayOfWeek != System.DayOfWeek.Saturday && f.DayOfWeek != System.DayOfWeek.Sunday)
                    {
                        TreeNode node= new TreeNode(f.DayOfWeek.ToString() + " - " + f.Day.ToString() + "/" + f.Month.ToString() + "/" + f.Year.ToString());
                        try
                        {
                            lista = Utils._IConsultaCAD.BuscarConsultaPorFecha(f);
                            VeterinarioEN aux_vet=null;
                            string inforSubConsulta = "";

                            if (lista != null && lista.Count > 0)
                            {
                                for (int i = 0; i < lista.Count; i++)
                                {
                                    inforSubConsulta = lista[i].Fecha.Value.Hour + ":";

                                    if(lista[i].Fecha.Value.Minute==0)
                                        inforSubConsulta+="00";
                                    else
                                        inforSubConsulta+=lista[i].Fecha.Value.Minute;

                                    for (int k = 0; k < lista_veterinariosTotal.Count; k++)
                                    {
                                        if (lista[k].Veterinario.DNI == lista_veterinariosTotal[k].DNI)
                                        {
                                            aux_vet = lista_veterinariosTotal[k];
                                            break;
                                        }
                                    }

                                    if(aux_vet!=null)
                                        inforSubConsulta+= " - " + aux_vet.Nombre + " " + aux_vet.Apellidos;

                                    node.Nodes.Add(inforSubConsulta);
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

            if (nodeOp.Level > 0)
                nodeOp = nodeOp.Parent;

            String date = "";
            for (int i = 0; i < nodeOp.Text.Length; i++)
            {
                if (nodeOp.Text[i] != '-')
                    date += nodeOp.Text[i];
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

            if (lista_consultasToday != null && form.state==Utils.State.NEW && lista_consultasToday.Count > 0)
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

            if (consultaEN == null)
                consultaEN = new ConsultaEN();

            form.label_error_mascota.Visible = false;
            form.label_error_veterinario.Visible = false;

            if (consultaEN.Diagnostico == null)
                consultaEN.Diagnostico = "";

            consultaEN.MotivoConsulta = form.box_text_motivo.Text;
            consultaEN.Lugar = form.box_text_lugar.Text;
 
            if (form.box_combo_mascotas.SelectedItem != null)
            {
                if (list_mascotasCliente != null && list_mascotasCliente.Count > 0)
                {
                    for (int i = 0; i < list_mascotasCliente.Count; i++)
                    {
                        if (list_mascotasCliente[i].Nombre == form.box_combo_mascotas.SelectedItem.ToString())
                        {
                            consultaEN.Mascota = list_mascotasCliente[i];
                            consultaEN.Mascota = Utils._IMascotaCAD.BuscarMascotaPorOID(consultaEN.Mascota.IdMascota);
                            form.box_combo_mascotas.SelectedItem = consultaEN.Mascota.Nombre;
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
                        if (name == form.box_combo_veterinario.SelectedItem.ToString())
                        {
                            consultaEN.Veterinario = list_veterinariosToday[i];
                            consultaEN.Veterinario = Utils._IVeterinarioCAD.DameVetarinarioPorOID(consultaEN.Veterinario.DNI);
                            form.box_combo_veterinario.SelectedItem = consultaEN.Veterinario.Nombre + ' ' + consultaEN.Veterinario.Apellidos;
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

            if (consultaEN != null)
            {
                switch (form.state)
                {
                    case Utils.State.NONE:
                        break;
                    case Utils.State.NEW:
                            consultaEN.IdConsulta= Utils._ConsultaCEN.New_(consultaEN.MotivoConsulta, consultaEN.Diagnostico, consultaEN.Mascota.IdMascota, consultaEN.Veterinario.DNI, consultaEN.Lugar, consultaEN.Fecha);
                        break;
                    case Utils.State.MODIFY:
                            Utils._ConsultaCEN.Modify(consultaEN.IdConsulta, consultaEN.MotivoConsulta, consultaEN.Diagnostico, consultaEN.Lugar, consultaEN.Fecha);
                        break;
                    case Utils.State.DESTROY:
                            Utils._ConsultaCEN.Destroy(consultaEN.IdConsulta);
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region BorrarDatosFormulario

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
