

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

public string New_ (string p_nombre, string p_fecha, string p_duracion, float p_precio)
{
        TratamientoEN tratamientoEN = null;
        string oid;

        //Initialized TratamientoEN
        tratamientoEN = new TratamientoEN ();
        tratamientoEN.Nombre = p_nombre;

        tratamientoEN.Fecha = p_fecha;

        tratamientoEN.Duracion = p_duracion;

        tratamientoEN.Precio = p_precio;

        //Call to TratamientoCAD

        oid = _ITratamientoCAD.New_ (tratamientoEN);
        return oid;
}

public void Modify (string p_Tratamiento_OID, string p_fecha, string p_duracion, float p_precio)
{
        TratamientoEN tratamientoEN = null;

        //Initialized TratamientoEN
        tratamientoEN = new TratamientoEN ();
        tratamientoEN.Nombre = p_Tratamiento_OID;
        tratamientoEN.Fecha = p_fecha;
        tratamientoEN.Duracion = p_duracion;
        tratamientoEN.Precio = p_precio;
        //Call to TratamientoCAD

        _ITratamientoCAD.Modify (tratamientoEN);
}

public void Destroy (string nombre)
{
        _ITratamientoCAD.Destroy (nombre);
}

public System.Collections.Generic.IList<TratamientoEN> DameTodosLosTratamientos (int first, int size)
{
        System.Collections.Generic.IList<TratamientoEN> list = null;

        list = _ITratamientoCAD.DameTodosLosTratamientos (first, size);
        return list;
}
public TratamientoEN DameTratamientoPorOID (string nombre)
{
        TratamientoEN tratamientoEN = null;

        tratamientoEN = _ITratamientoCAD.DameTratamientoPorOID (nombre);
        return tratamientoEN;
}
}
}
