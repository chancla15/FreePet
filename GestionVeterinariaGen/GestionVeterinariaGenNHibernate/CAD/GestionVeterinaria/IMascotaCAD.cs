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
public partial interface IMascotaCAD
{
MascotaEN ReadOIDDefault (int IdMascota);

int New_ (MascotaEN mascota);

void Modify (MascotaEN mascota);


void Destroy (int IdMascota);


MascotaEN BuscarMascotaPorOID (int IdMascota);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> DameTodasLasMascotas ();


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> DameMascotaPorNombre (string busqueda);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> ContadorMascotas ();


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> DameMascotaPorCliente (string nif);


GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN DameClientePorMascota (int id_msc);
}
}
