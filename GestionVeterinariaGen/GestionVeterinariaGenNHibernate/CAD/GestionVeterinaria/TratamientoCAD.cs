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

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> DameTratamientosPorConsulta (int id_consulta)
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TratamientoEN self where SELECT trat FROM TratamientoEN AS trat INNER JOIN trat.Consulta AS cons WHERE cons.IdConsulta=:id_consulta";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TratamientoENDameTratamientosPorConsultaHQL");
                query.SetParameter ("id_consulta", id_consulta);

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
}
}
