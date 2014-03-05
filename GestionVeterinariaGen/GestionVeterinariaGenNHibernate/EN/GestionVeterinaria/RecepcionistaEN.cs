
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class RecepcionistaEN                    :                           GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN


{
public RecepcionistaEN() : base ()
{
}



public RecepcionistaEN(string dNI, string idEmpleado, float sueldo, string nombre, string apellidos, String password, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.init (dNI, idEmpleado, sueldo, nombre, apellidos, password, direccion, telefono, localidad, provincia, cp);
}


public RecepcionistaEN(RecepcionistaEN recepcionista)
{
        this.init (recepcionista.DNI, recepcionista.IdEmpleado, recepcionista.Sueldo, recepcionista.Nombre, recepcionista.Apellidos, recepcionista.Password, recepcionista.Direccion, recepcionista.Telefono, recepcionista.Localidad, recepcionista.Provincia, recepcionista.Cp);
}

private void init (string dNI, string idEmpleado, float sueldo, string nombre, string apellidos, String password, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.DNI = DNI;


        this.IdEmpleado = idEmpleado;

        this.Sueldo = sueldo;

        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Password = password;

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
        RecepcionistaEN t = obj as RecepcionistaEN;
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
