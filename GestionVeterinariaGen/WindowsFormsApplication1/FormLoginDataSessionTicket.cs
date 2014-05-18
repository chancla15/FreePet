/* 
    FreePet. OpenSource Software Veterinarian Management
    Copyright (C) 2014  Jesus Manresa Parres

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

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
    public class FormLoginDataSessionTicket
    {
        public String name;
        public String TOKEN_SESSION;
        public String fecha;
        public String tipo;
        public FileStream photo;

        public FormLoginDataSessionTicket(){
        }

        public void Disconnect() 
        {
            name = "";
            TOKEN_SESSION = "";
            tipo = "";
            fecha = "";
            photo = null;
            new FormLogin();
        }

        public Boolean Login(String User, String Pass)
        {
            Boolean log = false;

            EmpleadoEN empEN = null;
            RecepcionistaEN recpEN = null;
            AdministradorEN admin = null;

            if (User == "" || Pass == "")
                return log;

            empEN = Utils._IEmpleadoCAD.ReadOIDDefault(User);
            admin = Utils._IAdministradorCAD.ReadOIDDefault(User);

            if (empEN != null && Utils._EmpleadoCEN.Login(User, Pass))
            {
                log = true;
                name = empEN.Nombre;
                TOKEN_SESSION = empEN.DNI;
                fecha = DateTime.Now.ToString();

                recpEN = Utils._IRecepcionistaCAD.BuscarRecepPorOID(User);
                if (recpEN != null)
                {

                    tipo = "Recepcionista";
                }
                else
                {
                    if (admin == null)
                        tipo = "Veterinario";
                    else
                        tipo = "Administrador";
                }

                try
                {
                    photo = new System.IO.FileStream(Environment.CurrentDirectory + @"\" + empEN.DNI.ToString() + ".png", System.IO.FileMode.Open);

                }
                catch (Exception ex)
                {
                    photo = new System.IO.FileStream(Environment.CurrentDirectory + @"\sinFoto.png", System.IO.FileMode.Open);
                }
                finally
                {

                    photo.Close();
                }
            }
            return log;
        }
    }
}
