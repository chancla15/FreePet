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
        ConsultaCEN consultaCEN = new ConsultaCEN();
        private Boolean SEARCH_DATE = false;
        private Boolean SEARCH_NAME = false;

        public FormConsulta()
        {
            InitializeComponent();

            textCliente.Text = "";
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
            SEARCH_NAME = false;
            SEARCH_DATE = true;
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

            SEARCH_NAME = true;
            SEARCH_DATE = false;
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
            TreeNode node = treeViewConsultas.SelectedNode;

            //Compruebo que estoy en un nodo raiz
            if (node!=null && node.Level == 0)
            {
                box_controller.Visible = true;
            }
            else
                label_error_selected.Visible = true;
        }

        /**
         * Boton Modificar, comprobar si se ha buscado por fecha o por cliente
         */
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            label_error_selected.Visible = false;
            TreeNode node = treeViewConsultas.SelectedNode;

            //Compruebo si estoy en un subnodo
            if (node != null && node.Level == 1)
            {
                box_controller.Visible = true;
            }
            else
                label_error_selected.Visible = true;
        }

        /*
         * Boton eliminar, comprobar si se ha buscado por fecha o por cliente
         */
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            label_error_selected.Visible = false;
            TreeNode node = treeViewConsultas.SelectedNode;
            
            //Compruebo si estoy en un subnodo
            if (node != null && node.Level == 1)
            {
                box_controller.Visible = true;
            }
            else
                label_error_selected.Visible = true;
        }

        /*
         * Aqui es cuando entramos al box_controller, aqui cargaria los datos inamobibles
         */ 
        private void box_controller_Enter(object sender, EventArgs e)
        {
          
  

        }

        /**
         * Con esto salimos del box_controller limpiando todos sus campos
         */ 
        private void box_controller_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //limpiar todos los campos del box_controller
            box_controller.Visible = false;
        }        
    }
}
