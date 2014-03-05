
using System;
using System.Text;
using PracticaGrupoGenNHibernate.CEN.Default_;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PracticaGrupoGenNHibernate.EN.Default_;
using PracticaGrupoGenNHibernate.Exceptions;

namespace PracticaGrupoGenNHibernate.CAD.Default_
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
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in VeterinarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return veterinarioEN;
}


public string Crear (VeterinarioEN veterinario)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (veterinario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in VeterinarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return veterinario.DNI;
}

public void Modificar (VeterinarioEN veterinario)
{
        try
        {
                SessionInitializeTransaction ();
                VeterinarioEN veterinarioEN = (VeterinarioEN)session.Load (typeof(VeterinarioEN), veterinario.DNI);

                veterinarioEN.Num_colegiado = veterinario.Num_colegiado;


                veterinarioEN.Identifier = veterinario.Identifier;


                veterinarioEN.Name = veterinario.Name;


                veterinarioEN.Surname = veterinario.Surname;


                veterinarioEN.Password = veterinario.Password;


                veterinarioEN.Address = veterinario.Address;


                veterinarioEN.Phone = veterinario.Phone;

                session.Update (veterinarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in VeterinarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Borrar (string DNI)
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
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in VeterinarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
