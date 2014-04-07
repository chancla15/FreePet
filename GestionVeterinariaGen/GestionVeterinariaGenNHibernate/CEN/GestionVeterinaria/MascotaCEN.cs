

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

public string New_ (string p_IdMascota, string p_nombre, string p_raza, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum p_sexo, float p_peso, string p_especie, Nullable<DateTime> p_fNacimiento, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum p_tamanyo, string p_cliente, string p_color, bool p_microchip, string p_foto)
{
        MascotaEN mascotaEN = null;
        string oid;

        //Initialized MascotaEN
        mascotaEN = new MascotaEN ();
        mascotaEN.IdMascota = p_IdMascota;

        mascotaEN.Nombre = p_nombre;

        mascotaEN.Raza = p_raza;

        mascotaEN.Sexo = p_sexo;

        mascotaEN.Peso = p_peso;

        mascotaEN.Especie = p_especie;

        mascotaEN.FNacimiento = p_fNacimiento;

        mascotaEN.Tamanyo = p_tamanyo;


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

public void Modify (string p_Mascota_OID, string p_nombre, string p_raza, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum p_sexo, float p_peso, string p_especie, Nullable<DateTime> p_fNacimiento, GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum p_tamanyo, string p_color, bool p_microchip, string p_foto)
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
        mascotaEN.Tamanyo = p_tamanyo;
        mascotaEN.Color = p_color;
        mascotaEN.Microchip = p_microchip;
        mascotaEN.Foto = p_foto;
        //Call to MascotaCAD

        _IMascotaCAD.Modify (mascotaEN);
}

public void Destroy (string IdMascota)
{
        _IMascotaCAD.Destroy (IdMascota);
}

public MascotaEN BuscarMascotaPorOID (string IdMascota)
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
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> DameMascotaPorNombre (string busqueda)
{
        return _IMascotaCAD.DameMascotaPorNombre (busqueda);
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> ContadorMascotas ()
{
        return _IMascotaCAD.ContadorMascotas ();
}
public System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.MascotaEN> DameMascotaPorCliente (string nif)
{
        return _IMascotaCAD.DameMascotaPorCliente (nif);
}
}
}
