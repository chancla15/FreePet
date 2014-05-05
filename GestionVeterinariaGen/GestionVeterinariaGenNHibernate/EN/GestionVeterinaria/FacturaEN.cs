
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class FacturaEN
{
/**
 *
 */

private string idFactura;

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

private bool pagada;





public virtual string IdFactura {
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


public virtual bool Pagada {
        get { return pagada; } set { pagada = value;  }
}





public FacturaEN()
{
}



public FacturaEN(string idFactura, Nullable<DateTime> fecha, float total, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN cliente, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN consulta, bool pagada)
{
        this.init (idFactura, fecha, total, cliente, consulta, pagada);
}


public FacturaEN(FacturaEN factura)
{
        this.init (factura.IdFactura, factura.Fecha, factura.Total, factura.Cliente, factura.Consulta, factura.Pagada);
}

private void init (string idFactura, Nullable<DateTime> fecha, float total, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN cliente, GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN consulta, bool pagada)
{
        this.IdFactura = idFactura;


        this.Fecha = fecha;

        this.Total = total;

        this.Cliente = cliente;

        this.Consulta = consulta;

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
