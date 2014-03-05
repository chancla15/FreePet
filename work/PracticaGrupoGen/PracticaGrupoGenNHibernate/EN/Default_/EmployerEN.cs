
using System;

namespace PracticaGrupoGenNHibernate.EN.Default_
{
public partial class EmployerEN                 :                           PracticaGrupoGenNHibernate.EN.Default_.UserEN


{
/**
 *
 */

private string identifier;





public virtual string Identifier {
        get { return identifier; } set { identifier = value;  }
}





public EmployerEN() : base ()
{
}



public EmployerEN(string dNI, string identifier, string name, string surname, string password, string address, int phone)
{
        this.init (dNI, identifier, name, surname, password, address, phone);
}


public EmployerEN(EmployerEN employer)
{
        this.init (employer.DNI, employer.Identifier, employer.Name, employer.Surname, employer.Password, employer.Address, employer.Phone);
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
        EmployerEN t = obj as EmployerEN;
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
