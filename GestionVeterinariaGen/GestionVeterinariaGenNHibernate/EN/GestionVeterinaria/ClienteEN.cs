/* 
    FreePet. OpenSource Software Veterinarian Management
    Copyright (C) 2014  Jesus Manresa Parres

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
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

private System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN> factura;





public virtual System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> Mascota {
        get { return mascota; } set { mascota = value;  }
}


public virtual System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN> Factura {
        get { return factura; } set { factura = value;  }
}





public ClienteEN() : base ()
{
        mascota = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN>();
        factura = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN>();
}



public ClienteEN(string dNI, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> mascota, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN> factura, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.init (dNI, mascota, factura, nombre, apellidos, direccion, telefono, localidad, provincia, cp);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (cliente.DNI, cliente.Mascota, cliente.Factura, cliente.Nombre, cliente.Apellidos, cliente.Direccion, cliente.Telefono, cliente.Localidad, cliente.Provincia, cliente.Cp);
}

private void init (string dNI, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> mascota, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN> factura, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
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
