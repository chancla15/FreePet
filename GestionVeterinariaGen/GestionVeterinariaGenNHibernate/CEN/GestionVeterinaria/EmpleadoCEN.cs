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
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria
{
public partial class EmpleadoCEN
{
private IEmpleadoCAD _IEmpleadoCAD;

public EmpleadoCEN()
{
        this._IEmpleadoCAD = new EmpleadoCAD ();
}

public EmpleadoCEN(IEmpleadoCAD _IEmpleadoCAD)
{
        this._IEmpleadoCAD = _IEmpleadoCAD;
}

public IEmpleadoCAD get_IEmpleadoCAD ()
{
        return this._IEmpleadoCAD;
}

public string New_ (string p_DNI, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp, float p_sueldo, String p_password)
{
        EmpleadoEN empleadoEN = null;
        string oid;

        //Initialized EmpleadoEN
        empleadoEN = new EmpleadoEN ();
        empleadoEN.DNI = p_DNI;

        empleadoEN.Nombre = p_nombre;

        empleadoEN.Apellidos = p_apellidos;

        empleadoEN.Direccion = p_direccion;

        empleadoEN.Telefono = p_telefono;

        empleadoEN.Localidad = p_localidad;

        empleadoEN.Provincia = p_provincia;

        empleadoEN.Cp = p_cp;

        empleadoEN.Sueldo = p_sueldo;

        empleadoEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        //Call to EmpleadoCAD

        oid = _IEmpleadoCAD.New_ (empleadoEN);
        return oid;
}

public void Modify (string p_Empleado_OID, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp, float p_sueldo, String p_password)
{
        EmpleadoEN empleadoEN = null;

        //Initialized EmpleadoEN
        empleadoEN = new EmpleadoEN ();
        empleadoEN.DNI = p_Empleado_OID;
        empleadoEN.Nombre = p_nombre;
        empleadoEN.Apellidos = p_apellidos;
        empleadoEN.Direccion = p_direccion;
        empleadoEN.Telefono = p_telefono;
        empleadoEN.Localidad = p_localidad;
        empleadoEN.Provincia = p_provincia;
        empleadoEN.Cp = p_cp;
        empleadoEN.Sueldo = p_sueldo;
        empleadoEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        //Call to EmpleadoCAD

        _IEmpleadoCAD.Modify (empleadoEN);
}

public void Destroy (string DNI)
{
        _IEmpleadoCAD.Destroy (DNI);
}

public EmpleadoEN DameEmpleadoPorOID (string DNI)
{
        EmpleadoEN empleadoEN = null;

        empleadoEN = _IEmpleadoCAD.DameEmpleadoPorOID (DNI);
        return empleadoEN;
}

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN> DameTodosLosEmpleados ()
{
        return _IEmpleadoCAD.DameTodosLosEmpleados ();
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN> DameEmpleadoPorNombre (string busqueda)
{
        return _IEmpleadoCAD.DameEmpleadoPorNombre (busqueda);
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN> DameEmpleadoPorApellidos (string busqueda)
{
        return _IEmpleadoCAD.DameEmpleadoPorApellidos (busqueda);
}
}
}
