namespace Hotel_Yavin
{
    partial class AltaServAdicionales
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
            this.btn_GuardarCliente = new System.Windows.Forms.Button();
            this.btn_CancelarCliente = new System.Windows.Forms.Button();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btn_GuardarCliente
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_GuardarCliente, "AltaServAdicionales.htm#btn_GuardarCliente");
            this.HelpProviderHG.SetHelpNavigator(this.btn_GuardarCliente, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_GuardarCliente.Location = new System.Drawing.Point(169, 102);
            this.btn_GuardarCliente.Name = "btn_GuardarCliente";
            this.HelpProviderHG.SetShowHelp(this.btn_GuardarCliente, true);
            this.btn_GuardarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarCliente.TabIndex = 41;
            this.btn_GuardarCliente.Text = "Aceptar";
            this.btn_GuardarCliente.UseVisualStyleBackColor = true;
            this.btn_GuardarCliente.Click += new System.EventHandler(this.btn_GuardarServicio_Click);
            // 
            // btn_CancelarCliente
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_CancelarCliente, "AltaServAdicionales.htm#btn_CancelarCliente");
            this.HelpProviderHG.SetHelpNavigator(this.btn_CancelarCliente, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_CancelarCliente.Location = new System.Drawing.Point(74, 102);
            this.btn_CancelarCliente.Name = "btn_CancelarCliente";
            this.HelpProviderHG.SetShowHelp(this.btn_CancelarCliente, true);
            this.btn_CancelarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_CancelarCliente.TabIndex = 40;
            this.btn_CancelarCliente.Text = "Cancelar";
            this.btn_CancelarCliente.UseVisualStyleBackColor = true;
            this.btn_CancelarCliente.Click += new System.EventHandler(this.btn_CancelarServicio_Click);
            // 
            // txt_precio
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_precio, "AltaServAdicionales.htm#label4");
            this.HelpProviderHG.SetHelpNavigator(this.txt_precio, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_precio.Location = new System.Drawing.Point(134, 62);
            this.txt_precio.Name = "txt_precio";
            this.HelpProviderHG.SetShowHelp(this.txt_precio, true);
            this.txt_precio.Size = new System.Drawing.Size(123, 20);
            this.txt_precio.TabIndex = 39;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            // 
            // txt_descripcion
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_descripcion, "AltaServAdicionales.htm#label2");
            this.HelpProviderHG.SetHelpNavigator(this.txt_descripcion, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_descripcion.Location = new System.Drawing.Point(134, 26);
            this.txt_descripcion.Name = "txt_descripcion";
            this.HelpProviderHG.SetShowHelp(this.txt_descripcion, true);
            this.txt_descripcion.Size = new System.Drawing.Size(123, 20);
            this.txt_descripcion.TabIndex = 37;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Precio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Descripción";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // AltaServAdicionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 165);
            this.Controls.Add(this.btn_GuardarCliente);
            this.Controls.Add(this.btn_CancelarCliente);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.HelpProviderHG.SetHelpKeyword(this, "AltaServAdicionales.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "AltaServAdicionales";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "Alta Serv. Adicionales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GuardarCliente;
        private System.Windows.Forms.Button btn_CancelarCliente;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}