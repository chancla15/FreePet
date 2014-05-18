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
public partial class AdministradorCEN
{
private IAdministradorCAD _IAdministradorCAD;

public AdministradorCEN()
{
        this._IAdministradorCAD = new AdministradorCAD ();
}

public AdministradorCEN(IAdministradorCAD _IAdministradorCAD)
{
        this._IAdministradorCAD = _IAdministradorCAD;
}

public IAdministradorCAD get_IAdministradorCAD ()
{
        return this._IAdministradorCAD;
}

public string New_ (string p_DNI, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp, float p_sueldo, String p_password)
{
        AdministradorEN administradorEN = null;
        string oid;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.DNI = p_DNI;

        administradorEN.Nombre = p_nombre;

        administradorEN.Apellidos = p_apellidos;

        administradorEN.Direccion = p_direccion;

        administradorEN.Telefono = p_telefono;

        administradorEN.Localidad = p_localidad;

        administradorEN.Provincia = p_provincia;

        administradorEN.Cp = p_cp;

        administradorEN.Sueldo = p_sueldo;

        administradorEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        //Call to AdministradorCAD

        oid = _IAdministradorCAD.New_ (administradorEN);
        return oid;
}

public void Modify (string p_Administrador_OID, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp, float p_sueldo, String p_password)
{
        AdministradorEN administradorEN = null;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.DNI = p_Administrador_OID;
        administradorEN.Nombre = p_nombre;
        administradorEN.Apellidos = p_apellidos;
        administradorEN.Direccion = p_direccion;
        administradorEN.Telefono = p_telefono;
        administradorEN.Localidad = p_localidad;
        administradorEN.Provincia = p_provincia;
        administradorEN.Cp = p_cp;
        administradorEN.Sueldo = p_sueldo;
        administradorEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        //Call to AdministradorCAD

        _IAdministradorCAD.Modify (administradorEN);
}

public void Destroy (string DNI)
{
        _IAdministradorCAD.Destroy (DNI);
}

public GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.AdministradorEN IsAdmin (string nif, string pass)
{
        return _IAdministradorCAD.IsAdmin (nif, pass);
}
}
}
