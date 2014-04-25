using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class FormConsulta : Form
    {
        public string sesionUsuario;
        private ConsultaCEN consultaCEN = new ConsultaCEN();
        private TreeNode nodeOp;

        public FormConsulta()
        {
            InitializeComponent();

            textCliente.Text = "";

            //La fecha minima para asignar/modificar/borrar una consulta es hoy
            datetime_init.MinDate = DateTime.Today;
            datetime_fin.MinDate = DateTime.Today;

            datetime_init.Value = DateTime.Today;
            datetime_fin.Value = DateTime.Today;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormConsulta.ActiveForm.Close();
            Form2 f2 = new Form2();
            f2.sesionUsuario = sesionUsuario; //sesion usuario
            f2.Activate();
            f2.Visible = true;
        }

        /**
         * Boton buscar por fecha, el boton ADD, MOD y DEL estaran disponibles. El cuadro del cliente se borrar
         * si hay escrito algo
         */
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            treeViewConsultas.Nodes.Clear();
            TFecha fecha = new TFecha(datetime_init.Value.Date, datetime_fin.Value.Date);
            btn_Anaydir.Enabled = true;
            textCliente.Clear();

            if (fecha.Validar())
            {
                label_error_fecha.Visible = false;
                TreeNode node;
                IList<ConsultaEN> lista;

                /** Recorro las fechas en el intervalo seleccionado */
                for (DateTime f = datetime_init.Value.Date; f <= datetime_fin.Value.Date; f = f.AddDays(1))
                {
                    /** Si no es dia laborable no muestra fecha */
                    if (f.DayOfWeek != System.DayOfWeek.Saturday && f.DayOfWeek != System.DayOfWeek.Sunday)
                    {
                        node= treeViewConsultas.Nodes.Add(f.DayOfWeek.ToString() + " - " + f.Date.ToShortDateString());
                       // Console.Write("Fecha: " + f.ToString() + "\n");
                        try
                        {
                            lista = consultaCEN.BuscarConsultaPorFecha(f);

                            /* Si existen consultas para ese dia se las añado sus horas y pongo el nodo como importante */
                            if (lista.Count > 0)
                            {
                                //Console.Write("Hay una consulta como minimo este dia" + f.ToString());
                                node.Checked = true;
                                for (int i = 0; i < lista.Count; i++)
                                    node.Nodes.Add(lista[i].Hora.Hours.ToString() + " - " + lista[i].Veterinario.Nombre + " " + lista[i].Veterinario.Apellidos);
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
                label_error_fecha.Visible = true;
        }

        /*
         * Buscar por cliente entonces no se pueden agregar consultar, solo modificarlas y borrarlas,
         * por lo que el boton ADD permanecera inactivo, ademas los cuadros de fecha se pondran los dos
         * al dia de hoy
         */ 
        private void btnBuscar_Cliente_Click(object sender, EventArgs e)
        {
            ClienteCEN clienteCEN= new ClienteCEN();
            ClienteEN cliente;
            IList<ClienteEN> cliente_list;

            btn_Anaydir.Enabled = false;
            datetime_fin.Value = DateTime.Today;
            datetime_init.Value = DateTime.Today;

            treeViewConsultas.Nodes.Clear();

            cliente = clienteCEN.DameClientePorOID(textCliente.ToString());

            //Si la validacion por DNI es incorrecta probamos por su nombre
            if (cliente == null)
            {
                cliente_list = clienteCEN.BuscarClientePorNombre(textCliente.ToString());

                //Si existe ese nombre en la DB mostramos los clientes con su nomre y apellidos, 
                //tambien deberia mterle las consultas
                if (cliente_list.Count>0)
                {
                    for (int i = 0; i < cliente_list.Count; i++)
                        treeViewConsultas.Nodes.Add(cliente_list[i].Nombre + " " + cliente_list[i].Apellidos);

                    cliente_list.Clear();
                }
            }
            else
            {
                treeViewConsultas.Nodes.Add(cliente.Nombre + " " + cliente.Apellidos);
            }

        }

        /**
         * Boton Añadir, comprobar si se ha buscado por fecha o por cliente 
         */
        private void btn_Anaydir_Click(object sender, EventArgs e)
        {
 
            label_error_selected.Visible = false;
            nodeOp = treeViewConsultas.SelectedNode;

            //Compruebo que estoy en un nodo raiz
            if (nodeOp != null && nodeOp.Level == 0)
            {
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
                box_text_fecha.Text = date;
                box_text_fecha.Enabled = false;
                box_controller.Visible = true;
            }
            else
            {
                nodeOp = null;
                label_error_selected.Visible = true;
            }
        }

        /**
         * Boton Modificar, comprobar si se ha buscado por fecha o por cliente
         */
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            label_error_selected.Visible = false;
            nodeOp = treeViewConsultas.SelectedNode;

            //Compruebo si estoy en un subnodo
            if (nodeOp != null && nodeOp.Level == 1)
            {
                //Aqui deberia cargar todos lso datos de la consulta , el cliente se guardará en enabled=true;
                box_controller.Visible = true;
            }
            else
            {
                nodeOp = null;
                label_error_selected.Visible = true;
            }
        }

        /*
         * Boton eliminar, comprobar si se ha buscado por fecha o por cliente
         */
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            label_error_selected.Visible = false;
            nodeOp = treeViewConsultas.SelectedNode;
            
            //Compruebo si estoy en un subnodo
            if (nodeOp != null && nodeOp.Level == 1)
            {
                //Muestre un mensaje de seguridad de si esta seguro de que desea borrar esto
                box_controller.Visible = true;
            }
            else
            {
                nodeOp = null;
                label_error_selected.Visible = true;
            }
        }

        /*
         * Aqui es cuando entramos al box_controller, aqui cargaria los datos inamobibles
         */ 
        private void box_controller_Enter(object sender, EventArgs e)
        {
            /************ Se inicializa la fecha y hora, porque solo se puede añadir si buscar por fecha **********/

            //SI ES DEL METODO AÑADIR CARGAR LAS HORAS DISPONIBLES PARA ESA FECHA (supones 1 consulta=1hora)
            try
            {
                box_combo_hora.FormattingEnabled = true;
                string[] horas = new string[]
                {
                    "09:00", "09:30","10:00","10:30","11:00","11:30","12:00","12:30","13:00","13:30",
                    "17:00", "17:30","18:00","18:30","19:00","19:30","20:00","20:30"
                };
                
                DateTime time = Convert.ToDateTime(box_text_fecha.Text);
                IList<ConsultaEN> consultas = consultaCEN.BuscarConsultaPorFecha(time);
                box_combo_hora.Items.AddRange(horas);
                

                if (consultas.Count > 0)
                    for (int i = 0; i < consultas.Count; i++)
                        box_combo_hora.Items.Remove(consultas[i].Hora.Hours.ToString() + ":" + consultas[i].Hora.Minutes.ToString());
                                
            }
            catch (FormatException ex)
            {
                Console.Error.Write(ex.Message.ToString());
            }
        }

        /**
         * Con esto salimos del box_controller limpiando todos sus campos
         */ 
        private void box_controller_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //limpiar todos los campos del box_controller
            box_controller.Visible = false;
        }

        /**
         * Metodo para guardar los datos de la consulta
         */
        private void box_label_save_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Si el cliente es correcto !!

           
          //  DateTime fecha= Convert.ToDateTime(box_text_fecha.Text);
            //TimeSpan hora;
            //String motivo = box_text_motivo.Text;
            //String diagnostico = "";
            //MascotaEN mascota; // = mascotaCEN.buscarMascotaPorNombre(box_combo_mascotas.Text); que me devuelve el oid
            //VeterinarioEN veterinario; //que me devuelva el objeto veterniario
            //String lugar = box_text_lugar.Text;


            // consultaCEN.New_(consultaCEN.DameTodasLasConsultas().Count.ToString(), fecha, hora, motivo, "", mascota.IdMascota, veterinario.DNI, lugar);


        }

        /**
         * Dado un cliente comprueba si existe, y si existe rellena lo que e esta al lao suyo con sus animales correspondientes. 
         */
        private void box_text_cliente_TextChanged(object sender, EventArgs e)
        {
            box_error_cliente.Visible = false;
            ClienteCEN clienteCEN = new ClienteCEN();
           /* ClienteEN clienteEN = clienteCEN.DameClientePorOID(box_text_cliente.Text);

            if (clienteEN != null)
            {
                MascotaCEN mascotaCEN = new MascotaCEN();
                IList<MascotaEN> lista = mascotaCEN.DameMascotaPorCliente(box_text_cliente.Text);
                //74669082A
                if (lista.Count > 0 && lista!=null)
                {
                    for (int i = 0; i < lista.Count; i++)
                        box_combo_mascotas.Items.Add(lista[i].Nombre);
                }
            }
            else
            {
                box_error_cliente.Visible = true;
               // box_combo_mascotas.Items.Clear();
            }*/
        }

        /**
         * Dada una fecha determinada mostrara todas las horas libres disponibles para ese dia
         */
        private void box_combo_hora_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  String hour = box_combo_hora.SelectedIndex.ToString();
           // String date = box_text_fecha.Text;
            //String hour_vet = "";

            /*IList<VeterinarioEN> veterinarios = consultaCEN.DameVeterinariosPorConsultaFecha(Convert.ToDateTime(date));

            if(veterinarios.Count>0)
            {
                for (int i = 0; i < veterinarios.Count; i++)
                {
                    //hour_vet= 
                }
            }*/
        }   
    }
}
