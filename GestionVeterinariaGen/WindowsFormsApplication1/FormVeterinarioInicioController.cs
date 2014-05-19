/* 
    FreePet. OpenSource Software Veterinarian Management
    Copyright (C) 2014  Jesus Manresa Parres

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using System.Windows.Forms;
using System.Drawing;

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
            form.Calendar.MinDate = form.Calendar.TodayDate;
            form.log_name.Text = form.menu.sessionData.name;
            form.log_id.Text = form.menu.sessionData.TOKEN_SESSION;
            form.log_type.Text = form.menu.sessionData.tipo;
            form.log_date.Text = form.menu.sessionData.fecha;
            //la foto
            try
            {

                System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\" + form.menu.sessionData.TOKEN_SESSION + ".png", System.IO.FileMode.Open);
                Console.WriteLine(Environment.CurrentDirectory + @"\" + form.menu.sessionData.TOKEN_SESSION + ".png");
                form.log_photo.Image = Image.FromStream(fs);
                form.log_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                fs.Close();

            }
            catch (Exception ex)
            {
                System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\sinFoto.png", System.IO.FileMode.Open);
                form.log_photo.Image = Image.FromStream(fs);
                fs.Close();
            }

            //cargar por defecto las consultas para el día de hoy
            DateTime hoy = form.Calendar.TodayDate;
            mostrarConsultas(hoy);
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
            form.label_fecha_consulta.Text = "Consultas para el día " + fecha.ToString("dd MMMM yyyy");


            //hacer la query a la base de datos pasandole la fecha seleccionada mostrar los resultados
            IList<ConsultaEN> consultas = Utils._IConsultaCAD.BuscarConsultaPorFecha(fecha);

            if (consultas.Count > 0)
            {//si ha encontrado consultas las muestra
                for (int x = 0; x < consultas.Count; x++)
                {//Si la consulta es para el día seleccionado y la realiza el veterinario logeado 
                    consultas[x].Mascota = Utils._IMascotaCAD.BuscarMascotaPorOID(consultas[x].Mascota.IdMascota);//Los datos de máscota que necesitamos.
                    if (consultas[x].Fecha.Value.ToString("dd/MM/yyyy").Equals(fecha.ToString("dd/MM/yyyy")) && consultas[x].Veterinario.DNI == form.menu.sessionData.TOKEN_SESSION)
                    {
                        form.dataGrid_consultas.Rows.Add(consultas[x].IdConsulta, consultas[x].Fecha.Value.ToString("HH:mm") , consultas[x].Mascota.Nombre ,consultas[x].Mascota.Raza, consultas[x].Mascota.Especie, consultas[x].MotivoConsulta, consultas[x].Lugar);
                    }
                }
            }


        }

        //Dibujar el icono en el datagrid
        public void paintDataGridView(DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && form.dataGrid_consultas.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = form.dataGrid_consultas.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\edit-icon.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                form.dataGrid_consultas.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                form.dataGrid_consultas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;

                e.Handled = true;

            }
        }
    }

}
