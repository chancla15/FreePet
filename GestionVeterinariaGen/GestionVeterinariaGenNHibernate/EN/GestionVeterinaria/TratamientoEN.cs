
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

private float precio;

/**
 *
 */

private string descripcion;

/**
 *
 */

private int stock;

/**
 *
 */

private GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum dosis_diaria;

/**
 *
 */

private System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual float Precio {
        get { return precio; } set { precio = value;  }
}


public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual int Stock {
        get { return stock; } set { stock = value;  }
}


public virtual GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum Dosis_diaria {
        get { return dosis_diaria; } set { dosis_diaria = value;  }
}


public virtual System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> Consulta {
        get { return consulta; } set { consulta = value;  }
}





public TratamientoEN()
{
        consulta = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN>();
}



public TratamientoEN(string nombre, float precio, string descripcion, int stock, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum dosis_diaria, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta)
{
        this.init (nombre, precio, descripcion, stock, dosis_diaria, consulta);
}


public TratamientoEN(TratamientoEN tratamiento)
{
        this.init (tratamiento.Nombre, tratamiento.Precio, tratamiento.Descripcion, tratamiento.Stock, tratamiento.Dosis_diaria, tratamiento.Consulta);
}

private void init (string nombre, float precio, string descripcion, int stock, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum dosis_diaria, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta)
{
        this.Nombre = nombre;


        this.Precio = precio;

        this.Descripcion = descripcion;

        this.Stock = stock;

        this.Dosis_diaria = dosis_diaria;

        this.Consulta = consulta;
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
