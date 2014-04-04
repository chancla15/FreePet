
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
public partial class VeterinarioCAD : BasicCAD, IVeterinarioCAD
{
public VeterinarioCAD() : base ()
{
}

public VeterinarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public VeterinarioEN ReadOIDDefault (string DNI)
{
        VeterinarioEN veterinarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                veterinarioEN = (VeterinarioEN)session.Get (typeof(VeterinarioEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VeterinarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return veterinarioEN;
}


public string New_ (VeterinarioEN veterinario)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (veterinario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VeterinarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return veterinario.DNI;
}

public void Modify (VeterinarioEN veterinario)
{
        try
        {
                SessionInitializeTransaction ();
                VeterinarioEN veterinarioEN = (VeterinarioEN)session.Load (typeof(VeterinarioEN), veterinario.DNI);

                veterinarioEN.Nombre = veterinario.Nombre;


                veterinarioEN.Apellidos = veterinario.Apellidos;


                veterinarioEN.Direccion = veterinario.Direccion;


                veterinarioEN.Telefono = veterinario.Telefono;


                veterinarioEN.Localidad = veterinario.Localidad;


                veterinarioEN.Provincia = veterinario.Provincia;


                veterinarioEN.Cp = veterinario.Cp;


                veterinarioEN.IdEmpleado = veterinario.IdEmpleado;


                veterinarioEN.Sueldo = veterinario.Sueldo;


                veterinarioEN.Password = veterinario.Password;


                veterinarioEN.NumColegiado = veterinario.NumColegiado;

                session.Update (veterinarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VeterinarioCAD.", ex);
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
                VeterinarioEN veterinarioEN = (VeterinarioEN)session.Load (typeof(VeterinarioEN), DNI);
                session.Delete (veterinarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VeterinarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<VeterinarioEN> DameTodosLosVeterinarios (int first, int size)
{
        System.Collections.Generic.IList<VeterinarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(VeterinarioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<VeterinarioEN>();
                else
                        result = session.CreateCriteria (typeof(VeterinarioEN)).List<VeterinarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VeterinarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public VeterinarioEN DameVetarinarioPorOID (string DNI)
{
        VeterinarioEN veterinarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                veterinarioEN = (VeterinarioEN)session.Get (typeof(VeterinarioEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VeterinarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return veterinarioEN;
}

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> BuscarVetPorNombre (string busqueda)
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM VeterinarioEN self where FROM VeterinarioEN as u where u.Nombre like '%'+:busqueda+'%'";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("VeterinarioENbuscarVetPorNombreHQL");
                query.SetParameter ("busqueda", busqueda);

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VeterinarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> BuscarVetPorApellidos (string busqueda)
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM VeterinarioEN self where FROM VeterinarioEN as u where u.Apellidos like '%'+:busqueda+'%'";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("VeterinarioENbuscarVetPorApellidosHQL");
                query.SetParameter ("busqueda", busqueda);

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in VeterinarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
