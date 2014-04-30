using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using System.IO;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;

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
            Boolean log = false;

            UsuarioCAD _IUsuarioCAD = new UsuarioCAD();
            EmpleadoCAD _IEmpleadoCAD = new EmpleadoCAD();
            RecepcionistaCAD _IRecepcionistaCAD = new RecepcionistaCAD();
            AdministradorCAD _IAdministradorCAD = new AdministradorCAD();
            EmpleadoCEN empCEN = new EmpleadoCEN(_IEmpleadoCAD);

            EmpleadoEN empEN = null;
            RecepcionistaEN recpEN = null;

            UsuarioEN userEN = null;
   

            if (User == "" || Pass == "")
                return log;



            empEN = _IEmpleadoCAD.ReadOIDDefault(User);
            userEN = _IUsuarioCAD.ReadOIDDefault(User);

            if (empEN!=null && empCEN.Login(User, Pass))
            {
                log = true;
                name = empEN.Nombre;
                TOKEN_SESSION = empEN.DNI;
                fecha = DateTime.Now.ToString();

                recpEN = _IRecepcionistaCAD.BuscarRecepPorOID(User);
                if (recpEN != null)
                {

                    tipo = "Recepcionista";
                }
                else
                {
                    //Buscar si es adminsitrador, y sino lo es es veterinario
                    tipo = "Veterinario";
                }

                try
                {
                    photo = new System.IO.FileStream(Environment.CurrentDirectory + @"\" + userEN.DNI.ToString() + ".png", System.IO.FileMode.Open);
                }
                catch (Exception ex)
                {
                    photo = new System.IO.FileStream(Environment.CurrentDirectory + @"\sinFoto.png", System.IO.FileMode.Open);
                }
            }
            return log;
        }
    }
}
