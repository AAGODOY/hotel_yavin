﻿namespace Hotel_Yavin
{
    partial class AdministrarFamilia
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
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.dgv_familias = new System.Windows.Forms.DataGridView();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_familias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_habilitar);
            this.groupBox1.Controls.Add(this.btn_alta);
            this.groupBox1.Controls.Add(this.btn_baja);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.dgv_familias);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 288);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Familias Disponibles";
            // 
            // btn_habilitar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_habilitar, "AdministrarFamilia.htm#btn_habilitar");
            this.HelpProviderHG.SetHelpNavigator(this.btn_habilitar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_habilitar.Location = new System.Drawing.Point(331, 247);
            this.btn_habilitar.Name = "btn_habilitar";
            this.HelpProviderHG.SetShowHelp(this.btn_habilitar, true);
            this.btn_habilitar.Size = new System.Drawing.Size(89, 29);
            this.btn_habilitar.TabIndex = 10;
            this.btn_habilitar.Text = "Habilitar";
            this.btn_habilitar.UseVisualStyleBackColor = true;
            this.btn_habilitar.Click += new System.EventHandler(this.btn_habilitar_Click);
            // 
            // btn_alta
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_alta, "AdministrarFamilia.htm#btn_alta");
            this.HelpProviderHG.SetHelpNavigator(this.btn_alta, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_alta.Location = new System.Drawing.Point(6, 247);
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
            this.HelpProviderHG.SetHelpKeyword(this.btn_baja, "AdministrarFamilia.htm#btn_baja");
            this.HelpProviderHG.SetHelpNavigator(this.btn_baja, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_baja.Location = new System.Drawing.Point(223, 247);
            this.btn_baja.Name = "btn_baja";
            this.HelpProviderHG.SetShowHelp(this.btn_baja, true);
            this.btn_baja.Size = new System.Drawing.Size(89, 29);
            this.btn_baja.TabIndex = 8;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_modificar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_modificar, "AdministrarFamilia.htm#btn_modificar");
            this.HelpProviderHG.SetHelpNavigator(this.btn_modificar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_modificar.Location = new System.Drawing.Point(116, 247);
            this.btn_modificar.Name = "btn_modificar";
            this.HelpProviderHG.SetShowHelp(this.btn_modificar, true);
            this.btn_modificar.Size = new System.Drawing.Size(89, 29);
            this.btn_modificar.TabIndex = 7;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // dgv_familias
            // 
            this.dgv_familias.AllowUserToAddRows = false;
            this.dgv_familias.AllowUserToDeleteRows = false;
            this.dgv_familias.AllowUserToOrderColumns = true;
            this.dgv_familias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HelpProviderHG.SetHelpKeyword(this.dgv_familias, "AdministrarFamilia.htm#dgv_familias");
            this.HelpProviderHG.SetHelpNavigator(this.dgv_familias, System.Windows.Forms.HelpNavigator.Topic);
            this.dgv_familias.Location = new System.Drawing.Point(6, 30);
            this.dgv_familias.MultiSelect = false;
            this.dgv_familias.Name = "dgv_familias";
            this.dgv_familias.ReadOnly = true;
            this.dgv_familias.RowHeadersVisible = false;
            this.dgv_familias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HelpProviderHG.SetShowHelp(this.dgv_familias, true);
            this.dgv_familias.Size = new System.Drawing.Size(414, 211);
            this.dgv_familias.TabIndex = 0;
            this.dgv_familias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_familias_MouseClick);
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // AdministrarFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 319);
            this.Controls.Add(this.groupBox1);
            this.HelpProviderHG.SetHelpKeyword(this, "AdministrarFamilia.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "AdministrarFamilia";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "Administrar Familia";
            this.Load += new System.EventHandler(this.AdministrarFamilia_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_familias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_habilitar;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridView dgv_familias;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}