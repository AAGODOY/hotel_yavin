namespace Hotel_Yavin
{
    partial class Bitacora
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clb_criticidad = new System.Windows.Forms.CheckedListBox();
            this.clb_Usuarios = new System.Windows.Forms.CheckedListBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_bitacora = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_GenerarReporte = new System.Windows.Forms.Button();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Desde";
            // 
            // dtp_fechaDesde
            // 
            this.HelpProviderHG.SetHelpKeyword(this.dtp_fechaDesde, "Bitacora.htm#label1");
            this.HelpProviderHG.SetHelpNavigator(this.dtp_fechaDesde, System.Windows.Forms.HelpNavigator.Topic);
            this.dtp_fechaDesde.Location = new System.Drawing.Point(85, 19);
            this.dtp_fechaDesde.Name = "dtp_fechaDesde";
            this.HelpProviderHG.SetShowHelp(this.dtp_fechaDesde, true);
            this.dtp_fechaDesde.Size = new System.Drawing.Size(248, 20);
            this.dtp_fechaDesde.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Hasta";
            // 
            // dtp_fechaHasta
            // 
            this.HelpProviderHG.SetHelpKeyword(this.dtp_fechaHasta, "Bitacora.htm#label2");
            this.HelpProviderHG.SetHelpNavigator(this.dtp_fechaHasta, System.Windows.Forms.HelpNavigator.Topic);
            this.dtp_fechaHasta.Location = new System.Drawing.Point(491, 20);
            this.dtp_fechaHasta.Name = "dtp_fechaHasta";
            this.HelpProviderHG.SetShowHelp(this.dtp_fechaHasta, true);
            this.dtp_fechaHasta.Size = new System.Drawing.Size(248, 20);
            this.dtp_fechaHasta.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clb_criticidad);
            this.groupBox1.Controls.Add(this.clb_Usuarios);
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_fechaDesde);
            this.groupBox1.Controls.Add(this.dtp_fechaHasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 243);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // clb_criticidad
            // 
            this.clb_criticidad.FormattingEnabled = true;
            this.HelpProviderHG.SetHelpKeyword(this.clb_criticidad, "Bitacora.htm#label4");
            this.HelpProviderHG.SetHelpNavigator(this.clb_criticidad, System.Windows.Forms.HelpNavigator.Topic);
            this.clb_criticidad.Location = new System.Drawing.Point(491, 55);
            this.clb_criticidad.Name = "clb_criticidad";
            this.HelpProviderHG.SetShowHelp(this.clb_criticidad, true);
            this.clb_criticidad.Size = new System.Drawing.Size(248, 139);
            this.clb_criticidad.TabIndex = 11;
            // 
            // clb_Usuarios
            // 
            this.clb_Usuarios.FormattingEnabled = true;
            this.HelpProviderHG.SetHelpKeyword(this.clb_Usuarios, "Bitacora.htm#label3");
            this.HelpProviderHG.SetHelpNavigator(this.clb_Usuarios, System.Windows.Forms.HelpNavigator.Topic);
            this.clb_Usuarios.Location = new System.Drawing.Point(85, 55);
            this.clb_Usuarios.Name = "clb_Usuarios";
            this.HelpProviderHG.SetShowHelp(this.clb_Usuarios, true);
            this.clb_Usuarios.Size = new System.Drawing.Size(248, 139);
            this.clb_Usuarios.TabIndex = 10;
            // 
            // Btn_Buscar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.Btn_Buscar, "Bitacora.htm#Btn_Buscar");
            this.HelpProviderHG.SetHelpNavigator(this.Btn_Buscar, System.Windows.Forms.HelpNavigator.Topic);
            this.Btn_Buscar.Location = new System.Drawing.Point(654, 214);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.HelpProviderHG.SetShowHelp(this.Btn_Buscar, true);
            this.Btn_Buscar.Size = new System.Drawing.Size(85, 23);
            this.Btn_Buscar.TabIndex = 9;
            this.Btn_Buscar.Text = "BUSCAR";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Criticidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuarios";
            // 
            // dgv_bitacora
            // 
            this.dgv_bitacora.AllowUserToAddRows = false;
            this.dgv_bitacora.AllowUserToDeleteRows = false;
            this.dgv_bitacora.AllowUserToOrderColumns = true;
            this.dgv_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HelpProviderHG.SetHelpKeyword(this.dgv_bitacora, "Bitacora.htm#dgv_bitacora");
            this.HelpProviderHG.SetHelpNavigator(this.dgv_bitacora, System.Windows.Forms.HelpNavigator.Topic);
            this.dgv_bitacora.Location = new System.Drawing.Point(12, 298);
            this.dgv_bitacora.Name = "dgv_bitacora";
            this.dgv_bitacora.ReadOnly = true;
            this.dgv_bitacora.RowHeadersVisible = false;
            this.dgv_bitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HelpProviderHG.SetShowHelp(this.dgv_bitacora, true);
            this.dgv_bitacora.Size = new System.Drawing.Size(767, 193);
            this.dgv_bitacora.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Movimientos del Sistema";
            // 
            // btn_GenerarReporte
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_GenerarReporte, "Bitacora.htm#btn_GenerarReporte");
            this.HelpProviderHG.SetHelpNavigator(this.btn_GenerarReporte, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_GenerarReporte.Location = new System.Drawing.Point(682, 497);
            this.btn_GenerarReporte.Name = "btn_GenerarReporte";
            this.HelpProviderHG.SetShowHelp(this.btn_GenerarReporte, true);
            this.btn_GenerarReporte.Size = new System.Drawing.Size(98, 33);
            this.btn_GenerarReporte.TabIndex = 11;
            this.btn_GenerarReporte.Text = "Generar Reporte";
            this.btn_GenerarReporte.UseVisualStyleBackColor = true;
            this.btn_GenerarReporte.Click += new System.EventHandler(this.btn_GenerarReporte_Click);
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 542);
            this.Controls.Add(this.btn_GenerarReporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_bitacora);
            this.Controls.Add(this.groupBox1);
            this.HelpProviderHG.SetHelpKeyword(this, "Bitacora.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "Bitacora";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fechaHasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.DataGridView dgv_bitacora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_GenerarReporte;
        private System.Windows.Forms.CheckedListBox clb_Usuarios;
        private System.Windows.Forms.CheckedListBox clb_criticidad;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}