namespace WindowsFormsApplication1
{
    partial class FormTratamientoAdministrador
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
            this.log_date = new System.Windows.Forms.Label();
            this.log_type = new System.Windows.Forms.Label();
            this.log_id = new System.Windows.Forms.Label();
            this.log_name = new System.Windows.Forms.Label();
            this.log_photo = new System.Windows.Forms.PictureBox();
            this.text_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).BeginInit();
            this.SuspendLayout();
            // 
            // log_date
            // 
            this.log_date.AutoSize = true;
            this.log_date.BackColor = System.Drawing.Color.Transparent;
            this.log_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_date.Location = new System.Drawing.Point(108, 127);
            this.log_date.Name = "log_date";
            this.log_date.Size = new System.Drawing.Size(51, 20);
            this.log_date.TabIndex = 51;
            this.log_date.Text = "label4";
            // 
            // log_type
            // 
            this.log_type.AutoSize = true;
            this.log_type.BackColor = System.Drawing.Color.Transparent;
            this.log_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_type.Location = new System.Drawing.Point(108, 95);
            this.log_type.Name = "log_type";
            this.log_type.Size = new System.Drawing.Size(51, 20);
            this.log_type.TabIndex = 50;
            this.log_type.Text = "label3";
            // 
            // log_id
            // 
            this.log_id.AutoSize = true;
            this.log_id.BackColor = System.Drawing.Color.Transparent;
            this.log_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_id.Location = new System.Drawing.Point(108, 62);
            this.log_id.Name = "log_id";
            this.log_id.Size = new System.Drawing.Size(51, 20);
            this.log_id.TabIndex = 49;
            this.log_id.Text = "label2";
            // 
            // log_name
            // 
            this.log_name.AutoSize = true;
            this.log_name.BackColor = System.Drawing.Color.Transparent;
            this.log_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_name.Location = new System.Drawing.Point(108, 27);
            this.log_name.Name = "log_name";
            this.log_name.Size = new System.Drawing.Size(51, 20);
            this.log_name.TabIndex = 48;
            this.log_name.Text = "label1";
            // 
            // log_photo
            // 
            this.log_photo.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.log_photo.Location = new System.Drawing.Point(12, 27);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(90, 120);
            this.log_photo.TabIndex = 47;
            this.log_photo.TabStop = false;
            // 
            // text_buscar
            // 
            this.text_buscar.Location = new System.Drawing.Point(12, 177);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(392, 20);
            this.text_buscar.TabIndex = 52;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(428, 177);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 20);
            this.btn_buscar.TabIndex = 53;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 213);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(658, 258);
            this.dataGridView.TabIndex = 54;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.add;
            this.btn_add.Location = new System.Drawing.Point(654, 191);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(16, 16);
            this.btn_add.TabIndex = 55;
            this.btn_add.TabStop = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FormTratamientoAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.log_date);
            this.Controls.Add(this.log_type);
            this.Controls.Add(this.log_id);
            this.Controls.Add(this.log_name);
            this.Controls.Add(this.log_photo);
            this.Name = "FormTratamientoAdministrador";
            this.Text = "FormTratamientoAdministrador";
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label log_date;
        public System.Windows.Forms.Label log_type;
        public System.Windows.Forms.Label log_id;
        public System.Windows.Forms.Label log_name;
        public System.Windows.Forms.PictureBox log_photo;
        private System.Windows.Forms.TextBox text_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox btn_add;
    }
}