
using System;
using PracticaGrupoGenNHibernate.EN.Default_;

namespace PracticaGrupoGenNHibernate.CAD.Default_
{
public partial interface IUserCAD
{
UserEN ReadOIDDefault (string DNI);

UserEN LeerUsuarioPorOID (string DNI);
}
}
