namespace WindowsFormsApplication1
{
    partial class FormVeterinarioConsulta
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
            this.log_type = new System.Windows.Forms.Label();
            this.log_name = new System.Windows.Forms.Label();
            this.log_photo = new System.Windows.Forms.PictureBox();
            this.text_hora = new System.Windows.Forms.TextBox();
            this.label_hora = new System.Windows.Forms.Label();
            this.text_fecha = new System.Windows.Forms.TextBox();
            this.label_fecha = new System.Windows.Forms.Label();
            this.text_motivo = new System.Windows.Forms.TextBox();
            this.label_motivo = new System.Windows.Forms.Label();
            this.text_diagnostico = new System.Windows.Forms.TextBox();
            this.label_diagnostico = new System.Windows.Forms.Label();
            this.label_lugar = new System.Windows.Forms.Label();
            this.text_lugar = new System.Windows.Forms.TextBox();
            this.label_tratamientos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_ficha = new System.Windows.Forms.GroupBox();
            this.textBox_chip = new System.Windows.Forms.TextBox();
            this.textBox_color = new System.Windows.Forms.TextBox();
            this.textBox_peso = new System.Windows.Forms.TextBox();
            this.textBox_sexo = new System.Windows.Forms.TextBox();
            this.textBox_tam = new System.Windows.Forms.TextBox();
            this.textBox_raza = new System.Windows.Forms.TextBox();
            this.textBox_especie = new System.Windows.Forms.TextBox();
            this.textBox_fn = new System.Windows.Forms.TextBox();
            this.label_microchip = new System.Windows.Forms.Label();
            this.label_color = new System.Windows.Forms.Label();
            this.label_tamaño = new System.Windows.Forms.Label();
            this.label_sexo = new System.Windows.Forms.Label();
            this.label_especie = new System.Windows.Forms.Label();
            this.label_fn = new System.Windows.Forms.Label();
            this.label_raza = new System.Windows.Forms.Label();
            this.label_peso = new System.Windows.Forms.Label();
            this.textBox_mascota = new System.Windows.Forms.TextBox();
            this.textBox_cliente = new System.Windows.Forms.TextBox();
            this.button_realizar = new System.Windows.Forms.Button();
            this.button_anular = new System.Windows.Forms.Button();
            this.picture_inicio_veterinario = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_consulta_veterinario = new System.Windows.Forms.PictureBox();
            this.picture_desconectar_veterinario = new System.Windows.Forms.PictureBox();
            this.listBox_addTratamiento = new System.Windows.Forms.ListBox();
            this.label_doc = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.gestionVeterinariaGenNHibernateDataSet = new WindowsFormsApplication1.GestionVeterinariaGenNHibernateDataSet();
            this.tratamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tratamientoTableAdapter = new WindowsFormsApplication1.GestionVeterinariaGenNHibernateDataSetTableAdapters.TratamientoTableAdapter();
            this.gestionVeterinariaGenNHibernateDataSet1 = new WindowsFormsApplication1.GestionVeterinariaGenNHibernateDataSet1();
            this.tratamientoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tratamientoTableAdapter1 = new WindowsFormsApplication1.GestionVeterinariaGenNHibernateDataSet1TableAdapters.TratamientoTableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosisdiariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_ficha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_inicio_veterinario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consulta_veterinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_desconectar_veterinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionVeterinariaGenNHibernateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionVeterinariaGenNHibernateDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // log_type
            // 
            this.log_type.AutoSize = true;
            this.log_type.BackColor = System.Drawing.Color.Transparent;
            this.log_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_type.Location = new System.Drawing.Point(108, 119);
            this.log_type.Name = "log_type";
            this.log_type.Size = new System.Drawing.Size(57, 18);
            this.log_type.TabIndex = 45;
            this.log_type.Text = "Cliente:";
            // 
            // log_name
            // 
            this.log_name.AutoSize = true;
            this.log_name.BackColor = System.Drawing.Color.Transparent;
            this.log_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_name.Location = new System.Drawing.Point(108, 50);
            this.log_name.Name = "log_name";
            this.log_name.Size = new System.Drawing.Size(134, 20);
            this.log_name.TabIndex = 43;
            this.log_name.Text = "Nombre Mascota:";
            // 
            // log_photo
            // 
            this.log_photo.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.log_photo.Location = new System.Drawing.Point(12, 50);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(90, 120);
            this.log_photo.TabIndex = 42;
            this.log_photo.TabStop = false;
            // 
            // text_hora
            // 
            this.text_hora.Location = new System.Drawing.Point(205, 185);
            this.text_hora.Name = "text_hora";
            this.text_hora.Size = new System.Drawing.Size(100, 20);
            this.text_hora.TabIndex = 50;
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Location = new System.Drawing.Point(166, 188);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(33, 13);
            this.label_hora.TabIndex = 49;
            this.label_hora.Text = "Hora:";
            // 
            // text_fecha
            // 
            this.text_fecha.Location = new System.Drawing.Point(56, 185);
            this.text_fecha.Name = "text_fecha";
            this.text_fecha.Size = new System.Drawing.Size(100, 20);
            this.text_fecha.TabIndex = 52;
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Location = new System.Drawing.Point(10, 188);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(40, 13);
            this.label_fecha.TabIndex = 51;
            this.label_fecha.Text = "Fecha:";
            // 
            // text_motivo
            // 
            this.text_motivo.Location = new System.Drawing.Point(125, 217);
            this.text_motivo.Name = "text_motivo";
            this.text_motivo.Size = new System.Drawing.Size(528, 20);
            this.text_motivo.TabIndex = 56;
            // 
            // label_motivo
            // 
            this.label_motivo.AutoSize = true;
            this.label_motivo.Location = new System.Drawing.Point(8, 220);
            this.label_motivo.Name = "label_motivo";
            this.label_motivo.Size = new System.Drawing.Size(111, 13);
            this.label_motivo.TabIndex = 55;
            this.label_motivo.Text = "Motivo de la consulta:";
            // 
            // text_diagnostico
            // 
            this.text_diagnostico.Location = new System.Drawing.Point(10, 265);
            this.text_diagnostico.Multiline = true;
            this.text_diagnostico.Name = "text_diagnostico";
            this.text_diagnostico.Size = new System.Drawing.Size(642, 49);
            this.text_diagnostico.TabIndex = 58;
            // 
            // label_diagnostico
            // 
            this.label_diagnostico.AutoSize = true;
            this.label_diagnostico.Location = new System.Drawing.Point(9, 249);
            this.label_diagnostico.Name = "label_diagnostico";
            this.label_diagnostico.Size = new System.Drawing.Size(66, 13);
            this.label_diagnostico.TabIndex = 57;
            this.label_diagnostico.Text = "Diagnostico:";
            // 
            // label_lugar
            // 
            this.label_lugar.AutoSize = true;
            this.label_lugar.Location = new System.Drawing.Point(328, 188);
            this.label_lugar.Name = "label_lugar";
            this.label_lugar.Size = new System.Drawing.Size(37, 13);
            this.label_lugar.TabIndex = 59;
            this.label_lugar.Text = "Lugar:";
            // 
            // text_lugar
            // 
            this.text_lugar.Location = new System.Drawing.Point(371, 185);
            this.text_lugar.Name = "text_lugar";
            this.text_lugar.Size = new System.Drawing.Size(282, 20);
            this.text_lugar.TabIndex = 60;
            // 
            // label_tratamientos
            // 
            this.label_tratamientos.AutoSize = true;
            this.label_tratamientos.Location = new System.Drawing.Point(10, 327);
            this.label_tratamientos.Name = "label_tratamientos";
            this.label_tratamientos.Size = new System.Drawing.Size(71, 13);
            this.label_tratamientos.TabIndex = 61;
            this.label_tratamientos.Text = "Tratamientos:";
            this.label_tratamientos.Click += new System.EventHandler(this.label_tratamientos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.dosisdiariaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tratamientoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 113);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox_ficha
            // 
            this.groupBox_ficha.Controls.Add(this.textBox_chip);
            this.groupBox_ficha.Controls.Add(this.textBox_color);
            this.groupBox_ficha.Controls.Add(this.textBox_peso);
            this.groupBox_ficha.Controls.Add(this.textBox_sexo);
            this.groupBox_ficha.Controls.Add(this.textBox_tam);
            this.groupBox_ficha.Controls.Add(this.textBox_raza);
            this.groupBox_ficha.Controls.Add(this.textBox_especie);
            this.groupBox_ficha.Controls.Add(this.textBox_fn);
            this.groupBox_ficha.Controls.Add(this.label_microchip);
            this.groupBox_ficha.Controls.Add(this.label_color);
            this.groupBox_ficha.Controls.Add(this.label_tamaño);
            this.groupBox_ficha.Controls.Add(this.label_sexo);
            this.groupBox_ficha.Controls.Add(this.label_especie);
            this.groupBox_ficha.Controls.Add(this.label_fn);
            this.groupBox_ficha.Controls.Add(this.label_raza);
            this.groupBox_ficha.Controls.Add(this.label_peso);
            this.groupBox_ficha.Location = new System.Drawing.Point(282, 43);
            this.groupBox_ficha.Name = "groupBox_ficha";
            this.groupBox_ficha.Size = new System.Drawing.Size(378, 127);
            this.groupBox_ficha.TabIndex = 63;
            this.groupBox_ficha.TabStop = false;
            this.groupBox_ficha.Text = "Ficha Mascota";
            // 
            // textBox_chip
            // 
            this.textBox_chip.Location = new System.Drawing.Point(302, 97);
            this.textBox_chip.Name = "textBox_chip";
            this.textBox_chip.Size = new System.Drawing.Size(69, 20);
            this.textBox_chip.TabIndex = 73;
            // 
            // textBox_color
            // 
            this.textBox_color.Location = new System.Drawing.Point(302, 76);
            this.textBox_color.Name = "textBox_color";
            this.textBox_color.Size = new System.Drawing.Size(69, 20);
            this.textBox_color.TabIndex = 72;
            // 
            // textBox_peso
            // 
            this.textBox_peso.Location = new System.Drawing.Point(302, 54);
            this.textBox_peso.Name = "textBox_peso";
            this.textBox_peso.Size = new System.Drawing.Size(69, 20);
            this.textBox_peso.TabIndex = 71;
            this.textBox_peso.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox_sexo
            // 
            this.textBox_sexo.Location = new System.Drawing.Point(302, 32);
            this.textBox_sexo.Name = "textBox_sexo";
            this.textBox_sexo.Size = new System.Drawing.Size(69, 20);
            this.textBox_sexo.TabIndex = 70;
            // 
            // textBox_tam
            // 
            this.textBox_tam.Location = new System.Drawing.Point(107, 99);
            this.textBox_tam.Name = "textBox_tam";
            this.textBox_tam.Size = new System.Drawing.Size(125, 20);
            this.textBox_tam.TabIndex = 69;
            // 
            // textBox_raza
            // 
            this.textBox_raza.Location = new System.Drawing.Point(107, 76);
            this.textBox_raza.Name = "textBox_raza";
            this.textBox_raza.Size = new System.Drawing.Size(125, 20);
            this.textBox_raza.TabIndex = 68;
            // 
            // textBox_especie
            // 
            this.textBox_especie.Location = new System.Drawing.Point(107, 53);
            this.textBox_especie.Name = "textBox_especie";
            this.textBox_especie.Size = new System.Drawing.Size(125, 20);
            this.textBox_especie.TabIndex = 67;
            // 
            // textBox_fn
            // 
            this.textBox_fn.Location = new System.Drawing.Point(107, 31);
            this.textBox_fn.Name = "textBox_fn";
            this.textBox_fn.Size = new System.Drawing.Size(125, 20);
            this.textBox_fn.TabIndex = 66;
            // 
            // label_microchip
            // 
            this.label_microchip.AutoSize = true;
            this.label_microchip.Location = new System.Drawing.Point(238, 100);
            this.label_microchip.Name = "label_microchip";
            this.label_microchip.Size = new System.Drawing.Size(57, 13);
            this.label_microchip.TabIndex = 7;
            this.label_microchip.Text = "MicroChip:";
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.Location = new System.Drawing.Point(238, 76);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(34, 13);
            this.label_color.TabIndex = 6;
            this.label_color.Text = "Color:";
            // 
            // label_tamaño
            // 
            this.label_tamaño.AutoSize = true;
            this.label_tamaño.Location = new System.Drawing.Point(6, 99);
            this.label_tamaño.Name = "label_tamaño";
            this.label_tamaño.Size = new System.Drawing.Size(49, 13);
            this.label_tamaño.TabIndex = 5;
            this.label_tamaño.Text = "Tamaño:";
            // 
            // label_sexo
            // 
            this.label_sexo.AutoSize = true;
            this.label_sexo.Location = new System.Drawing.Point(238, 35);
            this.label_sexo.Name = "label_sexo";
            this.label_sexo.Size = new System.Drawing.Size(34, 13);
            this.label_sexo.TabIndex = 4;
            this.label_sexo.Text = "Sexo:";
            // 
            // label_especie
            // 
            this.label_especie.AutoSize = true;
            this.label_especie.Location = new System.Drawing.Point(6, 54);
            this.label_especie.Name = "label_especie";
            this.label_especie.Size = new System.Drawing.Size(48, 13);
            this.label_especie.TabIndex = 3;
            this.label_especie.Text = "Especie:";
            // 
            // label_fn
            // 
            this.label_fn.AutoSize = true;
            this.label_fn.Location = new System.Drawing.Point(6, 35);
            this.label_fn.Name = "label_fn";
            this.label_fn.Size = new System.Drawing.Size(96, 13);
            this.label_fn.TabIndex = 2;
            this.label_fn.Text = "Fecha Nacimiento:";
            // 
            // label_raza
            // 
            this.label_raza.AutoSize = true;
            this.label_raza.Location = new System.Drawing.Point(6, 76);
            this.label_raza.Name = "label_raza";
            this.label_raza.Size = new System.Drawing.Size(35, 13);
            this.label_raza.TabIndex = 1;
            this.label_raza.Text = "Raza:";
            this.label_raza.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_peso
            // 
            this.label_peso.AutoSize = true;
            this.label_peso.Location = new System.Drawing.Point(238, 54);
            this.label_peso.Name = "label_peso";
            this.label_peso.Size = new System.Drawing.Size(34, 13);
            this.label_peso.TabIndex = 0;
            this.label_peso.Text = "Peso:";
            // 
            // textBox_mascota
            // 
            this.textBox_mascota.Location = new System.Drawing.Point(112, 82);
            this.textBox_mascota.Name = "textBox_mascota";
            this.textBox_mascota.Size = new System.Drawing.Size(130, 20);
            this.textBox_mascota.TabIndex = 64;
            // 
            // textBox_cliente
            // 
            this.textBox_cliente.Location = new System.Drawing.Point(112, 142);
            this.textBox_cliente.Name = "textBox_cliente";
            this.textBox_cliente.Size = new System.Drawing.Size(130, 20);
            this.textBox_cliente.TabIndex = 65;
            // 
            // button_realizar
            // 
            this.button_realizar.Location = new System.Drawing.Point(519, 566);
            this.button_realizar.Name = "button_realizar";
            this.button_realizar.Size = new System.Drawing.Size(135, 23);
            this.button_realizar.TabIndex = 66;
            this.button_realizar.Text = "Realizar consulta";
            this.button_realizar.UseVisualStyleBackColor = true;
            this.button_realizar.Click += new System.EventHandler(this.button_realizar_Click);
            // 
            // button_anular
            // 
            this.button_anular.Location = new System.Drawing.Point(372, 566);
            this.button_anular.Name = "button_anular";
            this.button_anular.Size = new System.Drawing.Size(135, 23);
            this.button_anular.TabIndex = 68;
            this.button_anular.Text = "Anular consulta";
            this.button_anular.UseVisualStyleBackColor = true;
            // 
            // picture_inicio_veterinario
            // 
            this.picture_inicio_veterinario.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.home;
            this.picture_inicio_veterinario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_inicio_veterinario.Location = new System.Drawing.Point(9, 0);
            this.picture_inicio_veterinario.Name = "picture_inicio_veterinario";
            this.picture_inicio_veterinario.Size = new System.Drawing.Size(165, 34);
            this.picture_inicio_veterinario.TabIndex = 50;
            this.picture_inicio_veterinario.TabStop = false;
            this.picture_inicio_veterinario.Click += new System.EventHandler(this.picture_inicio_veterinario_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.picture_inicio_veterinario);
            this.panel1.Controls.Add(this.picture_consulta_veterinario);
            this.panel1.Controls.Add(this.picture_desconectar_veterinario);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 34);
            this.panel1.TabIndex = 69;
            // 
            // picture_consulta_veterinario
            // 
            this.picture_consulta_veterinario.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.consulta;
            this.picture_consulta_veterinario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_consulta_veterinario.Location = new System.Drawing.Point(257, 0);
            this.picture_consulta_veterinario.Name = "picture_consulta_veterinario";
            this.picture_consulta_veterinario.Size = new System.Drawing.Size(165, 34);
            this.picture_consulta_veterinario.TabIndex = 51;
            this.picture_consulta_veterinario.TabStop = false;
            this.picture_consulta_veterinario.Click += new System.EventHandler(this.picture_consulta_veterinario_Click_1);
            // 
            // picture_desconectar_veterinario
            // 
            this.picture_desconectar_veterinario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.picture_desconectar_veterinario.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.desconectar;
            this.picture_desconectar_veterinario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_desconectar_veterinario.Location = new System.Drawing.Point(506, 0);
            this.picture_desconectar_veterinario.Name = "picture_desconectar_veterinario";
            this.picture_desconectar_veterinario.Size = new System.Drawing.Size(165, 34);
            this.picture_desconectar_veterinario.TabIndex = 52;
            this.picture_desconectar_veterinario.TabStop = false;
            this.picture_desconectar_veterinario.Click += new System.EventHandler(this.picture_desconectar_veterinario_Click_1);
            // 
            // listBox_addTratamiento
            // 
            this.listBox_addTratamiento.FormattingEnabled = true;
            this.listBox_addTratamiento.Location = new System.Drawing.Point(10, 462);
            this.listBox_addTratamiento.Name = "listBox_addTratamiento";
            this.listBox_addTratamiento.Size = new System.Drawing.Size(560, 69);
            this.listBox_addTratamiento.TabIndex = 70;
            // 
            // label_doc
            // 
            this.label_doc.AutoSize = true;
            this.label_doc.Location = new System.Drawing.Point(16, 566);
            this.label_doc.Name = "label_doc";
            this.label_doc.Size = new System.Drawing.Size(35, 13);
            this.label_doc.TabIndex = 71;
            this.label_doc.Text = "label1";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(576, 479);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 72;
            this.button_add.Text = "Añadir";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(576, 508);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(75, 23);
            this.button_del.TabIndex = 73;
            this.button_del.Text = "Quitar";
            this.button_del.UseVisualStyleBackColor = true;
            // 
            // gestionVeterinariaGenNHibernateDataSet
            // 
            this.gestionVeterinariaGenNHibernateDataSet.DataSetName = "GestionVeterinariaGenNHibernateDataSet";
            this.gestionVeterinariaGenNHibernateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tratamientoBindingSource
            // 
            this.tratamientoBindingSource.DataMember = "Tratamiento";
            this.tratamientoBindingSource.DataSource = this.gestionVeterinariaGenNHibernateDataSet;
            // 
            // tratamientoTableAdapter
            // 
            this.tratamientoTableAdapter.ClearBeforeFill = true;
            // 
            // gestionVeterinariaGenNHibernateDataSet1
            // 
            this.gestionVeterinariaGenNHibernateDataSet1.DataSetName = "GestionVeterinariaGenNHibernateDataSet1";
            this.gestionVeterinariaGenNHibernateDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tratamientoBindingSource1
            // 
            this.tratamientoBindingSource1.DataMember = "Tratamiento";
            this.tratamientoBindingSource1.DataSource = this.gestionVeterinariaGenNHibernateDataSet1;
            // 
            // tratamientoTableAdapter1
            // 
            this.tratamientoTableAdapter1.ClearBeforeFill = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // dosisdiariaDataGridViewTextBoxColumn
            // 
            this.dosisdiariaDataGridViewTextBoxColumn.DataPropertyName = "dosis_diaria";
            this.dosisdiariaDataGridViewTextBoxColumn.HeaderText = "dosis_diaria";
            this.dosisdiariaDataGridViewTextBoxColumn.Name = "dosisdiariaDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // FormVeterinarioConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 601);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_doc);
            this.Controls.Add(this.listBox_addTratamiento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_anular);
            this.Controls.Add(this.button_realizar);
            this.Controls.Add(this.textBox_cliente);
            this.Controls.Add(this.textBox_mascota);
            this.Controls.Add(this.groupBox_ficha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_tratamientos);
            this.Controls.Add(this.text_lugar);
            this.Controls.Add(this.label_lugar);
            this.Controls.Add(this.text_diagnostico);
            this.Controls.Add(this.label_diagnostico);
            this.Controls.Add(this.text_motivo);
            this.Controls.Add(this.label_motivo);
            this.Controls.Add(this.text_fecha);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.text_hora);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.log_type);
            this.Controls.Add(this.log_name);
            this.Controls.Add(this.log_photo);
            this.Name = "FormVeterinarioConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaVeterinario";
            this.Load += new System.EventHandler(this.FormConsultaVeterinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_ficha.ResumeLayout(false);
            this.groupBox_ficha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_inicio_veterinario)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_consulta_veterinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_desconectar_veterinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionVeterinariaGenNHibernateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionVeterinariaGenNHibernateDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label log_type;
        public System.Windows.Forms.Label log_name;
        public System.Windows.Forms.PictureBox log_photo;
        private System.Windows.Forms.TextBox text_hora;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.TextBox text_fecha;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_motivo;
        private System.Windows.Forms.Label label_diagnostico;
        private System.Windows.Forms.Label label_lugar;
        private System.Windows.Forms.Label label_tratamientos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_ficha;
        private System.Windows.Forms.Label label_raza;
        private System.Windows.Forms.Label label_peso;
        private System.Windows.Forms.Label label_especie;
        private System.Windows.Forms.Label label_fn;
        private System.Windows.Forms.Label label_microchip;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.Label label_tamaño;
        private System.Windows.Forms.Label label_sexo;
        private System.Windows.Forms.Button button_realizar;
        private System.Windows.Forms.Button button_anular;
        private System.Windows.Forms.PictureBox picture_inicio_veterinario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture_consulta_veterinario;
        private System.Windows.Forms.PictureBox picture_desconectar_veterinario;
        public System.Windows.Forms.TextBox textBox_peso;
        public System.Windows.Forms.TextBox textBox_sexo;
        public System.Windows.Forms.TextBox textBox_tam;
        public System.Windows.Forms.TextBox textBox_raza;
        public System.Windows.Forms.TextBox textBox_especie;
        public System.Windows.Forms.TextBox textBox_fn;
        public System.Windows.Forms.TextBox textBox_mascota;
        public System.Windows.Forms.TextBox textBox_cliente;
        public System.Windows.Forms.TextBox textBox_chip;
        public System.Windows.Forms.TextBox textBox_color;
        public System.Windows.Forms.TextBox text_motivo;
        public System.Windows.Forms.TextBox text_diagnostico;
        public System.Windows.Forms.TextBox text_lugar;
        public System.Windows.Forms.ListBox listBox_addTratamiento;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_del;
        public System.Windows.Forms.Label label_doc;
        private GestionVeterinariaGenNHibernateDataSet gestionVeterinariaGenNHibernateDataSet;
        private System.Windows.Forms.BindingSource tratamientoBindingSource;
        private GestionVeterinariaGenNHibernateDataSetTableAdapters.TratamientoTableAdapter tratamientoTableAdapter;
        private GestionVeterinariaGenNHibernateDataSet1 gestionVeterinariaGenNHibernateDataSet1;
        private System.Windows.Forms.BindingSource tratamientoBindingSource1;
        private GestionVeterinariaGenNHibernateDataSet1TableAdapters.TratamientoTableAdapter tratamientoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosisdiariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
    }
}