/* 
    FreePet. OpenSource Software Veterinarian Management
    Copyright (C) 2014  Jesus Manresa Parres

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormConsultaVeterinarioController
     * El controlador de manejar los datos de la vista de consultas del veterinario
     */
    class FormVeterinarioConsultaController
    {
        /** La vista */
        FormVeterinarioConsulta form;
        ConsultaEN consulta;

        /**
         * Constructor de la clase
         * @param session el ticket de sesion
         * @param la vista a controlar
         */
        public FormVeterinarioConsultaController(FormVeterinarioConsulta form)
        {
            this.form = form;
        }

        public void loadData(MascotaEN mascota, ConsultaEN consulta)
        {
            if (mascota != null)
            {
                form.listBox_addTratamiento.Items.Clear();
                this.consulta = consulta;
                consulta.Tratamiento = Utils._ITratamientoCAD.DameTratamientosPorConsulta(consulta.IdConsulta);
                form.label_doc.Text = "Consulta realizada por "+form.menu.sessionData.name;
                form.textBox_mascota.Text = mascota.Nombre;
                form.textBox_color.Text = mascota.Color;
                form.textBox_especie.Text = mascota.Especie;
                form.textBox_fn.Text = mascota.FNacimiento.Value.Day.ToString() + "/" + mascota.FNacimiento.Value.Month.ToString() + "/" + mascota.FNacimiento.Value.Year.ToString();
                form.textBox_sexo.Text = mascota.Sexo.ToString();
                form.textBox_peso.Text = mascota.Peso.ToString();
                form.textBox_tam.Text = mascota.Tamanyo.ToString();
                form.textBox_raza.Text = mascota.Raza;
                form.textBox_cliente.Text = "" + mascota.Cliente.DNI.ToString();
                form.text_hora.Text = DateTime.Now.Hour+ ":" + DateTime.Now.Minute.ToString();
                form.text_fecha.Text = form.textBox_fn.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

                form.text_lugar.Text = consulta.Lugar;
                form.text_motivo.Text = consulta.MotivoConsulta;

                form.text_diagnostico.Text = consulta.Diagnostico;

                if (mascota.Microchip)
                    form.textBox_chip.Text = "Sí";
                else
                    form.textBox_chip.Text = "No";

                //añadimos al listbox los tratamientos que ya tenga asociado.
                IList<TratamientoEN> tratamientos = Utils._ITratamientoCAD.DameTratamientosPorConsulta(consulta.IdConsulta);
                for (int x = 0; x < tratamientos.Count; x++)
                    form.listBox_addTratamiento.Items.Add(tratamientos[x].Nombre);
            }
        }

        public void addTratamientos()
        {
            IList<string> borrar = new List<string>();
            ConsultaEN todas_c = Utils._IConsultaCAD.DameConsultaPorOID(consulta.IdConsulta);
            IList<string> tratamientos = new List<string>();
            float total =10;
            for (int i = 0; i < consulta.Tratamiento.Count; i++)
                borrar.Add(Convert.ToString(consulta.Tratamiento[i].Nombre));

            Utils._ConsultaCEN.QuitarTratamiento(consulta.IdConsulta, borrar);

            if (form.listBox_addTratamiento.Items.Count > 0)
            {
                for (int x = 0; x < form.listBox_addTratamiento.Items.Count; x++)
                {
                    form.listBox_addTratamiento.SetSelected(x, true);
                    tratamientos.Add(form.listBox_addTratamiento.SelectedItem.ToString());
                }
                //form.listBox_addTratamiento.SetSelected(1, false);//deseleccionamos
                Utils._ConsultaCEN.AnaydirTratamiento(consulta.IdConsulta, tratamientos);
                IList<TratamientoEN> tratsaux = Utils._ITratamientoCAD.DameTratamientosPorConsulta(consulta.IdConsulta);
                for (int j = 0; j < tratsaux.Count; j++)
                    total += tratsaux[j].Precio;
            }
            if (consulta.Factura == null)
            {
                Utils._FacturaCEN.New_(consulta.Fecha, total, Utils._IMascotaCAD.DameClientePorMascota(consulta.Mascota.IdMascota).DNI, consulta.IdConsulta, false);
            }
            else
                Utils._FacturaCEN.Modify(consulta.Factura.IdFactura, consulta.Fecha, total, false);
            

        }
    }
}
