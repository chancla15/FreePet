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

/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;
using System.Collections;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\SQLEXPRESS; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                IRecepcionistaCAD _IRecepcionistaCAD = new RecepcionistaCAD ();
                RecepcionistaCEN RecepcionistaCEN = new RecepcionistaCEN (_IRecepcionistaCAD);

                IClienteCAD _IClienteCAD = new ClienteCAD ();
                ClienteCEN ClienteCEN = new ClienteCEN (_IClienteCAD);

                IVeterinarioCAD _IVeterinarioCAD = new VeterinarioCAD ();
                VeterinarioCEN VeterinarioCEN = new VeterinarioCEN (_IVeterinarioCAD);

                IMascotaCAD _IMascotaCAD = new MascotaCAD ();
                MascotaCEN MascotaCEN = new MascotaCEN (_IMascotaCAD);

                IAdministradorCAD _IAdministradorCAD = new AdministradorCAD ();
                AdministradorCEN AdministradorCEN = new AdministradorCEN (_IAdministradorCAD);

                IConsultaCAD _IConsultaCAD = new ConsultaCAD ();
                ConsultaCEN ConsultaCEN = new ConsultaCEN (_IConsultaCAD);

                IFacturaCAD _IFacturaCAD = new FacturaCAD ();
                FacturaCEN FacturaCEN = new FacturaCEN (_IFacturaCAD);

                ITratamientoCAD _ITratamiendoCAD = new TratamientoCAD ();
                TratamientoCEN TratamientoCEN = new TratamientoCEN (_ITratamiendoCAD);

                #region Administrador
                AdministradorCEN.New_ ("admin", "adminNombre", "adminApellidos", "adminDireccion", "adminTelefono", "adminLocalidad", "adminProvincia", "adminCp", 9999, "admin");
                #endregion

                #region Cliente
                ClienteCEN.New_ ("74669082A", "Hector", "Torregrosa Mas", "C/ San Jaime 12", "967378899", "Babel", "Alicante", "12356", null);
                ClienteCEN.New_ ("73286192B", "Cayetano", "Perez Perez", "Plaza de Castilla 25", "986123522", "Barranco", "Alicante", "08697", null);
                ClienteCEN.New_ ("65881341C", "Antonio", "Ferrandez Ruiz", "Paseo de la Castellana 60", "912326890", "Busot", "Alicante", "68901", null);
                ClienteCEN.New_ ("71243536D", "Maria", "Magallon Abad", "C/ San Pedro 13", "965807890", "Calpe", "Alicante", "10403", null);
                ClienteCEN.New_ ("70123560E", "Jesus", "Agusti Alamo", "Plaza de España 76", "92689765", "Denia", "Alicante", "00765", null);
                ClienteCEN.New_ ("66768970F", "Angel", "Garrido Alberola", "C/ San Juan 33", "95467321", "Casas Pontet", "Alicante", "65721", null);
                ClienteCEN.New_ ("23159083G", "Ulises", "Blanco Bou", "Av. de la vida 61", "965409911", "Ca�ada", "Alicante", "12047", null);
                ClienteCEN.New_ ("16608297H", "Michel", "Fajardo Esteve", "C/ Rue 13", "967608971", "El Alted", "Alicante", "06279", null);
                ClienteCEN.New_ ("55706082I", "Soraya", "Daza Egea", "Plaza de la Concordia", "976370203", "Rafal", "Alicante", "62701", null);
                ClienteCEN.New_ ("59273016J", "Estefania", "Espada Donoso", "C/ San Lucas 1", "910265763", "Pi�os", "Alicante", "52456", null);
                ClienteCEN.New_ ("37986297K", "Manuel", "Guzman Heredia", "Av. de la Estacion23", "937697201", "Sagra", "Alicante", "16273", null);
                ClienteCEN.New_ ("71620683L", "Dolores", "Fuertes Grande", "C/ San Pablo 90", "957463026", "Orito", "Alicante", "63826", null);
                ClienteCEN.New_ ("26837961M", "Carmina", "Losa Mayo", "C/ Santa María 45", "970865212", "Palanquetas", "Alicante", "12353", null);
                ClienteCEN.New_ ("10275637N", "Rafael", "Navas Ochoa", "C/ San Jose 14", "917260283", "Crevillent", "Alicante", "03330", null);
                ClienteCEN.New_ ("06275617O", "David", "Adan Pi", "Av. del Calvario 87", "916672782", "Ofra", "Alicante", "12728", null);


                #endregion

                #region Veterinario
                VeterinarioCEN.New_ ("2", "Alfonso", "Guerra Biologica", "C/ San Miguel 20", "966662222", "Ares", "Alicante", "02120", 1100, "2", 1);
                VeterinarioCEN.New_ ("3", "Miguel Angel", "Martinez Perez", "C/ Barcelona 3", "966663333", "Algorfa", "Alicante", "03130", 1200, "3", 2);
                VeterinarioCEN.New_ ("4", "Juan", "Aznar Padilla", "Av. de la libertad 50", "966664444", "Adsubia", "Alicante", "04140", 1300, "4", 3);
                #endregion

                #region Recepcionista
                RecepcionistaCEN.New_ ("1", "Juan", "Fernandez Gonzalez", "Plaza de Spain 1", "966661111", "Albir", "Alicante", "01110", 1000, "1");
                #endregion

                #region Mascota
                MascotaCEN.New_ ("Bestia", "Labrador", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 45, "Perro", new DateTime (2010, 1, 5), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "74669082A", "Blanco", true);
                MascotaCEN.New_ ("Chispa", "American Pit Bull Terrier", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 30, "Perro", new DateTime (2012, 10, 25), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "73286192B", "Negro con manchas marrones", true);
                MascotaCEN.New_ ("Misifu", "Siames", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 5, "Gato", new DateTime (2011, 3, 14), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.M, "65881341C", "Negro", false);
                MascotaCEN.New_ ("Turco", "American Stanford Terrier", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 40, "Perro", new DateTime (2008, 2, 9), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L, "71243536D", "Marron con el pecho blanco", true);
                MascotaCEN.New_ ("Bemol", "Ninfa", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 0.2f, "Loro", new DateTime (2012, 2, 9), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XS, "70123560E", "Gris", true);
                MascotaCEN.New_ ("Nina", "Fox Terrier", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 8, "Perro", new DateTime (2005, 10, 2), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "66768970F", "Blanco con manchas negras", false);
                MascotaCEN.New_ ("Bigotes", "Azul Ruso", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 4, "Gato", new DateTime (2010, 2, 28), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "23159083G", "Gris", true);
                MascotaCEN.New_ ("Rosca", "Boa Constrictor", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 25, "Serpiente", new DateTime (2001, 12, 21), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "16608297H", "Marron con pintas negras", false);
                MascotaCEN.New_ ("Comotu", "Indeterminada", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 5, "Perro", new DateTime (2010, 4, 15), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "55706082I", "Gris con manchas negras", true);
                MascotaCEN.New_ ("Golfo", "Akita", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 45, "Perro", new DateTime (2009, 9, 9), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "59273016J", "Anaranjado", true);
                MascotaCEN.New_ ("Afrodita", "Persa", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 5.5f, "Gato", new DateTime (2013, 10, 25), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "37986297K", "Blanco", true);
                MascotaCEN.New_ ("Zeus", "Rottweiler", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 55, "Perro", new DateTime (2012, 11, 1), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "71620683L", "Negro y marron", true);
                MascotaCEN.New_ ("Cabezon", "Labrador", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 40, "Perro", new DateTime (2012, 5, 29), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "26837961M", "Blanco", true);
                MascotaCEN.New_ ("Higo", "Bulldog Frances", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 10, "Perro", new DateTime (2011, 7, 18), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.M, "10275637N", "Negro", true);
                MascotaCEN.New_ ("Negrica", "Indeterminada", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 4, "Gato", new DateTime (2010, 9, 10), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "06275617O", "Negro", false);
                MascotaCEN.New_ ("Misho", "Siames", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 5, "Gato", new DateTime (2010, 2, 23), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "74669082A", "Negro", true);
                MascotaCEN.New_ ("Zorro", "Pastor Aleman", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 30, "Perro", new DateTime (2008, 12, 25), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L, "74669082A", "Marron y Negro", true);
                MascotaCEN.New_ ("Nikita", "Pastor Belga", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 27, "Perro", new DateTime (2009, 2, 21), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L, "73286192B", "Negro", true);
                MascotaCEN.New_ ("Brutus", "San Bernardo", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 70, "Perro", new DateTime (2005, 7, 13), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "65881341C", "Anaranjado", true);
                MascotaCEN.New_ ("Bella", "Siberiano", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 6, "Gato", new DateTime (2014, 1, 2), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "71243536D", "Pardo", true);
                #endregion

                #region Tratamientos

                TratamientoEN t1 = new TratamientoEN ();
                t1.Consulta = null;
                t1.Nombre = "Anti Parvovirus";
                t1.Precio = 10;
                t1.Descripcion = "NOBIVAC PARVO-C. Caja con 10 frascos de una dosis";
                t1.Stock = 20;
                t1.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                TratamientoEN t2 = new TratamientoEN ();
                t2.Consulta = null;
                t2.Nombre = "Antirrabico";
                t2.Precio = 15.5f;
                t2.Descripcion = "VACUNA ANTIRRABICA MERIEUX. 1 vial + 1 jeringa sin aguja";
                t2.Stock = 20;
                t2.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                TratamientoEN t3 = new TratamientoEN ();
                t3.Consulta = null;
                t3.Nombre = "Antimoquillo";
                t3.Precio = 30.9f;
                t3.Descripcion = "Canigen MHA2. Caja con 10 dosis";
                t3.Stock = 20;
                t3.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                TratamientoEN t4 = new TratamientoEN ();
                t4.Consulta = null;
                t4.Nombre = "Antihepatitis";
                t4.Precio = 30.5f;
                t4.Descripcion = "Antibioticos, soluciones isotonicas, protectores hepaticos y una dieta hipoproteica";
                t4.Stock = 20;
                t4.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                TratamientoEN t5 = new TratamientoEN();
                t5.Consulta = null;
                t5.Nombre = "Antileptospirosis";
                t5.Precio = 15.8f;
                t5.Descripcion = "Frasco con 200 ml. Inyectable";
                t5.Stock = 20;
                t5.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                TratamientoEN t6 = new TratamientoEN();
                t6.Consulta = null;
                t6.Nombre = "Escayolado";
                t6.Precio = 5;
                t6.Descripcion = "Escayolado de 50 cm";
                t6.Stock = 20;
                t6.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                TratamientoEN t7 = new TratamientoEN();
                t7.Consulta = null;
                t7.Nombre = "Castracion";
                t7.Precio = 20.93f;
                t7.Descripcion = "Para que no haya camadas indeseadas";
                t7.Stock = 20;
                t7.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                TratamientoEN t8 = new TratamientoEN();
                t8.Consulta = null;
                t8.Nombre = "Anticoronavirus";
                t8.Precio = 35.75f;
                t8.Descripcion = "Antibiotico CONVENIA 800mg.";
                t8.Stock = 20;
                t8.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                TratamientoEN t9 = new TratamientoEN();
                t9.Consulta = null;
                t9.Nombre = "Antiinflamatorio";
                t9.Precio = 19.99f;
                t9.Descripcion = "Acicor. 6 frascos de 10 ml. Inyectable.";
                t9.Stock = 20;
                t9.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                TratamientoEN t10 = new TratamientoEN();
                t10.Consulta = null;
                t10.Nombre = "Antidiarreico";
                t10.Precio = 39.23f;
                t10.Descripcion = "Antidiarreico Ganafort 100ml. Inyectable.";
                t10.Stock = 20;
                t10.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                TratamientoEN t11 = new TratamientoEN();
                t11.Consulta = null;
                t11.Nombre = "Antiparasitario externo";
                t11.Precio = 5.95f;
                t11.Descripcion = "Collar antiparasitario 50 cm.";
                t11.Stock = 20;
                t11.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                TratamientoEN t12 = new TratamientoEN();
                t12.Consulta = null;
                t12.Nombre = "Antiparasitario interno";
                t12.Precio = 22.59f;
                t12.Descripcion = "Antiparasitario interno TOTAL EG. Comprimidos, oral.";
                t12.Stock = 20;
                t12.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                TratamientoEN t13 = new TratamientoEN();
                t13.Consulta = null;
                t13.Nombre = "Desinfectante";
                t13.Precio = 40.99f;
                t13.Descripcion = "Delegolo Vet. 1 litro. Ambientes.";
                t13.Stock = 20;
                t13.Dosis_diaria = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;

                    
            
                        


                TratamientoCEN.New_ (t1.Nombre, t1.Precio, t1.Descripcion, t1.Stock, t1.Dosis_diaria);
                TratamientoCEN.New_ (t2.Nombre, t2.Precio, t2.Descripcion, t2.Stock, t2.Dosis_diaria);
                TratamientoCEN.New_ (t3.Nombre, t3.Precio, t3.Descripcion, t3.Stock, t3.Dosis_diaria);
                TratamientoCEN.New_(t4.Nombre, t4.Precio, t4.Descripcion, t4.Stock, t4.Dosis_diaria);
                TratamientoCEN.New_(t5.Nombre, t5.Precio, t5.Descripcion, t5.Stock, t5.Dosis_diaria);
                TratamientoCEN.New_(t6.Nombre, t6.Precio, t6.Descripcion, t6.Stock, t6.Dosis_diaria);
                TratamientoCEN.New_(t7.Nombre, t7.Precio, t7.Descripcion, t7.Stock, t7.Dosis_diaria);
                TratamientoCEN.New_(t8.Nombre, t8.Precio, t8.Descripcion, t8.Stock, t8.Dosis_diaria);
                TratamientoCEN.New_(t9.Nombre, t9.Precio, t9.Descripcion, t9.Stock, t5.Dosis_diaria);
                TratamientoCEN.New_(t10.Nombre, t10.Precio, t10.Descripcion, t10.Stock, t10.Dosis_diaria);
                TratamientoCEN.New_(t11.Nombre, t11.Precio, t11.Descripcion, t11.Stock, t11.Dosis_diaria);
                TratamientoCEN.New_(t12.Nombre, t12.Precio, t12.Descripcion, t12.Stock, t12.Dosis_diaria);
                TratamientoCEN.New_(t13.Nombre, t13.Precio, t13.Descripcion, t13.Stock, t13.Dosis_diaria);
            
                #endregion

                #region Consulta
                //He modificado la relacion tratamiento - consulta era 0 * - 0 *
                //He tenido que añadir en FormConsultarecepcionistaController.cs en public void guardarCuadroInformacion() una cadena vacia dado que ahora hay un nuevo argumento en las consultas
                ConsultaEN c1 = new ConsultaEN ();
                c1.Diagnostico = "Pata rota";
                c1.Fecha = new DateTime (2014, 5, 19, 10, 30, 00);
                c1.IdConsulta = 10;
                c1.Lugar = "Sala 1";
                c1.Mascota = new MascotaEN ();
                c1.Mascota.IdMascota = 1;
                c1.MotivoConsulta = "Dolor pata";
                c1.Tratamiento = null;
                c1.Veterinario = new VeterinarioEN ();
                c1.Veterinario.DNI = "2";

                ConsultaEN c2 = new ConsultaEN ();
                c2.Diagnostico = "Pulgas";
                c2.Fecha = new DateTime (2014, 5, 20, 12, 0, 0);
                c2.IdConsulta = 10;
                c2.Lugar = "Sala 1";
                c2.Mascota = new MascotaEN ();
                c2.Mascota.IdMascota = 1;
                c2.MotivoConsulta = "Picores";
                c2.Tratamiento = null;
                c2.Veterinario = new VeterinarioEN ();
                c2.Veterinario.DNI = "2";

                ConsultaEN c3 = new ConsultaEN ();
                c3.Diagnostico = "Rabia";
                c3.Fecha = new DateTime (2014, 5, 20, 10, 30, 00);
                c3.IdConsulta = 10;
                c3.Lugar = "Sala 2";
                c3.Mascota = new MascotaEN ();
                c3.Mascota.IdMascota = 1;
                c3.MotivoConsulta = "Espuma por la boca";
                c3.Tratamiento = null;
                c3.Veterinario = new VeterinarioEN ();
                c3.Veterinario.DNI = "3";

                ConsultaEN c4 = new ConsultaEN ();
                c4.Diagnostico = "Hepatitis B";
                c4.Fecha = new DateTime (2014, 5, 21, 11, 00, 00);
                c4.IdConsulta = 10;
                c4.Lugar = "Sala 2";
                c4.Mascota = new MascotaEN ();
                c4.Mascota.IdMascota = 1;
                c4.MotivoConsulta = "Diarrea y vomitos";
                c4.Tratamiento = null;
                c4.Veterinario = new VeterinarioEN ();
                c4.Veterinario.DNI = "4";

                int oid_c1 = ConsultaCEN.New_ (c1.MotivoConsulta, c1.Diagnostico, c1.Mascota.IdMascota, c1.Veterinario.DNI, c1.Lugar, c1.Fecha);
                ConsultaCEN.New_ (c2.MotivoConsulta, c2.Diagnostico, c2.Mascota.IdMascota, c2.Veterinario.DNI, c2.Lugar, c2.Fecha);
                ConsultaCEN.New_ (c3.MotivoConsulta, c3.Diagnostico, c3.Mascota.IdMascota, c3.Veterinario.DNI, c3.Lugar, c3.Fecha);
                ConsultaCEN.New_ (c4.MotivoConsulta, c4.Diagnostico, c4.Mascota.IdMascota, c4.Veterinario.DNI, c4.Lugar, c4.Fecha);


                //Metientro tratamientos a una consultas

                /*IList<TratamientoEN> lista = TratamientoCEN.DameTodosLosTratamientos ();
                IList<string> oids = new List<string>();

                if (lista != null) {
                        for (int i = 0; i < lista.Count; i++)
                                oids.Add (lista [i].Nombre);
                        ConsultaCEN.AnaydirTratamiento (oid_c1, oids);
                }*/
                #endregion

                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
