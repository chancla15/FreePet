using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using System.IO;

namespace WindowsFormsApplication1
{
    /**
     * La clase DataSessionTicket
     * Esta clase es la que encarga del mantenimiento de sesion tanto de su apertura como su cierre
     */
    public class FormLoginDataSessionTicket
    {
        /** Nombre del usuario */
        public String name;

        /** Token de inicio de sesion */
        public String TOKEN_SESSION;

        /** Fecha de inicio de sesion */
        public String fecha;

        /** Tipo de empleado */
        public String tipo;

        /** Foto */
        public FileStream photo;

        /** Constructor */
        public FormLoginDataSessionTicket(){
            Disconnect();
        }

        /** 
         * Limpia los datos de sesion y vuelve a la pantalla de login
         */
        public void Disconnect() 
        {
            name = "";
            TOKEN_SESSION = "";
            tipo = "";
            new FormLogin();
        }

        /**
         * Devuelve true si es posible el logueo
         * @param User el DNI del usuario
         * @param Pass su contraseña
         * @return true/false
         */
        public Boolean Login(String User, String Pass)
        {
            Boolean ret = false;
            UsuarioCEN usuarioCEN = new UsuarioCEN();
            EmpleadoCEN empleadoCEN = new EmpleadoCEN();
            VeterinarioCEN recepcionistaCEN = new VeterinarioCEN();
            UsuarioEN userEN;
            VeterinarioEN recepEN;

            if (User == "" || Pass == "")
                return ret;

            if (empleadoCEN.Login(User, Pass))
            {
                userEN = usuarioCEN.DameUsuarioPorDNI(User);
                recepEN = recepcionistaCEN.DameVetarinarioPorOID(User);

                name = userEN.Nombre;
                TOKEN_SESSION = userEN.DNI;
                fecha = DateTime.Now.ToString();

                if (recepEN == null)
                    tipo = "Recepcionista";
                else
                    tipo = "Veterinario";

                try
                {
                    photo = new System.IO.FileStream(Environment.CurrentDirectory + @"\" + userEN.DNI.ToString() + ".png", System.IO.FileMode.Open);
                }
                catch (Exception ex)
                {
                    photo = new System.IO.FileStream(Environment.CurrentDirectory + @"\sinFoto.png", System.IO.FileMode.Open);
                }
                ret = true;
            }
            return ret;
        }
    }
}
