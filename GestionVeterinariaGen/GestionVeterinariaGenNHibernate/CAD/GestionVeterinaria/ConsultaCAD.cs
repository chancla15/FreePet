
using System;
using System.Text;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.Exceptions;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial class ConsultaCAD : BasicCAD, IConsultaCAD
{
public ConsultaCAD() : base ()
{
}

public ConsultaCAD(ISession sessionAux) : base (sessionAux)
{
}



public ConsultaEN ReadOIDDefault (int IdConsulta)
{
        ConsultaEN consultaEN = null;

        try
        {
                SessionInitializeTransaction ();
                consultaEN = (ConsultaEN)session.Get (typeof(ConsultaEN), IdConsulta);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in ConsultaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return consultaEN;
}


public int New_ (ConsultaEN consulta)
{
        try
        {
                SessionInitializeTransaction ();
                if (consulta.Mascota != null) {
                        for (int i = 0; i < consulta.Mascota.Count; i++) {
                                consulta.Mascota [i] = (GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN)session.Load (typeof(GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN), consulta.Mascota [i].IdMascota);
                                consulta.Mascota [i].Consulta.Add (consulta);
                        }
                }
                if (consulta.Veterinario != null) {
                        consulta.Veterinario = (GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN)session.Load (typeof(GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN), consulta.Veterinario.DNI);

                        consulta.Veterinario.Consulta.Add (consulta);
                }

                session.Save (consulta);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in ConsultaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return consulta.IdConsulta;
}

public void Modify (ConsultaEN consulta)
{
        try
        {
                SessionInitializeTransaction ();
                ConsultaEN consultaEN = (ConsultaEN)session.Load (typeof(ConsultaEN), consulta.IdConsulta);

                consultaEN.Fecha = consulta.Fecha;


                consultaEN.Hora = consulta.Hora;


                consultaEN.MotivoConsulta = consulta.MotivoConsulta;


                consultaEN.Diagnostico = consulta.Diagnostico;


                consultaEN.Lugar = consulta.Lugar;

                session.Update (consultaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in ConsultaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int IdConsulta)
{
        try
        {
                SessionInitializeTransaction ();
                ConsultaEN consultaEN = (ConsultaEN)session.Load (typeof(ConsultaEN), IdConsulta);
                session.Delete (consultaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in ConsultaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public ConsultaEN DameConsultaPorOID (int IdConsulta)
{
        ConsultaEN consultaEN = null;

        try
        {
                SessionInitializeTransaction ();
                consultaEN = (ConsultaEN)session.Get (typeof(ConsultaEN), IdConsulta);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in ConsultaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return consultaEN;
}

public System.Collections.Generic.IList<ConsultaEN> DameTodasLasConsultas (int first, int size)
{
        System.Collections.Generic.IList<ConsultaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ConsultaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ConsultaEN>();
                else
                        result = session.CreateCriteria (typeof(ConsultaEN)).List<ConsultaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in ConsultaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
