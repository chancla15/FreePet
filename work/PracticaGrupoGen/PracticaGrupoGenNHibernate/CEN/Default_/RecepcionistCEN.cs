

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
public partial class RecepcionistCEN
{
private IRecepcionistCAD _IRecepcionistCAD;

public RecepcionistCEN()
{
        this._IRecepcionistCAD = new RecepcionistCAD ();
}

public RecepcionistCEN(IRecepcionistCAD _IRecepcionistCAD)
{
        this._IRecepcionistCAD = _IRecepcionistCAD;
}

public IRecepcionistCAD get_IRecepcionistCAD ()
{
        return this._IRecepcionistCAD;
}

public string Crear (string p_identifier, string p_DNI, string p_name, string p_surname, string p_password, string p_address, int p_phone)
{
        RecepcionistEN recepcionistEN = null;
        string oid;

        //Initialized RecepcionistEN
        recepcionistEN = new RecepcionistEN ();
        recepcionistEN.Identifier = p_identifier;

        recepcionistEN.DNI = p_DNI;

        recepcionistEN.Name = p_name;

        recepcionistEN.Surname = p_surname;

        recepcionistEN.Password = p_password;

        recepcionistEN.Address = p_address;

        recepcionistEN.Phone = p_phone;

        //Call to RecepcionistCAD

        oid = _IRecepcionistCAD.Crear (recepcionistEN);
        return oid;
}

public void Modificar (string p_oid, string p_identifier, string p_name, string p_surname, string p_password, string p_address, int p_phone)
{
        RecepcionistEN recepcionistEN = null;

        //Initialized RecepcionistEN
        recepcionistEN = new RecepcionistEN ();
        recepcionistEN.DNI = p_oid;
        recepcionistEN.Identifier = p_identifier;
        recepcionistEN.Name = p_name;
        recepcionistEN.Surname = p_surname;
        recepcionistEN.Password = p_password;
        recepcionistEN.Address = p_address;
        recepcionistEN.Phone = p_phone;
        //Call to RecepcionistCAD

        _IRecepcionistCAD.Modificar (recepcionistEN);
}

public void Borrar (string DNI)
{
        _IRecepcionistCAD.Borrar (DNI);
}
}
}
