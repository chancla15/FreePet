
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class RecepcionistaEN                    :                           GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN


{
public RecepcionistaEN() : base ()
{
}



public RecepcionistaEN(string dNI, int idEmpleado, float sueldo, String password, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.init (dNI, idEmpleado, sueldo, password, nombre, apellidos, direccion, telefono, localidad, provincia, cp);
}


public RecepcionistaEN(RecepcionistaEN recepcionista)
{
        this.init (recepcionista.DNI, recepcionista.IdEmpleado, recepcionista.Sueldo, recepcionista.Password, recepcionista.Nombre, recepcionista.Apellidos, recepcionista.Direccion, recepcionista.Telefono, recepcionista.Localidad, recepcionista.Provincia, recepcionista.Cp);
}

private void init (string dNI, int idEmpleado, float sueldo, String password, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
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
