namespace WindowsFormsApplication1
{
    partial class FormRecepcionistaMascota
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.picture_ajustes = new System.Windows.Forms.PictureBox();
            this.picture_facturas = new System.Windows.Forms.PictureBox();
            this.picture_clientes = new System.Windows.Forms.PictureBox();
            this.picture_consultas = new System.Windows.Forms.PictureBox();
            this.picture_start = new System.Windows.Forms.PictureBox();
            this.panel_clientes_opcion = new System.Windows.Forms.Panel();
            this.picture_cliente_opcion_mascota = new System.Windows.Forms.PictureBox();
            this.picture_cliente_opcion_cliente = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewImageColumn();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formRecepcionistaMascota_DataSet = new WindowsFormsApplication1.FormRecepcionistaMascota_DataSet();
            this.label_cliente = new System.Windows.Forms.Label();
            this.text_cliente = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_especie = new System.Windows.Forms.Label();
            this.label_raza = new System.Windows.Forms.Label();
            this.label_fechanac = new System.Windows.Forms.Label();
            this.text_raza = new System.Windows.Forms.TextBox();
            this.dateTime_fnac = new System.Windows.Forms.DateTimePicker();
            this.label_sexo = new System.Windows.Forms.Label();
            this.label_color = new System.Windows.Forms.Label();
            this.label_peso = new System.Windows.Forms.Label();
            this.label_tamayo = new System.Windows.Forms.Label();
            this.text_color = new System.Windows.Forms.TextBox();
            this.text_peso = new System.Windows.Forms.TextBox();
            this.combo_tamanyo = new System.Windows.Forms.ComboBox();
            this.combo_sexo = new System.Windows.Forms.ComboBox();
            this.label_microchip = new System.Windows.Forms.Label();
            this.combo_microchip = new System.Windows.Forms.ComboBox();
            this.picture_foto = new System.Windows.Forms.PictureBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_anaydir = new System.Windows.Forms.PictureBox();
            this.btn_buscar_cliente = new System.Windows.Forms.PictureBox();
            this.text_especie = new System.Windows.Forms.TextBox();
            this.btn_erase = new System.Windows.Forms.PictureBox();
            this.alerta_eliminar = new System.Windows.Forms.Panel();
            this.label_eliminar_box = new System.Windows.Forms.Label();
            this.btn_eliminar_no = new System.Windows.Forms.Button();
            this.btn_eliminar_si = new System.Windows.Forms.Button();
            this.consultaTableAdapter = new WindowsFormsApplication1.FormRecepcionistaMascota_DataSetTableAdapters.ConsultaTableAdapter();
            this.combo_nombreAnimal = new System.Windows.Forms.ComboBox();
            this.box_NombreAnimal = new System.Windows.Forms.Panel();
            this.box_text_nombre_mascota = new System.Windows.Forms.TextBox();
            this.box_label_nombre_mascota = new System.Windows.Forms.Label();
            this.box_label_aceptar = new System.Windows.Forms.Label();
            this.box_label_cancelar = new System.Windows.Forms.Label();
            this.btn_add_NombreMascota = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRecepcionistaMascota_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_anaydir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_erase)).BeginInit();
            this.alerta_eliminar.SuspendLayout();
            this.box_NombreAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_NombreMascota)).BeginInit();
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
            this.panel_top.Location = new System.Drawing.Point(-2, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(690, 34);
            this.panel_top.TabIndex = 52;
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
            this.picture_facturas.Click += new System.EventHandler(this.picture_facturas_Click);
            // 
            // picture_clientes
            // 
            this.picture_clientes.BackColor = System.Drawing.Color.Transparent;
            this.picture_clientes.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.clientes;
            this.picture_clientes.Location = new System.Drawing.Point(280, 0);
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
            // panel_clientes_opcion
            // 
            this.panel_clientes_opcion.BackColor = System.Drawing.Color.Transparent;
            this.panel_clientes_opcion.Controls.Add(this.picture_cliente_opcion_mascota);
            this.panel_clientes_opcion.Controls.Add(this.picture_cliente_opcion_cliente);
            this.panel_clientes_opcion.Location = new System.Drawing.Point(-2, 34);
            this.panel_clientes_opcion.Name = "panel_clientes_opcion";
            this.panel_clientes_opcion.Size = new System.Drawing.Size(687, 32);
            this.panel_clientes_opcion.TabIndex = 54;
            this.panel_clientes_opcion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_clientes_opcion_Paint);
            // 
            // picture_cliente_opcion_mascota
            // 
            this.picture_cliente_opcion_mascota.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cliente_PerfilMascota;
            this.picture_cliente_opcion_mascota.Location = new System.Drawing.Point(342, 0);
            this.picture_cliente_opcion_mascota.Name = "picture_cliente_opcion_mascota";
            this.picture_cliente_opcion_mascota.Size = new System.Drawing.Size(345, 32);
            this.picture_cliente_opcion_mascota.TabIndex = 54;
            this.picture_cliente_opcion_mascota.TabStop = false;
            this.picture_cliente_opcion_mascota.Click += new System.EventHandler(this.picture_cliente_opcion_mascota_Click);
            // 
            // picture_cliente_opcion_cliente
            // 
            this.picture_cliente_opcion_cliente.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cliente_PerfilCliente;
            this.picture_cliente_opcion_cliente.Location = new System.Drawing.Point(3, 0);
            this.picture_cliente_opcion_cliente.Name = "picture_cliente_opcion_cliente";
            this.picture_cliente_opcion_cliente.Size = new System.Drawing.Size(345, 32);
            this.picture_cliente_opcion_cliente.TabIndex = 0;
            this.picture_cliente_opcion_cliente.TabStop = false;
            this.picture_cliente_opcion_cliente.Click += new System.EventHandler(this.picture_cliente_opcion_cliente_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Motivo,
            this.Lugar,
            this.Veterinario,
            this.Ver});
            this.dataGridView.DataSource = this.consultaBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 262);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(658, 209);
            this.dataGridView.TabIndex = 55;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "motivoConsulta";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            // 
            // Lugar
            // 
            this.Lugar.DataPropertyName = "lugar";
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            this.Lugar.ReadOnly = true;
            // 
            // Veterinario
            // 
            this.Veterinario.DataPropertyName = "FK_DNI_idVeterinario";
            this.Veterinario.HeaderText = "Veterinario";
            this.Veterinario.Name = "Veterinario";
            this.Veterinario.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataMember = "Consulta";
            this.consultaBindingSource.DataSource = this.formRecepcionistaMascota_DataSet;
            // 
            // formRecepcionistaMascota_DataSet
            // 
            this.formRecepcionistaMascota_DataSet.DataSetName = "FormRecepcionistaMascota_DataSet";
            this.formRecepcionistaMascota_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.BackColor = System.Drawing.Color.Transparent;
            this.label_cliente.Location = new System.Drawing.Point(119, 81);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(39, 13);
            this.label_cliente.TabIndex = 56;
            this.label_cliente.Text = "Cliente";
            // 
            // text_cliente
            // 
            this.text_cliente.Location = new System.Drawing.Point(203, 78);
            this.text_cliente.Name = "text_cliente";
            this.text_cliente.Size = new System.Drawing.Size(118, 20);
            this.text_cliente.TabIndex = 57;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.BackColor = System.Drawing.Color.Transparent;
            this.label_nombre.Location = new System.Drawing.Point(119, 117);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 58;
            this.label_nombre.Text = "Nombre";
            // 
            // label_especie
            // 
            this.label_especie.AutoSize = true;
            this.label_especie.BackColor = System.Drawing.Color.Transparent;
            this.label_especie.Location = new System.Drawing.Point(119, 147);
            this.label_especie.Name = "label_especie";
            this.label_especie.Size = new System.Drawing.Size(45, 13);
            this.label_especie.TabIndex = 60;
            this.label_especie.Text = "Especie";
            // 
            // label_raza
            // 
            this.label_raza.AutoSize = true;
            this.label_raza.BackColor = System.Drawing.Color.Transparent;
            this.label_raza.Location = new System.Drawing.Point(119, 182);
            this.label_raza.Name = "label_raza";
            this.label_raza.Size = new System.Drawing.Size(32, 13);
            this.label_raza.TabIndex = 61;
            this.label_raza.Text = "Raza";
            // 
            // label_fechanac
            // 
            this.label_fechanac.AutoSize = true;
            this.label_fechanac.BackColor = System.Drawing.Color.Transparent;
            this.label_fechanac.Location = new System.Drawing.Point(12, 220);
            this.label_fechanac.Name = "label_fechanac";
            this.label_fechanac.Size = new System.Drawing.Size(69, 13);
            this.label_fechanac.TabIndex = 62;
            this.label_fechanac.Text = "F.Nacimiento";
            // 
            // text_raza
            // 
            this.text_raza.Location = new System.Drawing.Point(203, 176);
            this.text_raza.Name = "text_raza";
            this.text_raza.Size = new System.Drawing.Size(118, 20);
            this.text_raza.TabIndex = 63;
            // 
            // dateTime_fnac
            // 
            this.dateTime_fnac.Location = new System.Drawing.Point(87, 217);
            this.dateTime_fnac.Name = "dateTime_fnac";
            this.dateTime_fnac.Size = new System.Drawing.Size(118, 20);
            this.dateTime_fnac.TabIndex = 64;
            // 
            // label_sexo
            // 
            this.label_sexo.AutoSize = true;
            this.label_sexo.BackColor = System.Drawing.Color.Transparent;
            this.label_sexo.Location = new System.Drawing.Point(221, 220);
            this.label_sexo.Name = "label_sexo";
            this.label_sexo.Size = new System.Drawing.Size(31, 13);
            this.label_sexo.TabIndex = 66;
            this.label_sexo.Text = "Sexo";
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.BackColor = System.Drawing.Color.Transparent;
            this.label_color.Location = new System.Drawing.Point(337, 219);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(31, 13);
            this.label_color.TabIndex = 67;
            this.label_color.Text = "Color";
            // 
            // label_peso
            // 
            this.label_peso.AutoSize = true;
            this.label_peso.BackColor = System.Drawing.Color.Transparent;
            this.label_peso.Location = new System.Drawing.Point(337, 179);
            this.label_peso.Name = "label_peso";
            this.label_peso.Size = new System.Drawing.Size(31, 13);
            this.label_peso.TabIndex = 68;
            this.label_peso.Text = "Peso";
            // 
            // label_tamayo
            // 
            this.label_tamayo.AutoSize = true;
            this.label_tamayo.BackColor = System.Drawing.Color.Transparent;
            this.label_tamayo.Location = new System.Drawing.Point(337, 144);
            this.label_tamayo.Name = "label_tamayo";
            this.label_tamayo.Size = new System.Drawing.Size(46, 13);
            this.label_tamayo.TabIndex = 69;
            this.label_tamayo.Text = "Tamaño";
            // 
            // text_color
            // 
            this.text_color.Location = new System.Drawing.Point(399, 215);
            this.text_color.Name = "text_color";
            this.text_color.Size = new System.Drawing.Size(68, 20);
            this.text_color.TabIndex = 70;
            // 
            // text_peso
            // 
            this.text_peso.Location = new System.Drawing.Point(399, 176);
            this.text_peso.Name = "text_peso";
            this.text_peso.Size = new System.Drawing.Size(68, 20);
            this.text_peso.TabIndex = 71;
            // 
            // combo_tamanyo
            // 
            this.combo_tamanyo.FormattingEnabled = true;
            this.combo_tamanyo.Location = new System.Drawing.Point(399, 142);
            this.combo_tamanyo.Name = "combo_tamanyo";
            this.combo_tamanyo.Size = new System.Drawing.Size(68, 21);
            this.combo_tamanyo.TabIndex = 72;
            // 
            // combo_sexo
            // 
            this.combo_sexo.FormattingEnabled = true;
            this.combo_sexo.Location = new System.Drawing.Point(258, 216);
            this.combo_sexo.Name = "combo_sexo";
            this.combo_sexo.Size = new System.Drawing.Size(63, 21);
            this.combo_sexo.TabIndex = 73;
            // 
            // label_microchip
            // 
            this.label_microchip.AutoSize = true;
            this.label_microchip.BackColor = System.Drawing.Color.Transparent;
            this.label_microchip.Location = new System.Drawing.Point(493, 219);
            this.label_microchip.Name = "label_microchip";
            this.label_microchip.Size = new System.Drawing.Size(53, 13);
            this.label_microchip.TabIndex = 74;
            this.label_microchip.Text = "Microchip";
            // 
            // combo_microchip
            // 
            this.combo_microchip.FormattingEnabled = true;
            this.combo_microchip.Location = new System.Drawing.Point(557, 217);
            this.combo_microchip.Name = "combo_microchip";
            this.combo_microchip.Size = new System.Drawing.Size(49, 21);
            this.combo_microchip.TabIndex = 75;
            // 
            // picture_foto
            // 
            this.picture_foto.BackColor = System.Drawing.Color.Transparent;
            this.picture_foto.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.sinFotoa;
            this.picture_foto.Location = new System.Drawing.Point(12, 81);
            this.picture_foto.Name = "picture_foto";
            this.picture_foto.Size = new System.Drawing.Size(101, 124);
            this.picture_foto.TabIndex = 76;
            this.picture_foto.TabStop = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(595, 144);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 79;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(595, 109);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 78;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_anaydir
            // 
            this.btn_anaydir.BackColor = System.Drawing.Color.Transparent;
            this.btn_anaydir.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.add;
            this.btn_anaydir.Location = new System.Drawing.Point(654, 240);
            this.btn_anaydir.Name = "btn_anaydir";
            this.btn_anaydir.Size = new System.Drawing.Size(16, 16);
            this.btn_anaydir.TabIndex = 80;
            this.btn_anaydir.TabStop = false;
            this.btn_anaydir.Click += new System.EventHandler(this.btn_anaydir_Click);
            // 
            // btn_buscar_cliente
            // 
            this.btn_buscar_cliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar_cliente.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.btn_buscar_id;
            this.btn_buscar_cliente.Location = new System.Drawing.Point(327, 78);
            this.btn_buscar_cliente.Name = "btn_buscar_cliente";
            this.btn_buscar_cliente.Size = new System.Drawing.Size(16, 16);
            this.btn_buscar_cliente.TabIndex = 81;
            this.btn_buscar_cliente.TabStop = false;
            this.btn_buscar_cliente.Click += new System.EventHandler(this.btn_buscar_cliente_Click);
            // 
            // text_especie
            // 
            this.text_especie.Location = new System.Drawing.Point(203, 142);
            this.text_especie.Name = "text_especie";
            this.text_especie.Size = new System.Drawing.Size(118, 20);
            this.text_especie.TabIndex = 82;
            // 
            // btn_erase
            // 
            this.btn_erase.BackColor = System.Drawing.Color.Transparent;
            this.btn_erase.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.eraser;
            this.btn_erase.Location = new System.Drawing.Point(357, 78);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(16, 16);
            this.btn_erase.TabIndex = 84;
            this.btn_erase.TabStop = false;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // alerta_eliminar
            // 
            this.alerta_eliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alerta_eliminar.Controls.Add(this.label_eliminar_box);
            this.alerta_eliminar.Controls.Add(this.btn_eliminar_no);
            this.alerta_eliminar.Controls.Add(this.btn_eliminar_si);
            this.alerta_eliminar.Location = new System.Drawing.Point(389, 69);
            this.alerta_eliminar.Name = "alerta_eliminar";
            this.alerta_eliminar.Size = new System.Drawing.Size(200, 67);
            this.alerta_eliminar.TabIndex = 83;
            this.alerta_eliminar.Visible = false;
            // 
            // label_eliminar_box
            // 
            this.label_eliminar_box.AutoSize = true;
            this.label_eliminar_box.Location = new System.Drawing.Point(3, 16);
            this.label_eliminar_box.Name = "label_eliminar_box";
            this.label_eliminar_box.Size = new System.Drawing.Size(89, 13);
            this.label_eliminar_box.TabIndex = 2;
            this.label_eliminar_box.Text = "¿Eliminar Animal?";
            this.label_eliminar_box.Visible = false;
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
            // consultaTableAdapter
            // 
            this.consultaTableAdapter.ClearBeforeFill = true;
            // 
            // combo_nombreAnimal
            // 
            this.combo_nombreAnimal.FormattingEnabled = true;
            this.combo_nombreAnimal.Location = new System.Drawing.Point(203, 110);
            this.combo_nombreAnimal.Name = "combo_nombreAnimal";
            this.combo_nombreAnimal.Size = new System.Drawing.Size(121, 21);
            this.combo_nombreAnimal.TabIndex = 85;
            this.combo_nombreAnimal.SelectedIndexChanged += new System.EventHandler(this.combo_nombreAnimal_SelectedIndexChanged);
            // 
            // box_NombreAnimal
            // 
            this.box_NombreAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_NombreAnimal.Controls.Add(this.box_label_cancelar);
            this.box_NombreAnimal.Controls.Add(this.box_label_aceptar);
            this.box_NombreAnimal.Controls.Add(this.box_label_nombre_mascota);
            this.box_NombreAnimal.Controls.Add(this.box_text_nombre_mascota);
            this.box_NombreAnimal.Location = new System.Drawing.Point(224, 109);
            this.box_NombreAnimal.Name = "box_NombreAnimal";
            this.box_NombreAnimal.Size = new System.Drawing.Size(232, 78);
            this.box_NombreAnimal.TabIndex = 86;
            this.box_NombreAnimal.Visible = false;
            // 
            // box_text_nombre_mascota
            // 
            this.box_text_nombre_mascota.Location = new System.Drawing.Point(13, 27);
            this.box_text_nombre_mascota.Name = "box_text_nombre_mascota";
            this.box_text_nombre_mascota.Size = new System.Drawing.Size(204, 20);
            this.box_text_nombre_mascota.TabIndex = 0;
            // 
            // box_label_nombre_mascota
            // 
            this.box_label_nombre_mascota.AutoSize = true;
            this.box_label_nombre_mascota.BackColor = System.Drawing.Color.Transparent;
            this.box_label_nombre_mascota.Location = new System.Drawing.Point(13, 8);
            this.box_label_nombre_mascota.Name = "box_label_nombre_mascota";
            this.box_label_nombre_mascota.Size = new System.Drawing.Size(176, 13);
            this.box_label_nombre_mascota.TabIndex = 1;
            this.box_label_nombre_mascota.Text = "Introduce un nombre para el animal:";
            // 
            // box_label_aceptar
            // 
            this.box_label_aceptar.AutoSize = true;
            this.box_label_aceptar.BackColor = System.Drawing.Color.Transparent;
            this.box_label_aceptar.Location = new System.Drawing.Point(173, 57);
            this.box_label_aceptar.Name = "box_label_aceptar";
            this.box_label_aceptar.Size = new System.Drawing.Size(44, 13);
            this.box_label_aceptar.TabIndex = 2;
            this.box_label_aceptar.Text = "Aceptar";
            this.box_label_aceptar.Click += new System.EventHandler(this.box_label_aceptar_Click);
            // 
            // box_label_cancelar
            // 
            this.box_label_cancelar.AutoSize = true;
            this.box_label_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.box_label_cancelar.Location = new System.Drawing.Point(10, 57);
            this.box_label_cancelar.Name = "box_label_cancelar";
            this.box_label_cancelar.Size = new System.Drawing.Size(49, 13);
            this.box_label_cancelar.TabIndex = 3;
            this.box_label_cancelar.Text = "Cancelar";
            this.box_label_cancelar.Click += new System.EventHandler(this.box_label_cancelar_Click);
            // 
            // btn_add_NombreMascota
            // 
            this.btn_add_NombreMascota.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_NombreMascota.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.add;
            this.btn_add_NombreMascota.Location = new System.Drawing.Point(327, 112);
            this.btn_add_NombreMascota.Name = "btn_add_NombreMascota";
            this.btn_add_NombreMascota.Size = new System.Drawing.Size(16, 16);
            this.btn_add_NombreMascota.TabIndex = 87;
            this.btn_add_NombreMascota.TabStop = false;
            this.btn_add_NombreMascota.Click += new System.EventHandler(this.btn_add_NombreMascota_Click);
            // 
            // FormRecepcionistaMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.btn_add_NombreMascota);
            this.Controls.Add(this.box_NombreAnimal);
            this.Controls.Add(this.combo_nombreAnimal);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.alerta_eliminar);
            this.Controls.Add(this.text_especie);
            this.Controls.Add(this.btn_buscar_cliente);
            this.Controls.Add(this.btn_anaydir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.picture_foto);
            this.Controls.Add(this.combo_microchip);
            this.Controls.Add(this.label_microchip);
            this.Controls.Add(this.combo_sexo);
            this.Controls.Add(this.combo_tamanyo);
            this.Controls.Add(this.text_peso);
            this.Controls.Add(this.text_color);
            this.Controls.Add(this.label_tamayo);
            this.Controls.Add(this.label_peso);
            this.Controls.Add(this.label_color);
            this.Controls.Add(this.label_sexo);
            this.Controls.Add(this.dateTime_fnac);
            this.Controls.Add(this.text_raza);
            this.Controls.Add(this.label_fechanac);
            this.Controls.Add(this.label_raza);
            this.Controls.Add(this.label_especie);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.text_cliente);
            this.Controls.Add(this.label_cliente);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel_clientes_opcion);
            this.Controls.Add(this.panel_top);
            this.Name = "FormRecepcionistaMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Mascotas";
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
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRecepcionistaMascota_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_anaydir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_erase)).EndInit();
            this.alerta_eliminar.ResumeLayout(false);
            this.alerta_eliminar.PerformLayout();
            this.box_NombreAnimal.ResumeLayout(false);
            this.box_NombreAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_NombreMascota)).EndInit();
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
        public System.Windows.Forms.Panel panel_clientes_opcion;
        public System.Windows.Forms.PictureBox picture_cliente_opcion_mascota;
        public System.Windows.Forms.PictureBox picture_cliente_opcion_cliente;
        public System.Windows.Forms.DataGridView dataGridView;
        public FormRecepcionistaMascota_DataSet formRecepcionistaMascota_DataSet;
        public System.Windows.Forms.BindingSource consultaBindingSource;
        public FormRecepcionistaMascota_DataSetTableAdapters.ConsultaTableAdapter consultaTableAdapter;
        public System.Windows.Forms.Label label_cliente;
        public System.Windows.Forms.TextBox text_cliente;
        public System.Windows.Forms.Label label_nombre;
        public System.Windows.Forms.Label label_especie;
        public System.Windows.Forms.Label label_raza;
        public System.Windows.Forms.Label label_fechanac;
        public System.Windows.Forms.TextBox text_raza;
        public System.Windows.Forms.DateTimePicker dateTime_fnac;
        public System.Windows.Forms.Label label_sexo;
        public System.Windows.Forms.Label label_color;
        public System.Windows.Forms.Label label_peso;
        public System.Windows.Forms.Label label_tamayo;
        public System.Windows.Forms.TextBox text_color;
        public System.Windows.Forms.TextBox text_peso;
        public System.Windows.Forms.ComboBox combo_tamanyo;
        public System.Windows.Forms.ComboBox combo_sexo;
        public System.Windows.Forms.Label label_microchip;
        public System.Windows.Forms.ComboBox combo_microchip;
        public System.Windows.Forms.PictureBox picture_foto;
        public System.Windows.Forms.Button btn_eliminar;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.PictureBox btn_anaydir;
        public System.Windows.Forms.PictureBox btn_buscar_cliente;
        public System.Windows.Forms.TextBox text_especie;
        public System.Windows.Forms.PictureBox btn_erase;
        public System.Windows.Forms.Panel alerta_eliminar;
        public System.Windows.Forms.Label label_eliminar_box;
        public System.Windows.Forms.Button btn_eliminar_no;
        public System.Windows.Forms.Button btn_eliminar_si;
        public System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        public System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        public System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        public System.Windows.Forms.DataGridViewTextBoxColumn Veterinario;
        public System.Windows.Forms.DataGridViewImageColumn Ver;
        public System.Windows.Forms.ComboBox combo_nombreAnimal;
        private System.Windows.Forms.Panel box_NombreAnimal;
        private System.Windows.Forms.Label box_label_cancelar;
        private System.Windows.Forms.Label box_label_aceptar;
        private System.Windows.Forms.Label box_label_nombre_mascota;
        private System.Windows.Forms.TextBox box_text_nombre_mascota;
        private System.Windows.Forms.PictureBox btn_add_NombreMascota;
    }
}