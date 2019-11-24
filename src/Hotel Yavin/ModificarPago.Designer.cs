namespace Hotel_Yavin
{
    partial class ModificarPago
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
            this.dtp_fechaPago = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_montoPagado = new System.Windows.Forms.TextBox();
            this.btn_GuardarCliente = new System.Windows.Forms.Button();
            this.btn_CancelarCliente = new System.Windows.Forms.Button();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Pago";
            // 
            // dtp_fechaPago
            // 
            this.HelpProviderHG.SetHelpKeyword(this.dtp_fechaPago, "ModificarPagoProvisorio.htm#label1");
            this.HelpProviderHG.SetHelpNavigator(this.dtp_fechaPago, System.Windows.Forms.HelpNavigator.Topic);
            this.dtp_fechaPago.Location = new System.Drawing.Point(130, 19);
            this.dtp_fechaPago.Name = "dtp_fechaPago";
            this.HelpProviderHG.SetShowHelp(this.dtp_fechaPago, true);
            this.dtp_fechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechaPago.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Monto Pagado";
            // 
            // txt_montoPagado
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_montoPagado, "ModificarPagoProvisorio.htm#label5");
            this.HelpProviderHG.SetHelpNavigator(this.txt_montoPagado, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_montoPagado.Location = new System.Drawing.Point(130, 58);
            this.txt_montoPagado.Name = "txt_montoPagado";
            this.HelpProviderHG.SetShowHelp(this.txt_montoPagado, true);
            this.txt_montoPagado.Size = new System.Drawing.Size(200, 20);
            this.txt_montoPagado.TabIndex = 7;
            // 
            // btn_GuardarCliente
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_GuardarCliente, "ModificarPagoProvisorio.htm#btn_GuardarCliente");
            this.HelpProviderHG.SetHelpNavigator(this.btn_GuardarCliente, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_GuardarCliente.Location = new System.Drawing.Point(241, 98);
            this.btn_GuardarCliente.Name = "btn_GuardarCliente";
            this.HelpProviderHG.SetShowHelp(this.btn_GuardarCliente, true);
            this.btn_GuardarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarCliente.TabIndex = 29;
            this.btn_GuardarCliente.Text = "Aceptar";
            this.btn_GuardarCliente.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarCliente
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_CancelarCliente, "ModificarPagoProvisorio.htm#btn_CancelarCliente");
            this.HelpProviderHG.SetHelpNavigator(this.btn_CancelarCliente, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_CancelarCliente.Location = new System.Drawing.Point(130, 98);
            this.btn_CancelarCliente.Name = "btn_CancelarCliente";
            this.HelpProviderHG.SetShowHelp(this.btn_CancelarCliente, true);
            this.btn_CancelarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_CancelarCliente.TabIndex = 28;
            this.btn_CancelarCliente.Text = "Cancelar";
            this.btn_CancelarCliente.UseVisualStyleBackColor = true;
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // ModificarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 155);
            this.Controls.Add(this.btn_GuardarCliente);
            this.Controls.Add(this.btn_CancelarCliente);
            this.Controls.Add(this.txt_montoPagado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_fechaPago);
            this.Controls.Add(this.label1);
            this.HelpProviderHG.SetHelpKeyword(this, "ModificarPagoProvisorio.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "ModificarPago";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "Modificar Pago ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fechaPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_montoPagado;
        private System.Windows.Forms.Button btn_GuardarCliente;
        private System.Windows.Forms.Button btn_CancelarCliente;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}