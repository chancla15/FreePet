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

namespace WindowsFormsApplication1
{
    public partial class FormConsulta : Form
    {
        /** Identificador de la sesion de usuario */
        public string sesionUsuario;

        /** El controlador de esta vista */
        private FormConsultaController controller;

        /**
         * Contructor de clase
         */
        public FormConsulta() {
            InitializeComponent();
            controller = new FormConsultaController(this);
        }

        /**
         * Boton buscar por fecha, el boton ADD, MOD y DEL estaran disponibles. El cuadro del cliente se borrar
         * si hay escrito algo
         */
        private void btnBuscar_Click(object sender, EventArgs e) {
            controller.buscarPorFechas();
        }

        /*
         * Aqui es cuando entramos al box_controller, aqui cargaria los datos inamobibles
         */ 
        private void box_controller_Enter(object sender, EventArgs e) {
            controller.cargarCuadroInformacion();
        }

        /**
         * Con esto salimos del box_controller limpiando todos sus campos
         */ 
        private void box_controller_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            controller.borrarCamposCuadroInformacion();
           // box_controller.Visible = false;
            //controller.activeFormComponents(true);
        }

        /**
         * Metodo para guardar los datos de la consulta
         */
        private void box_label_save_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            controller.guardarCuadroInformacion();
            //box_controller.Visible = false;
            //controller.activeFormComponents(true);
           
          //  DateTime fecha= Convert.ToDateTime(box_text_fecha.Text);
            //TimeSpan hora;
            //String motivo = box_text_motivo.Text;
            //String diagnostico = "";
            //MascotaEN mascota; // = mascotaCEN.buscarMascotaPorNombre(box_combo_mascotas.Text); que me devuelve el oid
            //VeterinarioEN veterinario; //que me devuelva el objeto veterniario
            //String lugar = box_text_lugar.Text;


            // consultaCEN.New_(consultaCEN.DameTodasLasConsultas().Count.ToString(), fecha, hora, motivo, "", mascota.IdMascota, veterinario.DNI, lugar);
        }

        /**
         * Dado un cliente comprueba si existe, y si existe rellena lo que e esta al lao suyo con sus animales correspondientes. 
         */
        private void box_text_cliente_TextChanged(object sender, EventArgs e) {
            controller.checkBoxCliente();
        }

        /**
         * Dada una fecha determinada mostrara todas las horas libres disponibles para ese dia
         */
        private void box_combo_hora_SelectedIndexChanged(object sender, EventArgs e) {
            controller.checkBoxVeterinarios();
        }

        /**
         * Boton Añadir, comprobar si se ha buscado por fecha o por cliente 
         */
        private void image_add_Click(object sender, EventArgs e){
            box_controller.Visible = true;
            //controller.activeFormComponents(false);
            controller.anyadirConsulta();
        }

        /**
         * Boton Modificar, comprobar si se ha buscado por fecha o por cliente 
         */
        private void image_mod_Click(object sender, EventArgs e){
            box_controller.Visible = true;
            //controller.activeFormComponents(false);
            controller.modificarConsulta();
        }

        /**
         * Boton Eliminar, comprobar si se ha buscado por fecha o por cliente 
         */
        private void image_del_Click(object sender, EventArgs e) {
            box_controller.Visible = true;
            //controller.activeFormComponents(false);
            controller.borrarConsulta();
        }

    }
}
