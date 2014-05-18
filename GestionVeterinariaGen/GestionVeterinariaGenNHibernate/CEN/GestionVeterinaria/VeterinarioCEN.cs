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
public partial class VeterinarioCEN
{
private IVeterinarioCAD _IVeterinarioCAD;

public VeterinarioCEN()
{
        this._IVeterinarioCAD = new VeterinarioCAD ();
}

public VeterinarioCEN(IVeterinarioCAD _IVeterinarioCAD)
{
        this._IVeterinarioCAD = _IVeterinarioCAD;
}

public IVeterinarioCAD get_IVeterinarioCAD ()
{
        return this._IVeterinarioCAD;
}

public string New_ (string p_DNI, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp, float p_sueldo, String p_password, int p_numColegiado)
{
        VeterinarioEN veterinarioEN = null;
        string oid;

        //Initialized VeterinarioEN
        veterinarioEN = new VeterinarioEN ();
        veterinarioEN.DNI = p_DNI;

        veterinarioEN.Nombre = p_nombre;

        veterinarioEN.Apellidos = p_apellidos;

        veterinarioEN.Direccion = p_direccion;

        veterinarioEN.Telefono = p_telefono;

        veterinarioEN.Localidad = p_localidad;

        veterinarioEN.Provincia = p_provincia;

        veterinarioEN.Cp = p_cp;

        veterinarioEN.Sueldo = p_sueldo;

        veterinarioEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        veterinarioEN.NumColegiado = p_numColegiado;

        //Call to VeterinarioCAD

        oid = _IVeterinarioCAD.New_ (veterinarioEN);
        return oid;
}

public void Modify (string p_Veterinario_OID, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp, float p_sueldo, String p_password, int p_numColegiado)
{
        VeterinarioEN veterinarioEN = null;

        //Initialized VeterinarioEN
        veterinarioEN = new VeterinarioEN ();
        veterinarioEN.DNI = p_Veterinario_OID;
        veterinarioEN.Nombre = p_nombre;
        veterinarioEN.Apellidos = p_apellidos;
        veterinarioEN.Direccion = p_direccion;
        veterinarioEN.Telefono = p_telefono;
        veterinarioEN.Localidad = p_localidad;
        veterinarioEN.Provincia = p_provincia;
        veterinarioEN.Cp = p_cp;
        veterinarioEN.Sueldo = p_sueldo;
        veterinarioEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        veterinarioEN.NumColegiado = p_numColegiado;
        //Call to VeterinarioCAD

        _IVeterinarioCAD.Modify (veterinarioEN);
}

public void Destroy (string DNI)
{
        _IVeterinarioCAD.Destroy (DNI);
}

public VeterinarioEN DameVetarinarioPorOID (string DNI)
{
        VeterinarioEN veterinarioEN = null;

        veterinarioEN = _IVeterinarioCAD.DameVetarinarioPorOID (DNI);
        return veterinarioEN;
}

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> BuscarVetPorNombre (string busqueda)
{
        return _IVeterinarioCAD.BuscarVetPorNombre (busqueda);
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> BuscarVetPorApellidos (string busqueda)
{
        return _IVeterinarioCAD.BuscarVetPorApellidos (busqueda);
}
public GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN BuscarPorNombreYApellidos (string name, string surname)
{
        return _IVeterinarioCAD.BuscarPorNombreYApellidos (name, surname);
}
}
}
