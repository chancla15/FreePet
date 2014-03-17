
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class HistorialClinicoEN
{
/**
 *
 */

private string numero;

/**
 *
 */

private GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN mascota;





public virtual string Numero {
        get { return numero; } set { numero = value;  }
}


public virtual GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN Mascota {
        get { return mascota; } set { mascota = value;  }
}





public HistorialClinicoEN()
{
}



public HistorialClinicoEN(string numero, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN mascota)
{
        this.init (numero, mascota);
}


public HistorialClinicoEN(HistorialClinicoEN historialClinico)
{
        this.init (historialClinico.Numero, historialClinico.Mascota);
}

private void init (string numero, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN mascota)
{
        this.Numero = numero;


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
