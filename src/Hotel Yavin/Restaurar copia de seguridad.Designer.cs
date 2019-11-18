namespace Hotel_Yavin
{
    partial class Restaurar_copia_de_seguridad
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
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.dgv_listadoBackups = new System.Windows.Forms.DataGridView();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoBackups)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Copia de Seguridad";
            // 
            // btn_restaurar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_restaurar, "Restaurar_copia_de_seguridad.htm#btn_restaurar");
            this.HelpProviderHG.SetHelpNavigator(this.btn_restaurar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_restaurar.Location = new System.Drawing.Point(256, 200);
            this.btn_restaurar.Name = "btn_restaurar";
            this.HelpProviderHG.SetShowHelp(this.btn_restaurar, true);
            this.btn_restaurar.Size = new System.Drawing.Size(75, 23);
            this.btn_restaurar.TabIndex = 3;
            this.btn_restaurar.Text = "Restaurar";
            this.btn_restaurar.UseVisualStyleBackColor = true;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // dgv_listadoBackups
            // 
            this.dgv_listadoBackups.AllowUserToAddRows = false;
            this.dgv_listadoBackups.AllowUserToDeleteRows = false;
            this.dgv_listadoBackups.AllowUserToOrderColumns = true;
            this.dgv_listadoBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HelpProviderHG.SetHelpKeyword(this.dgv_listadoBackups, "Restaurar_copia_de_seguridad.htm#dgv_listadoBackups");
            this.HelpProviderHG.SetHelpNavigator(this.dgv_listadoBackups, System.Windows.Forms.HelpNavigator.Topic);
            this.dgv_listadoBackups.Location = new System.Drawing.Point(27, 44);
            this.dgv_listadoBackups.MultiSelect = false;
            this.dgv_listadoBackups.Name = "dgv_listadoBackups";
            this.dgv_listadoBackups.ReadOnly = true;
            this.dgv_listadoBackups.RowHeadersVisible = false;
            this.dgv_listadoBackups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HelpProviderHG.SetShowHelp(this.dgv_listadoBackups, true);
            this.dgv_listadoBackups.Size = new System.Drawing.Size(304, 150);
            this.dgv_listadoBackups.TabIndex = 4;
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // Restaurar_copia_de_seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 238);
            this.Controls.Add(this.dgv_listadoBackups);
            this.Controls.Add(this.btn_restaurar);
            this.Controls.Add(this.label1);
            this.HelpProviderHG.SetHelpKeyword(this, "Restaurar_copia_de_seguridad.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "Restaurar_copia_de_seguridad";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "Restaurar copia de seguridad";
            this.Load += new System.EventHandler(this.Restaurar_copia_de_seguridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoBackups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.DataGridView dgv_listadoBackups;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}