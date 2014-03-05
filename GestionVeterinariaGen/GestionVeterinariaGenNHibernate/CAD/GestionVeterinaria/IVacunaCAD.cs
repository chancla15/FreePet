
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IVacunaCAD
{
VacunaEN ReadOIDDefault (string nombre);

string New_ (VacunaEN vacuna);

void Modify (VacunaEN vacuna);


void Destroy (string nombre);


System.Collections.Generic.IList<VacunaEN> DameTodasLasVacunas (int first, int size);
}
}
