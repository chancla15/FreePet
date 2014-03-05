
using System;

namespace PracticaGrupoGenNHibernate.EN.Default_
{
public partial class VeterinarioEN              :                           PracticaGrupoGenNHibernate.EN.Default_.EmployerEN


{
/**
 *
 */

private int num_colegiado;





public virtual int Num_colegiado {
        get { return num_colegiado; } set { num_colegiado = value;  }
}





public VeterinarioEN() : base ()
{
}



public VeterinarioEN(string dNI, int num_colegiado, string identifier, string name, string surname, string password, string address, int phone)
{
        this.init (dNI, num_colegiado, identifier, name, surname, password, address, phone);
}


public VeterinarioEN(VeterinarioEN veterinario)
{
        this.init (veterinario.DNI, veterinario.Num_colegiado, veterinario.Identifier, veterinario.Name, veterinario.Surname, veterinario.Password, veterinario.Address, veterinario.Phone);
}

private void init (string dNI, int num_colegiado, string identifier, string name, string surname, string password, string address, int phone)
{
        this.DNI = DNI;


        this.Num_colegiado = num_colegiado;

        this.Identifier = identifier;

        this.Name = name;

        this.Surname = surname;

        this.Password = password;

        this.Address = address;

        this.Phone = phone;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        VeterinarioEN t = obj as VeterinarioEN;
        if (t == null)
                return false;
        if (DNI.Equals (t.DNI))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.DNI.GetHashCode ();
        return hash;
}
}
}
