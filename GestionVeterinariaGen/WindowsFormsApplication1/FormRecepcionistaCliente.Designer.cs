namespace WindowsFormsApplication1
{
    partial class FormRecepcionistaCliente
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_ajustes = new System.Windows.Forms.PictureBox();
            this.picture_facturas = new System.Windows.Forms.PictureBox();
            this.picture_clientes = new System.Windows.Forms.PictureBox();
            this.picture_consultas = new System.Windows.Forms.PictureBox();
            this.picture_start = new System.Windows.Forms.PictureBox();
            this.panel_clientes_opcion = new System.Windows.Forms.Panel();
            this.picture_cliente_opcion_mascota = new System.Windows.Forms.PictureBox();
            this.picture_cliente_opcion_cliente = new System.Windows.Forms.PictureBox();
            this.label_dni = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellidos = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_localidad = new System.Windows.Forms.Label();
            this.label_provincia = new System.Windows.Forms.Label();
            this.label_cp = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.text_telefono = new System.Windows.Forms.TextBox();
            this.text_direccion = new System.Windows.Forms.TextBox();
            this.text_localidad = new System.Windows.Forms.TextBox();
            this.text_provincia = new System.Windows.Forms.TextBox();
            this.text_cp = new System.Windows.Forms.TextBox();
            this.text_apellidos = new System.Windows.Forms.TextBox();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.text_dni = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formRecepcionistaCliente_DataSet = new WindowsFormsApplication1.FormRecepcionistaCliente_DataSet();
            this.text_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.formRecepcionistaClienteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotaTableAdapter = new WindowsFormsApplication1.FormRecepcionistaCliente_DataSetTableAdapters.MascotaTableAdapter();
            this.alerta_eliminar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar_no = new System.Windows.Forms.Button();
            this.btn_eliminar_si = new System.Windows.Forms.Button();
            this.btn_erase = new System.Windows.Forms.PictureBox();
            this.btn_buscar_dni = new System.Windows.Forms.PictureBox();
            this.btn_anaydir = new System.Windows.Forms.PictureBox();
            this.foto_cliente = new System.Windows.Forms.PictureBox();
            this.button_facturas = new System.Windows.Forms.Button();
            this.aa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).BeginInit();
            this.panel_clientes_opcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cliente_opcion_mascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cliente_opcion_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRecepcionistaCliente_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRecepcionistaClienteDataSetBindingSource)).BeginInit();
            this.alerta_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_erase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_dni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_anaydir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Transparent;
            this.panel_top.Controls.Add(this.panel1);
            this.panel_top.Controls.Add(this.picture_ajustes);
            this.panel_top.Controls.Add(this.picture_facturas);
            this.panel_top.Controls.Add(this.picture_clientes);
            this.panel_top.Controls.Add(this.picture_consultas);
            this.panel_top.Controls.Add(this.picture_start);
            this.panel_top.Location = new System.Drawing.Point(-4, -1);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(690, 34);
            this.panel_top.TabIndex = 52;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 100);
            this.panel1.TabIndex = 53;
            // 
            // picture_ajustes
            // 
            this.picture_ajustes.BackColor = System.Drawing.Color.Transparent;
            this.picture_ajustes.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.ajustes;
            this.picture_ajustes.Location = new System.Drawing.Point(561, 0);
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
            this.picture_facturas.Location = new System.Drawing.Point(421, 0);
            this.picture_facturas.Name = "picture_facturas";
            this.picture_facturas.Size = new System.Drawing.Size(128, 34);
            this.picture_facturas.TabIndex = 3;
            this.picture_facturas.TabStop = false;
            this.picture_facturas.Click += new System.EventHandler(this.picture_facturas_Click);
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
            this.picture_consultas.Location = new System.Drawing.Point(142, 0);
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
            this.picture_start.Location = new System.Drawing.Point(3, 0);
            this.picture_start.Name = "picture_start";
            this.picture_start.Size = new System.Drawing.Size(128, 34);
            this.picture_start.TabIndex = 0;
            this.picture_start.TabStop = false;
            this.picture_start.Click += new System.EventHandler(this.picture_start_Click);
            // 
            // panel_clientes_opcion
            // 
            this.panel_clientes_opcion.BackColor = System.Drawing.Color.Transparent;
            this.panel_clientes_opcion.Controls.Add(this.picture_cliente_opcion_mascota);
            this.panel_clientes_opcion.Controls.Add(this.picture_cliente_opcion_cliente);
            this.panel_clientes_opcion.Location = new System.Drawing.Point(0, 32);
            this.panel_clientes_opcion.Name = "panel_clientes_opcion";
            this.panel_clientes_opcion.Size = new System.Drawing.Size(690, 32);
            this.panel_clientes_opcion.TabIndex = 53;
            this.panel_clientes_opcion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_clientes_opcion_Paint);
            // 
            // picture_cliente_opcion_mascota
            // 
            this.picture_cliente_opcion_mascota.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cliente_PerfilMascota;
            this.picture_cliente_opcion_mascota.Location = new System.Drawing.Point(343, 0);
            this.picture_cliente_opcion_mascota.Name = "picture_cliente_opcion_mascota";
            this.picture_cliente_opcion_mascota.Size = new System.Drawing.Size(345, 32);
            this.picture_cliente_opcion_mascota.TabIndex = 54;
            this.picture_cliente_opcion_mascota.TabStop = false;
            this.picture_cliente_opcion_mascota.Click += new System.EventHandler(this.picture_cliente_opcion_mascota_Click);
            // 
            // picture_cliente_opcion_cliente
            // 
            this.picture_cliente_opcion_cliente.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cliente_PerfilCliente;
            this.picture_cliente_opcion_cliente.Location = new System.Drawing.Point(0, 0);
            this.picture_cliente_opcion_cliente.Name = "picture_cliente_opcion_cliente";
            this.picture_cliente_opcion_cliente.Size = new System.Drawing.Size(345, 32);
            this.picture_cliente_opcion_cliente.TabIndex = 0;
            this.picture_cliente_opcion_cliente.TabStop = false;
            this.picture_cliente_opcion_cliente.Click += new System.EventHandler(this.picture_cliente_opcion_cliente_Click);
            // 
            // label_dni
            // 
            this.label_dni.AutoSize = true;
            this.label_dni.BackColor = System.Drawing.Color.Transparent;
            this.label_dni.Location = new System.Drawing.Point(135, 88);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(26, 13);
            this.label_dni.TabIndex = 55;
            this.label_dni.Text = "DNI";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.BackColor = System.Drawing.Color.Transparent;
            this.label_nombre.Location = new System.Drawing.Point(135, 112);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 56;
            this.label_nombre.Text = "Nombre";
            // 
            // label_apellidos
            // 
            this.label_apellidos.AutoSize = true;
            this.label_apellidos.BackColor = System.Drawing.Color.Transparent;
            this.label_apellidos.Location = new System.Drawing.Point(135, 139);
            this.label_apellidos.Name = "label_apellidos";
            this.label_apellidos.Size = new System.Drawing.Size(49, 13);
            this.label_apellidos.TabIndex = 57;
            this.label_apellidos.Text = "Apellidos";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.BackColor = System.Drawing.Color.Transparent;
            this.label_direccion.Location = new System.Drawing.Point(11, 204);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(52, 13);
            this.label_direccion.TabIndex = 58;
            this.label_direccion.Text = "Direccion";
            // 
            // label_localidad
            // 
            this.label_localidad.AutoSize = true;
            this.label_localidad.BackColor = System.Drawing.Color.Transparent;
            this.label_localidad.Location = new System.Drawing.Point(235, 204);
            this.label_localidad.Name = "label_localidad";
            this.label_localidad.Size = new System.Drawing.Size(53, 13);
            this.label_localidad.TabIndex = 59;
            this.label_localidad.Text = "Localidad";
            // 
            // label_provincia
            // 
            this.label_provincia.AutoSize = true;
            this.label_provincia.BackColor = System.Drawing.Color.Transparent;
            this.label_provincia.Location = new System.Drawing.Point(407, 200);
            this.label_provincia.Name = "label_provincia";
            this.label_provincia.Size = new System.Drawing.Size(51, 13);
            this.label_provincia.TabIndex = 60;
            this.label_provincia.Text = "Provincia";
            // 
            // label_cp
            // 
            this.label_cp.AutoSize = true;
            this.label_cp.BackColor = System.Drawing.Color.Transparent;
            this.label_cp.Location = new System.Drawing.Point(571, 200);
            this.label_cp.Name = "label_cp";
            this.label_cp.Size = new System.Drawing.Size(21, 13);
            this.label_cp.TabIndex = 61;
            this.label_cp.Text = "CP";
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.BackColor = System.Drawing.Color.Transparent;
            this.label_telefono.Location = new System.Drawing.Point(135, 164);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(49, 13);
            this.label_telefono.TabIndex = 62;
            this.label_telefono.Text = "Telefono";
            // 
            // text_telefono
            // 
            this.text_telefono.Location = new System.Drawing.Point(199, 157);
            this.text_telefono.Name = "text_telefono";
            this.text_telefono.Size = new System.Drawing.Size(134, 20);
            this.text_telefono.TabIndex = 64;
            // 
            // text_direccion
            // 
            this.text_direccion.Location = new System.Drawing.Point(63, 197);
            this.text_direccion.Name = "text_direccion";
            this.text_direccion.Size = new System.Drawing.Size(158, 20);
            this.text_direccion.TabIndex = 65;
            // 
            // text_localidad
            // 
            this.text_localidad.Location = new System.Drawing.Point(290, 197);
            this.text_localidad.Name = "text_localidad";
            this.text_localidad.Size = new System.Drawing.Size(100, 20);
            this.text_localidad.TabIndex = 66;
            // 
            // text_provincia
            // 
            this.text_provincia.Location = new System.Drawing.Point(459, 197);
            this.text_provincia.Name = "text_provincia";
            this.text_provincia.Size = new System.Drawing.Size(100, 20);
            this.text_provincia.TabIndex = 67;
            // 
            // text_cp
            // 
            this.text_cp.Location = new System.Drawing.Point(596, 197);
            this.text_cp.Name = "text_cp";
            this.text_cp.Size = new System.Drawing.Size(73, 20);
            this.text_cp.TabIndex = 68;
            // 
            // text_apellidos
            // 
            this.text_apellidos.Location = new System.Drawing.Point(199, 132);
            this.text_apellidos.Name = "text_apellidos";
            this.text_apellidos.Size = new System.Drawing.Size(134, 20);
            this.text_apellidos.TabIndex = 69;
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(199, 108);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(134, 20);
            this.text_nombre.TabIndex = 70;
            // 
            // text_dni
            // 
            this.text_dni.Location = new System.Drawing.Point(199, 85);
            this.text_dni.Name = "text_dni";
            this.text_dni.Size = new System.Drawing.Size(134, 20);
            this.text_dni.TabIndex = 71;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aa,
            this.Nombre,
            this.Especie,
            this.Raza,
            this.Cliente,
            this.Ver});
            this.dataGridView.DataSource = this.mascotaBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(15, 274);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(655, 197);
            this.dataGridView.TabIndex = 72;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            // 
            // mascotaBindingSource
            // 
            this.mascotaBindingSource.DataMember = "Mascota";
            this.mascotaBindingSource.DataSource = this.formRecepcionistaCliente_DataSet;
            // 
            // formRecepcionistaCliente_DataSet
            // 
            this.formRecepcionistaCliente_DataSet.DataSetName = "FormRecepcionistaCliente_DataSet";
            this.formRecepcionistaCliente_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // text_buscar
            // 
            this.text_buscar.Location = new System.Drawing.Point(15, 243);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(375, 20);
            this.text_buscar.TabIndex = 73;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.btn_buscar_id;
            this.btn_buscar.Location = new System.Drawing.Point(396, 247);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(16, 16);
            this.btn_buscar.TabIndex = 74;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(594, 125);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 76;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(594, 154);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 77;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // formRecepcionistaClienteDataSetBindingSource
            // 
            this.formRecepcionistaClienteDataSetBindingSource.DataSource = this.formRecepcionistaCliente_DataSet;
            this.formRecepcionistaClienteDataSetBindingSource.Position = 0;
            // 
            // mascotaTableAdapter
            // 
            this.mascotaTableAdapter.ClearBeforeFill = true;
            // 
            // alerta_eliminar
            // 
            this.alerta_eliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alerta_eliminar.Controls.Add(this.label1);
            this.alerta_eliminar.Controls.Add(this.btn_eliminar_no);
            this.alerta_eliminar.Controls.Add(this.btn_eliminar_si);
            this.alerta_eliminar.Location = new System.Drawing.Point(383, 108);
            this.alerta_eliminar.Name = "alerta_eliminar";
            this.alerta_eliminar.Size = new System.Drawing.Size(200, 67);
            this.alerta_eliminar.TabIndex = 78;
            this.alerta_eliminar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Eliminar Cliente?";
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
            // btn_erase
            // 
            this.btn_erase.BackColor = System.Drawing.Color.Transparent;
            this.btn_erase.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.eraser;
            this.btn_erase.Location = new System.Drawing.Point(418, 247);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(16, 16);
            this.btn_erase.TabIndex = 80;
            this.btn_erase.TabStop = false;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // btn_buscar_dni
            // 
            this.btn_buscar_dni.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar_dni.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.btn_buscar_id;
            this.btn_buscar_dni.Location = new System.Drawing.Point(339, 85);
            this.btn_buscar_dni.Name = "btn_buscar_dni";
            this.btn_buscar_dni.Size = new System.Drawing.Size(16, 16);
            this.btn_buscar_dni.TabIndex = 79;
            this.btn_buscar_dni.TabStop = false;
            this.btn_buscar_dni.Click += new System.EventHandler(this.btn_buscar_dni_Click);
            // 
            // btn_anaydir
            // 
            this.btn_anaydir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_anaydir.BackColor = System.Drawing.Color.Transparent;
            this.btn_anaydir.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.add;
            this.btn_anaydir.Location = new System.Drawing.Point(653, 252);
            this.btn_anaydir.Name = "btn_anaydir";
            this.btn_anaydir.Size = new System.Drawing.Size(16, 16);
            this.btn_anaydir.TabIndex = 75;
            this.btn_anaydir.TabStop = false;
            this.btn_anaydir.Click += new System.EventHandler(this.btn_anaydir_Click);
            // 
            // foto_cliente
            // 
            this.foto_cliente.BackColor = System.Drawing.Color.Transparent;
            this.foto_cliente.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.foto_cliente.Location = new System.Drawing.Point(12, 82);
            this.foto_cliente.Name = "foto_cliente";
            this.foto_cliente.Size = new System.Drawing.Size(100, 104);
            this.foto_cliente.TabIndex = 54;
            this.foto_cliente.TabStop = false;
            // 
            // button_facturas
            // 
            this.button_facturas.Location = new System.Drawing.Point(594, 88);
            this.button_facturas.Name = "button_facturas";
            this.button_facturas.Size = new System.Drawing.Size(75, 23);
            this.button_facturas.TabIndex = 81;
            this.button_facturas.Text = "Facturas";
            this.button_facturas.UseVisualStyleBackColor = true;
            this.button_facturas.Click += new System.EventHandler(this.button_facturas_Click);
            // 
            // aa
            // 
            this.aa.DataPropertyName = "ID";
            this.aa.HeaderText = "Id";
            this.aa.Name = "aa";
            this.aa.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Especie
            // 
            this.Especie.DataPropertyName = "especie";
            this.Especie.HeaderText = "Especie";
            this.Especie.Name = "Especie";
            this.Especie.ReadOnly = true;
            // 
            // Raza
            // 
            this.Raza.DataPropertyName = "raza";
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "FK_DNI_idCliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            // 
            // FormRecepcionistaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.button_facturas);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.btn_buscar_dni);
            this.Controls.Add(this.alerta_eliminar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_anaydir);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.text_dni);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.text_apellidos);
            this.Controls.Add(this.text_cp);
            this.Controls.Add(this.text_provincia);
            this.Controls.Add(this.text_localidad);
            this.Controls.Add(this.text_direccion);
            this.Controls.Add(this.text_telefono);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.label_cp);
            this.Controls.Add(this.label_provincia);
            this.Controls.Add(this.label_localidad);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.label_apellidos);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_dni);
            this.Controls.Add(this.foto_cliente);
            this.Controls.Add(this.panel_clientes_opcion);
            this.Controls.Add(this.panel_top);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRecepcionistaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Perfil";
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).EndInit();
            this.panel_clientes_opcion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_cliente_opcion_mascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cliente_opcion_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRecepcionistaCliente_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRecepcionistaClienteDataSetBindingSource)).EndInit();
            this.alerta_eliminar.ResumeLayout(false);
            this.alerta_eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_erase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_dni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_anaydir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel_top;
        public System.Windows.Forms.PictureBox picture_ajustes;
        public System.Windows.Forms.PictureBox picture_facturas;
        public System.Windows.Forms.PictureBox picture_clientes;
        public System.Windows.Forms.PictureBox picture_consultas;
        public System.Windows.Forms.PictureBox picture_start;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel_clientes_opcion;
        public System.Windows.Forms.PictureBox picture_cliente_opcion_mascota;
        public System.Windows.Forms.PictureBox picture_cliente_opcion_cliente;
        public System.Windows.Forms.PictureBox foto_cliente;
        public System.Windows.Forms.Label label_dni;
        public System.Windows.Forms.Label label_nombre;
        public System.Windows.Forms.Label label_apellidos;
        public System.Windows.Forms.Label label_direccion;
        public System.Windows.Forms.Label label_localidad;
        public System.Windows.Forms.Label label_provincia;
        public System.Windows.Forms.Label label_cp;
        public System.Windows.Forms.Label label_telefono;
        public System.Windows.Forms.TextBox text_telefono;
        public System.Windows.Forms.TextBox text_direccion;
        public System.Windows.Forms.TextBox text_localidad;
        public System.Windows.Forms.TextBox text_provincia;
        public System.Windows.Forms.TextBox text_cp;
        public System.Windows.Forms.TextBox text_apellidos;
        public System.Windows.Forms.TextBox text_nombre;
        public System.Windows.Forms.TextBox text_dni;
        public System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.TextBox text_buscar;
        public System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.PictureBox btn_anaydir;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.BindingSource formRecepcionistaClienteDataSetBindingSource;
        private FormRecepcionistaCliente_DataSet formRecepcionistaCliente_DataSet;
        private System.Windows.Forms.BindingSource mascotaBindingSource;
        private FormRecepcionistaCliente_DataSetTableAdapters.MascotaTableAdapter mascotaTableAdapter;
        public System.Windows.Forms.Panel alerta_eliminar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_eliminar_no;
        public System.Windows.Forms.Button btn_eliminar_si;
        public System.Windows.Forms.PictureBox btn_buscar_dni;
        public System.Windows.Forms.PictureBox btn_erase;
        private System.Windows.Forms.Button button_facturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn aa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
    }
}