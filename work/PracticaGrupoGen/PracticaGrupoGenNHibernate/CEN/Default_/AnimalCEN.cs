

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
public partial class AnimalCEN
{
private IAnimalCAD _IAnimalCAD;

public AnimalCEN()
{
        this._IAnimalCAD = new AnimalCAD ();
}

public AnimalCEN(IAnimalCAD _IAnimalCAD)
{
        this._IAnimalCAD = _IAnimalCAD;
}

public IAnimalCAD get_IAnimalCAD ()
{
        return this._IAnimalCAD;
}

public string Crear (string p_microchip, string p_name, PracticaGrupoGenNHibernate.Enumerated.Default_.RazaAnimalEnum p_raza, PracticaGrupoGenNHibernate.Enumerated.Default_.TamanyoAnimalEnum p_tamanyo, double p_peso, Nullable<DateTime> p_fechanac, char p_sexo)
{
        AnimalEN animalEN = null;
        string oid;

        //Initialized AnimalEN
        animalEN = new AnimalEN ();
        animalEN.Microchip = p_microchip;

        animalEN.Name = p_name;

        animalEN.Raza = p_raza;

        animalEN.Tamanyo = p_tamanyo;

        animalEN.Peso = p_peso;

        animalEN.Fechanac = p_fechanac;

        animalEN.Sexo = p_sexo;

        //Call to AnimalCAD

        oid = _IAnimalCAD.Crear (animalEN);
        return oid;
}

public void Modificar (string p_oid, string p_name, PracticaGrupoGenNHibernate.Enumerated.Default_.RazaAnimalEnum p_raza, PracticaGrupoGenNHibernate.Enumerated.Default_.TamanyoAnimalEnum p_tamanyo, double p_peso, Nullable<DateTime> p_fechanac, char p_sexo)
{
        AnimalEN animalEN = null;

        //Initialized AnimalEN
        animalEN = new AnimalEN ();
        animalEN.Microchip = p_oid;
        animalEN.Name = p_name;
        animalEN.Raza = p_raza;
        animalEN.Tamanyo = p_tamanyo;
        animalEN.Peso = p_peso;
        animalEN.Fechanac = p_fechanac;
        animalEN.Sexo = p_sexo;
        //Call to AnimalCAD

        _IAnimalCAD.Modificar (animalEN);
}

public void Borrar (string microchip)
{
        _IAnimalCAD.Borrar (microchip);
}

public AnimalEN LeerAnimalPorOID (string microchip)
{
        AnimalEN animalEN = null;

        animalEN = _IAnimalCAD.LeerAnimalPorOID (microchip);
        return animalEN;
}
}
}
