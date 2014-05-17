using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.Enumerated.GestionVeterinaria;
using System.Drawing;

namespace WindowsFormsApplication1
{

    public class FormRecepcionistaMascotaController
    {
        #region Variables

        private FormRecepcionistaMascota form = null;
        public IList<MascotaEN> list_mascotas_clientes = null;
        public ClienteEN clienteEN = null;
        public MascotaEN mascotaEN = null;
        IList<ConsultaEN> consultas_animal = null;

        #endregion

        #region Constructor

        public FormRecepcionistaMascotaController(FormRecepcionistaMascota f)
        {
            this.form = f;

            form.combo_tamanyo.Items.Add(TamanyoMascotaEnum.XS);
            form.combo_tamanyo.Items.Add(TamanyoMascotaEnum.S);
            form.combo_tamanyo.Items.Add(TamanyoMascotaEnum.M);
            form.combo_tamanyo.Items.Add(TamanyoMascotaEnum.L);
            form.combo_tamanyo.Items.Add(TamanyoMascotaEnum.XL);

            form.combo_sexo.Items.Add(SexoEnum.Hembra);
            form.combo_sexo.Items.Add(SexoEnum.Macho);

            form.combo_microchip.Items.Add(true);
            form.combo_microchip.Items.Add(false);
        }

        public void cargarDatosMascota(MascotaEN msc)
        {
            mascotaEN = msc;

            if (mascotaEN != null)
            {
                form.combo_nombreAnimal.SelectedItem = mascotaEN.Nombre;
                form.text_especie.Text = mascotaEN.Especie;
                form.text_raza.Text = mascotaEN.Raza;
                form.combo_tamanyo.SelectedItem = mascotaEN.Tamanyo;
                form.text_peso.Text = mascotaEN.Peso.ToString();
                form.dateTime_fnac.Value = mascotaEN.FNacimiento.Value;
                form.combo_sexo.SelectedItem = mascotaEN.Sexo;
                form.text_color.Text = mascotaEN.Color;
                form.combo_microchip.SelectedItem = mascotaEN.Microchip;

                if (mascotaEN.Microchip == true)
                    form.combo_microchip.Enabled = false;
                else
                    form.combo_microchip.Enabled = true;

                //Cargamos la imagen
                try
                {

                    System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\" + mascotaEN.IdMascota + ".png", System.IO.FileMode.Open);
                    form.log_photo.Image = Image.FromStream(fs);
                    form.log_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                    fs.Close();

                }
                catch (Exception ex)
                {
                    System.IO.FileStream fs = new System.IO.FileStream(Environment.CurrentDirectory + @"\sinFotoa.png", System.IO.FileMode.Open);
                    form.log_photo.Image = Image.FromStream(fs);
                    fs.Close();
                }

                cargarConsultasAnimal();
            }
            else
            {
                ClearForm();
                form.combo_microchip.Enabled = true;
                form.text_cliente.Text = clienteEN.DNI;
            }
        }

        public void cargarDatosCliente(ClienteEN cli)
        {
            form.combo_nombreAnimal.Items.Clear();

            clienteEN = cli;

            if (clienteEN != null)
            {
                form.text_cliente.Text = clienteEN.DNI;
                //MUESTRA EL DNI CLIENTE CON UN COMBOBOX CON LAS MASCOTAS QUE TIENE Y LA OPCION DE AÑADIR UNA
                list_mascotas_clientes = Utils._IMascotaCAD.DameMascotaPorCliente(clienteEN.DNI);

                if (list_mascotas_clientes != null && list_mascotas_clientes.Count > 0)
                {
                    for (int i = 0; i < list_mascotas_clientes.Count; i++)
                        form.combo_nombreAnimal.Items.Add(list_mascotas_clientes[i].Nombre);
                }
            }
        }

        #endregion

        #region ComboBox_Animal

        public MascotaEN DevolverMascotaENComboBox()
        {
            if (list_mascotas_clientes != null && form.combo_nombreAnimal.SelectedItem != null)
            {
                for (int i = 0; i < list_mascotas_clientes.Count; i++)
                    if (list_mascotas_clientes[i].Nombre == form.combo_nombreAnimal.SelectedItem.ToString())
                    {
                        return list_mascotas_clientes[i];
                    }
            }

            return null;
        }

