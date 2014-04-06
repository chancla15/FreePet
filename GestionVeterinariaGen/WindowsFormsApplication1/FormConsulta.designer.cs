namespace WindowsFormsApplication1
{
    partial class FormConsulta
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
            this.textCliente = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewConsultas = new System.Windows.Forms.TreeView();
            this.datetime_fin = new System.Windows.Forms.DateTimePicker();
            this.datetime_init = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar_Fecha = new System.Windows.Forms.Button();
            this.label_error_cliente = new System.Windows.Forms.Label();
            this.label_error_fecha = new System.Windows.Forms.Label();
            this.btnBuscar_Cliente = new System.Windows.Forms.Button();
            this.btn_Anaydir = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(12, 157);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(200, 20);
            this.textCliente.TabIndex = 2;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(12, 141);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(42, 13);
            this.labelCliente.TabIndex = 4;
            this.labelCliente.Text = "Cliente:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(330, 492);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Volver";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "CONSULTAS";
            // 
            // treeViewConsultas
            // 
            this.treeViewConsultas.Location = new System.Drawing.Point(12, 202);
            this.treeViewConsultas.Name = "treeViewConsultas";
            this.treeViewConsultas.Size = new System.Drawing.Size(314, 271);
            this.treeViewConsultas.TabIndex = 9;
            // 
            // datetime_fin
            // 
            this.datetime_fin.Location = new System.Drawing.Point(12, 102);
            this.datetime_fin.Name = "datetime_fin";
            this.datetime_fin.Size = new System.Drawing.Size(200, 20);
            this.datetime_fin.TabIndex = 10;
            // 
            // datetime_init
            // 
            this.datetime_init.Location = new System.Drawing.Point(12, 61);
            this.datetime_init.Name = "datetime_init";
            this.datetime_init.Size = new System.Drawing.Size(200, 20);
            this.datetime_init.TabIndex = 11;
            // 
            // btnBuscar_Fecha
            // 
            this.btnBuscar_Fecha.Location = new System.Drawing.Point(229, 99);
            this.btnBuscar_Fecha.Name = "btnBuscar_Fecha";
            this.btnBuscar_Fecha.Size = new System.Drawing.Size(111, 23);
            this.btnBuscar_Fecha.TabIndex = 12;
            this.btnBuscar_Fecha.Text = "Buscar Por Fecha";
            this.btnBuscar_Fecha.UseVisualStyleBackColor = true;
            this.btnBuscar_Fecha.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label_error_cliente
            // 
            this.label_error_cliente.AutoSize = true;
            this.label_error_cliente.ForeColor = System.Drawing.Color.Red;
            this.label_error_cliente.Location = new System.Drawing.Point(12, 186);
            this.label_error_cliente.Name = "label_error_cliente";
            this.label_error_cliente.Size = new System.Drawing.Size(133, 13);
            this.label_error_cliente.TabIndex = 14;
            this.label_error_cliente.Text = "*ERROR: Cliente no existe";
            this.label_error_cliente.Visible = false;
            // 
            // label_error_fecha
            // 
            this.label_error_fecha.AutoSize = true;
            this.label_error_fecha.ForeColor = System.Drawing.Color.Red;
            this.label_error_fecha.Location = new System.Drawing.Point(226, 68);
            this.label_error_fecha.Name = "label_error_fecha";
            this.label_error_fecha.Size = new System.Drawing.Size(146, 13);
            this.label_error_fecha.TabIndex = 15;
            this.label_error_fecha.Text = "*ERROR: Fechas incorrectas";
            this.label_error_fecha.Visible = false;
            // 
            // btnBuscar_Cliente
            // 
            this.btnBuscar_Cliente.Location = new System.Drawing.Point(229, 154);
            this.btnBuscar_Cliente.Name = "btnBuscar_Cliente";
            this.btnBuscar_Cliente.Size = new System.Drawing.Size(111, 23);
            this.btnBuscar_Cliente.TabIndex = 16;
            this.btnBuscar_Cliente.Text = "Buscar Por Cliente";
            this.btnBuscar_Cliente.UseVisualStyleBackColor = true;
            this.btnBuscar_Cliente.Click += new System.EventHandler(this.btnBuscar_Cliente_Click);
            // 
            // btn_Anaydir
            // 
            this.btn_Anaydir.Location = new System.Drawing.Point(335, 283);
            this.btn_Anaydir.Name = "btn_Anaydir";
            this.btn_Anaydir.Size = new System.Drawing.Size(75, 23);
            this.btn_Anaydir.TabIndex = 17;
            this.btn_Anaydir.Text = "Add";
            this.btn_Anaydir.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(335, 322);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 18;
            this.btn_Modificar.Text = "Mod";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(335, 364);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 19;
            this.btn_Eliminar.Text = "Del";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 527);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Anaydir);
            this.Controls.Add(this.btnBuscar_Cliente);
            this.Controls.Add(this.label_error_fecha);
            this.Controls.Add(this.label_error_cliente);
            this.Controls.Add(this.btnBuscar_Fecha);
            this.Controls.Add(this.datetime_init);
            this.Controls.Add(this.datetime_fin);
            this.Controls.Add(this.treeViewConsultas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.textCliente);
            this.Name = "FormConsulta";
            this.Text = "FormAddConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewConsultas;
        private System.Windows.Forms.DateTimePicker datetime_fin;
        private System.Windows.Forms.DateTimePicker datetime_init;
        private System.Windows.Forms.Button btnBuscar_Fecha;
        private System.Windows.Forms.Label label_error_cliente;
        private System.Windows.Forms.Label label_error_fecha;
        private System.Windows.Forms.Button btnBuscar_Cliente;
        private System.Windows.Forms.Button btn_Anaydir;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}