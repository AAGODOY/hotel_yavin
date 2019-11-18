namespace Hotel_Yavin
{
    partial class ModificarPatente
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
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_descripcion, "ModificarPatente.htm#label1");
            this.HelpProviderHG.SetHelpNavigator(this.txt_descripcion, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_descripcion.Location = new System.Drawing.Point(81, 27);
            this.txt_descripcion.Name = "txt_descripcion";
            this.HelpProviderHG.SetShowHelp(this.txt_descripcion, true);
            this.txt_descripcion.Size = new System.Drawing.Size(175, 20);
            this.txt_descripcion.TabIndex = 1;
            // 
            // btn_Guardar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_Guardar, "ModificarPatente.htm#btn_Guardar");
            this.HelpProviderHG.SetHelpNavigator(this.btn_Guardar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_Guardar.Location = new System.Drawing.Point(168, 62);
            this.btn_Guardar.Name = "btn_Guardar";
            this.HelpProviderHG.SetShowHelp(this.btn_Guardar, true);
            this.btn_Guardar.Size = new System.Drawing.Size(89, 29);
            this.btn_Guardar.TabIndex = 17;
            this.btn_Guardar.Text = "Aceptar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_GuardarUsuario_Click);
            // 
            // btn_Cancelar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_Cancelar, "ModificarPatente.htm#btn_Cancelar");
            this.HelpProviderHG.SetHelpNavigator(this.btn_Cancelar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_Cancelar.Location = new System.Drawing.Point(73, 62);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.HelpProviderHG.SetShowHelp(this.btn_Cancelar, true);
            this.btn_Cancelar.Size = new System.Drawing.Size(89, 29);
            this.btn_Cancelar.TabIndex = 16;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_CancelarUsuario_Click);
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // ModificarPatente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 119);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label1);
            this.HelpProviderHG.SetHelpKeyword(this, "ModificarPatente.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "ModificarPatente";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "Modificar Patente";
            this.Load += new System.EventHandler(this.ModificarPatente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}