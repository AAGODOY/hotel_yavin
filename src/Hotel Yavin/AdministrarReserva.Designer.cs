﻿namespace Hotel_Yavin
{
    partial class AdministrarReserva
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
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_opcionesAdicionales = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_alta);
            this.groupBox1.Controls.Add(this.btn_opcionesAdicionales);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 288);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservas Disponibles";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_alta
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_alta, "AdministrarReserva.htm#btn_alta");
            this.HelpProviderHG.SetHelpNavigator(this.btn_alta, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_alta.Location = new System.Drawing.Point(24, 247);
            this.btn_alta.Name = "btn_alta";
            this.HelpProviderHG.SetShowHelp(this.btn_alta, true);
            this.btn_alta.Size = new System.Drawing.Size(121, 29);
            this.btn_alta.TabIndex = 9;
            this.btn_alta.Text = "Alta";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_opcionesAdicionales
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_opcionesAdicionales, "AdministrarReserva.htm#btn_baja");
            this.HelpProviderHG.SetHelpNavigator(this.btn_opcionesAdicionales, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_opcionesAdicionales.Location = new System.Drawing.Point(278, 247);
            this.btn_opcionesAdicionales.Name = "btn_opcionesAdicionales";
            this.HelpProviderHG.SetShowHelp(this.btn_opcionesAdicionales, true);
            this.btn_opcionesAdicionales.Size = new System.Drawing.Size(121, 29);
            this.btn_opcionesAdicionales.TabIndex = 8;
            this.btn_opcionesAdicionales.Text = "Opciones Adicionales";
            this.btn_opcionesAdicionales.UseVisualStyleBackColor = true;
            this.btn_opcionesAdicionales.Click += new System.EventHandler(this.btn_opcionesAdicionales_Click);
            // 
            // btn_modificar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_modificar, "AdministrarReserva.htm#btn_modificar");
            this.HelpProviderHG.SetHelpNavigator(this.btn_modificar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_modificar.Location = new System.Drawing.Point(150, 247);
            this.btn_modificar.Name = "btn_modificar";
            this.HelpProviderHG.SetShowHelp(this.btn_modificar, true);
            this.btn_modificar.Size = new System.Drawing.Size(121, 29);
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
            this.HelpProviderHG.SetHelpKeyword(this.dataGridView1, "AdministrarReserva.htm#dataGridView1");
            this.HelpProviderHG.SetHelpNavigator(this.dataGridView1, System.Windows.Forms.HelpNavigator.Topic);
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HelpProviderHG.SetShowHelp(this.dataGridView1, true);
            this.dataGridView1.Size = new System.Drawing.Size(414, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // AdministrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 311);
            this.Controls.Add(this.groupBox1);
            this.HelpProviderHG.SetHelpKeyword(this, "AdministrarReserva.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "AdministrarReserva";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "Administrar Reserva";
            this.Load += new System.EventHandler(this.AdministrarReserva_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_opcionesAdicionales;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}