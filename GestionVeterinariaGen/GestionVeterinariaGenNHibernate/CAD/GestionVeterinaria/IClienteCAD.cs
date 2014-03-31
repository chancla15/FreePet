
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (string DNI);

string New_ (ClienteEN cliente);

void Modify (ClienteEN cliente);


void Destroy (string DNI);


ClienteEN DameClientePorOID (string DNI);


void AnyadirMascota (string p_Cliente_OID, System.Collections.Generic.IList<int> p_mascota_OIDs);

void QuitarMascota (string p_Cliente_OID, System.Collections.Generic.IList<int> p_mascota_OIDs);
}
}
