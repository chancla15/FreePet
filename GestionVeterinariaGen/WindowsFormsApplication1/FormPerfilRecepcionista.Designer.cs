namespace WindowsFormsApplication1
{
    partial class FormPerfilRecepcionista
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.text_dni = new System.Windows.Forms.TextBox();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.text_apellidos = new System.Windows.Forms.TextBox();
            this.text_direccion = new System.Windows.Forms.TextBox();
            this.text_telefono = new System.Windows.Forms.TextBox();
            this.text_localidad = new System.Windows.Forms.TextBox();
            this.text_cp = new System.Windows.Forms.TextBox();
            this.label_dni = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellidos = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.label_localidad = new System.Windows.Forms.Label();
            this.label_provincia = new System.Windows.Forms.Label();
            this.label_cp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.error_dni = new System.Windows.Forms.Label();
            this.error_nombre = new System.Windows.Forms.Label();
            this.error_direccion = new System.Windows.Forms.Label();
            this.error_telefono = new System.Windows.Forms.Label();
            this.err_anaydir = new System.Windows.Forms.Label();
            this.combo_provincia = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.error_apellidos = new System.Windows.Forms.Label();
            this.bt_despedir = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.bt_modificar_cliente = new System.Windows.Forms.Button();
            this.bt_eliminar_cliente = new System.Windows.Forms.Button();
            this.bt_anyadir_cliente = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(590, 275);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // text_dni
            // 
            this.text_dni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_dni.Location = new System.Drawing.Point(231, 50);
            this.text_dni.Name = "text_dni";
            this.text_dni.Size = new System.Drawing.Size(163, 20);
            this.text_dni.TabIndex = 5;
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(231, 77);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(163, 20);
            this.text_nombre.TabIndex = 6;
            // 
            // text_apellidos
            // 
            this.text_apellidos.Location = new System.Drawing.Point(231, 103);
            this.text_apellidos.Name = "text_apellidos";
            this.text_apellidos.Size = new System.Drawing.Size(163, 20);
            this.text_apellidos.TabIndex = 7;
            // 
            // text_direccion
            // 
            this.text_direccion.Location = new System.Drawing.Point(96, 157);
            this.text_direccion.Name = "text_direccion";
            this.text_direccion.Size = new System.Drawing.Size(211, 20);
            this.text_direccion.TabIndex = 8;
            // 
            // text_telefono
            // 
            this.text_telefono.Location = new System.Drawing.Point(96, 195);
            this.text_telefono.Name = "text_telefono";
            this.text_telefono.Size = new System.Drawing.Size(154, 20);
            this.text_telefono.TabIndex = 9;
            // 
            // text_localidad
            // 
            this.text_localidad.Location = new System.Drawing.Point(590, 154);
            this.text_localidad.Name = "text_localidad";
            this.text_localidad.Size = new System.Drawing.Size(86, 20);
            this.text_localidad.TabIndex = 11;
            // 
            // text_cp
            // 
            this.text_cp.Location = new System.Drawing.Point(590, 192);
            this.text_cp.Name = "text_cp";
            this.text_cp.Size = new System.Drawing.Size(86, 20);
            this.text_cp.TabIndex = 12;
            // 
            // label_dni
            // 
            this.label_dni.AutoSize = true;
            this.label_dni.BackColor = System.Drawing.Color.Transparent;
            this.label_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dni.Location = new System.Drawing.Point(144, 51);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(38, 16);
            this.label_dni.TabIndex = 13;
            this.label_dni.Text = "DNI:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.BackColor = System.Drawing.Color.Transparent;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(145, 81);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(67, 16);
            this.label_nombre.TabIndex = 14;
            this.label_nombre.Text = "Nombre:";
            // 
            // label_apellidos
            // 
            this.label_apellidos.AutoSize = true;
            this.label_apellidos.BackColor = System.Drawing.Color.Transparent;
            this.label_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_apellidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_apellidos.Location = new System.Drawing.Point(145, 107);
            this.label_apellidos.Name = "label_apellidos";
            this.label_apellidos.Size = new System.Drawing.Size(78, 16);
            this.label_apellidos.TabIndex = 15;
            this.label_apellidos.Text = "Apellidos:";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.BackColor = System.Drawing.Color.Transparent;
            this.label_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_direccion.ForeColor = System.Drawing.Color.White;
            this.label_direccion.Location = new System.Drawing.Point(12, 160);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(78, 16);
            this.label_direccion.TabIndex = 16;
            this.label_direccion.Text = "Dirección:";
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.BackColor = System.Drawing.Color.Transparent;
            this.label_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telefono.ForeColor = System.Drawing.Color.White;
            this.label_telefono.Location = new System.Drawing.Point(12, 198);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(74, 16);
            this.label_telefono.TabIndex = 17;
            this.label_telefono.Text = "Teléfono:";
            // 
            // label_localidad
            // 
            this.label_localidad.AutoSize = true;
            this.label_localidad.BackColor = System.Drawing.Color.Transparent;
            this.label_localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_localidad.ForeColor = System.Drawing.Color.White;
            this.label_localidad.Location = new System.Drawing.Point(503, 158);
            this.label_localidad.Name = "label_localidad";
            this.label_localidad.Size = new System.Drawing.Size(81, 16);
            this.label_localidad.TabIndex = 18;
            this.label_localidad.Text = "Localidad:";
            // 
            // label_provincia
            // 
            this.label_provincia.AutoSize = true;
            this.label_provincia.BackColor = System.Drawing.Color.Transparent;
            this.label_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_provincia.ForeColor = System.Drawing.Color.White;
            this.label_provincia.Location = new System.Drawing.Point(313, 160);
            this.label_provincia.Name = "label_provincia";
            this.label_provincia.Size = new System.Drawing.Size(77, 16);
            this.label_provincia.TabIndex = 19;
            this.label_provincia.Text = "Provincia:";
            // 
            // label_cp
            // 
            this.label_cp.AutoSize = true;
            this.label_cp.BackColor = System.Drawing.Color.Transparent;
            this.label_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cp.ForeColor = System.Drawing.Color.White;
            this.label_cp.Location = new System.Drawing.Point(535, 196);
            this.label_cp.Name = "label_cp";
            this.label_cp.Size = new System.Drawing.Size(32, 16);
            this.label_cp.TabIndex = 20;
            this.label_cp.Text = "CP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(42, 597);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 25;
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(221, 275);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_aceptar.TabIndex = 27;
            this.bt_aceptar.Text = "ACEPTAR";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.button5_Click);
            // 
            // error_dni
            // 
            this.error_dni.AutoSize = true;
            this.error_dni.BackColor = System.Drawing.Color.Transparent;
            this.error_dni.ForeColor = System.Drawing.Color.Red;
            this.error_dni.Location = new System.Drawing.Point(400, 53);
            this.error_dni.Name = "error_dni";
            this.error_dni.Size = new System.Drawing.Size(11, 13);
            this.error_dni.TabIndex = 34;
            this.error_dni.Text = "*";
            this.error_dni.Visible = false;
            // 
            // error_nombre
            // 
            this.error_nombre.AutoSize = true;
            this.error_nombre.BackColor = System.Drawing.Color.Transparent;
            this.error_nombre.ForeColor = System.Drawing.Color.Red;
            this.error_nombre.Location = new System.Drawing.Point(400, 77);
            this.error_nombre.Name = "error_nombre";
            this.error_nombre.Size = new System.Drawing.Size(11, 13);
            this.error_nombre.TabIndex = 40;
            this.error_nombre.Text = "*";
            this.error_nombre.Visible = false;
            // 
            // error_direccion
            // 
            this.error_direccion.AutoSize = true;
            this.error_direccion.BackColor = System.Drawing.Color.Transparent;
            this.error_direccion.ForeColor = System.Drawing.Color.Red;
            this.error_direccion.Location = new System.Drawing.Point(93, 180);
            this.error_direccion.Name = "error_direccion";
            this.error_direccion.Size = new System.Drawing.Size(11, 13);
            this.error_direccion.TabIndex = 44;
            this.error_direccion.Text = "*";
            this.error_direccion.Visible = false;
            // 
            // error_telefono
            // 
            this.error_telefono.AutoSize = true;
            this.error_telefono.BackColor = System.Drawing.Color.Transparent;
            this.error_telefono.ForeColor = System.Drawing.Color.Red;
            this.error_telefono.Location = new System.Drawing.Point(93, 218);
            this.error_telefono.Name = "error_telefono";
            this.error_telefono.Size = new System.Drawing.Size(11, 13);
            this.error_telefono.TabIndex = 46;
            this.error_telefono.Text = "*";
            this.error_telefono.Visible = false;
            // 
            // err_anaydir
            // 
            this.err_anaydir.AutoSize = true;
            this.err_anaydir.BackColor = System.Drawing.Color.Transparent;
            this.err_anaydir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_anaydir.ForeColor = System.Drawing.Color.Red;
            this.err_anaydir.Location = new System.Drawing.Point(23, 247);
            this.err_anaydir.Name = "err_anaydir";
            this.err_anaydir.Size = new System.Drawing.Size(218, 16);
            this.err_anaydir.TabIndex = 48;
            this.err_anaydir.Text = "*Error al Añadir Recepcionista";
            this.err_anaydir.Visible = false;
            // 
            // combo_provincia
            // 
            this.combo_provincia.FormattingEnabled = true;
            this.combo_provincia.Items.AddRange(new object[] {
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
            this.combo_provincia.Location = new System.Drawing.Point(396, 155);
            this.combo_provincia.Name = "combo_provincia";
            this.combo_provincia.Size = new System.Drawing.Size(96, 21);
            this.combo_provincia.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(26, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 120);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // error_apellidos
            // 
            this.error_apellidos.AutoSize = true;
            this.error_apellidos.BackColor = System.Drawing.Color.Transparent;
            this.error_apellidos.ForeColor = System.Drawing.Color.Red;
            this.error_apellidos.Location = new System.Drawing.Point(400, 103);
            this.error_apellidos.Name = "error_apellidos";
            this.error_apellidos.Size = new System.Drawing.Size(11, 13);
            this.error_apellidos.TabIndex = 52;
            this.error_apellidos.Text = "*";
            this.error_apellidos.Visible = false;
            // 
            // bt_despedir
            // 
            this.bt_despedir.Location = new System.Drawing.Point(313, 275);
            this.bt_despedir.Name = "bt_despedir";
            this.bt_despedir.Size = new System.Drawing.Size(75, 23);
            this.bt_despedir.TabIndex = 56;
            this.bt_despedir.Text = "DESPEDIR";
            this.bt_despedir.UseVisualStyleBackColor = true;
            this.bt_despedir.Click += new System.EventHandler(this.bt_despedir_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.Location = new System.Drawing.Point(29, 275);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(75, 23);
            this.bt_modificar.TabIndex = 57;
            this.bt_modificar.Text = "MODIFICAR";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // bt_modificar_cliente
            // 
            this.bt_modificar_cliente.Location = new System.Drawing.Point(492, 275);
            this.bt_modificar_cliente.Name = "bt_modificar_cliente";
            this.bt_modificar_cliente.Size = new System.Drawing.Size(75, 23);
            this.bt_modificar_cliente.TabIndex = 58;
            this.bt_modificar_cliente.Text = "MODIFICAR";
            this.bt_modificar_cliente.UseVisualStyleBackColor = true;
            this.bt_modificar_cliente.Click += new System.EventHandler(this.bt_modificar_cliente_Click);
            // 
            // bt_eliminar_cliente
            // 
            this.bt_eliminar_cliente.Location = new System.Drawing.Point(127, 275);
            this.bt_eliminar_cliente.Name = "bt_eliminar_cliente";
            this.bt_eliminar_cliente.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar_cliente.TabIndex = 59;
            this.bt_eliminar_cliente.Text = "ELIMINAR";
            this.bt_eliminar_cliente.UseVisualStyleBackColor = true;
            this.bt_eliminar_cliente.Click += new System.EventHandler(this.bt_eliminar_cliente_Click_1);
            // 
            // bt_anyadir_cliente
            // 
            this.bt_anyadir_cliente.Location = new System.Drawing.Point(403, 275);
            this.bt_anyadir_cliente.Name = "bt_anyadir_cliente";
            this.bt_anyadir_cliente.Size = new System.Drawing.Size(75, 23);
            this.bt_anyadir_cliente.TabIndex = 60;
            this.bt_anyadir_cliente.Text = "ACEPTAR";
            this.bt_anyadir_cliente.UseVisualStyleBackColor = true;
            this.bt_anyadir_cliente.Click += new System.EventHandler(this.bt_anyadir_cliente_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(313, 194);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(193, 20);
            this.text_email.TabIndex = 62;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Transparent;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.White;
            this.label_email.Location = new System.Drawing.Point(256, 196);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(51, 16);
            this.label_email.TabIndex = 63;
            this.label_email.Text = "Email:";
            // 
            // FormPerfilRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 508);
            this.ControlBox = false;
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.error_apellidos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combo_provincia);
            this.Controls.Add(this.err_anaydir);
            this.Controls.Add(this.error_telefono);
            this.Controls.Add(this.error_direccion);
            this.Controls.Add(this.error_nombre);
            this.Controls.Add(this.error_dni);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_cp);
            this.Controls.Add(this.label_provincia);
            this.Controls.Add(this.label_localidad);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.label_apellidos);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_dni);
            this.Controls.Add(this.text_cp);
            this.Controls.Add(this.text_localidad);
            this.Controls.Add(this.text_telefono);
            this.Controls.Add(this.text_direccion);
            this.Controls.Add(this.text_apellidos);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.text_dni);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.bt_modificar_cliente);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_anyadir_cliente);
            this.Controls.Add(this.bt_eliminar_cliente);
            this.Controls.Add(this.bt_despedir);
            this.Controls.Add(this.bt_aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPerfilRecepcionista";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAddEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_salir;
        public System.Windows.Forms.TextBox text_dni;
        public System.Windows.Forms.TextBox text_nombre;
        public System.Windows.Forms.TextBox text_apellidos;
        public System.Windows.Forms.TextBox text_direccion;
        public System.Windows.Forms.TextBox text_telefono;
        public System.Windows.Forms.TextBox text_localidad;
        public System.Windows.Forms.TextBox text_cp;
        public System.Windows.Forms.Label label_dni;
        public System.Windows.Forms.Label label_nombre;
        public System.Windows.Forms.Label label_apellidos;
        public System.Windows.Forms.Label label_direccion;
        public System.Windows.Forms.Label label_telefono;
        public System.Windows.Forms.Label label_localidad;
        public System.Windows.Forms.Label label_provincia;
        public System.Windows.Forms.Label label_cp;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button bt_aceptar;
        public System.Windows.Forms.Label error_dni;
        public System.Windows.Forms.Label error_nombre;
        public System.Windows.Forms.Label error_direccion;
        public System.Windows.Forms.Label error_telefono;
        public System.Windows.Forms.Label err_anaydir;
        public System.Windows.Forms.ComboBox combo_provincia;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label error_apellidos;
        public System.Windows.Forms.Button bt_despedir;
        public System.Windows.Forms.Button bt_modificar;
        public System.Windows.Forms.Button bt_modificar_cliente;
        public System.Windows.Forms.Button bt_eliminar_cliente;
        public System.Windows.Forms.Button bt_anyadir_cliente;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox text_email;
        public System.Windows.Forms.Label label_email;
    }
}