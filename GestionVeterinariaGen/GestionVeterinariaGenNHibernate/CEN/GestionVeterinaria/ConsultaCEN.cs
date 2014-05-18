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
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria
{
public partial class ConsultaCEN
{
private IConsultaCAD _IConsultaCAD;

public ConsultaCEN()
{
        this._IConsultaCAD = new ConsultaCAD ();
}

public ConsultaCEN(IConsultaCAD _IConsultaCAD)
{
        this._IConsultaCAD = _IConsultaCAD;
}

public IConsultaCAD get_IConsultaCAD ()
{
        return this._IConsultaCAD;
}

public int New_ (string p_motivoConsulta, string p_diagnostico, int p_mascota, string p_veterinario, string p_lugar, Nullable<DateTime> p_fecha)
{
        ConsultaEN consultaEN = null;
        int oid;

        //Initialized ConsultaEN
        consultaEN = new ConsultaEN ();
        consultaEN.MotivoConsulta = p_motivoConsulta;

        consultaEN.Diagnostico = p_diagnostico;


        if (p_mascota != -1) {
                consultaEN.Mascota = new GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN ();
                consultaEN.Mascota.IdMascota = p_mascota;
        }


        if (p_veterinario != null) {
                consultaEN.Veterinario = new GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN ();
                consultaEN.Veterinario.DNI = p_veterinario;
        }

        consultaEN.Lugar = p_lugar;

        consultaEN.Fecha = p_fecha;

        //Call to ConsultaCAD

        oid = _IConsultaCAD.New_ (consultaEN);
        return oid;
}

public void Modify (int p_Consulta_OID, string p_motivoConsulta, string p_diagnostico, string p_lugar, Nullable<DateTime> p_fecha)
{
        ConsultaEN consultaEN = null;

        //Initialized ConsultaEN
        consultaEN = new ConsultaEN ();
        consultaEN.IdConsulta = p_Consulta_OID;
        consultaEN.MotivoConsulta = p_motivoConsulta;
        consultaEN.Diagnostico = p_diagnostico;
        consultaEN.Lugar = p_lugar;
        consultaEN.Fecha = p_fecha;
        //Call to ConsultaCAD

        _IConsultaCAD.Modify (consultaEN);
}

public void Destroy (int IdConsulta)
{
        _IConsultaCAD.Destroy (IdConsulta);
}

public ConsultaEN DameConsultaPorOID (int IdConsulta)
{
        ConsultaEN consultaEN = null;

        consultaEN = _IConsultaCAD.DameConsultaPorOID (IdConsulta);
        return consultaEN;
}

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> DameTodasLasConsultas ()
{
        return _IConsultaCAD.DameTodasLasConsultas ();
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> BuscarConsultaPorFecha (Nullable<DateTime> fecha)
{
        return _IConsultaCAD.BuscarConsultaPorFecha (fecha);
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> DameVeterinariosPorFechayHora (Nullable<DateTime> fecha)
{
        return _IConsultaCAD.DameVeterinariosPorFechayHora (fecha);
}
public GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN DameConsultaPorVeterinarioYFecha (string vet, Nullable<DateTime> fecha)
{
        return _IConsultaCAD.DameConsultaPorVeterinarioYFecha (vet, fecha);
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> DameConsultaPorAnimal (int mascota)
{
        return _IConsultaCAD.DameConsultaPorAnimal (mascota);
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> DameConsultaPorFechaYHora (Nullable<DateTime> fecha)
{
        return _IConsultaCAD.DameConsultaPorFechaYHora (fecha);
}
public void AnaydirTratamiento (int p_Consulta_OID, System.Collections.Generic.IList<string> p_tratamiento_OIDs)
{
        //Call to ConsultaCAD

        _IConsultaCAD.AnaydirTratamiento (p_Consulta_OID, p_tratamiento_OIDs);
}
public void QuitarTratamiento (int p_Consulta_OID, System.Collections.Generic.IList<string> p_tratamiento_OIDs)
{
        //Call to ConsultaCAD

        _IConsultaCAD.QuitarTratamiento (p_Consulta_OID, p_tratamiento_OIDs);
}
}
}
