
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
public partial class VacunaCAD : BasicCAD, IVacunaCAD
{
public VacunaCAD() : base ()
{
}

public VacunaCAD(ISession sessionAux) : base (sessionAux)
{
}



public VacunaEN ReadOIDDefault (string nombre)
{
        VacunaEN vacunaEN = null;

        try
        {
                SessionInitializeTransaction ();
                vacunaEN = (VacunaEN)session.Get (typeof(VacunaEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VacunaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return vacunaEN;
}


public string New_ (VacunaEN vacuna)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (vacuna);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VacunaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return vacuna.Nombre;
}

public void Modify (VacunaEN vacuna)
{
        try
        {
                SessionInitializeTransaction ();
                VacunaEN vacunaEN = (VacunaEN)session.Load (typeof(VacunaEN), vacuna.Nombre);

                vacunaEN.FechaInicio = vacuna.FechaInicio;


                vacunaEN.Precio = vacuna.Precio;


                vacunaEN.FechaFin = vacuna.FechaFin;


                vacunaEN.Tipo = vacuna.Tipo;

                session.Update (vacunaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VacunaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string nombre)
{
        try
        {
                SessionInitializeTransaction ();
                VacunaEN vacunaEN = (VacunaEN)session.Load (typeof(VacunaEN), nombre);
                session.Delete (vacunaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VacunaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<VacunaEN> DameTodasLasVacunas (int first, int size)
{
        System.Collections.Generic.IList<VacunaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(VacunaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<VacunaEN>();
                else
                        result = session.CreateCriteria (typeof(VacunaEN)).List<VacunaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VacunaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public VacunaEN DameVacunaPorOID (string nombre)
{
        VacunaEN vacunaEN = null;

        try
        {
                SessionInitializeTransaction ();
                vacunaEN = (VacunaEN)session.Get (typeof(VacunaEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VacunaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return vacunaEN;
}
}
}
