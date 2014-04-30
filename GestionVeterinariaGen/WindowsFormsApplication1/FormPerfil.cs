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
    public partial class FormPerfil : Form
    {
        /** El controlador de esta vista */
        private FormPerfilController controller;


        /**
         * Contructor de clase
         */
        public FormPerfil(FormLoginDataSessionTicket log) 
        {
            Activate();
            this.Visible = true;
            InitializeComponent();
            controller = new FormPerfilController(log, this);
        }

        /**
         * Cuando se pulsa el boton salir
         */
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Hide();
            new FormStartRecepcionista(controller.sessionData);
        }


        /** 
         * Cuando se pulsa el boton modificar
         */
        private void bt_modificar_Click(object sender, EventArgs e) 
        {
            if (controller.modifiData()) {
                Hide();
                new FormStartRecepcionista(controller.sessionData);
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
