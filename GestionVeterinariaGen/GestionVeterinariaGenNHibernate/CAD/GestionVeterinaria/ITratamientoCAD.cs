
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


System.Collections.Generic.IList<TratamientoEN> DameTodosLosTratamientos (int first, int size);


TratamientoEN DameTratamientoPorOID (string nombre);
}
}
