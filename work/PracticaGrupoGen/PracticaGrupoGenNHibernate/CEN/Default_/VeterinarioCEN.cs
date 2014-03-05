

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
public partial class VeterinarioCEN
{
private IVeterinarioCAD _IVeterinarioCAD;

public VeterinarioCEN()
{
        this._IVeterinarioCAD = new VeterinarioCAD ();
}

public VeterinarioCEN(IVeterinarioCAD _IVeterinarioCAD)
{
        this._IVeterinarioCAD = _IVeterinarioCAD;
}

public IVeterinarioCAD get_IVeterinarioCAD ()
{
        return this._IVeterinarioCAD;
}

public string Crear (int p_num_colegiado, string p_identifier, string p_DNI, string p_name, string p_surname, string p_password, string p_address, int p_phone)
{
        VeterinarioEN veterinarioEN = null;
        string oid;

        //Initialized VeterinarioEN
        veterinarioEN = new VeterinarioEN ();
        veterinarioEN.Num_colegiado = p_num_colegiado;

        veterinarioEN.Identifier = p_identifier;

        veterinarioEN.DNI = p_DNI;

        veterinarioEN.Name = p_name;

        veterinarioEN.Surname = p_surname;

        veterinarioEN.Password = p_password;

        veterinarioEN.Address = p_address;

        veterinarioEN.Phone = p_phone;

        //Call to VeterinarioCAD

        oid = _IVeterinarioCAD.Crear (veterinarioEN);
        return oid;
}

public void Modificar (string p_oid, int p_num_colegiado, string p_identifier, string p_name, string p_surname, string p_password, string p_address, int p_phone)
{
        VeterinarioEN veterinarioEN = null;

        //Initialized VeterinarioEN
        veterinarioEN = new VeterinarioEN ();
        veterinarioEN.DNI = p_oid;
        veterinarioEN.Num_colegiado = p_num_colegiado;
        veterinarioEN.Identifier = p_identifier;
        veterinarioEN.Name = p_name;
        veterinarioEN.Surname = p_surname;
        veterinarioEN.Password = p_password;
        veterinarioEN.Address = p_address;
        veterinarioEN.Phone = p_phone;
        //Call to VeterinarioCAD

        _IVeterinarioCAD.Modificar (veterinarioEN);
}

public void Borrar (string DNI)
{
        _IVeterinarioCAD.Borrar (DNI);
}
}
}
