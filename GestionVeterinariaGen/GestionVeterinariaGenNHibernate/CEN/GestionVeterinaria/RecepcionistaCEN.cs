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
public partial class RecepcionistaCEN
{
private IRecepcionistaCAD _IRecepcionistaCAD;

public RecepcionistaCEN()
{
        this._IRecepcionistaCAD = new RecepcionistaCAD ();
}

public RecepcionistaCEN(IRecepcionistaCAD _IRecepcionistaCAD)
{
        this._IRecepcionistaCAD = _IRecepcionistaCAD;
}

public IRecepcionistaCAD get_IRecepcionistaCAD ()
{
        return this._IRecepcionistaCAD;
}

public string New_ (string p_DNI, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp, float p_sueldo, String p_password)
{
        RecepcionistaEN recepcionistaEN = null;
        string oid;

        //Initialized RecepcionistaEN
        recepcionistaEN = new RecepcionistaEN ();
        recepcionistaEN.DNI = p_DNI;

        recepcionistaEN.Nombre = p_nombre;

        recepcionistaEN.Apellidos = p_apellidos;

        recepcionistaEN.Direccion = p_direccion;

        recepcionistaEN.Telefono = p_telefono;

        recepcionistaEN.Localidad = p_localidad;

        recepcionistaEN.Provincia = p_provincia;

        recepcionistaEN.Cp = p_cp;

        recepcionistaEN.Sueldo = p_sueldo;

        recepcionistaEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        //Call to RecepcionistaCAD

        oid = _IRecepcionistaCAD.New_ (recepcionistaEN);
        return oid;
}

public void Modify (string p_Recepcionista_OID, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp, float p_sueldo, String p_password)
{
        RecepcionistaEN recepcionistaEN = null;

        //Initialized RecepcionistaEN
        recepcionistaEN = new RecepcionistaEN ();
        recepcionistaEN.DNI = p_Recepcionista_OID;
        recepcionistaEN.Nombre = p_nombre;
        recepcionistaEN.Apellidos = p_apellidos;
        recepcionistaEN.Direccion = p_direccion;
        recepcionistaEN.Telefono = p_telefono;
        recepcionistaEN.Localidad = p_localidad;
        recepcionistaEN.Provincia = p_provincia;
        recepcionistaEN.Cp = p_cp;
        recepcionistaEN.Sueldo = p_sueldo;
        recepcionistaEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        //Call to RecepcionistaCAD

        _IRecepcionistaCAD.Modify (recepcionistaEN);
}

public void Destroy (string DNI)
{
        _IRecepcionistaCAD.Destroy (DNI);
}

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN> DameTodoLosRecepcionistas ()
{
        return _IRecepcionistaCAD.DameTodoLosRecepcionistas ();
}
public RecepcionistaEN BuscarRecepPorOID (string DNI)
{
        RecepcionistaEN recepcionistaEN = null;

        recepcionistaEN = _IRecepcionistaCAD.BuscarRecepPorOID (DNI);
        return recepcionistaEN;
}

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN> BuscarRecepPorNombre (string busqueda)
{
        return _IRecepcionistaCAD.BuscarRecepPorNombre (busqueda);
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN> BuscarRecepPorApellidos (string busqueda)
{
        return _IRecepcionistaCAD.BuscarRecepPorApellidos (busqueda);
}
}
}
