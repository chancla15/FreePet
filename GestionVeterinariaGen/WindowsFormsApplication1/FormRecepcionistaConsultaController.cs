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
    /**
     * La clase FormConsultarecepcionistaController
     * Se encarga de controlar la clae formulario de recepcionista
     */
    class FormRecepcionistaConsultaController
    {
        /** Variable privada de clase formulario consulta*/
        public FormRecepcionistaConsulta form;

        /** La lista de consulas de la fecha actual */
        private IList<ConsultaEN> lista_consultasToday;

        /** Consulta para la DDBB */
        ConsultaEN consultaEN;
        
        /** Lista de veterinarios */
        IList<VeterinarioEN> lista_veterinariosTotal;

        /** Lista de mascotas de esa consulta diponible para ese cliente */
        IList<MascotaEN> list_mascotasCliente;

        /** Lista de veterinario disponibles para una hora y fecha */
        IList<VeterinarioEN> list_veterinariosToday;

        /** Ticket de sesion */
        public FormLoginDataSessionTicket sessionData;

        /**
         * Constructor de la clase
         */
        public FormRecepcionistaConsultaController(FormRecepcionistaConsulta form, FormLoginDataSessionTicket session)
        {
            this.form = form;
            consultaEN = new ConsultaEN();
            form.datetime_init.MinDate = DateTime.Today;
            form.datetime_fin.MinDate = DateTime.Today;
            form.datetime_init.Value = DateTime.Today;
            form.datetime_fin.Value = DateTime.Today;
            sessionData = session;
            lista_veterinariosTotal = Utils._IVeterinarioCAD.DameTodosLosVeterinarios();   
        }

        public void changeState(ConsultaEN consulta)
        {
            //Si se crea con el estado normal no se carga normalemente sino
            //se carga la consulta pasada
            if (form.state == Utils.State.NONE)
            {
                ClearForm();
            }
            else
            {
                consultaEN = consulta;
                //Aqui cargaria los datos de una consulta
               // cargarDatosConsultaDesdeConsultaEN();
            }
        }


        /**
         * Comprueba si una fecha es valida o no
         * @param init la fecha inicio
         * @param fin la fecha fin
         */
        private Boolean ValidateDateTimer(DateTime init, DateTime fin) {
            return (init >= DateTime.Today && fin >= DateTime.Today && init <= fin);
        }
        
        /**
         * Busca consultas entre dos fechas comprobando que ambas son correctas
         */
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

        /**
        * Cambia la fecha
        */
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

       /**
        * Carga la informacion de las horas disponibles para una fecha
        */
        private void cargarHoras()
        {
            form.box_combo_hora.Items.Clear();
            form.box_combo_hora.FormattingEnabled = true;
            string[] horas =
                {
                    "09:00", "09:30","10:00","10:30","11:00","11:30","12:00","12:30","13:00","13:30",
                    "17:00", "17:30","18:00","18:30","19:00","19:30","20:00","20:30"
                };
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


        /**
         * Comprueba los veterinarios disponibles a esa fecha
         */
        public void checkBoxVeterinarios()
        {
            if (form.box_text_fecha.Text != "" && form.box_combo_hora != null)
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

                for (int i = 0; i < list_veterinariosToday.Count; i++)
                    form.box_combo_veterinario.Items.Add(list_veterinariosToday[i].Nombre + ' ' + list_veterinariosToday[i].Apellidos);
            }
        }

        /**
         * Comprueba que el campo cliente es correcto y sino muestra las mascotas
         */
        public bool checkClienteAndShowPets()
        {
            bool ret = false;
            form.box_combo_mascotas.Items.Clear();

            if (form.box_text_cliente.Text != "")
            {
                ClienteEN cli = Utils._IClienteCAD.DameClientePorOID(form.box_text_cliente.Text);

                if (cli != null)
                {
                    ret = true;
                    list_mascotasCliente = Utils._IMascotaCAD.DameMascotaPorCliente(cli.DNI);

                    if (list_mascotasCliente != null && list_mascotasCliente.Count > 0)
                        for (int i = 0; i < list_mascotasCliente.Count; i++)
                            form.box_combo_mascotas.Items.Add(list_mascotasCliente[i].Nombre);
                }
            }
            return ret;
        }

        /**
         * Carga los datos de una consulta en el formulario
         */
        public void cargarDatosConsultaDesdeTreeView()
        {
            string text = Convert.ToString(form.treeViewConsultas.SelectedNode.Text);
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
            for(int i=0;i<lista_consultasToday.Count;i++)
                if (fecha == lista_consultasToday[i].Fecha)
                {
                    consultaEN = lista_consultasToday[i];
                    break;
                }

            form.box_text_motivo.Text = consultaEN.MotivoConsulta;
            form.box_text_lugar.Text = consultaEN.Lugar;
            if(consultaEN.Mascota!=null)
                form.box_text_cliente.Text = consultaEN.Mascota.Cliente.DNI;
            form.box_text_fecha.Text = consultaEN.Fecha.Value.Day + "/" + consultaEN.Fecha.Value.Month + "/" + consultaEN.Fecha.Value.Year;
            form.box_combo_hora.SelectedItem = consultaEN.Fecha.Value.Hour + ':' + consultaEN.Fecha.Value.Minute;
            form.box_combo_mascotas.SelectedItem = consultaEN.Mascota.Nombre;
            if(consultaEN.Veterinario!=null)
                form.box_combo_veterinario.SelectedItem = consultaEN.Veterinario.Nombre + ' ' + consultaEN.Veterinario.Apellidos;
            form.datetime_init.Value = DateTime.Today;
            form.datetime_fin.Value = DateTime.Today;
        }

       /**
        * Borrar todos los campos del box_controller asi como su informacoin asociada
        */
        public void ClearForm()
        {
            form.box_text_motivo.Text = "";
            form.box_text_lugar.Text = "";
            form.box_text_cliente.Text = "";
            form.box_text_fecha.Text = "";
            form.box_combo_hora.SelectedText = "";
            form.box_combo_hora.SelectedItem = null;
            form.box_combo_hora.Items.Clear();
            form.box_combo_mascotas.SelectedText = "";
            form.box_combo_mascotas.SelectedItem = null;
            form.box_combo_mascotas.Items.Clear();
            form.box_combo_veterinario.SelectedText = "";
            form.box_combo_veterinario.SelectedItem = null;
            form.box_combo_veterinario.Items.Clear();
            //form.datetime_init.Value = DateTime.Today;
            //form.datetime_fin.Value = DateTime.Today;
            form.treeViewConsultas.Nodes.Clear();
            lista_consultasToday = null;
            list_mascotasCliente = null;
            list_veterinariosToday = null;

            cargarHoras();
            if (lista_veterinariosTotal != null && lista_veterinariosTotal.Count > 0)
            {
                form.box_combo_veterinario.Items.Clear();

                for (int i = 0; i < lista_veterinariosTotal.Count; i++)
                    form.box_combo_veterinario.Items.Add(lista_veterinariosTotal[i].Nombre + " " + lista_veterinariosTotal[i].Apellidos);

            }
        }

       /**
        * Cuando se pulsa el boton de anaydir/modificar o eliminar se llama a esto
        * y se comprueba el nodo pulsado y el estado 
        */
        public void ProcesarInformacion()
        {
            form.label_error_mascota.Visible = false;
            form.label_error_veterinario.Visible = false;

            //Anadido datos del formulario a clienteEN
            consultaEN.MotivoConsulta = form.box_text_motivo.Text;
            consultaEN.Lugar = form.box_text_lugar.Text;

            if(form.state==Utils.State.NEW)
                consultaEN.Factura = null;

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
                        Utils._ConsultaCEN.New_(consultaEN.Fecha, consultaEN.MotivoConsulta, "", consultaEN.Mascota.IdMascota, consultaEN.Veterinario.DNI, "", consultaEN.Lugar);
                        break;
                    case Utils.State.MODIFY:
                        Utils._ConsultaCEN.Modify(consultaEN.IdConsulta, consultaEN.Fecha, consultaEN.MotivoConsulta, consultaEN.Diagnostico, consultaEN.Lugar);
                        break;
                    case Utils.State.DESTROY:
                        Utils._ConsultaCEN.Destroy(consultaEN.IdConsulta);
                        break;
                    default:
                        break;
                }
            }
        }
















        /**
         * Añade una consulta a una fecha
         */
        public void anyadirConsulta()
        {
            /*nodeOp = form.treeViewConsultas.SelectedNode;

            //Compruebo que estoy en un nodo raiz
            if (nodeOp != null && nodeOp.Level == 0)
            {
                //state = State.ADD;
                cambiarFecha();
                cargarComboHoras();
            }
            else
                nodeOp = null;*/
        }

        /**
         * Modifica una consula en una fecha y hora
         */
        public void modificarConsulta()
        {
            /*nodeOp = form.treeViewConsultas.SelectedNode;

            //Compruebo si estoy en un subnodo
            if (nodeOp != null && nodeOp.Level == 1)
            {
                
                TreeNode padre = nodeOp.Parent;
                String date_calendar = "";
                String date_hour = "";
                String vet_name = "";
                String vet_app = "";
                Boolean name = true;
                String text = Convert.ToString(padre.Text);

                for (int i = 0; i < text.Length; i++)  {
                    if (text[i] != '-')
                        date_calendar += text[i];
                    else {
                        date_calendar = "";
                        i++;
                    }
                }

                text = Convert.ToString(nodeOp.Text);
                int navet=0;

                for (int i = 0; i < text.Length; i++) {
                    if (text[i] != ' ')
                        date_hour += text[i];
                    else
                    {
                        navet = i;
                        break;
                    }
                }
                navet += 2;

                for (int i = navet; i < text.Length; i++) {

                    if (name && text[i] == ' ')
                        name = false;

                    if (name)
                        vet_name += text[i];
                    else
                        vet_app += text[i];
                }

                DateTime timeMod = Convert.ToDateTime(date_calendar + ' ' + date_hour + ":00");
               // VeterinarioEN vetMod = _IVeterinarioCAD.BuscarPorNombreYApellidos(vet_name, vet_app);
                //ConsultaEN consulta = _IConsultaCAD.DameConsultaPorVeterinarioYFecha(vetMod.DNI, timeMod);
                //cargarEnBoxController(consulta);
            }
            else
                nodeOp = null;*/
        }

        /**
         * Borra la consulta
         */
        public void borrarConsulta() {
            //modificarConsulta();
            //state = State.DEL;
        }

        /**
         * Comprueba si el cliente introducido es correcto y en caso afirmativo rellena la lista de mascotas
         */
        public void checkBoxCliente()
        {/*
            try
            {
                form.box_error_cliente.Visible = false;
               // ClienteEN clienteEN = _IClienteCAD.DameClientePorOID(form.box_text_cliente.Text);
                form.box_combo_mascotas.Items.Clear();

                if (clienteEN != null)
                {
                    //boxcontroller.Cliente = clienteEN;
                    list_mascotas =// _IMascotaCAD.DameMascotaPorCliente(boxcontroller.Cliente.DNI);

                    if (list_mascotas.Count > 0 && list_mascotas != null)
                    {
                        for (int i = 0; i < list_mascotas.Count; i++)
                            form.box_combo_mascotas.Items.Add(list_mascotas[i].Nombre);
                    }
                }
                else
                {
                    form.box_error_cliente.Visible = true;
                    form.box_combo_mascotas.Items.Clear();
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }*/
        }

        

        /** 
         * Carga los campos escritos de la mascota 
         */
        private void loadVeterinarioMascota()
        {
           /* String vet = form.box_combo_veterinario.Text;
            String masc = form.box_combo_mascotas.Text;

            if (masc != "")
            {
                for (int i = 0; i < list_mascotas.Count; i++)
                    if (list_mascotas[i].Nombre.Equals(masc))
                    {
                        boxcontroller.Mascota = list_mascotas[i];
                        break;
                    }
            }
            else
            {
                //error
            }

            if (vet != "")
            {
                String s = "";
                for (int i = 0; i < list_veterinarios.Count; i++)
                {
                    s += list_veterinarios[i].Nombre.ToString() + ' ' + list_veterinarios[i].Apellidos.ToString();

                    if (s.Equals(vet))
                    {
                        boxcontroller.Veterinario = list_veterinarios[i];
                        break;
                    }
                    s = "";
                }
            }
            else 
            {
                //error
            }*/
        }

        public void guardarCuadroInformacion()
        {
           /* boxcontroller.Motivo = form.box_text_motivo.Text;
            boxcontroller.Lugar = form.box_text_lugar.Text;
            loadVeterinarioMascota();

            ConsultaCEN = new ConsultaCEN(_IConsultaCAD);
            //Si todos los campos estan correctos pos añado la consulta
            ConsultaEN c = new ConsultaEN();
           // ConsultaCEN consultaCEN = new ConsultaCEN();
            c.IdConsulta = 0;
            c.Fecha = boxcontroller.Fecha;
            c.MotivoConsulta = boxcontroller.Motivo;
            c.Diagnostico = "diag";
            c.Mascota = boxcontroller.Mascota;
            c.Veterinario = boxcontroller.Veterinario;
            c.Lugar = boxcontroller.Lugar;

            switch (state)
            {
                case State.ADD:
                    ConsultaCEN.New_(boxcontroller.Fecha, boxcontroller.Motivo, "", boxcontroller.Mascota.IdMascota, boxcontroller.Veterinario.DNI, boxcontroller.Lugar);
                    //_IConsultaCAD.New_(c);
                    buscarPorFechas();
                    break;
                case State.MOD: case State.DEL:
                    
                   // _IConsultaCAD.Modify(c);               
                   // _IConsultaCAD.Destroy(c.IdConsulta);
                    break;
                default:
                    break;
            }
            state = State.NONE;*/
        }
    }
}
