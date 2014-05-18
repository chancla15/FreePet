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
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria
{
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public string New_ (string p_DNI, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.DNI = p_DNI;

        usuarioEN.Nombre = p_nombre;

        usuarioEN.Apellidos = p_apellidos;

        usuarioEN.Direccion = p_direccion;

        usuarioEN.Telefono = p_telefono;

        usuarioEN.Localidad = p_localidad;

        usuarioEN.Provincia = p_provincia;

        usuarioEN.Cp = p_cp;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.New_ (usuarioEN);
        return oid;
}

public void Modify (string p_Usuario_OID, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.DNI = p_Usuario_OID;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Apellidos = p_apellidos;
        usuarioEN.Direccion = p_direccion;
        usuarioEN.Telefono = p_telefono;
        usuarioEN.Localidad = p_localidad;
        usuarioEN.Provincia = p_provincia;
        usuarioEN.Cp = p_cp;
        //Call to UsuarioCAD

        _IUsuarioCAD.Modify (usuarioEN);
}

public void Destroy (string DNI)
{
        _IUsuarioCAD.Destroy (DNI);
}

public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.UsuarioEN> DameTodosLosUsuarios ()
{
        return _IUsuarioCAD.DameTodosLosUsuarios ();
}
public UsuarioEN DameUsuarioPorDNI (string DNI)
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.DameUsuarioPorDNI (DNI);
        return usuarioEN;
}
}
}
