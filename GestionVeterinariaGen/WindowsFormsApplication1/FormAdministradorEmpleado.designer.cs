﻿/* 
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
namespace WindowsFormsApplication1
{
    partial class FormAdministradorEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.log_photo = new System.Windows.Forms.PictureBox();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apellidos = new System.Windows.Forms.TextBox();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_localidad = new System.Windows.Forms.TextBox();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_sueldo = new System.Windows.Forms.TextBox();
            this.tb_provincia = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_top = new System.Windows.Forms.Panel();
            this.picture_desconectar_admin = new System.Windows.Forms.PictureBox();
            this.picture_home = new System.Windows.Forms.PictureBox();
            this.picture_tratamiento = new System.Windows.Forms.PictureBox();
            this.picture_empleado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tipo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.btn_erase = new System.Windows.Forms.PictureBox();
            this.btn_buscar_dni = new System.Windows.Forms.PictureBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label_col = new System.Windows.Forms.Label();
            this.tb_colegiado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_desconectar_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_erase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_dni)).BeginInit();
            this.SuspendLayout();
            // 
            // log_photo
            // 
            this.log_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.log_photo.ErrorImage = null;
            this.log_photo.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.log_photo.InitialImage = null;
            this.log_photo.Location = new System.Drawing.Point(25, 66);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(94, 120);
            this.log_photo.TabIndex = 3;
            this.log_photo.TabStop = false;
            this.log_photo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tb_dni
            // 
            this.tb_dni.Location = new System.Drawing.Point(218, 79);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(163, 20);
            this.tb_dni.TabIndex = 5;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(218, 115);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(163, 20);
            this.tb_nombre.TabIndex = 6;
            // 
            // tb_apellidos
            // 
            this.tb_apellidos.Location = new System.Drawing.Point(134, 207);
            this.tb_apellidos.Name = "tb_apellidos";
            this.tb_apellidos.Size = new System.Drawing.Size(247, 20);
            this.tb_apellidos.TabIndex = 7;
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(134, 285);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(247, 20);
            this.tb_direccion.TabIndex = 8;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(218, 329);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(163, 20);
            this.tb_tel.TabIndex = 9;
            // 
            // tb_localidad
            // 
            this.tb_localidad.Location = new System.Drawing.Point(218, 360);
            this.tb_localidad.Name = "tb_localidad";
            this.tb_localidad.Size = new System.Drawing.Size(163, 20);
            this.tb_localidad.TabIndex = 10;
            // 
            // tb_cp
            // 
            this.tb_cp.Location = new System.Drawing.Point(218, 426);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.Size = new System.Drawing.Size(163, 20);
            this.tb_cp.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(132, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(132, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(29, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(29, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(29, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(29, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Localidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(29, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Provincia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(29, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "CP:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(29, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Sueldo:";
            // 
            // tb_sueldo
            // 
            this.tb_sueldo.Location = new System.Drawing.Point(218, 245);
            this.tb_sueldo.Name = "tb_sueldo";
            this.tb_sueldo.Size = new System.Drawing.Size(163, 20);
            this.tb_sueldo.TabIndex = 21;
            // 
            // tb_provincia
            // 
            this.tb_provincia.FormattingEnabled = true;
            this.tb_provincia.Items.AddRange(new object[] {
            "Álava",
            "Albacete",
            "Alicante",
            "Almería",
            "Asturias",
            "Ávila",
            "Badajoz",
            "Barcelona",
            "Burgos",
            "Cáceres",
            "Cádiz",
            "Cantabria",
            "Castellón",
            "Ciudad Real",
            "Córdoba",
            "La Coruña",
            "Cuenca",
            "Gerona",
            "Granada",
            "Guadalajara",
            "Guipúzcoa",
            "Huelva",
            "Huesca",
            "Islas Baleares",
            "Jaén",
            "León",
            "Lérida",
            "Lugo",
            "Madrid",
            "Málaga",
            "Murcia",
            "Navarra",
            "Orense",
            "Palencia",
            "Las Palmas",
            "Pontevedra",
            "La Rioja",
            "Salamanca",
            "Segovia",
            "Sevilla",
            "Soria",
            "Tarragona",
            "Santa Cruz de Tenerife",
            "Teruel",
            "Toledo",
            "Valencia",
            "Valladolid",
            "Vizcaya",
            "Zamora",
            "Zaragoza"});
            this.tb_provincia.Location = new System.Drawing.Point(218, 395);
            this.tb_provincia.Name = "tb_provincia";
            this.tb_provincia.Size = new System.Drawing.Size(163, 21);
            this.tb_provincia.TabIndex = 51;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Transparent;
            this.panel_top.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.PANELSUPERIOR;
            this.panel_top.Controls.Add(this.picture_desconectar_admin);
            this.panel_top.Controls.Add(this.picture_home);
            this.panel_top.Controls.Add(this.picture_tratamiento);
            this.panel_top.Controls.Add(this.picture_empleado);
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(690, 44);
            this.panel_top.TabIndex = 56;
            // 
            // picture_desconectar_admin
            // 
            this.picture_desconectar_admin.BackColor = System.Drawing.Color.Transparent;
            this.picture_desconectar_admin.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_ADMINISTRADOR_DESCONECTAR;
            this.picture_desconectar_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_desconectar_admin.Location = new System.Drawing.Point(510, 0);
            this.picture_desconectar_admin.Name = "picture_desconectar_admin";
            this.picture_desconectar_admin.Size = new System.Drawing.Size(172, 44);
            this.picture_desconectar_admin.TabIndex = 9;
            this.picture_desconectar_admin.TabStop = false;
            this.picture_desconectar_admin.Click += new System.EventHandler(this.picture_desconectar_admin_Click);
            // 
            // picture_home
            // 
            this.picture_home.BackColor = System.Drawing.Color.Transparent;
            this.picture_home.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_ADMINISTRADOR_INICIO;
            this.picture_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_home.Location = new System.Drawing.Point(0, 0);
            this.picture_home.Name = "picture_home";
            this.picture_home.Size = new System.Drawing.Size(172, 44);
            this.picture_home.TabIndex = 5;
            this.picture_home.TabStop = false;
            this.picture_home.Click += new System.EventHandler(this.picture_start_Click);
            // 
            // picture_tratamiento
            // 
            this.picture_tratamiento.BackColor = System.Drawing.Color.Transparent;
            this.picture_tratamiento.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_ADMINISTRADOR_TRATAMIENTO;
            this.picture_tratamiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_tratamiento.Location = new System.Drawing.Point(340, 0);
            this.picture_tratamiento.Name = "picture_tratamiento";
            this.picture_tratamiento.Size = new System.Drawing.Size(172, 44);
            this.picture_tratamiento.TabIndex = 8;
            this.picture_tratamiento.TabStop = false;
            this.picture_tratamiento.Click += new System.EventHandler(this.picture_tratamientos_Click);
            // 
            // picture_empleado
            // 
            this.picture_empleado.BackColor = System.Drawing.Color.GreenYellow;
            this.picture_empleado.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_ADMINISTRADOR_EMPLEADO;
            this.picture_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_empleado.Location = new System.Drawing.Point(169, 0);
            this.picture_empleado.Name = "picture_empleado";
            this.picture_empleado.Size = new System.Drawing.Size(172, 44);
            this.picture_empleado.TabIndex = 7;
            this.picture_empleado.TabStop = false;
            this.picture_empleado.Click += new System.EventHandler(this.picture_empleados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(432, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tipo:";
            // 
            // tb_tipo
            // 
            this.tb_tipo.FormattingEnabled = true;
            this.tb_tipo.Items.AddRange(new object[] {
            "Veterinario",
            "Recepcionista"});
            this.tb_tipo.Location = new System.Drawing.Point(507, 152);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.Size = new System.Drawing.Size(163, 21);
            this.tb_tipo.TabIndex = 58;
            this.tb_tipo.SelectedIndexChanged += new System.EventHandler(this.tb_tipo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(132, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Password:";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(218, 153);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(163, 20);
            this.tb_pass.TabIndex = 59;
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // btn_erase
            // 
            this.btn_erase.BackColor = System.Drawing.Color.Transparent;
            this.btn_erase.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.eraser;
            this.btn_erase.Location = new System.Drawing.Point(411, 83);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(16, 16);
            this.btn_erase.TabIndex = 82;
            this.btn_erase.TabStop = false;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // btn_buscar_dni
            // 
            this.btn_buscar_dni.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar_dni.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.btn_buscar_id;
            this.btn_buscar_dni.Location = new System.Drawing.Point(389, 83);
            this.btn_buscar_dni.Name = "btn_buscar_dni";
            this.btn_buscar_dni.Size = new System.Drawing.Size(16, 16);
            this.btn_buscar_dni.TabIndex = 81;
            this.btn_buscar_dni.TabStop = false;
            this.btn_buscar_dni.Click += new System.EventHandler(this.btn_buscar_dni_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(595, 422);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 83;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(595, 393);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 78;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label_col
            // 
            this.label_col.AutoSize = true;
            this.label_col.BackColor = System.Drawing.Color.Transparent;
            this.label_col.Location = new System.Drawing.Point(432, 189);
            this.label_col.Name = "label_col";
            this.label_col.Size = new System.Drawing.Size(72, 13);
            this.label_col.TabIndex = 86;
            this.label_col.Text = "Nº Colegiado:";
            // 
            // tb_colegiado
            // 
            this.tb_colegiado.Location = new System.Drawing.Point(551, 188);
            this.tb_colegiado.Name = "tb_colegiado";
            this.tb_colegiado.Size = new System.Drawing.Size(119, 20);
            this.tb_colegiado.TabIndex = 85;
            // 
            // FormAdministradorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.FONDOAPP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.label_col);
            this.Controls.Add(this.tb_colegiado);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.btn_buscar_dni);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_provincia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_sueldo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cp);
            this.Controls.Add(this.tb_localidad);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_direccion);
            this.Controls.Add(this.tb_apellidos);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.log_photo);
            this.Controls.Add(this.panel_top);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdministradorEmpleado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_desconectar_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_erase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_dni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox log_photo;
        public System.Windows.Forms.TextBox tb_dni;
        public System.Windows.Forms.TextBox tb_nombre;
        public System.Windows.Forms.TextBox tb_apellidos;
        public System.Windows.Forms.TextBox tb_direccion;
        public System.Windows.Forms.TextBox tb_tel;
        public System.Windows.Forms.TextBox tb_localidad;
        public System.Windows.Forms.TextBox tb_cp;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tb_sueldo;
        public System.Windows.Forms.ComboBox tb_provincia;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox picture_tratamiento;
        private System.Windows.Forms.PictureBox picture_empleado;
        private System.Windows.Forms.PictureBox picture_home;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox tb_tipo;
        private System.Windows.Forms.PictureBox picture_desconectar_admin;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tb_pass;
        public System.Windows.Forms.PictureBox btn_erase;
        public System.Windows.Forms.PictureBox btn_buscar_dni;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.Button btn_eliminar;
        public System.Windows.Forms.Label label_col;
        public System.Windows.Forms.TextBox tb_colegiado;
    }
}