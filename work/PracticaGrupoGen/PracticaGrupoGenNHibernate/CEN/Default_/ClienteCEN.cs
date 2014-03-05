

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using PracticaGrupoGenNHibernate.EN.Default_;
using PracticaGrupoGenNHibernate.CAD.Default_;

namespace PracticaGrupoGenNHibernate.CEN.Default_
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

public string Crear (string p_DNI, string p_name, string p_surname, string p_password, string p_address, int p_phone)
{
        ClienteEN clienteEN = null;
        string oid;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.DNI = p_DNI;

        clienteEN.Name = p_name;

        clienteEN.Surname = p_surname;

        clienteEN.Password = p_password;

        clienteEN.Address = p_address;

        clienteEN.Phone = p_phone;

        //Call to ClienteCAD

        oid = _IClienteCAD.Crear (clienteEN);
        return oid;
}

public void Modificar (string p_oid, string p_name, string p_surname, string p_password, string p_address, int p_phone)
{
        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.DNI = p_oid;
        clienteEN.Name = p_name;
        clienteEN.Surname = p_surname;
        clienteEN.Password = p_password;
        clienteEN.Address = p_address;
        clienteEN.Phone = p_phone;
        //Call to ClienteCAD

        _IClienteCAD.Modificar (clienteEN);
}

public void Borrar (string DNI)
{
        _IClienteCAD.Borrar (DNI);
}

public void AnyadirAnimal (string p_cliente, string p_animal)
{
        //Call to ClienteCAD

        _IClienteCAD.AnyadirAnimal (p_cliente, p_animal);
}
public void QuitarAnimal (string p_cliente, string p_animal)
{
        //Call to ClienteCAD

        _IClienteCAD.QuitarAnimal (p_cliente, p_animal);
}
}
}
