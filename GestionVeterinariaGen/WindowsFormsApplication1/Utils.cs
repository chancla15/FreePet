using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    /**
     * Esta clase tendra utiladades que utilzaran todas las pantallas de la aplicacion
     * asi minimo, tambien que tiene los menus asociados a cada tipo de usuario
     * ESTO ULTIMO FAAL POR IMPLEMNTAR
     */
    public static class Utils
    {
        /** Estados de cada una de las pantallas de la aplicacion
         *  ya que se pueden lanzar en modo añadir un nuevo entidad
         *  o modficiar o borrar algunas entidades ya guardadas
         *  con anterioridad
         */
        public enum State {
            NEW, MODIFY, DESTROY, NEW_CONSULTAS_MASCOTA, NONE
        }

        /** Cliente para acceder a la DDBB */
        public static ClienteCAD _IClienteCAD = new ClienteCAD();

        /** Mascota para acceder a la DDBB */
        public static MascotaCAD _IMascotaCAD = new MascotaCAD();

        /** Veterinario para acceder a la DDBB */
        public static VeterinarioCAD _IVeterinarioCAD = new VeterinarioCAD();

        /** Consulta para acceder a la DDBB */
        public static ConsultaCAD _IConsultaCAD = new ConsultaCAD();

        /** Factura para acceder a la DDBB */
        public static FacturaCAD _IFacturaCAD = new FacturaCAD();

        /** Empleado para acceder a la DDBB */
        public static EmpleadoCAD _IEmpleadoCAD = new EmpleadoCAD();

        /** Recepcionista para acceder a la DDBB */
        public static RecepcionistaCAD _IRecepcionistaCAD = new RecepcionistaCAD();

        /** Administrador para acceder a la DDBB */
        public static AdministradorCAD _IAdministradorCAD = new AdministradorCAD();

        /** Tratamiento para acceder a la DDBB */
        public static TratamientoCAD _ITratamientoCAD = new TratamientoCAD();

        /** CEN de cliente */
        public static ClienteCEN _ClienteCEN = new ClienteCEN(_IClienteCAD);

        /** CEN de mascota */
        public static MascotaCEN _MascotaCEN = new MascotaCEN(_IMascotaCAD);

        /** CEN de veterinario */
        public static VeterinarioCEN _VeterinarioCEN = new VeterinarioCEN(_IVeterinarioCAD);

        /** CEN de consulta */
        public static ConsultaCEN _ConsultaCEN = new ConsultaCEN(_IConsultaCAD);

        /** CEN de factura */
        public static FacturaCEN _FacturaCEN = new FacturaCEN(_IFacturaCAD);

        /** CEN de empleado */
        public static EmpleadoCEN _EmpleadoCEN = new EmpleadoCEN(_IEmpleadoCAD);

        /** CEN de recepcionista */
        public static RecepcionistaCEN _RecepcionistaCEN = new RecepcionistaCEN(_IRecepcionistaCAD);

        /** CEN de administrador */
        public static AdministradorCEN _AdministradorCEN = new AdministradorCEN(_IAdministradorCAD);

        /** CEN de tratamiento */
        public static TratamientoCEN _TratamientoCEN = new TratamientoCEN(_ITratamientoCAD);
    }
}
