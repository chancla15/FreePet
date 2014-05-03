
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


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> BuscarVetPorNombre (string busqueda);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> BuscarVetPorApellidos (string busqueda);


int DameNumeroTotalVeterinarios ();


GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN BuscarPorNombreYApellidos (string name, string surname);
}
}
