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
public partial class MascotaCAD : BasicCAD, IMascotaCAD
{
public MascotaCAD() : base ()
{
}

public MascotaCAD(ISession sessionAux) : base (sessionAux)
{
}



public MascotaEN ReadOIDDefault (int IdMascota)
{
        MascotaEN mascotaEN = null;

        try
        {
                SessionInitializeTransaction ();
                mascotaEN = (MascotaEN)session.Get (typeof(MascotaEN), IdMascota);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in MascotaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mascotaEN;
}


public int New_ (MascotaEN mascota)
{
        try
        {
                SessionInitializeTransaction ();
                if (mascota.Cliente != null) {
                        mascota.Cliente = (GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN)session.Load (typeof(GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN), mascota.Cliente.DNI);

                        mascota.Cliente.Mascota.Add (mascota);
                }

                session.Save (mascota);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in MascotaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mascota.IdMascota;
}

public void Modify (MascotaEN mascota)
{
        try
        {
                SessionInitializeTransaction ();
                MascotaEN mascotaEN = (MascotaEN)session.Load (typeof(MascotaEN), mascota.IdMascota);

                mascotaEN.Nombre = mascota.Nombre;


                mascotaEN.Raza = mascota.Raza;


                mascotaEN.Sexo = mascota.Sexo;


                mascotaEN.Peso = mascota.Peso;


                mascotaEN.Especie = mascota.Especie;


                mascotaEN.FNacimiento = mascota.FNacimiento;


                mascotaEN.Tamanyo = mascota.Tamanyo;


                mascotaEN.Color = mascota.Color;


                mascotaEN.Microchip = mascota.Microchip;

                session.Update (mascotaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in MascotaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int IdMascota)
{
        try
        {
                SessionInitializeTransaction ();
                MascotaEN mascotaEN = (MascotaEN)session.Load (typeof(MascotaEN), IdMascota);
                session.Delete (mascotaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in MascotaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public MascotaEN BuscarMascotaPorOID (int IdMascota)
{
        MascotaEN mascotaEN = null;

        try
        {
                SessionInitializeTransaction ();
                mascotaEN = (MascotaEN)session.Get (typeof(MascotaEN), IdMascota);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in MascotaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mascotaEN;
}

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> DameTodasLasMascotas ()
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MascotaEN self where FROM MascotaEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MascotaENdameTodasLasMascotasHQL");

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in MascotaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> DameMascotaPorNombre (string busqueda)
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MascotaEN self where FROM MascotaEN m WHERE m.Nombre like '%'+:busqueda+'%' ";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MascotaENdameMascotaPorNombreHQL");
                query.SetParameter ("busqueda", busqueda);

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in MascotaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> ContadorMascotas ()
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MascotaEN self where FROM MascotaEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MascotaENcontadorMascotasHQL");

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in MascotaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> DameMascotaPorCliente (string nif)
{
        System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MascotaEN self where FROM MascotaEN m WHERE m.Cliente.DNI=:nif";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MascotaENDameMascotaPorClienteHQL");
                query.SetParameter ("nif", nif);

                result = query.List<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in MascotaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN DameClientePorMascota (int id_msc)
{
        GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MascotaEN self where SELECT msc.Cliente FROM MascotaEN AS msc WHERE msc.IdMascota=:id_msc";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MascotaENDameClientePorMascotaHQL");
                query.SetParameter ("id_msc", id_msc);


                result = query.UniqueResult<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionVeterinariaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new GestionVeterinariaGenNHibernate.Exceptions.DataLayerException ("Error in MascotaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
