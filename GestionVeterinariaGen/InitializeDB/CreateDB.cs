
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

                IConsultaCAD _IConsultaCAD = new ConsultaCAD ();
                ConsultaCEN ConsultaCEN = new ConsultaCEN (_IConsultaCAD);

                #region Cliente
                ClienteCEN.New_ ("74669082A", "Hector", "Torregrosa Mas", "C/ San Jaime 12", "967378899", "Babel", "Alicante", "12356", null);
                ClienteCEN.New_ ("73286192B", "Cayetano", "Perez Perez", "Plaza de Castilla 25", "986123522", "Barranco", "Alicante", "08697", null);
                ClienteCEN.New_ ("65881341C", "Antonio", "Ferrandez Ruiz", "Paseo de la Castellana 60", "912326890", "Busot", "Alicante", "68901", null);
                ClienteCEN.New_ ("71243536D", "Maria", "Magallon Abad", "C/ San Pedro 13", "965807890", "Calpe", "Alicante", "10403", null);
                ClienteCEN.New_ ("70123560E", "Jesus", "Agusti Alamo", "Plaza de Espa�a 76", "92689765", "Denia", "Alicante", "00765", null);
                ClienteCEN.New_ ("66768970F", "Angel", "Garrido Alberola", "C/ San Juan 33", "95467321", "Casas Pontet", "Alicante", "65721", null);
                ClienteCEN.New_ ("23159083G", "Ulises", "Blanco Bou", "Av. de la vida 61", "965409911", "Ca�ada", "Alicante", "12047", null);
                ClienteCEN.New_ ("16608297H", "Michel", "Fajardo Esteve", "C/ Rue 13", "967608971", "El Alted", "Alicante", "06279", null);
                ClienteCEN.New_ ("55706082I", "Soraya", "Daza Egea", "Plaza de la Concordia", "976370203", "Rafal", "Alicante", "62701", null);
                ClienteCEN.New_ ("59273016J", "Estefania", "Espada Donoso", "C/ San Lucas 1", "910265763", "Pi�os", "Alicante", "52456", null);
                ClienteCEN.New_ ("37986297K", "Manuel", "Guzman Heredia", "Av. de la Estacion23", "937697201", "Sagra", "Alicante", "16273", null);
                ClienteCEN.New_ ("71620683L", "Dolores", "Fuertes Grande", "C/ San Pablo 90", "957463026", "Orito", "Alicante", "63826", null);
                ClienteCEN.New_ ("26837961M", "Carmina", "Losa Mayo", "C/ Santa Mar�a 45", "970865212", "Palanquetas", "Alicante", "12353", null);
                ClienteCEN.New_ ("10275637N", "Rafael", "Navas Ochoa", "C/ San Jose 14", "917260283", "Crevillent", "Alicante", "03330", null);
                ClienteCEN.New_ ("06275617O", "David", "Adan Pi", "Av. del Calvario 87", "916672782", "Ofra", "Alicante", "12728", null);


                #endregion

                #region Veterinario
                VeterinarioCEN.New_ ("2", "Alfonso", "Guerra Biologica", "C/ San Miguel 20", "966662222", "Ares", "Alicante", "02120", 1100, "2", 1);
                //VeterinarioCEN.New_("3", "Miguel Angel", "Martinez Perez", "C/ Barcelona 3", "966663333", "Algorfa", "Alicante", "03130", 1200, "c4ca4238a0b923820dcc509a6f75849b", 2);
                //VeterinarioCEN.New_("4", "Juan", "Aznar Padilla", "Av. de la libertad 50", "966664444", "Adsubia", "Alicante", "04140", 1300, "c4ca4238a0b923820dcc509a6f75849b", 3);
                #endregion

                #region Recepcionista
                RecepcionistaCEN.New_ ("1", "Juan", "Fernandez Gonzalez", "Plaza de Spain 1", "966661111", "Albir", "Alicante", "01110", 1000, "1");
                #endregion

                #region Mascota
                MascotaCEN.New_ ("0001", "Bestia", "Labrador", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 45, "Perro", new DateTime (2010, 1, 5), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "74669082A", "Blanco", true, "");
                MascotaCEN.New_ ("0002", "Chispa", "American Pit Bull Terrier", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 30, "Perro", new DateTime (2012, 10, 25), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "73286192B", "Negro con manchas marrones", true, "");
                MascotaCEN.New_ ("0003", "Misifu", "Siames", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 5, "Gato", new DateTime (2011, 3, 14), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.M, "65881341C", "Negro", false, "");
                MascotaCEN.New_ ("0004", "Turco", "American Stanford Terrier", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 40, "Perro", new DateTime (2008, 2, 9), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L, "71243536D", "Marron con el pecho blanco", true, "");
                MascotaCEN.New_ ("0005", "Bemol", "Ninfa", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 0.2f, "Loro", new DateTime (2012, 2, 9), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XS, "70123560E", "Gris", true, "");
                MascotaCEN.New_ ("0006", "Nina", "Fox Terrier", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 8, "Perro", new DateTime (2005, 10, 2), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "66768970F", "Blanco con manchas negras", false, "");
                MascotaCEN.New_ ("0007", "Bigotes", "Azul Ruso", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 4, "Gato", new DateTime (2010, 2, 28), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "23159083G", "Gris", true, "");
                MascotaCEN.New_ ("0008", "Rosca", "Boa Constrictor", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 25, "Serpiente", new DateTime (2001, 12, 21), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "16608297H", "Marron con pintas negras", false, "");
                MascotaCEN.New_ ("0009", "Comotu", "Indeterminada", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 5, "Perro", new DateTime (2010, 4, 15), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "55706082I", "Gris con manchas negras", true, "");
                MascotaCEN.New_ ("0010", "Golfo", "Akita", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 45, "Perro", new DateTime (2009, 9, 9), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "59273016J", "Anaranjado", true, "");
                MascotaCEN.New_ ("0011", "Afrodita", "Persa", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 5.5f, "Gato", new DateTime (2013, 10, 25), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "37986297K", "Blanco", true, "");
                MascotaCEN.New_ ("0012", "Zeus", "Rottweiler", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 55, "Perro", new DateTime (2012, 11, 1), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "71620683L", "Negro y marron", true, "");
                MascotaCEN.New_ ("0013", "Cabezon", "Labrador", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 40, "Perro", new DateTime (2012, 5, 29), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "26837961M", "Blanco", true, "");
                MascotaCEN.New_ ("0014", "Higo", "Bulldog Frances", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 10, "Perro", new DateTime (2011, 7, 18), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.M, "10275637N", "Negro", true, "");
                MascotaCEN.New_ ("0015", "Negrica", "Indeterminada", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 4, "Gato", new DateTime (2010, 9, 10), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "06275617O", "Negro", false, "");
                MascotaCEN.New_ ("0016", "Misho", "Siames", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 5, "Gato", new DateTime (2010, 2, 23), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "74669082A", "Negro", true, "");
                MascotaCEN.New_ ("0017", "Zorro", "Pastor Aleman", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 30, "Perro", new DateTime (2008, 12, 25), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L, "74669082A", "Marron y Negro", true, "");
                MascotaCEN.New_ ("0018", "Nikita", "Pastor Belga", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 27, "Perro", new DateTime (2009, 2, 21), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L, "73286192B", "Negro", true, "");
                MascotaCEN.New_ ("0019", "Brutus", "San Bernardo", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho, 70, "Perro", new DateTime (2005, 7, 13), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL, "65881341C", "Anaranjado", true, "");
                MascotaCEN.New_ ("0020", "Bella", "Siberiano", GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra, 6, "Gato", new DateTime (2014, 1, 2), GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S, "71243536D", "Pardo", true, "");
                #endregion

                #region Consulta
                //Id, Fecha, Hora, Motivo, Diagnostico, Mascota, Veter, Lugar
                //ConsultaCEN.New_ ("1", new DateTime (2014, 4, 20), new TimeSpan (17, 0, 0), "Dolor en la pata", "Pata rota", "0001", "2B", "Sala 1");
                //ConsultaCEN.New_ ("2", new DateTime (2014, 4, 19), new TimeSpan (20, 0, 0), "Mareos", "Contusion leve", "0002", "3C", "Sala 1");
                //ConsultaCEN.New_ ("3", new DateTime (2014, 4, 20), new TimeSpan (10, 0, 0), "Dolor abdominal", "Ingestion de quimicos", "0002", "4D", "Sala 2");
                //ConsultaCEN.New_("4", new DateTime(2014, 2, 21), new TimeSpan(17, 0, 0), "Picores", "Pulgas bajo el pelaje", "0004", "2B", "Sala 1");
                //ConsultaCEN.New_("5", new DateTime(2014, 2, 21), new TimeSpan(17, 0, 0), "Gastrointeritis", "Salmonelosis", "0005", "3C", "Sala 2");
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
