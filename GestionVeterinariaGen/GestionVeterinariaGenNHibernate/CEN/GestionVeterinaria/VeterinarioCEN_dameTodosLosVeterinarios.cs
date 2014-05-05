
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
public partial class VeterinarioCEN
{
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> DameTodosLosVeterinarios ()
{
        /*PROTECTED REGION ID(GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria_Veterinario_dameTodosLosVeterinarios_customized) START*/

        return _IVeterinarioCAD.DameTodosLosVeterinarios ();
        /*PROTECTED REGION END*/
}
}
}
