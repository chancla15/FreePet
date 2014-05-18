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
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public abstract class ScreenController
    {
        public FormLoginDataSessionTicket sessionData = null;
        public string FormActual = "";

        public ScreenController(FormLoginDataSessionTicket ticket) {
            sessionData = ticket;
        }

        //RECEPCIONISTA
        public abstract bool LaunchStartScreen();   //Tambien sirve para veterinario
        public abstract bool LaunchClienteScreen();
        public abstract bool LaunchMascotaScreen(Utils.State s, MascotaEN m);
        public abstract bool LaunchConsultaScreen(Utils.State s, ConsultaEN c);
        public abstract bool LaunchFacturaScreen(Utils.State s);
        public abstract void CargarClienteCompartidoRecepcionista(ClienteEN c);


        //ADMINISTRADOR
        public abstract bool LaunchEmpleadoScreen(Utils.State s, EmpleadoEN e);
        public abstract bool LaunchTratamientoScreen(Utils.State s, TratamientoEN t);

        //VETERINARIO
        public abstract bool LaunchStartScreenVeterinario();
        public abstract bool LaunchConsultaScreenVeterinario(MascotaEN m, ConsultaEN c);

        //DESCONECTAR
        public abstract void Disconnect();
        public abstract void CloseForms();
    }
}
