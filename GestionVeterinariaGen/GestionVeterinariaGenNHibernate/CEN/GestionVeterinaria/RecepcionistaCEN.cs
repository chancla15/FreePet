

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
public partial class RecepcionistaCEN
{
private IRecepcionistaCAD _IRecepcionistaCAD;

public RecepcionistaCEN()
{
        this._IRecepcionistaCAD = new RecepcionistaCAD ();
}

public RecepcionistaCEN(IRecepcionistaCAD _IRecepcionistaCAD)
{
        this._IRecepcionistaCAD = _IRecepcionistaCAD;
}

public IRecepcionistaCAD get_IRecepcionistaCAD ()
{
        return this._IRecepcionistaCAD;
}

public string New_ (string p_DNI, string p_nombre, string p_apellidos, String p_password, string p_direccion, string p_telefono, string p_localidad, string p_provincia, int p_cp, string p_IdEmpleado, float p_sueldo)
{
        RecepcionistaEN recepcionistaEN = null;
        string oid;

        //Initialized RecepcionistaEN
        recepcionistaEN = new RecepcionistaEN ();
        recepcionistaEN.DNI = p_DNI;

        recepcionistaEN.Nombre = p_nombre;

        recepcionistaEN.Apellidos = p_apellidos;

        recepcionistaEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        recepcionistaEN.Direccion = p_direccion;

        recepcionistaEN.Telefono = p_telefono;

        recepcionistaEN.Localidad = p_localidad;

        recepcionistaEN.Provincia = p_provincia;

        recepcionistaEN.Cp = p_cp;

        recepcionistaEN.IdEmpleado = p_IdEmpleado;

        recepcionistaEN.Sueldo = p_sueldo;

        //Call to RecepcionistaCAD

        oid = _IRecepcionistaCAD.New_ (recepcionistaEN);
        return oid;
}

public void Modify (string p_Recepcionista_OID, string p_nombre, string p_apellidos, String p_password, string p_direccion, string p_telefono, string p_localidad, string p_provincia, int p_cp, string p_IdEmpleado, float p_sueldo)
{
        RecepcionistaEN recepcionistaEN = null;

        //Initialized RecepcionistaEN
        recepcionistaEN = new RecepcionistaEN ();
        recepcionistaEN.DNI = p_Recepcionista_OID;
        recepcionistaEN.Nombre = p_nombre;
        recepcionistaEN.Apellidos = p_apellidos;
        recepcionistaEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        recepcionistaEN.Direccion = p_direccion;
        recepcionistaEN.Telefono = p_telefono;
        recepcionistaEN.Localidad = p_localidad;
        recepcionistaEN.Provincia = p_provincia;
        recepcionistaEN.Cp = p_cp;
        recepcionistaEN.IdEmpleado = p_IdEmpleado;
        recepcionistaEN.Sueldo = p_sueldo;
        //Call to RecepcionistaCAD

        _IRecepcionistaCAD.Modify (recepcionistaEN);
}

public void Destroy (string DNI)
{
        _IRecepcionistaCAD.Destroy (DNI);
}

public System.Collections.Generic.IList<RecepcionistaEN> DameTodos (int first, int size)
{
        System.Collections.Generic.IList<RecepcionistaEN> list = null;

        list = _IRecepcionistaCAD.DameTodos (first, size);
        return list;
}
}
}
