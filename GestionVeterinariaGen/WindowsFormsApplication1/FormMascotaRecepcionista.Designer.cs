namespace WindowsFormsApplication1
{
    partial class FormMascotaRecepcionista
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
            this.components = new System.ComponentModel.Container();
            this.log_date = new System.Windows.Forms.Label();
            this.log_type = new System.Windows.Forms.Label();
            this.log_id = new System.Windows.Forms.Label();
            this.log_name = new System.Windows.Forms.Label();
            this.log_photo = new System.Windows.Forms.PictureBox();
            this.text_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKDNIidClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FormMascotaRecepcionistaDataSet = new WindowsFormsApplication1.FormMascotaRecepcionista_DataSet();
            this.mascotaTableAdapter = new WindowsFormsApplication1.GestionVeterinariaGenNHibernateDataSet1TableAdapters.MascotaTableAdapter();
            this.btn_add = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeGestionVetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormMascotaRecepcionistaDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // log_date
            // 
            this.log_date.AutoSize = true;
            this.log_date.BackColor = System.Drawing.Color.Transparent;
            this.log_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_date.Location = new System.Drawing.Point(108, 137);
            this.log_date.Name = "log_date";
            this.log_date.Size = new System.Drawing.Size(51, 20);
            this.log_date.TabIndex = 41;
            this.log_date.Text = "label4";
            // 
            // log_type
            // 
            this.log_type.AutoSize = true;
            this.log_type.BackColor = System.Drawing.Color.Transparent;
            this.log_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_type.Location = new System.Drawing.Point(108, 105);
            this.log_type.Name = "log_type";
            this.log_type.Size = new System.Drawing.Size(51, 20);
            this.log_type.TabIndex = 40;
            this.log_type.Text = "label3";
            // 
            // log_id
            // 
            this.log_id.AutoSize = true;
            this.log_id.BackColor = System.Drawing.Color.Transparent;
            this.log_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_id.Location = new System.Drawing.Point(108, 72);
            this.log_id.Name = "log_id";
            this.log_id.Size = new System.Drawing.Size(51, 20);
            this.log_id.TabIndex = 39;
            this.log_id.Text = "label2";
            // 
            // log_name
            // 
            this.log_name.AutoSize = true;
            this.log_name.BackColor = System.Drawing.Color.Transparent;
            this.log_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_name.Location = new System.Drawing.Point(108, 37);
            this.log_name.Name = "log_name";
            this.log_name.Size = new System.Drawing.Size(51, 20);
            this.log_name.TabIndex = 38;
            this.log_name.Text = "label1";
            // 
            // log_photo
            // 
            this.log_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_photo.ErrorImage = null;
            this.log_photo.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.log_photo.InitialImage = null;
            this.log_photo.Location = new System.Drawing.Point(12, 37);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(90, 120);
            this.log_photo.TabIndex = 36;
            this.log_photo.TabStop = false;
            // 
            // text_buscar
            // 
            this.text_buscar.Location = new System.Drawing.Point(12, 172);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(457, 20);
            this.text_buscar.TabIndex = 42;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(475, 169);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(129, 23);
            this.btn_buscar.TabIndex = 43;
            this.btn_buscar.Text = "BUSCAR MASCOTAS";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.fKDNIidClienteDataGridViewTextBoxColumn,
            this.Modificar,
            this.Eliminar});
            this.dataGridView1.DataSource = this.mascotaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(642, 230);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting_1);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKDNIidClienteDataGridViewTextBoxColumn
            // 
            this.fKDNIidClienteDataGridViewTextBoxColumn.DataPropertyName = "FK_DNI_idCliente";
            this.fKDNIidClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.fKDNIidClienteDataGridViewTextBoxColumn.Name = "fKDNIidClienteDataGridViewTextBoxColumn";
            this.fKDNIidClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.DataPropertyName = "DNI";
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
            // mascotaBindingSource
            // 
            this.mascotaBindingSource.DataMember = "Mascota";
            this.mascotaBindingSource.DataSource = this.FormMascotaRecepcionistaDataSet;
            // 
            // FormMascotaRecepcionistaDataSet
            // 
            this.FormMascotaRecepcionistaDataSet.DataSetName = "FormStartRecepcionistaDataSet";
            this.FormMascotaRecepcionistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mascotaTableAdapter
            // 
            this.mascotaTableAdapter.ClearBeforeFill = true;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.add;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Location = new System.Drawing.Point(631, 186);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(23, 21);
            this.btn_add.TabIndex = 49;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desconectarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPerfilToolStripMenuItem,
            this.modificarPerfilToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // verPerfilToolStripMenuItem
            // 
            this.verPerfilToolStripMenuItem.Name = "verPerfilToolStripMenuItem";
            this.verPerfilToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.verPerfilToolStripMenuItem.Text = "Ver Perfil";
            this.verPerfilToolStripMenuItem.Click += new System.EventHandler(this.verPerfilToolStripMenuItem_Click);
            // 
            // modificarPerfilToolStripMenuItem
            // 
            this.modificarPerfilToolStripMenuItem.Name = "modificarPerfilToolStripMenuItem";
            this.modificarPerfilToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.modificarPerfilToolStripMenuItem.Text = "Modificar Perfil";
            this.modificarPerfilToolStripMenuItem.Click += new System.EventHandler(this.modificarPerfilToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verClientesToolStripMenuItem,
            this.añadirClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // verClientesToolStripMenuItem
            // 
            this.verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            this.verClientesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.verClientesToolStripMenuItem.Text = "Ver Clientes";
            this.verClientesToolStripMenuItem.Click += new System.EventHandler(this.verClientesToolStripMenuItem_Click);
            // 
            // añadirClientesToolStripMenuItem
            // 
            this.añadirClientesToolStripMenuItem.Name = "añadirClientesToolStripMenuItem";
            this.añadirClientesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.añadirClientesToolStripMenuItem.Text = "Añadir Clientes";
            this.añadirClientesToolStripMenuItem.Click += new System.EventHandler(this.añadirClientesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPacientesToolStripMenuItem,
            this.añadirPacientesToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.usuariosToolStripMenuItem.Text = "Pacientes";
            // 
            // verPacientesToolStripMenuItem
            // 
            this.verPacientesToolStripMenuItem.Name = "verPacientesToolStripMenuItem";
            this.verPacientesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.verPacientesToolStripMenuItem.Text = "Ver Pacientes";
            this.verPacientesToolStripMenuItem.Click += new System.EventHandler(this.añadirPacientesToolStripMenuItem_Click);
            // 
            // añadirPacientesToolStripMenuItem
            // 
            this.añadirPacientesToolStripMenuItem.Name = "añadirPacientesToolStripMenuItem";
            this.añadirPacientesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.añadirPacientesToolStripMenuItem.Text = "Añadir Pacientes";
            this.añadirPacientesToolStripMenuItem.Click += new System.EventHandler(this.añadirPacientesToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verFacturasToolStripMenuItem,
            this.añadirFacturasToolStripMenuItem});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // verFacturasToolStripMenuItem
            // 
            this.verFacturasToolStripMenuItem.Name = "verFacturasToolStripMenuItem";
            this.verFacturasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.verFacturasToolStripMenuItem.Text = "Ver Facturas";
            this.verFacturasToolStripMenuItem.Click += new System.EventHandler(this.verFacturasToolStripMenuItem_Click);
            // 
            // añadirFacturasToolStripMenuItem
            // 
            this.añadirFacturasToolStripMenuItem.Name = "añadirFacturasToolStripMenuItem";
            this.añadirFacturasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.añadirFacturasToolStripMenuItem.Text = "Añadir Facturas";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verConsultasToolStripMenuItem,
            this.añadirConsultasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // verConsultasToolStripMenuItem
            // 
            this.verConsultasToolStripMenuItem.Name = "verConsultasToolStripMenuItem";
            this.verConsultasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.verConsultasToolStripMenuItem.Text = "Ver Consultas";
            this.verConsultasToolStripMenuItem.Click += new System.EventHandler(this.verConsultasToolStripMenuItem_Click);
            // 
            // añadirConsultasToolStripMenuItem
            // 
            this.añadirConsultasToolStripMenuItem.Name = "añadirConsultasToolStripMenuItem";
            this.añadirConsultasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.añadirConsultasToolStripMenuItem.Text = "Añadir Consultas";
            this.añadirConsultasToolStripMenuItem.Click += new System.EventHandler(this.añadirConsultasToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verEmpleadosToolStripMenuItem,
            this.añadirEmpleadosToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // verEmpleadosToolStripMenuItem
            // 
            this.verEmpleadosToolStripMenuItem.Name = "verEmpleadosToolStripMenuItem";
            this.verEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.verEmpleadosToolStripMenuItem.Text = "Ver Empleados";
            this.verEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.verEmpleadosToolStripMenuItem_Click);
            // 
            // añadirEmpleadosToolStripMenuItem
            // 
            this.añadirEmpleadosToolStripMenuItem.Name = "añadirEmpleadosToolStripMenuItem";
            this.añadirEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.añadirEmpleadosToolStripMenuItem.Text = "Añadir Empleados";
            this.añadirEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.añadirEmpleadosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.acercaDeGestionVetToolStripMenuItem,
            this.soporteTécnicoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.acercaDeToolStripMenuItem.Text = "Ver Ayuda";
            // 
            // acercaDeGestionVetToolStripMenuItem
            // 
            this.acercaDeGestionVetToolStripMenuItem.Name = "acercaDeGestionVetToolStripMenuItem";
            this.acercaDeGestionVetToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.acercaDeGestionVetToolStripMenuItem.Text = "Acerca De GestionVet";
            // 
            // soporteTécnicoToolStripMenuItem
            // 
            this.soporteTécnicoToolStripMenuItem.Name = "soporteTécnicoToolStripMenuItem";
            this.soporteTécnicoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.soporteTécnicoToolStripMenuItem.Text = "Soporte Técnico";
            // 
            // FormMascotaRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fondo_nuevo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 449);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.log_date);
            this.Controls.Add(this.log_type);
            this.Controls.Add(this.log_id);
            this.Controls.Add(this.log_name);
            this.Controls.Add(this.log_photo);
            this.Name = "FormMascotaRecepcionista";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mascotas";
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormMascotaRecepcionistaDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label log_date;
        public System.Windows.Forms.Label log_type;
        public System.Windows.Forms.Label log_id;
        public System.Windows.Forms.Label log_name;
        public System.Windows.Forms.PictureBox log_photo;
        public System.Windows.Forms.TextBox text_buscar;
        public System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.DataGridView dataGridView1;
        public FormMascotaRecepcionista_DataSet FormMascotaRecepcionistaDataSet;
        public System.Windows.Forms.BindingSource mascotaBindingSource;
        public GestionVeterinariaGenNHibernateDataSet1TableAdapters.MascotaTableAdapter mascotaTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn fKDNIidClienteDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewButtonColumn Modificar;
        public System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem verPerfilToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modificarPerfilToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem verClientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem añadirClientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem verPacientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem añadirPacientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem verFacturasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem añadirFacturasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem verConsultasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem añadirConsultasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem añadirEmpleadosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem verEmpleadosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem acercaDeGestionVetToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem soporteTécnicoToolStripMenuItem;
    }
}