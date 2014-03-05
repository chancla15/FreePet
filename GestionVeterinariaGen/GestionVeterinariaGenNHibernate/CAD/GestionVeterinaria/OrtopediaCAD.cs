
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
public partial class OrtopediaCAD : BasicCAD, IOrtopediaCAD
{
public OrtopediaCAD() : base ()
{
}

public OrtopediaCAD(ISession sessionAux) : base (sessionAux)
{
}



public OrtopediaEN ReadOIDDefault (string nombre)
{
        OrtopediaEN ortopediaEN = null;

        try
        {
                SessionInitializeTransaction ();
                ortopediaEN = (OrtopediaEN)session.Get (typeof(OrtopediaEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in OrtopediaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ortopediaEN;
}


public string New_ (OrtopediaEN ortopedia)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (ortopedia);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in OrtopediaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ortopedia.Nombre;
}

public void Modify (OrtopediaEN ortopedia)
{
        try
        {
                SessionInitializeTransaction ();
                OrtopediaEN ortopediaEN = (OrtopediaEN)session.Load (typeof(OrtopediaEN), ortopedia.Nombre);

                ortopediaEN.Fecha = ortopedia.Fecha;


                ortopediaEN.Duracion = ortopedia.Duracion;


                ortopediaEN.Precio = ortopedia.Precio;


                ortopediaEN.Talla = ortopedia.Talla;


                ortopediaEN.Longitud = ortopedia.Longitud;

                session.Update (ortopediaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in OrtopediaCAD.", ex);
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
                OrtopediaEN ortopediaEN = (OrtopediaEN)session.Load (typeof(OrtopediaEN), nombre);
                session.Delete (ortopediaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in OrtopediaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<OrtopediaEN> DameTodosOrtopedia (int first, int size)
{
        System.Collections.Generic.IList<OrtopediaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(OrtopediaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<OrtopediaEN>();
                else
                        result = session.CreateCriteria (typeof(OrtopediaEN)).List<OrtopediaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in OrtopediaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
