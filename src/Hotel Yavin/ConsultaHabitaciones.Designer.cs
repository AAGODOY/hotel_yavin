namespace Hotel_Yavin
{
    partial class ConsultaHabitaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_habilitar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_habilitar);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.btn_baja);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.btn_alta);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_habilitar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_habilitar, "ConsultaHabitaciones.htm#btn_habilitar");
            this.HelpProviderHG.SetHelpNavigator(this.btn_habilitar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_habilitar.Location = new System.Drawing.Point(519, 187);
            this.btn_habilitar.Name = "btn_habilitar";
            this.HelpProviderHG.SetShowHelp(this.btn_habilitar, true);
            this.btn_habilitar.Size = new System.Drawing.Size(75, 23);
            this.btn_habilitar.TabIndex = 9;
            this.btn_habilitar.Text = "Habilitar";
            this.btn_habilitar.UseVisualStyleBackColor = true;
            this.btn_habilitar.Click += new System.EventHandler(this.btn_habilitar_Click);
            // 
            // btn_Buscar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_Buscar, "ConsultaHabitaciones.htm#btn_Buscar");
            this.HelpProviderHG.SetHelpNavigator(this.btn_Buscar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_Buscar.Location = new System.Drawing.Point(25, 187);
            this.btn_Buscar.Name = "btn_Buscar";
            this.HelpProviderHG.SetShowHelp(this.btn_Buscar, true);
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 8;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_baja
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_baja, "ConsultaHabitaciones.htm#btn_baja");
            this.HelpProviderHG.SetHelpNavigator(this.btn_baja, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_baja.Location = new System.Drawing.Point(438, 187);
            this.btn_baja.Name = "btn_baja";
            this.HelpProviderHG.SetShowHelp(this.btn_baja, true);
            this.btn_baja.Size = new System.Drawing.Size(75, 23);
            this.btn_baja.TabIndex = 7;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_modificar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_modificar, "ConsultaHabitaciones.htm#btn_modificar");
            this.HelpProviderHG.SetHelpNavigator(this.btn_modificar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_modificar.Location = new System.Drawing.Point(358, 187);
            this.btn_modificar.Name = "btn_modificar";
            this.HelpProviderHG.SetShowHelp(this.btn_modificar, true);
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 6;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_alta
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_alta, "ConsultaHabitaciones.htm#btn_alta");
            this.HelpProviderHG.SetHelpNavigator(this.btn_alta, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_alta.Location = new System.Drawing.Point(277, 187);
            this.btn_alta.Name = "btn_alta";
            this.HelpProviderHG.SetShowHelp(this.btn_alta, true);
            this.btn_alta.Size = new System.Drawing.Size(75, 23);
            this.btn_alta.TabIndex = 5;
            this.btn_alta.Text = "Nuevo";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HelpProviderHG.SetHelpKeyword(this.dataGridView1, "ConsultaHabitaciones.htm#dataGridView1");
            this.HelpProviderHG.SetHelpNavigator(this.dataGridView1, System.Windows.Forms.HelpNavigator.Topic);
            this.dataGridView1.Location = new System.Drawing.Point(25, 68);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HelpProviderHG.SetShowHelp(this.dataGridView1, true);
            this.dataGridView1.Size = new System.Drawing.Size(569, 111);
            this.dataGridView1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.HelpProviderHG.SetHelpKeyword(this.dateTimePicker2, "ConsultaHabitaciones.htm#label2");
            this.HelpProviderHG.SetHelpNavigator(this.dateTimePicker2, System.Windows.Forms.HelpNavigator.Topic);
            this.dateTimePicker2.Location = new System.Drawing.Point(394, 27);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.HelpProviderHG.SetShowHelp(this.dateTimePicker2, true);
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.HelpProviderHG.SetHelpKeyword(this.dateTimePicker1, "ConsultaHabitaciones.htm#label1");
            this.HelpProviderHG.SetHelpNavigator(this.dateTimePicker1, System.Windows.Forms.HelpNavigator.Topic);
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.HelpProviderHG.SetShowHelp(this.dateTimePicker1, true);
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Desde";
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // ConsultaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 270);
            this.Controls.Add(this.groupBox1);
            this.HelpProviderHG.SetHelpKeyword(this, "ConsultaHabitaciones.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "ConsultaHabitaciones";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "ConsultaHabitaciones";
            this.Load += new System.EventHandler(this.ConsultaHabitaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_habilitar;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}