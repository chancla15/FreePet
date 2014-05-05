using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Collections;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormFacturaRecepcionistaController
     * La encargada de controlar la vista facturas
     */
    class FormRecepcionistaFacturaController
    {
        /** El formulario a controlar */
        private FormRecepcionistaFactura frf;

        /** El ticket de sesion */
        public FormLoginDataSessionTicket sessionData;

        private IList<FacturaEN> facturas;
        private FacturaEN factura;
        private IList<MascotaEN> mascotas;
        private IList<TratamientoEN> tratamientos;
        /**
         * El constructor
         * @param s el ticket de sesion
         * @param f el formulario a controlar
         */
        public FormRecepcionistaFacturaController(FormLoginDataSessionTicket sessionData, FormRecepcionistaFactura frf)
        {
            this.sessionData = sessionData;
            this.frf = frf;
        }

        public string getScreenState(DataGridViewCellEventArgs ev, char action)
        {
            string cli = "";

            if (frf.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Eliminar"))
                action = 'E';
            else if (frf.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Modificar"))
                action = 'M';
            else if (frf.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Añadir"))
                action = 'A';

            if (action == 'E' || action == 'M' || action == 'A')
                cli = frf.dataGridView1.Rows[ev.RowIndex].Cells[0].Value.ToString();

            return cli;
        }

        public void CargarFacturasDataGrid()
        {
            ClienteCEN ClienteCEN = new ClienteCEN();
            ClienteEN cliente = ClienteCEN.DameClientePorOID("74669082A");
            FacturaCEN FacturaCEN = new FacturaCEN();
            facturas = FacturaCEN.DameFacturasPorCliente("74669082A");
            frf.l_Nombre.Text = cliente.Nombre + " " + cliente.Apellidos;
            

            for (int i = 0; i < facturas.Count; i++)
            {
                //Num, fecha, total, mascota, motivo, pagada, pagar
                frf.dataGridView1.Rows.Add(i + 1, facturas[i].Fecha, facturas[i].Total, new MascotaCEN().BuscarMascotaPorOID(facturas[i].Consulta.Mascota.IdMascota).Nombre,
                    facturas[i].Consulta.MotivoConsulta, facturas[i].Pagada == true ? "Si" : "No", facturas[i].Consulta.Tratamiento.Nombre, "X");

            }

        }
        public void CargarBoxController(int indiceFactura)
        {
            frf.gp_ModificarFactura.Visible = true;

            factura = facturas[indiceFactura];

            String nombreMascota = new MascotaCEN().BuscarMascotaPorOID(factura.Consulta.Mascota.IdMascota).Nombre;

            frf.tb_Fecha.Text = factura.Fecha.ToString();
            frf.tb_Total.Text = factura.Total.ToString();
            frf.tb_Pagada.Text = factura.Pagada ? "Si" : "No";
            frf.tb_Motivo.Text = factura.Consulta.MotivoConsulta;
            frf.tb_Mascota.Text = nombreMascota;
            frf.tb_Tratamiento.Text = factura.Consulta.Tratamiento.Nombre;

            mascotas = new MascotaCEN().DameMascotaPorCliente(factura.Cliente.DNI); //lista de mascotas para el combobox
            for (int i = 0; i < mascotas.Count; i++)
                frf.cb_Mascota.Items.Add(mascotas[i].Nombre);

            tratamientos = new TratamientoCEN().DameTodosLosTratamientos(0, 17);
            for (int i = 0; i < tratamientos.Count; i++)
                frf.cb_Tratamiento.Items.Add(tratamientos[i].Nombre + " (" + tratamientos[i].Precio + ")");
        }
        public void EliminarFactura()
        {
            new FacturaCEN().Destroy(factura.IdFactura);
        }

        public void ModificarFactura()
        {
            FacturaCEN FacturaCEN = new FacturaCEN();
            //Guardamos la consulta de la factura actual para modificar los campos necesarios e introducirla en la factura nueva(ya que al modificar no deja modificar la consulta)
            ConsultaEN c1 = factura.Consulta;
            c1.MotivoConsulta = frf.tb_Motivo.Text;
            //Si no has seleccionado una mascota del combobox o es la misma no modifica la mascota
            if (!String.IsNullOrEmpty(frf.cb_Mascota.SelectedText))
                c1.Mascota = mascotas[frf.cb_Mascota.SelectedIndex];
            //Lo mismo para los tratamientos
            if (!String.IsNullOrEmpty(frf.cb_Tratamiento.SelectedText))
                c1.Tratamiento = tratamientos[frf.cb_Tratamiento.SelectedIndex];

            //Imagino que una manera de que no se desordenen sea añadir manualmente el id de factura pero a partir del ultimo, 
            //con un hql de alguna manera, eso suponiendo que al llamar a la operacion para crear la lista las devuelva en orden de id.
            //Como ahora mismo es autogenerado cada vez que elimina y crea una factura aparece al final de la lista.
            //Auque si suponemos que cuando modificas es para pagar normalmente no es mala idea que aparezcan al final una vez pagadas.
            FacturaCEN.Destroy(factura.IdFactura);
            FacturaCEN.New_(DateTime.Parse(frf.tb_Fecha.Text), float.Parse(frf.tb_Total.Text), factura.Cliente.DNI, c1, frf.tb_Pagada.Text.Equals("Si") ? true : false);

            frf.gp_ModificarFactura.Visible = false;
            frf.Hide();
            frf = new FormRecepcionistaFactura(sessionData);
        }
    }
}
