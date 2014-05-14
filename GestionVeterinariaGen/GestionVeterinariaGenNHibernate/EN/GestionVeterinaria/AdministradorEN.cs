
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class AdministradorEN                    :                           GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN


{
public AdministradorEN() : base ()
{
}



public AdministradorEN(string dNI, float sueldo, String password, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.init (dNI, sueldo, password, nombre, apellidos, direccion, telefono, localidad, provincia, cp);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (administrador.DNI, administrador.Sueldo, administrador.Password, administrador.Nombre, administrador.Apellidos, administrador.Direccion, administrador.Telefono, administrador.Localidad, administrador.Provincia, administrador.Cp);
}

private void init (string dNI, float sueldo, String password, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.DNI = DNI;


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
        AdministradorEN t = obj as AdministradorEN;
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
