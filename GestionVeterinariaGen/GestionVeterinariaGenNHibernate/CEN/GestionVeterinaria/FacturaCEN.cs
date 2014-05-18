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

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN> DameTodasLasFacturas ()
{
        return _IFacturaCAD.DameTodasLasFacturas ();
}
public int New_ (Nullable<DateTime> p_fecha, float p_total, string p_cliente, int p_consulta, bool p_pagada)
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


        if (p_consulta != -1) {
                facturaEN.Consulta = new GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN ();
                facturaEN.Consulta.IdConsulta = p_consulta;
        }

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
