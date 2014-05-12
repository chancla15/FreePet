﻿namespace WindowsFormsApplication1
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
            this.log_photo = new System.Windows.Forms.PictureBox();
            this.l_Nombre = new System.Windows.Forms.Label();
            this.text_dni = new System.Windows.Forms.TextBox();
            this.label_dni = new System.Windows.Forms.Label();
            this.btn_buscar_dni = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Pagada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.alerta_pagar = new System.Windows.Forms.Panel();
            this.texto_alerta = new System.Windows.Forms.Label();
            this.btn_pagar_no = new System.Windows.Forms.Button();
            this.btn_pagar_si = new System.Windows.Forms.Button();
            this.btn_erase = new System.Windows.Forms.PictureBox();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_dni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.alerta_pagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_erase)).BeginInit();
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
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
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
            // log_photo
            // 
            this.log_photo.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.log_photo.Location = new System.Drawing.Point(12, 46);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(90, 120);
            this.log_photo.TabIndex = 52;
            this.log_photo.TabStop = false;
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
            this.label_dni.Location = new System.Drawing.Point(140, 149);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(29, 13);
            this.label_dni.TabIndex = 72;
            this.label_dni.Text = "DNI:";
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
            this.Tratamiento,
            this.Pagada,
            this.Pagar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(658, 274);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting_1);
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
            // btn_erase
            // 
            this.btn_erase.BackColor = System.Drawing.Color.Transparent;
            this.btn_erase.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.eraser;
            this.btn_erase.Location = new System.Drawing.Point(337, 150);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(16, 16);
            this.btn_erase.TabIndex = 83;
            this.btn_erase.TabStop = false;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // FormRecepcionistaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.alerta_pagar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_buscar_dni);
            this.Controls.Add(this.text_dni);
            this.Controls.Add(this.label_dni);
            this.Controls.Add(this.l_Nombre);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.log_photo);
            this.Name = "FormRecepcionistaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecepcionistaFactura";
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_dni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.alerta_pagar.ResumeLayout(false);
            this.alerta_pagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_erase)).EndInit();
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
        public System.Windows.Forms.PictureBox log_photo;
        public System.Windows.Forms.Label l_Nombre;
        public System.Windows.Forms.TextBox text_dni;
        public System.Windows.Forms.Label label_dni;
        public System.Windows.Forms.PictureBox btn_buscar_dni;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagada;
        private System.Windows.Forms.DataGridViewButtonColumn Pagar;
        public System.Windows.Forms.Panel alerta_pagar;
        public System.Windows.Forms.Label texto_alerta;
        public System.Windows.Forms.Button btn_pagar_no;
        public System.Windows.Forms.Button btn_pagar_si;
        public System.Windows.Forms.PictureBox btn_erase;
    }
}