
using System;

namespace PracticaGrupoGenNHibernate.EN.Default_
{
public partial class AnimalEN
{
/**
 *
 */

private System.Collections.Generic.IList<PracticaGrupoGenNHibernate.EN.Default_.ClienteEN> cliente;

/**
 *
 */

private string microchip;

/**
 *
 */

private string name;

/**
 *
 */

private PracticaGrupoGenNHibernate.Enumerated.Default_.RazaAnimalEnum raza;

/**
 *
 */

private PracticaGrupoGenNHibernate.Enumerated.Default_.TamanyoAnimalEnum tamanyo;

/**
 *
 */

private double peso;

/**
 *
 */

private Nullable<DateTime> fechanac;

/**
 *
 */

private char sexo;





public virtual System.Collections.Generic.IList<PracticaGrupoGenNHibernate.EN.Default_.ClienteEN> Cliente {
        get { return cliente; } set { cliente = value;  }
}


public virtual string Microchip {
        get { return microchip; } set { microchip = value;  }
}


public virtual string Name {
        get { return name; } set { name = value;  }
}


public virtual PracticaGrupoGenNHibernate.Enumerated.Default_.RazaAnimalEnum Raza {
        get { return raza; } set { raza = value;  }
}


public virtual PracticaGrupoGenNHibernate.Enumerated.Default_.TamanyoAnimalEnum Tamanyo {
        get { return tamanyo; } set { tamanyo = value;  }
}


public virtual double Peso {
        get { return peso; } set { peso = value;  }
}


public virtual Nullable<DateTime> Fechanac {
        get { return fechanac; } set { fechanac = value;  }
}


public virtual char Sexo {
        get { return sexo; } set { sexo = value;  }
}





public AnimalEN()
{
        cliente = new System.Collections.Generic.List<PracticaGrupoGenNHibernate.EN.Default_.ClienteEN>();
}



public AnimalEN(string microchip, System.Collections.Generic.IList<PracticaGrupoGenNHibernate.EN.Default_.ClienteEN> cliente, string name, PracticaGrupoGenNHibernate.Enumerated.Default_.RazaAnimalEnum raza, PracticaGrupoGenNHibernate.Enumerated.Default_.TamanyoAnimalEnum tamanyo, double peso, Nullable<DateTime> fechanac, char sexo)
{
        this.init (microchip, cliente, name, raza, tamanyo, peso, fechanac, sexo);
}


public AnimalEN(AnimalEN animal)
{
        this.init (animal.Microchip, animal.Cliente, animal.Name, animal.Raza, animal.Tamanyo, animal.Peso, animal.Fechanac, animal.Sexo);
}

private void init (string microchip, System.Collections.Generic.IList<PracticaGrupoGenNHibernate.EN.Default_.ClienteEN> cliente, string name, PracticaGrupoGenNHibernate.Enumerated.Default_.RazaAnimalEnum raza, PracticaGrupoGenNHibernate.Enumerated.Default_.TamanyoAnimalEnum tamanyo, double peso, Nullable<DateTime> fechanac, char sexo)
{
        this.Microchip = microchip;


        this.Cliente = cliente;

        this.Name = name;

        this.Raza = raza;

        this.Tamanyo = tamanyo;

        this.Peso = peso;

        this.Fechanac = fechanac;

        this.Sexo = sexo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AnimalEN t = obj as AnimalEN;
        if (t == null)
                return false;
        if (Microchip.Equals (t.Microchip))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Microchip.GetHashCode ();
        return hash;
}
}
}
