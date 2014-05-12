namespace WindowsFormsApplication1
{
    partial class FormRecepcionistaAdministradorInicio
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecepcionistaAdministradorInicio));
            this.log_date = new System.Windows.Forms.Label();
            this.log_type = new System.Windows.Forms.Label();
            this.log_id = new System.Windows.Forms.Label();
            this.log_name = new System.Windows.Forms.Label();
            this.text_buscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGrid_clientes = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FormStartRecepcionistaDataSet = new WindowsFormsApplication1.FormRecepcionistaAdministradorInicio_DataSet();
            this.usuarioTableAdapter = new WindowsFormsApplication1.FormRecepcionistaAdministradorInicio_DataSetTableAdapters.ClienteTableAdapter();
            this.panel_top = new System.Windows.Forms.Panel();
            this.picture_tratamientos_admin = new System.Windows.Forms.PictureBox();
            this.picture_empleados_admin = new System.Windows.Forms.PictureBox();
            this.picture_ajustes_admin = new System.Windows.Forms.PictureBox();
            this.picture_start_admin = new System.Windows.Forms.PictureBox();
            this.picture_ajustes_recepcionista = new System.Windows.Forms.PictureBox();
            this.picture_facturas_recepcionista = new System.Windows.Forms.PictureBox();
            this.picture_clientes_recepcionista = new System.Windows.Forms.PictureBox();
            this.picture_consultas_recepcionista = new System.Windows.Forms.PictureBox();
            this.picture_start_recepcionista = new System.Windows.Forms.PictureBox();
            this.ListaEmpleados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModificarEmpleado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarEmpleado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formRecepcionistaAdministradorInicio_DataSet2 = new WindowsFormsApplication1.FormRecepcionistaAdministradorInicio_DataSet2();
            this.usuarioTableAdapter1 = new WindowsFormsApplication1.FormRecepcionistaAdministradorInicio_DataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.FormRecepcionistaAdministradorInicio_DataSetTableAdapters.TableAdapterManager();
            this.listaempleadosToolStrip = new System.Windows.Forms.ToolStrip();
            this.listaempleadosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.log_photo = new System.Windows.Forms.PictureBox();
            this.usuarioTableAdapter2 = new WindowsFormsApplication1.FormRecepcionistaAdministradorInicio_DataSet2TableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormStartRecepcionistaDataSet)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tratamientos_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_empleados_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes_recepcionista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas_recepcionista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes_recepcionista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas_recepcionista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start_recepcionista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRecepcionistaAdministradorInicio_DataSet2)).BeginInit();
            this.listaempleadosToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
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
            this.log_date.TabIndex = 41;
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
            this.log_type.TabIndex = 40;
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
            this.log_id.TabIndex = 39;
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
            this.log_name.TabIndex = 38;
            this.log_name.Text = "label1";
            // 
            // text_buscar
            // 
            this.text_buscar.Location = new System.Drawing.Point(12, 172);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(443, 20);
            this.text_buscar.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(13, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 45;
            // 
            // dataGrid_clientes
            // 
            this.dataGrid_clientes.AllowUserToAddRows = false;
            this.dataGrid_clientes.AllowUserToDeleteRows = false;
            this.dataGrid_clientes.AllowUserToResizeRows = false;
            this.dataGrid_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_clientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Eliminar});
            this.dataGrid_clientes.Location = new System.Drawing.Point(12, 197);
            this.dataGrid_clientes.Name = "dataGrid_clientes";
            this.dataGrid_clientes.ReadOnly = true;
            this.dataGrid_clientes.RowHeadersVisible = false;
            this.dataGrid_clientes.Size = new System.Drawing.Size(658, 274);
            this.dataGrid_clientes.TabIndex = 46;
            this.dataGrid_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGrid_clientes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting_1);
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
            // FormStartRecepcionistaDataSet
            // 
            this.FormStartRecepcionistaDataSet.DataSetName = "FormRecepcionistaAdministradorInicio_DataSet";
            this.FormStartRecepcionistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Transparent;
            this.panel_top.Controls.Add(this.picture_tratamientos_admin);
            this.panel_top.Controls.Add(this.picture_empleados_admin);
            this.panel_top.Controls.Add(this.picture_ajustes_admin);
            this.panel_top.Controls.Add(this.picture_start_admin);
            this.panel_top.Controls.Add(this.picture_ajustes_recepcionista);
            this.panel_top.Controls.Add(this.picture_facturas_recepcionista);
            this.panel_top.Controls.Add(this.picture_clientes_recepcionista);
            this.panel_top.Controls.Add(this.picture_consultas_recepcionista);
            this.panel_top.Controls.Add(this.picture_start_recepcionista);
            this.panel_top.Location = new System.Drawing.Point(-2, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(690, 34);
            this.panel_top.TabIndex = 51;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            // 
            // picture_tratamientos_admin
            // 
            this.picture_tratamientos_admin.BackColor = System.Drawing.Color.Transparent;
            this.picture_tratamientos_admin.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.clientes;
            this.picture_tratamientos_admin.Location = new System.Drawing.Point(281, 0);
            this.picture_tratamientos_admin.Name = "picture_tratamientos_admin";
            this.picture_tratamientos_admin.Size = new System.Drawing.Size(128, 34);
            this.picture_tratamientos_admin.TabIndex = 8;
            this.picture_tratamientos_admin.TabStop = false;
            this.picture_tratamientos_admin.Click += new System.EventHandler(this.picture_tratamientos_admin_Click);
            // 
            // picture_empleados_admin
            // 
            this.picture_empleados_admin.BackColor = System.Drawing.Color.Transparent;
            this.picture_empleados_admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_empleados_admin.BackgroundImage")));
            this.picture_empleados_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_empleados_admin.Location = new System.Drawing.Point(140, 0);
            this.picture_empleados_admin.Name = "picture_empleados_admin";
            this.picture_empleados_admin.Size = new System.Drawing.Size(128, 34);
            this.picture_empleados_admin.TabIndex = 7;
            this.picture_empleados_admin.TabStop = false;
            this.picture_empleados_admin.Click += new System.EventHandler(this.picture_empleados_admin_Click);
            // 
            // picture_ajustes_admin
            // 
            this.picture_ajustes_admin.BackColor = System.Drawing.Color.Transparent;
            this.picture_ajustes_admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_ajustes_admin.BackgroundImage")));
            this.picture_ajustes_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_ajustes_admin.Location = new System.Drawing.Point(420, 0);
            this.picture_ajustes_admin.Name = "picture_ajustes_admin";
            this.picture_ajustes_admin.Size = new System.Drawing.Size(128, 34);
            this.picture_ajustes_admin.TabIndex = 6;
            this.picture_ajustes_admin.TabStop = false;
            this.picture_ajustes_admin.Click += new System.EventHandler(this.picture_ajustes_admin_Click);
            // 
            // picture_start_admin
            // 
            this.picture_start_admin.BackColor = System.Drawing.Color.Transparent;
            this.picture_start_admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_start_admin.BackgroundImage")));
            this.picture_start_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_start_admin.Location = new System.Drawing.Point(0, 0);
            this.picture_start_admin.Name = "picture_start_admin";
            this.picture_start_admin.Size = new System.Drawing.Size(128, 34);
            this.picture_start_admin.TabIndex = 5;
            this.picture_start_admin.TabStop = false;
            this.picture_start_admin.Click += new System.EventHandler(this.picture_start_admin_Click);
            // 
            // picture_ajustes_recepcionista
            // 
            this.picture_ajustes_recepcionista.BackColor = System.Drawing.Color.Transparent;
            this.picture_ajustes_recepcionista.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.ajustes;
            this.picture_ajustes_recepcionista.Location = new System.Drawing.Point(559, 0);
            this.picture_ajustes_recepcionista.Name = "picture_ajustes_recepcionista";
            this.picture_ajustes_recepcionista.Size = new System.Drawing.Size(128, 34);
            this.picture_ajustes_recepcionista.TabIndex = 4;
            this.picture_ajustes_recepcionista.TabStop = false;
            this.picture_ajustes_recepcionista.Click += new System.EventHandler(this.picture_ajustes_Click);
            // 
            // picture_facturas_recepcionista
            // 
            this.picture_facturas_recepcionista.BackColor = System.Drawing.Color.Transparent;
            this.picture_facturas_recepcionista.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.facturas;
            this.picture_facturas_recepcionista.Location = new System.Drawing.Point(420, 0);
            this.picture_facturas_recepcionista.Name = "picture_facturas_recepcionista";
            this.picture_facturas_recepcionista.Size = new System.Drawing.Size(128, 34);
            this.picture_facturas_recepcionista.TabIndex = 3;
            this.picture_facturas_recepcionista.TabStop = false;
            this.picture_facturas_recepcionista.Click += new System.EventHandler(this.picture_facturas_Click);
            // 
            // picture_clientes_recepcionista
            // 
            this.picture_clientes_recepcionista.BackColor = System.Drawing.Color.Transparent;
            this.picture_clientes_recepcionista.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.clientes;
            this.picture_clientes_recepcionista.Location = new System.Drawing.Point(281, 0);
            this.picture_clientes_recepcionista.Name = "picture_clientes_recepcionista";
            this.picture_clientes_recepcionista.Size = new System.Drawing.Size(128, 34);
            this.picture_clientes_recepcionista.TabIndex = 2;
            this.picture_clientes_recepcionista.TabStop = false;
            this.picture_clientes_recepcionista.Click += new System.EventHandler(this.picture_clientes_Click);
            // 
            // picture_consultas_recepcionista
            // 
            this.picture_consultas_recepcionista.BackColor = System.Drawing.Color.Transparent;
            this.picture_consultas_recepcionista.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.doctor;
            this.picture_consultas_recepcionista.Location = new System.Drawing.Point(140, 0);
            this.picture_consultas_recepcionista.Name = "picture_consultas_recepcionista";
            this.picture_consultas_recepcionista.Size = new System.Drawing.Size(128, 34);
            this.picture_consultas_recepcionista.TabIndex = 1;
            this.picture_consultas_recepcionista.TabStop = false;
            this.picture_consultas_recepcionista.Click += new System.EventHandler(this.picture_consultas_Click);
            // 
            // picture_start_recepcionista
            // 
            this.picture_start_recepcionista.BackColor = System.Drawing.Color.Transparent;
            this.picture_start_recepcionista.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.start;
            this.picture_start_recepcionista.Location = new System.Drawing.Point(0, 0);
            this.picture_start_recepcionista.Name = "picture_start_recepcionista";
            this.picture_start_recepcionista.Size = new System.Drawing.Size(128, 34);
            this.picture_start_recepcionista.TabIndex = 0;
            this.picture_start_recepcionista.TabStop = false;
            this.picture_start_recepcionista.Click += new System.EventHandler(this.picture_start_Click);
            // 
            // ListaEmpleados
            // 
            this.ListaEmpleados.AllowUserToAddRows = false;
            this.ListaEmpleados.AllowUserToDeleteRows = false;
            this.ListaEmpleados.AllowUserToResizeRows = false;
            this.ListaEmpleados.AutoGenerateColumns = false;
            this.ListaEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.ListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Tipo,
            this.ModificarEmpleado,
            this.EliminarEmpleado});
            this.ListaEmpleados.DataSource = this.bindingSource1;
            this.ListaEmpleados.Location = new System.Drawing.Point(12, 198);
            this.ListaEmpleados.Name = "ListaEmpleados";
            this.ListaEmpleados.ReadOnly = true;
            this.ListaEmpleados.RowHeadersVisible = false;
            this.ListaEmpleados.Size = new System.Drawing.Size(658, 273);
            this.ListaEmpleados.TabIndex = 52;
            this.ListaEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClick_empleados);
            this.ListaEmpleados.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.CellPainting_empleados);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DNI";
            this.dataGridViewTextBoxColumn1.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // ModificarEmpleado
            // 
            this.ModificarEmpleado.HeaderText = "Modificar";
            this.ModificarEmpleado.Name = "ModificarEmpleado";
            this.ModificarEmpleado.ReadOnly = true;
            // 
            // EliminarEmpleado
            // 
            this.EliminarEmpleado.HeaderText = "Eliminar";
            this.EliminarEmpleado.Name = "EliminarEmpleado";
            this.EliminarEmpleado.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Usuario";
            this.bindingSource1.DataSource = this.formRecepcionistaAdministradorInicio_DataSet2;
            // 
            // formRecepcionistaAdministradorInicio_DataSet2
            // 
            this.formRecepcionistaAdministradorInicio_DataSet2.DataSetName = "FormRecepcionistaAdministradorInicio_DataSet2";
            this.formRecepcionistaAdministradorInicio_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.FormRecepcionistaAdministradorInicio_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter1;
            // 
            // listaempleadosToolStrip
            // 
            this.listaempleadosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaempleadosToolStripButton});
            this.listaempleadosToolStrip.Location = new System.Drawing.Point(0, 0);
            this.listaempleadosToolStrip.Name = "listaempleadosToolStrip";
            this.listaempleadosToolStrip.Size = new System.Drawing.Size(708, 25);
            this.listaempleadosToolStrip.TabIndex = 53;
            this.listaempleadosToolStrip.Text = "listaempleadosToolStrip";
            this.listaempleadosToolStrip.Visible = false;
            // 
            // listaempleadosToolStripButton
            // 
            this.listaempleadosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.listaempleadosToolStripButton.Name = "listaempleadosToolStripButton";
            this.listaempleadosToolStripButton.Size = new System.Drawing.Size(90, 22);
            this.listaempleadosToolStripButton.Text = "listaempleados";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.add_1_icon;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(646, 167);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(24, 24);
            this.btn_add.TabIndex = 48;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.search_identifier;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(461, 172);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(16, 16);
            this.btn_buscar.TabIndex = 43;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // log_photo
            // 
            this.log_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_photo.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.log_photo.Location = new System.Drawing.Point(12, 44);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(90, 120);
            this.log_photo.TabIndex = 36;
            this.log_photo.TabStop = false;
            // 
            // usuarioTableAdapter2
            // 
            this.usuarioTableAdapter2.ClearBeforeFill = true;
            // 
            // FormRecepcionistaAdministradorInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fondo_nuevo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 471);
            this.Controls.Add(this.listaempleadosToolStrip);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.log_date);
            this.Controls.Add(this.log_type);
            this.Controls.Add(this.log_id);
            this.Controls.Add(this.log_name);
            this.Controls.Add(this.log_photo);
            this.Controls.Add(this.ListaEmpleados);
            this.Controls.Add(this.dataGrid_clientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRecepcionistaAdministradorInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormStartRecepcionistaDataSet)).EndInit();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_tratamientos_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_empleados_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes_recepcionista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas_recepcionista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes_recepcionista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas_recepcionista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start_recepcionista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRecepcionistaAdministradorInicio_DataSet2)).EndInit();
            this.listaempleadosToolStrip.ResumeLayout(false);
            this.listaempleadosToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
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
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGrid_clientes;
        public FormRecepcionistaAdministradorInicio_DataSet FormStartRecepcionistaDataSet;
        public System.Windows.Forms.BindingSource usuarioBindingSource;
        public FormRecepcionistaAdministradorInicio_DataSetTableAdapters.ClienteTableAdapter usuarioTableAdapter;
        public System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox picture_start_recepcionista;
        private System.Windows.Forms.PictureBox picture_ajustes_recepcionista;
        private System.Windows.Forms.PictureBox picture_facturas_recepcionista;
        private System.Windows.Forms.PictureBox picture_clientes_recepcionista;
        private System.Windows.Forms.PictureBox picture_consultas_recepcionista;
        public System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewButtonColumn Modificar;
        public System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        public System.Windows.Forms.DataGridView ListaEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn1;
        private FormRecepcionistaAdministradorInicio_DataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter1;
        private FormRecepcionistaAdministradorInicio_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip listaempleadosToolStrip;
        private System.Windows.Forms.ToolStripButton listaempleadosToolStripButton;
        private FormRecepcionistaAdministradorInicio_DataSet2 formRecepcionistaAdministradorInicio_DataSet2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private FormRecepcionistaAdministradorInicio_DataSet2TableAdapters.UsuarioTableAdapter usuarioTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewButtonColumn ModificarEmpleado;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarEmpleado;
        private System.Windows.Forms.PictureBox picture_tratamientos_admin;
        private System.Windows.Forms.PictureBox picture_empleados_admin;
        private System.Windows.Forms.PictureBox picture_ajustes_admin;
        private System.Windows.Forms.PictureBox picture_start_admin;
    }
}