namespace WindowsFormsApplication1
{
    partial class FormConsultaVeterinario
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
            this.label_cliente = new System.Windows.Forms.Label();
            this.text_cliente = new System.Windows.Forms.TextBox();
            this.text_hora = new System.Windows.Forms.TextBox();
            this.label_hora = new System.Windows.Forms.Label();
            this.text_fecha = new System.Windows.Forms.TextBox();
            this.label_fecha = new System.Windows.Forms.Label();
            this.text_macota = new System.Windows.Forms.TextBox();
            this.label_mascota = new System.Windows.Forms.Label();
            this.text_motivo = new System.Windows.Forms.TextBox();
            this.label_motivo = new System.Windows.Forms.Label();
            this.text_diagnostico = new System.Windows.Forms.TextBox();
            this.label_diagnostico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // log_date
            // 
            this.log_date.AutoSize = true;
            this.log_date.BackColor = System.Drawing.Color.Transparent;
            this.log_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_date.Location = new System.Drawing.Point(108, 130);
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
            this.log_type.Location = new System.Drawing.Point(108, 98);
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
            this.log_id.Location = new System.Drawing.Point(108, 65);
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
            this.log_name.Location = new System.Drawing.Point(108, 30);
            this.log_name.Name = "log_name";
            this.log_name.Size = new System.Drawing.Size(51, 20);
            this.log_name.TabIndex = 43;
            this.log_name.Text = "label1";
            // 
            // log_photo
            // 
            this.log_photo.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.log_photo.Location = new System.Drawing.Point(12, 30);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(90, 120);
            this.log_photo.TabIndex = 42;
            this.log_photo.TabStop = false;
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.Location = new System.Drawing.Point(12, 179);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(42, 13);
            this.label_cliente.TabIndex = 47;
            this.label_cliente.Text = "Cliente:";
            // 
            // text_cliente
            // 
            this.text_cliente.Location = new System.Drawing.Point(68, 176);
            this.text_cliente.Name = "text_cliente";
            this.text_cliente.Size = new System.Drawing.Size(100, 20);
            this.text_cliente.TabIndex = 48;
            // 
            // text_hora
            // 
            this.text_hora.Location = new System.Drawing.Point(231, 210);
            this.text_hora.Name = "text_hora";
            this.text_hora.Size = new System.Drawing.Size(100, 20);
            this.text_hora.TabIndex = 50;
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Location = new System.Drawing.Point(174, 213);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(33, 13);
            this.label_hora.TabIndex = 49;
            this.label_hora.Text = "Hora:";
            // 
            // text_fecha
            // 
            this.text_fecha.Location = new System.Drawing.Point(68, 210);
            this.text_fecha.Name = "text_fecha";
            this.text_fecha.Size = new System.Drawing.Size(100, 20);
            this.text_fecha.TabIndex = 52;
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Location = new System.Drawing.Point(14, 217);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(40, 13);
            this.label_fecha.TabIndex = 51;
            this.label_fecha.Text = "Fecha:";
            // 
            // text_macota
            // 
            this.text_macota.Location = new System.Drawing.Point(231, 176);
            this.text_macota.Name = "text_macota";
            this.text_macota.Size = new System.Drawing.Size(100, 20);
            this.text_macota.TabIndex = 54;
            // 
            // label_mascota
            // 
            this.label_mascota.AutoSize = true;
            this.label_mascota.Location = new System.Drawing.Point(174, 179);
            this.label_mascota.Name = "label_mascota";
            this.label_mascota.Size = new System.Drawing.Size(51, 13);
            this.label_mascota.TabIndex = 53;
            this.label_mascota.Text = "Mascota:";
            // 
            // text_motivo
            // 
            this.text_motivo.Location = new System.Drawing.Point(409, 172);
            this.text_motivo.Name = "text_motivo";
            this.text_motivo.Size = new System.Drawing.Size(258, 20);
            this.text_motivo.TabIndex = 56;
            // 
            // label_motivo
            // 
            this.label_motivo.AutoSize = true;
            this.label_motivo.Location = new System.Drawing.Point(337, 179);
            this.label_motivo.Name = "label_motivo";
            this.label_motivo.Size = new System.Drawing.Size(42, 13);
            this.label_motivo.TabIndex = 55;
            this.label_motivo.Text = "Motivo:";
            // 
            // text_diagnostico
            // 
            this.text_diagnostico.Location = new System.Drawing.Point(409, 213);
            this.text_diagnostico.Name = "text_diagnostico";
            this.text_diagnostico.Size = new System.Drawing.Size(258, 20);
            this.text_diagnostico.TabIndex = 58;
            // 
            // label_diagnostico
            // 
            this.label_diagnostico.AutoSize = true;
            this.label_diagnostico.Location = new System.Drawing.Point(337, 217);
            this.label_diagnostico.Name = "label_diagnostico";
            this.label_diagnostico.Size = new System.Drawing.Size(66, 13);
            this.label_diagnostico.TabIndex = 57;
            this.label_diagnostico.Text = "Diagnostico:";
            // 
            // FormConsultaVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.text_diagnostico);
            this.Controls.Add(this.label_diagnostico);
            this.Controls.Add(this.text_motivo);
            this.Controls.Add(this.label_motivo);
            this.Controls.Add(this.text_macota);
            this.Controls.Add(this.label_mascota);
            this.Controls.Add(this.text_fecha);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.text_hora);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.text_cliente);
            this.Controls.Add(this.label_cliente);
            this.Controls.Add(this.log_date);
            this.Controls.Add(this.log_type);
            this.Controls.Add(this.log_id);
            this.Controls.Add(this.log_name);
            this.Controls.Add(this.log_photo);
            this.Name = "FormConsultaVeterinario";
            this.Text = "FormConsultaVeterinario";
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label log_date;
        public System.Windows.Forms.Label log_type;
        public System.Windows.Forms.Label log_id;
        public System.Windows.Forms.Label log_name;
        public System.Windows.Forms.PictureBox log_photo;
        private System.Windows.Forms.Label label_cliente;
        private System.Windows.Forms.TextBox text_cliente;
        private System.Windows.Forms.TextBox text_hora;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.TextBox text_fecha;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.TextBox text_macota;
        private System.Windows.Forms.Label label_mascota;
        private System.Windows.Forms.TextBox text_motivo;
        private System.Windows.Forms.Label label_motivo;
        private System.Windows.Forms.TextBox text_diagnostico;
        private System.Windows.Forms.Label label_diagnostico;
    }
}