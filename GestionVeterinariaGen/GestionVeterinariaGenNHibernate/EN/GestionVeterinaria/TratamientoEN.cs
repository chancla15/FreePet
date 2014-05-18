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
