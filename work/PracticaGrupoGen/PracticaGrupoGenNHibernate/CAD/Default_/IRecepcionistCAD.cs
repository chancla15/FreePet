
using System;
using PracticaGrupoGenNHibernate.EN.Default_;

namespace PracticaGrupoGenNHibernate.CAD.Default_
{
public partial interface IRecepcionistCAD
{
RecepcionistEN ReadOIDDefault (string DNI);

string Crear (RecepcionistEN recepcionist);

void Modificar (RecepcionistEN recepcionist);


void Borrar (string DNI);
}
}
