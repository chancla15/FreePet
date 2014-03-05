

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
public partial class MascotaCEN
{
private IMascotaCAD _IMascotaCAD;

public MascotaCEN()
{
        this._IMascotaCAD = new MascotaCAD ();
}

public MascotaCEN(IMascotaCAD _IMascotaCAD)
{
        this._IMascotaCAD = _IMascotaCAD;
}

public IMascotaCAD get_IMascotaCAD ()
{
        return this._IMascotaCAD;
}

public int New_ (string p_nombre, string p_raza, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum p_sexo, float p_peso, string p_especie, Nullable<DateTime> p_fNacimiento, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum p_tamayo, string p_cliente, string p_color, bool p_microchip, string p_foto)
{
        MascotaEN mascotaEN = null;
        int oid;

        //Initialized MascotaEN
        mascotaEN = new MascotaEN ();
        mascotaEN.Nombre = p_nombre;

        mascotaEN.Raza = p_raza;

        mascotaEN.Sexo = p_sexo;

        mascotaEN.Peso = p_peso;

        mascotaEN.Especie = p_especie;

        mascotaEN.FNacimiento = p_fNacimiento;

        mascotaEN.Tamayo = p_tamayo;


        if (p_cliente != null) {
                mascotaEN.Cliente = new GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ClienteEN ();
                mascotaEN.Cliente.DNI = p_cliente;
        }

        mascotaEN.Color = p_color;

        mascotaEN.Microchip = p_microchip;

        mascotaEN.Foto = p_foto;

        //Call to MascotaCAD

        oid = _IMascotaCAD.New_ (mascotaEN);
        return oid;
}

public void Modify (int p_Mascota_OID, string p_nombre, string p_raza, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum p_sexo, float p_peso, string p_especie, Nullable<DateTime> p_fNacimiento, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum p_tamayo, string p_color, bool p_microchip, string p_foto)
{
        MascotaEN mascotaEN = null;

        //Initialized MascotaEN
        mascotaEN = new MascotaEN ();
        mascotaEN.IdMascota = p_Mascota_OID;
        mascotaEN.Nombre = p_nombre;
        mascotaEN.Raza = p_raza;
        mascotaEN.Sexo = p_sexo;
        mascotaEN.Peso = p_peso;
        mascotaEN.Especie = p_especie;
        mascotaEN.FNacimiento = p_fNacimiento;
        mascotaEN.Tamayo = p_tamayo;
        mascotaEN.Color = p_color;
        mascotaEN.Microchip = p_microchip;
        mascotaEN.Foto = p_foto;
        //Call to MascotaCAD

        _IMascotaCAD.Modify (mascotaEN);
}

public void Destroy (int IdMascota)
{
        _IMascotaCAD.Destroy (IdMascota);
}

public MascotaEN BuscarMascotaPorOID (int IdMascota)
{
        MascotaEN mascotaEN = null;

        mascotaEN = _IMascotaCAD.BuscarMascotaPorOID (IdMascota);
        return mascotaEN;
}

public System.Collections.Generic.IList<MascotaEN> DameTodasLasMascotas (int first, int size)
{
        System.Collections.Generic.IList<MascotaEN> list = null;

        list = _IMascotaCAD.DameTodasLasMascotas (first, size);
        return list;
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> DameMascotaPorNombre (string param, int first, int size)
{
        return _IMascotaCAD.DameMascotaPorNombre (param, first, size);
}
}
}
