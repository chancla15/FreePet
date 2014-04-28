using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormStartAdministradorController
     * Sera la encargada de manejar la vista principal del administrador
     */
    class FormStartAdministradorController
    {
        /** La vista */
        private FormStartAdministrador form;

        /** EL ticket de sesion */
        public FormLoginDataSessionTicket sessionData;

        /**
         * Constructor de esta clase
         * @param session el ticket de sesion
         * @param form la vista a controlar
         */
        public FormStartAdministradorController(FormLoginDataSessionTicket session, FormStartAdministrador form)
        {
            this.sessionData = session;
            this.form = form;
            initPerfil();
        }

       /**
        * Inicializa los datos de sesion FALTA LA FOTO!!!!!!!!!!!!!!!!!!!!!
        */
        private void initPerfil()
        {
            form.log_name.Text = sessionData.name;
            form.log_id.Text = sessionData.TOKEN_SESSION;
            form.log_type.Text = sessionData.tipo;
            form.log_date.Text = sessionData.fecha;
            //la foto
        }

        /** 
        * Busca tratamientos en la DDBB
        */
        public void Buscar()
        {
        }

        /**
         * Boton Modificar cliente
         */
        public string getStateScreen(DataGridViewCellEventArgs ev, char action)
        {
            string ret = "";

            return ret;
        }
    }
}
