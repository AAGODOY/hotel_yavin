﻿namespace Hotel_Yavin
{
    partial class Reserva
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
            this.lblFIngreso = new System.Windows.Forms.Label();
            this.lblFSalida = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clb_habitaciones = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_GuardarEmpleado = new System.Windows.Forms.Button();
            this.btn_CancelarEmpleado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFIngreso
            // 
            this.lblFIngreso.AutoSize = true;
            this.lblFIngreso.Location = new System.Drawing.Point(6, 31);
            this.lblFIngreso.Name = "lblFIngreso";
            this.lblFIngreso.Size = new System.Drawing.Size(90, 13);
            this.lblFIngreso.TabIndex = 0;
            this.lblFIngreso.Text = "Fecha de Ingreso";
            // 
            // lblFSalida
            // 
            this.lblFSalida.AutoSize = true;
            this.lblFSalida.Location = new System.Drawing.Point(312, 31);
            this.lblFSalida.Name = "lblFSalida";
            this.lblFSalida.Size = new System.Drawing.Size(84, 13);
            this.lblFSalida.TabIndex = 1;
            this.lblFSalida.Text = "Fecha de Salida";
            this.lblFSalida.Click += new System.EventHandler(this.lblFSalida_Click);
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(102, 25);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(194, 20);
            this.dtpIngreso.TabIndex = 2;
            this.dtpIngreso.Value = new System.DateTime(2019, 6, 17, 0, 0, 0, 0);
            this.dtpIngreso.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(402, 25);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(194, 20);
            this.dtpSalida.TabIndex = 3;
            this.dtpSalida.Value = new System.DateTime(2019, 6, 17, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccionar Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_Cliente
            // 
            this.cmb_Cliente.FormattingEnabled = true;
            this.cmb_Cliente.Location = new System.Drawing.Point(159, 63);
            this.cmb_Cliente.Name = "cmb_Cliente";
            this.cmb_Cliente.Size = new System.Drawing.Size(137, 21);
            this.cmb_Cliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccionar Habitación";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clb_habitaciones);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.lblFIngreso);
            this.groupBox1.Controls.Add(this.lblFSalida);
            this.groupBox1.Controls.Add(this.dtpIngreso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpSalida);
            this.groupBox1.Controls.Add(this.cmb_Cliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 291);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // clb_habitaciones
            // 
            this.clb_habitaciones.FormattingEnabled = true;
            this.clb_habitaciones.Location = new System.Drawing.Point(160, 101);
            this.clb_habitaciones.Name = "clb_habitaciones";
            this.clb_habitaciones.Size = new System.Drawing.Size(136, 79);
            this.clb_habitaciones.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(315, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 215);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Huespedes";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(281, 151);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccionar Serv. Adicionales";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(160, 196);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(136, 79);
            this.checkedListBox1.TabIndex = 9;
            // 
            // btn_GuardarEmpleado
            // 
            this.btn_GuardarEmpleado.Location = new System.Drawing.Point(552, 319);
            this.btn_GuardarEmpleado.Name = "btn_GuardarEmpleado";
            this.btn_GuardarEmpleado.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarEmpleado.TabIndex = 28;
            this.btn_GuardarEmpleado.Text = "Aceptar";
            this.btn_GuardarEmpleado.UseVisualStyleBackColor = true;
            this.btn_GuardarEmpleado.Click += new System.EventHandler(this.btn_GuardarEmpleado_Click);
            // 
            // btn_CancelarEmpleado
            // 
            this.btn_CancelarEmpleado.Location = new System.Drawing.Point(458, 319);
            this.btn_CancelarEmpleado.Name = "btn_CancelarEmpleado";
            this.btn_CancelarEmpleado.Size = new System.Drawing.Size(89, 29);
            this.btn_CancelarEmpleado.TabIndex = 27;
            this.btn_CancelarEmpleado.Text = "Cancelar";
            this.btn_CancelarEmpleado.UseVisualStyleBackColor = true;
            this.btn_CancelarEmpleado.Click += new System.EventHandler(this.btn_CancelarEmpleado_Click);
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 360);
            this.Controls.Add(this.btn_GuardarEmpleado);
            this.Controls.Add(this.btn_CancelarEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFIngreso;
        private System.Windows.Forms.Label lblFSalida;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_GuardarEmpleado;
        private System.Windows.Forms.Button btn_CancelarEmpleado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox clb_habitaciones;
    }
}