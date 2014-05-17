

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
}
}
