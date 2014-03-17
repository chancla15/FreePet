
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


System.Collections.Generic.IList<EmpleadoEN> DameTodosLosEmpleados (int first, int size);
}
}
