using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormEmpleadoAdministradorController
     * Se encarga de controlar la pantalla de add/mod/del empleado de administrador
     */
    class FormEmpleadoAdministradorController
    {
         /** La vista */
        private FormEmpleadoAdministrador form;

        /** EL ticket de sesion */
        public FormLoginDataSessionTicket sessionData;

        /**
         * Constructor de esta clase
         * @param session el ticket de sesion
         * @param form la vista a controlar
         */
        public FormEmpleadoAdministradorController(FormLoginDataSessionTicket session, FormEmpleadoAdministrador form)
        {
            this.sessionData = session;
            this.form = form;
        }
    }
}
