﻿namespace Hotel_Yavin
{
    partial class Cliente
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
            this.txt_NombreCli = new System.Windows.Forms.TextBox();
            this.lbl_NumDocEmp = new System.Windows.Forms.Label();
            this.txt_NumDocCli = new System.Windows.Forms.TextBox();
            this.lbl_TelCliente = new System.Windows.Forms.Label();
            this.txt_TelCli = new System.Windows.Forms.TextBox();
            this.lbl_MailCli = new System.Windows.Forms.Label();
            this.txt_MailCli = new System.Windows.Forms.TextBox();
            this.btn_GuardarCliente = new System.Windows.Forms.Button();
            this.btn_CancelarCliente = new System.Windows.Forms.Button();
            this.txt_ApellidoCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txt_NombreCli
            // 
            this.txt_NombreCli.Location = new System.Drawing.Point(147, 25);
            this.txt_NombreCli.Name = "txt_NombreCli";
            this.txt_NombreCli.Size = new System.Drawing.Size(220, 20);
            this.txt_NombreCli.TabIndex = 1;
            // 
            // lbl_NumDocEmp
            // 
            this.lbl_NumDocEmp.AutoSize = true;
            this.lbl_NumDocEmp.Location = new System.Drawing.Point(24, 82);
            this.lbl_NumDocEmp.Name = "lbl_NumDocEmp";
            this.lbl_NumDocEmp.Size = new System.Drawing.Size(117, 13);
            this.lbl_NumDocEmp.TabIndex = 2;
            this.lbl_NumDocEmp.Text = "Numero de Documento";
            // 
            // txt_NumDocCli
            // 
            this.txt_NumDocCli.Location = new System.Drawing.Point(147, 79);
            this.txt_NumDocCli.Name = "txt_NumDocCli";
            this.txt_NumDocCli.Size = new System.Drawing.Size(220, 20);
            this.txt_NumDocCli.TabIndex = 3;
            // 
            // lbl_TelCliente
            // 
            this.lbl_TelCliente.AutoSize = true;
            this.lbl_TelCliente.Location = new System.Drawing.Point(24, 108);
            this.lbl_TelCliente.Name = "lbl_TelCliente";
            this.lbl_TelCliente.Size = new System.Drawing.Size(49, 13);
            this.lbl_TelCliente.TabIndex = 4;
            this.lbl_TelCliente.Text = "Teléfono";
            this.lbl_TelCliente.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_TelCli
            // 
            this.txt_TelCli.Location = new System.Drawing.Point(147, 105);
            this.txt_TelCli.Name = "txt_TelCli";
            this.txt_TelCli.Size = new System.Drawing.Size(220, 20);
            this.txt_TelCli.TabIndex = 5;
            // 
            // lbl_MailCli
            // 
            this.lbl_MailCli.AutoSize = true;
            this.lbl_MailCli.Location = new System.Drawing.Point(24, 134);
            this.lbl_MailCli.Name = "lbl_MailCli";
            this.lbl_MailCli.Size = new System.Drawing.Size(32, 13);
            this.lbl_MailCli.TabIndex = 6;
            this.lbl_MailCli.Text = "Email";
            this.lbl_MailCli.Click += new System.EventHandler(this.lbl_MailCli_Click);
            // 
            // txt_MailCli
            // 
            this.txt_MailCli.Location = new System.Drawing.Point(147, 131);
            this.txt_MailCli.Name = "txt_MailCli";
            this.txt_MailCli.Size = new System.Drawing.Size(220, 20);
            this.txt_MailCli.TabIndex = 7;
            // 
            // btn_GuardarCliente
            // 
            this.btn_GuardarCliente.Location = new System.Drawing.Point(278, 165);
            this.btn_GuardarCliente.Name = "btn_GuardarCliente";
            this.btn_GuardarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarCliente.TabIndex = 15;
            this.btn_GuardarCliente.Text = "Aceptar";
            this.btn_GuardarCliente.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarCliente
            // 
            this.btn_CancelarCliente.Location = new System.Drawing.Point(184, 165);
            this.btn_CancelarCliente.Name = "btn_CancelarCliente";
            this.btn_CancelarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_CancelarCliente.TabIndex = 14;
            this.btn_CancelarCliente.Text = "Cancelar";
            this.btn_CancelarCliente.UseVisualStyleBackColor = true;
            // 
            // txt_ApellidoCli
            // 
            this.txt_ApellidoCli.Location = new System.Drawing.Point(147, 53);
            this.txt_ApellidoCli.Name = "txt_ApellidoCli";
            this.txt_ApellidoCli.Size = new System.Drawing.Size(220, 20);
            this.txt_ApellidoCli.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apellido";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 207);
            this.Controls.Add(this.txt_ApellidoCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_GuardarCliente);
            this.Controls.Add(this.btn_CancelarCliente);
            this.Controls.Add(this.txt_MailCli);
            this.Controls.Add(this.lbl_MailCli);
            this.Controls.Add(this.txt_TelCli);
            this.Controls.Add(this.lbl_TelCliente);
            this.Controls.Add(this.txt_NumDocCli);
            this.Controls.Add(this.lbl_NumDocEmp);
            this.Controls.Add(this.txt_NombreCli);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NombreCli;
        private System.Windows.Forms.Label lbl_NumDocEmp;
        private System.Windows.Forms.TextBox txt_NumDocCli;
        private System.Windows.Forms.Label lbl_TelCliente;
        private System.Windows.Forms.TextBox txt_TelCli;
        private System.Windows.Forms.Label lbl_MailCli;
        private System.Windows.Forms.TextBox txt_MailCli;
        private System.Windows.Forms.Button btn_GuardarCliente;
        private System.Windows.Forms.Button btn_CancelarCliente;
        private System.Windows.Forms.TextBox txt_ApellidoCli;
        private System.Windows.Forms.Label label2;
    }
}