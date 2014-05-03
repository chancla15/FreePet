using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormMascotaRecepcionistaController
     * Sera la encargada de controlar del formulario de mascotas
     */
    class FormRecepcionistaMascotaController
    {
        /** El formulario a controlar */
        private FormRecepcionistaMascota form;

        /** El ticket de sesion */
        public FormLoginDataSessionTicket sessionData;

        /** EL CAD para acceder a la tabla mascotas */
        private MascotaCAD _IMascotaCAD = new MascotaCAD();

        /** El CEN para acceder a la tabla clientes */
        private ClienteCAD _IClienteCAD = new ClienteCAD();

        /** El CAD para acceder a las consultas del animal */
        private ConsultaCAD _IConsultaCAD = new ConsultaCAD();

        /** EL CEN para acceder a la tabla mascotas */
        private MascotaCEN MascotaCEN;

        /** El CEN para acceder a la tabla cliente */
        private ClienteCEN ClienteCEN;

        /** El CEN para acceder a la tabla consultas */
        private ConsultaCEN ConsultaCEN;

         /**
         * El constructor
         * @param s el ticket de sesion
         * @param f el formulario a controlar
         */
        public FormRecepcionistaMascotaController(FormLoginDataSessionTicket s, FormRecepcionistaMascota f) {
            this.sessionData = s;
            this.form = f;
            MascotaCEN = new MascotaCEN(_IMascotaCAD);
            ClienteCEN = new ClienteCEN(_IClienteCAD);
            ConsultaCEN = new ConsultaCEN(_IConsultaCAD);
        }

        /**
         * Carga los datos de una mascota dado un cliente y un identificador de mascota
         */
        public void Guardar()
        {
            /*MascotaEN mascota = _IMascotaCAD.BuscarMascotaPorOID();

            if (mascota != null)
            {
                mascota.Cliente.DNI = _IClienteCAD.DameClientePorOID(form.text_cliente.Text).DNI;
                mascota.Nombre = form.text_nombre.Text;
                mascota.Especie = form.combo_especie.SelectedItem.ToString();
                mascota.Raza = form.text_raza.Text;
                //mascota.Tamanyo = form.combo_tamanyo.SelectedItem.ToString();
                mascota.Peso = float.Parse(form.text_peso.Text);
                mascota.FNacimiento = Convert.ToDateTime(form.dateTime_fnac.Text);
                // mascota.Sexo = form.combo_sexo.SelectedItem.ToString();
                mascota.Color = form.text_color.Text;
                // mascota.Microchip = form.combo_microchip.SelectedItem.ToString();
                mascota.Consulta = ConsultaCEN.DameConsultaPorAnimal(Id);
            }
            else
            {
                //ERROR MASCOTA NO ENCONTRADA
            }*/
        }

        /**
         * Carga una mascota en el formulario
         */
        public void loadData(string msc)
        {
            MascotaEN mascota = _IMascotaCAD.BuscarMascotaPorOID(msc);

            if (mascota != null)
            {
                form.text_cliente.Text = mascota.Cliente.DNI;
                form.text_nombre.Text = mascota.Nombre;
                form.combo_especie.Text = mascota.Especie;
                form.text_raza.Text = mascota.Raza;
                form.combo_tamanyo.Text = mascota.Tamanyo.ToString();
                form.text_peso.Text = mascota.Peso.ToString();
                form.dateTime_fnac.Value = mascota.FNacimiento.Value;
                form.combo_sexo.Text = mascota.Sexo.ToString();
                form.text_color.Text = mascota.Color;
                form.combo_microchip.Text = mascota.Microchip.ToString();

                IList<ConsultaEN> consultas = ConsultaCEN.DameConsultaPorAnimal(msc);
                form.dataGridView1.DataSource = null;
                form.dataGridView1.Refresh();

                if (consultas != null && consultas.Count > 0)
                {
                    for(int i=0;i<consultas.Count;i++)
                    {
                        form.dataGridView1.Rows.Add(consultas[i].Fecha.Value.ToString(), consultas[i].MotivoConsulta, consultas[i].Lugar, consultas[i].Veterinario.DNI);
                    }
                }

            }
        }


        public string getStateScreen(DataGridViewCellEventArgs ev, char action)
        {
            string cli = "";

            if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Eliminar"))
                action = 'E';
            else if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Modificar"))
                action = 'M';

            if (action == 'E' || action == 'M')
                cli = form.dataGridView1.Rows[ev.RowIndex].Cells[0].Value.ToString();
            
            return cli;
        }
    }
}
