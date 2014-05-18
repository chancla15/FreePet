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
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.text_especie = new System.Windows.Forms.TextBox();
            this.consultaTableAdapter = new WindowsFormsApplication1.FormRecepcionistaMascota_DataSetTableAdapters.ConsultaTableAdapter();
            this.combo_nombreAnimal = new System.Windows.Forms.ComboBox();
            this.box_NombreAnimal = new System.Windows.Forms.Panel();
            this.box_label_nombre_mascota = new System.Windows.Forms.Label();
            this.box_label_cancelar = new System.Windows.Forms.Label();
            this.box_label_aceptar = new System.Windows.Forms.Label();
            this.box_text_nombre_mascota = new System.Windows.Forms.TextBox();
            this.error_nombre = new System.Windows.Forms.Label();
            this.error_especie = new System.Windows.Forms.Label();
            this.error_raza = new System.Windows.Forms.Label();
            this.error_fechanac = new System.Windows.Forms.Label();
            this.error_sexo = new System.Windows.Forms.Label();
            this.error_tamanyo = new System.Windows.Forms.Label();
            this.error_peso = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_add_NombreMascota = new System.Windows.Forms.PictureBox();
            this.btn_buscar_cliente = new System.Windows.Forms.PictureBox();
            this.btn_anaydir = new System.Windows.Forms.PictureBox();
            this.log_photo = new System.Windows.Forms.PictureBox();
            this.panel_recepcionista = new System.Windows.Forms.Panel();
            this.picture_ajustes = new System.Windows.Forms.PictureBox();
            this.picture_consultas = new System.Windows.Forms.PictureBox();
            this.picture_clientes = new System.Windows.Forms.PictureBox();
            this.picture_facturas = new System.Windows.Forms.PictureBox();
            this.picture_start = new System.Windows.Forms.PictureBox();
            this.panel_clientes_opcion = new System.Windows.Forms.Panel();
            this.picture_cliente_opcion_mascota = new System.Windows.Forms.PictureBox();
            this.picture_cliente_opcion_cliente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRecepcionistaMascota_DataSet)).BeginInit();
            this.box_NombreAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_NombreMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_anaydir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            this.panel_recepcionista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).BeginInit();
            this.panel_clientes_opcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cliente_opcion_mascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cliente_opcion_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Motivo,
            this.Lugar,
            this.Veterinario,
            this.Ver});
            this.dataGridView.DataSource = this.consultaBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 300);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(658, 171);
            this.dataGridView.TabIndex = 55;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
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
            this.label_cliente.Location = new System.Drawing.Point(119, 113);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(39, 13);
            this.label_cliente.TabIndex = 56;
            this.label_cliente.Text = "Cliente";
            // 
            // text_cliente
            // 
            this.text_cliente.Location = new System.Drawing.Point(203, 110);
            this.text_cliente.Name = "text_cliente";
            this.text_cliente.Size = new System.Drawing.Size(118, 20);
            this.text_cliente.TabIndex = 57;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.BackColor = System.Drawing.Color.Transparent;
            this.label_nombre.Location = new System.Drawing.Point(119, 149);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 58;
            this.label_nombre.Text = "Nombre";
            // 
            // label_especie
            // 
            this.label_especie.AutoSize = true;
            this.label_especie.BackColor = System.Drawing.Color.Transparent;
            this.label_especie.Location = new System.Drawing.Point(119, 179);
            this.label_especie.Name = "label_especie";
            this.label_especie.Size = new System.Drawing.Size(45, 13);
            this.label_especie.TabIndex = 60;
            this.label_especie.Text = "Especie";
            // 
            // label_raza
            // 
            this.label_raza.AutoSize = true;
            this.label_raza.BackColor = System.Drawing.Color.Transparent;
            this.label_raza.Location = new System.Drawing.Point(119, 214);
            this.label_raza.Name = "label_raza";
            this.label_raza.Size = new System.Drawing.Size(32, 13);
            this.label_raza.TabIndex = 61;
            this.label_raza.Text = "Raza";
            // 
            // label_fechanac
            // 
            this.label_fechanac.AutoSize = true;
            this.label_fechanac.BackColor = System.Drawing.Color.Transparent;
            this.label_fechanac.Location = new System.Drawing.Point(9, 252);
            this.label_fechanac.Name = "label_fechanac";
            this.label_fechanac.Size = new System.Drawing.Size(69, 13);
            this.label_fechanac.TabIndex = 62;
            this.label_fechanac.Text = "F.Nacimiento";
            // 
            // text_raza
            // 
            this.text_raza.Location = new System.Drawing.Point(203, 208);
            this.text_raza.Name = "text_raza";
            this.text_raza.Size = new System.Drawing.Size(118, 20);
            this.text_raza.TabIndex = 63;
            // 
            // dateTime_fnac
            // 
            this.dateTime_fnac.Location = new System.Drawing.Point(87, 249);
            this.dateTime_fnac.Name = "dateTime_fnac";
            this.dateTime_fnac.Size = new System.Drawing.Size(118, 20);
            this.dateTime_fnac.TabIndex = 64;
            // 
            // label_sexo
            // 
            this.label_sexo.AutoSize = true;
            this.label_sexo.BackColor = System.Drawing.Color.Transparent;
            this.label_sexo.Location = new System.Drawing.Point(221, 252);
            this.label_sexo.Name = "label_sexo";
            this.label_sexo.Size = new System.Drawing.Size(31, 13);
            this.label_sexo.TabIndex = 66;
            this.label_sexo.Text = "Sexo";
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.BackColor = System.Drawing.Color.Transparent;
            this.label_color.Location = new System.Drawing.Point(337, 251);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(31, 13);
            this.label_color.TabIndex = 67;
            this.label_color.Text = "Color";
            // 
            // label_peso
            // 
            this.label_peso.AutoSize = true;
            this.label_peso.BackColor = System.Drawing.Color.Transparent;
            this.label_peso.Location = new System.Drawing.Point(337, 211);
            this.label_peso.Name = "label_peso";
            this.label_peso.Size = new System.Drawing.Size(31, 13);
            this.label_peso.TabIndex = 68;
            this.label_peso.Text = "Peso";
            // 
            // label_tamayo
            // 
            this.label_tamayo.AutoSize = true;
            this.label_tamayo.BackColor = System.Drawing.Color.Transparent;
            this.label_tamayo.Location = new System.Drawing.Point(337, 176);
            this.label_tamayo.Name = "label_tamayo";
            this.label_tamayo.Size = new System.Drawing.Size(46, 13);
            this.label_tamayo.TabIndex = 69;
            this.label_tamayo.Text = "Tamaño";
            // 
            // text_color
            // 
            this.text_color.Location = new System.Drawing.Point(399, 247);
            this.text_color.Name = "text_color";
            this.text_color.Size = new System.Drawing.Size(68, 20);
            this.text_color.TabIndex = 70;
            // 
            // text_peso
            // 
            this.text_peso.Location = new System.Drawing.Point(399, 208);
            this.text_peso.Name = "text_peso";
            this.text_peso.Size = new System.Drawing.Size(68, 20);
            this.text_peso.TabIndex = 71;
            // 
            // combo_tamanyo
            // 
            this.combo_tamanyo.FormattingEnabled = true;
            this.combo_tamanyo.Location = new System.Drawing.Point(399, 174);
            this.combo_tamanyo.Name = "combo_tamanyo";
            this.combo_tamanyo.Size = new System.Drawing.Size(68, 21);
            this.combo_tamanyo.TabIndex = 72;
            // 
            // combo_sexo
            // 
            this.combo_sexo.FormattingEnabled = true;
            this.combo_sexo.Location = new System.Drawing.Point(258, 248);
            this.combo_sexo.Name = "combo_sexo";
            this.combo_sexo.Size = new System.Drawing.Size(63, 21);
            this.combo_sexo.TabIndex = 73;
            // 
            // label_microchip
            // 
            this.label_microchip.AutoSize = true;
            this.label_microchip.BackColor = System.Drawing.Color.Transparent;
            this.label_microchip.Location = new System.Drawing.Point(493, 251);
            this.label_microchip.Name = "label_microchip";
            this.label_microchip.Size = new System.Drawing.Size(53, 13);
            this.label_microchip.TabIndex = 74;
            this.label_microchip.Text = "Microchip";
            // 
            // combo_microchip
            // 
            this.combo_microchip.FormattingEnabled = true;
            this.combo_microchip.Location = new System.Drawing.Point(557, 249);
            this.combo_microchip.Name = "combo_microchip";
            this.combo_microchip.Size = new System.Drawing.Size(49, 21);
            this.combo_microchip.TabIndex = 75;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(595, 176);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 79;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(595, 141);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 78;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // text_especie
            // 
            this.text_especie.Location = new System.Drawing.Point(203, 174);
            this.text_especie.Name = "text_especie";
            this.text_especie.Size = new System.Drawing.Size(118, 20);
            this.text_especie.TabIndex = 82;
            // 
            // consultaTableAdapter
            // 
            this.consultaTableAdapter.ClearBeforeFill = true;
            // 
            // combo_nombreAnimal
            // 
            this.combo_nombreAnimal.FormattingEnabled = true;
            this.combo_nombreAnimal.Location = new System.Drawing.Point(203, 142);
            this.combo_nombreAnimal.Name = "combo_nombreAnimal";
            this.combo_nombreAnimal.Size = new System.Drawing.Size(121, 21);
            this.combo_nombreAnimal.TabIndex = 85;
            this.combo_nombreAnimal.SelectedIndexChanged += new System.EventHandler(this.combo_nombreAnimal_SelectedIndexChanged);
            // 
            // box_NombreAnimal
            // 
            this.box_NombreAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_NombreAnimal.Controls.Add(this.box_label_nombre_mascota);
            this.box_NombreAnimal.Controls.Add(this.box_label_cancelar);
            this.box_NombreAnimal.Controls.Add(this.box_label_aceptar);
            this.box_NombreAnimal.Controls.Add(this.box_text_nombre_mascota);
            this.box_NombreAnimal.Location = new System.Drawing.Point(366, 99);
            this.box_NombreAnimal.Name = "box_NombreAnimal";
            this.box_NombreAnimal.Size = new System.Drawing.Size(207, 69);
            this.box_NombreAnimal.TabIndex = 86;
            this.box_NombreAnimal.Visible = false;
            // 
            // box_label_nombre_mascota
            // 
            this.box_label_nombre_mascota.AutoSize = true;
            this.box_label_nombre_mascota.BackColor = System.Drawing.Color.Transparent;
            this.box_label_nombre_mascota.Location = new System.Drawing.Point(15, 8);
            this.box_label_nombre_mascota.Name = "box_label_nombre_mascota";
            this.box_label_nombre_mascota.Size = new System.Drawing.Size(176, 13);
            this.box_label_nombre_mascota.TabIndex = 1;
            this.box_label_nombre_mascota.Text = "Introduce un nombre para el animal:";
            // 
            // box_label_cancelar
            // 
            this.box_label_cancelar.AutoSize = true;
            this.box_label_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.box_label_cancelar.Location = new System.Drawing.Point(18, 47);
            this.box_label_cancelar.Name = "box_label_cancelar";
            this.box_label_cancelar.Size = new System.Drawing.Size(49, 13);
            this.box_label_cancelar.TabIndex = 3;
            this.box_label_cancelar.Text = "Cancelar";
            this.box_label_cancelar.Click += new System.EventHandler(this.box_label_cancelar_Click);
            // 
            // box_label_aceptar
            // 
            this.box_label_aceptar.AutoSize = true;
            this.box_label_aceptar.BackColor = System.Drawing.Color.Transparent;
            this.box_label_aceptar.Location = new System.Drawing.Point(140, 47);
            this.box_label_aceptar.Name = "box_label_aceptar";
            this.box_label_aceptar.Size = new System.Drawing.Size(44, 13);
            this.box_label_aceptar.TabIndex = 2;
            this.box_label_aceptar.Text = "Aceptar";
            this.box_label_aceptar.Click += new System.EventHandler(this.box_label_aceptar_Click);
            // 
            // box_text_nombre_mascota
            // 
            this.box_text_nombre_mascota.Location = new System.Drawing.Point(18, 24);
            this.box_text_nombre_mascota.Name = "box_text_nombre_mascota";
            this.box_text_nombre_mascota.Size = new System.Drawing.Size(166, 20);
            this.box_text_nombre_mascota.TabIndex = 0;
            // 
            // error_nombre
            // 
            this.error_nombre.AutoSize = true;
            this.error_nombre.BackColor = System.Drawing.Color.Transparent;
            this.error_nombre.ForeColor = System.Drawing.Color.Red;
            this.error_nombre.Location = new System.Drawing.Point(349, 145);
            this.error_nombre.Name = "error_nombre";
            this.error_nombre.Size = new System.Drawing.Size(11, 13);
            this.error_nombre.TabIndex = 88;
            this.error_nombre.Text = "*";
            this.error_nombre.Visible = false;
            // 
            // error_especie
            // 
            this.error_especie.AutoSize = true;
            this.error_especie.BackColor = System.Drawing.Color.Transparent;
            this.error_especie.ForeColor = System.Drawing.Color.Red;
            this.error_especie.Location = new System.Drawing.Point(324, 176);
            this.error_especie.Name = "error_especie";
            this.error_especie.Size = new System.Drawing.Size(11, 13);
            this.error_especie.TabIndex = 89;
            this.error_especie.Text = "*";
            this.error_especie.Visible = false;
            // 
            // error_raza
            // 
            this.error_raza.AutoSize = true;
            this.error_raza.BackColor = System.Drawing.Color.Transparent;
            this.error_raza.ForeColor = System.Drawing.Color.Red;
            this.error_raza.Location = new System.Drawing.Point(324, 211);
            this.error_raza.Name = "error_raza";
            this.error_raza.Size = new System.Drawing.Size(11, 13);
            this.error_raza.TabIndex = 90;
            this.error_raza.Text = "*";
            this.error_raza.Visible = false;
            // 
            // error_fechanac
            // 
            this.error_fechanac.AutoSize = true;
            this.error_fechanac.BackColor = System.Drawing.Color.Transparent;
            this.error_fechanac.ForeColor = System.Drawing.Color.Red;
            this.error_fechanac.Location = new System.Drawing.Point(211, 252);
            this.error_fechanac.Name = "error_fechanac";
            this.error_fechanac.Size = new System.Drawing.Size(11, 13);
            this.error_fechanac.TabIndex = 91;
            this.error_fechanac.Text = "*";
            this.error_fechanac.Visible = false;
            // 
            // error_sexo
            // 
            this.error_sexo.AutoSize = true;
            this.error_sexo.BackColor = System.Drawing.Color.Transparent;
            this.error_sexo.ForeColor = System.Drawing.Color.Red;
            this.error_sexo.Location = new System.Drawing.Point(324, 252);
            this.error_sexo.Name = "error_sexo";
            this.error_sexo.Size = new System.Drawing.Size(11, 13);
            this.error_sexo.TabIndex = 92;
            this.error_sexo.Text = "*";
            this.error_sexo.Visible = false;
            // 
            // error_tamanyo
            // 
            this.error_tamanyo.AutoSize = true;
            this.error_tamanyo.BackColor = System.Drawing.Color.Transparent;
            this.error_tamanyo.ForeColor = System.Drawing.Color.Red;
            this.error_tamanyo.Location = new System.Drawing.Point(473, 176);
            this.error_tamanyo.Name = "error_tamanyo";
            this.error_tamanyo.Size = new System.Drawing.Size(11, 13);
            this.error_tamanyo.TabIndex = 88;
            this.error_tamanyo.Text = "*";
            this.error_tamanyo.Visible = false;
            // 
            // error_peso
            // 
            this.error_peso.AutoSize = true;
            this.error_peso.BackColor = System.Drawing.Color.Transparent;
            this.error_peso.ForeColor = System.Drawing.Color.Red;
            this.error_peso.Location = new System.Drawing.Point(473, 211);
            this.error_peso.Name = "error_peso";
            this.error_peso.Size = new System.Drawing.Size(11, 13);
            this.error_peso.TabIndex = 93;
            this.error_peso.Text = "*";
            this.error_peso.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_add_NombreMascota
            // 
            this.btn_add_NombreMascota.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_NombreMascota.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.add;
            this.btn_add_NombreMascota.Location = new System.Drawing.Point(327, 144);
            this.btn_add_NombreMascota.Name = "btn_add_NombreMascota";
            this.btn_add_NombreMascota.Size = new System.Drawing.Size(16, 16);
            this.btn_add_NombreMascota.TabIndex = 87;
            this.btn_add_NombreMascota.TabStop = false;
            this.btn_add_NombreMascota.Click += new System.EventHandler(this.btn_add_NombreMascota_Click);
            // 
            // btn_buscar_cliente
            // 
            this.btn_buscar_cliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar_cliente.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.btn_buscar_id;
            this.btn_buscar_cliente.Location = new System.Drawing.Point(327, 110);
            this.btn_buscar_cliente.Name = "btn_buscar_cliente";
            this.btn_buscar_cliente.Size = new System.Drawing.Size(16, 16);
            this.btn_buscar_cliente.TabIndex = 81;
            this.btn_buscar_cliente.TabStop = false;
            this.btn_buscar_cliente.Click += new System.EventHandler(this.btn_buscar_cliente_Click);
            // 
            // btn_anaydir
            // 
            this.btn_anaydir.BackColor = System.Drawing.Color.Transparent;
            this.btn_anaydir.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.add;
            this.btn_anaydir.Location = new System.Drawing.Point(654, 278);
            this.btn_anaydir.Name = "btn_anaydir";
            this.btn_anaydir.Size = new System.Drawing.Size(16, 16);
            this.btn_anaydir.TabIndex = 80;
            this.btn_anaydir.TabStop = false;
            this.btn_anaydir.Click += new System.EventHandler(this.btn_anaydir_Click);
            // 
            // log_photo
            // 
            this.log_photo.BackColor = System.Drawing.Color.Transparent;
            this.log_photo.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.sinFotoa;
            this.log_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.log_photo.Location = new System.Drawing.Point(12, 113);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(94, 120);
            this.log_photo.TabIndex = 76;
            this.log_photo.TabStop = false;
            this.log_photo.Click += new System.EventHandler(this.picture_foto_Click);
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
            this.panel_recepcionista.TabIndex = 95;
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
            this.picture_clientes.BackColor = System.Drawing.Color.White;
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
            this.picture_facturas.BackColor = System.Drawing.Color.Transparent;
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
            // panel_clientes_opcion
            // 
            this.panel_clientes_opcion.BackColor = System.Drawing.Color.Transparent;
            this.panel_clientes_opcion.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.BARRA_MENU;
            this.panel_clientes_opcion.Controls.Add(this.picture_cliente_opcion_mascota);
            this.panel_clientes_opcion.Controls.Add(this.picture_cliente_opcion_cliente);
            this.panel_clientes_opcion.Location = new System.Drawing.Point(0, 44);
            this.panel_clientes_opcion.Name = "panel_clientes_opcion";
            this.panel_clientes_opcion.Size = new System.Drawing.Size(690, 44);
            this.panel_clientes_opcion.TabIndex = 54;
            // 
            // picture_cliente_opcion_mascota
            // 
            this.picture_cliente_opcion_mascota.BackColor = System.Drawing.Color.White;
            this.picture_cliente_opcion_mascota.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_RECEPCIONISTA_FICHA_MASCOTA;
            this.picture_cliente_opcion_mascota.Location = new System.Drawing.Point(338, 0);
            this.picture_cliente_opcion_mascota.Name = "picture_cliente_opcion_mascota";
            this.picture_cliente_opcion_mascota.Size = new System.Drawing.Size(345, 44);
            this.picture_cliente_opcion_mascota.TabIndex = 54;
            this.picture_cliente_opcion_mascota.TabStop = false;
            this.picture_cliente_opcion_mascota.Click += new System.EventHandler(this.picture_cliente_opcion_mascota_Click);
            // 
            // picture_cliente_opcion_cliente
            // 
            this.picture_cliente_opcion_cliente.BackColor = System.Drawing.Color.Transparent;
            this.picture_cliente_opcion_cliente.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.MENU_RECEPCIONISTA_FICHA_CLIENTE;
            this.picture_cliente_opcion_cliente.Location = new System.Drawing.Point(-1, 0);
            this.picture_cliente_opcion_cliente.Name = "picture_cliente_opcion_cliente";
            this.picture_cliente_opcion_cliente.Size = new System.Drawing.Size(342, 44);
            this.picture_cliente_opcion_cliente.TabIndex = 0;
            this.picture_cliente_opcion_cliente.TabStop = false;
            this.picture_cliente_opcion_cliente.Click += new System.EventHandler(this.picture_cliente_opcion_cliente_Click);
            // 
            // FormRecepcionistaMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.panel_clientes_opcion);
            this.Controls.Add(this.panel_recepcionista);
            this.Controls.Add(this.box_NombreAnimal);
            this.Controls.Add(this.error_peso);
            this.Controls.Add(this.error_tamanyo);
            this.Controls.Add(this.error_sexo);
            this.Controls.Add(this.error_fechanac);
            this.Controls.Add(this.error_raza);
            this.Controls.Add(this.error_nombre);
            this.Controls.Add(this.error_especie);
            this.Controls.Add(this.btn_add_NombreMascota);
            this.Controls.Add(this.combo_nombreAnimal);
            this.Controls.Add(this.text_especie);
            this.Controls.Add(this.btn_buscar_cliente);
            this.Controls.Add(this.btn_anaydir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.log_photo);
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
            this.DoubleBuffered = true;
            this.Name = "FormRecepcionistaMascota";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mascotas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRecepcionistaMascota_DataSet)).EndInit();
            this.box_NombreAnimal.ResumeLayout(false);
            this.box_NombreAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_NombreMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_anaydir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            this.panel_recepcionista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_ajustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).EndInit();
            this.panel_clientes_opcion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_cliente_opcion_mascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cliente_opcion_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        public System.Windows.Forms.PictureBox log_photo;
        public System.Windows.Forms.Button btn_eliminar;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.PictureBox btn_anaydir;
        public System.Windows.Forms.PictureBox btn_buscar_cliente;
        public System.Windows.Forms.TextBox text_especie;
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
        public System.Windows.Forms.TextBox box_text_nombre_mascota;
        public System.Windows.Forms.PictureBox btn_add_NombreMascota;
        public System.Windows.Forms.Label error_nombre;
        public System.Windows.Forms.Label error_especie;
        public System.Windows.Forms.Label error_raza;
        public System.Windows.Forms.Label error_fechanac;
        public System.Windows.Forms.Label error_sexo;
        public System.Windows.Forms.Label error_tamanyo;
        public System.Windows.Forms.Label error_peso;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel_recepcionista;
        private System.Windows.Forms.PictureBox picture_ajustes;
        private System.Windows.Forms.PictureBox picture_consultas;
        private System.Windows.Forms.PictureBox picture_clientes;
        private System.Windows.Forms.PictureBox picture_facturas;
        private System.Windows.Forms.PictureBox picture_start;
        public System.Windows.Forms.Panel panel_clientes_opcion;
        public System.Windows.Forms.PictureBox picture_cliente_opcion_mascota;
        public System.Windows.Forms.PictureBox picture_cliente_opcion_cliente;
    }
}