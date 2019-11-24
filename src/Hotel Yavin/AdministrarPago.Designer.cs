namespace Hotel_Yavin
{
    partial class AdministrarPago
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
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_totalAPagar = new System.Windows.Forms.Label();
            this.lbl_totalPagado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_habilitar = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_totalAPagar);
            this.groupBox1.Controls.Add(this.lbl_totalPagado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_habilitar);
            this.groupBox1.Controls.Add(this.btn_alta);
            this.groupBox1.Controls.Add(this.btn_baja);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 312);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pago/s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "$";
            // 
            // lbl_totalAPagar
            // 
            this.lbl_totalAPagar.AutoSize = true;
            this.lbl_totalAPagar.Location = new System.Drawing.Point(284, 244);
            this.lbl_totalAPagar.Name = "lbl_totalAPagar";
            this.lbl_totalAPagar.Size = new System.Drawing.Size(77, 13);
            this.lbl_totalAPagar.TabIndex = 13;
            this.lbl_totalAPagar.Text = "Total a Pagar: ";
            // 
            // lbl_totalPagado
            // 
            this.lbl_totalPagado.AutoSize = true;
            this.lbl_totalPagado.Location = new System.Drawing.Point(85, 244);
            this.lbl_totalPagado.Name = "lbl_totalPagado";
            this.lbl_totalPagado.Size = new System.Drawing.Size(13, 13);
            this.lbl_totalPagado.TabIndex = 12;
            this.lbl_totalPagado.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Pagado: ";
            // 
            // btn_habilitar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_habilitar, "AdministrarPago.htm#btn_habilitar");
            this.HelpProviderHG.SetHelpNavigator(this.btn_habilitar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_habilitar.Location = new System.Drawing.Point(334, 277);
            this.btn_habilitar.Name = "btn_habilitar";
            this.HelpProviderHG.SetShowHelp(this.btn_habilitar, true);
            this.btn_habilitar.Size = new System.Drawing.Size(89, 29);
            this.btn_habilitar.TabIndex = 10;
            this.btn_habilitar.Text = "Habilitar";
            this.btn_habilitar.UseVisualStyleBackColor = true;
            // 
            // btn_alta
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_alta, "AdministrarPago.htm#btn_alta");
            this.HelpProviderHG.SetHelpNavigator(this.btn_alta, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_alta.Location = new System.Drawing.Point(9, 277);
            this.btn_alta.Name = "btn_alta";
            this.HelpProviderHG.SetShowHelp(this.btn_alta, true);
            this.btn_alta.Size = new System.Drawing.Size(89, 29);
            this.btn_alta.TabIndex = 9;
            this.btn_alta.Text = "Alta";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_baja
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_baja, "AdministrarPago.htm#btn_baja");
            this.HelpProviderHG.SetHelpNavigator(this.btn_baja, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_baja.Location = new System.Drawing.Point(226, 277);
            this.btn_baja.Name = "btn_baja";
            this.HelpProviderHG.SetShowHelp(this.btn_baja, true);
            this.btn_baja.Size = new System.Drawing.Size(89, 29);
            this.btn_baja.TabIndex = 8;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_modificar, "AdministrarPago.htm#btn_modificar");
            this.HelpProviderHG.SetHelpNavigator(this.btn_modificar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_modificar.Location = new System.Drawing.Point(119, 277);
            this.btn_modificar.Name = "btn_modificar";
            this.HelpProviderHG.SetShowHelp(this.btn_modificar, true);
            this.btn_modificar.Size = new System.Drawing.Size(89, 29);
            this.btn_modificar.TabIndex = 7;
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
            this.HelpProviderHG.SetHelpKeyword(this.dataGridView1, "AdministrarPago.htm#dataGridView1");
            this.HelpProviderHG.SetHelpNavigator(this.dataGridView1, System.Windows.Forms.HelpNavigator.Topic);
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HelpProviderHG.SetShowHelp(this.dataGridView1, true);
            this.dataGridView1.Size = new System.Drawing.Size(414, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // AdministrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 336);
            this.Controls.Add(this.groupBox1);
            this.HelpProviderHG.SetHelpKeyword(this, "AdministrarPago.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "AdministrarPago";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "AdministrarPago";
            this.Load += new System.EventHandler(this.AdministrarPago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_habilitar;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_totalAPagar;
        private System.Windows.Forms.Label lbl_totalPagado;
        private System.Windows.Forms.Label label1;
    }
}