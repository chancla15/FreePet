

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
public partial class UserCEN
{
private IUserCAD _IUserCAD;

public UserCEN()
{
        this._IUserCAD = new UserCAD ();
}

public UserCEN(IUserCAD _IUserCAD)
{
        this._IUserCAD = _IUserCAD;
}

public IUserCAD get_IUserCAD ()
{
        return this._IUserCAD;
}

public UserEN LeerUsuarioPorOID (string DNI)
{
        UserEN userEN = null;

        userEN = _IUserCAD.LeerUsuarioPorOID (DNI);
        return userEN;
}
}
}
