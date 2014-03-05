

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using PracticaGrupoGenNHibernate.EN.Default_;
using PracticaGrupoGenNHibernate.CAD.Default_;

namespace PracticaGrupoGenNHibernate.CEN.Default_
{
public partial class EmployerCEN
{
private IEmployerCAD _IEmployerCAD;

public EmployerCEN()
{
        this._IEmployerCAD = new EmployerCAD ();
}

public EmployerCEN(IEmployerCAD _IEmployerCAD)
{
        this._IEmployerCAD = _IEmployerCAD;
}

public IEmployerCAD get_IEmployerCAD ()
{
        return this._IEmployerCAD;
}
}
}
