using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public class ScreenControllerVeterinario : ScreenController
    {
        #region Variables

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
        public ScreenControllerVeterinario(FormLoginDataSessionTicket ticket):base(ticket)
        {
            f_inicio = new FormVeterinarioInicio(this);
            f_inicio.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            f_consulta = new FormVeterinarioConsulta(this);
            LaunchStartScreenVeterinario();
        }
        #endregion

        #region LanzadorDePantallas

        /**
         * Cuando lanza la pantalla principal
         */
        override public bool LaunchStartScreenVeterinario()
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

        override public bool LaunchConsultaScreenVeterinario(MascotaEN mascota,ConsultaEN consulta)
        {
            bool ret = false;

             if (FormActual != f_consulta.ID)
             {
                 ret = true;
                 FormActual = f_consulta.ID;
                 f_consulta.ActivateForm();
                 f_consulta.changeState(mascota, consulta);
             }
            return ret;
        }

        override public bool LaunchEmpleadoScreen(Utils.State s, EmpleadoEN e)
        {
            throw new NotImplementedException();
        }

        override public bool LaunchTratamientoScreen(Utils.State s, TratamientoEN t)
        {
            throw new NotImplementedException();
        }

        override public bool LaunchStartScreen()
        {
            throw new NotImplementedException();
        }

        override public bool LaunchClienteScreen()
        {
            throw new NotImplementedException();
        }

        override public bool LaunchMascotaScreen(Utils.State s, MascotaEN m)
        {
            throw new NotImplementedException();
        }

        override public bool LaunchFacturaScreen(Utils.State s)
        {
            throw new NotImplementedException();
        }

        override public bool LaunchConsultaScreen(Utils.State s, ConsultaEN c)
        {
            throw new NotImplementedException();
        }

        override public void CargarClienteCompartidoRecepcionista(ClienteEN c)
        {
            throw new NotImplementedException();
        }


        #endregion


    }
}
