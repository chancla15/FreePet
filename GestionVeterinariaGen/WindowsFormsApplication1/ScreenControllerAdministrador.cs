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

        #region LanzadorDePantallas

        override public bool LaunchStartScreen()
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

        override public bool LaunchEmpleadoScreen(Utils.State state, EmpleadoEN empleado)
        {
            bool ret = false;

            if (FormActual != f_empleado.ID)
            {
                ret = true;
                FormActual = f_empleado.ID;
                f_empleado.Show();
                f_empleado.changeState(state, empleado);
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

        override public void CargarClienteCompartidoRecepcionista(ClienteEN c)
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
