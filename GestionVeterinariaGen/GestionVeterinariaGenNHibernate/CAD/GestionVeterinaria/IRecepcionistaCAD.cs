
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IRecepcionistaCAD
{
RecepcionistaEN ReadOIDDefault (string DNI);

string New_ (RecepcionistaEN recepcionista);

void Modify (RecepcionistaEN recepcionista);


void Destroy (string DNI);


System.Collections.Generic.IList<RecepcionistaEN> DameTodos (int first, int size);
}
}
