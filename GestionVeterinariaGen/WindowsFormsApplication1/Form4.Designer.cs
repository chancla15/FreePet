namespace WindowsFormsApplication1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_id = new System.Windows.Forms.TextBox();
            this.m_nombre = new System.Windows.Forms.TextBox();
            this.m_raza = new System.Windows.Forms.TextBox();
            this.m_especie = new System.Windows.Forms.TextBox();
            this.m_color = new System.Windows.Forms.TextBox();
            this.M_clienteDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.m_peso = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.m_sexo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.err_add = new System.Windows.Forms.Label();
            this.err_tel = new System.Windows.Forms.Label();
            this.err_direccion = new System.Windows.Forms.Label();
            this.err_nom = new System.Windows.Forms.Label();
            this.err_dni = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.tb_localidad = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.tb_apellidos = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.m_clienteNombre = new System.Windows.Forms.TextBox();
            this.m_fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "ACEPTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 534);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 120);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "MASCOTAS";
            // 
            // m_id
            // 
            this.m_id.Location = new System.Drawing.Point(231, 144);
            this.m_id.Name = "m_id";
            this.m_id.Size = new System.Drawing.Size(163, 20);
            this.m_id.TabIndex = 5;
            // 
            // m_nombre
            // 
            this.m_nombre.Location = new System.Drawing.Point(231, 173);
            this.m_nombre.Name = "m_nombre";
            this.m_nombre.Size = new System.Drawing.Size(163, 20);
            this.m_nombre.TabIndex = 6;
            // 
            // m_raza
            // 
            this.m_raza.Location = new System.Drawing.Point(147, 209);
            this.m_raza.Name = "m_raza";
            this.m_raza.Size = new System.Drawing.Size(247, 20);
            this.m_raza.TabIndex = 7;
            // 
            // m_especie
            // 
            this.m_especie.Location = new System.Drawing.Point(147, 333);
            this.m_especie.Name = "m_especie";
            this.m_especie.Size = new System.Drawing.Size(247, 20);
            this.m_especie.TabIndex = 8;
            // 
            // m_color
            // 
            this.m_color.Location = new System.Drawing.Point(231, 394);
            this.m_color.Name = "m_color";
            this.m_color.Size = new System.Drawing.Size(163, 20);
            this.m_color.TabIndex = 10;
            // 
            // M_clienteDNI
            // 
            this.M_clienteDNI.Location = new System.Drawing.Point(231, 460);
            this.M_clienteDNI.Name = "M_clienteDNI";
            this.M_clienteDNI.Size = new System.Drawing.Size(163, 20);
            this.M_clienteDNI.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Raza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Especie:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tamaño:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Color:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "MicroChip:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(42, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cliente DNI:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(42, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Peso:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(42, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Sexo:";
            // 
            // m_peso
            // 
            this.m_peso.Location = new System.Drawing.Point(231, 275);
            this.m_peso.Name = "m_peso";
            this.m_peso.Size = new System.Drawing.Size(163, 20);
            this.m_peso.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(42, 503);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 25;
            // 
            // m_sexo
            // 
            this.m_sexo.FormattingEnabled = true;
            this.m_sexo.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.m_sexo.Location = new System.Drawing.Point(231, 243);
            this.m_sexo.Name = "m_sexo";
            this.m_sexo.Size = new System.Drawing.Size(163, 21);
            this.m_sexo.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(849, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 86;
            this.label15.Text = "*";
            this.label15.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Álava",
            "Albacete",
            "Alicante",
            "Almería",
            "Asturias",
            "Ávila",
            "Badajoz",
            "Barcelona",
            "Burgos",
            "Cáceres",
            "Cádiz",
            "Cantabria",
            "Castellón",
            "Ciudad Real",
            "Córdoba",
            "La Coruña",
            "Cuenca",
            "Gerona",
            "Granada",
            "Guadalajara",
            "Guipúzcoa",
            "Huelva",
            "Huesca",
            "Islas Baleares",
            "Jaén",
            "León",
            "Lérida",
            "Lugo",
            "Madrid",
            "Málaga",
            "Murcia",
            "Navarra",
            "Orense",
            "Palencia",
            "Las Palmas",
            "Pontevedra",
            "La Rioja",
            "Salamanca",
            "Segovia",
            "Sevilla",
            "Soria",
            "Tarragona",
            "Santa Cruz de Tenerife",
            "Teruel",
            "Toledo",
            "Valencia",
            "Valladolid",
            "Vizcaya",
            "Zamora",
            "Zaragoza"});
            this.comboBox2.Location = new System.Drawing.Point(680, 345);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 21);
            this.comboBox2.TabIndex = 85;
            // 
            // err_add
            // 
            this.err_add.AutoSize = true;
            this.err_add.BackColor = System.Drawing.Color.Transparent;
            this.err_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_add.ForeColor = System.Drawing.Color.Red;
            this.err_add.Location = new System.Drawing.Point(492, 499);
            this.err_add.Name = "err_add";
            this.err_add.Size = new System.Drawing.Size(225, 16);
            this.err_add.TabIndex = 84;
            this.err_add.Text = "*Error al Añadir Recepcionista";
            this.err_add.Visible = false;
            // 
            // err_tel
            // 
            this.err_tel.AutoSize = true;
            this.err_tel.BackColor = System.Drawing.Color.Transparent;
            this.err_tel.ForeColor = System.Drawing.Color.Red;
            this.err_tel.Location = new System.Drawing.Point(849, 319);
            this.err_tel.Name = "err_tel";
            this.err_tel.Size = new System.Drawing.Size(11, 13);
            this.err_tel.TabIndex = 83;
            this.err_tel.Text = "*";
            this.err_tel.Visible = false;
            // 
            // err_direccion
            // 
            this.err_direccion.AutoSize = true;
            this.err_direccion.BackColor = System.Drawing.Color.Transparent;
            this.err_direccion.ForeColor = System.Drawing.Color.Red;
            this.err_direccion.Location = new System.Drawing.Point(849, 280);
            this.err_direccion.Name = "err_direccion";
            this.err_direccion.Size = new System.Drawing.Size(11, 13);
            this.err_direccion.TabIndex = 81;
            this.err_direccion.Text = "*";
            this.err_direccion.Visible = false;
            // 
            // err_nom
            // 
            this.err_nom.AutoSize = true;
            this.err_nom.BackColor = System.Drawing.Color.Transparent;
            this.err_nom.ForeColor = System.Drawing.Color.Red;
            this.err_nom.Location = new System.Drawing.Point(849, 216);
            this.err_nom.Name = "err_nom";
            this.err_nom.Size = new System.Drawing.Size(11, 13);
            this.err_nom.TabIndex = 78;
            this.err_nom.Text = "*";
            this.err_nom.Visible = false;
            // 
            // err_dni
            // 
            this.err_dni.AutoSize = true;
            this.err_dni.BackColor = System.Drawing.Color.Transparent;
            this.err_dni.ForeColor = System.Drawing.Color.Red;
            this.err_dni.Location = new System.Drawing.Point(849, 190);
            this.err_dni.Name = "err_dni";
            this.err_dni.Size = new System.Drawing.Size(11, 13);
            this.err_dni.TabIndex = 77;
            this.err_dni.Text = "*";
            this.err_dni.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(492, 402);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 16);
            this.label19.TabIndex = 70;
            this.label19.Text = "CP:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(491, 350);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 16);
            this.label20.TabIndex = 69;
            this.label20.Text = "Provincia:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(491, 376);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 16);
            this.label21.TabIndex = 68;
            this.label21.Text = "Localidad:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(491, 323);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 16);
            this.label22.TabIndex = 67;
            this.label22.Text = "Teléfono:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(491, 284);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 16);
            this.label23.TabIndex = 66;
            this.label23.Text = "Dirección:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.Control;
            this.label24.Location = new System.Drawing.Point(491, 246);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 16);
            this.label24.TabIndex = 65;
            this.label24.Text = "Apellidos:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(491, 220);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 16);
            this.label25.TabIndex = 64;
            this.label25.Text = "Nombre:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(490, 190);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 16);
            this.label26.TabIndex = 63;
            this.label26.Text = "DNI:";
            // 
            // tb_cp
            // 
            this.tb_cp.Location = new System.Drawing.Point(680, 398);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.Size = new System.Drawing.Size(163, 20);
            this.tb_cp.TabIndex = 62;
            // 
            // tb_localidad
            // 
            this.tb_localidad.Location = new System.Drawing.Point(680, 372);
            this.tb_localidad.Name = "tb_localidad";
            this.tb_localidad.Size = new System.Drawing.Size(163, 20);
            this.tb_localidad.TabIndex = 61;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(680, 319);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(163, 20);
            this.tb_tel.TabIndex = 60;
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(614, 280);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(229, 20);
            this.tb_direccion.TabIndex = 59;
            // 
            // tb_apellidos
            // 
            this.tb_apellidos.Location = new System.Drawing.Point(614, 242);
            this.tb_apellidos.Name = "tb_apellidos";
            this.tb_apellidos.Size = new System.Drawing.Size(229, 20);
            this.tb_apellidos.TabIndex = 58;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(680, 216);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(163, 20);
            this.tb_nombre.TabIndex = 57;
            // 
            // tb_dni
            // 
            this.tb_dni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_dni.Location = new System.Drawing.Point(680, 190);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(163, 20);
            this.tb_dni.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(747, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 24);
            this.label13.TabIndex = 87;
            this.label13.Text = "CLIENTE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(495, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 120);
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(42, 498);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 16);
            this.label14.TabIndex = 90;
            this.label14.Text = "Cliente Nombre:";
            // 
            // m_clienteNombre
            // 
            this.m_clienteNombre.Location = new System.Drawing.Point(231, 494);
            this.m_clienteNombre.Name = "m_clienteNombre";
            this.m_clienteNombre.Size = new System.Drawing.Size(163, 20);
            this.m_clienteNombre.TabIndex = 89;
            // 
            // m_fecha_nac
            // 
            this.m_fecha_nac.Location = new System.Drawing.Point(194, 301);
            this.m_fecha_nac.Name = "m_fecha_nac";
            this.m_fecha_nac.Size = new System.Drawing.Size(200, 20);
            this.m_fecha_nac.TabIndex = 91;
            this.m_fecha_nac.Value = new System.DateTime(2014, 4, 4, 0, 0, 0, 0);
            this.m_fecha_nac.ValueChanged += new System.EventHandler(this.m_fecha_nac_ValueChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(42, 305);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(141, 16);
            this.label30.TabIndex = 92;
            this.label30.Text = "Fecha Nacimiento:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-16, -16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 93;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.comboBox1.Location = new System.Drawing.Point(272, 428);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 94;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL"});
            this.comboBox3.Location = new System.Drawing.Point(272, 363);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 95;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 580);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.m_fecha_nac);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.m_clienteNombre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.err_add);
            this.Controls.Add(this.err_tel);
            this.Controls.Add(this.err_direccion);
            this.Controls.Add(this.err_nom);
            this.Controls.Add(this.err_dni);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.tb_cp);
            this.Controls.Add(this.tb_localidad);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_direccion);
            this.Controls.Add(this.tb_apellidos);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.m_sexo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.m_peso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.M_clienteDNI);
            this.Controls.Add(this.m_color);
            this.Controls.Add(this.m_especie);
            this.Controls.Add(this.m_raza);
            this.Controls.Add(this.m_nombre);
            this.Controls.Add(this.m_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_id;
        private System.Windows.Forms.TextBox m_nombre;
        private System.Windows.Forms.TextBox m_raza;
        private System.Windows.Forms.TextBox m_especie;
        private System.Windows.Forms.TextBox m_color;
        private System.Windows.Forms.TextBox M_clienteDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox m_peso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox m_sexo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label err_add;
        private System.Windows.Forms.Label err_tel;
        private System.Windows.Forms.Label err_direccion;
        private System.Windows.Forms.Label err_nom;
        private System.Windows.Forms.Label err_dni;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.TextBox tb_localidad;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_direccion;
        private System.Windows.Forms.TextBox tb_apellidos;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_dni;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox m_clienteNombre;
        private System.Windows.Forms.DateTimePicker m_fecha_nac;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}