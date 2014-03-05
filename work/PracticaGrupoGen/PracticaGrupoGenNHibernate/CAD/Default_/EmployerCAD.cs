
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
public partial class EmployerCAD : BasicCAD, IEmployerCAD
{
public EmployerCAD() : base ()
{
}

public EmployerCAD(ISession sessionAux) : base (sessionAux)
{
}



public EmployerEN ReadOIDDefault (string DNI)
{
        EmployerEN employerEN = null;

        try
        {
                SessionInitializeTransaction ();
                employerEN = (EmployerEN)session.Get (typeof(EmployerEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in EmployerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return employerEN;
}
}
}
