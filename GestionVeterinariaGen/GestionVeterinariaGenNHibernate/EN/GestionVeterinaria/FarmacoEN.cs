
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class FarmacoEN                  :                           GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN


{
/**
 *
 */

private string cantidad;

/**
 *
 */

private GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum frecuencia;





public virtual string Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}


public virtual GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum Frecuencia {
        get { return frecuencia; } set { frecuencia = value;  }
}





public FarmacoEN() : base ()
{
}



public FarmacoEN(string nombre, string cantidad, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum frecuencia, string fecha, string duracion, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, float precio)
{
        this.init (nombre, cantidad, frecuencia, fecha, duracion, consulta, precio);
}


public FarmacoEN(FarmacoEN farmaco)
{
        this.init (farmaco.Nombre, farmaco.Cantidad, farmaco.Frecuencia, farmaco.Fecha, farmaco.Duracion, farmaco.Consulta, farmaco.Precio);
}

private void init (string nombre, string cantidad, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum frecuencia, string fecha, string duracion, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, float precio)
{
        this.Nombre = nombre;


        this.Cantidad = cantidad;

        this.Frecuencia = frecuencia;

        this.Fecha = fecha;

        this.Duracion = duracion;

        this.Consulta = consulta;

        this.Precio = precio;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FarmacoEN t = obj as FarmacoEN;
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
