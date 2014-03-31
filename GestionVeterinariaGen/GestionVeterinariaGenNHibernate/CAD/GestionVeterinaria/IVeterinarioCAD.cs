
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IVeterinarioCAD
{
VeterinarioEN ReadOIDDefault (string DNI);

string New_ (VeterinarioEN veterinario);

void Modify (VeterinarioEN veterinario);


void Destroy (string DNI);


System.Collections.Generic.IList<VeterinarioEN> DameTodosLosVeterinarios (int first, int size);


VeterinarioEN DameVetarinarioPorOID (string DNI);
}
}
