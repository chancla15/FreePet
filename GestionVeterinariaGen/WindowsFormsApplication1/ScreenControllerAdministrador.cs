using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    /**
     * Esto controlaria el cambio de pantallas de la barra de superior del menu 
     * 
     * USUARIO: 
     *      RECEPCIONISTA
     *
     * PANTALLAS:
     *      FORM_RECEPCIONISTA_ADMINISTRADOR_INICIO
     *      FORM_RECEPCIONISTA_CLIENTE
     *      FORM_RECEPCIONISTA_MASCOTA
     *      FORM_RECEPCIONISTA_CONSULTA
     *      FORM_RECEPCIONISTA_FACTURA
     */
    public class ScreenControllerAdministrador : ScreenController
    {
        #region Variables

        /** EL formulario de inicio */
        public FormRecepcionistaAdministradorInicio f_inicio = null;

        /** El formulario de cliente */
        public FormAdministradorEmpleado f_empleado = null;

        /** El formulario de mascota */
        public FormAdministradorTratamiento f_tratamiento = null;

        
        #endregion

        #region Constructor
        /**
         * Crea todos los formularios que usara el recepcionista
         * @param ticket el ticket de sesion
         */
        public ScreenControllerAdministrador(FormLoginDataSessionTicket ticket):base(ticket)
        {
            f_inicio = new FormRecepcionistaAdministradorInicio(this);
            //f_empleado = new FormAdministradorEmpleado(this);
            //f_tratamiento = new FormAdministradorTratamiento(this);
            LaunchStartScreen();
        }
        #endregion

        #region LanzadorDePantallas


        
        /**
         * Cuando lanza la pantalla principal
         */
        override public bool LaunchStartScreen()
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

        /**
         * Cuando lanza la pantalla empleados
         */
        override public bool LaunchEmpleadoScreen(Utils.State state, EmpleadoEN empleado)
        {
            bool ret = false;

            if (FormActual != f_empleado.ID)
            {
                ret = true;
                FormActual = f_empleado.ID;
                //f_empleado.ActivateForm();
                //f_empleado.changeState(state, empleado);
            }
            return ret;
        }

        /**
         * Cuando lanza la pantalla tratamiento
         */
        override public bool LaunchTratamientoScreen(Utils.State state,TratamientoEN tratamiento)
        {
            bool ret = false;

            if (FormActual != f_tratamiento.ID)
            {
                ret = true;
                FormActual = f_tratamiento.ID;
                //f_tratamiento.ActivateForm();
               // f_tratamiento.changeState(state,tratamiento);
            }
            return ret;
        }

        override public bool LaunchClienteScreen(Utils.State s, ClienteEN c)
        {
            throw new NotImplementedException();
        }

        override public bool LaunchMascotaScreen(Utils.State s, ClienteEN c, MascotaEN m)
        {
            throw new NotImplementedException();
        }

        override public bool LaunchFacturaScreen(Utils.State s, string f)
        {
            throw new NotImplementedException();
        }

        public override bool LaunchConsultaScreen(Utils.State s, ConsultaEN c)
        {
            throw new NotImplementedException();
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
            f_empleado.Hide();
            f_tratamiento.Hide();

        }

        #endregion

    }
}
