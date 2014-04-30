

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
public partial class AdministradorCEN
{
private IAdministradorCAD _IAdministradorCAD;

public AdministradorCEN()
{
        this._IAdministradorCAD = new AdministradorCAD ();
}

public AdministradorCEN(IAdministradorCAD _IAdministradorCAD)
{
        this._IAdministradorCAD = _IAdministradorCAD;
}

public IAdministradorCAD get_IAdministradorCAD ()
{
        return this._IAdministradorCAD;
}

public string New_ (string p_DNI, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp, string p_password)
{
        AdministradorEN administradorEN = null;
        string oid;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.DNI = p_DNI;

        administradorEN.Nombre = p_nombre;

        administradorEN.Apellidos = p_apellidos;

        administradorEN.Direccion = p_direccion;

        administradorEN.Telefono = p_telefono;

        administradorEN.Localidad = p_localidad;

        administradorEN.Provincia = p_provincia;

        administradorEN.Cp = p_cp;

        administradorEN.Password = p_password;

        //Call to AdministradorCAD

        oid = _IAdministradorCAD.New_ (administradorEN);
        return oid;
}

public void Modify (string p_Administrador_OID, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp, string p_password)
{
        AdministradorEN administradorEN = null;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.DNI = p_Administrador_OID;
        administradorEN.Nombre = p_nombre;
        administradorEN.Apellidos = p_apellidos;
        administradorEN.Direccion = p_direccion;
        administradorEN.Telefono = p_telefono;
        administradorEN.Localidad = p_localidad;
        administradorEN.Provincia = p_provincia;
        administradorEN.Cp = p_cp;
        administradorEN.Password = p_password;
        //Call to AdministradorCAD

        _IAdministradorCAD.Modify (administradorEN);
}

public void Destroy (string DNI)
{
        _IAdministradorCAD.Destroy (DNI);
}

public GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.AdministradorEN IsAdmin (string nif, string pass)
{
        return _IAdministradorCAD.IsAdmin (nif, pass);
}
}
}
