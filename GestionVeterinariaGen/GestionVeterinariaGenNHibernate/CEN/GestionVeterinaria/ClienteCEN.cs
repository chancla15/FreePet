

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
public partial class ClienteCEN
{
private IClienteCAD _IClienteCAD;

public ClienteCEN()
{
        this._IClienteCAD = new ClienteCAD ();
}

public ClienteCEN(IClienteCAD _IClienteCAD)
{
        this._IClienteCAD = _IClienteCAD;
}

public IClienteCAD get_IClienteCAD ()
{
        return this._IClienteCAD;
}

public string New_ (string p_DNI, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> p_mascota)
{
        ClienteEN clienteEN = null;
        string oid;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.DNI = p_DNI;

        clienteEN.Nombre = p_nombre;

        clienteEN.Apellidos = p_apellidos;

        clienteEN.Direccion = p_direccion;

        clienteEN.Telefono = p_telefono;

        clienteEN.Localidad = p_localidad;

        clienteEN.Provincia = p_provincia;

        clienteEN.Cp = p_cp;

        clienteEN.Mascota = p_mascota;

        //Call to ClienteCAD

        oid = _IClienteCAD.New_ (clienteEN);
        return oid;
}

public void Modify (string p_Cliente_OID, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp)
{
        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.DNI = p_Cliente_OID;
        clienteEN.Nombre = p_nombre;
        clienteEN.Apellidos = p_apellidos;
        clienteEN.Direccion = p_direccion;
        clienteEN.Telefono = p_telefono;
        clienteEN.Localidad = p_localidad;
        clienteEN.Provincia = p_provincia;
        clienteEN.Cp = p_cp;
        //Call to ClienteCAD

        _IClienteCAD.Modify (clienteEN);
}

public void Destroy (string DNI)
{
        _IClienteCAD.Destroy (DNI);
}

public ClienteEN DameClientePorOID (string DNI)
{
        ClienteEN clienteEN = null;

        clienteEN = _IClienteCAD.DameClientePorOID (DNI);
        return clienteEN;
}

public void AnyadirMascota (string p_Cliente_OID, System.Collections.Generic.IList<int> p_mascota_OIDs)
{
        //Call to ClienteCAD

        _IClienteCAD.AnyadirMascota (p_Cliente_OID, p_mascota_OIDs);
}
public void QuitarMascota (string p_Cliente_OID, System.Collections.Generic.IList<int> p_mascota_OIDs)
{
        //Call to ClienteCAD

        _IClienteCAD.QuitarMascota (p_Cliente_OID, p_mascota_OIDs);
}
}
}
