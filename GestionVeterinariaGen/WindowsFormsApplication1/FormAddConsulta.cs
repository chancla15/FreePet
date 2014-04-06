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
    public partial class FormAddConsulta : Form
    {
        public string sesionUsuario;
        ConsultaCEN consultaCEN = new ConsultaCEN();

        public FormAddConsulta()
        {
            InitializeComponent();

            textCliente.Text = "";
            textMascota.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormAddConsulta.ActiveForm.Close();
            Form2 f2 = new Form2();
            f2.sesionUsuario = sesionUsuario; //sesion usuario
            f2.Activate();
            f2.Visible = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ClienteCEN clienteCEN = new ClienteCEN();
            MascotaCEN mascotaCEN = new MascotaCEN();

            ClienteEN cliente = clienteCEN.DameClientePorOID(textCliente.ToString());
            MascotaEN mascota = null; // mascotaCEN.DameMascotaPorNombreyCliente(cliente.DNI, textMascota.ToString());

                if (cliente==null)
                {
                    //Console.Write("Hola Mascota");
                    textCliente.Clear();
                    label_error_cliente.Visible = true;
                }
                else
                {
                    if (mascota==null || mascota.Cliente != cliente)
                    {
                        //Console.Write("HOla mascota\n");
                        textMascota.Clear();
                        label_error_mascota.Visible = true;
                    }
                    else
                    {
                        label_error_cliente.Visible = false;
                        label_error_mascota.Visible = false;
                        //Aqui se crearia la nueva consulta!!!!!
                        
                    }
                }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TFecha fecha = new TFecha(datetime_init.Value.Date, datetime_fin.Value.Date);

            if (fecha.Validar())
            {
                label_error_fecha.Visible = false;
                DateTime counter = datetime_init.Value.Date;
                Boolean exit = false;
                treeViewConsultas.Nodes.Add(counter.DayOfWeek.ToString() + " - " + counter.Date.ToShortDateString());
                counter.AddDays(2);
                treeViewConsultas.Nodes.Add(counter.DayOfWeek.ToString() + " - " + counter.Date.ToShortDateString());


                
                /*while(!exit)
                {
                    if (counter == datetime_fin.Value.Date)
                        exit = true;
                    else
                    {
                        treeViewConsultas.Nodes.Add(counter.DayOfWeek.ToString() + " - " + counter.Date.ToShortDateString());
                        counter.AddDays(1);
                    }
                }*/






                //treeViewConsultas.Nodes.Add(DateTime.Today.DayOfWeek.ToString() + " - " + DateTime.Today.Date.ToShortDateString());
                //IList<ConsultaEN> consultas = consultaCEN.DameConsultaEntreDosFechas(datetime_init.Value.Date, datetime_fin.Value.Date);

                //for (DateTime i = datetime_init.Value.Date; i!=datetime_fin.Value.Date; i.AddDays(1))
                //{
                   // if (i.DayOfWeek != System.DayOfWeek.Sunday && i.DayOfWeek != System.DayOfWeek.Saturday)
                    //{
                        //Añado el nodo superior de cada fecha y lo guardo en el nodo principal
                        //TreeNode node= treeViewConsultas.Nodes.Add(i.DayOfWeek.ToString() + " - " + i.Date.ToShortDateString());

                        //Ahora añado el nodo secundario que contendra una hora, X nodos de estos por cada fecha
                        //ahora por cada consulta en esa fecha::    node.Nodes.Add(consulta.Hora +  "-" + consultaId);

                   
                        
                    //}
               // }
                 

            }
            else
            {
                label_error_fecha.Visible = true;
            }
        }        
    }
}
