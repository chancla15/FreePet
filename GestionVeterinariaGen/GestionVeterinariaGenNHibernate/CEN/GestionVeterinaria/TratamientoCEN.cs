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
public partial class TratamientoCEN
{
private ITratamientoCAD _ITratamientoCAD;

public TratamientoCEN()
{
        this._ITratamientoCAD = new TratamientoCAD ();
}

public TratamientoCEN(ITratamientoCAD _ITratamientoCAD)
{
        this._ITratamientoCAD = _ITratamientoCAD;
}

public ITratamientoCAD get_ITratamientoCAD ()
{
        return this._ITratamientoCAD;
}

public string New_ (string p_nombre, float p_precio, string p_descripcion, int p_stock, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum p_dosis_diaria)
{
        TratamientoEN tratamientoEN = null;
        string oid;

        //Initialized TratamientoEN
        tratamientoEN = new TratamientoEN ();
        tratamientoEN.Nombre = p_nombre;

        tratamientoEN.Precio = p_precio;

        tratamientoEN.Descripcion = p_descripcion;

        tratamientoEN.Stock = p_stock;

        tratamientoEN.Dosis_diaria = p_dosis_diaria;

        //Call to TratamientoCAD

        oid = _ITratamientoCAD.New_ (tratamientoEN);
        return oid;
}

public void Modify (string p_Tratamiento_OID, float p_precio, string p_descripcion, int p_stock, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum p_dosis_diaria)
{
        TratamientoEN tratamientoEN = null;

        //Initialized TratamientoEN
        tratamientoEN = new TratamientoEN ();
        tratamientoEN.Nombre = p_Tratamiento_OID;
        tratamientoEN.Precio = p_precio;
        tratamientoEN.Descripcion = p_descripcion;
        tratamientoEN.Stock = p_stock;
        tratamientoEN.Dosis_diaria = p_dosis_diaria;
        //Call to TratamientoCAD

        _ITratamientoCAD.Modify (tratamientoEN);
}

public void Destroy (string nombre)
{
        _ITratamientoCAD.Destroy (nombre);
}

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> DameTodosLosTratamientos ()
{
        return _ITratamientoCAD.DameTodosLosTratamientos ();
}
public TratamientoEN DameTratamientoPorOID (string nombre)
{
        TratamientoEN tratamientoEN = null;

        tratamientoEN = _ITratamientoCAD.DameTratamientoPorOID (nombre);
        return tratamientoEN;
}

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> DameTratamientosPorConsulta (int id_consulta)
{
        return _ITratamientoCAD.DameTratamientosPorConsulta (id_consulta);
}
}
}
