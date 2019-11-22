namespace Hotel_Yavin
{
    partial class ModificarReserva
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
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.clb_habitaciones = new System.Windows.Forms.CheckedListBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.clb_servicios = new System.Windows.Forms.CheckedListBox();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_errorHabitacion = new System.Windows.Forms.Label();
            this.lbl_errorCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFIngreso = new System.Windows.Forms.Label();
            this.lblFSalida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // btn_Guardar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_Guardar, "Alta_Reserva.htm#btn_GuardarReserva");
            this.HelpProviderHG.SetHelpNavigator(this.btn_Guardar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_Guardar.Location = new System.Drawing.Point(599, 360);
            this.btn_Guardar.Name = "btn_Guardar";
            this.HelpProviderHG.SetShowHelp(this.btn_Guardar, true);
            this.btn_Guardar.Size = new System.Drawing.Size(89, 29);
            this.btn_Guardar.TabIndex = 31;
            this.btn_Guardar.Text = "Aceptar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_Cancelar, "Alta_Reserva.htm#btn_CancelarEmpleado");
            this.HelpProviderHG.SetHelpNavigator(this.btn_Cancelar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_Cancelar.Location = new System.Drawing.Point(505, 360);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.HelpProviderHG.SetShowHelp(this.btn_Cancelar, true);
            this.btn_Cancelar.Size = new System.Drawing.Size(89, 29);
            this.btn_Cancelar.TabIndex = 30;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
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
            // btn_eliminar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_eliminar, "Alta_Reserva.htm#button3");
            this.HelpProviderHG.SetHelpNavigator(this.btn_eliminar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_eliminar.Location = new System.Drawing.Point(214, 227);
            this.btn_eliminar.Name = "btn_eliminar";
            this.HelpProviderHG.SetShowHelp(this.btn_eliminar, true);
            this.btn_eliminar.Size = new System.Drawing.Size(83, 33);
            this.btn_eliminar.TabIndex = 14;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_modificar, "Alta_Reserva.htm#button2");
            this.HelpProviderHG.SetHelpNavigator(this.btn_modificar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_modificar.Location = new System.Drawing.Point(115, 227);
            this.btn_modificar.Name = "btn_modificar";
            this.HelpProviderHG.SetShowHelp(this.btn_modificar, true);
            this.btn_modificar.Size = new System.Drawing.Size(83, 33);
            this.btn_modificar.TabIndex = 13;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HelpProviderHG.SetHelpKeyword(this.dataGridView1, "Alta_Reserva.htm#dataGridView1");
            this.HelpProviderHG.SetHelpNavigator(this.dataGridView1, System.Windows.Forms.HelpNavigator.Topic);
            this.dataGridView1.Location = new System.Drawing.Point(16, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HelpProviderHG.SetShowHelp(this.dataGridView1, true);
            this.dataGridView1.Size = new System.Drawing.Size(281, 187);
            this.dataGridView1.TabIndex = 12;
            // 
            // btn_agregar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_agregar, "Alta_Reserva.htm#button1");
            this.HelpProviderHG.SetHelpNavigator(this.btn_agregar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_agregar.Location = new System.Drawing.Point(16, 227);
            this.btn_agregar.Name = "btn_agregar";
            this.HelpProviderHG.SetShowHelp(this.btn_agregar, true);
            this.btn_agregar.Size = new System.Drawing.Size(83, 33);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 342);
            this.groupBox1.TabIndex = 29;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_modificar);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Location = new System.Drawing.Point(348, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 271);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Huespedes";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccionar Habitación";
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
            // ModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 405);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.HelpProviderHG.SetHelpKeyword(this, "ModificarReserva.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "ModificarReserva";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "ModificarReserva";
            this.Load += new System.EventHandler(this.ModificarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HelpProvider HelpProviderHG;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_errorHabitacion;
        private System.Windows.Forms.Label lbl_errorCliente;
        private System.Windows.Forms.CheckedListBox clb_habitaciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clb_servicios;
        private System.Windows.Forms.Label lblFIngreso;
        private System.Windows.Forms.Label lblFSalida;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.ComboBox cmb_Cliente;
        private System.Windows.Forms.Label label1;
    }
}