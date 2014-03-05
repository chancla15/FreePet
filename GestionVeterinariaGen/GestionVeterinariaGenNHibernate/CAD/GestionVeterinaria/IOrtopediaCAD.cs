
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IOrtopediaCAD
{
OrtopediaEN ReadOIDDefault (string nombre);

string New_ (OrtopediaEN ortopedia);

void Modify (OrtopediaEN ortopedia);


void Destroy (string nombre);


System.Collections.Generic.IList<OrtopediaEN> DameTodosOrtopedia (int first, int size);
}
}
