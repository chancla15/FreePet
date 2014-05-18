/* 
    FreePet. OpenSource Software Veterinarian Management
    Copyright (C) 2014  Jesus Manresa Parres

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IVeterinarioCAD
{
VeterinarioEN ReadOIDDefault (string DNI);

string New_ (VeterinarioEN veterinario);

void Modify (VeterinarioEN veterinario);


void Destroy (string DNI);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> DameTodosLosVeterinarios ();


VeterinarioEN DameVetarinarioPorOID (string DNI);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> BuscarVetPorNombre (string busqueda);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN> BuscarVetPorApellidos (string busqueda);


GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.VeterinarioEN BuscarPorNombreYApellidos (string name, string surname);
}
}
