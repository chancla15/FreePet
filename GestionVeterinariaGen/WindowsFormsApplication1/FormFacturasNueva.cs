using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormFacturasNueva : Form
    {
        String DNI;
        FormFacturas ff;
        IList<ConsultaEN> consultas;
        public FormFacturasNueva(String DNI, FormFacturas ff)
        {
            this.DNI = DNI;
            this.ff = ff;
            InitializeComponent();
            CargarConsultas();
            Activate();
            Visible = true;
        }
        private void CargarConsultas()
        {
            consultas = new ConsultaCEN().DameTodasLasConsultas(0, 2);
            for (int i = 0; i < consultas.Count; i++)
                cb_Consultas.Items.Add("Fecha: " + consultas[i].Fecha.ToString() + ", Mascota: " 
                    + new MascotaCEN().BuscarMascotaPorOID(consultas[i].Mascota.IdMascota).Nombre + ", Motivo: " 
                    + consultas[i].MotivoConsulta + ", Tratamiento: " + consultas[i].Tratamiento.Nombre + ", Coste: " 
                    + new TratamientoCEN().DameTratamientoPorOID(consultas[i].Tratamiento.Nombre).Precio);
        }

        private void l_Crear_Click(object sender, EventArgs e)
        {
            ConsultaEN c = new ConsultaEN(consultas[cb_Consultas.SelectedIndex]);
            new FacturaCEN().New_(c.Fecha, float.Parse(tb_Total.Text),DNI, c, tb_Pagada.Text.Equals("Si") ? true : false);

            Close();
            ff = new FormFacturas(DNI);
        }

        private void l_Salir_Click(object sender, EventArgs e)
        {
            Close();
            ff.Visible = true;
        }
    }
}
