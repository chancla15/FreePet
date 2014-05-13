using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormTratamientoAdministradorController
     * Se encarga de la gestion de la vista de tratamientos del administrador
     * de esta vista se podran añadir, modificar y eliminar
     */
    class FormAdministradorTratamientoController
    {
        /** La vista */
        private FormAdministradorTratamiento form;

        /** El ticket de sesion */
        public FormLoginDataSessionTicket sessionData;

        /**
         * Constructor de clase
         * @param session el ticket de sesion
         * @param el form
         */
        public FormAdministradorTratamientoController(FormLoginDataSessionTicket session, FormAdministradorTratamiento form)
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
            form.log_id.Text = sessionData.TOKEN_SESSION;
            form.log_type.Text = sessionData.tipo;
            form.log_date.Text = sessionData.fecha;
            //la foto
        }

        /** 
         * Busca tratamientos en la DDBB
         */
        public void BuscarFactura()
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
