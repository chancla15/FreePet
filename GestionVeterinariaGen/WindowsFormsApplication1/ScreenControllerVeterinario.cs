using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class ScreenControllerVeterinario
    {
        #region Variables

        /** El ticket de sesion */
        public FormLoginDataSessionTicket sessionData = null;

        /** El formulario donde se encuentra actualmente */
        public string FormActual = "";

        /** EL formulario de inicio */
        public FormVeterinarioInicio f_inicio = null;

        /** El formulario de cliente */
        public FormVeterinarioConsulta f_consulta = null;

        //Aquí el futuro formulario de ajustes del Veterinario

        #endregion

        #region Constructor
        /**
         * Crea todos los formularios que usara el recepcionista
         * @param ticket el ticket de sesion
         */
        public ScreenControllerVeterinario(FormLoginDataSessionTicket ticket)
        {
            sessionData = ticket;
            f_inicio = new FormVeterinarioInicio(this);
            f_consulta = new FormVeterinarioConsulta(this);
            LaunchStartScreen();
        }
        #endregion


        #region LanzadorDePantallas

        /**
         * Cuando lanza la pantalla principal
         */
        public bool LaunchStartScreen()
        {
            bool ret = false;

            if (FormActual != f_inicio.ID)
            {
                ret = true;
                FormActual = f_inicio.ID;
                f_inicio.ActivateForm();
            }
            return ret;
        }

       public bool LaunchConsultaScreen()
        {
            bool ret = false ;

            if (FormActual != f_consulta.ID)
            {
                ret = true;
                FormActual = f_consulta.ID;
                f_consulta.ActivateForm();
            }
            return ret;
        }

        #endregion

       #region SalirAplicacion

       /**
         * Cuando se desconecta de la aplicacion
         */
       public void Disconnect()
       {
           CloseForms();
           sessionData.Disconnect();
       }

       /**
        * Cuando cierra el programa  (LA X DE LA BARRA DE HERRAMIENTAS)
        * Cierra todos los formularios
        */
       public void CloseForms()
       {
           FormActual = "";
           f_inicio.Hide();
           f_consulta.Hide();
       }

       #endregion
    }
}
