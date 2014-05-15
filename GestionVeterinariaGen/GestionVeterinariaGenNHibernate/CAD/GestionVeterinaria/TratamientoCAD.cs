
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
public partial class TratamientoCAD : BasicCAD, ITratamientoCAD
{
public TratamientoCAD() : base ()
{
}

public TratamientoCAD(ISession sessionAux) : base (sessionAux)
{
}



public TratamientoEN ReadOIDDefault (string nombre)
{
        TratamientoEN tratamientoEN = null;

        try
        {
                SessionInitializeTransaction ();
                tratamientoEN = (TratamientoEN)session.Get (typeof(TratamientoEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in TratamientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tratamientoEN;
}


public string New_ (TratamientoEN tratamiento)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (tratamiento);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in TratamientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tratamiento.Nombre;
}

public void Modify (TratamientoEN tratamiento)
{
        try
        {
                SessionInitializeTransaction ();
                TratamientoEN tratamientoEN = (TratamientoEN)session.Load (typeof(TratamientoEN), tratamiento.Nombre);

                tratamientoEN.Precio = tratamiento.Precio;


                tratamientoEN.Descripcion = tratamiento.Descripcion;


                tratamientoEN.Stock = tratamiento.Stock;


                tratamientoEN.Dosis_diaria = tratamiento.Dosis_diaria;

                session.Update (tratamientoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in TratamientoCAD.", ex);
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
                TratamientoEN tratamientoEN = (TratamientoEN)session.Load (typeof(TratamientoEN), nombre);
                session.Delete (tratamientoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in TratamientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> DameTodosLosTratamientos ()
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TratamientoEN self where FROM TratamientoEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TratamientoENdameTodosLosTratamientosHQL");

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in TratamientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public TratamientoEN DameTratamientoPorOID (string nombre)
{
        TratamientoEN tratamientoEN = null;

        try
        {
                SessionInitializeTransaction ();
                tratamientoEN = (TratamientoEN)session.Get (typeof(TratamientoEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in TratamientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tratamientoEN;
}
}
}
