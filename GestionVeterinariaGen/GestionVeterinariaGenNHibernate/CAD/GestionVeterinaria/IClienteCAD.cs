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
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (string DNI);

string New_ (ClienteEN cliente);

void Modify (ClienteEN cliente);


void Destroy (string DNI);


ClienteEN DameClientePorOID (string DNI);


void AnyadirMascota (string p_Cliente_OID, System.Collections.Generic.IList<int> p_mascota_OIDs);

void QuitarMascota (string p_Cliente_OID, System.Collections.Generic.IList<int> p_mascota_OIDs);

System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN> BuscarClientePorNombre (string busqueda);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN> BuscarClientePorApellidos (string busqueda);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN> DameTodosLosClientes ();
}
}
