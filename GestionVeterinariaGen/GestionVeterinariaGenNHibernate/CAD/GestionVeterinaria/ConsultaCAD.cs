
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
                        consulta.Mascota = (GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN)session.Load (typeof(GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN), consulta.Mascota.IdMascota);

                        consulta.Mascota.Consulta.Add (consulta);
                }
                if (consulta.Veterinario != null) {
                        consulta.Veterinario = (GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN)session.Load (typeof(GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN), consulta.Veterinario.DNI);

                        consulta.Veterinario.Consulta.Add (consulta);
                }
                if (consulta.Tratamiento != null) {
                        consulta.Tratamiento = (GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN)session.Load (typeof(GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN), consulta.Tratamiento.Nombre);

                        consulta.Tratamiento.Consulta.Add (consulta);
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

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> BuscarConsultaPorFecha (Nullable<DateTime> fecha)
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConsultaEN self where FROM ConsultaEN c WHERE year(c.Fecha)=year(:fecha) AND month(c.Fecha)=month(:fecha) AND day(c.Fecha)=day(:fecha)";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConsultaENbuscarConsultaPorFechaHQL");
                query.SetParameter ("fecha", fecha);

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN>();
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
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> DameVeterinariosPorFechayHora (Nullable<DateTime> fecha)
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConsultaEN self where SELECT c.Veterinario FROM ConsultaEN as c WHERE year(c.Fecha)=year(:fecha) AND month(c.Fecha)=month(:fecha) AND day(c.Fecha)=day(:fecha) AND hour(c.Fecha)=hour(:fecha) AND minutes(c.Fecha)=(:fecha)";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConsultaENdameVeterinariosPorFechayHoraHQL");
                query.SetParameter ("fecha", fecha);

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN>();
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
public GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN DameConsultaPorVeterinarioYFecha (string vet, Nullable<DateTime> fecha)
{
        GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConsultaEN self where SELECT cli FROM ConsultaEN AS cli WHERE cli.Veterinario.DNI=:vet AND cli.Fecha=:fecha";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConsultaENdameConsultaPorVeterinarioYFechaHQL");
                query.SetParameter ("vet", vet);
                query.SetParameter ("fecha", fecha);


                result = query.UniqueResult<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN>();
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
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> DameConsultaPorAnimal (int mascota)
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConsultaEN self where SELECT c FROM ConsultaEN AS c WHERE c.Mascota.IdMascota=:mascota";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConsultaENdameConsultaPorAnimalHQL");
                query.SetParameter ("mascota", mascota);

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN>();
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
