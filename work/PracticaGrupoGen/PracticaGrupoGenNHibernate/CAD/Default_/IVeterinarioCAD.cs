
using System;
using PracticaGrupoGenNHibernate.EN.Default_;

namespace PracticaGrupoGenNHibernate.CAD.Default_
{
public partial interface IVeterinarioCAD
{
VeterinarioEN ReadOIDDefault (string DNI);

string Crear (VeterinarioEN veterinario);

void Modificar (VeterinarioEN veterinario);


void Borrar (string DNI);
}
}
