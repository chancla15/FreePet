
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IConsultaCAD
{
ConsultaEN ReadOIDDefault (string IdConsulta);

string New_ (ConsultaEN consulta);

void Modify (ConsultaEN consulta);


void Destroy (string IdConsulta);


ConsultaEN DameConsultaPorOID (string IdConsulta);


System.Collections.Generic.IList<ConsultaEN> DameTodasLasConsultas (int first, int size);
}
}
