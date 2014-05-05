namespace WindowsFormsApplication1
{
    partial class FormRecepcionistaFactura
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.picture_ajustes = new System.Windows.Forms.PictureBox();
            this.picture_facturas = new System.Windows.Forms.PictureBox();
            this.picture_clientes = new System.Windows.Forms.PictureBox();
            this.picture_consultas = new System.Windows.Forms.PictureBox();
            this.picture_start = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.text_buscar = new System.Windows.Forms.TextBox();
            this.log_photo = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_Nombre = new System.Windows.Forms.Label();
            this.gp_ModificarFactura = new System.Windows.Forms.GroupBox();
            this.ll_Modificar = new System.Windows.Forms.LinkLabel();
            this.l_TratamientoElegir = new System.Windows.Forms.Label();
            this.cb_Tratamiento = new System.Windows.Forms.ComboBox();
            this.tb_Tratamiento = new System.Windows.Forms.TextBox();
            this.l_Tratamiento = new System.Windows.Forms.Label();
            this.l_MascotaElegir = new System.Windows.Forms.Label();
            this.tb_Mascota = new System.Windows.Forms.TextBox();
            this.cb_Mascota = new System.Windows.Forms.ComboBox();
            this.tb_Motivo = new System.Windows.Forms.TextBox();
            this.l_Motivo = new System.Windows.Forms.Label();
            this.l_Mascota = new System.Windows.Forms.Label();
            this.tb_Pagada = new System.Windows.Forms.TextBox();
            this.l_Pagada = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.l_Total = new System.Windows.Forms.Label();
            this.tb_Fecha = new System.Windows.Forms.TextBox();
            this.l_Fecha = new System.Windows.Forms.Label();
            this.ll_Eliminar = new System.Windows.Forms.LinkLabel();
            this.ll_Cancelar = new System.Windows.Forms.LinkLabel();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gp_ModificarFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Transparent;
            this.panel_top.Controls.Add(this.picture_ajustes);
            this.panel_top.Controls.Add(this.picture_facturas);
            this.panel_top.Controls.Add(this.picture_clientes);
            this.panel_top.Controls.Add(this.picture_consultas);
            this.panel_top.Controls.Add(this.picture_start);
            this.panel_top.Location = new System.Drawing.Point(-2, 2);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(690, 34);
            this.panel_top.TabIndex = 61;
            // 
            // picture_ajustes
            // 
            this.picture_ajustes.BackColor = System.Drawing.Color.Transparent;
            this.picture_ajustes.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.ajustes;
            this.picture_ajustes.Location = new System.Drawing.Point(559, 0);
            this.picture_ajustes.Name = "picture_ajustes";
            this.picture_ajustes.Size = new System.Drawing.Size(128, 34);
            this.picture_ajustes.TabIndex = 4;
            this.picture_ajustes.TabStop = false;
            this.picture_ajustes.Click += new System.EventHandler(this.picture_ajustes_Click);
            // 
            // picture_facturas
            // 
            this.picture_facturas.BackColor = System.Drawing.Color.Transparent;
            this.picture_facturas.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.facturas;
            this.picture_facturas.Location = new System.Drawing.Point(420, 0);
            this.picture_facturas.Name = "picture_facturas";
            this.picture_facturas.Size = new System.Drawing.Size(128, 34);
            this.picture_facturas.TabIndex = 3;
            this.picture_facturas.TabStop = false;
            // 
            // picture_clientes
            // 
            this.picture_clientes.BackColor = System.Drawing.Color.Transparent;
            this.picture_clientes.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.clientes;
            this.picture_clientes.Location = new System.Drawing.Point(281, 0);
            this.picture_clientes.Name = "picture_clientes";
            this.picture_clientes.Size = new System.Drawing.Size(128, 34);
            this.picture_clientes.TabIndex = 2;
            this.picture_clientes.TabStop = false;
            this.picture_clientes.Click += new System.EventHandler(this.picture_clientes_Click);
            // 
            // picture_consultas
            // 
            this.picture_consultas.BackColor = System.Drawing.Color.Transparent;
            this.picture_consultas.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.doctor;
            this.picture_consultas.Location = new System.Drawing.Point(140, 0);
            this.picture_consultas.Name = "picture_consultas";
            this.picture_consultas.Size = new System.Drawing.Size(128, 34);
            this.picture_consultas.TabIndex = 1;
            this.picture_consultas.TabStop = false;
            this.picture_consultas.Click += new System.EventHandler(this.picture_consultas_Click);
            // 
            // picture_start
            // 
            this.picture_start.BackColor = System.Drawing.Color.Transparent;
            this.picture_start.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.start;
            this.picture_start.Location = new System.Drawing.Point(0, 0);
            this.picture_start.Name = "picture_start";
            this.picture_start.Size = new System.Drawing.Size(128, 34);
            this.picture_start.TabIndex = 0;
            this.picture_start.TabStop = false;
            this.picture_start.Click += new System.EventHandler(this.picture_start_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.add1;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_add.Location = new System.Drawing.Point(621, 188);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(20, 21);
            this.btn_add.TabIndex = 60;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.btn_buscar_id;
            this.btn_buscar.Location = new System.Drawing.Point(461, 193);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(16, 16);
            this.btn_buscar.TabIndex = 58;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // text_buscar
            // 
            this.text_buscar.Location = new System.Drawing.Point(12, 189);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(443, 20);
            this.text_buscar.TabIndex = 57;
            // 
            // log_photo
            // 
            this.log_photo.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.log_photo.Location = new System.Drawing.Point(12, 46);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(90, 120);
            this.log_photo.TabIndex = 52;
            this.log_photo.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Fecha,
            this.Total,
            this.Mascota,
            this.Motivo,
            this.Pagada,
            this.c_Tratamiento});
            this.dataGridView1.Location = new System.Drawing.Point(3, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(685, 254);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Mascota
            // 
            this.Mascota.HeaderText = "Mascota";
            this.Mascota.Name = "Mascota";
            this.Mascota.ReadOnly = true;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            // 
            // Pagada
            // 
            this.Pagada.HeaderText = "Pagada";
            this.Pagada.Name = "Pagada";
            this.Pagada.ReadOnly = true;
            // 
            // c_Tratamiento
            // 
            this.c_Tratamiento.HeaderText = "Tratamiento";
            this.c_Tratamiento.Name = "c_Tratamiento";
            this.c_Tratamiento.ReadOnly = true;
            // 
            // l_Nombre
            // 
            this.l_Nombre.AutoSize = true;
            this.l_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.l_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Nombre.Location = new System.Drawing.Point(124, 46);
            this.l_Nombre.Name = "l_Nombre";
            this.l_Nombre.Size = new System.Drawing.Size(65, 20);
            this.l_Nombre.TabIndex = 62;
            this.l_Nombre.Text = "Nombre";
            // 
            // gp_ModificarFactura
            // 
            this.gp_ModificarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gp_ModificarFactura.Controls.Add(this.ll_Modificar);
            this.gp_ModificarFactura.Controls.Add(this.l_TratamientoElegir);
            this.gp_ModificarFactura.Controls.Add(this.cb_Tratamiento);
            this.gp_ModificarFactura.Controls.Add(this.tb_Tratamiento);
            this.gp_ModificarFactura.Controls.Add(this.l_Tratamiento);
            this.gp_ModificarFactura.Controls.Add(this.l_MascotaElegir);
            this.gp_ModificarFactura.Controls.Add(this.tb_Mascota);
            this.gp_ModificarFactura.Controls.Add(this.cb_Mascota);
            this.gp_ModificarFactura.Controls.Add(this.tb_Motivo);
            this.gp_ModificarFactura.Controls.Add(this.l_Motivo);
            this.gp_ModificarFactura.Controls.Add(this.l_Mascota);
            this.gp_ModificarFactura.Controls.Add(this.tb_Pagada);
            this.gp_ModificarFactura.Controls.Add(this.l_Pagada);
            this.gp_ModificarFactura.Controls.Add(this.tb_Total);
            this.gp_ModificarFactura.Controls.Add(this.l_Total);
            this.gp_ModificarFactura.Controls.Add(this.tb_Fecha);
            this.gp_ModificarFactura.Controls.Add(this.l_Fecha);
            this.gp_ModificarFactura.Controls.Add(this.ll_Eliminar);
            this.gp_ModificarFactura.Controls.Add(this.ll_Cancelar);
            this.gp_ModificarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_ModificarFactura.Location = new System.Drawing.Point(344, 126);
            this.gp_ModificarFactura.Name = "gp_ModificarFactura";
            this.gp_ModificarFactura.Size = new System.Drawing.Size(271, 354);
            this.gp_ModificarFactura.TabIndex = 63;
            this.gp_ModificarFactura.TabStop = false;
            this.gp_ModificarFactura.Visible = false;
            // 
            // ll_Modificar
            // 
            this.ll_Modificar.AutoSize = true;
            this.ll_Modificar.Location = new System.Drawing.Point(107, 322);
            this.ll_Modificar.Name = "ll_Modificar";
            this.ll_Modificar.Size = new System.Drawing.Size(50, 13);
            this.ll_Modificar.TabIndex = 74;
            this.ll_Modificar.TabStop = true;
            this.ll_Modificar.Text = "Modificar";
            this.ll_Modificar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Modificar_LinkClicked);
            // 
            // l_TratamientoElegir
            // 
            this.l_TratamientoElegir.AutoSize = true;
            this.l_TratamientoElegir.Location = new System.Drawing.Point(6, 293);
            this.l_TratamientoElegir.Name = "l_TratamientoElegir";
            this.l_TratamientoElegir.Size = new System.Drawing.Size(103, 13);
            this.l_TratamientoElegir.TabIndex = 73;
            this.l_TratamientoElegir.Text = "Tratamiento a elegir:";
            // 
            // cb_Tratamiento
            // 
            this.cb_Tratamiento.FormattingEnabled = true;
            this.cb_Tratamiento.Location = new System.Drawing.Point(111, 293);
            this.cb_Tratamiento.Name = "cb_Tratamiento";
            this.cb_Tratamiento.Size = new System.Drawing.Size(154, 21);
            this.cb_Tratamiento.TabIndex = 72;
            // 
            // tb_Tratamiento
            // 
            this.tb_Tratamiento.Location = new System.Drawing.Point(110, 178);
            this.tb_Tratamiento.Name = "tb_Tratamiento";
            this.tb_Tratamiento.Size = new System.Drawing.Size(154, 20);
            this.tb_Tratamiento.TabIndex = 71;
            // 
            // l_Tratamiento
            // 
            this.l_Tratamiento.AutoSize = true;
            this.l_Tratamiento.Location = new System.Drawing.Point(6, 178);
            this.l_Tratamiento.Name = "l_Tratamiento";
            this.l_Tratamiento.Size = new System.Drawing.Size(98, 13);
            this.l_Tratamiento.TabIndex = 70;
            this.l_Tratamiento.Text = "Tratamiento actual:";
            // 
            // l_MascotaElegir
            // 
            this.l_MascotaElegir.AutoSize = true;
            this.l_MascotaElegir.Location = new System.Drawing.Point(6, 254);
            this.l_MascotaElegir.Name = "l_MascotaElegir";
            this.l_MascotaElegir.Size = new System.Drawing.Size(93, 13);
            this.l_MascotaElegir.TabIndex = 69;
            this.l_MascotaElegir.Text = "Mascotas a elegir:";
            // 
            // tb_Mascota
            // 
            this.tb_Mascota.Location = new System.Drawing.Point(110, 217);
            this.tb_Mascota.Name = "tb_Mascota";
            this.tb_Mascota.Size = new System.Drawing.Size(154, 20);
            this.tb_Mascota.TabIndex = 68;
            // 
            // cb_Mascota
            // 
            this.cb_Mascota.FormattingEnabled = true;
            this.cb_Mascota.Location = new System.Drawing.Point(110, 254);
            this.cb_Mascota.Name = "cb_Mascota";
            this.cb_Mascota.Size = new System.Drawing.Size(154, 21);
            this.cb_Mascota.TabIndex = 67;
            // 
            // tb_Motivo
            // 
            this.tb_Motivo.Location = new System.Drawing.Point(110, 139);
            this.tb_Motivo.Name = "tb_Motivo";
            this.tb_Motivo.Size = new System.Drawing.Size(154, 20);
            this.tb_Motivo.TabIndex = 66;
            // 
            // l_Motivo
            // 
            this.l_Motivo.AutoSize = true;
            this.l_Motivo.Location = new System.Drawing.Point(6, 139);
            this.l_Motivo.Name = "l_Motivo";
            this.l_Motivo.Size = new System.Drawing.Size(42, 13);
            this.l_Motivo.TabIndex = 65;
            this.l_Motivo.Text = "Motivo:";
            // 
            // l_Mascota
            // 
            this.l_Mascota.AutoSize = true;
            this.l_Mascota.Location = new System.Drawing.Point(6, 217);
            this.l_Mascota.Name = "l_Mascota";
            this.l_Mascota.Size = new System.Drawing.Size(83, 13);
            this.l_Mascota.TabIndex = 64;
            this.l_Mascota.Text = "Mascota actual:";
            // 
            // tb_Pagada
            // 
            this.tb_Pagada.Location = new System.Drawing.Point(110, 97);
            this.tb_Pagada.Name = "tb_Pagada";
            this.tb_Pagada.Size = new System.Drawing.Size(154, 20);
            this.tb_Pagada.TabIndex = 63;
            // 
            // l_Pagada
            // 
            this.l_Pagada.AutoSize = true;
            this.l_Pagada.Location = new System.Drawing.Point(6, 97);
            this.l_Pagada.Name = "l_Pagada";
            this.l_Pagada.Size = new System.Drawing.Size(47, 13);
            this.l_Pagada.TabIndex = 62;
            this.l_Pagada.Text = "Pagada:";
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(110, 57);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(154, 20);
            this.tb_Total.TabIndex = 61;
            // 
            // l_Total
            // 
            this.l_Total.AutoSize = true;
            this.l_Total.Location = new System.Drawing.Point(6, 57);
            this.l_Total.Name = "l_Total";
            this.l_Total.Size = new System.Drawing.Size(34, 13);
            this.l_Total.TabIndex = 60;
            this.l_Total.Text = "Total:";
            // 
            // tb_Fecha
            // 
            this.tb_Fecha.Location = new System.Drawing.Point(110, 17);
            this.tb_Fecha.Name = "tb_Fecha";
            this.tb_Fecha.Size = new System.Drawing.Size(154, 20);
            this.tb_Fecha.TabIndex = 59;
            // 
            // l_Fecha
            // 
            this.l_Fecha.AutoSize = true;
            this.l_Fecha.Location = new System.Drawing.Point(6, 17);
            this.l_Fecha.Name = "l_Fecha";
            this.l_Fecha.Size = new System.Drawing.Size(40, 13);
            this.l_Fecha.TabIndex = 58;
            this.l_Fecha.Text = "Fecha:";
            // 
            // ll_Eliminar
            // 
            this.ll_Eliminar.AutoSize = true;
            this.ll_Eliminar.Location = new System.Drawing.Point(192, 322);
            this.ll_Eliminar.Name = "ll_Eliminar";
            this.ll_Eliminar.Size = new System.Drawing.Size(43, 13);
            this.ll_Eliminar.TabIndex = 17;
            this.ll_Eliminar.TabStop = true;
            this.ll_Eliminar.Text = "Eliminar";
            this.ll_Eliminar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Eliminar_LinkClicked);
            // 
            // ll_Cancelar
            // 
            this.ll_Cancelar.AutoSize = true;
            this.ll_Cancelar.Location = new System.Drawing.Point(30, 322);
            this.ll_Cancelar.Name = "ll_Cancelar";
            this.ll_Cancelar.Size = new System.Drawing.Size(49, 13);
            this.ll_Cancelar.TabIndex = 0;
            this.ll_Cancelar.TabStop = true;
            this.ll_Cancelar.Text = "Cancelar";
            this.ll_Cancelar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Cancelar_LinkClicked);
            // 
            // FormRecepcionistaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 482);
            this.Controls.Add(this.gp_ModificarFactura);
            this.Controls.Add(this.l_Nombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.log_photo);
            this.Name = "FormRecepcionistaFactura";
            this.Text = "FormRecepcionistaFactura";
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gp_ModificarFactura.ResumeLayout(false);
            this.gp_ModificarFactura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox picture_ajustes;
        private System.Windows.Forms.PictureBox picture_facturas;
        private System.Windows.Forms.PictureBox picture_clientes;
        private System.Windows.Forms.PictureBox picture_consultas;
        private System.Windows.Forms.PictureBox picture_start;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.TextBox text_buscar;
        public System.Windows.Forms.PictureBox log_photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagada;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Tratamiento;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.GroupBox gp_ModificarFactura;
        public System.Windows.Forms.LinkLabel ll_Eliminar;
        public System.Windows.Forms.LinkLabel ll_Cancelar;
        private System.Windows.Forms.Label l_TratamientoElegir;
        private System.Windows.Forms.Label l_Tratamiento;
        private System.Windows.Forms.Label l_MascotaElegir;
        private System.Windows.Forms.Label l_Motivo;
        private System.Windows.Forms.Label l_Mascota;
        private System.Windows.Forms.Label l_Pagada;
        private System.Windows.Forms.Label l_Total;
        private System.Windows.Forms.Label l_Fecha;
        public System.Windows.Forms.Label l_Nombre;
        public System.Windows.Forms.ComboBox cb_Tratamiento;
        public System.Windows.Forms.TextBox tb_Tratamiento;
        public System.Windows.Forms.TextBox tb_Mascota;
        public System.Windows.Forms.ComboBox cb_Mascota;
        public System.Windows.Forms.TextBox tb_Motivo;
        public System.Windows.Forms.TextBox tb_Pagada;
        public System.Windows.Forms.TextBox tb_Total;
        public System.Windows.Forms.TextBox tb_Fecha;
        public System.Windows.Forms.LinkLabel ll_Modificar;
    }
}