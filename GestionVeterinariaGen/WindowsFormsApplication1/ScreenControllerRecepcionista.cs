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
    public class ScreenControllerRecepcionista : ScreenController
    {
        #region Variables

        /** EL formulario de inicio */
        public FormRecepcionistaAdministradorInicio f_inicio = null;

        /** El formulario de cliente */
        public FormRecepcionistaCliente f_cliente = null;

        /** El formulario de mascota */
        public FormRecepcionistaMascota f_mascota = null;

        /** EL formulario de consulta */
        public FormRecepcionistaConsulta f_consulta = null;

        /** El formulario de factura */
        public FormRecepcionistaFactura f_factura = null;
        
        #endregion

        #region Constructor
        /**
         * Crea todos los formularios que usara el recepcionista
         * @param ticket el ticket de sesion
         */
        public ScreenControllerRecepcionista(FormLoginDataSessionTicket ticket):base(ticket)
        {
            f_inicio = new FormRecepcionistaAdministradorInicio(this);
            f_cliente = new FormRecepcionistaCliente(this);
            f_mascota = new FormRecepcionistaMascota(this);
            f_consulta = new FormRecepcionistaConsulta(this);
            f_factura = new FormRecepcionistaFactura(this);
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
         * Cuando lanza la pantalla clientes
         */
        override public bool LaunchClienteScreen(Utils.State state, ClienteEN cliente)
        {
            bool ret = false;

            if (FormActual != f_cliente.ID)
            {
                ret = true;
                FormActual = f_cliente.ID;
                f_cliente.ActivateForm();
                f_cliente.changeState(state, cliente);
            }
            return ret;
        }

        /**
         * Cuando lanza la pantalla mascota
         */
        override public bool LaunchMascotaScreen(Utils.State state, ClienteEN cliente, MascotaEN mascota)
        {
            bool ret = false;

            if (FormActual != f_mascota.ID)
            {
                ret = true;
                FormActual = f_mascota.ID;
                f_mascota.ActivateForm();
                f_mascota.changeState(state, cliente, mascota);
            }
            return ret;
        }

        /**
         * Cuando lanza la pantalla consulta
         */
        override public bool LaunchConsultaScreen(Utils.State state, ConsultaEN consulta)
        {
            bool ret = false;

            if (FormActual != f_consulta.ID)
            {
                ret = true;
                FormActual = f_consulta.ID;
                f_consulta.ActivateForm();
                f_consulta.changeState(state, consulta);
            }
            return ret;
        }

        /**
         * Cuando lanza la pantalla factura
         */
        override public bool LaunchFacturaScreen(Utils.State state, string cli)
        {
            bool ret = false;

            if (FormActual != f_factura.ID)
            {
                ret = true;
                FormActual = f_factura.ID;
                f_factura.ActivateForm();
                f_factura.changeState(state, cli);
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

        override public bool LaunchStartScreenVeterinario()
        {
            throw new NotImplementedException();
        }

        override public bool LaunchConsultaScreenVeterinario()
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
            f_cliente.Hide();
            f_mascota.Hide();
            f_consulta.Hide();
            f_factura.Hide();
        }

        #endregion

    }
}
