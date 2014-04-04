
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class ConsultaEN
{
/**
 *
 */

private string idConsulta;

/**
 *
 */

private Nullable<DateTime> fecha;

/**
 *
 */

private TimeSpan hora;

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

private System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> tratamiento;

/**
 *
 */

private string lugar;

/**
 *
 */

private GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN factura;





public virtual string IdConsulta {
        get { return idConsulta; } set { idConsulta = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual TimeSpan Hora {
        get { return hora; } set { hora = value;  }
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


public virtual System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> Tratamiento {
        get { return tratamiento; } set { tratamiento = value;  }
}


public virtual string Lugar {
        get { return lugar; } set { lugar = value;  }
}


public virtual GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN Factura {
        get { return factura; } set { factura = value;  }
}





public ConsultaEN()
{
        tratamiento = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN>();
}



public ConsultaEN(string idConsulta, Nullable<DateTime> fecha, TimeSpan hora, string motivoConsulta, string diagnostico, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN mascota, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN veterinario, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> tratamiento, string lugar, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN factura)
{
        this.init (idConsulta, fecha, hora, motivoConsulta, diagnostico, mascota, veterinario, tratamiento, lugar, factura);
}


public ConsultaEN(ConsultaEN consulta)
{
        this.init (consulta.IdConsulta, consulta.Fecha, consulta.Hora, consulta.MotivoConsulta, consulta.Diagnostico, consulta.Mascota, consulta.Veterinario, consulta.Tratamiento, consulta.Lugar, consulta.Factura);
}

private void init (string idConsulta, Nullable<DateTime> fecha, TimeSpan hora, string motivoConsulta, string diagnostico, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN mascota, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN veterinario, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> tratamiento, string lugar, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN factura)
{
        this.IdConsulta = IdConsulta;


        this.Fecha = fecha;

        this.Hora = hora;

        this.MotivoConsulta = motivoConsulta;

        this.Diagnostico = diagnostico;

        this.Mascota = mascota;

        this.Veterinario = veterinario;

        this.Tratamiento = tratamiento;

        this.Lugar = lugar;

        this.Factura = factura;
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