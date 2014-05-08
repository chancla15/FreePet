namespace WindowsFormsApplication1
{
    partial class FormVeterinarioInicio
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
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.label_fecha_consulta = new System.Windows.Forms.Label();
            this.dataGrid_consultas = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_consultas)).BeginInit();
            this.SuspendLayout();
            // 
            // log_date
            // 
            this.log_date.AutoSize = true;
            this.log_date.BackColor = System.Drawing.Color.Transparent;
            this.log_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_date.Location = new System.Drawing.Point(108, 132);
            this.log_date.Name = "log_date";
            this.log_date.Size = new System.Drawing.Size(51, 20);
            this.log_date.TabIndex = 46;
            this.log_date.Text = "label4";
            // 
            // log_type
            // 
            this.log_type.AutoSize = true;
            this.log_type.BackColor = System.Drawing.Color.Transparent;
            this.log_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_type.Location = new System.Drawing.Point(108, 100);
            this.log_type.Name = "log_type";
            this.log_type.Size = new System.Drawing.Size(51, 20);
            this.log_type.TabIndex = 45;
            this.log_type.Text = "label3";
            // 
            // log_id
            // 
            this.log_id.AutoSize = true;
            this.log_id.BackColor = System.Drawing.Color.Transparent;
            this.log_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_id.Location = new System.Drawing.Point(108, 67);
            this.log_id.Name = "log_id";
            this.log_id.Size = new System.Drawing.Size(51, 20);
            this.log_id.TabIndex = 44;
            this.log_id.Text = "label2";
            // 
            // log_name
            // 
            this.log_name.AutoSize = true;
            this.log_name.BackColor = System.Drawing.Color.Transparent;
            this.log_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_name.Location = new System.Drawing.Point(108, 32);
            this.log_name.Name = "log_name";
            this.log_name.Size = new System.Drawing.Size(51, 20);
            this.log_name.TabIndex = 43;
            this.log_name.Text = "label1";
            // 
            // log_photo
            // 
            this.log_photo.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.log_photo.Location = new System.Drawing.Point(12, 32);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(90, 120);
            this.log_photo.TabIndex = 42;
            this.log_photo.TabStop = false;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(506, 18);
            this.Calendar.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.Calendar.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 47;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // label_fecha_consulta
            // 
            this.label_fecha_consulta.AutoSize = true;
            this.label_fecha_consulta.BackColor = System.Drawing.Color.Transparent;
            this.label_fecha_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha_consulta.Location = new System.Drawing.Point(12, 173);
            this.label_fecha_consulta.Name = "label_fecha_consulta";
            this.label_fecha_consulta.Size = new System.Drawing.Size(51, 20);
            this.label_fecha_consulta.TabIndex = 48;
            this.label_fecha_consulta.Text = "label5";
            // 
            // dataGrid_consultas
            // 
            this.dataGrid_consultas.AllowUserToAddRows = false;
            this.dataGrid_consultas.AllowUserToDeleteRows = false;
            this.dataGrid_consultas.AllowUserToResizeRows = false;
            this.dataGrid_consultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_consultas.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_consultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Motivo,
            this.Lugar,
            this.Modificar,
            this.Eliminar});
            this.dataGrid_consultas.Location = new System.Drawing.Point(12, 196);
            this.dataGrid_consultas.Name = "dataGrid_consultas";
            this.dataGrid_consultas.ReadOnly = true;
            this.dataGrid_consultas.RowHeadersVisible = false;
            this.dataGrid_consultas.Size = new System.Drawing.Size(658, 274);
            this.dataGrid_consultas.TabIndex = 49;
            this.dataGrid_consultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_consultas_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            this.Lugar.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // FormVeterinarioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.dataGrid_consultas);
            this.Controls.Add(this.label_fecha_consulta);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.log_date);
            this.Controls.Add(this.log_type);
            this.Controls.Add(this.log_id);
            this.Controls.Add(this.log_name);
            this.Controls.Add(this.log_photo);
            this.Name = "FormVeterinarioInicio";
            this.Text = "FormStartVeterinario";
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_consultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label log_date;
        public System.Windows.Forms.Label log_type;
        public System.Windows.Forms.Label log_id;
        public System.Windows.Forms.Label log_name;
        public System.Windows.Forms.PictureBox log_photo;
        private System.Windows.Forms.MonthCalendar Calendar;
        public System.Windows.Forms.Label label_fecha_consulta;
        public System.Windows.Forms.DataGridView dataGrid_consultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}