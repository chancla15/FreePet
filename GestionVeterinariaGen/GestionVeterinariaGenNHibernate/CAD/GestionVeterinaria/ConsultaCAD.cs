
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



public ConsultaEN ReadOIDDefault (string IdConsulta)
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


public string New_ (ConsultaEN consulta)
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
                if (consulta.Factura != null) {
                        consulta.Factura = (GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN)session.Load (typeof(GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.FacturaEN), consulta.Factura.IdFactura);

                        consulta.Factura.Consulta = consulta;
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
public void Destroy (string IdConsulta)
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

public ConsultaEN DameConsultaPorOID (string IdConsulta)
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
