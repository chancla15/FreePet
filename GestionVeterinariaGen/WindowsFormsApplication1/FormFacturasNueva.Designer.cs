namespace WindowsFormsApplication1
{
    partial class FormFacturasNueva
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
            this.tb_Pagada = new System.Windows.Forms.TextBox();
            this.l_Pagada = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.l_Total = new System.Windows.Forms.Label();
            this.l_Crear = new System.Windows.Forms.Label();
            this.l_Salir = new System.Windows.Forms.Label();
            this.cb_Consultas = new System.Windows.Forms.ComboBox();
            this.l_Consultas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Pagada
            // 
            this.tb_Pagada.Location = new System.Drawing.Point(347, 26);
            this.tb_Pagada.Name = "tb_Pagada";
            this.tb_Pagada.Size = new System.Drawing.Size(100, 20);
            this.tb_Pagada.TabIndex = 13;
            // 
            // l_Pagada
            // 
            this.l_Pagada.AutoSize = true;
            this.l_Pagada.Location = new System.Drawing.Point(253, 26);
            this.l_Pagada.Name = "l_Pagada";
            this.l_Pagada.Size = new System.Drawing.Size(47, 13);
            this.l_Pagada.TabIndex = 12;
            this.l_Pagada.Text = "Pagada:";
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(122, 26);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(100, 20);
            this.tb_Total.TabIndex = 11;
            // 
            // l_Total
            // 
            this.l_Total.AutoSize = true;
            this.l_Total.Location = new System.Drawing.Point(28, 26);
            this.l_Total.Name = "l_Total";
            this.l_Total.Size = new System.Drawing.Size(34, 13);
            this.l_Total.TabIndex = 10;
            this.l_Total.Text = "Total:";
            // 
            // l_Crear
            // 
            this.l_Crear.AutoSize = true;
            this.l_Crear.Location = new System.Drawing.Point(28, 158);
            this.l_Crear.Name = "l_Crear";
            this.l_Crear.Size = new System.Drawing.Size(32, 13);
            this.l_Crear.TabIndex = 14;
            this.l_Crear.Text = "Crear";
            this.l_Crear.Click += new System.EventHandler(this.l_Crear_Click);
            // 
            // l_Salir
            // 
            this.l_Salir.AutoSize = true;
            this.l_Salir.Location = new System.Drawing.Point(116, 158);
            this.l_Salir.Name = "l_Salir";
            this.l_Salir.Size = new System.Drawing.Size(27, 13);
            this.l_Salir.TabIndex = 15;
            this.l_Salir.Text = "Salir";
            this.l_Salir.Click += new System.EventHandler(this.l_Salir_Click);
            // 
            // cb_Consultas
            // 
            this.cb_Consultas.FormattingEnabled = true;
            this.cb_Consultas.Location = new System.Drawing.Point(122, 94);
            this.cb_Consultas.Name = "cb_Consultas";
            this.cb_Consultas.Size = new System.Drawing.Size(543, 21);
            this.cb_Consultas.TabIndex = 16;
            // 
            // l_Consultas
            // 
            this.l_Consultas.AutoSize = true;
            this.l_Consultas.Location = new System.Drawing.Point(28, 94);
            this.l_Consultas.Name = "l_Consultas";
            this.l_Consultas.Size = new System.Drawing.Size(56, 13);
            this.l_Consultas.TabIndex = 17;
            this.l_Consultas.Text = "Consultas:";
            // 
            // FormFacturasNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 214);
            this.Controls.Add(this.l_Consultas);
            this.Controls.Add(this.cb_Consultas);
            this.Controls.Add(this.l_Salir);
            this.Controls.Add(this.l_Crear);
            this.Controls.Add(this.tb_Pagada);
            this.Controls.Add(this.l_Pagada);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.l_Total);
            this.Name = "FormFacturasNueva";
            this.Text = "FormFacturasNueva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Pagada;
        private System.Windows.Forms.Label l_Pagada;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label l_Total;
        private System.Windows.Forms.Label l_Crear;
        private System.Windows.Forms.Label l_Salir;
        private System.Windows.Forms.ComboBox cb_Consultas;
        private System.Windows.Forms.Label l_Consultas;
    }
}