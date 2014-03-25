
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class OrtopediaEN                :                           GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN


{
/**
 *
 */

private string talla;

/**
 *
 */

private int longitud;





public virtual string Talla {
        get { return talla; } set { talla = value;  }
}


public virtual int Longitud {
        get { return longitud; } set { longitud = value;  }
}





public OrtopediaEN() : base ()
{
}



public OrtopediaEN(string nombre, string talla, int longitud, Nullable<DateTime> fechaInicio, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, float precio, Nullable<DateTime> fechaFin)
{
        this.init (nombre, talla, longitud, fechaInicio, consulta, precio, fechaFin);
}


public OrtopediaEN(OrtopediaEN ortopedia)
{
        this.init (ortopedia.Nombre, ortopedia.Talla, ortopedia.Longitud, ortopedia.FechaInicio, ortopedia.Consulta, ortopedia.Precio, ortopedia.FechaFin);
}

private void init (string nombre, string talla, int longitud, Nullable<DateTime> fechaInicio, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, float precio, Nullable<DateTime> fechaFin)
{
        this.Nombre = nombre;


        this.Talla = talla;

        this.Longitud = longitud;

        this.FechaInicio = fechaInicio;

        this.Consulta = consulta;

        this.Precio = precio;

        this.FechaFin = fechaFin;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        OrtopediaEN t = obj as OrtopediaEN;
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
