
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IFacturaCAD
{
FacturaEN ReadOIDDefault (int idFactura);

System.Collections.Generic.IList<FacturaEN> DameTodasLasFacturas (int first, int size);


int New_ (FacturaEN factura);

void Modify (FacturaEN factura);


void Destroy (int idFactura);


FacturaEN DameFacturaPorOID (int idFactura);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN> DameFacturaPorFecha (Nullable<DateTime> param);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN> DameImpagos ();
}
}
