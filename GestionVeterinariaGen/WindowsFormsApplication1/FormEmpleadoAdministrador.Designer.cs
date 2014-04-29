namespace WindowsFormsApplication1
{
    partial class FormEmpleadoAdministrador
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
            this.label_email = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.error_apellidos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.combo_provincia = new System.Windows.Forms.ComboBox();
            this.error_telefono = new System.Windows.Forms.Label();
            this.error_direccion = new System.Windows.Forms.Label();
            this.error_nombre = new System.Windows.Forms.Label();
            this.error_dni = new System.Windows.Forms.Label();
            this.label_cp = new System.Windows.Forms.Label();
            this.label_provincia = new System.Windows.Forms.Label();
            this.label_localidad = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_apellidos = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_dni = new System.Windows.Forms.Label();
            this.text_cp = new System.Windows.Forms.TextBox();
            this.text_localidad = new System.Windows.Forms.TextBox();
            this.text_telefono = new System.Windows.Forms.TextBox();
            this.text_direccion = new System.Windows.Forms.TextBox();
            this.text_apellidos = new System.Windows.Forms.TextBox();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.text_dni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Transparent;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.White;
            this.label_email.Location = new System.Drawing.Point(252, 192);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(51, 16);
            this.label_email.TabIndex = 87;
            this.label_email.Text = "Email:";
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(309, 190);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(193, 20);
            this.text_email.TabIndex = 86;
            // 
            // error_apellidos
            // 
            this.error_apellidos.AutoSize = true;
            this.error_apellidos.BackColor = System.Drawing.Color.Transparent;
            this.error_apellidos.ForeColor = System.Drawing.Color.Red;
            this.error_apellidos.Location = new System.Drawing.Point(396, 99);
            this.error_apellidos.Name = "error_apellidos";
            this.error_apellidos.Size = new System.Drawing.Size(11, 13);
            this.error_apellidos.TabIndex = 85;
            this.error_apellidos.Text = "*";
            this.error_apellidos.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(22, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 120);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
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
            this.combo_provincia.Location = new System.Drawing.Point(392, 151);
            this.combo_provincia.Name = "combo_provincia";
            this.combo_provincia.Size = new System.Drawing.Size(96, 21);
            this.combo_provincia.TabIndex = 83;
            // 
            // error_telefono
            // 
            this.error_telefono.AutoSize = true;
            this.error_telefono.BackColor = System.Drawing.Color.Transparent;
            this.error_telefono.ForeColor = System.Drawing.Color.Red;
            this.error_telefono.Location = new System.Drawing.Point(89, 214);
            this.error_telefono.Name = "error_telefono";
            this.error_telefono.Size = new System.Drawing.Size(11, 13);
            this.error_telefono.TabIndex = 82;
            this.error_telefono.Text = "*";
            this.error_telefono.Visible = false;
            // 
            // error_direccion
            // 
            this.error_direccion.AutoSize = true;
            this.error_direccion.BackColor = System.Drawing.Color.Transparent;
            this.error_direccion.ForeColor = System.Drawing.Color.Red;
            this.error_direccion.Location = new System.Drawing.Point(89, 176);
            this.error_direccion.Name = "error_direccion";
            this.error_direccion.Size = new System.Drawing.Size(11, 13);
            this.error_direccion.TabIndex = 81;
            this.error_direccion.Text = "*";
            this.error_direccion.Visible = false;
            // 
            // error_nombre
            // 
            this.error_nombre.AutoSize = true;
            this.error_nombre.BackColor = System.Drawing.Color.Transparent;
            this.error_nombre.ForeColor = System.Drawing.Color.Red;
            this.error_nombre.Location = new System.Drawing.Point(396, 73);
            this.error_nombre.Name = "error_nombre";
            this.error_nombre.Size = new System.Drawing.Size(11, 13);
            this.error_nombre.TabIndex = 80;
            this.error_nombre.Text = "*";
            this.error_nombre.Visible = false;
            // 
            // error_dni
            // 
            this.error_dni.AutoSize = true;
            this.error_dni.BackColor = System.Drawing.Color.Transparent;
            this.error_dni.ForeColor = System.Drawing.Color.Red;
            this.error_dni.Location = new System.Drawing.Point(396, 49);
            this.error_dni.Name = "error_dni";
            this.error_dni.Size = new System.Drawing.Size(11, 13);
            this.error_dni.TabIndex = 79;
            this.error_dni.Text = "*";
            this.error_dni.Visible = false;
            // 
            // label_cp
            // 
            this.label_cp.AutoSize = true;
            this.label_cp.BackColor = System.Drawing.Color.Transparent;
            this.label_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cp.ForeColor = System.Drawing.Color.White;
            this.label_cp.Location = new System.Drawing.Point(531, 192);
            this.label_cp.Name = "label_cp";
            this.label_cp.Size = new System.Drawing.Size(32, 16);
            this.label_cp.TabIndex = 78;
            this.label_cp.Text = "CP:";
            // 
            // label_provincia
            // 
            this.label_provincia.AutoSize = true;
            this.label_provincia.BackColor = System.Drawing.Color.Transparent;
            this.label_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_provincia.ForeColor = System.Drawing.Color.White;
            this.label_provincia.Location = new System.Drawing.Point(309, 156);
            this.label_provincia.Name = "label_provincia";
            this.label_provincia.Size = new System.Drawing.Size(77, 16);
            this.label_provincia.TabIndex = 77;
            this.label_provincia.Text = "Provincia:";
            // 
            // label_localidad
            // 
            this.label_localidad.AutoSize = true;
            this.label_localidad.BackColor = System.Drawing.Color.Transparent;
            this.label_localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_localidad.ForeColor = System.Drawing.Color.White;
            this.label_localidad.Location = new System.Drawing.Point(499, 154);
            this.label_localidad.Name = "label_localidad";
            this.label_localidad.Size = new System.Drawing.Size(81, 16);
            this.label_localidad.TabIndex = 76;
            this.label_localidad.Text = "Localidad:";
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.BackColor = System.Drawing.Color.Transparent;
            this.label_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telefono.ForeColor = System.Drawing.Color.White;
            this.label_telefono.Location = new System.Drawing.Point(8, 194);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(74, 16);
            this.label_telefono.TabIndex = 75;
            this.label_telefono.Text = "Teléfono:";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.BackColor = System.Drawing.Color.Transparent;
            this.label_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_direccion.ForeColor = System.Drawing.Color.White;
            this.label_direccion.Location = new System.Drawing.Point(8, 156);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(78, 16);
            this.label_direccion.TabIndex = 74;
            this.label_direccion.Text = "Dirección:";
            // 
            // label_apellidos
            // 
            this.label_apellidos.AutoSize = true;
            this.label_apellidos.BackColor = System.Drawing.Color.Transparent;
            this.label_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_apellidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_apellidos.Location = new System.Drawing.Point(141, 103);
            this.label_apellidos.Name = "label_apellidos";
            this.label_apellidos.Size = new System.Drawing.Size(78, 16);
            this.label_apellidos.TabIndex = 73;
            this.label_apellidos.Text = "Apellidos:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.BackColor = System.Drawing.Color.Transparent;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(141, 77);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(67, 16);
            this.label_nombre.TabIndex = 72;
            this.label_nombre.Text = "Nombre:";
            // 
            // label_dni
            // 
            this.label_dni.AutoSize = true;
            this.label_dni.BackColor = System.Drawing.Color.Transparent;
            this.label_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dni.Location = new System.Drawing.Point(140, 47);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(38, 16);
            this.label_dni.TabIndex = 71;
            this.label_dni.Text = "DNI:";
            // 
            // text_cp
            // 
            this.text_cp.Location = new System.Drawing.Point(586, 188);
            this.text_cp.Name = "text_cp";
            this.text_cp.Size = new System.Drawing.Size(86, 20);
            this.text_cp.TabIndex = 70;
            // 
            // text_localidad
            // 
            this.text_localidad.Location = new System.Drawing.Point(586, 150);
            this.text_localidad.Name = "text_localidad";
            this.text_localidad.Size = new System.Drawing.Size(86, 20);
            this.text_localidad.TabIndex = 69;
            // 
            // text_telefono
            // 
            this.text_telefono.Location = new System.Drawing.Point(92, 191);
            this.text_telefono.Name = "text_telefono";
            this.text_telefono.Size = new System.Drawing.Size(154, 20);
            this.text_telefono.TabIndex = 68;
            // 
            // text_direccion
            // 
            this.text_direccion.Location = new System.Drawing.Point(92, 153);
            this.text_direccion.Name = "text_direccion";
            this.text_direccion.Size = new System.Drawing.Size(211, 20);
            this.text_direccion.TabIndex = 67;
            // 
            // text_apellidos
            // 
            this.text_apellidos.Location = new System.Drawing.Point(227, 99);
            this.text_apellidos.Name = "text_apellidos";
            this.text_apellidos.Size = new System.Drawing.Size(163, 20);
            this.text_apellidos.TabIndex = 66;
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(227, 73);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(163, 20);
            this.text_nombre.TabIndex = 65;
            // 
            // text_dni
            // 
            this.text_dni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_dni.Location = new System.Drawing.Point(227, 46);
            this.text_dni.Name = "text_dni";
            this.text_dni.Size = new System.Drawing.Size(163, 20);
            this.text_dni.TabIndex = 64;
            // 
            // FormEmpleadoAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.error_apellidos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combo_provincia);
            this.Controls.Add(this.error_telefono);
            this.Controls.Add(this.error_direccion);
            this.Controls.Add(this.error_nombre);
            this.Controls.Add(this.error_dni);
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
            this.Name = "FormEmpleadoAdministrador";
            this.Text = "FormEmpleadoAdministrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_email;
        public System.Windows.Forms.TextBox text_email;
        public System.Windows.Forms.Label error_apellidos;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox combo_provincia;
        public System.Windows.Forms.Label error_telefono;
        public System.Windows.Forms.Label error_direccion;
        public System.Windows.Forms.Label error_nombre;
        public System.Windows.Forms.Label error_dni;
        public System.Windows.Forms.Label label_cp;
        public System.Windows.Forms.Label label_provincia;
        public System.Windows.Forms.Label label_localidad;
        public System.Windows.Forms.Label label_telefono;
        public System.Windows.Forms.Label label_direccion;
        public System.Windows.Forms.Label label_apellidos;
        public System.Windows.Forms.Label label_nombre;
        public System.Windows.Forms.Label label_dni;
        public System.Windows.Forms.TextBox text_cp;
        public System.Windows.Forms.TextBox text_localidad;
        public System.Windows.Forms.TextBox text_telefono;
        public System.Windows.Forms.TextBox text_direccion;
        public System.Windows.Forms.TextBox text_apellidos;
        public System.Windows.Forms.TextBox text_nombre;
        public System.Windows.Forms.TextBox text_dni;
    }
}