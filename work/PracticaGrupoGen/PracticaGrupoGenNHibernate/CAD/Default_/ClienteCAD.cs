
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
public partial class ClienteCAD : BasicCAD, IClienteCAD
{
public ClienteCAD() : base ()
{
}

public ClienteCAD(ISession sessionAux) : base (sessionAux)
{
}



public ClienteEN ReadOIDDefault (string DNI)
{
        ClienteEN clienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Get (typeof(ClienteEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEN;
}


public string Crear (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (cliente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cliente.DNI;
}

public void Modificar (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), cliente.DNI);

                clienteEN.Name = cliente.Name;


                clienteEN.Surname = cliente.Surname;


                clienteEN.Password = cliente.Password;


                clienteEN.Address = cliente.Address;


                clienteEN.Phone = cliente.Phone;

                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
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
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), DNI);
                session.Delete (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AnyadirAnimal (string p_cliente, string p_animal)
{
        PracticaGrupoGenNHibernate.EN.Default_.ClienteEN clienteEN = null;
        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), p_cliente);
                clienteEN.Animal = (PracticaGrupoGenNHibernate.EN.Default_.AnimalEN)session.Load (typeof(PracticaGrupoGenNHibernate.EN.Default_.AnimalEN), p_animal);

                clienteEN.Animal.Cliente.Add (clienteEN);



                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void QuitarAnimal (string p_cliente, string p_animal)
{
        try
        {
                SessionInitializeTransaction ();
                PracticaGrupoGenNHibernate.EN.Default_.ClienteEN clienteEN = null;
                clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), p_cliente);

                if (clienteEN.Animal.Microchip == p_animal) {
                        clienteEN.Animal = null;
                }
                else
                        throw new ModelException ("The identifier " + p_animal + " in p_animal you are trying to unrelationer, doesn't exist in ClienteEN");

                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaGrupoGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PracticaGrupoGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
