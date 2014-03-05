

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
public partial class ConsultaCEN
{
private IConsultaCAD _IConsultaCAD;

public ConsultaCEN()
{
        this._IConsultaCAD = new ConsultaCAD ();
}

public ConsultaCEN(IConsultaCAD _IConsultaCAD)
{
        this._IConsultaCAD = _IConsultaCAD;
}

public IConsultaCAD get_IConsultaCAD ()
{
        return this._IConsultaCAD;
}

public int New_ (Nullable<DateTime> p_fecha, TimeSpan p_hora, string p_motivoConsulta, string p_diagnostico, System.Collections.Generic.IList<int> p_mascota, string p_veterinario, string p_lugar)
{
        ConsultaEN consultaEN = null;
        int oid;

        //Initialized ConsultaEN
        consultaEN = new ConsultaEN ();
        consultaEN.Fecha = p_fecha;

        consultaEN.Hora = p_hora;

        consultaEN.MotivoConsulta = p_motivoConsulta;

        consultaEN.Diagnostico = p_diagnostico;


        consultaEN.Mascota = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN>();
        if (p_mascota != null) {
                foreach (int item in p_mascota) {
                        GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN en = new GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN ();
                        en.IdMascota = item;
                        consultaEN.Mascota.Add (en);
                }
        }

        else{
                consultaEN.Mascota = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN>();
        }


        if (p_veterinario != null) {
                consultaEN.Veterinario = new GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN ();
                consultaEN.Veterinario.DNI = p_veterinario;
        }

        consultaEN.Lugar = p_lugar;

        //Call to ConsultaCAD

        oid = _IConsultaCAD.New_ (consultaEN);
        return oid;
}

public void Modify (int p_Consulta_OID, Nullable<DateTime> p_fecha, TimeSpan p_hora, string p_motivoConsulta, string p_diagnostico, string p_lugar)
{
        ConsultaEN consultaEN = null;

        //Initialized ConsultaEN
        consultaEN = new ConsultaEN ();
        consultaEN.IdConsulta = p_Consulta_OID;
        consultaEN.Fecha = p_fecha;
        consultaEN.Hora = p_hora;
        consultaEN.MotivoConsulta = p_motivoConsulta;
        consultaEN.Diagnostico = p_diagnostico;
        consultaEN.Lugar = p_lugar;
        //Call to ConsultaCAD

        _IConsultaCAD.Modify (consultaEN);
}

public void Destroy (int IdConsulta)
{
        _IConsultaCAD.Destroy (IdConsulta);
}

public ConsultaEN DameConsultaPorOID (int IdConsulta)
{
        ConsultaEN consultaEN = null;

        consultaEN = _IConsultaCAD.DameConsultaPorOID (IdConsulta);
        return consultaEN;
}

public System.Collections.Generic.IList<ConsultaEN> DameTodasLasConsultas (int first, int size)
{
        System.Collections.Generic.IList<ConsultaEN> list = null;

        list = _IConsultaCAD.DameTodasLasConsultas (first, size);
        return list;
}
}
}
