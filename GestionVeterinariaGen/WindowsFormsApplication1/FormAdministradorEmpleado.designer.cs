namespace WindowsFormsApplication1
{
    partial class FormAdministradorEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministradorEmpleado));
            this.log_photo = new System.Windows.Forms.PictureBox();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apellidos = new System.Windows.Forms.TextBox();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_localidad = new System.Windows.Forms.TextBox();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_sueldo = new System.Windows.Forms.TextBox();
            this.tb_provincia = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_top = new System.Windows.Forms.Panel();
            this.picture_desconectar_admin = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tipo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.btn_erase = new System.Windows.Forms.PictureBox();
            this.btn_buscar_dni = new System.Windows.Forms.PictureBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.alerta_eliminar = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_eliminar_no = new System.Windows.Forms.Button();
            this.btn_eliminar_si = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label_col = new System.Windows.Forms.Label();
            this.tb_colegiado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_desconectar_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_erase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_dni)).BeginInit();
            this.alerta_eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // log_photo
            // 
            this.log_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_photo.ErrorImage = null;
            this.log_photo.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.log_photo.InitialImage = null;
            this.log_photo.Location = new System.Drawing.Point(25, 57);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(94, 120);
            this.log_photo.TabIndex = 3;
            this.log_photo.TabStop = false;
            this.log_photo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tb_dni
            // 
            this.tb_dni.Location = new System.Drawing.Point(218, 70);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(163, 20);
            this.tb_dni.TabIndex = 5;
            this.tb_dni.TextChanged += new System.EventHandler(this.tb_dni_TextChanged);
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(218, 106);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(163, 20);
            this.tb_nombre.TabIndex = 6;
            // 
            // tb_apellidos
            // 
            this.tb_apellidos.Location = new System.Drawing.Point(134, 207);
            this.tb_apellidos.Name = "tb_apellidos";
            this.tb_apellidos.Size = new System.Drawing.Size(247, 20);
            this.tb_apellidos.TabIndex = 7;
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(134, 285);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(247, 20);
            this.tb_direccion.TabIndex = 8;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(218, 329);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(163, 20);
            this.tb_tel.TabIndex = 9;
            // 
            // tb_localidad
            // 
            this.tb_localidad.Location = new System.Drawing.Point(218, 360);
            this.tb_localidad.Name = "tb_localidad";
            this.tb_localidad.Size = new System.Drawing.Size(163, 20);
            this.tb_localidad.TabIndex = 10;
            // 
            // tb_cp
            // 
            this.tb_cp.Location = new System.Drawing.Point(218, 426);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.Size = new System.Drawing.Size(163, 20);
            this.tb_cp.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Localidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Provincia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "CP:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(29, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Sueldo:";
            // 
            // tb_sueldo
            // 
            this.tb_sueldo.Location = new System.Drawing.Point(218, 245);
            this.tb_sueldo.Name = "tb_sueldo";
            this.tb_sueldo.Size = new System.Drawing.Size(163, 20);
            this.tb_sueldo.TabIndex = 21;
            // 
            // tb_provincia
            // 
            this.tb_provincia.FormattingEnabled = true;
            this.tb_provincia.Items.AddRange(new object[] {
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
            this.tb_provincia.Location = new System.Drawing.Point(218, 395);
            this.tb_provincia.Name = "tb_provincia";
            this.tb_provincia.Size = new System.Drawing.Size(163, 21);
            this.tb_provincia.TabIndex = 51;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Transparent;
            this.panel_top.Controls.Add(this.picture_desconectar_admin);
            this.panel_top.Controls.Add(this.pictureBox3);
            this.panel_top.Controls.Add(this.pictureBox1);
            this.panel_top.Controls.Add(this.pictureBox2);
            this.panel_top.Location = new System.Drawing.Point(-2, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(676, 34);
            this.panel_top.TabIndex = 56;
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
            this.picture_desconectar_admin.Click += new System.EventHandler(this.picture_desconectar_admin_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tipo:";
            // 
            // tb_tipo
            // 
            this.tb_tipo.FormattingEnabled = true;
            this.tb_tipo.Items.AddRange(new object[] {
            "Veterinario",
            "Recepcionista"});
            this.tb_tipo.Location = new System.Drawing.Point(489, 143);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.Size = new System.Drawing.Size(163, 21);
            this.tb_tipo.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 60;
            this.label10.Text = "Password:";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(218, 144);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(163, 20);
            this.tb_pass.TabIndex = 59;
            // 
            // btn_erase
            // 
            this.btn_erase.BackColor = System.Drawing.Color.Transparent;
            this.btn_erase.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.eraser;
            this.btn_erase.Location = new System.Drawing.Point(411, 74);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(16, 16);
            this.btn_erase.TabIndex = 82;
            this.btn_erase.TabStop = false;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // btn_buscar_dni
            // 
            this.btn_buscar_dni.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar_dni.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.btn_buscar_id;
            this.btn_buscar_dni.Location = new System.Drawing.Point(389, 74);
            this.btn_buscar_dni.Name = "btn_buscar_dni";
            this.btn_buscar_dni.Size = new System.Drawing.Size(16, 16);
            this.btn_buscar_dni.TabIndex = 81;
            this.btn_buscar_dni.TabStop = false;
            this.btn_buscar_dni.Click += new System.EventHandler(this.btn_buscar_dni_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(577, 422);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 83;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // alerta_eliminar
            // 
            this.alerta_eliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alerta_eliminar.Controls.Add(this.label12);
            this.alerta_eliminar.Controls.Add(this.btn_eliminar_no);
            this.alerta_eliminar.Controls.Add(this.btn_eliminar_si);
            this.alerta_eliminar.Location = new System.Drawing.Point(439, 301);
            this.alerta_eliminar.Name = "alerta_eliminar";
            this.alerta_eliminar.Size = new System.Drawing.Size(200, 67);
            this.alerta_eliminar.TabIndex = 84;
            this.alerta_eliminar.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "¿Eliminar Empleado?";
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
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(577, 393);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 78;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label_col
            // 
            this.label_col.AutoSize = true;
            this.label_col.BackColor = System.Drawing.Color.Transparent;
            this.label_col.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_col.Location = new System.Drawing.Point(414, 189);
            this.label_col.Name = "label_col";
            this.label_col.Size = new System.Drawing.Size(105, 16);
            this.label_col.TabIndex = 86;
            this.label_col.Text = "Nº Colegiado:";
            // 
            // tb_colegiado
            // 
            this.tb_colegiado.Location = new System.Drawing.Point(533, 188);
            this.tb_colegiado.Name = "tb_colegiado";
            this.tb_colegiado.Size = new System.Drawing.Size(119, 20);
            this.tb_colegiado.TabIndex = 85;
            // 
            // FormAdministradorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fondo_nuevo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 471);
            this.Controls.Add(this.label_col);
            this.Controls.Add(this.tb_colegiado);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.alerta_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.btn_buscar_dni);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_provincia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_sueldo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cp);
            this.Controls.Add(this.tb_localidad);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_direccion);
            this.Controls.Add(this.tb_apellidos);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.log_photo);
            this.Controls.Add(this.panel_top);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdministradorEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_desconectar_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_erase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar_dni)).EndInit();
            this.alerta_eliminar.ResumeLayout(false);
            this.alerta_eliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox log_photo;
        public System.Windows.Forms.TextBox tb_dni;
        public System.Windows.Forms.TextBox tb_nombre;
        public System.Windows.Forms.TextBox tb_apellidos;
        public System.Windows.Forms.TextBox tb_direccion;
        public System.Windows.Forms.TextBox tb_tel;
        public System.Windows.Forms.TextBox tb_localidad;
        public System.Windows.Forms.TextBox tb_cp;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tb_sueldo;
        public System.Windows.Forms.ComboBox tb_provincia;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox tb_tipo;
        private System.Windows.Forms.PictureBox picture_desconectar_admin;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tb_pass;
        public System.Windows.Forms.PictureBox btn_erase;
        public System.Windows.Forms.PictureBox btn_buscar_dni;
        private System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.Panel alerta_eliminar;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btn_eliminar_no;
        public System.Windows.Forms.Button btn_eliminar_si;
        private System.Windows.Forms.Button btn_eliminar;
        public System.Windows.Forms.Label label_col;
        public System.Windows.Forms.TextBox tb_colegiado;
    }
}