
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

private Nullable<DateTime> fecha;

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





public virtual int IdConsulta {
        get { return idConsulta; } set { idConsulta = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
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





public ConsultaEN()
{
        tratamiento = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN>();
}



public ConsultaEN(int idConsulta, Nullable<DateTime> fecha, string motivoConsulta, string diagnostico, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN mascota, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN veterinario, string lugar, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN factura, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> tratamiento)
{
        this.init (idConsulta, fecha, motivoConsulta, diagnostico, mascota, veterinario, lugar, factura, tratamiento);
}


public ConsultaEN(ConsultaEN consulta)
{
        this.init (consulta.IdConsulta, consulta.Fecha, consulta.MotivoConsulta, consulta.Diagnostico, consulta.Mascota, consulta.Veterinario, consulta.Lugar, consulta.Factura, consulta.Tratamiento);
}

private void init (int idConsulta, Nullable<DateTime> fecha, string motivoConsulta, string diagnostico, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN mascota, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN veterinario, string lugar, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN factura, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> tratamiento)
{
        this.IdConsulta = IdConsulta;


        this.Fecha = fecha;

        this.MotivoConsulta = motivoConsulta;

        this.Diagnostico = diagnostico;

        this.Mascota = mascota;

        this.Veterinario = veterinario;

        this.Lugar = lugar;

        this.Factura = factura;

        this.Tratamiento = tratamiento;
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
