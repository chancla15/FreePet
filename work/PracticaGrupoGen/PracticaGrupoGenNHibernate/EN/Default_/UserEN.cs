
using System;

namespace PracticaGrupoGenNHibernate.EN.Default_
{
public partial class UserEN
{
/**
 *
 */

private string dNI;

/**
 *
 */

private string name;

/**
 *
 */

private string surname;

/**
 *
 */

private string password;

/**
 *
 */

private string address;

/**
 *
 */

private int phone;





public virtual string DNI {
        get { return dNI; } set { dNI = value;  }
}


public virtual string Name {
        get { return name; } set { name = value;  }
}


public virtual string Surname {
        get { return surname; } set { surname = value;  }
}


public virtual string Password {
        get { return password; } set { password = value;  }
}


public virtual string Address {
        get { return address; } set { address = value;  }
}


public virtual int Phone {
        get { return phone; } set { phone = value;  }
}





public UserEN()
{
}



public UserEN(string dNI, string name, string surname, string password, string address, int phone)
{
        this.init (dNI, name, surname, password, address, phone);
}


public UserEN(UserEN user)
{
        this.init (user.DNI, user.Name, user.Surname, user.Password, user.Address, user.Phone);
}

private void init (string dNI, string name, string surname, string password, string address, int phone)
{
        this.DNI = DNI;


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
        UserEN t = obj as UserEN;
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
