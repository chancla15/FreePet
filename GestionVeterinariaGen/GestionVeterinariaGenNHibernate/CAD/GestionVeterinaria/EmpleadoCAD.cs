
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


                empleadoEN.Password = empleado.Password;


                empleadoEN.Direccion = empleado.Direccion;


                empleadoEN.Telefono = empleado.Telefono;


                empleadoEN.Localidad = empleado.Localidad;


                empleadoEN.Provincia = empleado.Provincia;


                empleadoEN.Cp = empleado.Cp;


                empleadoEN.IdEmpleado = empleado.IdEmpleado;


                empleadoEN.Sueldo = empleado.Sueldo;

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

public System.Collections.Generic.IList<EmpleadoEN> DameTodosLosEmpleados (int first, int size)
{
        System.Collections.Generic.IList<EmpleadoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(EmpleadoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<EmpleadoEN>();
                else
                        result = session.CreateCriteria (typeof(EmpleadoEN)).List<EmpleadoEN>();
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
