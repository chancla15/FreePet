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

        /** La clase que contendra los datos de la consulta a insertar */
        private class BoxControllerConsulta
        {
            /** La clase Fecha */
            public DateTime Fecha;

            /** La clase Cliente */
            public ClienteEN Cliente;

            /** La clase Mascota */
            public MascotaEN Mascota;

            /** La clase veterinario */
            public VeterinarioEN Veterinario;

            /** La clase lugar */
            public String Motivo, Lugar;

            /**
             * El constructor
             */
            public BoxControllerConsulta() 
            {
                Fecha= DateTime.Today;
                Cliente= new ClienteEN();
                Mascota= new MascotaEN();
                Veterinario= new VeterinarioEN();
                Motivo=Lugar="";
            }

            /**
             * Limpia el BoxController
             */
            public void clear()
            {
                Fecha = DateTime.Today;
                Cliente = null;
                Mascota = null;
                Veterinario = null;
                Motivo = Lugar = "";
            }
        }
        
        /** Variable privada de clase formulario consulta*/
        public FormRecepcionistaConsulta form;

        /** Varialbe de tipo nodo del TreeView */
        private TreeNode nodeOp;

        /** La lista de consulas de la fecha actual */
        private IList<ConsultaEN> consultasActual;

        /** Cliente para acceder a la DDBB */
        ClienteCAD _IClienteCAD = new ClienteCAD();

        /** Mascota para acceder a la DDBB */
        MascotaCAD _IMascotaCAD = new MascotaCAD();

        /** Veterinario para acceder a la DDBB */
        VeterinarioCAD _IVeterinarioCAD = new VeterinarioCAD();

        /** Consulta para acceder a la DDBB */
        ConsultaCAD _IConsultaCAD = new ConsultaCAD();

        /** Consulta para la DDBB */
        ConsultaCEN ConsultaCEN;
        
        /** Lista de veterinarios disponibles */
        IList<VeterinarioEN> list_veterinarios;

        /** Lista de mascotas de esa consulta diponible para ese cliente */
        IList<MascotaEN> list_mascotas;

        /** Variable que tendra lo datos de la consulta */
        BoxControllerConsulta boxcontroller;

        /** Tipos de Estados de la pantalla */
        private enum State {
            ADD, MOD, DEL, NONE
        }

        /** Estado de la pantalla */
        private State state;

        /** Ticket de sesion */
        public FormLoginDataSessionTicket sessionData;

        /**
         * Constructor de la clase
         */
        public FormRecepcionistaConsultaController(FormRecepcionistaConsulta forsm, FormLoginDataSessionTicket session)
        {
            this.form = forsm;
            form.datetime_init.MinDate = DateTime.Today;
            form.datetime_fin.MinDate = DateTime.Today;
            form.datetime_init.Value = DateTime.Today;
            form.datetime_fin.Value = DateTime.Today;
            boxcontroller = new BoxControllerConsulta();
            state = State.NONE;
            sessionData = session;
            initPerfil();
        }

        /**
         * Inicializa los datos de sesion FALTA LA FOTO!!!!!!!!!!!!!!!!!!!!!
         */
        private void initPerfil()
        {
            form.log_name.Text = sessionData.name;
            form.log_id.Text = sessionData.TOKEN_SESSION;
            form.log_type.Text = sessionData.tipo;
            form.log_date.Text = sessionData.fecha;
            //la foto
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
        public void buscarPorFechas()
        {
            form.treeViewConsultas.Nodes.Clear();

            if (ValidateDateTimer(form.datetime_init.Value.Date, form.datetime_fin.Value.Date))
            {
                form.label_error_fecha.Visible = false;
                TreeNode node;
                IList<ConsultaEN> lista;

                /** Recorro las fechas en el intervalo seleccionado */
                for (DateTime f = form.datetime_init.Value.Date; f <= form.datetime_fin.Value.Date; f = f.AddDays(1))
                {
                    /** Si no es dia laborable no muestra fecha */
                    if (f.DayOfWeek != System.DayOfWeek.Saturday && f.DayOfWeek != System.DayOfWeek.Sunday)
                    {
                        node = form.treeViewConsultas.Nodes.Add(f.DayOfWeek.ToString() + " - " + f.Day.ToString() + "/" + f.Month.ToString() + "/" + f.Year.ToString());
                        // Console.Write("Fecha: " + f.ToString() + "\n");
                        try
                        {
                            lista = ConsultaCEN.BuscarConsultaPorFecha(f);

                            /* Si existen consultas para ese dia se las añado sus horas y pongo el nodo como importante */
                            if (lista.Count > 0)
                            {
                                //Console.Write("Hay una consulta como minimo este dia" + f.ToString());
                                    
                                for (int i = 0; i < lista.Count; i++)
                                    node.Nodes.Add(lista[i].Fecha.Value.Hour.ToString()+":"+lista[i].Fecha.Value.Minute.ToString() + " - " + lista[i].Veterinario.Nombre + " " + lista[i].Veterinario.Apellidos);
                                lista.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Error.Write("...........ERROR...............\n" + ex.Message.ToString() + "\n");
                        }
                    }
                }
            }
            else
                form.label_error_fecha.Visible = true;
        }


        /**
         * Añade una consulta a una fecha
         */
        public void anyadirConsulta()
        {
            nodeOp = form.treeViewConsultas.SelectedNode;

            //Compruebo que estoy en un nodo raiz
            if (nodeOp != null && nodeOp.Level == 0)
            {
                state = State.ADD;
                cambiarFecha();
                cargarComboHoras();
            }
            else
                nodeOp = null;
        }

        /**
         * Cambia la fecha
         */
        public void cambiarFecha()
        {
            nodeOp = form.treeViewConsultas.SelectedNode;
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
            boxcontroller.Fecha = Convert.ToDateTime(date);
            form.box_text_fecha.Enabled = true;
            form.box_text_fecha.Text = date;
            form.box_text_fecha.Enabled = false;
            cargarComboHoras();
        }

        /**
         * Modifica una consula en una fecha y hora
         */
        public void modificarConsulta()
        {
            nodeOp = form.treeViewConsultas.SelectedNode;

            //Compruebo si estoy en un subnodo
            if (nodeOp != null && nodeOp.Level == 1)
            {
                state = State.MOD;
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

                text = Convert.ToString(nodeOp.ToString());
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
                VeterinarioEN vetMod = _IVeterinarioCAD.BuscarPorNombreYApellidos(vet_name, vet_app);
                ConsultaEN consulta = _IConsultaCAD.DameConsultaPorVeterinarioYFecha(vetMod.DNI, timeMod);
                cargarEnBoxController(consulta);
            }
            else
                nodeOp = null;
        }

        /**
         * Carga la informacion de una consulta en el boxvcontroller
         */
        private void cargarEnBoxController(ConsultaEN consulta)
        {
            boxcontroller.clear();
            boxcontroller.Fecha = consulta.Fecha.Value;
            boxcontroller.Mascota = consulta.Mascota;
            boxcontroller.Veterinario = consulta.Veterinario;
            boxcontroller.Motivo = consulta.MotivoConsulta;
            boxcontroller.Lugar = consulta.Lugar;

            form.box_text_fecha.Text = boxcontroller.Fecha.Day + "/" +  boxcontroller.Fecha.Month + "/" + boxcontroller.Fecha.Year;
            form.box_combo_hora.Text = boxcontroller.Fecha.Hour + ":" + boxcontroller.Fecha.Minute;
            form.box_text_cliente.Text = boxcontroller.Mascota.Cliente.DNI;
            form.box_combo_mascotas.Text = boxcontroller.Mascota.Nombre;
            form.box_text_motivo.Text = boxcontroller.Motivo;
            form.box_text_lugar.Text = boxcontroller.Lugar;
        }

        /**
         * Borra la consulta
         */
        public void borrarConsulta() {
            modificarConsulta();
            state = State.DEL;
        }


        /**
         * Carga la informacion de las horas disponibles para una fecha
         * HashMap<String, IList<VeterinarioEN>> (hora, veterinarios disponibles)
         */
        private void cargarComboHoras()
        {
            form.box_combo_hora.Items.Clear();
            form.box_combo_hora.FormattingEnabled = true;
            String[] horas =
                {
                    "09:00", "09:30","10:00","10:30","11:00","11:30","12:00","12:30","13:00","13:30",
                    "17:00", "17:30","18:00","18:30","19:00","19:30","20:00","20:30"
                };
            form.box_combo_hora.Items.AddRange(horas);

            try
            {
                //Cargar solo las horas disponibles para ese dia
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.ToString());
            }
        }

        /**
         * Comprueba si el cliente introducido es correcto y en caso afirmativo rellena la lista de mascotas
         */
        public void checkBoxCliente()
        {
            try
            {
                form.box_error_cliente.Visible = false;
                ClienteEN clienteEN = _IClienteCAD.DameClientePorOID(form.box_text_cliente.Text);
                form.box_combo_mascotas.Items.Clear();

                if (clienteEN != null)
                {
                    boxcontroller.Cliente = clienteEN;
                    list_mascotas = _IMascotaCAD.DameMascotaPorCliente(boxcontroller.Cliente.DNI);

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
            }
        }

        /**
         * Comprueba los veterinarios disponibles a esa fecha
         */
        public void checkBoxVeterinarios()
        {
            try
            {
                
                boxcontroller.Fecha = Convert.ToDateTime(form.box_text_fecha.Text + ' ' + form.box_combo_hora.Text + ":00");
                list_veterinarios = _IVeterinarioCAD.DameTodosLosVeterinarios(0, 3);

                if (list_veterinarios.Count > 0)
                {
                    form.box_combo_veterinario.Items.Clear();
                    String s = "";
                    for (int i = 0; i < list_veterinarios.Count; i++)
                    {
                        s += list_veterinarios[i].Nombre.ToString() + ' ' + list_veterinarios[i].Apellidos.ToString();
                        form.box_combo_veterinario.Items.Add(s);
                        s = "";

                    }
                    DateTime fecha = boxcontroller.Fecha;
                    list_veterinarios = _IConsultaCAD.DameVeterinariosPorFechayHora(fecha);

                    if (list_veterinarios.Count > 0)
                    {
                        s = "";
                        for (int i = 0; i < list_veterinarios.Count; i++)
                        {
                            s += list_veterinarios[i].Nombre.ToString() + ' ' + list_veterinarios[i].Apellidos.ToString();
                            form.box_combo_veterinario.Items.Remove(s);
                            s = "";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }

        /** 
         * Carga los campos escritos de la mascota 
         */
        private void loadVeterinarioMascota()
        {
            String vet = form.box_combo_veterinario.Text;
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
            }
        }

        public void guardarCuadroInformacion()
        {
            boxcontroller.Motivo = form.box_text_motivo.Text;
            boxcontroller.Lugar = form.box_text_lugar.Text;
            loadVeterinarioMascota();

            ConsultaCEN = new ConsultaCEN(_IConsultaCAD);
            //Si todos los campos estan correctos pos añado la consulta
           /* ConsultaEN c = new ConsultaEN();
           // ConsultaCEN consultaCEN = new ConsultaCEN();
            c.IdConsulta = 0;
            c.Fecha = boxcontroller.Fecha;
            c.MotivoConsulta = boxcontroller.Motivo;
            c.Diagnostico = "diag";
            c.Mascota = boxcontroller.Mascota;
            c.Veterinario = boxcontroller.Veterinario;
            c.Lugar = boxcontroller.Lugar;*/

            switch (state)
            {
                case State.ADD:
                    ConsultaCEN.New_(boxcontroller.Fecha, boxcontroller.Motivo, "", boxcontroller.Mascota.IdMascota, boxcontroller.Veterinario.DNI,"", boxcontroller.Lugar);
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
            state = State.NONE;
        }

        /**
         * Borrar todos los campos del box_controller asi como su informacoin asociada
         */
        public void borrarCamposCuadroInformacion()
        {
            boxcontroller.clear();

            form.box_text_motivo.Clear();
            form.box_text_lugar.Clear();
            form.box_text_cliente.Clear();

            form.box_text_fecha.Text = "";
            form.box_combo_hora.SelectedItem = null;
            form.box_combo_hora.Text = "";
            form.box_combo_mascotas.SelectedItem = null;
            form.box_combo_mascotas.Text = "";
            form.box_combo_veterinario.SelectedItem = null;
            form.box_label_veterinario.Text = "";
        }


    }
}
