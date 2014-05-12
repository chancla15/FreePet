
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

                //IVacunaCAD _IVacunaCAD = new VacunaCAD ();
                //VacunaCEN VacunaCEN = new VacunaCEN (_IVacunaCAD);

                //IOrtopediaCAD _IOrtopediaCAD = new OrtopediaCAD ();
                //OrtopediaCEN OrtopediaCEN = new OrtopediaCEN (_IOrtopediaCAD);

                //IFarmacoCAD _IFarmacoCAD = new FarmacoCAD ();
                //FarmacoCEN FarmacoCEN = new FarmacoCEN (_IFarmacoCAD);


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
                VeterinarioCEN.New_ ("3", "Miguel Angel", "Martinez Perez", "C/ Barcelona 3", "966663333", "Algorfa", "Alicante", "03130", 1200, "c4ca4238a0b923820dcc509a6f75849b", 2);
                VeterinarioCEN.New_ ("4", "Juan", "Aznar Padilla", "Av. de la libertad 50", "966664444", "Adsubia", "Alicante", "04140", 1300, "c4ca4238a0b923820dcc509a6f75849b", 3);
                #endregion

                #region Recepcionista
                RecepcionistaCEN.New_ ("1", "Juan", "Fernandez Gonzalez", "Plaza de Spain 1", "966661111", "Albir", "Alicante", "01110", 1000, "1");
                #endregion

                #region Mascota
                MascotaCEN.New_ ("Bestia", "Labrador", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 45, "Perro", new DateTime (2010, 1, 5), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "74669082A", "Blanco", true, "");
                MascotaCEN.New_ ("Chispa", "American Pit Bull Terrier", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 30, "Perro", new DateTime (2012, 10, 25), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "73286192B", "Negro con manchas marrones", true, "");
                MascotaCEN.New_ ("Misifu", "Siames", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 5, "Gato", new DateTime (2011, 3, 14), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.M, "65881341C", "Negro", false, "");
                MascotaCEN.New_ ("Turco", "American Stanford Terrier", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 40, "Perro", new DateTime (2008, 2, 9), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L, "71243536D", "Marron con el pecho blanco", true, "");
                MascotaCEN.New_ ("Bemol", "Ninfa", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 0.2f, "Loro", new DateTime (2012, 2, 9), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XS, "70123560E", "Gris", true, "");
                MascotaCEN.New_ ("Nina", "Fox Terrier", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 8, "Perro", new DateTime (2005, 10, 2), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "66768970F", "Blanco con manchas negras", false, "");
                MascotaCEN.New_ ("Bigotes", "Azul Ruso", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 4, "Gato", new DateTime (2010, 2, 28), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "23159083G", "Gris", true, "");
                MascotaCEN.New_ ("Rosca", "Boa Constrictor", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 25, "Serpiente", new DateTime (2001, 12, 21), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "16608297H", "Marron con pintas negras", false, "");
                MascotaCEN.New_ ("Comotu", "Indeterminada", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 5, "Perro", new DateTime (2010, 4, 15), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "55706082I", "Gris con manchas negras", true, "");
                MascotaCEN.New_ ("Golfo", "Akita", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 45, "Perro", new DateTime (2009, 9, 9), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "59273016J", "Anaranjado", true, "");
                MascotaCEN.New_ ("Afrodita", "Persa", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 5.5f, "Gato", new DateTime (2013, 10, 25), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "37986297K", "Blanco", true, "");
                MascotaCEN.New_ ("Zeus", "Rottweiler", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 55, "Perro", new DateTime (2012, 11, 1), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "71620683L", "Negro y marron", true, "");
                MascotaCEN.New_ ("Cabezon", "Labrador", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 40, "Perro", new DateTime (2012, 5, 29), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "26837961M", "Blanco", true, "");
                MascotaCEN.New_ ("Higo", "Bulldog Frances", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 10, "Perro", new DateTime (2011, 7, 18), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.M, "10275637N", "Negro", true, "");
                MascotaCEN.New_ ("Negrica", "Indeterminada", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 4, "Gato", new DateTime (2010, 9, 10), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "06275617O", "Negro", false, "");
                MascotaCEN.New_ ("Misho", "Siames", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 5, "Gato", new DateTime (2010, 2, 23), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "74669082A", "Negro", true, "");
                MascotaCEN.New_ ("Zorro", "Pastor Aleman", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 30, "Perro", new DateTime (2008, 12, 25), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L, "74669082A", "Marron y Negro", true, "");
                MascotaCEN.New_ ("Nikita", "Pastor Belga", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 27, "Perro", new DateTime (2009, 2, 21), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L, "73286192B", "Negro", true, "");
                MascotaCEN.New_ ("Brutus", "San Bernardo", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 70, "Perro", new DateTime (2005, 7, 13), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "65881341C", "Anaranjado", true, "");
                MascotaCEN.New_ ("Bella", "Siberiano", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 6, "Gato", new DateTime (2014, 1, 2), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "71243536D", "Pardo", true, "");
                #endregion

                /*#region Vacuna
                 * VacunaEN v1 = new VacunaEN ();
                 * v1.Consulta = null;
                 * v1.FechaInicio = new DateTime (2014, 1, 2);
                 * v1.FechaFin = new DateTime (2014, 1, 10);
                 * v1.Nombre = "Parvovirosis";
                 * v1.Precio = 10;
                 * v1.Tipo = "Vial";
                 *
                 * VacunaEN v2 = new VacunaEN ();
                 * v2.Consulta = null;
                 * v2.FechaInicio = new DateTime (2014, 1, 2);
                 * v2.FechaFin = new DateTime (2014, 1, 10);
                 * v2.Nombre = "Rabia";
                 * v2.Precio = 15.5f;
                 * v2.Tipo = "Inyeccion";
                 *
                 * VacunaEN v3 = new VacunaEN ();
                 * v3.Consulta = null;
                 * v3.FechaInicio = new DateTime (2014, 1, 2);
                 * v3.FechaFin = new DateTime (2014, 1, 10);
                 * v3.Nombre = "Hepatits";
                 * v3.Precio = 5.5f;
                 * v3.Tipo = "Inyeccion";
                 *
                 * VacunaEN v4 = new VacunaEN ();
                 * v4.Consulta = null;
                 * v4.FechaInicio = new DateTime (2014, 1, 2);
                 * v4.FechaFin = new DateTime (2014, 1, 10);
                 * v4.Nombre = "Leptospirosis";
                 * v4.Precio = 12.9f;
                 * v4.Tipo = "Inyeccion";
                 *
                 * VacunaEN v5 = new VacunaEN ();
                 * v5.Consulta = null;
                 * v5.FechaInicio = new DateTime (2014, 1, 2);
                 * v5.FechaFin = new DateTime (2014, 1, 10);
                 * v5.Nombre = "Moquillo";
                 * v5.Precio = 8.5f;
                 * v5.Tipo = "Inyeccion";
                 *
                 * VacunaEN v6 = new VacunaEN ();
                 * v6.Consulta = null;
                 * v6.FechaInicio = new DateTime (2014, 1, 2);
                 * v6.FechaFin = new DateTime (2014, 1, 10);
                 * v6.Nombre = "Traqueobronquitis";
                 * v6.Precio = 10;
                 * v6.Tipo = "Inyeccion";
                 *
                 * VacunaEN v7 = new VacunaEN ();
                 * v7.Consulta = null;
                 * v7.FechaInicio = new DateTime (2014, 1, 2);
                 * v7.FechaFin = new DateTime (2014, 1, 10);
                 * v7.Nombre = "Piroplasmosis";
                 * v7.Precio = 13.5f;
                 * v7.Tipo = "Inyeccion";
                 *
                 * VacunaEN v8 = new VacunaEN ();
                 * v8.Consulta = null;
                 * v8.FechaInicio = new DateTime (2014, 1, 2);
                 * v8.FechaFin = new DateTime (2014, 1, 10);
                 * v8.Nombre = "Coronavirus";
                 * v8.Precio = 25.9f;
                 * v8.Tipo = "Inyeccion";
                 *
                 * VacunaCEN.New_ (v1.Nombre, v1.FechaInicio, v1.Precio, v1.FechaFin, v1.Tipo);
                 * VacunaCEN.New_ (v2.Nombre, v2.FechaInicio, v2.Precio, v2.FechaFin, v2.Tipo);
                 * VacunaCEN.New_ (v3.Nombre, v3.FechaInicio, v3.Precio, v3.FechaFin, v3.Tipo);
                 * VacunaCEN.New_ (v4.Nombre, v4.FechaInicio, v4.Precio, v4.FechaFin, v4.Tipo);
                 * VacunaCEN.New_ (v5.Nombre, v5.FechaInicio, v5.Precio, v5.FechaFin, v5.Tipo);
                 * VacunaCEN.New_ (v6.Nombre, v6.FechaInicio, v6.Precio, v6.FechaFin, v6.Tipo);
                 * VacunaCEN.New_ (v7.Nombre, v7.FechaInicio, v7.Precio, v7.FechaFin, v7.Tipo);
                 * VacunaCEN.New_ (v8.Nombre, v8.FechaInicio, v8.Precio, v8.FechaFin, v8.Tipo);
                 *
                 * #endregion
                 *
                 * #region Ortopedia
                 * OrtopediaEN o1 = new OrtopediaEN ();
                 * o1.Consulta = null;
                 * o1.FechaInicio = new DateTime (2014, 1, 2);
                 * o1.FechaFin = new DateTime (2014, 1, 10);
                 * o1.Nombre = "Escayolado";
                 * o1.Precio = 5;
                 * o1.Longitud = 1;
                 * o1.Talla = "S";
                 *
                 * OrtopediaCEN.New_ (o1.Nombre, o1.FechaInicio, o1.Precio, o1.FechaFin, o1.Talla, o1.Longitud);
                 *
                 * #endregion
                 *
                 * /*#region Farmaco
                 * FarmacoEN f1 = new FarmacoEN ();
                 * f1.Consulta = null;
                 * f1.FechaInicio = new DateTime (2014, 1, 2);
                 * f1.FechaFin = new DateTime (2014, 1, 10);
                 * f1.Nombre = "Analgesico";
                 * f1.Precio = 0.36f;
                 * f1.Cantidad = "10 Comprimido";
                 * f1.Frecuencia = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;
                 * f1.FechaCaducidad = new DateTime (2020, 1, 1);
                 *
                 * FarmacoEN f2 = new FarmacoEN ();
                 * f2.Consulta = null;
                 * f2.FechaInicio = new DateTime (2014, 1, 2);
                 * f2.FechaFin = new DateTime (2014, 1, 10);
                 * f2.Nombre = "Antiparasitario";
                 * f2.Precio = 22.73f;
                 * f2.Cantidad = "4 Pipetas";
                 * f2.Frecuencia = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;
                 * f2.FechaCaducidad = new DateTime (2020, 1, 1);
                 *
                 * FarmacoEN f3 = new FarmacoEN ();
                 * f3.Consulta = null;
                 * f3.FechaInicio = new DateTime (2014, 1, 2);
                 * f3.FechaFin = new DateTime (2014, 1, 10);
                 * f3.Nombre = "Antihemorragico";
                 * f3.Precio = 30.34f;
                 * f3.Cantidad = "5 x 20 ML";
                 * f3.Frecuencia = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;
                 * f3.FechaCaducidad = new DateTime (2020, 1, 1);
                 *
                 * FarmacoEN f4 = new FarmacoEN ();
                 * f4.Consulta = null;
                 * f4.FechaInicio = new DateTime (2014, 1, 2);
                 * f4.FechaFin = new DateTime (2014, 1, 10);
                 * f4.Nombre = "Otico";
                 * f4.Precio = 9.36f;
                 * f4.Cantidad = "125 ML";
                 * f4.Frecuencia = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;
                 * f4.FechaCaducidad = new DateTime (2020, 1, 1);
                 *
                 * FarmacoEN f5 = new FarmacoEN ();
                 * f5.Consulta = null;
                 * f5.FechaInicio = new DateTime (2014, 1, 2);
                 * f5.FechaFin = new DateTime (2014, 1, 10);
                 * f5.Nombre = "Antiprogestageno";
                 * f5.Precio = 53.63f;
                 * f5.Cantidad = "10 ML";
                 * f5.Frecuencia = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;
                 * f5.FechaCaducidad = new DateTime (2020, 1, 1);
                 *
                 * FarmacoEN f6 = new FarmacoEN ();
                 * f6.Consulta = null;
                 * f6.FechaInicio = new DateTime (2014, 1, 2);
                 * f6.FechaFin = new DateTime (2014, 1, 10);
                 * f6.Nombre = "Anticanceroso";
                 * f6.Precio = 47.70f;
                 * f6.Cantidad = "10 mg 20 Comprimidos";
                 * f6.Frecuencia = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;
                 * f6.FechaCaducidad = new DateTime (2020, 1, 1);
                 *
                 * FarmacoEN f7 = new FarmacoEN ();
                 * f7.Consulta = null;
                 * f7.FechaInicio = new DateTime (2014, 1, 2);
                 * f7.FechaFin = new DateTime (2014, 1, 10);
                 * f7.Nombre = "Digestivo";
                 * f7.Precio = 12.01f;
                 * f7.Cantidad = "16 mg 4 Comprimidos";
                 * f7.Frecuencia = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;
                 * f7.FechaCaducidad = new DateTime (2020, 1, 1);
                 *
                 * FarmacoEN f8 = new FarmacoEN ();
                 * f8.Consulta = null;
                 * f8.FechaInicio = new DateTime (2014, 1, 2);
                 * f8.FechaFin = new DateTime (2014, 1, 10);
                 * f8.Nombre = "Hepatico";
                 * f8.Precio = 37.93f;
                 * f8.Cantidad = "225 mg 30 Comprimidos";
                 * f8.Frecuencia = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.DosisEnum.Uno_al_dia;
                 * f8.FechaCaducidad = new DateTime (2020, 1, 1);
                 *
                 * FarmacoCEN.New_ (f1.Nombre, f1.FechaInicio, f1.Precio, f1.FechaFin, f1.Cantidad, f1.Frecuencia, f1.FechaCaducidad);
                 * FarmacoCEN.New_ (f2.Nombre, f2.FechaInicio, f2.Precio, f2.FechaFin, f2.Cantidad, f2.Frecuencia, f2.FechaCaducidad);
                 * FarmacoCEN.New_ (f3.Nombre, f3.FechaInicio, f3.Precio, f3.FechaFin, f3.Cantidad, f3.Frecuencia, f3.FechaCaducidad);
                 * FarmacoCEN.New_ (f4.Nombre, f4.FechaInicio, f4.Precio, f4.FechaFin, f4.Cantidad, f4.Frecuencia, f4.FechaCaducidad);
                 * FarmacoCEN.New_ (f5.Nombre, f5.FechaInicio, f5.Precio, f5.FechaFin, f5.Cantidad, f5.Frecuencia, f5.FechaCaducidad);
                 * FarmacoCEN.New_ (f6.Nombre, f6.FechaInicio, f6.Precio, f6.FechaFin, f6.Cantidad, f6.Frecuencia, f6.FechaCaducidad);
                 * FarmacoCEN.New_ (f7.Nombre, f7.FechaInicio, f7.Precio, f7.FechaFin, f7.Cantidad, f7.Frecuencia, f7.FechaCaducidad);
                 * FarmacoCEN.New_ (f8.Nombre, f8.FechaInicio, f8.Precio, f8.FechaFin, f8.Cantidad, f8.Frecuencia, f8.FechaCaducidad);
                 *
                 * #endregion
                 */
                #region Consulta
                //He modificado la relacion tratamiento - consulta era 0 * - 0 *
                //He tenido que añadir en FormConsultarecepcionistaController.cs en public void guardarCuadroInformacion() una cadena vacia dado que ahora hay un nuevo argumento en las consultas
                ConsultaEN c1 = new ConsultaEN ();
                c1.Diagnostico = "Pata rota";
                c1.Fecha = new DateTime (2014, 5, 5);
                c1.IdConsulta = 10;
                c1.Lugar = "Sala 1";
                c1.Mascota = new MascotaEN ();
                c1.Mascota.IdMascota = 1;
                c1.MotivoConsulta = "Dolor pata";
                //c1.Tratamiento = v1;
                c1.Veterinario = new VeterinarioEN ();
                c1.Veterinario.DNI = "2";

                ConsultaEN c2 = new ConsultaEN ();
                c2.Diagnostico = "Pulgas";
                c2.Fecha = new DateTime (2014, 7, 7);
                c2.IdConsulta = 10;
                c2.Lugar = "Sala 1";
                c2.Mascota = new MascotaEN ();
                c2.Mascota.IdMascota = 1;
                c2.MotivoConsulta = "Picores";
                //c2.Tratamiento = o1;
                c2.Veterinario = new VeterinarioEN ();
                c2.Veterinario.DNI = "2";

                //ConsultaCEN.New_ (c1.Fecha, c1.MotivoConsulta, c1.Diagnostico, c1.Mascota.IdMascota, c1.Veterinario.DNI, c1.Tratamiento.Nombre, c1.Lugar);
                //ConsultaCEN.New_ (c2.Fecha, c2.MotivoConsulta, c2.Diagnostico, c2.Mascota.IdMascota, c2.Veterinario.DNI, c2.Tratamiento.Nombre, c2.Lugar);

                #endregion

                #region Factura
                //FacturaCEN.New_ (new DateTime (2014, 3, 3), 30, "74669082A", c1, false);
                //FacturaCEN.New_ (new DateTime (2014, 4, 5), 20, "74669082A", c2, false);
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
