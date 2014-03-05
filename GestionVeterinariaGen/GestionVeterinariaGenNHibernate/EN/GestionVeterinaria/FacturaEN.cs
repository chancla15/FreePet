
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class FacturaEN
{
/**
 *
 */

private int idFactura;

/**
 *
 */

private Nullable<DateTime> fecha;

/**
 *
 */

private float total;

/**
 *
 */

private GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN cliente;

/**
 *
 */

private GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN consulta;

/**
 *
 */

private System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> farmaco;

/**
 *
 */

private bool pagada;





public virtual int IdFactura {
        get { return idFactura; } set { idFactura = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual float Total {
        get { return total; } set { total = value;  }
}


public virtual GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}


public virtual GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN Consulta {
        get { return consulta; } set { consulta = value;  }
}


public virtual System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> Farmaco {
        get { return farmaco; } set { farmaco = value;  }
}


public virtual bool Pagada {
        get { return pagada; } set { pagada = value;  }
}





public FacturaEN()
{
        farmaco = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN>();
}



public FacturaEN(int idFactura, Nullable<DateTime> fecha, float total, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN cliente, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN consulta, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> farmaco, bool pagada)
{
        this.init (idFactura, fecha, total, cliente, consulta, farmaco, pagada);
}


public FacturaEN(FacturaEN factura)
{
        this.init (factura.IdFactura, factura.Fecha, factura.Total, factura.Cliente, factura.Consulta, factura.Farmaco, factura.Pagada);
}

private void init (int idFactura, Nullable<DateTime> fecha, float total, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN cliente, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN consulta, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> farmaco, bool pagada)
{
        this.IdFactura = idFactura;


        this.Fecha = fecha;

        this.Total = total;

        this.Cliente = cliente;

        this.Consulta = consulta;

        this.Farmaco = farmaco;

        this.Pagada = pagada;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FacturaEN t = obj as FacturaEN;
        if (t == null)
                return false;
        if (IdFactura.Equals (t.IdFactura))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdFactura.GetHashCode ();
        return hash;
}
}
}
