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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using GestionVeterinariaGenNHibernate.Exceptions;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public class BasicCAD
{
protected ISession session;

protected bool sessionInside;

protected ITransaction tx;

protected BasicCAD()
{
        sessionInside = true;
}

protected BasicCAD(ISession sessionAux)
{
        session = sessionAux;
        sessionInside = false;
}

protected void SessionInitializeTransaction ()
{
        if (session == null) {
                session = NHibernateHelper.OpenSession ();
                tx = session.BeginTransaction ();
        }
}

protected void SessionCommit ()
{
        if (sessionInside && session != null)
                tx.Commit ();
}

protected void SessionRollBack ()
{
        if (sessionInside && session != null && session.IsOpen)
                tx.Rollback ();
}

protected void SessionClose ()
{
        if (sessionInside && session != null && session.IsOpen) {
                session.Close ();
                session.Dispose ();
                session = null;
        }
}
}
}
