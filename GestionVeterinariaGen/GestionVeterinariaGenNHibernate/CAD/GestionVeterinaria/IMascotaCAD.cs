
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IMascotaCAD
{
MascotaEN ReadOIDDefault (int IdMascota);

int New_ (MascotaEN mascota);

void Modify (MascotaEN mascota);


void Destroy (int IdMascota);


MascotaEN BuscarMascotaPorOID (int IdMascota);


System.Collections.Generic.IList<MascotaEN> DameTodasLasMascotas (int first, int size);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> DameMascotaPorNombre (string busqueda);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> ContadorMascotas ();


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> DameMascotaPorCliente (string nif);
}
}
