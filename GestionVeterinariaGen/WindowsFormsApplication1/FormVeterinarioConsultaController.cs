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
            initPerfil();
        }

        /**
      * Inicializa los datos de sesion FALTA LA FOTO!!!!!!!!!!!!!!!!!!!!!
      */
        private void initPerfil()
        {
            //form.log_name.Text = form.menu.sessionData.name;
            //form.log_id.Text = sessionData.TOKEN_SESSION;
            //form.log_type.Text = sessionData.tipo;
            //form.log_date.Text = sessionData.fecha;
            //la foto
        }

        public void loadData(MascotaEN mascota)
        {
            if (mascota != null)
            {
                form.label_doc.Text = "Consulta realizada por "+form.menu.sessionData.name;
                form.textBox_mascota.Text = mascota.Nombre;
                form.textBox_color.Text = mascota.Color;
                form.textBox_especie.Text = mascota.Especie;
                //form.textBox_fn.Text = System.DateTime.Parse(mascota.FNacimiento.ToString());
                form.textBox_peso.Text = ""+mascota.Peso;
                form.textBox_sexo.Text = ""+mascota.Sexo;
                form.textBox_tam.Text = ""+mascota.Tamanyo;
                form.textBox_raza.Text = mascota.Raza;

                if (mascota.Microchip)
                    form.textBox_chip.Text = "Sí";
                else
                    form.textBox_chip.Text = "No";
                
            }
        }
    }
}
