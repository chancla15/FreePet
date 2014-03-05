

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

public HistorialClinicoEN ConsultarHistorialPorOID (int numero)
{
        HistorialClinicoEN historialClinicoEN = null;

        historialClinicoEN = _IHistorialClinicoCAD.ConsultarHistorialPorOID (numero);
        return historialClinicoEN;
}

public int New_ (int p_mascota)
{
        HistorialClinicoEN historialClinicoEN = null;
        int oid;

        //Initialized HistorialClinicoEN
        historialClinicoEN = new HistorialClinicoEN ();

        if (p_mascota != -1) {
                historialClinicoEN.Mascota = new GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN ();
                historialClinicoEN.Mascota.IdMascota = p_mascota;
        }

        //Call to HistorialClinicoCAD

        oid = _IHistorialClinicoCAD.New_ (historialClinicoEN);
        return oid;
}

public void Modify (int p_HistorialClinico_OID)
{
        HistorialClinicoEN historialClinicoEN = null;

        //Initialized HistorialClinicoEN
        historialClinicoEN = new HistorialClinicoEN ();
        historialClinicoEN.Numero = p_HistorialClinico_OID;
        //Call to HistorialClinicoCAD

        _IHistorialClinicoCAD.Modify (historialClinicoEN);
}

public void Destroy (int numero)
{
        _IHistorialClinicoCAD.Destroy (numero);
}
}
}
