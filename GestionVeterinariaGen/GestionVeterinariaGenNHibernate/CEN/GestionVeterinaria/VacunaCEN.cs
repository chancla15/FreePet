

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
public partial class VacunaCEN
{
private IVacunaCAD _IVacunaCAD;

public VacunaCEN()
{
        this._IVacunaCAD = new VacunaCAD ();
}

public VacunaCEN(IVacunaCAD _IVacunaCAD)
{
        this._IVacunaCAD = _IVacunaCAD;
}

public IVacunaCAD get_IVacunaCAD ()
{
        return this._IVacunaCAD;
}

public string New_ (string p_nombre, string p_fecha, string p_duracion, float p_precio, string p_tipo)
{
        VacunaEN vacunaEN = null;
        string oid;

        //Initialized VacunaEN
        vacunaEN = new VacunaEN ();
        vacunaEN.Nombre = p_nombre;

        vacunaEN.Fecha = p_fecha;

        vacunaEN.Duracion = p_duracion;

        vacunaEN.Precio = p_precio;

        vacunaEN.Tipo = p_tipo;

        //Call to VacunaCAD

        oid = _IVacunaCAD.New_ (vacunaEN);
        return oid;
}

public void Modify (string p_Vacuna_OID, string p_fecha, string p_duracion, float p_precio, string p_tipo)
{
        VacunaEN vacunaEN = null;

        //Initialized VacunaEN
        vacunaEN = new VacunaEN ();
        vacunaEN.Nombre = p_Vacuna_OID;
        vacunaEN.Fecha = p_fecha;
        vacunaEN.Duracion = p_duracion;
        vacunaEN.Precio = p_precio;
        vacunaEN.Tipo = p_tipo;
        //Call to VacunaCAD

        _IVacunaCAD.Modify (vacunaEN);
}

public void Destroy (string nombre)
{
        _IVacunaCAD.Destroy (nombre);
}

public System.Collections.Generic.IList<VacunaEN> DameTodasLasVacunas (int first, int size)
{
        System.Collections.Generic.IList<VacunaEN> list = null;

        list = _IVacunaCAD.DameTodasLasVacunas (first, size);
        return list;
}
}
}
