
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria
{
public partial class EmpleadoCEN
{
public bool Login (string p_oid, String pass)
{
        /*PROTECTED REGION ID(GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria_Empleado_login) ENABLED START*/

        // Write here your custom code...

        System.Console.WriteLine ("Login " + p_oid + " " + pass);
        try
        {
                EmpleadoEN en = _IEmpleadoCAD.ReadOIDDefault (p_oid);
                return(en.Password.Equals (pass));
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex);
                return false;
        }

        /*PROTECTED REGION END*/
}
}
}
