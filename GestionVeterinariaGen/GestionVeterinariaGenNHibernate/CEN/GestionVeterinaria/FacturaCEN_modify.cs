
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
public void Modify (int p_Factura_OID, Nullable<DateTime> p_fecha, float p_total, bool p_pagada, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN p_consulta)
{
        /*PROTECTED REGION ID(GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria_Factura_modify_customized) START*/

        FacturaEN facturaEN = null;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.IdFactura = p_Factura_OID;
        facturaEN.Fecha = p_fecha;
        facturaEN.Total = p_total;
        facturaEN.Pagada = p_pagada;
        facturaEN.Consulta = p_consulta;
        //Call to FacturaCAD

        _IFacturaCAD.Modify (facturaEN);

        /*PROTECTED REGION END*/
}
}
}
