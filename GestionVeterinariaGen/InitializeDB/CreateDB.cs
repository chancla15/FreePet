
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
                VeterinarioCEN.New_ ("2", "Alfonso", "Guerra Biologica", "C/ San Miguel 20", "966662222", "Ares", "Alicante", "02120", 1100, "c4ca4238a0b923820dcc509a6f75849b", 1);
                //VeterinarioCEN.New_("3", "Miguel Angel", "Martinez Perez", "C/ Barcelona 3", "966663333", "Algorfa", "Alicante", "03130", 1200, "c4ca4238a0b923820dcc509a6f75849b", 2);
                //VeterinarioCEN.New_("4", "Juan", "Aznar Padilla", "Av. de la libertad 50", "966664444", "Adsubia", "Alicante", "04140", 1300, "c4ca4238a0b923820dcc509a6f75849b", 3);
                #endregion

                #region Recepcionista
                //RecepcionistaCEN.New_("1", "Juan", "Fernandez Gonzalez", "Plaza de Espa�a 1", "966661111", "Albir", "Alicante", "01110", 1000, "c4ca4238a0b923820dcc509a6f75849b");
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
