namespace Hotel_Yavin
{
    partial class ModificarIdioma
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
            this.cmb_SeleccionIdioma = new System.Windows.Forms.ComboBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Idioma";
            // 
            // cmb_SeleccionIdioma
            // 
            this.cmb_SeleccionIdioma.FormattingEnabled = true;
            this.HelpProviderHG.SetHelpKeyword(this.cmb_SeleccionIdioma, "ModificarIdioma.htm#label1");
            this.HelpProviderHG.SetHelpNavigator(this.cmb_SeleccionIdioma, System.Windows.Forms.HelpNavigator.Topic);
            this.cmb_SeleccionIdioma.Location = new System.Drawing.Point(44, 95);
            this.cmb_SeleccionIdioma.Name = "cmb_SeleccionIdioma";
            this.HelpProviderHG.SetShowHelp(this.cmb_SeleccionIdioma, true);
            this.cmb_SeleccionIdioma.Size = new System.Drawing.Size(146, 21);
            this.cmb_SeleccionIdioma.TabIndex = 1;
            this.cmb_SeleccionIdioma.SelectedIndexChanged += new System.EventHandler(this.cmb_SeleccionIdioma_SelectedIndexChanged);
            // 
            // btn_Aceptar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_Aceptar, "ModificarIdioma.htm#btn_Aceptar");
            this.HelpProviderHG.SetHelpNavigator(this.btn_Aceptar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_Aceptar.Location = new System.Drawing.Point(115, 136);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.HelpProviderHG.SetShowHelp(this.btn_Aceptar, true);
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 2;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // ModificarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 219);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.cmb_SeleccionIdioma);
            this.Controls.Add(this.label1);
            this.HelpProviderHG.SetHelpKeyword(this, "ModificarIdioma.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "ModificarIdioma";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "Modificar Idioma";
            this.Load += new System.EventHandler(this.ModificarIdioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_SeleccionIdioma;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}