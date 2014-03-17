
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
public partial class FarmacoCAD : BasicCAD, IFarmacoCAD
{
public FarmacoCAD() : base ()
{
}

public FarmacoCAD(ISession sessionAux) : base (sessionAux)
{
}



public FarmacoEN ReadOIDDefault (string nombre)
{
        FarmacoEN farmacoEN = null;

        try
        {
                SessionInitializeTransaction ();
                farmacoEN = (FarmacoEN)session.Get (typeof(FarmacoEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in FarmacoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return farmacoEN;
}


public string New_ (FarmacoEN farmaco)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (farmaco);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in FarmacoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return farmaco.Nombre;
}

public void Modify (FarmacoEN farmaco)
{
        try
        {
                SessionInitializeTransaction ();
                FarmacoEN farmacoEN = (FarmacoEN)session.Load (typeof(FarmacoEN), farmaco.Nombre);

                farmacoEN.Fecha = farmaco.Fecha;


                farmacoEN.Duracion = farmaco.Duracion;


                farmacoEN.Precio = farmaco.Precio;


                farmacoEN.Cantidad = farmaco.Cantidad;


                farmacoEN.Frecuencia = farmaco.Frecuencia;

                session.Update (farmacoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in FarmacoCAD.", ex);
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
                FarmacoEN farmacoEN = (FarmacoEN)session.Load (typeof(FarmacoEN), nombre);
                session.Delete (farmacoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in FarmacoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<FarmacoEN> DameTodosLosFarmacos (int first, int size)
{
        System.Collections.Generic.IList<FarmacoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(FarmacoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<FarmacoEN>();
                else
                        result = session.CreateCriteria (typeof(FarmacoEN)).List<FarmacoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in FarmacoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public FarmacoEN DameFarmacoPorOID (string nombre)
{
        FarmacoEN farmacoEN = null;

        try
        {
                SessionInitializeTransaction ();
                farmacoEN = (FarmacoEN)session.Get (typeof(FarmacoEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in FarmacoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return farmacoEN;
}
}
}
