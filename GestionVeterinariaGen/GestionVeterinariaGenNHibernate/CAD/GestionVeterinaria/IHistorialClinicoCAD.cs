
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IHistorialClinicoCAD
{
HistorialClinicoEN ReadOIDDefault (string numero);

HistorialClinicoEN ConsultarHistorialPorOID (string numero);


string New_ (HistorialClinicoEN historialClinico);

void Modify (HistorialClinicoEN historialClinico);


void Destroy (string numero);
}
}
