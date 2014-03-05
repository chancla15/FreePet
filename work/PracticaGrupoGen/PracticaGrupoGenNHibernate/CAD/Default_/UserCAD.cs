
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
public partial class UserCAD : BasicCAD, IUserCAD
{
public UserCAD() : base ()
{
}

public UserCAD(ISession sessionAux) : base (sessionAux)
{
}



public UserEN ReadOIDDefault (string DNI)
{
        UserEN userEN = null;

        try
        {
                SessionInitializeTransaction ();
                userEN = (UserEN)session.Get (typeof(UserEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return userEN;
}


public UserEN LeerUsuarioPorOID (string DNI)
{
        UserEN userEN = null;

        try
        {
                SessionInitializeTransaction ();
                userEN = (UserEN)session.Get (typeof(UserEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return userEN;
}
}
}
