
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
public System.Collections.Generic.IList<VeterinarioEN> DameTodosLosVeterinarios (int first, int size)
{
        /*PROTECTED REGION ID(GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria_Veterinario_dameTodosLosVeterinarios_customized) START*/

        System.Collections.Generic.IList<VeterinarioEN> list = null;

        list = _IVeterinarioCAD.DameTodosLosVeterinarios (first, size);
        return list;
        /*PROTECTED REGION END*/
}
}
}
