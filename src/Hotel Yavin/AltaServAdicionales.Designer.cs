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
            this.SuspendLayout();
            // 
            // btn_GuardarCliente
            // 
            this.btn_GuardarCliente.Location = new System.Drawing.Point(169, 102);
            this.btn_GuardarCliente.Name = "btn_GuardarCliente";
            this.btn_GuardarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarCliente.TabIndex = 41;
            this.btn_GuardarCliente.Text = "Aceptar";
            this.btn_GuardarCliente.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarCliente
            // 
            this.btn_CancelarCliente.Location = new System.Drawing.Point(74, 102);
            this.btn_CancelarCliente.Name = "btn_CancelarCliente";
            this.btn_CancelarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_CancelarCliente.TabIndex = 40;
            this.btn_CancelarCliente.Text = "Cancelar";
            this.btn_CancelarCliente.UseVisualStyleBackColor = true;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(134, 62);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(123, 20);
            this.txt_precio.TabIndex = 39;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(134, 26);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(123, 20);
            this.txt_descripcion.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Descripción";
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
            this.Name = "AltaServAdicionales";
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
    }
}