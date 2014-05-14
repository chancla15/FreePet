
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
public partial class EmpleadoCAD : BasicCAD, IEmpleadoCAD
{
public EmpleadoCAD() : base ()
{
}

public EmpleadoCAD(ISession sessionAux) : base (sessionAux)
{
}



public EmpleadoEN ReadOIDDefault (string DNI)
{
        EmpleadoEN empleadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                empleadoEN = (EmpleadoEN)session.Get (typeof(EmpleadoEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return empleadoEN;
}


public string New_ (EmpleadoEN empleado)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (empleado);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return empleado.DNI;
}

public void Modify (EmpleadoEN empleado)
{
        try
        {
                SessionInitializeTransaction ();
                EmpleadoEN empleadoEN = (EmpleadoEN)session.Load (typeof(EmpleadoEN), empleado.DNI);

                empleadoEN.Nombre = empleado.Nombre;


                empleadoEN.Apellidos = empleado.Apellidos;


                empleadoEN.Direccion = empleado.Direccion;


                empleadoEN.Telefono = empleado.Telefono;


                empleadoEN.Localidad = empleado.Localidad;


                empleadoEN.Provincia = empleado.Provincia;


                empleadoEN.Cp = empleado.Cp;


                empleadoEN.Sueldo = empleado.Sueldo;


                empleadoEN.Password = empleado.Password;

                session.Update (empleadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
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
                EmpleadoEN empleadoEN = (EmpleadoEN)session.Load (typeof(EmpleadoEN), DNI);
                session.Delete (empleadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public EmpleadoEN DameEmpleadoPorOID (string DNI)
{
        EmpleadoEN empleadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                empleadoEN = (EmpleadoEN)session.Get (typeof(EmpleadoEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return empleadoEN;
}

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN> DameTodosLosEmpleados ()
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EmpleadoEN self where SELECT c FROM EmpleadoEN AS c";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EmpleadoENdameTodosLosEmpleadosHQL");

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN> DameEmpleadoPorNombre (string busqueda)
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EmpleadoEN self where FROM EmpleadoEN  as u where u.Nombre like '%'+:busqueda+'%'";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EmpleadoENdameEmpleadoPorNombreHQL");
                query.SetParameter ("busqueda", busqueda);

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN> DameEmpleadoPorApellidos (string busqueda)
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EmpleadoEN self where FROM EmpleadoEN  as u where u.Apellidos like '%'+:busqueda+'%'";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EmpleadoENdameEmpleadoPorApellidosHQL");
                query.SetParameter ("busqueda", busqueda);

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.EmpleadoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
