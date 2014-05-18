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
public partial class EmpleadoEN                 :                           GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.UsuarioEN


{
/**
 *
 */

private float sueldo;

/**
 *
 */

private String password;





public virtual float Sueldo {
        get { return sueldo; } set { sueldo = value;  }
}


public virtual String Password {
        get { return password; } set { password = value;  }
}





public EmpleadoEN() : base ()
{
}



public EmpleadoEN(string dNI, float sueldo, String password, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.init (dNI, sueldo, password, nombre, apellidos, direccion, telefono, localidad, provincia, cp);
}


public EmpleadoEN(EmpleadoEN empleado)
{
        this.init (empleado.DNI, empleado.Sueldo, empleado.Password, empleado.Nombre, empleado.Apellidos, empleado.Direccion, empleado.Telefono, empleado.Localidad, empleado.Provincia, empleado.Cp);
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
