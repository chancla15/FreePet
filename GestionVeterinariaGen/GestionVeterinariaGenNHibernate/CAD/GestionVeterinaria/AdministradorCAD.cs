
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
public partial class AdministradorCAD : BasicCAD, IAdministradorCAD
{
public AdministradorCAD() : base ()
{
}

public AdministradorCAD(ISession sessionAux) : base (sessionAux)
{
}



public AdministradorEN ReadOIDDefault (string DNI)
{
        AdministradorEN administradorEN = null;

        try
        {
                SessionInitializeTransaction ();
                administradorEN = (AdministradorEN)session.Get (typeof(AdministradorEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in AdministradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return administradorEN;
}


public string New_ (AdministradorEN administrador)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (administrador);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in AdministradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return administrador.DNI;
}

public void Modify (AdministradorEN administrador)
{
        try
        {
                SessionInitializeTransaction ();
                AdministradorEN administradorEN = (AdministradorEN)session.Load (typeof(AdministradorEN), administrador.DNI);

                administradorEN.Nombre = administrador.Nombre;


                administradorEN.Apellidos = administrador.Apellidos;


                administradorEN.Direccion = administrador.Direccion;


                administradorEN.Telefono = administrador.Telefono;


                administradorEN.Localidad = administrador.Localidad;


                administradorEN.Provincia = administrador.Provincia;


                administradorEN.Cp = administrador.Cp;


                administradorEN.Password = administrador.Password;

                session.Update (administradorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in AdministradorCAD.", ex);
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
                AdministradorEN administradorEN = (AdministradorEN)session.Load (typeof(AdministradorEN), DNI);
                session.Delete (administradorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in AdministradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.AdministradorEN IsAdmin (string nif, string pass)
{
        GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.AdministradorEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AdministradorEN self where SELECT admin FROM AdministradorEN AS admin WHERE admin.DNI=:nif AND admin.Password=:pass";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AdministradorENisAdminHQL");
                query.SetParameter ("nif", nif);
                query.SetParameter ("pass", pass);


                result = query.UniqueResult<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.AdministradorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in AdministradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
