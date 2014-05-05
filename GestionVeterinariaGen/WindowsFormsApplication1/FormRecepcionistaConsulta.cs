﻿using System;
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
    public partial class FormRecepcionistaConsulta : Form
    {
        /** El controlador de esta vista */
        private FormRecepcionistaConsultaController controller;

        /**
         * Contructor de clase
         */
        public FormRecepcionistaConsulta(FormLoginDataSessionTicket log) {

            Activate();
            this.Visible = true;
            InitializeComponent();
            controller = new FormRecepcionistaConsultaController(this, log);
        }

        /**
         * Boton buscar por fecha, el boton ADD, MOD y DEL estaran disponibles. El cuadro del cliente se borrar
         * si hay escrito algo
         */
        private void btnBuscar_Click(object sender, EventArgs e) {
            controller.buscarPorFechas();
        }

        /**
         * Con esto salimos del box_controller limpiando todos sus campos
         */ 
        private void box_controller_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            controller.borrarCamposCuadroInformacion();
            box_controller.Visible = false;
            activeFormComponentsAddModDel(true);
        }

        /**
         * Metodo para guardar los datos de la consulta
         */
        private void box_label_save_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            controller.guardarCuadroInformacion();
            box_controller.Visible = false;
            activeFormComponentsAddModDel(true);
            
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
            box_label_save.Visible = true;
            linklabel_eliminar.Visible = false;
            activeFormComponentsAddModDel(false);
            controller.anyadirConsulta();
            treeViewConsultas.SelectedNode = null;
        }

        /**
         * Boton Modificar, comprobar si se ha buscado por fecha o por cliente 
         */
        private void image_mod_Click(object sender, EventArgs e){
            box_controller.Visible = true;
            box_label_save.Visible = true;
            linklabel_eliminar.Visible = false;
            activeFormComponentsAddModDel(false);
            controller.modificarConsulta();
            treeViewConsultas.SelectedNode = null;
        }

        /**
         * Boton Eliminar, comprobar si se ha buscado por fecha o por cliente 
         */
        private void image_del_Click(object sender, EventArgs e)
        {
            box_controller.Visible = true;
            box_label_save.Visible = false;
            linklabel_eliminar.Visible = true;
            activeFormComponentsAddModDel(false);
            controller.borrarConsulta();
        }

        /** 
         * CUando clikeamos en una fecha de la pantalla principal se cambia a la de introducir datos consulta
         */
        private void treeViewConsultas_AfterSelect(object sender, TreeViewEventArgs e){
            controller.cambiarFecha();
        }

        private void linklabel_eliminar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            alerta_eliminar.Visible = true;
            activeFormComponents(false);
        }

        private void btn_eliminar_no_Click(object sender, EventArgs e)
        {
            alerta_eliminar.Visible = false;
            activeFormComponents(true);
        }

        private void btn_eliminar_si_Click(object sender, EventArgs e)
        {
            alerta_eliminar.Visible = false;
            controller.borrarConsulta();
            activeFormComponents(true);
        }

        /**
         * Deshabilita los componentes de  la pantalla 
         */
        public void activeFormComponents(Boolean t)
        {
            datetime_init.Enabled = t;
            datetime_fin.Enabled = t;
            btnBuscar_Fecha.Enabled = t;
            treeViewConsultas.Enabled = t;
            box_controller.Visible = t;
            activeFormComponents(t);
        }

        /**
         * Forma chapucera de que no se vean las imagenes de add, mod del en el boxcontroller
         */
        public void activeFormComponentsAddModDel(Boolean t)
        {
            image_add.Enabled = image_add.Visible = t;
            image_mod.Enabled = image_mod.Visible = t;
            image_del.Enabled = t;
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_consultas.BackColor = Color.White;
            this.panel_top.BackColor = Color.LightBlue;
        }

        /**
    * Cuando se slecciona la opcion start
    */
        private void picture_start_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaAdministradorInicio(controller.sessionData);
        }

        /**
         * Cuando se slecciona la opcion clientes
         */
        private void picture_clientes_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaCliente(controller.sessionData, 'A');
        }

        /**
         * Cuando se slecciona la opcion consultas
         */
        private void picture_consultas_Click(object sender, EventArgs e)
        {
        }

        /**
         * Cuando se slecciona la opcion facturas
         */
        private void picture_facturas_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaFactura(controller.sessionData);
        }

        /**
         * Cuando se slecciona la opcion ajustes
         */
        private void picture_ajustes_Click(object sender, EventArgs e)
        {
            //Esto solo le da a un formulario
            //donde puede cambiar algunos datos personales, la constraseña la foto y desconectarse
        }

     
    }
}