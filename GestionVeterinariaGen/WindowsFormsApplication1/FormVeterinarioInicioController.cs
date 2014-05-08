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

        /** El ticket de sesion */
        FormLoginDataSessionTicket sessionData;

        /**
         * Constructor de la clase
         * @param session el ticket de sesion
         * @param la vista a controlar
         */
        public FormVeterinarioInicioController(FormLoginDataSessionTicket session, FormVeterinarioInicio form)
        {
            this.form = form;
            this.sessionData = session;
            initPerfil();
        }

        /**
      * Inicializa los datos de sesion FALTA LA FOTO!!!!!!!!!!!!!!!!!!!!!
      */
        private void initPerfil()
        {
            form.log_name.Text = sessionData.name;
            form.log_id.Text = sessionData.TOKEN_SESSION;
            form.log_type.Text = sessionData.tipo;
            form.log_date.Text = sessionData.fecha;
            //la foto

        }

        /*
         * Cuando seleccionameos una fecha, del calendario, mostrará las
         * consultas asociadas a ese veterinario en dicho día.
         */
        public void mostrarConsultas(DateTime fecha)
        {
            //limpiamos el datagrid
            form.dataGrid_consultas.Rows.Clear();

            //dia consulta seleccionada
            form.label_fecha_consulta.Text = "Consultas para el día "+fecha.ToString("dd MMMM yyyy");

            //hacer la query a la base de datos pasandole la fecha seleccionada mostrar los resultados
            IList<ConsultaEN> consultas = Utils._ConsultaCEN.DameTodasLasConsultas(0,0);

            bool centinela = false;

            if (consultas != null)
            {//si ha encontrado consultas las muestra
                for (int x = 0; x < consultas.Count; x++)
                {
                    //Si la consulta es para el día seleccionado y la realiza el veterinario logeado 
                    if (consultas[x].Fecha.Equals(fecha) && consultas[x].Veterinario.DNI == sessionData.TOKEN_SESSION)
                    {
                        form.dataGrid_consultas.Rows.Add(consultas[x].Fecha, consultas[x].MotivoConsulta, consultas[x].Lugar);
                        centinela = true;
                    }
                }
            }

            if(!centinela)//Cuando no existan consultas para ese día avisamos
                MessageBox.Show("No existe ninguna consulta para este día");
        }
    }
}
