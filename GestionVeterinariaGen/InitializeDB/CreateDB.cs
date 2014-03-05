
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;

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
                IClienteCAD _IClienteCAD = new ClienteCAD ();
                ClienteEN cliente1EN, cliente2EN;
                ClienteCEN clienteCEN = new ClienteCEN (_IClienteCAD);
                IUsuarioCAD _IUsuarioCAD = new UsuarioCAD ();
                UsuarioEN usuario1EN, usuario2EN;
                UsuarioCEN usuarioCEN = new UsuarioCEN (_IUsuarioCAD);
                IMascotaCAD _IMascotaCAD = new MascotaCAD ();
                MascotaEN mascota1EN, mascota2EN = new MascotaEN();
                MascotaCEN mascotaCEN = new MascotaCEN (_IMascotaCAD);
                IFacturaCAD _IFacturaCAD = new FacturaCAD();
                FacturaEN factura1EN, factura2EN;
                FacturaCEN facturaCEN = new FacturaCEN(_IFacturaCAD);
                IConsultaCAD _IConsultaCAD = new ConsultaCAD();
                ConsultaEN consulta1EN = new ConsultaEN();
                ConsultaEN consulta2EN = new ConsultaEN();
                ConsultaCEN consultaCEN = new ConsultaCEN(_IConsultaCAD);

                #region Cliente
                //FALTA LA FACTURA Y LA MASCOTA EN LOS 2 CLIENTES
                cliente1EN = new ClienteEN ();
                cliente1EN.Nombre = "cliente1Nombre";
                cliente1EN.Apellidos = "cliente1Apellidos";
                cliente1EN.DNI = "11111111A";
                cliente1EN.Direccion = "cliente1Direccion";
                cliente1EN.Localidad = "cliente1Localidad";
                cliente1EN.Cp = "01234";
                cliente1EN.Provincia = "cliente1Provincia";
                cliente1EN.Telefono = "cliente1Telefono";
                cliente1EN.Password = "cliente1Password";
                //cliente1EN.Mascota[0] = mascota1EN; // PRUEBA
                clienteCEN.New_ (cliente1EN.DNI, cliente1EN.Nombre, cliente1EN.Apellidos, cliente1EN.Password, cliente1EN.Direccion, cliente1EN.Telefono, cliente1EN.Localidad, cliente1EN.Provincia, cliente1EN.Cp);
                //clienteCEN.AnyadirMascota(cliente1EN.DNI, ); ?????

                cliente2EN = new ClienteEN ();
                cliente2EN.Nombre = "cliente2Nombre";
                cliente2EN.Apellidos = "cliente2Apellidos";
                cliente2EN.DNI = "22222222A";
                cliente2EN.Direccion = "cliente2Direccion";
                cliente2EN.Localidad = "cliente2Localidad";
                cliente2EN.Cp = "01234";
                cliente2EN.Provincia = "cliente2Provincia";
                cliente2EN.Telefono = "cliente2Telefono";
                cliente2EN.Password = "cliente2Password";
                clienteCEN.New_ (cliente2EN.DNI, cliente2EN.Nombre, cliente2EN.Apellidos, cliente2EN.Password, cliente2EN.Direccion, cliente2EN.Telefono, cliente2EN.Localidad, cliente2EN.Provincia, cliente2EN.Cp);


                #endregion

                #region Usuario
                //NI IDEA DE COMO RELLENAR CON HERENCIA, DEJO ESTO COMO PRUEBA
                usuario1EN = new UsuarioEN (cliente1EN);
                usuarioCEN.New_ (cliente1EN.DNI, cliente1EN.Nombre, cliente1EN.Apellidos, cliente1EN.Password, cliente1EN.Direccion, cliente1EN.Telefono, cliente1EN.Localidad, cliente1EN.Provincia, cliente1EN.Cp);

                usuario2EN = new UsuarioEN (cliente2EN);
                usuarioCEN.New_ (cliente2EN.DNI, cliente2EN.Nombre, cliente2EN.Apellidos, cliente2EN.Password, cliente2EN.Direccion, cliente2EN.Telefono, cliente2EN.Localidad, cliente2EN.Provincia, cliente2EN.Cp);


                #endregion

                #region Mascota
                //EL HISTORIALCLINICO NO ESTA
                mascota1EN = new MascotaEN ();
                mascota1EN.Cliente = cliente1EN; //COMO ES TIPO OBJETO HE PUESTO UN OBJETO CLIENTE PERO NI IDEA :S
                mascota1EN.IdMascota = 1;
                mascota1EN.Nombre = "mascota1Nombre";
                mascota1EN.Raza = "mascota1Raza";
                mascota1EN.Sexo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho;
                mascota1EN.Peso = 1;
                mascota1EN.Especie = "mascota1Especie";
                mascota1EN.FNacimiento = new DateTime (1, 1, 1);
                mascota1EN.Tamanyo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L;
                mascota1EN.Color = "mascota1Color";
                mascota1EN.Microchip = true;
                mascota1EN.Foto = "mascota1Foto";
                mascotaCEN.New_(mascota1EN.Nombre, mascota1EN.Raza, mascota1EN.Sexo, mascota1EN.Peso, mascota1EN.Especie, mascota1EN.FNacimiento, mascota1EN.Tamanyo, cliente1EN.DNI, mascota1EN.Color, mascota1EN.Microchip, mascota1EN.Foto);
                //EN EL NEW EN EL PARAMETRO CLIENTE HE PUESTO EL DNI DEL CLIENTE1 PERO ENTONCES DE QUE SIRVE EL CAMPO MASCOTA1EN.CLIENTE¿?
               
                mascota2EN = new MascotaEN();
                mascota2EN.Cliente = cliente2EN;
                mascota2EN.IdMascota = 2;
                mascota2EN.Nombre = "mascota2Nombre";
                mascota2EN.Raza = "mascota2Raza";
                mascota2EN.Sexo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho;
                mascota2EN.Peso = 2;
                mascota2EN.Especie = "mascota2Especie";
                mascota2EN.FNacimiento = new DateTime(2, 2, 2);
                mascota2EN.Tamanyo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L;
                mascota2EN.Color = "mascota2Color";
                mascota2EN.Microchip = true;
                mascota2EN.Foto = "mascota2Foto";
                mascotaCEN.New_(mascota2EN.Nombre, mascota2EN.Raza, mascota2EN.Sexo, mascota2EN.Peso, mascota2EN.Especie, mascota2EN.FNacimiento, mascota2EN.Tamanyo, cliente2EN.DNI, mascota2EN.Color, mascota2EN.Microchip, mascota2EN.Foto);
               
                #endregion

                #region Factura
                //FALTAN PARAMETROS, LOS DE LAS RELACIONES
                factura1EN = new FacturaEN();
                factura1EN.IdFactura = 1;
                factura1EN.Fecha = new DateTime(1, 1, 1);
                factura1EN.Total = 1;
                factura1EN.Pagada = true;
                facturaCEN.New_(factura1EN.Fecha, factura1EN.Total, cliente1EN.DNI, consulta1EN.IdConsulta, factura1EN.Pagada);
                
                factura2EN = new FacturaEN();
                factura2EN.IdFactura = 2;
                factura2EN.Fecha = new DateTime(2, 2, 2);
                factura2EN.Total = 2;
                factura2EN.Pagada = true;
                facturaCEN.New_(factura2EN.Fecha, factura2EN.Total, cliente2EN.DNI, consulta2EN.IdConsulta, factura2EN.Pagada);
                
                

                #endregion

                #region Consulta
                consulta1EN = new ConsultaEN();
                consulta1EN.IdConsulta = 1;
                consulta1EN.Fecha = new DateTime(1, 1, 1);
                consulta1EN.Hora = new TimeSpan(1, 1, 1);
                consulta1EN.MotivoConsulta = "consulta1Motivo";
                consulta1EN.Diagnostico = "consulta1Diagnostico";
                consulta1EN.Lugar = "consulta1Lugar";
                consultaCEN.New_(consulta1EN.Fecha, consulta1EN.Hora, consulta1EN.MotivoConsulta, consulta1EN.Diagnostico, new List<int>(mascota1EN.IdMascota), "poner veterinario", consulta1EN.Lugar);

                consulta2EN = new ConsultaEN();
                consulta2EN.IdConsulta = 2;
                consulta2EN.Fecha = new DateTime(2, 2, 2);
                consulta2EN.Hora = new TimeSpan(2, 2, 2);
                consulta2EN.MotivoConsulta = "consulta2Motivo";
                consulta2EN.Diagnostico = "consulta2Diagnostico";
                consulta2EN.Lugar = "consulta2Lugar";
                consultaCEN.New_(consulta2EN.Fecha, consulta2EN.Hora, consulta2EN.MotivoConsulta, consulta2EN.Diagnostico, new List<int>(mascota2EN.IdMascota), "poner veterinario", consulta2EN.Lugar);

                #endregion
            /*List<GestionVeterinariaGenNHibernate.EN.Mediaplayer.MusicTrackEN> musicTracks = new List<GestionVeterinariaGenNHibernate.EN.Mediaplayer.MusicTrackEN>();
                 * GestionVeterinariaGenNHibernate.EN.Mediaplayer.UserEN userEN = new GestionVeterinariaGenNHibernate.EN.Mediaplayer.UserEN();
                 * GestionVeterinariaGenNHibernate.EN.Mediaplayer.ArtistEN artistEN = new GestionVeterinariaGenNHibernate.EN.Mediaplayer.ArtistEN();
                 * GestionVeterinariaGenNHibernate.EN.Mediaplayer.MusicTrackEN musicTrackEN = new GestionVeterinariaGenNHibernate.EN.Mediaplayer.MusicTrackEN();
                 * GestionVeterinariaGenNHibernate.CEN.Mediaplayer.ArtistCEN artistCEN = new GestionVeterinariaGenNHibernate.CEN.Mediaplayer.ArtistCEN();
                 * GestionVeterinariaGenNHibernate.CEN.Mediaplayer.UserCEN userCEN = new GestionVeterinariaGenNHibernate.CEN.Mediaplayer.UserCEN();
                 * GestionVeterinariaGenNHibernate.CEN.Mediaplayer.MusicTrackCEN musicTrackCEN = new GestionVeterinariaGenNHibernate.CEN.Mediaplayer.MusicTrackCEN();
                 * GestionVeterinariaGenNHibernate.CEN.Mediaplayer.PlayListCEN playListCEN = new GestionVeterinariaGenNHibernate.CEN.Mediaplayer.PlayListCEN();
                 *
                 *              //Add Users
                 * userEN.Email = "user@user.com";
                 * userEN.Name = "user";
                 * userEN.Surname = "userSurname";
                 * userEN.Password = "user";
                 * userCEN.New_(userEN.Name, userEN.Surname, userEN.Email, userEN.Password);
                 *
                 * //Add Music Track1
                 * musicTrackEN.Id = "http://www2.b3ta.com/mp3/Beer Beer Beer (YOB mix).mp3";
                 * musicTrackEN.Format = "mp3";
                 * musicTrackEN.Lyrics = "Beer Beer Beer Beer Beer Beer ..";
                 * musicTrackEN.Name = "Beer Beer Beer";
                 * musicTrackEN.Company = "Company";
                 * musicTrackEN.Cover = "http://www.tomasabraham.com.ar/cajadig/2007/images/nro18-2/beer1.jpg";
                 * musicTrackEN.Price = 20;
                 * musicTrackEN.Rating = 5;
                 * musicTrackEN.CommunityRating = 5;
                 * musicTrackEN.Duration = 200;
                 * musicTrackCEN.New_(musicTrackEN.Id, musicTrackEN.Format, musicTrackEN.Lyrics, musicTrackEN.Name,
                 *  musicTrackEN.Company, musicTrackEN.Cover, musicTrackEN.CommunityRating, musicTrackEN.Rating,
                 *  musicTrackEN.Price, musicTrackEN.Duration);
                 * musicTracks.Add(musicTrackEN);
                 * musicTrackCEN.AsignUser(musicTrackEN.Id,userEN.Email);
                 *
                 * //Define Album
                 * //GestionVeterinariaGenNHibernate.CEN.Mediaplayer.AlbumCEN albumCEN = new GestionVeterinariaGenNHibernate.CEN.Mediaplayer.AlbumCEN();
                 * //albumCEN.New_("Album 1", "This is a Album 1", artists, musicTracks);*/
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
