
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string DNI);

string New_ (UsuarioEN usuario);

void Modify (UsuarioEN usuario);


void Destroy (string DNI);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.UsuarioEN> BuscarPorNombre (string arg0);


System.Collections.Generic.IList<UsuarioEN> DameTodosLosUsuarios (int first, int size);


UsuarioEN DameUsuarioPorDNI (string DNI);
}
}
