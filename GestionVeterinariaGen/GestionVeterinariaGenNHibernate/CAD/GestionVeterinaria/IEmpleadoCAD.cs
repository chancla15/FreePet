
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IEmpleadoCAD
{
EmpleadoEN ReadOIDDefault (string DNI);

string New_ (EmpleadoEN empleado);

void Modify (EmpleadoEN empleado);


void Destroy (string DNI);


EmpleadoEN DameEmpleadoPorOID (string DNI);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN> DameTodosLosEmpleados ();




System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN> DameEmpleadoPorNombre (string busqueda);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN> DameEmpleadoPorApellidos (string busqueda);
}
}
