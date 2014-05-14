
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IFarmacoCAD
{
FarmacoEN ReadOIDDefault (string nombre);

string New_ (FarmacoEN farmaco);

void Modify (FarmacoEN farmaco);


void Destroy (string nombre);


System.Collections.Generic.IList<FarmacoEN> DameTodosLosFarmacos (int first, int size);


FarmacoEN DameFarmacoPorOID (string nombre);
}
}
