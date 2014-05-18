/* 
    FreePet. OpenSource Software Veterinarian Management
    Copyright (C) 2014  Jesus Manresa Parres

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
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


                recepcionistaEN.Direccion = recepcionista.Direccion;


                recepcionistaEN.Telefono = recepcionista.Telefono;


                recepcionistaEN.Localidad = recepcionista.Localidad;


                recepcionistaEN.Provincia = recepcionista.Provincia;


                recepcionistaEN.Cp = recepcionista.Cp;


                recepcionistaEN.Sueldo = recepcionista.Sueldo;


                recepcionistaEN.Password = recepcionista.Password;

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

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN> DameTodoLosRecepcionistas ()
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RecepcionistaEN self where FROM RecepcionistaEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RecepcionistaENdameTodoLosRecepcionistasHQL");

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN>();
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
public RecepcionistaEN BuscarRecepPorOID (string DNI)
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

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN> BuscarRecepPorNombre (string busqueda)
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RecepcionistaEN self where FROM RecepcionistaEN as u where u.Nombre like '%'+:busqueda+'%'";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RecepcionistaENbuscarRecepPorNombreHQL");
                query.SetParameter ("busqueda", busqueda);

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN>();
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
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN> BuscarRecepPorApellidos (string busqueda)
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RecepcionistaEN self where FROM RecepcionistaEN as u where u.Apellidos like '%'+:busqueda+'%'";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RecepcionistaENbuscarRecepPorApellidosHQL");
                query.SetParameter ("busqueda", busqueda);

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN>();
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
