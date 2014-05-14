using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            form.label_doc.Text = "Consulta realizada por " + form.menu.sessionData.name;
            //form.log_name.Text = form.menu.sessionData.name;
            //form.log_id.Text = sessionData.TOKEN_SESSION;
            //form.log_type.Text = sessionData.tipo;
            //form.log_date.Text = sessionData.fecha;
            //la foto
        }

    }
}
