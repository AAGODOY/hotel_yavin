namespace Hotel_Yavin
{
    partial class AltaPago
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
            this.txt_montoPagado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_fechaPago = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_GuardarCliente
            // 
            this.btn_GuardarCliente.Location = new System.Drawing.Point(242, 97);
            this.btn_GuardarCliente.Name = "btn_GuardarCliente";
            this.btn_GuardarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarCliente.TabIndex = 35;
            this.btn_GuardarCliente.Text = "Aceptar";
            this.btn_GuardarCliente.UseVisualStyleBackColor = true;
            this.btn_GuardarCliente.Click += new System.EventHandler(this.btn_GuardarCliente_Click);
            // 
            // btn_CancelarCliente
            // 
            this.btn_CancelarCliente.Location = new System.Drawing.Point(131, 97);
            this.btn_CancelarCliente.Name = "btn_CancelarCliente";
            this.btn_CancelarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_CancelarCliente.TabIndex = 34;
            this.btn_CancelarCliente.Text = "Cancelar";
            this.btn_CancelarCliente.UseVisualStyleBackColor = true;
            this.btn_CancelarCliente.Click += new System.EventHandler(this.btn_CancelarCliente_Click);
            // 
            // txt_montoPagado
            // 
            this.txt_montoPagado.Location = new System.Drawing.Point(131, 57);
            this.txt_montoPagado.Name = "txt_montoPagado";
            this.txt_montoPagado.Size = new System.Drawing.Size(200, 20);
            this.txt_montoPagado.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Monto Pagado";
            // 
            // dtp_fechaPago
            // 
            this.dtp_fechaPago.Location = new System.Drawing.Point(131, 18);
            this.dtp_fechaPago.Name = "dtp_fechaPago";
            this.dtp_fechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechaPago.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fecha de Pago";
            // 
            // AltaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 156);
            this.Controls.Add(this.btn_GuardarCliente);
            this.Controls.Add(this.btn_CancelarCliente);
            this.Controls.Add(this.txt_montoPagado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_fechaPago);
            this.Controls.Add(this.label1);
            this.Name = "AltaPago";
            this.Text = "Nuevo Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GuardarCliente;
        private System.Windows.Forms.Button btn_CancelarCliente;
        private System.Windows.Forms.TextBox txt_montoPagado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_fechaPago;
        private System.Windows.Forms.Label label1;
    }
}