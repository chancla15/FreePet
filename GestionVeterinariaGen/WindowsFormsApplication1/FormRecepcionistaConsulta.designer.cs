namespace WindowsFormsApplication1
{
    partial class FormRecepcionistaConsulta
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
            this.datetime_fin = new System.Windows.Forms.DateTimePicker();
            this.datetime_init = new System.Windows.Forms.DateTimePicker();
            this.label_error_fecha = new System.Windows.Forms.Label();
            this.box_error_cliente = new System.Windows.Forms.Label();
            this.box_text_lugar = new System.Windows.Forms.TextBox();
            this.box_combo_veterinario = new System.Windows.Forms.ComboBox();
            this.box_combo_mascotas = new System.Windows.Forms.ComboBox();
            this.box_text_cliente = new System.Windows.Forms.TextBox();
            this.box_text_motivo = new System.Windows.Forms.TextBox();
            this.box_label_lugar = new System.Windows.Forms.Label();
            this.box_label_veterinario = new System.Windows.Forms.Label();
            this.box_label_mascota = new System.Windows.Forms.Label();
            this.box_label_cliente = new System.Windows.Forms.Label();
            this.box_label_motivo = new System.Windows.Forms.Label();
            this.box_label_hora = new System.Windows.Forms.Label();
            this.box_label_fecha = new System.Windows.Forms.Label();
            this.box_combo_hora = new System.Windows.Forms.ComboBox();
            this.box_text_fecha = new System.Windows.Forms.TextBox();
            this.treeViewConsultas = new System.Windows.Forms.TreeView();
            this.alerta_eliminar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar_no = new System.Windows.Forms.Button();
            this.btn_eliminar_si = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.picture_ajustes = new System.Windows.Forms.PictureBox();
            this.picture_facturas = new System.Windows.Forms.PictureBox();
            this.picture_clientes = new System.Windows.Forms.PictureBox();
            this.picture_consultas = new System.Windows.Forms.PictureBox();
            this.picture_start = new System.Windows.Forms.PictureBox();
            this.label_error_mascota = new System.Windows.Forms.Label();
            this.label_error_veterinario = new System.Windows.Forms.Label();
            this.btn_buscar_cliente = new System.Windows.Forms.Button();
            this.btn_erase = new System.Windows.Forms.PictureBox();
            this.image_del = new System.Windows.Forms.PictureBox();
            this.image_add = new System.Windows.Forms.PictureBox();
            this.btnBuscar_Fecha = new System.Windows.Forms.Button();
            this.alerta_eliminar.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_erase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_del)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_add)).BeginInit();
            this.SuspendLayout();
            // 
            // datetime_fin
            // 
            this.datetime_fin.Location = new System.Drawing.Point(12, 209);
            this.datetime_fin.Name = "datetime_fin";
            this.datetime_fin.Size = new System.Drawing.Size(273, 20);
            this.datetime_fin.TabIndex = 10;
            // 
            // datetime_init
            // 
            this.datetime_init.Location = new System.Drawing.Point(12, 183);
            this.datetime_init.Name = "datetime_init";
            this.datetime_init.Size = new System.Drawing.Size(273, 20);
            this.datetime_init.TabIndex = 11;
            // 
            // label_error_fecha
            // 
            this.label_error_fecha.AutoSize = true;
            this.label_error_fecha.BackColor = System.Drawing.Color.Transparent;
            this.label_error_fecha.ForeColor = System.Drawing.Color.Red;
            this.label_error_fecha.Location = new System.Drawing.Point(291, 213);
            this.label_error_fecha.Name = "label_error_fecha";
            this.label_error_fecha.Size = new System.Drawing.Size(11, 13);
            this.label_error_fecha.TabIndex = 15;
            this.label_error_fecha.Text = "*";
            this.label_error_fecha.Visible = false;
            // 
            // box_error_cliente
            // 
            this.box_error_cliente.AutoSize = true;
            this.box_error_cliente.BackColor = System.Drawing.Color.Transparent;
            this.box_error_cliente.ForeColor = System.Drawing.Color.Red;
            this.box_error_cliente.Location = new System.Drawing.Point(199, 99);
            this.box_error_cliente.Name = "box_error_cliente";
            this.box_error_cliente.Size = new System.Drawing.Size(11, 13);
            this.box_error_cliente.TabIndex = 16;
            this.box_error_cliente.Text = "*";
            this.box_error_cliente.Visible = false;
            // 
            // box_text_lugar
            // 
            this.box_text_lugar.Location = new System.Drawing.Point(468, 94);
            this.box_text_lugar.Name = "box_text_lugar";
            this.box_text_lugar.Size = new System.Drawing.Size(140, 20);
            this.box_text_lugar.TabIndex = 15;
            // 
            // box_combo_veterinario
            // 
            this.box_combo_veterinario.FormattingEnabled = true;
            this.box_combo_veterinario.Location = new System.Drawing.Point(468, 142);
            this.box_combo_veterinario.Name = "box_combo_veterinario";
            this.box_combo_veterinario.Size = new System.Drawing.Size(140, 21);
            this.box_combo_veterinario.TabIndex = 14;
            // 
            // box_combo_mascotas
            // 
            this.box_combo_mascotas.FormattingEnabled = true;
            this.box_combo_mascotas.Location = new System.Drawing.Point(276, 97);
            this.box_combo_mascotas.Name = "box_combo_mascotas";
            this.box_combo_mascotas.Size = new System.Drawing.Size(99, 21);
            this.box_combo_mascotas.TabIndex = 13;
            // 
            // box_text_cliente
            // 
            this.box_text_cliente.Location = new System.Drawing.Point(62, 98);
            this.box_text_cliente.Name = "box_text_cliente";
            this.box_text_cliente.Size = new System.Drawing.Size(109, 20);
            this.box_text_cliente.TabIndex = 12;
            // 
            // box_text_motivo
            // 
            this.box_text_motivo.Location = new System.Drawing.Point(62, 143);
            this.box_text_motivo.Name = "box_text_motivo";
            this.box_text_motivo.Size = new System.Drawing.Size(313, 20);
            this.box_text_motivo.TabIndex = 11;
            // 
            // box_label_lugar
            // 
            this.box_label_lugar.AutoSize = true;
            this.box_label_lugar.BackColor = System.Drawing.Color.Transparent;
            this.box_label_lugar.Location = new System.Drawing.Point(402, 100);
            this.box_label_lugar.Name = "box_label_lugar";
            this.box_label_lugar.Size = new System.Drawing.Size(37, 13);
            this.box_label_lugar.TabIndex = 9;
            this.box_label_lugar.Text = "Lugar:";
            // 
            // box_label_veterinario
            // 
            this.box_label_veterinario.AutoSize = true;
            this.box_label_veterinario.BackColor = System.Drawing.Color.Transparent;
            this.box_label_veterinario.Location = new System.Drawing.Point(402, 146);
            this.box_label_veterinario.Name = "box_label_veterinario";
            this.box_label_veterinario.Size = new System.Drawing.Size(60, 13);
            this.box_label_veterinario.TabIndex = 8;
            this.box_label_veterinario.Text = "Veterinario:";
            // 
            // box_label_mascota
            // 
            this.box_label_mascota.AutoSize = true;
            this.box_label_mascota.BackColor = System.Drawing.Color.Transparent;
            this.box_label_mascota.Location = new System.Drawing.Point(221, 101);
            this.box_label_mascota.Name = "box_label_mascota";
            this.box_label_mascota.Size = new System.Drawing.Size(51, 13);
            this.box_label_mascota.TabIndex = 7;
            this.box_label_mascota.Text = "Mascota:";
            // 
            // box_label_cliente
            // 
            this.box_label_cliente.AutoSize = true;
            this.box_label_cliente.BackColor = System.Drawing.Color.Transparent;
            this.box_label_cliente.Location = new System.Drawing.Point(12, 101);
            this.box_label_cliente.Name = "box_label_cliente";
            this.box_label_cliente.Size = new System.Drawing.Size(42, 13);
            this.box_label_cliente.TabIndex = 6;
            this.box_label_cliente.Text = "Cliente:";
            // 
            // box_label_motivo
            // 
            this.box_label_motivo.AutoSize = true;
            this.box_label_motivo.BackColor = System.Drawing.Color.Transparent;
            this.box_label_motivo.Location = new System.Drawing.Point(12, 150);
            this.box_label_motivo.Name = "box_label_motivo";
            this.box_label_motivo.Size = new System.Drawing.Size(42, 13);
            this.box_label_motivo.TabIndex = 5;
            this.box_label_motivo.Text = "Motivo:";
            // 
            // box_label_hora
            // 
            this.box_label_hora.AutoSize = true;
            this.box_label_hora.BackColor = System.Drawing.Color.Transparent;
            this.box_label_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_label_hora.Location = new System.Drawing.Point(221, 61);
            this.box_label_hora.Name = "box_label_hora";
            this.box_label_hora.Size = new System.Drawing.Size(33, 13);
            this.box_label_hora.TabIndex = 4;
            this.box_label_hora.Text = "Hora:";
            // 
            // box_label_fecha
            // 
            this.box_label_fecha.AutoSize = true;
            this.box_label_fecha.BackColor = System.Drawing.Color.Transparent;
            this.box_label_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_label_fecha.Location = new System.Drawing.Point(12, 61);
            this.box_label_fecha.Name = "box_label_fecha";
            this.box_label_fecha.Size = new System.Drawing.Size(40, 13);
            this.box_label_fecha.TabIndex = 3;
            this.box_label_fecha.Text = "Fecha:";
            // 
            // box_combo_hora
            // 
            this.box_combo_hora.FormattingEnabled = true;
            this.box_combo_hora.Location = new System.Drawing.Point(274, 53);
            this.box_combo_hora.Name = "box_combo_hora";
            this.box_combo_hora.Size = new System.Drawing.Size(96, 21);
            this.box_combo_hora.TabIndex = 2;
            this.box_combo_hora.SelectedIndexChanged += new System.EventHandler(this.box_combo_hora_SelectedIndexChanged);
            // 
            // box_text_fecha
            // 
            this.box_text_fecha.Location = new System.Drawing.Point(62, 58);
            this.box_text_fecha.Name = "box_text_fecha";
            this.box_text_fecha.Size = new System.Drawing.Size(144, 20);
            this.box_text_fecha.TabIndex = 1;
            // 
            // treeViewConsultas
            // 
            this.treeViewConsultas.Location = new System.Drawing.Point(12, 241);
            this.treeViewConsultas.Name = "treeViewConsultas";
            this.treeViewConsultas.Size = new System.Drawing.Size(657, 228);
            this.treeViewConsultas.TabIndex = 9;
            this.treeViewConsultas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewConsultas_AfterSelect);
            // 
            // alerta_eliminar
            // 
            this.alerta_eliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alerta_eliminar.Controls.Add(this.label1);
            this.alerta_eliminar.Controls.Add(this.btn_eliminar_no);
            this.alerta_eliminar.Controls.Add(this.btn_eliminar_si);
            this.alerta_eliminar.Location = new System.Drawing.Point(365, 294);
            this.alerta_eliminar.Name = "alerta_eliminar";
            this.alerta_eliminar.Size = new System.Drawing.Size(200, 67);
            this.alerta_eliminar.TabIndex = 26;
            this.alerta_eliminar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Eliminar Consulta?";
            // 
            // btn_eliminar_no
            // 
            this.btn_eliminar_no.Location = new System.Drawing.Point(104, 35);
            this.btn_eliminar_no.Name = "btn_eliminar_no";
            this.btn_eliminar_no.Size = new System.Drawing.Size(41, 23);
            this.btn_eliminar_no.TabIndex = 1;
            this.btn_eliminar_no.Text = "No";
            this.btn_eliminar_no.UseVisualStyleBackColor = true;
            this.btn_eliminar_no.Click += new System.EventHandler(this.btn_eliminar_no_Click);
            // 
            // btn_eliminar_si
            // 
            this.btn_eliminar_si.Location = new System.Drawing.Point(151, 35);
            this.btn_eliminar_si.Name = "btn_eliminar_si";
            this.btn_eliminar_si.Size = new System.Drawing.Size(38, 23);
            this.btn_eliminar_si.TabIndex = 0;
            this.btn_eliminar_si.Text = "Si";
            this.btn_eliminar_si.UseVisualStyleBackColor = true;
            this.btn_eliminar_si.Click += new System.EventHandler(this.btn_eliminar_si_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Transparent;
            this.panel_top.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.PANEL_RECEPCIONISTA;
            this.panel_top.Controls.Add(this.picture_ajustes);
            this.panel_top.Controls.Add(this.picture_facturas);
            this.panel_top.Controls.Add(this.picture_clientes);
            this.panel_top.Controls.Add(this.picture_consultas);
            this.panel_top.Controls.Add(this.picture_start);
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(690, 44);
            this.panel_top.TabIndex = 59;
            // 
            // picture_ajustes
            // 
            this.picture_ajustes.BackColor = System.Drawing.Color.Transparent;
            this.picture_ajustes.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_RECEPCIONISTA_DESCONECTAR;
            this.picture_ajustes.Location = new System.Drawing.Point(546, 0);
            this.picture_ajustes.Name = "picture_ajustes";
            this.picture_ajustes.Size = new System.Drawing.Size(138, 44);
            this.picture_ajustes.TabIndex = 4;
            this.picture_ajustes.TabStop = false;
            this.picture_ajustes.Click += new System.EventHandler(this.picture_ajustes_Click);
            // 
            // picture_facturas
            // 
            this.picture_facturas.BackColor = System.Drawing.Color.Transparent;
            this.picture_facturas.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_RECEPCIONISTA_FACTURA;
            this.picture_facturas.Location = new System.Drawing.Point(410, 0);
            this.picture_facturas.Name = "picture_facturas";
            this.picture_facturas.Size = new System.Drawing.Size(138, 44);
            this.picture_facturas.TabIndex = 3;
            this.picture_facturas.TabStop = false;
            this.picture_facturas.Click += new System.EventHandler(this.picture_facturas_Click);
            // 
            // picture_clientes
            // 
            this.picture_clientes.BackColor = System.Drawing.Color.Transparent;
            this.picture_clientes.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_RECEPCIONISTA_CLIENTE;
            this.picture_clientes.Location = new System.Drawing.Point(273, 0);
            this.picture_clientes.Name = "picture_clientes";
            this.picture_clientes.Size = new System.Drawing.Size(138, 44);
            this.picture_clientes.TabIndex = 2;
            this.picture_clientes.TabStop = false;
            this.picture_clientes.Click += new System.EventHandler(this.picture_clientes_Click);
            // 
            // picture_consultas
            // 
            this.picture_consultas.BackColor = System.Drawing.Color.White;
            this.picture_consultas.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_RECEPCIONISTA_CONSULTA;
            this.picture_consultas.Location = new System.Drawing.Point(137, 0);
            this.picture_consultas.Name = "picture_consultas";
            this.picture_consultas.Size = new System.Drawing.Size(138, 44);
            this.picture_consultas.TabIndex = 1;
            this.picture_consultas.TabStop = false;
            this.picture_consultas.Click += new System.EventHandler(this.picture_consultas_Click);
            // 
            // picture_start
            // 
            this.picture_start.BackColor = System.Drawing.Color.Transparent;
            this.picture_start.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_RECEPCIONISTA_INICIO;
            this.picture_start.Location = new System.Drawing.Point(0, 0);
            this.picture_start.Name = "picture_start";
            this.picture_start.Size = new System.Drawing.Size(138, 44);
            this.picture_start.TabIndex = 0;
            this.picture_start.TabStop = false;
            this.picture_start.Click += new System.EventHandler(this.picture_start_Click);
            // 
            // label_error_mascota
            // 
            this.label_error_mascota.AutoSize = true;
            this.label_error_mascota.BackColor = System.Drawing.Color.Transparent;
            this.label_error_mascota.ForeColor = System.Drawing.Color.Red;
            this.label_error_mascota.Location = new System.Drawing.Point(381, 100);
            this.label_error_mascota.Name = "label_error_mascota";
            this.label_error_mascota.Size = new System.Drawing.Size(11, 13);
            this.label_error_mascota.TabIndex = 87;
            this.label_error_mascota.Text = "*";
            this.label_error_mascota.Visible = false;
            // 
            // label_error_veterinario
            // 
            this.label_error_veterinario.AutoSize = true;
            this.label_error_veterinario.BackColor = System.Drawing.Color.Transparent;
            this.label_error_veterinario.ForeColor = System.Drawing.Color.Red;
            this.label_error_veterinario.Location = new System.Drawing.Point(614, 142);
            this.label_error_veterinario.Name = "label_error_veterinario";
            this.label_error_veterinario.Size = new System.Drawing.Size(11, 13);
            this.label_error_veterinario.TabIndex = 88;
            this.label_error_veterinario.Text = "*";
            this.label_error_veterinario.Visible = false;
            // 
            // btn_buscar_cliente
            // 
            this.btn_buscar_cliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar_cliente.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.btn_buscar_id;
            this.btn_buscar_cliente.Location = new System.Drawing.Point(177, 99);
            this.btn_buscar_cliente.Name = "btn_buscar_cliente";
            this.btn_buscar_cliente.Size = new System.Drawing.Size(16, 16);
            this.btn_buscar_cliente.TabIndex = 86;
            this.btn_buscar_cliente.UseVisualStyleBackColor = false;
            this.btn_buscar_cliente.Click += new System.EventHandler(this.btn_buscar_cliente_Click);
            // 
            // btn_erase
            // 
            this.btn_erase.BackColor = System.Drawing.Color.Transparent;
            this.btn_erase.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.eraser;
            this.btn_erase.Location = new System.Drawing.Point(316, 187);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(16, 16);
            this.btn_erase.TabIndex = 85;
            this.btn_erase.TabStop = false;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // image_del
            // 
            this.image_del.BackColor = System.Drawing.Color.Transparent;
            this.image_del.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.delete;
            this.image_del.Location = new System.Drawing.Point(653, 94);
            this.image_del.Name = "image_del";
            this.image_del.Size = new System.Drawing.Size(16, 16);
            this.image_del.TabIndex = 23;
            this.image_del.TabStop = false;
            this.image_del.Click += new System.EventHandler(this.image_del_Click);
            // 
            // image_add
            // 
            this.image_add.BackColor = System.Drawing.Color.Transparent;
            this.image_add.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.add;
            this.image_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.image_add.Location = new System.Drawing.Point(653, 53);
            this.image_add.Name = "image_add";
            this.image_add.Size = new System.Drawing.Size(16, 16);
            this.image_add.TabIndex = 22;
            this.image_add.TabStop = false;
            this.image_add.Click += new System.EventHandler(this.image_add_Click);
            // 
            // btnBuscar_Fecha
            // 
            this.btnBuscar_Fecha.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar_Fecha.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.btn_buscar_id;
            this.btnBuscar_Fecha.Location = new System.Drawing.Point(291, 187);
            this.btnBuscar_Fecha.Name = "btnBuscar_Fecha";
            this.btnBuscar_Fecha.Size = new System.Drawing.Size(16, 16);
            this.btnBuscar_Fecha.TabIndex = 12;
            this.btnBuscar_Fecha.UseVisualStyleBackColor = false;
            this.btnBuscar_Fecha.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormRecepcionistaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.FONDO_APP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.label_error_veterinario);
            this.Controls.Add(this.label_error_mascota);
            this.Controls.Add(this.btn_buscar_cliente);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.box_text_lugar);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.box_label_lugar);
            this.Controls.Add(this.box_error_cliente);
            this.Controls.Add(this.box_combo_veterinario);
            this.Controls.Add(this.alerta_eliminar);
            this.Controls.Add(this.box_combo_mascotas);
            this.Controls.Add(this.box_label_veterinario);
            this.Controls.Add(this.image_del);
            this.Controls.Add(this.image_add);
            this.Controls.Add(this.box_text_cliente);
            this.Controls.Add(this.box_label_mascota);
            this.Controls.Add(this.box_text_motivo);
            this.Controls.Add(this.label_error_fecha);
            this.Controls.Add(this.box_label_cliente);
            this.Controls.Add(this.btnBuscar_Fecha);
            this.Controls.Add(this.datetime_init);
            this.Controls.Add(this.datetime_fin);
            this.Controls.Add(this.treeViewConsultas);
            this.Controls.Add(this.box_label_fecha);
            this.Controls.Add(this.box_label_motivo);
            this.Controls.Add(this.box_text_fecha);
            this.Controls.Add(this.box_label_hora);
            this.Controls.Add(this.box_combo_hora);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRecepcionistaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.alerta_eliminar.ResumeLayout(false);
            this.alerta_eliminar.PerformLayout();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_erase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_del)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker datetime_fin;
        public System.Windows.Forms.DateTimePicker datetime_init;
        public System.Windows.Forms.Button btnBuscar_Fecha;
        public System.Windows.Forms.Label label_error_fecha;
        public System.Windows.Forms.TextBox box_text_fecha;
        public System.Windows.Forms.Label box_label_hora;
        public System.Windows.Forms.Label box_label_fecha;
        public System.Windows.Forms.ComboBox box_combo_hora;
        public System.Windows.Forms.Label box_label_lugar;
        public System.Windows.Forms.Label box_label_veterinario;
        public System.Windows.Forms.Label box_label_mascota;
        public System.Windows.Forms.Label box_label_cliente;
        public System.Windows.Forms.Label box_label_motivo;
        public System.Windows.Forms.TextBox box_text_lugar;
        public System.Windows.Forms.ComboBox box_combo_veterinario;
        public System.Windows.Forms.ComboBox box_combo_mascotas;
        public System.Windows.Forms.TextBox box_text_cliente;
        public System.Windows.Forms.TextBox box_text_motivo;
        public System.Windows.Forms.Label box_error_cliente;
        public System.Windows.Forms.PictureBox image_add;
        public System.Windows.Forms.PictureBox image_del;
        public System.Windows.Forms.TreeView treeViewConsultas;
        public System.Windows.Forms.Panel alerta_eliminar;
        public System.Windows.Forms.Button btn_eliminar_no;
        public System.Windows.Forms.Button btn_eliminar_si;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox picture_ajustes;
        private System.Windows.Forms.PictureBox picture_facturas;
        private System.Windows.Forms.PictureBox picture_clientes;
        private System.Windows.Forms.PictureBox picture_consultas;
        private System.Windows.Forms.PictureBox picture_start;
        public System.Windows.Forms.PictureBox btn_erase;
        public System.Windows.Forms.Button btn_buscar_cliente;
        public System.Windows.Forms.Label label_error_mascota;
        public System.Windows.Forms.Label label_error_veterinario;
    }
}