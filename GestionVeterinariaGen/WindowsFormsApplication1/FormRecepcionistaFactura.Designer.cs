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
            this.l_Nombre = new System.Windows.Forms.Label();
            this.text_dni = new System.Windows.Forms.TextBox();
            this.label_dni = new System.Windows.Forms.Label();
            this.dataGridFacturas = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Pagada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Exportar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.alerta_pagar = new System.Windows.Forms.Panel();
            this.texto_alerta = new System.Windows.Forms.Label();
            this.btn_pagar_no = new System.Windows.Forms.Button();
            this.btn_pagar_si = new System.Windows.Forms.Button();
            this.dataGridTratamientos = new System.Windows.Forms.DataGridView();
            this.trat_col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trat_col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trat_col_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_trata_ok = new System.Windows.Forms.Button();
            this.panel_tratamientos = new System.Windows.Forms.Panel();
            this.btn_buscar_dni = new System.Windows.Forms.PictureBox();
            this.log_photo = new System.Windows.Forms.PictureBox();
            this.panel_recepcionista = new System.Windows.Forms.Panel();
            this.picture_ajustes = new System.Windows.Forms.PictureBox();
            this.picture_consultas = new System.Windows.Forms.PictureBox();
            this.picture_clientes = new System.Windows.Forms.PictureBox();
            this.picture_facturas = new System.Windows.Forms.PictureBox();
            this.picture_start = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).BeginInit();
            this.alerta_pagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTratamientos)).BeginInit();
            this.panel_tratamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_dni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            this.panel_recepcionista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Nombre
            // 
            this.l_Nombre.AutoSize = true;
            this.l_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.l_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Nombre.Location = new System.Drawing.Point(139, 56);
            this.l_Nombre.Name = "l_Nombre";
            this.l_Nombre.Size = new System.Drawing.Size(0, 20);
            this.l_Nombre.TabIndex = 62;
            // 
            // text_dni
            // 
            this.text_dni.Location = new System.Drawing.Point(175, 146);
            this.text_dni.Name = "text_dni";
            this.text_dni.Size = new System.Drawing.Size(134, 20);
            this.text_dni.TabIndex = 73;
            // 
            // label_dni
            // 
            this.label_dni.AutoSize = true;
            this.label_dni.BackColor = System.Drawing.Color.Transparent;
            this.label_dni.Location = new System.Drawing.Point(127, 150);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(42, 13);
            this.label_dni.TabIndex = 72;
            this.label_dni.Text = "Cliente:";
            // 
            // dataGridFacturas
            // 
            this.dataGridFacturas.AllowUserToAddRows = false;
            this.dataGridFacturas.AllowUserToDeleteRows = false;
            this.dataGridFacturas.AllowUserToResizeRows = false;
            this.dataGridFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFacturas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Fecha,
            this.Total,
            this.Mascota,
            this.Motivo,
            this.Tratamiento,
            this.Pagada,
            this.Pagar,
            this.Exportar});
            this.dataGridFacturas.Location = new System.Drawing.Point(12, 197);
            this.dataGridFacturas.Name = "dataGridFacturas";
            this.dataGridFacturas.ReadOnly = true;
            this.dataGridFacturas.RowHeadersVisible = false;
            this.dataGridFacturas.Size = new System.Drawing.Size(658, 274);
            this.dataGridFacturas.TabIndex = 81;
            this.dataGridFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridFacturas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting_1);
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
            // Tratamiento
            // 
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.Name = "Tratamiento";
            this.Tratamiento.ReadOnly = true;
            this.Tratamiento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tratamiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Pagada
            // 
            this.Pagada.HeaderText = "Pagada";
            this.Pagada.Name = "Pagada";
            this.Pagada.ReadOnly = true;
            // 
            // Pagar
            // 
            this.Pagar.HeaderText = "Pagar";
            this.Pagar.Name = "Pagar";
            this.Pagar.ReadOnly = true;
            // 
            // Exportar
            // 
            this.Exportar.HeaderText = "Exportar";
            this.Exportar.Name = "Exportar";
            this.Exportar.ReadOnly = true;
            this.Exportar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Exportar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // alerta_pagar
            // 
            this.alerta_pagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alerta_pagar.Controls.Add(this.texto_alerta);
            this.alerta_pagar.Controls.Add(this.btn_pagar_no);
            this.alerta_pagar.Controls.Add(this.btn_pagar_si);
            this.alerta_pagar.Location = new System.Drawing.Point(394, 111);
            this.alerta_pagar.Name = "alerta_pagar";
            this.alerta_pagar.Size = new System.Drawing.Size(200, 67);
            this.alerta_pagar.TabIndex = 82;
            this.alerta_pagar.Visible = false;
            // 
            // texto_alerta
            // 
            this.texto_alerta.AutoSize = true;
            this.texto_alerta.Location = new System.Drawing.Point(3, 16);
            this.texto_alerta.Name = "texto_alerta";
            this.texto_alerta.Size = new System.Drawing.Size(86, 13);
            this.texto_alerta.TabIndex = 2;
            this.texto_alerta.Text = "¿Pagar Factura?";
            // 
            // btn_pagar_no
            // 
            this.btn_pagar_no.Location = new System.Drawing.Point(104, 35);
            this.btn_pagar_no.Name = "btn_pagar_no";
            this.btn_pagar_no.Size = new System.Drawing.Size(41, 23);
            this.btn_pagar_no.TabIndex = 1;
            this.btn_pagar_no.Text = "No";
            this.btn_pagar_no.UseVisualStyleBackColor = true;
            this.btn_pagar_no.Click += new System.EventHandler(this.btn_pagar_no_Click);
            // 
            // btn_pagar_si
            // 
            this.btn_pagar_si.Location = new System.Drawing.Point(151, 35);
            this.btn_pagar_si.Name = "btn_pagar_si";
            this.btn_pagar_si.Size = new System.Drawing.Size(38, 23);
            this.btn_pagar_si.TabIndex = 0;
            this.btn_pagar_si.Text = "Si";
            this.btn_pagar_si.UseVisualStyleBackColor = true;
            this.btn_pagar_si.Click += new System.EventHandler(this.btn_pagar_si_Click);
            // 
            // dataGridTratamientos
            // 
            this.dataGridTratamientos.AllowUserToAddRows = false;
            this.dataGridTratamientos.AllowUserToDeleteRows = false;
            this.dataGridTratamientos.AllowUserToResizeRows = false;
            this.dataGridTratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTratamientos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTratamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trat_col_Nombre,
            this.trat_col_Descripcion,
            this.trat_col_Precio});
            this.dataGridTratamientos.Location = new System.Drawing.Point(3, 3);
            this.dataGridTratamientos.Name = "dataGridTratamientos";
            this.dataGridTratamientos.ReadOnly = true;
            this.dataGridTratamientos.RowHeadersVisible = false;
            this.dataGridTratamientos.Size = new System.Drawing.Size(401, 138);
            this.dataGridTratamientos.TabIndex = 84;
            // 
            // trat_col_Nombre
            // 
            this.trat_col_Nombre.FillWeight = 127.1574F;
            this.trat_col_Nombre.HeaderText = "Nombre";
            this.trat_col_Nombre.Name = "trat_col_Nombre";
            this.trat_col_Nombre.ReadOnly = true;
            // 
            // trat_col_Descripcion
            // 
            this.trat_col_Descripcion.FillWeight = 127.1574F;
            this.trat_col_Descripcion.HeaderText = "Descripcion";
            this.trat_col_Descripcion.Name = "trat_col_Descripcion";
            this.trat_col_Descripcion.ReadOnly = true;
            // 
            // trat_col_Precio
            // 
            this.trat_col_Precio.FillWeight = 45.68528F;
            this.trat_col_Precio.HeaderText = "Precio";
            this.trat_col_Precio.Name = "trat_col_Precio";
            this.trat_col_Precio.ReadOnly = true;
            // 
            // btn_trata_ok
            // 
            this.btn_trata_ok.Location = new System.Drawing.Point(179, 147);
            this.btn_trata_ok.Name = "btn_trata_ok";
            this.btn_trata_ok.Size = new System.Drawing.Size(38, 23);
            this.btn_trata_ok.TabIndex = 0;
            this.btn_trata_ok.Text = "Ok";
            this.btn_trata_ok.UseVisualStyleBackColor = true;
            this.btn_trata_ok.Click += new System.EventHandler(this.btn_trata_ok_Click);
            // 
            // panel_tratamientos
            // 
            this.panel_tratamientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_tratamientos.Controls.Add(this.dataGridTratamientos);
            this.panel_tratamientos.Controls.Add(this.btn_trata_ok);
            this.panel_tratamientos.Location = new System.Drawing.Point(239, 264);
            this.panel_tratamientos.Name = "panel_tratamientos";
            this.panel_tratamientos.Size = new System.Drawing.Size(409, 175);
            this.panel_tratamientos.TabIndex = 84;
            this.panel_tratamientos.Visible = false;
            // 
            // btn_buscar_dni
            // 
            this.btn_buscar_dni.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar_dni.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.btn_buscar_id;
            this.btn_buscar_dni.Location = new System.Drawing.Point(315, 150);
            this.btn_buscar_dni.Name = "btn_buscar_dni";
            this.btn_buscar_dni.Size = new System.Drawing.Size(16, 16);
            this.btn_buscar_dni.TabIndex = 80;
            this.btn_buscar_dni.TabStop = false;
            this.btn_buscar_dni.Click += new System.EventHandler(this.btn_buscar_dni_Click);
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
            // panel_recepcionista
            // 
            this.panel_recepcionista.BackColor = System.Drawing.Color.Transparent;
            this.panel_recepcionista.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.BARRA_MENU;
            this.panel_recepcionista.Controls.Add(this.picture_ajustes);
            this.panel_recepcionista.Controls.Add(this.picture_consultas);
            this.panel_recepcionista.Controls.Add(this.picture_clientes);
            this.panel_recepcionista.Controls.Add(this.picture_facturas);
            this.panel_recepcionista.Controls.Add(this.picture_start);
            this.panel_recepcionista.Location = new System.Drawing.Point(0, 0);
            this.panel_recepcionista.Name = "panel_recepcionista";
            this.panel_recepcionista.Size = new System.Drawing.Size(690, 44);
            this.panel_recepcionista.TabIndex = 85;
            // 
            // picture_ajustes
            // 
            this.picture_ajustes.BackColor = System.Drawing.Color.Transparent;
            this.picture_ajustes.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_RECEPCIONISTA_DESCONECTAR;
            this.picture_ajustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_ajustes.Location = new System.Drawing.Point(546, 0);
            this.picture_ajustes.Name = "picture_ajustes";
            this.picture_ajustes.Size = new System.Drawing.Size(138, 44);
            this.picture_ajustes.TabIndex = 4;
            this.picture_ajustes.TabStop = false;
            this.picture_ajustes.Click += new System.EventHandler(this.picture_ajustes_Click);
            // 
            // picture_consultas
            // 
            this.picture_consultas.BackColor = System.Drawing.Color.Transparent;
            this.picture_consultas.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_RECEPCIONISTA_CONSULTA;
            this.picture_consultas.Location = new System.Drawing.Point(137, 0);
            this.picture_consultas.Name = "picture_consultas";
            this.picture_consultas.Size = new System.Drawing.Size(138, 44);
            this.picture_consultas.TabIndex = 1;
            this.picture_consultas.TabStop = false;
            this.picture_consultas.Click += new System.EventHandler(this.picture_consultas_Click);
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
            // picture_facturas
            // 
            this.picture_facturas.BackColor = System.Drawing.Color.White;
            this.picture_facturas.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_RECEPCIONISTA_FACTURA;
            this.picture_facturas.Location = new System.Drawing.Point(409, 0);
            this.picture_facturas.Name = "picture_facturas";
            this.picture_facturas.Size = new System.Drawing.Size(138, 44);
            this.picture_facturas.TabIndex = 3;
            this.picture_facturas.TabStop = false;
            this.picture_facturas.Click += new System.EventHandler(this.picture_facturas_Click);
            // 
            // picture_start
            // 
            this.picture_start.BackColor = System.Drawing.Color.Transparent;
            this.picture_start.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_RECEPCIONISTA_INICIO;
            this.picture_start.Location = new System.Drawing.Point(1, 0);
            this.picture_start.Name = "picture_start";
            this.picture_start.Size = new System.Drawing.Size(138, 44);
            this.picture_start.TabIndex = 0;
            this.picture_start.TabStop = false;
            this.picture_start.Click += new System.EventHandler(this.picture_start_Click);
            // 
            // FormRecepcionistaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.panel_recepcionista);
            this.Controls.Add(this.panel_tratamientos);
            this.Controls.Add(this.alerta_pagar);
            this.Controls.Add(this.dataGridFacturas);
            this.Controls.Add(this.btn_buscar_dni);
            this.Controls.Add(this.text_dni);
            this.Controls.Add(this.label_dni);
            this.Controls.Add(this.l_Nombre);
            this.Controls.Add(this.log_photo);
            this.Name = "FormRecepcionistaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecepcionistaFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).EndInit();
            this.alerta_pagar.ResumeLayout(false);
            this.alerta_pagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTratamientos)).EndInit();
            this.panel_tratamientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_dni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            this.panel_recepcionista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox log_photo;
        public System.Windows.Forms.Label l_Nombre;
        public System.Windows.Forms.TextBox text_dni;
        public System.Windows.Forms.Label label_dni;
        public System.Windows.Forms.PictureBox btn_buscar_dni;
        public System.Windows.Forms.DataGridView dataGridFacturas;
        public System.Windows.Forms.Panel alerta_pagar;
        public System.Windows.Forms.Label texto_alerta;
        public System.Windows.Forms.Button btn_pagar_no;
        public System.Windows.Forms.Button btn_pagar_si;
        public System.Windows.Forms.DataGridView dataGridTratamientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn trat_col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn trat_col_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn trat_col_Precio;
        public System.Windows.Forms.Button btn_trata_ok;
        public System.Windows.Forms.Panel panel_tratamientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewButtonColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagada;
        private System.Windows.Forms.DataGridViewButtonColumn Pagar;
        private System.Windows.Forms.DataGridViewButtonColumn Exportar;
        private System.Windows.Forms.Panel panel_recepcionista;
        private System.Windows.Forms.PictureBox picture_ajustes;
        private System.Windows.Forms.PictureBox picture_consultas;
        private System.Windows.Forms.PictureBox picture_clientes;
        private System.Windows.Forms.PictureBox picture_facturas;
        private System.Windows.Forms.PictureBox picture_start;
    }
}