        #endregion

        #region ProcesarDatos

        public void ocultarErroresProcesarInformacion()
        {
            form.error_nombre.Visible = false;
            form.error_raza.Visible = false;
            form.error_especie.Visible = false;
            form.error_fechanac.Visible = false;
            form.error_sexo.Visible = false;
            form.error_tamanyo.Visible = false;
            form.error_peso.Visible = false;
        }

        public void ProcesarInformacion()
        {
            ocultarErroresProcesarInformacion();
            Boolean fail = false;

            if (mascotaEN == null)
            {

                mascotaEN = new MascotaEN();
                form.state = Utils.State.NEW;
                
            }else


                    mascotaEN.Cliente = clienteEN;

                    if (form.combo_nombreAnimal.Text != "")
                        mascotaEN.Nombre = form.combo_nombreAnimal.Text;
                    else
                    {
                        fail = true;
                        form.error_nombre.Visible = true;
                    }

                    if (form.text_raza.Text != "") //raza
                        mascotaEN.Raza = form.text_raza.Text;
                    else
                    {
                        fail = true;
                        form.error_raza.Visible = true;
                    }

                    if (form.text_especie.Text != "")  //especie
                        mascotaEN.Especie = form.text_especie.Text;
                    else
                    {
                        fail = true;
                        form.error_especie.Visible = true;
                    }

                    if (form.dateTime_fnac.Value != null)  //fecha_nac
                        mascotaEN.FNacimiento = form.dateTime_fnac.Value;
                    else
                    {
                        fail = true;
                        form.error_fechanac.Visible = true;
                    }

                    if (form.combo_sexo.SelectedItem != null) //sexo
                    {
                        if (form.combo_sexo.SelectedItem.ToString() == "Macho")
                        {

                            mascotaEN.Sexo = SexoEnum.Macho;

                        }
                        else
                        {

                            mascotaEN.Sexo = SexoEnum.Hembra;

                        }
                    }
                    else
                    {
                        fail = true;
                        form.error_sexo.Visible = true;
                    }

                    if (form.combo_tamanyo.SelectedItem != null)
                    {

                        if (form.combo_tamanyo.SelectedItem.ToString() == "L")
                        {
                            mascotaEN.Tamanyo = TamanyoMascotaEnum.L;
                        }
                        else if (form.combo_tamanyo.SelectedItem.ToString() == "M")
                        {

                            mascotaEN.Tamanyo = TamanyoMascotaEnum.M;

                        }
                        else if (form.combo_tamanyo.SelectedItem.ToString() == "S")
                        {

                            mascotaEN.Tamanyo = TamanyoMascotaEnum.S;

                        }
                        else if (form.combo_tamanyo.SelectedItem.ToString() == "XS")
                        {

                            mascotaEN.Tamanyo = TamanyoMascotaEnum.XS;

                        }
                        else
                        {

                            mascotaEN.Tamanyo = TamanyoMascotaEnum.XL;

                        }
                    }
                    else
                    {
                        fail = true;
                        form.error_tamanyo.Visible = true;
                    }

                    //Adquiere el peso
                    int i = 0;
                    if (form.text_peso.Text != "" && int.TryParse(form.text_peso.Text.ToString(), out i))
                        mascotaEN.Peso = Convert.ToInt32(form.text_peso.Text);
                    else
                    {
                        fail = true;
                        form.error_peso.Visible = true;
                    }

                    //Adquiere el color
                    if (form.text_color.Text != "")
                        mascotaEN.Color = form.text_color.Text;


                    //Adquiere si tiene microchip o no
                    if (form.combo_microchip.SelectedItem != null)
                        mascotaEN.Microchip = Convert.ToBoolean(form.combo_microchip.SelectedItem);



                    if (!fail)
                    {
                        switch (form.state)
                        {
                            case Utils.State.NEW:
                                mascotaEN.IdMascota= Utils._MascotaCEN.New_(mascotaEN.Nombre, mascotaEN.Raza, mascotaEN.Sexo, mascotaEN.Peso, mascotaEN.Especie, mascotaEN.FNacimiento, mascotaEN.Tamanyo, mascotaEN.Cliente.DNI, mascotaEN.Color, mascotaEN.Microchip);
                                MessageBox.Show("Mascota creada con exito");
                                list_mascotas_clientes.Add(mascotaEN);
                                break;
                            case Utils.State.MODIFY:
                                list_mascotas_clientes.Remove(mascotaEN);
                                Utils._MascotaCEN.Modify(mascotaEN.IdMascota, mascotaEN.Nombre, mascotaEN.Raza, mascotaEN.Sexo, mascotaEN.Peso, mascotaEN.Especie, mascotaEN.FNacimiento, mascotaEN.Tamanyo, mascotaEN.Color, mascotaEN.Microchip);
                                MessageBox.Show("Mascota modiificada con exito");
                                list_mascotas_clientes.Add(mascotaEN);
                                break;
                            case Utils.State.DESTROY:
                                Utils._MascotaCEN.Destroy(mascotaEN.IdMascota);
                                MessageBox.Show("Mascota eliminado con exito");
                                list_mascotas_clientes.Remove(mascotaEN);
                                form.combo_nombreAnimal.Refresh();
                                break;
                        }
                        

                        ClearForm();

                    }
                    else
                        MessageBox.Show("Revisa los campos");
        }

