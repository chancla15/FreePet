
using System;
using PracticaGrupoGenNHibernate.EN.Default_;

namespace PracticaGrupoGenNHibernate.CAD.Default_
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (string DNI);

string Crear (ClienteEN cliente);

void Modificar (ClienteEN cliente);


void Borrar (string DNI);


void AnyadirAnimal (string p_cliente, string p_animal);

void QuitarAnimal (string p_cliente, string p_animal);
}
}
