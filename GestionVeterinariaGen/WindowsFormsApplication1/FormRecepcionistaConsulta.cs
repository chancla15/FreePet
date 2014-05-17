using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormRecepcionistaConsulta : Form
    {
        #region Variables

        public FormRecepcionistaConsultaController controller = null;
        public Utils.State state = Utils.State.NONE;
        public string ID = "CONSULTA";
        public ScreenControllerRecepcionista menu = null;
        public bool haBorradoFormulario = false;

        #endregion

        #region Constructor

        public FormRecepcionistaConsulta(ScreenControllerRecepcionista menu)
        {
            this.menu = menu;
            InitializeComponent();
            controller = new FormRecepcionistaConsultaController(this);
        }

        public void changeState(Utils.State st, ConsultaEN consulta)
        {
            state = st;

            if(state!=Utils.State.NONE)
                box_text_cliente.Enabled = false;

            if (state == Utils.State.NEW)
            {
                if (consulta!=null && consulta.Mascota != null)
                    controller.cargarDatosMascota(consulta.Mascota);
            }
            else if (state == Utils.State.MODIFY || state == Utils.State.DESTROY)
            {
                if (consulta != null)
                {
                    controller.cargarDatosConsulta(consulta);

                    if (st == Utils.State.DESTROY)
                        image_del_Click(new object(), new EventArgs());
                }
            }
        }

        #endregion

        #region I/O_Form

        public void ActivateForm()
        {
            Activate();
            this.Visible = true;
        }

        public void DesactivateForm()
        {
            this.Visible = false;

            if (haBorradoFormulario)
            {
                controller.cargarDatosCliente(menu.clienteCompartido);
                haBorradoFormulario = false;
            }
        }

        private void EnableForm(bool t)
        {
            box_text_motivo.Enabled = t;
            box_text_lugar.Enabled = t;
            box_text_cliente.Enabled = t;
            box_text_fecha.Enabled = t;
            box_combo_hora.Enabled = t;
            box_combo_hora.Enabled = t;
            box_combo_mascotas.Enabled = t;
            box_combo_mascotas.Enabled = t;
            box_combo_veterinario.Enabled = t;
            box_label_veterinario.Enabled = t;
            datetime_init.Enabled = t;
            datetime_fin.Enabled = t;
            treeViewConsultas.Enabled = t;

            alerta_eliminar.Enabled = !t;
            alerta_eliminar.Visible = !t;
        }

        #endregion

        #region Botones

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            label_error_fecha.Visible = false;
            box_combo_hora.Text = "";
            if(!controller.buscarPorFechas())
                label_error_fecha.Visible=true;
        }

        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            if ((state == Utils.State.NONE || state == Utils.State.NEW) && menu.LaunchStartScreen())
                DesactivateForm();
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            EnableForm(true);
            haBorradoFormulario = true;
            controller.ClearForm();
            state = Utils.State.NONE;
        }

        private void erase_veterinario_Click(object sender, EventArgs e)
        {
            haBorradoFormulario = true;
            controller.checkBoxVeterinarios();
            controller.cargarHoras();
            box_combo_veterinario.Text = "";
        }

        private void erase_horas_Click(object sender, EventArgs e)
        {
            haBorradoFormulario = true;
            controller.checkBoxVeterinarios();
            controller.cargarHoras();
            box_combo_hora.Text = "";
        }

        private void image_add_Click(object sender, EventArgs e)
        {
            if (state == Utils.State.NONE)
                state = Utils.State.NEW;

            controller.ProcesarInformacion();
        }

        private void image_del_Click(object sender, EventArgs e)
        {
            if (state == Utils.State.MODIFY)
            {
                state = Utils.State.DESTROY;
                EnableForm(false);
            }
        }

        private void btn_eliminar_no_Click(object sender, EventArgs e)
        {
            EnableForm(true);
            state = Utils.State.MODIFY;
        }

        private void btn_eliminar_si_Click(object sender, EventArgs e)
        {
            controller.ProcesarInformacion();
            EnableForm(true);
            state = Utils.State.NONE;
        }
        
        #endregion

        #region ComboBox

        private void box_combo_hora_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.checkBoxVeterinarios();
        }

        #endregion

        #region TreeView_Consultas
        
        private void treeViewConsultas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nodeOp = treeViewConsultas.SelectedNode;

            if (nodeOp != null)
            {
                if (nodeOp.Level == 0)
                {
                    controller.cambiarFecha();

                    if (state != Utils.State.MODIFY)
                        state = Utils.State.NEW;
                }
                else if (nodeOp.Level == 1)
                {
                    state = Utils.State.MODIFY;
                    controller.cargarDatosConsultaDesdeTreeView();
                }
            }
        }  
 
        #endregion

        #region MenuSuperior

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_consultas.BackColor = Color.White;
            this.panel_top.BackColor = Color.LightBlue;
        }

        private void picture_start_Click(object sender, EventArgs e)
        {
            if (menu.LaunchStartScreen())
                DesactivateForm();
        }

        private void picture_clientes_Click(object sender, EventArgs e)
        {
            if (menu.LaunchClienteScreen())
                DesactivateForm();
        }

        private void picture_consultas_Click(object sender, EventArgs e)
        {
            if (menu.LaunchConsultaScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        private void picture_facturas_Click(object sender, EventArgs e)
        {
            if (menu.LaunchFacturaScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        private void picture_ajustes_Click(object sender, EventArgs e)
        {
            menu.Disconnect();
        }

        #endregion
    }
}
