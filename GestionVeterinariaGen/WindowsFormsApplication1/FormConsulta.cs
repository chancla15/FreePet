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

        public FormConsulta()
        {
            InitializeComponent();

            textCliente.Text = "";
            textMascota.Text = "";
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
         * Boton aceptar
         */
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

        /**
         * Boton buscar
         */
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TFecha fecha = new TFecha(datetime_init.Value.Date, datetime_fin.Value.Date);

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
                        lista = consultaCEN.BuscarConsultaPorFecha(f.Date);

                        /** Si existen consultas para ese dia se las añado sus horas y pongo el nodo como importante */
                        if (lista.Count > 0)
                        {
                            node.Checked = true;
                            for (int i = 0; i < lista.Count; i++)
                                node.Nodes.Add(lista[i].Hora.Hours.ToString() + " - " + lista[i].Mascota.Especie.ToString());
                        }
                    }
                }
            }
            else
            {
                label_error_fecha.Visible = true;
            }
        }        
    }
}
