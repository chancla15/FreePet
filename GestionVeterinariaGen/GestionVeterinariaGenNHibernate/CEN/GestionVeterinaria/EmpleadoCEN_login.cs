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
public bool Login (String p_oid, String pass)
{

        EmpleadoEN en = null;
        bool login = false;
        if (p_oid != null && pass != null){

            en = _IEmpleadoCAD.DameEmpleadoPorOID(p_oid);

            if (en.Password == pass)
                login = true;
        }

        return login;
}
}
}
