
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

/**
 *
 */

private Nullable<DateTime> fechaCaducidad;





public virtual string Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}


public virtual GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum Frecuencia {
        get { return frecuencia; } set { frecuencia = value;  }
}


public virtual Nullable<DateTime> FechaCaducidad {
        get { return fechaCaducidad; } set { fechaCaducidad = value;  }
}





public FarmacoEN() : base ()
{
}



public FarmacoEN(string nombre, string cantidad, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum frecuencia, Nullable<DateTime> fechaCaducidad, Nullable<DateTime> fechaInicio, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, float precio, Nullable<DateTime> fechaFin)
{
        this.init (nombre, cantidad, frecuencia, fechaCaducidad, fechaInicio, consulta, precio, fechaFin);
}


public FarmacoEN(FarmacoEN farmaco)
{
        this.init (farmaco.Nombre, farmaco.Cantidad, farmaco.Frecuencia, farmaco.FechaCaducidad, farmaco.FechaInicio, farmaco.Consulta, farmaco.Precio, farmaco.FechaFin);
}

private void init (string nombre, string cantidad, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum frecuencia, Nullable<DateTime> fechaCaducidad, Nullable<DateTime> fechaInicio, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, float precio, Nullable<DateTime> fechaFin)
{
        this.Nombre = nombre;


        this.Cantidad = cantidad;

        this.Frecuencia = frecuencia;

        this.FechaCaducidad = fechaCaducidad;

        this.FechaInicio = fechaInicio;

        this.Consulta = consulta;

        this.Precio = precio;

        this.FechaFin = fechaFin;
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
