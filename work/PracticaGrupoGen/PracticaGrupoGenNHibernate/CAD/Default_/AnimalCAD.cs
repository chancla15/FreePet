
using System;
using System.Text;
using PracticaGrupoGenNHibernate.CEN.Default_;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PracticaGrupoGenNHibernate.EN.Default_;
using PracticaGrupoGenNHibernate.Exceptions;

namespace PracticaGrupoGenNHibernate.CAD.Default_
{
public partial class AnimalCAD : BasicCAD, IAnimalCAD
{
public AnimalCAD() : base ()
{
}

public AnimalCAD(ISession sessionAux) : base (sessionAux)
{
}



public AnimalEN ReadOIDDefault (string microchip)
{
        AnimalEN animalEN = null;

        try
        {
                SessionInitializeTransaction ();
                animalEN = (AnimalEN)session.Get (typeof(AnimalEN), microchip);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in AnimalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return animalEN;
}


public string Crear (AnimalEN animal)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (animal);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in AnimalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return animal.Microchip;
}

public void Modificar (AnimalEN animal)
{
        try
        {
                SessionInitializeTransaction ();
                AnimalEN animalEN = (AnimalEN)session.Load (typeof(AnimalEN), animal.Microchip);

                animalEN.Name = animal.Name;


                animalEN.Raza = animal.Raza;


                animalEN.Tamanyo = animal.Tamanyo;


                animalEN.Peso = animal.Peso;


                animalEN.Fechanac = animal.Fechanac;


                animalEN.Sexo = animal.Sexo;

                session.Update (animalEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in AnimalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Borrar (string microchip)
{
        try
        {
                SessionInitializeTransaction ();
                AnimalEN animalEN = (AnimalEN)session.Load (typeof(AnimalEN), microchip);
                session.Delete (animalEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in AnimalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public AnimalEN LeerAnimalPorOID (string microchip)
{
        AnimalEN animalEN = null;

        try
        {
                SessionInitializeTransaction ();
                animalEN = (AnimalEN)session.Get (typeof(AnimalEN), microchip);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in AnimalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return animalEN;
}
}
}
