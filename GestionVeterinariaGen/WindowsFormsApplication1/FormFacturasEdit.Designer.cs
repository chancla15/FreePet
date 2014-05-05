namespace WindowsFormsApplication1
{
    partial class FormFacturasEdit
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
            this.tb_Fecha = new System.Windows.Forms.TextBox();
            this.l_Fecha = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.l_Total = new System.Windows.Forms.Label();
            this.tb_Pagada = new System.Windows.Forms.TextBox();
            this.l_Pagada = new System.Windows.Forms.Label();
            this.l_Salir = new System.Windows.Forms.Label();
            this.l_Modificar = new System.Windows.Forms.Label();
            this.l_Mascota = new System.Windows.Forms.Label();
            this.l_Motivo = new System.Windows.Forms.Label();
            this.tb_Motivo = new System.Windows.Forms.TextBox();
            this.cb_Mascota = new System.Windows.Forms.ComboBox();
            this.tb_Mascota = new System.Windows.Forms.TextBox();
            this.l_MascotaElegir = new System.Windows.Forms.Label();
            this.l_Eliminar = new System.Windows.Forms.Label();
            this.tb_Tratamiento = new System.Windows.Forms.TextBox();
            this.l_Tratamiento = new System.Windows.Forms.Label();
            this.l_TratamientoElegir = new System.Windows.Forms.Label();
            this.cb_Tratamiento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_Fecha
            // 
            this.tb_Fecha.Location = new System.Drawing.Point(130, 20);
            this.tb_Fecha.Name = "tb_Fecha";
            this.tb_Fecha.Size = new System.Drawing.Size(154, 20);
            this.tb_Fecha.TabIndex = 3;
            // 
            // l_Fecha
            // 
            this.l_Fecha.AutoSize = true;
            this.l_Fecha.Location = new System.Drawing.Point(26, 20);
            this.l_Fecha.Name = "l_Fecha";
            this.l_Fecha.Size = new System.Drawing.Size(40, 13);
            this.l_Fecha.TabIndex = 2;
            this.l_Fecha.Text = "Fecha:";
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(130, 60);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(154, 20);
            this.tb_Total.TabIndex = 5;
            // 
            // l_Total
            // 
            this.l_Total.AutoSize = true;
            this.l_Total.Location = new System.Drawing.Point(26, 60);
            this.l_Total.Name = "l_Total";
            this.l_Total.Size = new System.Drawing.Size(34, 13);
            this.l_Total.TabIndex = 4;
            this.l_Total.Text = "Total:";
            // 
            // tb_Pagada
            // 
            this.tb_Pagada.Location = new System.Drawing.Point(130, 100);
            this.tb_Pagada.Name = "tb_Pagada";
            this.tb_Pagada.Size = new System.Drawing.Size(154, 20);
            this.tb_Pagada.TabIndex = 7;
            // 
            // l_Pagada
            // 
            this.l_Pagada.AutoSize = true;
            this.l_Pagada.Location = new System.Drawing.Point(26, 100);
            this.l_Pagada.Name = "l_Pagada";
            this.l_Pagada.Size = new System.Drawing.Size(47, 13);
            this.l_Pagada.TabIndex = 6;
            this.l_Pagada.Text = "Pagada:";
            // 
            // l_Salir
            // 
            this.l_Salir.AutoSize = true;
            this.l_Salir.Location = new System.Drawing.Point(223, 333);
            this.l_Salir.Name = "l_Salir";
            this.l_Salir.Size = new System.Drawing.Size(27, 13);
            this.l_Salir.TabIndex = 8;
            this.l_Salir.Text = "Salir";
            this.l_Salir.Click += new System.EventHandler(this.l_Salir_Click);
            // 
            // l_Modificar
            // 
            this.l_Modificar.AutoSize = true;
            this.l_Modificar.Location = new System.Drawing.Point(139, 333);
            this.l_Modificar.Name = "l_Modificar";
            this.l_Modificar.Size = new System.Drawing.Size(50, 13);
            this.l_Modificar.TabIndex = 9;
            this.l_Modificar.Text = "Modificar";
            this.l_Modificar.Click += new System.EventHandler(this.l_Modificar_Click);
            // 
            // l_Mascota
            // 
            this.l_Mascota.AutoSize = true;
            this.l_Mascota.Location = new System.Drawing.Point(26, 220);
            this.l_Mascota.Name = "l_Mascota";
            this.l_Mascota.Size = new System.Drawing.Size(83, 13);
            this.l_Mascota.TabIndex = 10;
            this.l_Mascota.Text = "Mascota actual:";
            // 
            // l_Motivo
            // 
            this.l_Motivo.AutoSize = true;
            this.l_Motivo.Location = new System.Drawing.Point(26, 142);
            this.l_Motivo.Name = "l_Motivo";
            this.l_Motivo.Size = new System.Drawing.Size(42, 13);
            this.l_Motivo.TabIndex = 11;
            this.l_Motivo.Text = "Motivo:";
            // 
            // tb_Motivo
            // 
            this.tb_Motivo.Location = new System.Drawing.Point(130, 142);
            this.tb_Motivo.Name = "tb_Motivo";
            this.tb_Motivo.Size = new System.Drawing.Size(154, 20);
            this.tb_Motivo.TabIndex = 12;
            // 
            // cb_Mascota
            // 
            this.cb_Mascota.FormattingEnabled = true;
            this.cb_Mascota.Location = new System.Drawing.Point(130, 257);
            this.cb_Mascota.Name = "cb_Mascota";
            this.cb_Mascota.Size = new System.Drawing.Size(154, 21);
            this.cb_Mascota.TabIndex = 50;
            // 
            // tb_Mascota
            // 
            this.tb_Mascota.Location = new System.Drawing.Point(130, 220);
            this.tb_Mascota.Name = "tb_Mascota";
            this.tb_Mascota.Size = new System.Drawing.Size(154, 20);
            this.tb_Mascota.TabIndex = 51;
            // 
            // l_MascotaElegir
            // 
            this.l_MascotaElegir.AutoSize = true;
            this.l_MascotaElegir.Location = new System.Drawing.Point(26, 257);
            this.l_MascotaElegir.Name = "l_MascotaElegir";
            this.l_MascotaElegir.Size = new System.Drawing.Size(93, 13);
            this.l_MascotaElegir.TabIndex = 52;
            this.l_MascotaElegir.Text = "Mascotas a elegir:";
            // 
            // l_Eliminar
            // 
            this.l_Eliminar.AutoSize = true;
            this.l_Eliminar.Location = new System.Drawing.Point(55, 333);
            this.l_Eliminar.Name = "l_Eliminar";
            this.l_Eliminar.Size = new System.Drawing.Size(43, 13);
            this.l_Eliminar.TabIndex = 53;
            this.l_Eliminar.Text = "Eliminar";
            this.l_Eliminar.Click += new System.EventHandler(this.l_Eliminar_Click);
            // 
            // tb_Tratamiento
            // 
            this.tb_Tratamiento.Location = new System.Drawing.Point(130, 181);
            this.tb_Tratamiento.Name = "tb_Tratamiento";
            this.tb_Tratamiento.Size = new System.Drawing.Size(154, 20);
            this.tb_Tratamiento.TabIndex = 55;
            // 
            // l_Tratamiento
            // 
            this.l_Tratamiento.AutoSize = true;
            this.l_Tratamiento.Location = new System.Drawing.Point(26, 181);
            this.l_Tratamiento.Name = "l_Tratamiento";
            this.l_Tratamiento.Size = new System.Drawing.Size(98, 13);
            this.l_Tratamiento.TabIndex = 54;
            this.l_Tratamiento.Text = "Tratamiento actual:";
            // 
            // l_TratamientoElegir
            // 
            this.l_TratamientoElegir.AutoSize = true;
            this.l_TratamientoElegir.Location = new System.Drawing.Point(26, 296);
            this.l_TratamientoElegir.Name = "l_TratamientoElegir";
            this.l_TratamientoElegir.Size = new System.Drawing.Size(103, 13);
            this.l_TratamientoElegir.TabIndex = 57;
            this.l_TratamientoElegir.Text = "Tratamiento a elegir:";
            // 
            // cb_Tratamiento
            // 
            this.cb_Tratamiento.FormattingEnabled = true;
            this.cb_Tratamiento.Location = new System.Drawing.Point(130, 296);
            this.cb_Tratamiento.Name = "cb_Tratamiento";
            this.cb_Tratamiento.Size = new System.Drawing.Size(154, 21);
            this.cb_Tratamiento.TabIndex = 56;
            // 
            // FormFacturasEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 355);
            this.Controls.Add(this.l_TratamientoElegir);
            this.Controls.Add(this.cb_Tratamiento);
            this.Controls.Add(this.tb_Tratamiento);
            this.Controls.Add(this.l_Tratamiento);
            this.Controls.Add(this.l_Eliminar);
            this.Controls.Add(this.l_MascotaElegir);
            this.Controls.Add(this.tb_Mascota);
            this.Controls.Add(this.cb_Mascota);
            this.Controls.Add(this.tb_Motivo);
            this.Controls.Add(this.l_Motivo);
            this.Controls.Add(this.l_Mascota);
            this.Controls.Add(this.l_Modificar);
            this.Controls.Add(this.l_Salir);
            this.Controls.Add(this.tb_Pagada);
            this.Controls.Add(this.l_Pagada);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.l_Total);
            this.Controls.Add(this.tb_Fecha);
            this.Controls.Add(this.l_Fecha);
            this.Name = "FormFacturasEdit";
            this.Text = "FormFacturasEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Fecha;
        private System.Windows.Forms.Label l_Fecha;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label l_Total;
        private System.Windows.Forms.TextBox tb_Pagada;
        private System.Windows.Forms.Label l_Pagada;
        private System.Windows.Forms.Label l_Salir;
        private System.Windows.Forms.Label l_Modificar;
        private System.Windows.Forms.Label l_Mascota;
        private System.Windows.Forms.Label l_Motivo;
        private System.Windows.Forms.TextBox tb_Motivo;
        private System.Windows.Forms.ComboBox cb_Mascota;
        private System.Windows.Forms.TextBox tb_Mascota;
        private System.Windows.Forms.Label l_MascotaElegir;
        private System.Windows.Forms.Label l_Eliminar;
        private System.Windows.Forms.TextBox tb_Tratamiento;
        private System.Windows.Forms.Label l_Tratamiento;
        private System.Windows.Forms.Label l_TratamientoElegir;
        private System.Windows.Forms.ComboBox cb_Tratamiento;
    }
}