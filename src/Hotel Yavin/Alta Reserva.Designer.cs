namespace Hotel_Yavin
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_errorHabitacion = new System.Windows.Forms.Label();
            this.lbl_errorCliente = new System.Windows.Forms.Label();
            this.clb_habitaciones = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.clb_servicios = new System.Windows.Forms.CheckedListBox();
            this.cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.btn_GuardarReserva = new System.Windows.Forms.Button();
            this.btn_CancelarEmpleado = new System.Windows.Forms.Button();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
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
            this.lblFSalida.Location = new System.Drawing.Point(345, 31);
            this.lblFSalida.Name = "lblFSalida";
            this.lblFSalida.Size = new System.Drawing.Size(84, 13);
            this.lblFSalida.TabIndex = 1;
            this.lblFSalida.Text = "Fecha de Salida";
            // 
            // dtpIngreso
            // 
            this.HelpProviderHG.SetHelpKeyword(this.dtpIngreso, "Alta_Reserva.htm#lblFIngreso");
            this.HelpProviderHG.SetHelpNavigator(this.dtpIngreso, System.Windows.Forms.HelpNavigator.Topic);
            this.dtpIngreso.Location = new System.Drawing.Point(102, 25);
            this.dtpIngreso.Name = "dtpIngreso";
            this.HelpProviderHG.SetShowHelp(this.dtpIngreso, true);
            this.dtpIngreso.Size = new System.Drawing.Size(194, 20);
            this.dtpIngreso.TabIndex = 2;
            this.dtpIngreso.Value = new System.DateTime(2019, 6, 17, 0, 0, 0, 0);
            // 
            // dtpSalida
            // 
            this.HelpProviderHG.SetHelpKeyword(this.dtpSalida, "Alta_Reserva.htm#lblFSalida");
            this.HelpProviderHG.SetHelpNavigator(this.dtpSalida, System.Windows.Forms.HelpNavigator.Topic);
            this.dtpSalida.Location = new System.Drawing.Point(435, 25);
            this.dtpSalida.Name = "dtpSalida";
            this.HelpProviderHG.SetShowHelp(this.dtpSalida, true);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccionar Habitación";
            // 
            // button1
            // 
            this.HelpProviderHG.SetHelpKeyword(this.button1, "Alta_Reserva.htm#button1");
            this.HelpProviderHG.SetHelpNavigator(this.button1, System.Windows.Forms.HelpNavigator.Topic);
            this.button1.Location = new System.Drawing.Point(16, 227);
            this.button1.Name = "button1";
            this.HelpProviderHG.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_errorHabitacion);
            this.groupBox1.Controls.Add(this.lbl_errorCliente);
            this.groupBox1.Controls.Add(this.clb_habitaciones);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.clb_servicios);
            this.groupBox1.Controls.Add(this.lblFIngreso);
            this.groupBox1.Controls.Add(this.lblFSalida);
            this.groupBox1.Controls.Add(this.dtpIngreso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpSalida);
            this.groupBox1.Controls.Add(this.cmb_Cliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 342);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            // 
            // lbl_errorHabitacion
            // 
            this.lbl_errorHabitacion.AutoSize = true;
            this.lbl_errorHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorHabitacion.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorHabitacion.Location = new System.Drawing.Point(159, 208);
            this.lbl_errorHabitacion.Name = "lbl_errorHabitacion";
            this.lbl_errorHabitacion.Size = new System.Drawing.Size(167, 13);
            this.lbl_errorHabitacion.TabIndex = 32;
            this.lbl_errorHabitacion.Text = "*Debe seleccionar una habitación";
            // 
            // lbl_errorCliente
            // 
            this.lbl_errorCliente.AutoSize = true;
            this.lbl_errorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorCliente.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorCliente.Location = new System.Drawing.Point(159, 90);
            this.lbl_errorCliente.Name = "lbl_errorCliente";
            this.lbl_errorCliente.Size = new System.Drawing.Size(143, 13);
            this.lbl_errorCliente.TabIndex = 31;
            this.lbl_errorCliente.Text = "*Debe seleccionar un cliente";
            // 
            // clb_habitaciones
            // 
            this.clb_habitaciones.FormattingEnabled = true;
            this.HelpProviderHG.SetHelpKeyword(this.clb_habitaciones, "Alta_Reserva.htm#label2");
            this.HelpProviderHG.SetHelpNavigator(this.clb_habitaciones, System.Windows.Forms.HelpNavigator.Topic);
            this.clb_habitaciones.Location = new System.Drawing.Point(160, 122);
            this.clb_habitaciones.Name = "clb_habitaciones";
            this.HelpProviderHG.SetShowHelp(this.clb_habitaciones, true);
            this.clb_habitaciones.Size = new System.Drawing.Size(166, 79);
            this.clb_habitaciones.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(348, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 271);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Huespedes";
            // 
            // button3
            // 
            this.HelpProviderHG.SetHelpKeyword(this.button3, "Alta_Reserva.htm#button3");
            this.HelpProviderHG.SetHelpNavigator(this.button3, System.Windows.Forms.HelpNavigator.Topic);
            this.button3.Location = new System.Drawing.Point(214, 227);
            this.button3.Name = "button3";
            this.HelpProviderHG.SetShowHelp(this.button3, true);
            this.button3.Size = new System.Drawing.Size(83, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.HelpProviderHG.SetHelpKeyword(this.button2, "Alta_Reserva.htm#button2");
            this.HelpProviderHG.SetHelpNavigator(this.button2, System.Windows.Forms.HelpNavigator.Topic);
            this.button2.Location = new System.Drawing.Point(115, 227);
            this.button2.Name = "button2";
            this.HelpProviderHG.SetShowHelp(this.button2, true);
            this.button2.Size = new System.Drawing.Size(83, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HelpProviderHG.SetHelpKeyword(this.dataGridView1, "Alta_Reserva.htm#dataGridView1");
            this.HelpProviderHG.SetHelpNavigator(this.dataGridView1, System.Windows.Forms.HelpNavigator.Topic);
            this.dataGridView1.Location = new System.Drawing.Point(16, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.HelpProviderHG.SetShowHelp(this.dataGridView1, true);
            this.dataGridView1.Size = new System.Drawing.Size(281, 187);
            this.dataGridView1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccionar Serv. Adicionales";
            // 
            // clb_servicios
            // 
            this.clb_servicios.FormattingEnabled = true;
            this.HelpProviderHG.SetHelpKeyword(this.clb_servicios, "Alta_Reserva.htm#label3");
            this.HelpProviderHG.SetHelpNavigator(this.clb_servicios, System.Windows.Forms.HelpNavigator.Topic);
            this.clb_servicios.Location = new System.Drawing.Point(160, 239);
            this.clb_servicios.Name = "clb_servicios";
            this.HelpProviderHG.SetShowHelp(this.clb_servicios, true);
            this.clb_servicios.Size = new System.Drawing.Size(166, 79);
            this.clb_servicios.TabIndex = 9;
            // 
            // cmb_Cliente
            // 
            this.cmb_Cliente.FormattingEnabled = true;
            this.HelpProviderHG.SetHelpKeyword(this.cmb_Cliente, "Alta_Reserva.htm#label1");
            this.HelpProviderHG.SetHelpNavigator(this.cmb_Cliente, System.Windows.Forms.HelpNavigator.Topic);
            this.cmb_Cliente.Location = new System.Drawing.Point(159, 63);
            this.cmb_Cliente.Name = "cmb_Cliente";
            this.HelpProviderHG.SetShowHelp(this.cmb_Cliente, true);
            this.cmb_Cliente.Size = new System.Drawing.Size(167, 21);
            this.cmb_Cliente.TabIndex = 5;
            // 
            // btn_GuardarReserva
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_GuardarReserva, "Alta_Reserva.htm#btn_GuardarReserva");
            this.HelpProviderHG.SetHelpNavigator(this.btn_GuardarReserva, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_GuardarReserva.Location = new System.Drawing.Point(599, 370);
            this.btn_GuardarReserva.Name = "btn_GuardarReserva";
            this.HelpProviderHG.SetShowHelp(this.btn_GuardarReserva, true);
            this.btn_GuardarReserva.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarReserva.TabIndex = 28;
            this.btn_GuardarReserva.Text = "Aceptar";
            this.btn_GuardarReserva.UseVisualStyleBackColor = true;
            this.btn_GuardarReserva.Click += new System.EventHandler(this.btn_GuardarReserva_Click);
            // 
            // btn_CancelarEmpleado
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_CancelarEmpleado, "Alta_Reserva.htm#btn_CancelarEmpleado");
            this.HelpProviderHG.SetHelpNavigator(this.btn_CancelarEmpleado, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_CancelarEmpleado.Location = new System.Drawing.Point(505, 370);
            this.btn_CancelarEmpleado.Name = "btn_CancelarEmpleado";
            this.HelpProviderHG.SetShowHelp(this.btn_CancelarEmpleado, true);
            this.btn_CancelarEmpleado.Size = new System.Drawing.Size(89, 29);
            this.btn_CancelarEmpleado.TabIndex = 27;
            this.btn_CancelarEmpleado.Text = "Cancelar";
            this.btn_CancelarEmpleado.UseVisualStyleBackColor = true;
            this.btn_CancelarEmpleado.Click += new System.EventHandler(this.btn_CancelarEmpleado_Click);
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 409);
            this.Controls.Add(this.btn_GuardarReserva);
            this.Controls.Add(this.btn_CancelarEmpleado);
            this.Controls.Add(this.groupBox1);
            this.HelpProviderHG.SetHelpKeyword(this, "Alta_Reserva.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "Reserva";
            this.HelpProviderHG.SetShowHelp(this, true);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clb_servicios;
        private System.Windows.Forms.Button btn_GuardarReserva;
        private System.Windows.Forms.Button btn_CancelarEmpleado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox clb_habitaciones;
        private System.Windows.Forms.ComboBox cmb_Cliente;
        private System.Windows.Forms.Label lbl_errorCliente;
        private System.Windows.Forms.Label lbl_errorHabitacion;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}