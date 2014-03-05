
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IConsultaCAD
{
ConsultaEN ReadOIDDefault (int IdConsulta);

int New_ (ConsultaEN consulta);

void Modify (ConsultaEN consulta);


void Destroy (int IdConsulta);


ConsultaEN DameConsultaPorOID (int IdConsulta);


System.Collections.Generic.IList<ConsultaEN> DameTodasLasConsultas (int first, int size);
}
}
