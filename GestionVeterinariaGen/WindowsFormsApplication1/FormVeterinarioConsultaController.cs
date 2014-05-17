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
            }
        }
    }
}
