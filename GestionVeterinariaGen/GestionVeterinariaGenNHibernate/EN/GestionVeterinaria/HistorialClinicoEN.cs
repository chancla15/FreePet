
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class HistorialClinicoEN
{
/**
 *
 */

private System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta;

/**
 *
 */

private int numero;

/**
 *
 */

private GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN mascota;





public virtual System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> Consulta {
        get { return consulta; } set { consulta = value;  }
}


public virtual int Numero {
        get { return numero; } set { numero = value;  }
}


public virtual GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN Mascota {
        get { return mascota; } set { mascota = value;  }
}





public HistorialClinicoEN()
{
        consulta = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN>();
}



public HistorialClinicoEN(int numero, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN mascota)
{
        this.init (numero, consulta, mascota);
}


public HistorialClinicoEN(HistorialClinicoEN historialClinico)
{
        this.init (historialClinico.Numero, historialClinico.Consulta, historialClinico.Mascota);
}

private void init (int numero, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN mascota)
{
        this.Numero = numero;


        this.Consulta = consulta;

        this.Mascota = mascota;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        HistorialClinicoEN t = obj as HistorialClinicoEN;
        if (t == null)
                return false;
        if (Numero.Equals (t.Numero))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Numero.GetHashCode ();
        return hash;
}
}
}
