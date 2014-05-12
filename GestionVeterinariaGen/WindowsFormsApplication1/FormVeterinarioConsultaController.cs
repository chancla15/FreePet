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

        /** El ticket de sesion */
        FormLoginDataSessionTicket sessionData;

        /**
         * Constructor de la clase
         * @param session el ticket de sesion
         * @param la vista a controlar
         */
        public FormVeterinarioConsultaController(FormLoginDataSessionTicket session, FormVeterinarioConsulta form)
        {
            this.form = form;
            this.sessionData = session;
            initPerfil();
        }

        /**
      * Inicializa los datos de sesion FALTA LA FOTO!!!!!!!!!!!!!!!!!!!!!
      */
        private void initPerfil()
        {
            form.log_name.Text = sessionData.name;
            //form.log_id.Text = sessionData.TOKEN_SESSION;
            //form.log_type.Text = sessionData.tipo;
            //form.log_date.Text = sessionData.fecha;
            //la foto
        }

    }
}
