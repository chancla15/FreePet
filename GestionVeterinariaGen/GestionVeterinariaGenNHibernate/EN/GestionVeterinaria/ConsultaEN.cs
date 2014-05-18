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

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class ConsultaEN
{
/**
 *
 */

private int idConsulta;

/**
 *
 */

private string motivoConsulta;

/**
 *
 */

private string diagnostico;

/**
 *
 */

private GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN mascota;

/**
 *
 */

private GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN veterinario;

/**
 *
 */

private string lugar;

/**
 *
 */

private GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN factura;

/**
 *
 */

private System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> tratamiento;

/**
 *
 */

private Nullable<DateTime> fecha;





public virtual int IdConsulta {
        get { return idConsulta; } set { idConsulta = value;  }
}


public virtual string MotivoConsulta {
        get { return motivoConsulta; } set { motivoConsulta = value;  }
}


public virtual string Diagnostico {
        get { return diagnostico; } set { diagnostico = value;  }
}


public virtual GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN Mascota {
        get { return mascota; } set { mascota = value;  }
}


public virtual GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN Veterinario {
        get { return veterinario; } set { veterinario = value;  }
}


public virtual string Lugar {
        get { return lugar; } set { lugar = value;  }
}


public virtual GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN Factura {
        get { return factura; } set { factura = value;  }
}


public virtual System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> Tratamiento {
        get { return tratamiento; } set { tratamiento = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}





public ConsultaEN()
{
        tratamiento = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN>();
}



public ConsultaEN(int idConsulta, string motivoConsulta, string diagnostico, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN mascota, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN veterinario, string lugar, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN factura, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> tratamiento, Nullable<DateTime> fecha)
{
        this.init (idConsulta, motivoConsulta, diagnostico, mascota, veterinario, lugar, factura, tratamiento, fecha);
}


public ConsultaEN(ConsultaEN consulta)
{
        this.init (consulta.IdConsulta, consulta.MotivoConsulta, consulta.Diagnostico, consulta.Mascota, consulta.Veterinario, consulta.Lugar, consulta.Factura, consulta.Tratamiento, consulta.Fecha);
}

private void init (int idConsulta, string motivoConsulta, string diagnostico, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN mascota, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN veterinario, string lugar, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN factura, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> tratamiento, Nullable<DateTime> fecha)
{
        this.IdConsulta = IdConsulta;


        this.MotivoConsulta = motivoConsulta;

        this.Diagnostico = diagnostico;

        this.Mascota = mascota;

        this.Veterinario = veterinario;

        this.Lugar = lugar;

        this.Factura = factura;

        this.Tratamiento = tratamiento;

        this.Fecha = fecha;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ConsultaEN t = obj as ConsultaEN;
        if (t == null)
                return false;
        if (IdConsulta.Equals (t.IdConsulta))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdConsulta.GetHashCode ();
        return hash;
}
}
}
