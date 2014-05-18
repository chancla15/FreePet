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
public partial class EmpleadoCEN
{
public bool Login (string p_oid, String pass)
{
        /*PROTECTED REGION ID(GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria_Empleado_login) ENABLED START*/

        // Write here your custom code...

        //System.Console.WriteLine ("Login " + p_oid + " " + pass);
        try
        {
                EmpleadoEN en = _IEmpleadoCAD.ReadOIDDefault (p_oid);
                pass = Utils.Util.GetEncondeMD5 (pass);
                return(en.Password.Equals (pass));
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex);
                return false;
        }

        /*PROTECTED REGION END*/
}
}
}
