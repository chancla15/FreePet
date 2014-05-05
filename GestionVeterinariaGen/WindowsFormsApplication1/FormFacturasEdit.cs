using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormFacturasEdit : Form
    {
        FacturaEN factura;
        IList<MascotaEN> mascotas;
        IList<TratamientoEN> tratamientos;
        FormFacturas ff;
        public FormFacturasEdit(FacturaEN factura, FormFacturas ff)
        {
            this.factura = factura;
            this.ff = ff;
            InitializeComponent();
            CargarDatosEditar();
            Activate();
            Visible = true;
         
        }

        private void CargarDatosEditar()
        {
            String nombreMascota = new MascotaCEN().BuscarMascotaPorOID(factura.Consulta.Mascota.IdMascota).Nombre;

            tb_Fecha.Text = factura.Fecha.ToString();
            tb_Total.Text = factura.Total.ToString();
            tb_Pagada.Text = factura.Pagada ? "Si" : "No";
            tb_Motivo.Text = factura.Consulta.MotivoConsulta;
            tb_Mascota.Text = nombreMascota;
            tb_Tratamiento.Text = factura.Consulta.Tratamiento.Nombre;

            mascotas = new MascotaCEN().DameMascotaPorCliente(factura.Cliente.DNI); //lista de mascotas para el combobox
            for (int i = 0; i < mascotas.Count; i++)
                cb_Mascota.Items.Add(mascotas[i].Nombre);
            
            tratamientos = new TratamientoCEN().DameTodosLosTratamientos(0, 17);
            for (int i = 0; i < tratamientos.Count; i++)
                cb_Tratamiento.Items.Add(tratamientos[i].Nombre + " (" + tratamientos[i].Precio + ")");
        }

        private void l_Modificar_Click(object sender, EventArgs e)
        {
            FacturaCEN FacturaCEN = new FacturaCEN();
            //Guardamos la consulta de la factura actual para modificar los campos necesarios e introducirla en la factura nueva(ya que al modificar no deja modificar la consulta)
            ConsultaEN c1 = factura.Consulta;
            c1.MotivoConsulta = tb_Motivo.Text;
            //Si no has seleccionado una mascota del combobox o es la misma no modifica la mascota
            if (!String.IsNullOrEmpty(cb_Mascota.SelectedText)) 
                c1.Mascota = mascotas[cb_Mascota.SelectedIndex];
            //Lo mismo para los tratamientos
            if (!String.IsNullOrEmpty(cb_Tratamiento.SelectedText))
                c1.Tratamiento = tratamientos[cb_Tratamiento.SelectedIndex];

            //Imagino que una manera de que no se desordenen sea añadir manualmente el id de factura pero a partir del ultimo, 
            //con un hql de alguna manera, eso suponiendo que al llamar a la operacion para crear la lista las devuelva en orden de id.
            //Como ahora mismo es autogenerado cada vez que elimina y crea una factura aparece al final de la lista.
            //Auque si suponemos que cuando modificas es para pagar normalmente no es mala idea que aparezcan al final una vez pagadas.
            FacturaCEN.Destroy(factura.IdFactura); 
            FacturaCEN.New_(DateTime.Parse(tb_Fecha.Text), float.Parse(tb_Total.Text), factura.Cliente.DNI, c1, tb_Pagada.Text.Equals("Si") ? true : false);
            
            Close();

            ff = new FormFacturas(factura.Cliente.DNI);

        }

        private void l_Salir_Click(object sender, EventArgs e)
        {
            Close();
            ff.Visible = true;
        }

        private void l_Eliminar_Click(object sender, EventArgs e)
        {
            new FacturaCEN().Destroy(factura.IdFactura);
            Close();
            ff = new FormFacturas(factura.Cliente.DNI);
        }
    }
}
