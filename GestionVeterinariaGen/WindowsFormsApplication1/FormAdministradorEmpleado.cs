using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormAdministradorEmpleado : Form
    {

        #region Variables

        /** El controlador */
        private FormAdministradorEmpleadoController controller = null;

        /** EL tipo de accion, ADD,MOD,DEL */
        public Utils.State state = Utils.State.NONE;

        /** El identificador de la clase */
        public string ID = "EMPLEADO";

        /** EL controlador del menu superior */
        public ScreenControllerAdministrador menu = null;

        #endregion


        /**
         * Contructor de clase
         */
        public FormAdministradorEmpleado(FormLoginDataSessionTicket log) 
        {
            Activate();
            this.Visible = true;
            InitializeComponent();
            controller = new FormAdministradorEmpleadoController(log, this);
        }

        /**
         * Cuando se pulsa el boton salir
         */
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Hide();
            //new FormRecepcionistaAdministradorInicio(controller.sessionData);
        }


        /** 
         * Cuando se pulsa el boton modificar
         */
        private void bt_modificar_Click(object sender, EventArgs e) 
        {
            if (controller.modifiData()) {
                Hide();
                //new FormRecepcionistaAdministradorInicio(controller.sessionData);
            }
        }

        /**
         * Cuando se pulsa la foto
         */
        private void pictureBox1_Click(object sender, EventArgs e) {
            controller.clickInPhoto();
        }

        /**
         * Cuando escribimos el dni
         */
        private void tb_dni_TextChanged(object sender, EventArgs e) {
            controller.showData();
        }
    }
}
