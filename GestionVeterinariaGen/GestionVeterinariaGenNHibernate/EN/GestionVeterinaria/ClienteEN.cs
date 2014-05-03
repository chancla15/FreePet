
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class ClienteEN                  :                           GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.UsuarioEN


{
/**
 *
 */

private System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> mascota;

/**
 *
 */

private GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN factura;





public virtual System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> Mascota {
        get { return mascota; } set { mascota = value;  }
}


public virtual GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN Factura {
        get { return factura; } set { factura = value;  }
}





public ClienteEN() : base ()
{
        mascota = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN>();
}



public ClienteEN(string dNI, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> mascota, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN factura, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.init (dNI, mascota, factura, nombre, apellidos, direccion, telefono, localidad, provincia, cp);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (cliente.DNI, cliente.Mascota, cliente.Factura, cliente.Nombre, cliente.Apellidos, cliente.Direccion, cliente.Telefono, cliente.Localidad, cliente.Provincia, cliente.Cp);
}

private void init (string dNI, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> mascota, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN factura, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.DNI = DNI;


        this.Mascota = mascota;

        this.Factura = factura;

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
