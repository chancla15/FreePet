using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormPerfilRecepcionistaController
     * Esta sera la encargada de gestionar la vista de datos de clientes y empleados 
     * tanto para añadir/modificar/eliminar cliente, o para modificar datos opcionale
     * e irrelevantes del empleado
     */
    class FormPerfilRecepcionistaController
    {
        /** El formulario a controlar */
        FormPerfilRecepcionista form;

        /** El ticket de sesion */
        FormLoginDataSessionTicket sessionData;

        /** Los ditintos estados de lo que puede hacer el controlador
         * Esto solo sirve para guiarme para refactorizar 
         */
        public enum State {
            NONE, CLI_ADD, CLI_MOD, CLI_DEL, EMP
        }

        /**
         * El constructor
         * @param s el ticket de sesion
         * @param f el formulario a controlar
         */
        public FormPerfilRecepcionistaController(FormLoginDataSessionTicket s, FormPerfilRecepcionista f) {
            
            this.sessionData = s;
            this.form = f;
        }
    }
}