        #endregion

        #region DataGridView_Consultas

        public void cargarConsultasAnimal()
        {
            if (consultas_animal != null)
                consultas_animal.Clear();

            if (mascotaEN == null)
            {
                String nameMsc = form.combo_nombreAnimal.SelectedItem.ToString();

                for (int i = 0; i < list_mascotas_clientes.Count; i++)
                {
                    if (list_mascotas_clientes[i].Nombre == nameMsc)
                    {
                        mascotaEN = list_mascotas_clientes[i];
                        break;
                    }
                }
            }

            consultas_animal = Utils._IConsultaCAD.DameConsultaPorAnimal(mascotaEN.IdMascota);
            VeterinarioEN veterinario = null;
            form.dataGridView.DataSource = null;
            form.dataGridView.Refresh();
            if (form.dataGridView.Rows.Count > 0)
                form.dataGridView.Rows.Clear();

            if (consultas_animal != null && consultas_animal.Count > 0)
            {
                for (int i = 0; i < consultas_animal.Count; i++)
                {
                    veterinario = Utils._IVeterinarioCAD.DameVetarinarioPorOID(consultas_animal[i].Veterinario.DNI);
                    string vet = veterinario.Nombre + " " + veterinario.Apellidos;
                    form.dataGridView.Rows.Add(consultas_animal[i].Fecha.Value.ToString(), consultas_animal[i].MotivoConsulta, consultas_animal[i].Lugar, vet);
                }
            }
        }

        public ConsultaEN getStateScreen(DataGridViewCellEventArgs ev, ref Utils.State st)
        {
            string cli = "";
            ConsultaEN c = null;
            if (form.dataGridView.Columns[ev.ColumnIndex].Name.Equals("Ver"))
                st = Utils.State.MODIFY;

            if (st != Utils.State.NONE)
                cli = form.dataGridView.Rows[ev.RowIndex].Cells[0].Value.ToString();

            //  if (cli != "")
            //    c = Utils._IConsultaCAD.DameConsultaPorOID(Convert.ToInt32(cli));

            return c;
        }

        #endregion

        #region BorrarTodosLosCampos

        public void ClearForm()
        {
            //form.text_cliente.Enabled = true;
            //form.text_cliente.Text = "";
            form.combo_nombreAnimal.SelectedIndex = -1;
            form.text_especie.Text = "";
            form.text_raza.Text = "";
            form.combo_tamanyo.SelectedIndex = -1;
            form.text_peso.Text = "";
            form.dateTime_fnac.Value = DateTime.Today;
            form.combo_sexo.SelectedIndex = -1;
            form.text_color.Text = "";
            form.combo_microchip.SelectedIndex = -1;

            form.dataGridView.DataSource = null;
            form.dataGridView.Refresh();

            if (form.dataGridView.Rows.Count > 0)
                form.dataGridView.Rows.Clear();
        }

        #endregion

        /** 
         * Modifica la foto
         */
        public void clickInPhoto()
        {
            form.openFileDialog1.Filter = "PNG Files(*.png)|*.png";

            if (form.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagen = form.openFileDialog1.FileName;
                form.log_photo.Image = Image.FromFile(imagen);
                form.log_photo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
