namespace WindowsFormsApplication1
{
    partial class FormAdministradorTratamiento
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministradorTratamiento));
            this.log_date = new System.Windows.Forms.Label();
            this.log_type = new System.Windows.Forms.Label();
            this.log_id = new System.Windows.Forms.Label();
            this.log_name = new System.Windows.Forms.Label();
            this.log_photo = new System.Windows.Forms.PictureBox();
            this.text_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.tratramientos = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formAdministradorTratamientoDataSet = new WindowsFormsApplication1.FormAdministradorTratamientoDataSet();
            this.btn_add = new System.Windows.Forms.PictureBox();
            this.tratamientoTableAdapter = new WindowsFormsApplication1.FormAdministradorTratamientoDataSetTableAdapters.TratamientoTableAdapter();
            this.panel_top = new System.Windows.Forms.Panel();
            this.picture_desconectar_admin = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratramientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAdministradorTratamientoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_desconectar_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // log_date
            // 
            this.log_date.AutoSize = true;
            this.log_date.BackColor = System.Drawing.Color.Transparent;
            this.log_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_date.Location = new System.Drawing.Point(108, 143);
            this.log_date.Name = "log_date";
            this.log_date.Size = new System.Drawing.Size(51, 20);
            this.log_date.TabIndex = 51;
            this.log_date.Text = "label4";
            // 
            // log_type
            // 
            this.log_type.AutoSize = true;
            this.log_type.BackColor = System.Drawing.Color.Transparent;
            this.log_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_type.Location = new System.Drawing.Point(108, 112);
            this.log_type.Name = "log_type";
            this.log_type.Size = new System.Drawing.Size(51, 20);
            this.log_type.TabIndex = 50;
            this.log_type.Text = "label3";
            // 
            // log_id
            // 
            this.log_id.AutoSize = true;
            this.log_id.BackColor = System.Drawing.Color.Transparent;
            this.log_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_id.Location = new System.Drawing.Point(108, 80);
            this.log_id.Name = "log_id";
            this.log_id.Size = new System.Drawing.Size(51, 20);
            this.log_id.TabIndex = 49;
            this.log_id.Text = "label2";
            // 
            // log_name
            // 
            this.log_name.AutoSize = true;
            this.log_name.BackColor = System.Drawing.Color.Transparent;
            this.log_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_name.Location = new System.Drawing.Point(108, 50);
            this.log_name.Name = "log_name";
            this.log_name.Size = new System.Drawing.Size(51, 20);
            this.log_name.TabIndex = 48;
            this.log_name.Text = "label1";
            // 
            // log_photo
            // 
            this.log_photo.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.log_photo.Location = new System.Drawing.Point(12, 44);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(90, 120);
            this.log_photo.TabIndex = 47;
            this.log_photo.TabStop = false;
            // 
            // text_buscar
            // 
            this.text_buscar.Location = new System.Drawing.Point(12, 172);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(392, 20);
            this.text_buscar.TabIndex = 52;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.search_identifier;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(410, 173);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(16, 16);
            this.btn_buscar.TabIndex = 53;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // tratramientos
            // 
            this.tratramientos.AllowUserToAddRows = false;
            this.tratramientos.AllowUserToDeleteRows = false;
            this.tratramientos.AutoGenerateColumns = false;
            this.tratramientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tratramientos.BackgroundColor = System.Drawing.Color.White;
            this.tratramientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tratramientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.Modificar,
            this.Eliminar});
            this.tratramientos.DataSource = this.tratamientoBindingSource;
            this.tratramientos.Location = new System.Drawing.Point(12, 198);
            this.tratramientos.Name = "tratramientos";
            this.tratramientos.ReadOnly = true;
            this.tratramientos.RowHeadersVisible = false;
            this.tratramientos.Size = new System.Drawing.Size(658, 270);
            this.tratramientos.TabIndex = 54;
            this.tratramientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "fechaFin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "fechaFin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            this.fechaFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tratamientoBindingSource
            // 
            this.tratamientoBindingSource.DataMember = "Tratamiento";
            this.tratamientoBindingSource.DataSource = this.formAdministradorTratamientoDataSet;
            // 
            // formAdministradorTratamientoDataSet
            // 
            this.formAdministradorTratamientoDataSet.DataSetName = "FormAdministradorTratamientoDataSet";
            this.formAdministradorTratamientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.add;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Location = new System.Drawing.Point(646, 170);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(24, 24);
            this.btn_add.TabIndex = 55;
            this.btn_add.TabStop = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tratamientoTableAdapter
            // 
            this.tratamientoTableAdapter.ClearBeforeFill = true;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Transparent;
            this.panel_top.Controls.Add(this.picture_desconectar_admin);
            this.panel_top.Controls.Add(this.pictureBox3);
            this.panel_top.Controls.Add(this.pictureBox1);
            this.panel_top.Controls.Add(this.pictureBox2);
            this.panel_top.Location = new System.Drawing.Point(-3, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(676, 34);
            this.panel_top.TabIndex = 57;
            // 
            // picture_desconectar_admin
            // 
            this.picture_desconectar_admin.BackColor = System.Drawing.Color.Transparent;
            this.picture_desconectar_admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_desconectar_admin.BackgroundImage")));
            this.picture_desconectar_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_desconectar_admin.Location = new System.Drawing.Point(517, 0);
            this.picture_desconectar_admin.Name = "picture_desconectar_admin";
            this.picture_desconectar_admin.Size = new System.Drawing.Size(165, 34);
            this.picture_desconectar_admin.TabIndex = 9;
            this.picture_desconectar_admin.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 34);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(345, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 34);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(174, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 34);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // FormAdministradorTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fondo_nuevo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 471);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tratramientos);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.log_date);
            this.Controls.Add(this.log_type);
            this.Controls.Add(this.log_id);
            this.Controls.Add(this.log_name);
            this.Controls.Add(this.log_photo);
            this.Name = "FormAdministradorTratamiento";
            this.Text = "Tratamientos";
            this.Load += new System.EventHandler(this.FormAdministradorTratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratramientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAdministradorTratamientoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).EndInit();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_desconectar_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label log_date;
        public System.Windows.Forms.Label log_type;
        public System.Windows.Forms.Label log_id;
        public System.Windows.Forms.Label log_name;
        public System.Windows.Forms.PictureBox log_photo;
        private System.Windows.Forms.TextBox text_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView tratramientos;
        private System.Windows.Forms.PictureBox btn_add;
        private FormAdministradorTratamientoDataSet formAdministradorTratamientoDataSet;
        private System.Windows.Forms.BindingSource tratamientoBindingSource;
        private FormAdministradorTratamientoDataSetTableAdapters.TratamientoTableAdapter tratamientoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox picture_desconectar_admin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}