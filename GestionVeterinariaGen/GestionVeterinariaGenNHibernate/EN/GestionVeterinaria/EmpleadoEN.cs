
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class EmpleadoEN                 :                           GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.UsuarioEN


{
/**
 *
 */

private string idEmpleado;

/**
 *
 */

private float sueldo;

/**
 *
 */

private String password;





public virtual string IdEmpleado {
        get { return idEmpleado; } set { idEmpleado = value;  }
}


public virtual float Sueldo {
        get { return sueldo; } set { sueldo = value;  }
}


public virtual String Password {
        get { return password; } set { password = value;  }
}





public EmpleadoEN() : base ()
{
}



public EmpleadoEN(string dNI, string idEmpleado, float sueldo, String password, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.init (dNI, idEmpleado, sueldo, password, nombre, apellidos, direccion, telefono, localidad, provincia, cp);
}


public EmpleadoEN(EmpleadoEN empleado)
{
        this.init (empleado.DNI, empleado.IdEmpleado, empleado.Sueldo, empleado.Password, empleado.Nombre, empleado.Apellidos, empleado.Direccion, empleado.Telefono, empleado.Localidad, empleado.Provincia, empleado.Cp);
}

private void init (string dNI, string idEmpleado, float sueldo, String password, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.DNI = DNI;


        this.IdEmpleado = idEmpleado;

        this.Sueldo = sueldo;

        this.Password = password;

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
        EmpleadoEN t = obj as EmpleadoEN;
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
