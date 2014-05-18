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

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> DameTodosLosVeterinarios ()
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM VeterinarioEN self where FROM VeterinarioEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("VeterinarioENdameTodosLosVeterinariosHQL");

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
public GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN BuscarPorNombreYApellidos (string name, string surname)
{
        GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM VeterinarioEN self where SELECT cli FROM VeterinarioEN AS cli WHERE cli.Nombre=:name AND cli.Apellidos=:surname";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("VeterinarioENbuscarPorNombreYApellidosHQL");
                query.SetParameter ("name", name);
                query.SetParameter ("surname", surname);


                result = query.UniqueResult<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN>();
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
