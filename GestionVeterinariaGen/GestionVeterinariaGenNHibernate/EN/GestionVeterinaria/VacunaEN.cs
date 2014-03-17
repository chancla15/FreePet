
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class VacunaEN                   :                           GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN


{
/**
 *
 */

private string tipo;





public virtual string Tipo {
        get { return tipo; } set { tipo = value;  }
}





public VacunaEN() : base ()
{
}



public VacunaEN(string nombre, string tipo, string fecha, string duracion, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, float precio)
{
        this.init (nombre, tipo, fecha, duracion, consulta, precio);
}


public VacunaEN(VacunaEN vacuna)
{
        this.init (vacuna.Nombre, vacuna.Tipo, vacuna.Fecha, vacuna.Duracion, vacuna.Consulta, vacuna.Precio);
}

private void init (string nombre, string tipo, string fecha, string duracion, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, float precio)
{
        this.Nombre = nombre;


        this.Tipo = tipo;

        this.Fecha = fecha;

        this.Duracion = duracion;

        this.Consulta = consulta;

        this.Precio = precio;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        VacunaEN t = obj as VacunaEN;
        if (t == null)
                return false;
        if (Nombre.Equals (t.Nombre))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nombre.GetHashCode ();
        return hash;
}
}
}
