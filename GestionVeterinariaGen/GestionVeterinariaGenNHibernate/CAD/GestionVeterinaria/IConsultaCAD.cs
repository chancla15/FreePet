
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


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> BuscarConsultaPorFecha (Nullable<DateTime> fecha);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> DameVeterinariosPorConsultaFecha (Nullable<DateTime> fecha, TimeSpan arg1);
}
}
