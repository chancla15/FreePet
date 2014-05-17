﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class ScreenControllerRecepcionista : ScreenController
    {
        #region Variables

        public FormRecepcionistaAdministradorInicio f_inicio = null;
        public FormRecepcionistaCliente f_cliente = null;
        public FormRecepcionistaMascota f_mascota = null;
        public FormRecepcionistaConsulta f_consulta = null;
        public FormRecepcionistaFactura f_factura = null;
        public ClienteEN clienteCompartido = null;

        #endregion

        #region Constructor

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

        #region CargaClienteCompartidoEnPantallas

        override public void CargarClienteCompartidoRecepcionista(ClienteEN cliente)
        {
            clienteCompartido = cliente;

            if (clienteCompartido != null)
            {
                f_cliente.controller.cargarDatosCliente(clienteCompartido);
                f_cliente.changeState(Utils.State.MODIFY);

                f_mascota.controller.cargarDatosCliente(clienteCompartido);
                f_mascota.changeState(Utils.State.NEW, null);

                f_consulta.controller.cargarDatosCliente(clienteCompartido);
                f_consulta.changeState(Utils.State.NEW, null);

                f_factura.controller.cargarDatosCliente(clienteCompartido);
                f_factura.changeState(Utils.State.MODIFY);
            }
            else
            {
                f_cliente.controller.ClearForm();
                f_mascota.controller.ClearForm();
                f_consulta.controller.ClearForm();
                f_factura.controller.ClearForm();
            }
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
                f_inicio.ActivateForm();
            }        
            return ret;
        }

        override public bool LaunchClienteScreen()
        {
            bool ret = false;

            if (FormActual != f_cliente.ID)
            {
                ret = true;
                FormActual = f_cliente.ID;
                f_cliente.ActivateForm();
            }
            return ret;
        }

        override public bool LaunchMascotaScreen(Utils.State st, MascotaEN mascota)
        {
            bool ret = false;

            if (FormActual != f_mascota.ID)
            {
                ret = true;
                FormActual = f_mascota.ID;
                f_mascota.ActivateForm();
                f_mascota.changeState(st, mascota);
            }
            return ret;
        }

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

        override public bool LaunchFacturaScreen(Utils.State state)
        {
            bool ret = false;

            if (FormActual != f_factura.ID)
            {
                ret = true;
                FormActual = f_factura.ID;
                f_factura.ActivateForm();
                f_factura.changeState(state);
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

        override public bool LaunchConsultaScreenVeterinario(MascotaEN mascota)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region SalirAplicacion

        public void Disconnect()
        {
            CloseForms();
            sessionData.Disconnect();
        }

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
