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

        private List<DateTime> fechas_consultas;
        public string sesionUsuario;

        public FormAddConsulta()
        {
            InitializeComponent();
        }

        private void GetConsultasDates()
        {
            //Inicializar fechas_consultas
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
            ConsultaCEN consultaCEN = new ConsultaCEN();

            ClienteEN cliente = clienteCEN.DameClientePorOID(textCliente.ToString());
            MascotaEN mascota = new MascotaEN(); ;// = mascotaCEN.DameMascotaPorNombreyCliente(cliente.DNI, textMascota.ToString());

            if (cliente.DNI != "")
            {
                textCliente.Clear();
                label_error_cliente.Visible = true;
            }
            else
            {
                if (mascota.IdMascota == "" || mascota.Cliente != cliente)
                {
                    textMascota.Clear();
                    label_error_mascota.Visible = true;
                }
                else
                {
                    
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
