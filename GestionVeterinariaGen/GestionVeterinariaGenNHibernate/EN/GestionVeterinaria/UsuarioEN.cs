
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class UsuarioEN
{
/**
 *
 */

private string dNI;

/**
 *
 */

private string nombre;

/**
 *
 */

private string apellidos;

/**
 *
 */

private string direccion;

/**
 *
 */

private string telefono;

/**
 *
 */

private string localidad;

/**
 *
 */

private string provincia;

/**
 *
 */

private string cp;





public virtual string DNI {
        get { return dNI; } set { dNI = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}


public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}


public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}


public virtual string Localidad {
        get { return localidad; } set { localidad = value;  }
}


public virtual string Provincia {
        get { return provincia; } set { provincia = value;  }
}


public virtual string Cp {
        get { return cp; } set { cp = value;  }
}





public UsuarioEN()
{
}



public UsuarioEN(string dNI, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.init (dNI, nombre, apellidos, direccion, telefono, localidad, provincia, cp);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.DNI, usuario.Nombre, usuario.Apellidos, usuario.Direccion, usuario.Telefono, usuario.Localidad, usuario.Provincia, usuario.Cp);
}

private void init (string dNI, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.DNI = DNI;


        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Direccion = direccion;

        this.Telefono = telefono;

        this.Localidad = localidad;

        this.Provincia = provincia;

        this.Cp = cp;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
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
