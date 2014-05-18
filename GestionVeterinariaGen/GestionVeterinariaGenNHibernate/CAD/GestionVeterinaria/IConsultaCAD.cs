/* 
    FreePet. OpenSource Software Veterinarian Management
    Copyright (C) 2014  Jesus Manresa Parres

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
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


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> DameTodasLasConsultas ();


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> BuscarConsultaPorFecha (Nullable<DateTime> fecha);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> DameVeterinariosPorFechayHora (Nullable<DateTime> fecha);


GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN DameConsultaPorVeterinarioYFecha (string vet, Nullable<DateTime> fecha);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> DameConsultaPorAnimal (int mascota);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> DameConsultaPorFechaYHora (Nullable<DateTime> fecha);


void AnaydirTratamiento (int p_Consulta_OID, System.Collections.Generic.IList<string> p_tratamiento_OIDs);

void QuitarTratamiento (int p_Consulta_OID, System.Collections.Generic.IList<string> p_tratamiento_OIDs);
}
}
