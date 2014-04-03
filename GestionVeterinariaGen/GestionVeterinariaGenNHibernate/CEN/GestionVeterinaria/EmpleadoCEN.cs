

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
public partial class EmpleadoCEN
{
private IEmpleadoCAD _IEmpleadoCAD;

public EmpleadoCEN()
{
        this._IEmpleadoCAD = new EmpleadoCAD ();
}

public EmpleadoCEN(IEmpleadoCAD _IEmpleadoCAD)
{
        this._IEmpleadoCAD = _IEmpleadoCAD;
}

public IEmpleadoCAD get_IEmpleadoCAD ()
{
        return this._IEmpleadoCAD;
}

public string New_ (string p_DNI, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp, float p_sueldo, String p_password)
{
        EmpleadoEN empleadoEN = null;
        string oid;

        //Initialized EmpleadoEN
        empleadoEN = new EmpleadoEN ();
        empleadoEN.DNI = p_DNI;

        empleadoEN.Nombre = p_nombre;

        empleadoEN.Apellidos = p_apellidos;

        empleadoEN.Direccion = p_direccion;

        empleadoEN.Telefono = p_telefono;

        empleadoEN.Localidad = p_localidad;

        empleadoEN.Provincia = p_provincia;

        empleadoEN.Cp = p_cp;

        empleadoEN.Sueldo = p_sueldo;

        empleadoEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        //Call to EmpleadoCAD

        oid = _IEmpleadoCAD.New_ (empleadoEN);
        return oid;
}

public void Modify (string p_Empleado_OID, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_localidad, string p_provincia, string p_cp, int p_IdEmpleado, float p_sueldo, String p_password)
{
        EmpleadoEN empleadoEN = null;

        //Initialized EmpleadoEN
        empleadoEN = new EmpleadoEN ();
        empleadoEN.DNI = p_Empleado_OID;
        empleadoEN.Nombre = p_nombre;
        empleadoEN.Apellidos = p_apellidos;
        empleadoEN.Direccion = p_direccion;
        empleadoEN.Telefono = p_telefono;
        empleadoEN.Localidad = p_localidad;
        empleadoEN.Provincia = p_provincia;
        empleadoEN.Cp = p_cp;
        empleadoEN.IdEmpleado = p_IdEmpleado;
        empleadoEN.Sueldo = p_sueldo;
        empleadoEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        //Call to EmpleadoCAD

        _IEmpleadoCAD.Modify (empleadoEN);
}

public void Destroy (string DNI)
{
        _IEmpleadoCAD.Destroy (DNI);
}

public EmpleadoEN DameEmpleadoPorOID (string DNI)
{
        EmpleadoEN empleadoEN = null;

        empleadoEN = _IEmpleadoCAD.DameEmpleadoPorOID (DNI);
        return empleadoEN;
}

public System.Collections.Generic.IList<EmpleadoEN> DameTodosLosEmpleados (int first, int size)
{
        System.Collections.Generic.IList<EmpleadoEN> list = null;

        list = _IEmpleadoCAD.DameTodosLosEmpleados (first, size);
        return list;
}
}
}
