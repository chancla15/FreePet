
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface ITratamientoCAD
{
TratamientoEN ReadOIDDefault (string nombre);

string New_ (TratamientoEN tratamiento);

void Modify (TratamientoEN tratamiento);


void Destroy (string nombre);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> DameTodosLosTratamientos ();


TratamientoEN DameTratamientoPorOID (string nombre);
}
}
