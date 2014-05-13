using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public abstract class ScreenController
    {
        /** El ticket de sesion */
        public FormLoginDataSessionTicket sessionData = null;

        /** El formulario donde se encuentra actualmente */
        public string FormActual = "";

        public ScreenController(FormLoginDataSessionTicket ticket)
        {
            sessionData = ticket;
        }


        //RECEPCIONISTA
        public abstract bool LaunchStartScreen();   //Tambien sirve para veterinario
        public abstract bool LaunchClienteScreen(Utils.State s, ClienteEN c);
        public abstract bool LaunchMascotaScreen(Utils.State s, ClienteEN c, MascotaEN m);
        public abstract bool LaunchConsultaScreen(Utils.State s, ConsultaEN c);
        public abstract bool LaunchFacturaScreen(Utils.State s, string f);


        //ADMINISTRADOR
        public abstract bool LaunchEmpleadoScreen(Utils.State s, EmpleadoEN e);
        public abstract bool LaunchTratamientoScreen(Utils.State s, TratamientoEN t);
    
        //VETERINARIO
        public abstract bool LaunchStartScreenVeterinario();
        public abstract bool LaunchConsultaScreenVeterinario();
    }
}
