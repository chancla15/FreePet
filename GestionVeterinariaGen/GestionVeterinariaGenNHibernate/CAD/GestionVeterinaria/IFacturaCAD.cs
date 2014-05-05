
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IFacturaCAD
{
FacturaEN ReadOIDDefault (string idFactura);

System.Collections.Generic.IList<FacturaEN> DameTodasLasFacturas (int first, int size);


string New_ (FacturaEN factura);

void Modify (FacturaEN factura);


void Destroy (string idFactura);


FacturaEN DameFacturaPorOID (string idFactura);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN> DameFacturaPorFecha (Nullable<DateTime> param);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN> DameImpagos ();
}
}
