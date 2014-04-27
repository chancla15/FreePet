using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    /**
     * Controlador de la clase formulario consulta
     */
    class FormConsultaController
    {
        /** Variable privada de clase formulario consulta*/
        public FormConsulta form;

        /** Varialbe de tipo nodo del TreeView */
        private TreeNode nodeOp;

        /** Estados importantes de la pantalla */
        private enum State {
            SEARCH, ADD, MOD, DEL, NONE
        }

        /** Estado actual de la pantalla */
        private State state = State.NONE;

        /** Variable privada para realizar busquedas en la DB */
        private ConsultaCEN consultaCEN;

        /** La lista de consulas de la fecha actual */
        private IList<ConsultaEN> consultasActual;

        /**
         * Constructor de la clase
         */
        public FormConsultaController(FormConsulta forsm)
        {
            this.form = forsm;

            form.datetime_init.MinDate = DateTime.Today;
            form.datetime_fin.MinDate = DateTime.Today;
            form.datetime_init.Value = DateTime.Today;
            form.datetime_fin.Value = DateTime.Today;
            form.box_controller.Visible = true;
        }

        /**
         * Busca consultas entre dos fechas comprobando que ambas son correctas
         */
        public void buscarPorFechas()
        {
            form.treeViewConsultas.Nodes.Clear();
            TFecha fecha = new TFecha(form.datetime_init.Value.Date, form.datetime_fin.Value.Date);

            if (fecha.Validar())
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
                            lista = consultaCEN.BuscarConsultaPorFecha(f);

                            /* Si existen consultas para ese dia se las añado sus horas y pongo el nodo como importante */
                            if (lista.Count > 0)
                            {
                                //Console.Write("Hay una consulta como minimo este dia" + f.ToString());
                                    
                                for (int i = 0; i < lista.Count; i++)
                                    node.Nodes.Add(lista[i].Fecha.Value.Hour.ToString() + " - " + lista[i].Veterinario.Nombre + " " + lista[i].Veterinario.Apellidos);
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
                form.box_text_fecha.Enabled = false;
            }
            else
                nodeOp = null;
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
                //Muestre un mensaje de seguridad de si esta seguro de que desea borrar esto
                //box_controller.Visible = true;
            }
            else
                nodeOp = null;
        }

        /**
         * Borra la consulta
         */
        public void borrarConsulta() {
            nodeOp = form.treeViewConsultas.SelectedNode;

            //Compruebo si estoy en un subnodo
            if (nodeOp != null && nodeOp.Level == 1)
            {
                //Muestre un mensaje de seguridad de si esta seguro de que desea borrar esto
                //box_controller.Visible = true;
            }
            else
                nodeOp = null;
        }


        /**
         * Carga la informacion minima en el cuadro de carga
         */
        public void cargarCuadroInformacion()
        {
            //SI ES DEL METODO AÑADIR CARGAR LAS HORAS DISPONIBLES PARA ESA FECHA (supones 1 consulta=1hora)
            try
            {
                consultasActual.Clear();
                form.box_combo_hora.FormattingEnabled = true;
                String[] horas =
                {
                    "09:00", "09:30","10:00","10:30","11:00","11:30","12:00","12:30","13:00","13:30",
                    "17:00", "17:30","18:00","18:30","19:00","19:30","20:00","20:30"
                };

                DateTime time = Convert.ToDateTime(form.box_text_fecha.Text);
                if (time != null)
                {
                    form.box_combo_hora.Items.AddRange(horas);
                    consultasActual = consultaCEN.BuscarConsultaPorFecha(time);
                    DateTime act;

                   /* if (consultasActual.Count > 0)
                    {
                        for (int i = 0; i < consultasActual.Count; i++)
                        {
                            act = consultasActual[i].Fecha.Value;
                            form.box_combo_hora.Items.Remove(act.Hour.ToString() + ":" + act.Minute.ToString());
                        }
                    }*/
                }
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
            form.box_error_cliente.Visible = false;
            ClienteCEN clienteCEN = new ClienteCEN();
            ClienteEN clienteEN = clienteCEN.DameClientePorOID(form.box_text_cliente.Text);

             if (clienteEN != null)
             {
                 MascotaCEN mascotaCEN = new MascotaCEN();
                 IList<MascotaEN> lista = mascotaCEN.DameMascotaPorCliente(form.box_text_cliente.Text);
                 //74669082A
                 if (lista.Count > 0 && lista!=null)
                 {
                     for (int i = 0; i < lista.Count; i++)
                         form.box_combo_mascotas.Items.Add(lista[i].Nombre);
                 }
             }
             else
             {
                 form.box_error_cliente.Visible = true;
                 form.box_combo_mascotas.Items.Clear();
             }
        }

        /**
         * Comprueba los veterinarios disponibles a esa fecha
         */
        public void checkBoxVeterinarios()
        {
            VeterinarioCEN veterinarioCEN= new VeterinarioCEN();
            IList<VeterinarioEN> veterinarios = veterinarioCEN.DameTodosLosVeterinarios();

            if (veterinarios.Count > 0)
            {
                for (int i = 0; i < veterinarios.Count; i++)
                    form.box_combo_veterinario.Items.Add(veterinarios[i].Nombre.ToString());

                for (int i = 0; i < consultasActual.Count; i++)
                    form.box_combo_veterinario.Items.Remove(consultasActual[i].Veterinario.Nombre.ToString());
            }
        }

        public void guardarCuadroInformacion()
        {
            string fecha, hora, motivo, cliente, animal, veterinario, lugar;
            fecha = form.box_text_fecha.Text.ToString();
            /*hora = form.box_combo_hora.SelectedItem.ToString();
            motivo= form.box_text_motivo.Text.ToString();
            cliente = form.box_text_cliente.Text.ToString();
            animal = form.box_combo_mascotas.SelectedItem.ToString();
            veterinario = form.box_combo_veterinario.SelectedItem.ToString();
            lugar = form.box_text_lugar.Text.ToString();*/

            //Comprobar que ningun campo sea vacio y obtener los oid para rellenar la consulta
            String oid_mascota, oid_veterinario;
            hora = "10:30:00";
            DateTime tt = Convert.ToDateTime(fecha + ' ' + hora);
            
            //DateTime timer_cons = Convert.ToDateTime(fecha); */
            Console.WriteLine("FECHA: " + tt.ToString());

        }

        public void borrarCamposCuadroInformacion()
        {
            
        }

        public void activeFormComponents(Boolean t) {

            form.datetime_init.Enabled = t;
            form.datetime_fin.Enabled = t;
            form.btnBuscar_Fecha.Enabled = t;
            form.treeViewConsultas.Enabled = t;
            form.btn_Return.Enabled = t;
            form.image_add.Enabled = t;
            form.image_mod.Enabled = t;
            form.image_del.Enabled = t;
        }
    }
}
