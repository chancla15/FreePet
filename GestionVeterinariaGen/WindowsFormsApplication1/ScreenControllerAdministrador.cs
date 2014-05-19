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
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public class ScreenControllerAdministrador : ScreenController
    {
        #region Variables

        public FormRecepcionistaAdministradorInicio f_inicio = null;
        public FormAdministradorEmpleado f_empleado = null;
        public FormAdministradorTratamiento f_tratamiento = null;
        public EmpleadoEN empleadoCompartido = null;

        #endregion

        #region Constructor

        public ScreenControllerAdministrador(FormLoginDataSessionTicket ticket)
            : base(ticket)
        {
            f_inicio = new FormRecepcionistaAdministradorInicio(this);
            f_empleado = new FormAdministradorEmpleado(this);
            f_tratamiento = new FormAdministradorTratamiento(this);
            LaunchStartScreen();
        }
       
        #endregion

        #region CargarEmpleadoCompartido

        public override void  CargarEmpleadoCompartido(EmpleadoEN e)
        {
            empleadoCompartido = e;
            if (empleadoCompartido != null)
                f_empleado.controller.cargarDatosEmpleado(empleadoCompartido);
            else
                f_empleado.controller.ClearForm();
        }

        #endregion

        #region LanzadorDePantallas

        override public bool LaunchStartScreen()
        {
            bool ret = false;

            if (FormActual != f_inicio.ID)
            {
                ret = true;
                FormActual = f_inicio.ID;
                f_inicio.controller.buscar();
                f_inicio.Show();
            }
            return ret;
        }

        override public bool LaunchEmpleadoScreen(Utils.State state)
        {
            bool ret = false;

            if (FormActual != f_empleado.ID)
            {
                ret = true;
                FormActual = f_empleado.ID;
                f_empleado.Show();
                f_empleado.changeState(state);
            }
            return ret;
        }

        override public bool LaunchTratamientoScreen(Utils.State state, TratamientoEN tratamiento)
        {
            bool ret = false;

            if (FormActual != f_tratamiento.ID)
            {
                ret = true;
                FormActual = f_tratamiento.ID;
                f_tratamiento.Show();
                f_tratamiento.changeState(state,tratamiento);
            }
            return ret;
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

        override public bool LaunchStartScreenVeterinario()
        {
            throw new NotImplementedException();
        }

        override public bool LaunchConsultaScreenVeterinario(MascotaEN mascota, ConsultaEN consulta)
        {
            throw new NotImplementedException();
        }

        override public void CargarClienteCompartido(ClienteEN c)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region SalirAplicacion

        override public void Disconnect()
        {
            CloseForms();
            sessionData.Disconnect();
        }

        override public void CloseForms()
        {
            FormActual = "";
            f_inicio.Hide();
            f_empleado.Hide();
            f_tratamiento.Hide();
        }

        #endregion

    }
}
