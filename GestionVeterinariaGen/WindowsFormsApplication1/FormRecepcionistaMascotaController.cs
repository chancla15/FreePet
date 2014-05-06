using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    /**
     * La clase FormMascotaRecepcionistaController
     * Sera la encargada de controlar del formulario de mascotas
     */
    class FormRecepcionistaMascotaController
    {
        #region Variables

        /** El formulario a controlar */
        private FormRecepcionistaMascota form;

        /** La lista de mascotas del cliente por si se ha metido al formulario para meter una nueva mascota */
        public IList<MascotaEN> list_mascotas_clientes = null;

        /** El cliente de esta pantalla */
        public ClienteEN clienteEN = null;

        /** La mascota de esta pantalla */
        public MascotaEN mascotaEN = null;

        #endregion

        #region Constructor

        /**
         * El constructor
         * @param s el ticket de sesion
         * @param f el formulario a controlar
         */
        public FormRecepcionistaMascotaController(FormRecepcionistaMascota f)
        {
            this.form = f;

            form.combo_tamanyo.Items.Add(GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XS);
            form.combo_tamanyo.Items.Add(GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.S);
            form.combo_tamanyo.Items.Add(GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.M);
            form.combo_tamanyo.Items.Add(GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.L);
            form.combo_tamanyo.Items.Add(GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.TamanyoMascotaEnum.XL);

            form.combo_sexo.Items.Add(GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Hembra);
            form.combo_sexo.Items.Add(GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria.SexoEnum.Macho);

            form.combo_microchip.Items.Add(true);
            form.combo_microchip.Items.Add(false);
        }

        #endregion

        #region ProcesarDatos

        /**
         * Carga los datos de una mascota en el formulario 
         */
        public void loadDataMascota(MascotaEN msc)
        {
            mascotaEN = msc;

            if (mascotaEN != null)
            {
                form.text_cliente.Text = mascotaEN.Cliente.DNI;
                form.text_especie.Text = mascotaEN.Especie;
                form.text_raza.Text = mascotaEN.Raza;
                form.combo_tamanyo.SelectedItem = mascotaEN.Tamanyo;
                form.text_peso.Text = mascotaEN.Peso.ToString();
                form.dateTime_fnac.Value = mascotaEN.FNacimiento.Value;
                form.combo_sexo.SelectedItem = mascotaEN.Sexo;
                form.text_color.Text = mascotaEN.Color;
                form.combo_microchip.SelectedItem = mascotaEN.Microchip;
            }
        }

        /**
        * Carga una mascota en el formulario
        */
        public void loadDataCliente(ClienteEN cli, MascotaEN msc)
        {
            ClearForm();
            clienteEN = cli;
            mascotaEN = msc;
            string dni = "";

            if (clienteEN == null && mascotaEN == null)
            {
            }
            else if (clienteEN != null && mascotaEN == null)
            {
                form.text_cliente.Text = clienteEN.DNI;
                dni = clienteEN.DNI;
            }
            else if (mascotaEN != null)
            {
                dni = clienteEN.DNI;
                loadDataMascota(msc);
            }

            //MUESTRA EL DNI CLIENTE CON UN COMBOBOX CON LAS MASCOTAS QUE TIENE Y LA OPCION DE AÑADIR UNA
            list_mascotas_clientes = Utils._IMascotaCAD.DameMascotaPorCliente(dni);

            if (list_mascotas_clientes != null && list_mascotas_clientes.Count > 0)
            {
                for (int i = 0; i < list_mascotas_clientes.Count; i++)
                    form.combo_nombreAnimal.Items.Add(list_mascotas_clientes[i].Nombre);
            }

            if(mascotaEN!=null)
                form.combo_nombreAnimal.SelectedItem = mascotaEN.Nombre;
        }

        /**
         * Carga las consultas de un animal una vez seleccionada uno
         */
        public void cargarConsultasAnimal()
        {
            if (mascotaEN == null) {
                String nameMsc = form.combo_nombreAnimal.SelectedItem.ToString();

                for (int i = 0; i < list_mascotas_clientes.Count; i++) {
                    if (list_mascotas_clientes[i].Nombre == nameMsc) {
                        mascotaEN = list_mascotas_clientes[i];
                        break;
                    }
                }
            }

            IList<ConsultaEN> consultas = Utils._IConsultaCAD.DameConsultaPorAnimal(mascotaEN.IdMascota);
            VeterinarioEN veterinario = null;
            form.dataGridView.DataSource = null;
            form.dataGridView.Refresh();
            if (form.dataGridView.Rows.Count > 0)
                form.dataGridView.Rows.Clear();

            if (consultas != null && consultas.Count > 0) {
                for (int i = 0; i < consultas.Count; i++) {
                    veterinario = Utils._IVeterinarioCAD.DameVetarinarioPorOID(consultas[i].Veterinario.DNI);
                    string vet = veterinario.Nombre + " " + veterinario.Apellidos;
                    form.dataGridView.Rows.Add(consultas[i].Fecha.Value.ToString(), consultas[i].MotivoConsulta, consultas[i].Lugar, vet);
                }
            }
        }

        /**
         * Procesa la informacion del formulario y dependiendo del estado de la pantalla
         * hace una cosa o otra
         */
        public void ProcesarInformacion()
        {
            //SI es una nueva mascota se añade todo, sino solo los campos disponibles
            if ((mascotaEN == null && form.state == Utils.State.NEW)
                || (clienteEN != null && form.state == Utils.State.MODIFY)
                || (clienteEN != null && form.state == Utils.State.DESTROY))
            {

                //Comprueba el cliente
                if (form.text_cliente.Text != "")
                    mascotaEN.Cliente = Utils._IClienteCAD.DameClientePorOID(form.text_cliente.Text);
                else { }

                //Comprueba el nombre del animal
                if (form.combo_nombreAnimal.SelectedItem != null)
                    mascotaEN.Nombre = form.combo_nombreAnimal.SelectedItem.ToString();
                else { }

                //Comprueba la especie del animal
                if (form.text_especie.Text != "")
                    mascotaEN.Especie = form.text_especie.Text;
                else { }

                //Comprueba la raza del animal
                if (form.text_raza.Text != "")
                    mascotaEN.Raza = form.text_raza.Text;
                else { }

                //Adquiere la fecha
                mascotaEN.FNacimiento = form.dateTime_fnac.Value;

                //Adquiere el sexo
               /* if (form.combo_sexo.SelectedItem != null)
                    mascotaEN.Sexo = form.combo_sexo.SelectedItem;
                else { }*/

                //Adquiere el tamaño
               /* if (form.combo_tamanyo.SelectedItem != null)
                    mascotaEN.Tamanyo = form.combo_tamanyo.SelectedItem;
                else { }*/

                //Adquiere el peso
                /*if (form.text_peso.Text != "")
                    mascotaEN.Peso = Convert.ToDecimal(form.text_peso.Text);
                else { }*/

                //Adquiere el color
                if (form.text_color.Text != "")
                    mascotaEN.Color = form.text_color.Text;
                else { }

                //Adquiere si tiene microchip o no
                /*if (form.combo_microchip.SelectedItem != null)
                    mascotaEN.Microchip = form.combo_microchip.SelectedItem;
                else { }*/



                switch (form.state)
                {
                    case Utils.State.NONE:
                        break;
                    case Utils.State.NEW:
                            Utils._MascotaCEN.New_(mascotaEN.Nombre, mascotaEN.Raza, mascotaEN.Sexo, mascotaEN.Peso, mascotaEN.Especie, mascotaEN.FNacimiento, mascotaEN.Tamanyo, mascotaEN.Cliente.DNI, mascotaEN.Color, mascotaEN.Microchip, mascotaEN.Foto);
                        break;
                    case Utils.State.MODIFY:
                            Utils._MascotaCEN.Modify(mascotaEN.IdMascota, mascotaEN.Nombre, mascotaEN.Raza, mascotaEN.Sexo, mascotaEN.Peso, mascotaEN.Especie, mascotaEN.FNacimiento, mascotaEN.Tamanyo, mascotaEN.Color, mascotaEN.Microchip, mascotaEN.Foto); 
                        break;
                    case Utils.State.DESTROY:
                            Utils._MascotaCEN.Destroy(mascotaEN.IdMascota);
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region DataGridView_Consultas

        /**
         * Devuelve la columna pulsada
         * @param ev la columna seleccionada
         * @param action el tipo de accion
         */
        public string getStateScreen(DataGridViewCellEventArgs ev, ref Utils.State st)
        {
            string cli = "";
            /*if (form.dataGridView.Columns[ev.ColumnIndex].Name.Equals("Eliminar"))
                st = Utils.State.DESTROY;
            else if (form.dataGridView.Columns[ev.ColumnIndex].Name.Equals("Modificar"))
                st = Utils.State.MODIFY;

            if (st== Utils.State.MODIFY || st==Utils.State.DESTROY)
                cli = form.dataGridView.Rows[ev.RowIndex].Cells[0].Value.ToString();
            */
            return cli;
        }

        #endregion

        #region BorrarTodosLosCampos

        /**
         * Borra todos los campos del formulario
         */
        public void ClearForm()
        {
            form.text_cliente.Enabled = true;
            form.text_cliente.Text = "";
            form.combo_nombreAnimal.SelectedItem = null;
            form.text_especie.Text = "";
            form.text_raza.Text = "";
            form.combo_tamanyo.SelectedItem = null;
            form.text_peso.Text = "";
            form.dateTime_fnac.Value = DateTime.Today;
            form.combo_sexo.SelectedItem = null;
            form.text_color.Text = "";
            form.combo_microchip.SelectedItem = null;

            form.dataGridView.DataSource = null;
            form.dataGridView.Refresh();
            if (form.dataGridView.Rows.Count > 0)
                form.dataGridView.Rows.Clear();
        }

        #endregion
    }
}
