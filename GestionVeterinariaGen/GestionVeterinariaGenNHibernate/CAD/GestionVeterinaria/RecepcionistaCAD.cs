
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
public partial class RecepcionistaCAD : BasicCAD, IRecepcionistaCAD
{
public RecepcionistaCAD() : base ()
{
}

public RecepcionistaCAD(ISession sessionAux) : base (sessionAux)
{
}



public RecepcionistaEN ReadOIDDefault (string DNI)
{
        RecepcionistaEN recepcionistaEN = null;

        try
        {
                SessionInitializeTransaction ();
                recepcionistaEN = (RecepcionistaEN)session.Get (typeof(RecepcionistaEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in RecepcionistaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recepcionistaEN;
}


public string New_ (RecepcionistaEN recepcionista)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (recepcionista);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in RecepcionistaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recepcionista.DNI;
}

public void Modify (RecepcionistaEN recepcionista)
{
        try
        {
                SessionInitializeTransaction ();
                RecepcionistaEN recepcionistaEN = (RecepcionistaEN)session.Load (typeof(RecepcionistaEN), recepcionista.DNI);

                recepcionistaEN.Nombre = recepcionista.Nombre;


                recepcionistaEN.Apellidos = recepcionista.Apellidos;


                recepcionistaEN.Password = recepcionista.Password;


                recepcionistaEN.Direccion = recepcionista.Direccion;


                recepcionistaEN.Telefono = recepcionista.Telefono;


                recepcionistaEN.Localidad = recepcionista.Localidad;


                recepcionistaEN.Provincia = recepcionista.Provincia;


                recepcionistaEN.Cp = recepcionista.Cp;


                recepcionistaEN.IdEmpleado = recepcionista.IdEmpleado;


                recepcionistaEN.Sueldo = recepcionista.Sueldo;

                session.Update (recepcionistaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in RecepcionistaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string DNI)
{
        try
        {
                SessionInitializeTransaction ();
                RecepcionistaEN recepcionistaEN = (RecepcionistaEN)session.Load (typeof(RecepcionistaEN), DNI);
                session.Delete (recepcionistaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in RecepcionistaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<RecepcionistaEN> DameTodos (int first, int size)
{
        System.Collections.Generic.IList<RecepcionistaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RecepcionistaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RecepcionistaEN>();
                else
                        result = session.CreateCriteria (typeof(RecepcionistaEN)).List<RecepcionistaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in RecepcionistaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
