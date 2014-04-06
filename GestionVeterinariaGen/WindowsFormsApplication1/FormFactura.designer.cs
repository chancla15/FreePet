namespace WindowsFormsApplication1
{
    partial class FormFactura
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
            this.text_Mascota = new System.Windows.Forms.TextBox();
            this.text_Cliente = new System.Windows.Forms.TextBox();
            this.label_Cliente = new System.Windows.Forms.Label();
            this.label_Mascota = new System.Windows.Forms.Label();
            this.listView_Facturas = new System.Windows.Forms.ListView();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.label_fact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_Mascota
            // 
            this.text_Mascota.Location = new System.Drawing.Point(12, 151);
            this.text_Mascota.Name = "text_Mascota";
            this.text_Mascota.Size = new System.Drawing.Size(169, 20);
            this.text_Mascota.TabIndex = 0;
            // 
            // text_Cliente
            // 
            this.text_Cliente.Location = new System.Drawing.Point(12, 90);
            this.text_Cliente.Name = "text_Cliente";
            this.text_Cliente.Size = new System.Drawing.Size(169, 20);
            this.text_Cliente.TabIndex = 1;
            // 
            // label_Cliente
            // 
            this.label_Cliente.AutoSize = true;
            this.label_Cliente.Location = new System.Drawing.Point(9, 74);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(42, 13);
            this.label_Cliente.TabIndex = 2;
            this.label_Cliente.Text = "Cliente:";
            // 
            // label_Mascota
            // 
            this.label_Mascota.AutoSize = true;
            this.label_Mascota.Location = new System.Drawing.Point(9, 135);
            this.label_Mascota.Name = "label_Mascota";
            this.label_Mascota.Size = new System.Drawing.Size(48, 13);
            this.label_Mascota.TabIndex = 3;
            this.label_Mascota.Text = "Mascota";
            // 
            // listView_Facturas
            // 
            this.listView_Facturas.Location = new System.Drawing.Point(12, 201);
            this.listView_Facturas.Name = "listView_Facturas";
            this.listView_Facturas.Size = new System.Drawing.Size(398, 233);
            this.listView_Facturas.TabIndex = 4;
            this.listView_Facturas.UseCompatibleStateImageBehavior = false;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(335, 448);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 5;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_pagar
            // 
            this.btn_pagar.Location = new System.Drawing.Point(202, 118);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(208, 60);
            this.btn_pagar.TabIndex = 6;
            this.btn_pagar.Text = "PAGAR";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // label_fact
            // 
            this.label_fact.AutoSize = true;
            this.label_fact.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fact.Location = new System.Drawing.Point(207, 9);
            this.label_fact.Name = "label_fact";
            this.label_fact.Size = new System.Drawing.Size(203, 38);
            this.label_fact.TabIndex = 7;
            this.label_fact.Text = "FACTURAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "*ERROR: Cliente no existe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "*ERROR: Mascota no existe";
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_fact);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.listView_Facturas);
            this.Controls.Add(this.label_Mascota);
            this.Controls.Add(this.label_Cliente);
            this.Controls.Add(this.text_Cliente);
            this.Controls.Add(this.text_Mascota);
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Mascota;
        private System.Windows.Forms.TextBox text_Cliente;
        private System.Windows.Forms.Label label_Cliente;
        private System.Windows.Forms.Label label_Mascota;
        private System.Windows.Forms.ListView listView_Facturas;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label label_fact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}