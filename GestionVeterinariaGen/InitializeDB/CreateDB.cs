
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
                /** Objetos de tipo tratamiento con herencia */
                /*ITratamientoCAD _ITratamientoCAD = new TratamientoCAD();
                 * IFarmacoCAD _IFarmacoCAD = new FarmacoCAD();
                 * IOrtopediaCAD _IoOrtopediaCAD = new OrtopediaCAD();
                 * IVacunaCAD _IVacunaCAD = new VacunaCAD(); */

                /*TratamientoEN tratamientoEN= new TratamientoEN();
                 * TratamientoEN tratamientoFarmacoEN= new FarmacoEN();
                 * TratamientoEN tratamientoOrtopediaEN= new OrtopediaEN();
                 * TratamientoEN tratamientoVacunaEN = new VacunaEN();
                 * TratamientoCEN tratamientoCEN = new TratamientoCEN();
                 * FarmacoCEN tratamientoFarmacoCEN = new FarmacoCEN();
                 * OrtopediaCEN tratamientoOrtopediaCEN = new OrtopediaCEN();
                 * VacunaCEN tratamientoVacunaCEN = new VacunaCEN();
                 *
                 * #region Tratamientos
                 * tratamientoEN.Nombre = " tratamiento1";
                 * tratamientoEN.Fecha = "03/03/2014";
                 * tratamientoEN.Duracion = "30";
                 * tratamientoEN.Precio = 30.0f;
                 *
                 #endregion*/



                /** Objectos de tipo Cliente */
                /* IClienteCAD _IClienteCAD = new ClienteCAD ();
                 * ClienteEN cliente1EN, cliente2EN;
                 * ClienteCEN clienteCEN = new ClienteCEN (_IClienteCAD);
                 */

                UsuarioEN cliente1EN = new ClienteEN ();
                UsuarioEN cliente2EN = new ClienteEN ();
                EmpleadoEN recep1EN = new RecepcionistaEN ();
                EmpleadoEN recep2EN = new RecepcionistaEN ();
                VeterinarioEN veterEN = new VeterinarioEN ();
                ClienteCEN clienteCEN = new ClienteCEN ();
                RecepcionistaCEN recepCEN = new RecepcionistaCEN ();
                VeterinarioCEN veterCEN = new VeterinarioCEN ();

                #region EMPLEADOS_DB
                recep1EN.IdEmpleado = "01-R";
                recep1EN.Sueldo = 1000;
                recep1EN.Nombre = "recepcionista1Nombre";
                recep1EN.Apellidos = "recepcionista1Apellidos";
                recep1EN.DNI = "11111111R";
                recep1EN.Direccion = "recepcionista1Direccion";
                recep1EN.Localidad = "recepcionista1Localidad";
                recep1EN.Cp = "01234";
                recep1EN.Provincia = "recepcionista1Provincia";
                recep1EN.Telefono = "recepcionista1Telefono";
                recep1EN.Password = "recepcionista1Password";
                recepCEN.New_ (recep1EN.DNI, recep1EN.Nombre, recep1EN.Apellidos, recep1EN.Password, recep1EN.Direccion, recep1EN.Telefono, recep1EN.Localidad, recep1EN.Provincia, recep1EN.Cp, recep1EN.IdEmpleado, recep1EN.Sueldo);

                recep2EN.IdEmpleado = "02-R";
                recep2EN.Sueldo = 1000;
                recep2EN.Nombre = "recepcionista2Nombre";
                recep2EN.Apellidos = "recepcionista2Apellidos";
                recep2EN.DNI = "22222222R";
                recep2EN.Direccion = "recepcionista2Direccion";
                recep2EN.Localidad = "recepcionista2Localidad";
                recep2EN.Cp = "01234";
                recep2EN.Provincia = "recepcionista2Provincia";
                recep2EN.Telefono = "recepcionista2Telefono";
                recep2EN.Password = "recepcionista2Password";
                recepCEN.New_ (recep2EN.DNI, recep2EN.Nombre, recep2EN.Apellidos, recep2EN.Password, recep2EN.Direccion, recep2EN.Telefono, recep2EN.Localidad, recep2EN.Provincia, recep2EN.Cp, recep2EN.IdEmpleado, recep2EN.Sueldo);

                veterEN.IdEmpleado = "01-V";
                veterEN.Sueldo = 2000;
                veterEN.NumColegiado = 1;
                veterEN.Nombre = "veterinarioNombre";
                veterEN.Apellidos = "veterinarioApellidos";
                veterEN.DNI = "11111111V";
                veterEN.Direccion = "veterinarioDireccion";
                veterEN.Localidad = "veterinarioLocalidad";
                veterEN.Cp = "01234";
                veterEN.Provincia = "veterinarioProvincia";
                veterEN.Telefono = "veterinarioTelefono";
                veterEN.Password = "veterinarioPassword";
                veterCEN.New_ (veterEN.DNI, veterEN.Nombre, veterEN.Apellidos, veterEN.Password, veterEN.Direccion, veterEN.Telefono, veterEN.Localidad, veterEN.Provincia, veterEN.Cp, veterEN.IdEmpleado, veterEN.Sueldo, veterEN.NumColegiado);
                #endregion

                #region CLIENTE_DB
                cliente1EN = new ClienteEN ();
                cliente1EN.Nombre = "cliente1Nombre";
                cliente1EN.Apellidos = "cliente1Apellidos";
                cliente1EN.DNI = "11111111C";
                cliente1EN.Direccion = "cliente1Direccion";
                cliente1EN.Localidad = "cliente1Localidad";
                cliente1EN.Cp = "01234";
                cliente1EN.Provincia = "cliente1Provincia";
                cliente1EN.Telefono = "cliente1Telefono";
                cliente1EN.Password = "cliente1Password";
                clienteCEN.New_ (cliente1EN.DNI, cliente1EN.Nombre, cliente1EN.Apellidos, cliente1EN.Password, cliente1EN.Direccion, cliente1EN.Telefono, cliente1EN.Localidad, cliente1EN.Provincia, cliente1EN.Cp);

                cliente2EN = new ClienteEN ();
                cliente2EN.Nombre = "cliente2Nombre";
                cliente2EN.Apellidos = "cliente2Apellidos";
                cliente2EN.DNI = "22222222C";
                cliente2EN.Direccion = "cliente2Direccion";
                cliente2EN.Localidad = "cliente2Localidad";
                cliente2EN.Cp = "01234";
                cliente2EN.Provincia = "cliente2Provincia";
                cliente2EN.Telefono = "cliente2Telefono";
                cliente2EN.Password = "cliente2Password";
                clienteCEN.New_ (cliente2EN.DNI, cliente2EN.Nombre, cliente2EN.Apellidos, cliente2EN.Password, cliente2EN.Direccion, cliente2EN.Telefono, cliente2EN.Localidad, cliente2EN.Provincia, cliente2EN.Cp);
                #endregion


                MascotaEN mascota1EN = new MascotaEN ();
                MascotaEN mascota2EN = new MascotaEN ();
                MascotaEN mascota3EN = new MascotaEN ();
                MascotaEN mascota4EN = new MascotaEN ();
                MascotaCEN mascotaCEN = new MascotaCEN ();

                #region MASCOTAS_DB
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

                mascota2EN.IdMascota = 2;
                mascota2EN.Nombre = "mascota2Nombre";
                mascota2EN.Raza = "mascota2Raza";
                mascota2EN.Sexo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho;
                mascota2EN.Peso = 2;
                mascota2EN.Especie = "mascota2Especie";
                mascota2EN.FNacimiento = new DateTime (2, 2, 2);
                mascota2EN.Tamanyo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L;
                mascota2EN.Color = "mascota2Color";
                mascota2EN.Microchip = true;
                mascota2EN.Foto = "mascota2Foto";

                mascota3EN.IdMascota = 3;
                mascota3EN.Nombre = "mascota3Nombre";
                mascota3EN.Raza = "mascota3Raza";
                mascota3EN.Sexo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho;
                mascota3EN.Peso = 3;
                mascota3EN.Especie = "mascota3Especie";
                mascota3EN.FNacimiento = new DateTime (3, 3, 3);
                mascota3EN.Tamanyo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L;
                mascota3EN.Color = "mascota3Color";
                mascota3EN.Microchip = true;
                mascota3EN.Foto = "mascota3Foto";

                mascota4EN.IdMascota = 4;
                mascota4EN.Nombre = "mascota4Nombre";
                mascota4EN.Raza = "mascota4Raza";
                mascota4EN.Sexo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho;
                mascota4EN.Peso = 4;
                mascota4EN.Especie = "mascota4Especie";
                mascota4EN.FNacimiento = new DateTime (4, 4, 4);
                mascota4EN.Tamanyo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L;
                mascota4EN.Color = "mascota4Color";
                mascota4EN.Microchip = true;
                mascota4EN.Foto = "mascota4Foto";
                #endregion


                #region CLIENTES_ANAYDIR_MASCOTAS
                IList<int> mascotas;
                mascotas.Add (mascota1EN.IdMascota);
                mascotas.Add (mascota2EN.IdMascota);
                clienteCEN.AnyadirMascota (cliente1EN.DNI, mascotas);
                IList<int> mascotas2;
                //mascotas2.Add(mascota3EN.IdMascota);
                //mascotas2.Add(mascota4EN.IdMascota);
                //clienteCEN.AnyadirMascota(cliente2EN.DNI, mascotas);
                #endregion

                #region  CLIENTE_ELIMINAR_MASCOTAS
                IList<int> mascotas; // = new IList<int>();
                //mascotas.Add(mascota2EN.IdMascota);
                //clienteCEN.QuitarMascota(cliente1EN.DNI, mascotas);
                #endregion

                FacturaEN factura1EN = new FacturaEN ();
                FacturaEN factura2EN = new FacturaEN ();
                ConsultaEN consultaEN = new ConsultaEN ();
                FacturaCEN facturaCEN = new FacturaCEN ();
                ConsultaCEN consultaCEN = new ConsultaCEN ();

                #region FACTURA_CONSULTA
                factura1EN.IdFactura = "00001";
                factura1EN.Fecha = new DateTime (1, 1, 1);
                factura1EN.Total = 1;
                factura1EN.Cliente = clienteCEN.DameClientePorOID (cliente1EN.DNI);
                //factura1EN.Consulta = consultaCEN.DameConsultaPorOID(consulta1EN.IdConsulta);
                factura1EN.Pagada = true;


                consultaEN.IdConsulta = "0001";
                consultaEN.Lugar = "En la sala 1";
                consultaEN.MotivoConsulta = "Esta resfriao";
                consultaEN.Tratamiento = null;
                consultaEN.Veterinario = veterCEN.DameVetarinarioPorOID (veterEN.DNI);

                factura2EN.IdFactura = "00002";;
                factura2EN.Fecha = new DateTime (2, 2, 2);
                factura2EN.Total = 2;
                factura2EN.Cliente = clienteCEN.DameClientePorOID (cliente1EN.DNI);
                //factura2EN.COnsulta= "Introducir consulta valida";
                factura2EN.Pagada = true;
                #endregion














                /** Objectos de tipo Recepcionista */
                /* IRecepcionistaCAD _IRecepcionistaCAD = new RecepcionistaCAD();
                 * RecepcionistaEN recepcionista1EN, recepcionista2EN;
                 * RecepcionistaCEN recepcionistaCEN = new RecepcionistaCEN(_IRecepcionistaCAD);
                 */
                /** Objectos de tipo Veterinario */
                /*  IVeterinarioCAD _IVeterinarioCAD = new VeterinarioCAD();
                 * VeterinarioEN veterinario1EN, veterinario2EN;
                 * VeterinarioCEN veterinarioCEN = new VeterinarioCEN(_IVeterinarioCAD);
                 */
                /** Objectos de tipo Empleado */
                /*  IEmpleadoCAD _IEmpleadoCAD = new EmpleadoCAD();
                 * EmpleadoEN empleado1EN, empleado2EN;
                 * EmpleadoCEN empleadoCEN = new EmpleadoCEN(_IEmpleadoCAD);
                 */
                /** Objectos de tipo usuario */
                /*  IUsuarioCAD _IUsuarioCAD = new UsuarioCAD ();
                 * UsuarioEN usuario1EN, usuario2EN;
                 * UsuarioCEN usuarioCEN = new UsuarioCEN (_IUsuarioCAD);
                 */
                /** Objetos de tipo mascota
                 * IMascotaCAD _IMascotaCAD = new MascotaCAD ();
                 * MascotaEN mascota1EN, mascota2EN = new MascotaEN ();
                 * MascotaCEN mascotaCEN = new MascotaCEN (_IMascotaCAD);*/

                /** Objectos de tipo factura
                 * IFacturaCAD _IFacturaCAD = new FacturaCAD ();
                 * FacturaEN factura1EN, factura2EN;
                 * FacturaCEN facturaCEN = new FacturaCEN (_IFacturaCAD);*/

                /** Objetos de tipo consulta
                 * IConsultaCAD _IConsultaCAD = new ConsultaCAD ();
                 * ConsultaEN consulta1EN = new ConsultaEN ();
                 * ConsultaEN consulta2EN = new ConsultaEN ();
                 * ConsultaCEN consultaCEN = new ConsultaCEN (_IConsultaCAD);
                 *
                 *
                 *
                 *
                 * #region Usuario
                 * //NI IDEA DE COMO RELLENAR CON HERENCIA, DEJO ESTO COMO PRUEBA
                 * usuario1EN = new ClienteEN(cliente1EN);
                 * usuarioCEN.New_ (cliente1EN.DNI, cliente1EN.Nombre, cliente1EN.Apellidos, cliente1EN.Password, cliente1EN.Direccion, cliente1EN.Telefono, cliente1EN.Localidad, cliente1EN.Provincia, cliente1EN.Cp);
                 *
                 * usuario2EN = new ClienteEN(cliente2EN);
                 * usuarioCEN.New_ (cliente2EN.DNI, cliente2EN.Nombre, cliente2EN.Apellidos, cliente2EN.Password, cliente2EN.Direccion, cliente2EN.Telefono, cliente2EN.Localidad, cliente2EN.Provincia, cliente2EN.Cp);
                 * #endregion
                 *
                 * #region Mascota
                 * //EL HISTORIALCLINICO NO ESTA
                 * mascota1EN = new MascotaEN ();
                 * mascota1EN.Cliente = cliente1EN; //COMO ES TIPO OBJETO HE PUESTO UN OBJETO CLIENTE PERO NI IDEA :S
                 * mascota1EN.IdMascota = 1;
                 * mascota1EN.Nombre = "mascota1Nombre";
                 * mascota1EN.Raza = "mascota1Raza";
                 * mascota1EN.Sexo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho;
                 * mascota1EN.Peso = 1;
                 * mascota1EN.Especie = "mascota1Especie";
                 * mascota1EN.FNacimiento = new DateTime (1, 1, 1);
                 * mascota1EN.Tamanyo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L;
                 * mascota1EN.Color = "mascota1Color";
                 * mascota1EN.Microchip = true;
                 * mascota1EN.Foto = "mascota1Foto";
                 * mascotaCEN.New_ (mascota1EN.Nombre, mascota1EN.Raza, mascota1EN.Sexo, mascota1EN.Peso, mascota1EN.Especie, mascota1EN.FNacimiento, mascota1EN.Tamanyo, cliente1EN.DNI, mascota1EN.Color, mascota1EN.Microchip, mascota1EN.Foto);
                 * //EN EL NEW EN EL PARAMETRO CLIENTE HE PUESTO EL DNI DEL CLIENTE1 PERO ENTONCES DE QUE SIRVE EL CAMPO MASCOTA1EN.CLIENTE�?
                 *
                 * mascota2EN = new MascotaEN ();
                 * mascota2EN.Cliente = cliente2EN;
                 * mascota2EN.IdMascota = 2;
                 * mascota2EN.Nombre = "mascota2Nombre";
                 * mascota2EN.Raza = "mascota2Raza";
                 * mascota2EN.Sexo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho;
                 * mascota2EN.Peso = 2;
                 * mascota2EN.Especie = "mascota2Especie";
                 * mascota2EN.FNacimiento = new DateTime (2, 2, 2);
                 * mascota2EN.Tamanyo = GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L;
                 * mascota2EN.Color = "mascota2Color";
                 * mascota2EN.Microchip = true;
                 * mascota2EN.Foto = "mascota2Foto";
                 * mascotaCEN.New_ (mascota2EN.Nombre, mascota2EN.Raza, mascota2EN.Sexo, mascota2EN.Peso, mascota2EN.Especie, mascota2EN.FNacimiento, mascota2EN.Tamanyo, cliente2EN.DNI, mascota2EN.Color, mascota2EN.Microchip, mascota2EN.Foto);
                 *
                 * #endregion
                 *
                 * #region Factura
                 * //FALTAN PARAMETROS, LOS DE LAS RELACIONES
                 * factura1EN = new FacturaEN ();
                 * factura1EN.IdFactura = 1;
                 * factura1EN.Fecha = new DateTime (1, 1, 1);
                 * factura1EN.Total = 1;
                 * factura1EN.Pagada = true;
                 * facturaCEN.New_ (factura1EN.Fecha, factura1EN.Total, cliente1EN.DNI, consulta1EN.IdConsulta, factura1EN.Pagada);
                 *
                 * factura2EN = new FacturaEN ();
                 * factura2EN.IdFactura = 2;
                 * factura2EN.Fecha = new DateTime (2, 2, 2);
                 * factura2EN.Total = 2;
                 * factura2EN.Pagada = true;
                 * facturaCEN.New_ (factura2EN.Fecha, factura2EN.Total, cliente2EN.DNI, consulta2EN.IdConsulta, factura2EN.Pagada);
                 *
                 *
                 *
                 * #endregion
                 *
                 * #region Consulta
                 * consulta1EN = new ConsultaEN ();
                 * consulta1EN.IdConsulta = 1;
                 * consulta1EN.Fecha = new DateTime (1, 1, 1);
                 * consulta1EN.Hora = new TimeSpan (1, 1, 1);
                 * consulta1EN.MotivoConsulta = "consulta1Motivo";
                 * consulta1EN.Diagnostico = "consulta1Diagnostico";
                 * consulta1EN.Lugar = "consulta1Lugar";
                 * consultaCEN.New_ (consulta1EN.Fecha, consulta1EN.Hora, consulta1EN.MotivoConsulta, consulta1EN.Diagnostico, new List<int>(mascota1EN.IdMascota), "poner veterinario", consulta1EN.Lugar);
                 *
                 * consulta2EN = new ConsultaEN ();
                 * consulta2EN.IdConsulta = 2;
                 * consulta2EN.Fecha = new DateTime (2, 2, 2);
                 * consulta2EN.Hora = new TimeSpan (2, 2, 2);
                 * consulta2EN.MotivoConsulta = "consulta2Motivo";
                 * consulta2EN.Diagnostico = "consulta2Diagnostico";
                 * consulta2EN.Lugar = "consulta2Lugar";
                 * consultaCEN.New_ (consulta2EN.Fecha, consulta2EN.Hora, consulta2EN.MotivoConsulta, consulta2EN.Diagnostico, new List<int>(mascota2EN.IdMascota), "poner veterinario", consulta2EN.Lugar);
                 *
                 #endregion*/

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
