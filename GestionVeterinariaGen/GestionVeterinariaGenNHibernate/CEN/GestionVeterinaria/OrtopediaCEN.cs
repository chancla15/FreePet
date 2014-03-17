

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
public partial class OrtopediaCEN
{
private IOrtopediaCAD _IOrtopediaCAD;

public OrtopediaCEN()
{
        this._IOrtopediaCAD = new OrtopediaCAD ();
}

public OrtopediaCEN(IOrtopediaCAD _IOrtopediaCAD)
{
        this._IOrtopediaCAD = _IOrtopediaCAD;
}

public IOrtopediaCAD get_IOrtopediaCAD ()
{
        return this._IOrtopediaCAD;
}

public string New_ (string p_nombre, string p_fecha, string p_duracion, float p_precio, string p_talla, int p_longitud)
{
        OrtopediaEN ortopediaEN = null;
        string oid;

        //Initialized OrtopediaEN
        ortopediaEN = new OrtopediaEN ();
        ortopediaEN.Nombre = p_nombre;

        ortopediaEN.Fecha = p_fecha;

        ortopediaEN.Duracion = p_duracion;

        ortopediaEN.Precio = p_precio;

        ortopediaEN.Talla = p_talla;

        ortopediaEN.Longitud = p_longitud;

        //Call to OrtopediaCAD

        oid = _IOrtopediaCAD.New_ (ortopediaEN);
        return oid;
}

public void Modify (string p_Ortopedia_OID, string p_fecha, string p_duracion, float p_precio, string p_talla, int p_longitud)
{
        OrtopediaEN ortopediaEN = null;

        //Initialized OrtopediaEN
        ortopediaEN = new OrtopediaEN ();
        ortopediaEN.Nombre = p_Ortopedia_OID;
        ortopediaEN.Fecha = p_fecha;
        ortopediaEN.Duracion = p_duracion;
        ortopediaEN.Precio = p_precio;
        ortopediaEN.Talla = p_talla;
        ortopediaEN.Longitud = p_longitud;
        //Call to OrtopediaCAD

        _IOrtopediaCAD.Modify (ortopediaEN);
}

public void Destroy (string nombre)
{
        _IOrtopediaCAD.Destroy (nombre);
}

public System.Collections.Generic.IList<OrtopediaEN> DameTodosOrtopedia (int first, int size)
{
        System.Collections.Generic.IList<OrtopediaEN> list = null;

        list = _IOrtopediaCAD.DameTodosOrtopedia (first, size);
        return list;
}
public OrtopediaEN DameOrtopediaPorOID (string nombre)
{
        OrtopediaEN ortopediaEN = null;

        ortopediaEN = _IOrtopediaCAD.DameOrtopediaPorOID (nombre);
        return ortopediaEN;
}
}
}
