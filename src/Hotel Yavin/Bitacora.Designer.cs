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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora));
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_GenerarReporte = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dtp_fechaDesde.Location = new System.Drawing.Point(85, 19);
            this.dtp_fechaDesde.Name = "dtp_fechaDesde";
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
            this.dtp_fechaHasta.Location = new System.Drawing.Point(491, 20);
            this.dtp_fechaHasta.Name = "dtp_fechaHasta";
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
            this.clb_criticidad.Location = new System.Drawing.Point(491, 55);
            this.clb_criticidad.Name = "clb_criticidad";
            this.clb_criticidad.Size = new System.Drawing.Size(248, 139);
            this.clb_criticidad.TabIndex = 11;
            // 
            // clb_Usuarios
            // 
            this.clb_Usuarios.FormattingEnabled = true;
            this.clb_Usuarios.Location = new System.Drawing.Point(85, 55);
            this.clb_Usuarios.Name = "clb_Usuarios";
            this.clb_Usuarios.Size = new System.Drawing.Size(248, 139);
            this.clb_Usuarios.TabIndex = 10;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(654, 214);
            this.Btn_Buscar.Name = "Btn_Buscar";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(767, 193);
            this.dataGridView1.TabIndex = 5;
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
            this.btn_GenerarReporte.Location = new System.Drawing.Point(682, 497);
            this.btn_GenerarReporte.Name = "btn_GenerarReporte";
            this.btn_GenerarReporte.Size = new System.Drawing.Size(98, 33);
            this.btn_GenerarReporte.TabIndex = 11;
            this.btn_GenerarReporte.Text = "Generar Reporte";
            this.btn_GenerarReporte.UseVisualStyleBackColor = true;
            this.btn_GenerarReporte.Click += new System.EventHandler(this.btn_GenerarReporte_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 542);
            this.Controls.Add(this.btn_GenerarReporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_GenerarReporte;
        private System.Windows.Forms.CheckedListBox clb_Usuarios;
        private System.Windows.Forms.CheckedListBox clb_criticidad;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}