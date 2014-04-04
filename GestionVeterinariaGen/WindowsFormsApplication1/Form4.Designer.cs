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
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_id = new System.Windows.Forms.TextBox();
            this.m_nombre = new System.Windows.Forms.TextBox();
            this.m_raza = new System.Windows.Forms.TextBox();
            this.m_especie = new System.Windows.Forms.TextBox();
            this.m_color = new System.Windows.Forms.TextBox();
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
            this.m_sexo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.err_tel = new System.Windows.Forms.Label();
            this.err_direccion = new System.Windows.Forms.Label();
            this.err_nom = new System.Windows.Forms.Label();
            this.err_dni = new System.Windows.Forms.Label();
            this.m_fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.err_add = new System.Windows.Forms.Label();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.bt_aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(147, 534);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 1;
            this.bt_eliminar.Text = "ELIMINAR";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.button2_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
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
            this.label3.Size = new System.Drawing.Size(67, 16);
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
            this.label4.Size = new System.Drawing.Size(48, 16);
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
            this.label5.Size = new System.Drawing.Size(69, 16);
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
            this.label6.Size = new System.Drawing.Size(69, 16);
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
            this.label7.Size = new System.Drawing.Size(49, 16);
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
            this.label8.Size = new System.Drawing.Size(81, 16);
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
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(42, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
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
            this.label11.Size = new System.Drawing.Size(47, 16);
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
            this.label15.Location = new System.Drawing.Point(400, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 86;
            this.label15.Text = "*";
            this.label15.Visible = false;
            // 
            // err_tel
            // 
            this.err_tel.AutoSize = true;
            this.err_tel.BackColor = System.Drawing.Color.Transparent;
            this.err_tel.ForeColor = System.Drawing.Color.Red;
            this.err_tel.Location = new System.Drawing.Point(400, 273);
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
            this.err_direccion.Location = new System.Drawing.Point(400, 234);
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
            this.err_nom.Location = new System.Drawing.Point(400, 170);
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
            this.err_dni.Location = new System.Drawing.Point(400, 144);
            this.err_dni.Name = "err_dni";
            this.err_dni.Size = new System.Drawing.Size(11, 13);
            this.err_dni.TabIndex = 77;
            this.err_dni.Text = "*";
            this.err_dni.Visible = false;
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
            this.label30.Size = new System.Drawing.Size(137, 16);
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(400, 464);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 13);
            this.label17.TabIndex = 98;
            this.label17.Text = "*";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(400, 400);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 13);
            this.label18.TabIndex = 97;
            this.label18.Text = "*";
            this.label18.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(400, 336);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 13);
            this.label19.TabIndex = 96;
            this.label19.Text = "*";
            this.label19.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(147, 464);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(245, 21);
            this.comboBox2.TabIndex = 99;
            // 
            // err_add
            // 
            this.err_add.AutoSize = true;
            this.err_add.BackColor = System.Drawing.Color.Transparent;
            this.err_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_add.ForeColor = System.Drawing.Color.Red;
            this.err_add.Location = new System.Drawing.Point(42, 504);
            this.err_add.Name = "err_add";
            this.err_add.Size = new System.Drawing.Size(177, 16);
            this.err_add.TabIndex = 100;
            this.err_add.Text = "*Error al Añadir Mascota";
            this.err_add.Visible = false;
            // 
            // bt_modificar
            // 
            this.bt_modificar.Location = new System.Drawing.Point(231, 534);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(75, 23);
            this.bt_modificar.TabIndex = 101;
            this.bt_modificar.Text = "MODIFICAR";
            this.bt_modificar.UseVisualStyleBackColor = true;
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(231, 534);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_aceptar.TabIndex = 102;
            this.bt_aceptar.Text = "ACEPTAR";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(442, 580);
            this.ControlBox = false;
            this.Controls.Add(this.err_add);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.m_fecha_nac);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.err_tel);
            this.Controls.Add(this.err_direccion);
            this.Controls.Add(this.err_nom);
            this.Controls.Add(this.err_dni);
            this.Controls.Add(this.m_sexo);
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
            this.Controls.Add(this.m_color);
            this.Controls.Add(this.m_especie);
            this.Controls.Add(this.m_raza);
            this.Controls.Add(this.m_nombre);
            this.Controls.Add(this.m_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.bt_modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_id;
        private System.Windows.Forms.TextBox m_nombre;
        private System.Windows.Forms.TextBox m_raza;
        private System.Windows.Forms.TextBox m_especie;
        private System.Windows.Forms.TextBox m_color;
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
        private System.Windows.Forms.ComboBox m_sexo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label err_tel;
        private System.Windows.Forms.Label err_direccion;
        private System.Windows.Forms.Label err_nom;
        private System.Windows.Forms.Label err_dni;
        private System.Windows.Forms.DateTimePicker m_fecha_nac;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label err_add;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Button bt_aceptar;
    }
}