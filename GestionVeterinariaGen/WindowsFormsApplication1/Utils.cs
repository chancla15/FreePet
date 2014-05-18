using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public static class Utils
    {
        public enum State {
            NEW, MODIFY, DESTROY, NEW_CONSULTAS_MASCOTA, NONE
        }

        public static ClienteCAD _IClienteCAD = new ClienteCAD();
        public static MascotaCAD _IMascotaCAD = new MascotaCAD();
        public static VeterinarioCAD _IVeterinarioCAD = new VeterinarioCAD();
        public static ConsultaCAD _IConsultaCAD = new ConsultaCAD();
        public static FacturaCAD _IFacturaCAD = new FacturaCAD();
        public static EmpleadoCAD _IEmpleadoCAD = new EmpleadoCAD();
        public static RecepcionistaCAD _IRecepcionistaCAD = new RecepcionistaCAD();
        public static AdministradorCAD _IAdministradorCAD = new AdministradorCAD();
        public static TratamientoCAD _ITratamientoCAD = new TratamientoCAD();
        public static ClienteCEN _ClienteCEN = new ClienteCEN(_IClienteCAD);
        public static MascotaCEN _MascotaCEN = new MascotaCEN(_IMascotaCAD);
        public static VeterinarioCEN _VeterinarioCEN = new VeterinarioCEN(_IVeterinarioCAD);
        public static ConsultaCEN _ConsultaCEN = new ConsultaCEN(_IConsultaCAD);
        public static FacturaCEN _FacturaCEN = new FacturaCEN(_IFacturaCAD);
        public static EmpleadoCEN _EmpleadoCEN = new EmpleadoCEN(_IEmpleadoCAD);
        public static RecepcionistaCEN _RecepcionistaCEN = new RecepcionistaCEN(_IRecepcionistaCAD);
        public static AdministradorCEN _AdministradorCEN = new AdministradorCEN(_IAdministradorCAD);
        public static TratamientoCEN _TratamientoCEN = new TratamientoCEN(_ITratamientoCAD);
    }
}
