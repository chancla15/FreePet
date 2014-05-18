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
public partial class MascotaEN
{
/**
 *
 */

private int idMascota;

/**
 *
 */

private string nombre;

/**
 *
 */

private string raza;

/**
 *
 */

private GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum sexo;

/**
 *
 */

private float peso;

/**
 *
 */

private string especie;

/**
 *
 */

private Nullable<DateTime> fNacimiento;

/**
 *
 */

private GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum tamanyo;

/**
 *
 */

private GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN cliente;

/**
 *
 */

private System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta;

/**
 *
 */

private string color;

/**
 *
 */

private bool microchip;





public virtual int IdMascota {
        get { return idMascota; } set { idMascota = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Raza {
        get { return raza; } set { raza = value;  }
}


public virtual GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum Sexo {
        get { return sexo; } set { sexo = value;  }
}


public virtual float Peso {
        get { return peso; } set { peso = value;  }
}


public virtual string Especie {
        get { return especie; } set { especie = value;  }
}


public virtual Nullable<DateTime> FNacimiento {
        get { return fNacimiento; } set { fNacimiento = value;  }
}


public virtual GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum Tamanyo {
        get { return tamanyo; } set { tamanyo = value;  }
}


public virtual GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}


public virtual System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> Consulta {
        get { return consulta; } set { consulta = value;  }
}


public virtual string Color {
        get { return color; } set { color = value;  }
}


public virtual bool Microchip {
        get { return microchip; } set { microchip = value;  }
}





public MascotaEN()
{
        consulta = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN>();
}



public MascotaEN(int idMascota, string nombre, string raza, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum sexo, float peso, string especie, Nullable<DateTime> fNacimiento, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum tamanyo, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN cliente, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, string color, bool microchip)
{
        this.init (idMascota, nombre, raza, sexo, peso, especie, fNacimiento, tamanyo, cliente, consulta, color, microchip);
}


public MascotaEN(MascotaEN mascota)
{
        this.init (mascota.IdMascota, mascota.Nombre, mascota.Raza, mascota.Sexo, mascota.Peso, mascota.Especie, mascota.FNacimiento, mascota.Tamanyo, mascota.Cliente, mascota.Consulta, mascota.Color, mascota.Microchip);
}

private void init (int idMascota, string nombre, string raza, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum sexo, float peso, string especie, Nullable<DateTime> fNacimiento, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum tamanyo, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN cliente, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, string color, bool microchip)
{
        this.IdMascota = IdMascota;


        this.Nombre = nombre;

        this.Raza = raza;

        this.Sexo = sexo;

        this.Peso = peso;

        this.Especie = especie;

        this.FNacimiento = fNacimiento;

        this.Tamanyo = tamanyo;

        this.Cliente = cliente;

        this.Consulta = consulta;

        this.Color = color;

        this.Microchip = microchip;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MascotaEN t = obj as MascotaEN;
        if (t == null)
                return false;
        if (IdMascota.Equals (t.IdMascota))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdMascota.GetHashCode ();
        return hash;
}
}
}
