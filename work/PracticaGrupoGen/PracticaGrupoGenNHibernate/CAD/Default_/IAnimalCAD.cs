
using System;
using PracticaGrupoGenNHibernate.EN.Default_;

namespace PracticaGrupoGenNHibernate.CAD.Default_
{
public partial interface IAnimalCAD
{
AnimalEN ReadOIDDefault (string microchip);

string Crear (AnimalEN animal);

void Modificar (AnimalEN animal);


void Borrar (string microchip);


AnimalEN LeerAnimalPorOID (string microchip);
}
}
