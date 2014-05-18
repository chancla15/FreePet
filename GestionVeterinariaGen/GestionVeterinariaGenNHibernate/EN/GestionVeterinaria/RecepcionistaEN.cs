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
public partial class RecepcionistaEN                    :                           GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN


{
public RecepcionistaEN() : base ()
{
}



public RecepcionistaEN(string dNI, float sueldo, String password, string nombre, string apellidos, string direccion, string telefono, string localidad, string provincia, string cp)
{
        this.init (dNI, sueldo, password, nombre, apellidos, direccion, telefono, localidad, provincia, cp);
}


public RecepcionistaEN(RecepcionistaEN recepcionista)
{
        this.init (recepcionista.DNI, recepcionista.Sueldo, recepcionista.Password, recepcionista.Nombre, recepcionista.Apellidos, recepcionista.Direccion, recepcionista.Telefono, recepcionista.Localidad, recepcionista.Provincia, recepcionista.Cp);
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
