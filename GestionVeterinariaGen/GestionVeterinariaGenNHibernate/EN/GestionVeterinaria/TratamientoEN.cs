
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class TratamientoEN
{
/**
 *
 */

private string nombre;

/**
 *
 */

private string fecha;

/**
 *
 */

private string duracion;

/**
 *
 */

private System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta;

/**
 *
 */

private float precio;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual string Duracion {
        get { return duracion; } set { duracion = value;  }
}


public virtual System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> Consulta {
        get { return consulta; } set { consulta = value;  }
}


public virtual float Precio {
        get { return precio; } set { precio = value;  }
}





public TratamientoEN()
{
        consulta = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN>();
}



public TratamientoEN(string nombre, string fecha, string duracion, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, float precio)
{
        this.init (nombre, fecha, duracion, consulta, precio);
}


public TratamientoEN(TratamientoEN tratamiento)
{
        this.init (tratamiento.Nombre, tratamiento.Fecha, tratamiento.Duracion, tratamiento.Consulta, tratamiento.Precio);
}

private void init (string nombre, string fecha, string duracion, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, float precio)
{
        this.Nombre = nombre;


        this.Fecha = fecha;

        this.Duracion = duracion;

        this.Consulta = consulta;

        this.Precio = precio;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TratamientoEN t = obj as TratamientoEN;
        if (t == null)
                return false;
        if (Nombre.Equals (t.Nombre))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nombre.GetHashCode ();
        return hash;
}
}
}
