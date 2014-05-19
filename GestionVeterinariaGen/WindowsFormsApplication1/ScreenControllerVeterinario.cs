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
    public class ScreenControllerVeterinario : ScreenController
    {
        #region Variables

        public FormVeterinarioInicio f_inicio = null;
        public FormVeterinarioConsulta f_consulta = null;

        #endregion

        #region Constructor
      
        public ScreenControllerVeterinario(FormLoginDataSessionTicket ticket):base(ticket)
        {
            f_inicio = new FormVeterinarioInicio(this);
            f_inicio.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            f_consulta = new FormVeterinarioConsulta(this);
            LaunchStartScreenVeterinario();
        }
        
        #endregion

        #region LanzadorDePantallas

        override public bool LaunchStartScreenVeterinario()
        {
            bool ret = false;

            if (FormActual != f_inicio.ID)
            {
                ret = true;
                FormActual = f_inicio.ID;
                f_inicio.Show();
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
                 f_consulta.Show();
                 f_consulta.changeState(mascota, consulta);
             }
            return ret;
        }

        public override void CargarEmpleadoCompartido(EmpleadoEN e)
        {
            throw new NotImplementedException();
        }

        override public bool LaunchEmpleadoScreen(Utils.State s)
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

        override public void CargarClienteCompartido(ClienteEN c)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Desconectar

        override public void Disconnect()
        {
            CloseForms();
            sessionData.Disconnect();
        }

        override public void CloseForms()
        {
            FormActual = "";
            f_inicio.DesactivateForm();
            f_consulta.DesactivateForm();
        }

        #endregion
    }
}
