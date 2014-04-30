using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormMascotaRecepcionistaController
     * Sera la encargada de controlar del formulario de mascotas
     */
    class FormMascotaRecepcionistaController
    {
        /** El formulario a controlar */
        private FormMascotaRecepcionista form;

        /** El ticket de sesion */
        public FormLoginDataSessionTicket sessionData;

         /**
         * El constructor
         * @param s el ticket de sesion
         * @param f el formulario a controlar
         */
        public FormMascotaRecepcionistaController(FormLoginDataSessionTicket s, FormMascotaRecepcionista f)
        {
            this.sessionData = s;
            this.form = f;
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

        /**
         * Busca mascotas
         */
        public void Buscar()
        {
            String buscar = form.text_buscar.Text;//String a buscar
            MascotaCEN cen_m = new MascotaCEN();
            IList<MascotaEN> en_mas_nombre = cen_m.DameMascotaPorNombre(buscar);

            if (en_mas_nombre.Count == 0)
                MessageBox.Show("La búsqueda no ha producido ningún resultado");
            else
            {

                form.dataGridView1.DataSource = null;
                form.dataGridView1.Refresh();

                if (form.dataGridView1.Rows.Count != 0)
                    form.dataGridView1.Rows.Clear();
                

                for (int x = 0; x < en_mas_nombre.Count; x++)
                    form.dataGridView1.Rows.Add(en_mas_nombre[x].IdMascota, en_mas_nombre[x].Nombre, en_mas_nombre[x].Cliente.DNI);
            }
        }

        public string getStateScreen(DataGridViewCellEventArgs ev, char action)
        {
            string cli = "";

            if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Eliminar"))
                action = 'E';
            else if (form.dataGridView1.Columns[ev.ColumnIndex].Name.Equals("Modificar"))
                action = 'M';

            if (action == 'E' || action == 'M')
                cli = form.dataGridView1.Rows[ev.RowIndex].Cells[0].Value.ToString();

            return cli;
        }
    }
}
