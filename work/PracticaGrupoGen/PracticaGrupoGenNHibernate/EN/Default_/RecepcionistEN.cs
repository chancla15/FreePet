
using System;

namespace PracticaGrupoGenNHibernate.EN.Default_
{
public partial class RecepcionistEN                     :                           PracticaGrupoGenNHibernate.EN.Default_.EmployerEN


{
public RecepcionistEN() : base ()
{
}



public RecepcionistEN(string dNI, string identifier, string name, string surname, string password, string address, int phone)
{
        this.init (dNI, identifier, name, surname, password, address, phone);
}


public RecepcionistEN(RecepcionistEN recepcionist)
{
        this.init (recepcionist.DNI, recepcionist.Identifier, recepcionist.Name, recepcionist.Surname, recepcionist.Password, recepcionist.Address, recepcionist.Phone);
}

private void init (string dNI, string identifier, string name, string surname, string password, string address, int phone)
{
        this.DNI = DNI;


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
        RecepcionistEN t = obj as RecepcionistEN;
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
