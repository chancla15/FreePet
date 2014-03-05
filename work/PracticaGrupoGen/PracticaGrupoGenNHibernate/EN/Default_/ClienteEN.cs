
using System;

namespace PracticaGrupoGenNHibernate.EN.Default_
{
public partial class ClienteEN                  :                           PracticaGrupoGenNHibernate.EN.Default_.UserEN


{
/**
 *
 */

private PracticaGrupoGenNHibernate.EN.Default_.AnimalEN animal;





public virtual PracticaGrupoGenNHibernate.EN.Default_.AnimalEN Animal {
        get { return animal; } set { animal = value;  }
}





public ClienteEN() : base ()
{
}



public ClienteEN(string dNI, PracticaGrupoGenNHibernate.EN.Default_.AnimalEN animal, string name, string surname, string password, string address, int phone)
{
        this.init (dNI, animal, name, surname, password, address, phone);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (cliente.DNI, cliente.Animal, cliente.Name, cliente.Surname, cliente.Password, cliente.Address, cliente.Phone);
}

private void init (string dNI, PracticaGrupoGenNHibernate.EN.Default_.AnimalEN animal, string name, string surname, string password, string address, int phone)
{
        this.DNI = DNI;


        this.Animal = animal;

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
        ClienteEN t = obj as ClienteEN;
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
