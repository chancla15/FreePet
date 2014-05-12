using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormStartVeterinarioController
     * Se encarga de manejar la pantalla principal del veterinario
     */
    class FormVeterinarioInicioController
    {
        /** La vista */
        FormVeterinarioInicio form;



        /**
         * Constructor de la clase
         * @param session el ticket de sesion
         * @param la vista a controlar
         */
        public FormVeterinarioInicioController(FormVeterinarioInicio form)
        {
            this.form = form;
            initPerfil();
        }

        /**
      * Inicializa los datos de sesion FALTA LA FOTO!!!!!!!!!!!!!!!!!!!!!
      */
        private void initPerfil()
        {
            form.log_name.Text = form.menu.sessionData.name;
            form.log_id.Text = form.menu.sessionData.TOKEN_SESSION;
            form.log_type.Text = form.menu.sessionData.tipo;
            form.log_date.Text = form.menu.sessionData.fecha;
            //la foto

        }

        /*
         * Cuando seleccionameos una fecha, del calendario, mostrará las
         * consultas asociadas a ese veterinario en dicho día.
         */
        public void mostrarConsultas()
        {
            DateTime fecha = form.Calendar.SelectionRange.Start;
            //limpiamos el datagrid
            form.dataGrid_consultas.Rows.Clear();

            //dia consulta seleccionada
            form.label_fecha_consulta.Text = "Consultas para el día "+fecha.ToString("dd MMMM yyyy");


            //hacer la query a la base de datos pasandole la fecha seleccionada mostrar los resultados
            IList<ConsultaEN> consultas = Utils._ConsultaCEN.DameConsultaPorFechaYHora(fecha);

            if (consultas.Count > 0)
            {//si ha encontrado consultas las muestra
                for (int x = 0; x < consultas.Count; x++)
                {//Si la consulta es para el día seleccionado y la realiza el veterinario logeado 
                    if (consultas[x].Fecha.Equals(fecha) && consultas[x].Veterinario.DNI == form.menu.sessionData.TOKEN_SESSION)
                        form.dataGrid_consultas.Rows.Add(consultas[x].Fecha, consultas[x].MotivoConsulta, consultas[x].Lugar);
                }
            }


        }
    }
}
