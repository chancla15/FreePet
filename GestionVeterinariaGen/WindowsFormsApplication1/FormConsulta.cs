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
         * Boton buscar
         */
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            treeViewConsultas.Nodes.Clear();
            TFecha fecha = new TFecha(datetime_init.Value.Date, datetime_fin.Value.Date);
            SEARCH_NAME = false;
            SEARCH_DATE = true;

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
                        Console.Write("Fecha: " + f.ToString() + "\n");
                        try
                        {
                            lista = consultaCEN.BuscarConsultaPorFecha(f);

                            /* Si existen consultas para ese dia se las añado sus horas y pongo el nodo como importante */
                            if (lista.Count > 0)
                            {
                                Console.Write("Hay una consulta como minimo este dia" + f.ToString());
                                node.Checked = true;
                                for (int i = 0; i < lista.Count; i++)
                                    node.Nodes.Add(lista[i].Hora.Hours.ToString());// + " - " + lista[i].Mascota.Especie.ToString());
                                lista.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Write("...........ERROR...............\n" + ex.Message.ToString() + "\n");
                        }
                    }
                }
            }
            else
                label_error_fecha.Visible = true;
        }

        private void btnBuscar_Cliente_Click(object sender, EventArgs e)
        {
            ClienteCEN clienteCEN= new ClienteCEN();
            ClienteEN cliente;
            IList<ClienteEN> cliente_list;

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
    }
}
