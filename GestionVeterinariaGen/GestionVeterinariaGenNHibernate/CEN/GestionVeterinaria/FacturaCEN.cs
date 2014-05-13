

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
public partial class FacturaCEN
{
private IFacturaCAD _IFacturaCAD;

public FacturaCEN()
{
        this._IFacturaCAD = new FacturaCAD ();
}

public FacturaCEN(IFacturaCAD _IFacturaCAD)
{
        this._IFacturaCAD = _IFacturaCAD;
}

public IFacturaCAD get_IFacturaCAD ()
{
        return this._IFacturaCAD;
}

public System.Collections.Generic.IList<FacturaEN> DameTodasLasFacturas (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> list = null;

        list = _IFacturaCAD.DameTodasLasFacturas (first, size);
        return list;
}
public int New_ (Nullable<DateTime> p_fecha, float p_total, string p_cliente, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN p_consulta, bool p_pagada)
{
        FacturaEN facturaEN = null;
        int oid;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Fecha = p_fecha;

        facturaEN.Total = p_total;


        if (p_cliente != null) {
                facturaEN.Cliente = new GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN ();
                facturaEN.Cliente.DNI = p_cliente;
        }

        facturaEN.Consulta = p_consulta;

        facturaEN.Pagada = p_pagada;

        //Call to FacturaCAD

        oid = _IFacturaCAD.New_ (facturaEN);
        return oid;
}

public void Modify (int p_Factura_OID, Nullable<DateTime> p_fecha, float p_total, bool p_pagada)
{
        FacturaEN facturaEN = null;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.IdFactura = p_Factura_OID;
        facturaEN.Fecha = p_fecha;
        facturaEN.Total = p_total;
        facturaEN.Pagada = p_pagada;
        //Call to FacturaCAD

        _IFacturaCAD.Modify (facturaEN);
}

public void Destroy (int idFactura)
{
        _IFacturaCAD.Destroy (idFactura);
}

public FacturaEN DameFacturaPorOID (int idFactura)
{
        FacturaEN facturaEN = null;

        facturaEN = _IFacturaCAD.DameFacturaPorOID (idFactura);
        return facturaEN;
}

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN> DameFacturaPorFecha (Nullable<DateTime> param)
{
        return _IFacturaCAD.DameFacturaPorFecha (param);
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN> DameImpagos ()
{
        return _IFacturaCAD.DameImpagos ();
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN> DameFacturasPorCliente (string nif)
{
        return _IFacturaCAD.DameFacturasPorCliente (nif);
}
}
}
