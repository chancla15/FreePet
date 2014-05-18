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
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;


namespace InitializeDB
{
class Program
{
static void Main (string[] args)
{
        System.Console.WriteLine ("-----------------------------------------------------------------------------");
        System.Console.WriteLine ("A new database called: GestionVeterinariaGenNHibernate will be created (the previous information will be deleted).");
        System.Console.WriteLine ("-----------------------------------------------------------------------------");
        System.Console.WriteLine ("Are you sure?(Y/N) ");
        String ans = Console.ReadLine ();
        try
        {
                if (ans.ToLower () == "y") {
                        CreateDB.Create ("GestionVeterinariaGenNHibernate", "nhibernateUser", "nhibernatePass");
                        var cfg = new Configuration ();
                        cfg.Configure ();
                        cfg.AddAssembly (typeof(UsuarioEN).Assembly);
                        new SchemaExport (cfg).Execute (true, true, false);
                        System.Console.WriteLine ("-----------------------------");
                        System.Console.WriteLine ("Database schema created successfully");
                        System.Console.WriteLine ("-----------------------------");
                }
                /*PROTECTED REGION ID(initializeData) ENABLED START*/
                System.Console.WriteLine ("-------------------------------------------------------");
                System.Console.Write ("Do you want to initialize the data of your database?(Y/N) ");
                ans = System.Console.ReadLine ();
                if (ans.ToLower () == "y") {
                        CreateDB.InitializeData ();
                        System.Console.WriteLine ("-----------------------------------------");
                        System.Console.WriteLine ("The data has been inserted successfully!!");
                        System.Console.WriteLine ("-----------------------------------------");
                }
                /*PROTECTED REGION END*/
        }
        catch (Exception e)
        {
                System.Console.WriteLine (e.Message.ToString () + '\n' + e.StackTrace);
        }

        finally
        {
                System.Console.WriteLine ("Powered by OOH4RIA. Press any key to exit....");
                Console.ReadLine ();
        }
}
}
}
