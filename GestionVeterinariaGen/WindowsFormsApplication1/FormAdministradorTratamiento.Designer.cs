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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.picture_desconectar_admin = new System.Windows.Forms.PictureBox();
            this.picture_home = new System.Windows.Forms.PictureBox();
            this.picture_tratamiento = new System.Windows.Forms.PictureBox();
            this.picture_empleado = new System.Windows.Forms.PictureBox();
            this.text_stock = new System.Windows.Forms.TextBox();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.text_descripcion = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGrid_tratamientos = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosisdiariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formAdministradorTratamientoDataSet = new WindowsFormsApplication1.FormAdministradorTratamientoDataSet();
            this.tratamientoTableAdapter = new WindowsFormsApplication1.FormAdministradorTratamientoDataSetTableAdapters.TratamientoTableAdapter();
            this.btn_delete = new System.Windows.Forms.PictureBox();
            this.btn_erase = new System.Windows.Forms.Button();
            this.lista_dosis = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_desconectar_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_tratamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAdministradorTratamientoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.search_identifier;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(354, 63);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(16, 16);
            this.btn_buscar.TabIndex = 53;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_id_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.add;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Location = new System.Drawing.Point(602, 113);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(24, 24);
            this.btn_add.TabIndex = 55;
            this.btn_add.TabStop = false;
            this.btn_add.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Transparent;
            this.panel_top.Controls.Add(this.picture_desconectar_admin);
            this.panel_top.Controls.Add(this.picture_home);
            this.panel_top.Controls.Add(this.picture_tratamiento);
            this.panel_top.Controls.Add(this.picture_empleado);
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
            this.picture_desconectar_admin.Click += new System.EventHandler(this.picture_desconectar_Click);
            // 
            // picture_home
            // 
            this.picture_home.BackColor = System.Drawing.Color.Transparent;
            this.picture_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_home.BackgroundImage")));
            this.picture_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_home.Location = new System.Drawing.Point(3, 0);
            this.picture_home.Name = "picture_home";
            this.picture_home.Size = new System.Drawing.Size(165, 34);
            this.picture_home.TabIndex = 5;
            this.picture_home.TabStop = false;
            this.picture_home.Click += new System.EventHandler(this.picture_start_Click);
            // 
            // picture_tratamiento
            // 
            this.picture_tratamiento.BackColor = System.Drawing.Color.Transparent;
            this.picture_tratamiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_tratamiento.BackgroundImage")));
            this.picture_tratamiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_tratamiento.Location = new System.Drawing.Point(345, 0);
            this.picture_tratamiento.Name = "picture_tratamiento";
            this.picture_tratamiento.Size = new System.Drawing.Size(165, 34);
            this.picture_tratamiento.TabIndex = 8;
            this.picture_tratamiento.TabStop = false;
            this.picture_tratamiento.Click += new System.EventHandler(this.picture_tratatamiento_Click);
            // 
            // picture_empleado
            // 
            this.picture_empleado.BackColor = System.Drawing.Color.Transparent;
            this.picture_empleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_empleado.BackgroundImage")));
            this.picture_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_empleado.Location = new System.Drawing.Point(174, 0);
            this.picture_empleado.Name = "picture_empleado";
            this.picture_empleado.Size = new System.Drawing.Size(165, 34);
            this.picture_empleado.TabIndex = 7;
            this.picture_empleado.TabStop = false;
            this.picture_empleado.Click += new System.EventHandler(this.picture_empleados_Click);
            // 
            // text_stock
            // 
            this.text_stock.Location = new System.Drawing.Point(62, 95);
            this.text_stock.Name = "text_stock";
            this.text_stock.Size = new System.Drawing.Size(55, 20);
            this.text_stock.TabIndex = 59;
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(62, 59);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(286, 20);
            this.text_nombre.TabIndex = 60;
            // 
            // text_descripcion
            // 
            this.text_descripcion.Location = new System.Drawing.Point(12, 143);
            this.text_descripcion.Multiline = true;
            this.text_descripcion.Name = "text_descripcion";
            this.text_descripcion.Size = new System.Drawing.Size(650, 55);
            this.text_descripcion.TabIndex = 61;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.BackColor = System.Drawing.Color.Transparent;
            this.label_nombre.Location = new System.Drawing.Point(12, 62);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 62;
            this.label_nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(276, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Dosis Diaria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(142, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Stock";
            // 
            // text_precio
            // 
            this.text_precio.Location = new System.Drawing.Point(185, 95);
            this.text_precio.Name = "text_precio";
            this.text_precio.Size = new System.Drawing.Size(72, 20);
            this.text_precio.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Descripción";
            // 
            // dataGrid_tratamientos
            // 
            this.dataGrid_tratamientos.AllowUserToAddRows = false;
            this.dataGrid_tratamientos.AllowUserToDeleteRows = false;
            this.dataGrid_tratamientos.AutoGenerateColumns = false;
            this.dataGrid_tratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_tratamientos.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_tratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_tratamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.dosisdiariaDataGridViewTextBoxColumn});
            this.dataGrid_tratamientos.DataSource = this.tratamientoBindingSource;
            this.dataGrid_tratamientos.Location = new System.Drawing.Point(12, 204);
            this.dataGrid_tratamientos.Name = "dataGrid_tratamientos";
            this.dataGrid_tratamientos.ReadOnly = true;
            this.dataGrid_tratamientos.RowHeadersVisible = false;
            this.dataGrid_tratamientos.Size = new System.Drawing.Size(650, 255);
            this.dataGrid_tratamientos.TabIndex = 70;
            this.dataGrid_tratamientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dosisdiariaDataGridViewTextBoxColumn
            // 
            this.dosisdiariaDataGridViewTextBoxColumn.DataPropertyName = "dosis_diaria";
            this.dosisdiariaDataGridViewTextBoxColumn.HeaderText = "Dosis Diaria";
            this.dosisdiariaDataGridViewTextBoxColumn.Name = "dosisdiariaDataGridViewTextBoxColumn";
            this.dosisdiariaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tratamientoTableAdapter
            // 
            this.tratamientoTableAdapter.ClearBeforeFill = true;
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.delete;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.Location = new System.Drawing.Point(638, 113);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(24, 24);
            this.btn_delete.TabIndex = 71;
            this.btn_delete.TabStop = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_erase
            // 
            this.btn_erase.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.eraser;
            this.btn_erase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_erase.FlatAppearance.BorderSize = 0;
            this.btn_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_erase.Location = new System.Drawing.Point(376, 63);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(16, 16);
            this.btn_erase.TabIndex = 73;
            this.btn_erase.UseVisualStyleBackColor = true;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // lista_dosis
            // 
            this.lista_dosis.FormattingEnabled = true;
            this.lista_dosis.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.lista_dosis.Location = new System.Drawing.Point(345, 94);
            this.lista_dosis.Name = "lista_dosis";
            this.lista_dosis.Size = new System.Drawing.Size(47, 21);
            this.lista_dosis.TabIndex = 75;
            // 
            // FormAdministradorTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 471);
            this.Controls.Add(this.lista_dosis);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGrid_tratamientos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.text_descripcion);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.text_stock);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_buscar);
            this.Name = "FormAdministradorTratamiento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratamientos";
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).EndInit();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_desconectar_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_tratamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAdministradorTratamientoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.PictureBox btn_add;
        public System.Windows.Forms.Panel panel_top;
        public System.Windows.Forms.PictureBox picture_desconectar_admin;
        public System.Windows.Forms.PictureBox picture_home;
        public System.Windows.Forms.PictureBox picture_tratamiento;
        public System.Windows.Forms.PictureBox picture_empleado;
        public System.Windows.Forms.TextBox text_stock;
        public System.Windows.Forms.TextBox text_nombre;
        public System.Windows.Forms.TextBox text_descripcion;
        public System.Windows.Forms.Label label_nombre;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox text_precio;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGrid_tratamientos;
        public FormAdministradorTratamientoDataSet formAdministradorTratamientoDataSet;
        public System.Windows.Forms.BindingSource tratamientoBindingSource;
        public FormAdministradorTratamientoDataSetTableAdapters.TratamientoTableAdapter tratamientoTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn dosisdiariaDataGridViewTextBoxColumn;
        public System.Windows.Forms.PictureBox btn_delete;
        public System.Windows.Forms.Button btn_erase;
        public System.Windows.Forms.ComboBox lista_dosis;
    }
}