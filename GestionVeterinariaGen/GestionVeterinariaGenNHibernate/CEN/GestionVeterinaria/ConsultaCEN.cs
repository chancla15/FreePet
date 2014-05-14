

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

public int New_ (Nullable<DateTime> p_fecha, string p_motivoConsulta, string p_diagnostico, int p_mascota, string p_veterinario, System.Collections.Generic.IList<string> p_tratamiento, string p_lugar)
{
        ConsultaEN consultaEN = null;
        int oid;

        //Initialized ConsultaEN
        consultaEN = new ConsultaEN ();
        consultaEN.Fecha = p_fecha;

        consultaEN.MotivoConsulta = p_motivoConsulta;

        consultaEN.Diagnostico = p_diagnostico;


        if (p_mascota != -1) {
                consultaEN.Mascota = new GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN ();
                consultaEN.Mascota.IdMascota = p_mascota;
        }


        if (p_veterinario != null) {
                consultaEN.Veterinario = new GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN ();
                consultaEN.Veterinario.DNI = p_veterinario;
        }


        consultaEN.Tratamiento = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN>();
        if (p_tratamiento != null) {
                foreach (string item in p_tratamiento) {
                        GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN en = new GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN ();
                        en.Nombre = item;
                        consultaEN.Tratamiento.Add (en);
                }
        }

        else{
                consultaEN.Tratamiento = new System.Collections.Generic.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN>();
        }

        consultaEN.Lugar = p_lugar;

        //Call to ConsultaCAD

        oid = _IConsultaCAD.New_ (consultaEN);
        return oid;
}

public void Modify (int p_Consulta_OID, Nullable<DateTime> p_fecha, string p_motivoConsulta, string p_diagnostico, string p_lugar)
{
        ConsultaEN consultaEN = null;

        //Initialized ConsultaEN
        consultaEN = new ConsultaEN ();
        consultaEN.IdConsulta = p_Consulta_OID;
        consultaEN.Fecha = p_fecha;
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
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> BuscarConsultaPorFecha (Nullable<DateTime> fecha)
{
        return _IConsultaCAD.BuscarConsultaPorFecha (fecha);
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> DameVeterinariosPorFechayHora (Nullable<DateTime> fecha)
{
        return _IConsultaCAD.DameVeterinariosPorFechayHora (fecha);
}
public GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN DameConsultaPorVeterinarioYFecha (string vet, Nullable<DateTime> fecha)
{
        return _IConsultaCAD.DameConsultaPorVeterinarioYFecha (vet, fecha);
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> DameConsultaPorAnimal (int mascota)
{
        return _IConsultaCAD.DameConsultaPorAnimal (mascota);
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> DameConsultaPorFechaYHora (Nullable<DateTime> fecha)
{
        return _IConsultaCAD.DameConsultaPorFechaYHora (fecha);
}
}
}
