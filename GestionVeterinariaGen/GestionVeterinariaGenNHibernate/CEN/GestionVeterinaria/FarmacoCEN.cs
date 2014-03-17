

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
public partial class FarmacoCEN
{
private IFarmacoCAD _IFarmacoCAD;

public FarmacoCEN()
{
        this._IFarmacoCAD = new FarmacoCAD ();
}

public FarmacoCEN(IFarmacoCAD _IFarmacoCAD)
{
        this._IFarmacoCAD = _IFarmacoCAD;
}

public IFarmacoCAD get_IFarmacoCAD ()
{
        return this._IFarmacoCAD;
}

public string New_ (string p_nombre, string p_fecha, string p_duracion, float p_precio, string p_cantidad, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum p_frecuencia)
{
        FarmacoEN farmacoEN = null;
        string oid;

        //Initialized FarmacoEN
        farmacoEN = new FarmacoEN ();
        farmacoEN.Nombre = p_nombre;

        farmacoEN.Fecha = p_fecha;

        farmacoEN.Duracion = p_duracion;

        farmacoEN.Precio = p_precio;

        farmacoEN.Cantidad = p_cantidad;

        farmacoEN.Frecuencia = p_frecuencia;

        //Call to FarmacoCAD

        oid = _IFarmacoCAD.New_ (farmacoEN);
        return oid;
}

public void Modify (string p_Farmaco_OID, string p_fecha, string p_duracion, float p_precio, string p_cantidad, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum p_frecuencia)
{
        FarmacoEN farmacoEN = null;

        //Initialized FarmacoEN
        farmacoEN = new FarmacoEN ();
        farmacoEN.Nombre = p_Farmaco_OID;
        farmacoEN.Fecha = p_fecha;
        farmacoEN.Duracion = p_duracion;
        farmacoEN.Precio = p_precio;
        farmacoEN.Cantidad = p_cantidad;
        farmacoEN.Frecuencia = p_frecuencia;
        //Call to FarmacoCAD

        _IFarmacoCAD.Modify (farmacoEN);
}

public void Destroy (string nombre)
{
        _IFarmacoCAD.Destroy (nombre);
}

public System.Collections.Generic.IList<FarmacoEN> DameTodosLosFarmacos (int first, int size)
{
        System.Collections.Generic.IList<FarmacoEN> list = null;

        list = _IFarmacoCAD.DameTodosLosFarmacos (first, size);
        return list;
}
public FarmacoEN DameFarmacoPorOID (string nombre)
{
        FarmacoEN farmacoEN = null;

        farmacoEN = _IFarmacoCAD.DameFarmacoPorOID (nombre);
        return farmacoEN;
}
}
}
