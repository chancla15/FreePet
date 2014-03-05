
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
public partial class RecepcionistCAD : BasicCAD, IRecepcionistCAD
{
public RecepcionistCAD() : base ()
{
}

public RecepcionistCAD(ISession sessionAux) : base (sessionAux)
{
}



public RecepcionistEN ReadOIDDefault (string DNI)
{
        RecepcionistEN recepcionistEN = null;

        try
        {
                SessionInitializeTransaction ();
                recepcionistEN = (RecepcionistEN)session.Get (typeof(RecepcionistEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in RecepcionistCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recepcionistEN;
}


public string Crear (RecepcionistEN recepcionist)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (recepcionist);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in RecepcionistCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recepcionist.DNI;
}

public void Modificar (RecepcionistEN recepcionist)
{
        try
        {
                SessionInitializeTransaction ();
                RecepcionistEN recepcionistEN = (RecepcionistEN)session.Load (typeof(RecepcionistEN), recepcionist.DNI);

                recepcionistEN.Identifier = recepcionist.Identifier;


                recepcionistEN.Name = recepcionist.Name;


                recepcionistEN.Surname = recepcionist.Surname;


                recepcionistEN.Password = recepcionist.Password;


                recepcionistEN.Address = recepcionist.Address;


                recepcionistEN.Phone = recepcionist.Phone;

                session.Update (recepcionistEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in RecepcionistCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Borrar (string DNI)
{
        try
        {
                SessionInitializeTransaction ();
                RecepcionistEN recepcionistEN = (RecepcionistEN)session.Load (typeof(RecepcionistEN), DNI);
                session.Delete (recepcionistEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in RecepcionistCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
