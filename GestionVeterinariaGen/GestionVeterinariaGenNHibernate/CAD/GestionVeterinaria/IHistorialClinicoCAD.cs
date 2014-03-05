
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IHistorialClinicoCAD
{
HistorialClinicoEN ReadOIDDefault (int numero);

HistorialClinicoEN ConsultarHistorialPorOID (int numero);


int New_ (HistorialClinicoEN historialClinico);

void Modify (HistorialClinicoEN historialClinico);


void Destroy (int numero);
}
}
