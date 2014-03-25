
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
        public interface IEmpleadoCAD
        {
        EmpleadoEN ReadOIDDefault (String DNI);

        String New_ (EmpleadoEN empleado);

        void Modify (EmpleadoEN empleado);


        void Destroy (String DNI);


        EmpleadoEN DameEmpleadoPorOID (String DNI);


        System.Collections.Generic.IList<EN.GestionVeterinaria.EmpleadoEN> DameTodosLosEmpleados (int first, int size);

    }
}
