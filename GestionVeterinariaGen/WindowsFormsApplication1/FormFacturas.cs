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
    public partial class FormFacturas : Form
    {
        public String DNI;
        public IList<FacturaEN> lista;
        public FormFacturas(String DNI)
        {
            this.DNI = DNI;
            InitializeComponent();
            Activate();
            Visible = true;
        }
        private void FormFactura_Load(object sender, EventArgs e)
        {
            ClienteCEN ClienteCEN = new ClienteCEN();
            ClienteEN cliente = ClienteCEN.DameClientePorOID(DNI);
            FacturaCEN FacturaCEN = new FacturaCEN();
            lista = FacturaCEN.DameFacturasPorCliente(DNI);
            l_Nombre.Text = cliente.Nombre + " " + cliente.Apellidos;
            
            for (int i = 0; i < lista.Count; i++)
            {
                //Num, fecha, total, mascota, motivo, pagada, pagar
                dataGridView1.Rows.Add(i + 1, lista[i].Fecha, lista[i].Total, new MascotaCEN().BuscarMascotaPorOID(lista[i].Consulta.Mascota.IdMascota).Nombre,
                    lista[i].Consulta.MotivoConsulta,lista[i].Pagada == true ? "Si" : "No", lista[i].Consulta.Tratamiento.Nombre, "X");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                FormFacturasEdit ffe = new FormFacturasEdit(lista[e.RowIndex], this);
                Hide();
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormFacturasNueva ffn = new FormFacturasNueva(DNI, this);
            Hide();
        }

   }


}
