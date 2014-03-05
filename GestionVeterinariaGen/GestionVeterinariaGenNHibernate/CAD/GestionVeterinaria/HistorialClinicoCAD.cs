
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
public partial class HistorialClinicoCAD : BasicCAD, IHistorialClinicoCAD
{
public HistorialClinicoCAD() : base ()
{
}

public HistorialClinicoCAD(ISession sessionAux) : base (sessionAux)
{
}



public HistorialClinicoEN ReadOIDDefault (int numero)
{
        HistorialClinicoEN historialClinicoEN = null;

        try
        {
                SessionInitializeTransaction ();
                historialClinicoEN = (HistorialClinicoEN)session.Get (typeof(HistorialClinicoEN), numero);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in HistorialClinicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return historialClinicoEN;
}


public HistorialClinicoEN ConsultarHistorialPorOID (int numero)
{
        HistorialClinicoEN historialClinicoEN = null;

        try
        {
                SessionInitializeTransaction ();
                historialClinicoEN = (HistorialClinicoEN)session.Get (typeof(HistorialClinicoEN), numero);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in HistorialClinicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return historialClinicoEN;
}

public int New_ (HistorialClinicoEN historialClinico)
{
        try
        {
                SessionInitializeTransaction ();
                if (historialClinico.Mascota != null) {
                        historialClinico.Mascota = (GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN)session.Load (typeof(GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN), historialClinico.Mascota.IdMascota);

                        historialClinico.Mascota.HistorialClinico = historialClinico;
                }

                session.Save (historialClinico);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in HistorialClinicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return historialClinico.Numero;
}

public void Modify (HistorialClinicoEN historialClinico)
{
        try
        {
                SessionInitializeTransaction ();
                HistorialClinicoEN historialClinicoEN = (HistorialClinicoEN)session.Load (typeof(HistorialClinicoEN), historialClinico.Numero);
                session.Update (historialClinicoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in HistorialClinicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int numero)
{
        try
        {
                SessionInitializeTransaction ();
                HistorialClinicoEN historialClinicoEN = (HistorialClinicoEN)session.Load (typeof(HistorialClinicoEN), numero);
                session.Delete (historialClinicoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in HistorialClinicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
