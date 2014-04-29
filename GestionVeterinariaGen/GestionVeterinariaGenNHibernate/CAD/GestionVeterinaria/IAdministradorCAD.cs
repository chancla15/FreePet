
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (string DNI);

string New_ (AdministradorEN administrador);

void Modify (AdministradorEN administrador);


void Destroy (string DNI);


GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.AdministradorEN IsAdmin (string nif, string pass);
}
}
