
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



public MascotaEN ReadOIDDefault (string IdMascota)
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


public string New_ (MascotaEN mascota)
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


                mascotaEN.Foto = mascota.Foto;

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
public void Destroy (string IdMascota)
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

public MascotaEN BuscarMascotaPorOID (string IdMascota)
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

public System.Collections.Generic.IList<MascotaEN> DameTodasLasMascotas (int first, int size)
{
        System.Collections.Generic.IList<MascotaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MascotaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<MascotaEN>();
                else
                        result = session.CreateCriteria (typeof(MascotaEN)).List<MascotaEN>();
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
}
}
