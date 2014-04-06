
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IMascotaCAD
{
MascotaEN ReadOIDDefault (string IdMascota);

string New_ (MascotaEN mascota);

void Modify (MascotaEN mascota);


void Destroy (string IdMascota);


MascotaEN BuscarMascotaPorOID (string IdMascota);


System.Collections.Generic.IList<MascotaEN> DameTodasLasMascotas (int first, int size);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> DameMascotaPorNombre (string busqueda);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> ContadorMascotas ();


GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN DameMascotaPorNombreyCliente (string nif, string nombre);
}
}
