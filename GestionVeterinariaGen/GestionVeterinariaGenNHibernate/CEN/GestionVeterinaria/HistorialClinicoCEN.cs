

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
public partial class HistorialClinicoCEN
{
private IHistorialClinicoCAD _IHistorialClinicoCAD;

public HistorialClinicoCEN()
{
        this._IHistorialClinicoCAD = new HistorialClinicoCAD ();
}

public HistorialClinicoCEN(IHistorialClinicoCAD _IHistorialClinicoCAD)
{
        this._IHistorialClinicoCAD = _IHistorialClinicoCAD;
}

public IHistorialClinicoCAD get_IHistorialClinicoCAD ()
{
        return this._IHistorialClinicoCAD;
}

public HistorialClinicoEN ConsultarHistorialPorOID (string numero)
{
        HistorialClinicoEN historialClinicoEN = null;

        historialClinicoEN = _IHistorialClinicoCAD.ConsultarHistorialPorOID (numero);
        return historialClinicoEN;
}

public string New_ (string p_numero, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN p_mascota)
{
        HistorialClinicoEN historialClinicoEN = null;
        string oid;

        //Initialized HistorialClinicoEN
        historialClinicoEN = new HistorialClinicoEN ();
        historialClinicoEN.Numero = p_numero;

        historialClinicoEN.Mascota = p_mascota;

        //Call to HistorialClinicoCAD

        oid = _IHistorialClinicoCAD.New_ (historialClinicoEN);
        return oid;
}

public void Modify (string p_HistorialClinico_OID)
{
        HistorialClinicoEN historialClinicoEN = null;

        //Initialized HistorialClinicoEN
        historialClinicoEN = new HistorialClinicoEN ();
        historialClinicoEN.Numero = p_HistorialClinico_OID;
        //Call to HistorialClinicoCAD

        _IHistorialClinicoCAD.Modify (historialClinicoEN);
}

public void Destroy (string numero)
{
        _IHistorialClinicoCAD.Destroy (numero);
}
}
}
