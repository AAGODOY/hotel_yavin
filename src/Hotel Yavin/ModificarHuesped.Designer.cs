namespace Hotel_Yavin
{
    partial class ModificarHuesped
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
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_GuardarCliente = new System.Windows.Forms.Button();
            this.btn_CancelarCliente = new System.Windows.Forms.Button();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.lbl_MailCli = new System.Windows.Forms.Label();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.lbl_TelCliente = new System.Windows.Forms.Label();
            this.txt_NumDoc = new System.Windows.Forms.TextBox();
            this.lbl_NumDocEmp = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // txt_Apellido
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_Apellido, "ModificarHuesped.htm#label2");
            this.HelpProviderHG.SetHelpNavigator(this.txt_Apellido, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_Apellido.Location = new System.Drawing.Point(136, 40);
            this.txt_Apellido.Name = "txt_Apellido";
            this.HelpProviderHG.SetShowHelp(this.txt_Apellido, true);
            this.txt_Apellido.Size = new System.Drawing.Size(220, 20);
            this.txt_Apellido.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Apellido";
            // 
            // btn_GuardarCliente
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_GuardarCliente, "ModificarHuesped.htm#btn_GuardarCliente");
            this.HelpProviderHG.SetHelpNavigator(this.btn_GuardarCliente, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_GuardarCliente.Location = new System.Drawing.Point(267, 152);
            this.btn_GuardarCliente.Name = "btn_GuardarCliente";
            this.HelpProviderHG.SetShowHelp(this.btn_GuardarCliente, true);
            this.btn_GuardarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarCliente.TabIndex = 39;
            this.btn_GuardarCliente.Text = "Aceptar";
            this.btn_GuardarCliente.UseVisualStyleBackColor = true;
            this.btn_GuardarCliente.Click += new System.EventHandler(this.btn_GuardarCliente_Click);
            // 
            // btn_CancelarCliente
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_CancelarCliente, "ModificarHuesped.htm#btn_CancelarCliente");
            this.HelpProviderHG.SetHelpNavigator(this.btn_CancelarCliente, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_CancelarCliente.Location = new System.Drawing.Point(173, 152);
            this.btn_CancelarCliente.Name = "btn_CancelarCliente";
            this.HelpProviderHG.SetShowHelp(this.btn_CancelarCliente, true);
            this.btn_CancelarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_CancelarCliente.TabIndex = 38;
            this.btn_CancelarCliente.Text = "Cancelar";
            this.btn_CancelarCliente.UseVisualStyleBackColor = true;
            this.btn_CancelarCliente.Click += new System.EventHandler(this.btn_CancelarCliente_Click);
            // 
            // txt_Mail
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_Mail, "ModificarHuesped.htm#lbl_MailCli");
            this.HelpProviderHG.SetHelpNavigator(this.txt_Mail, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_Mail.Location = new System.Drawing.Point(136, 118);
            this.txt_Mail.Name = "txt_Mail";
            this.HelpProviderHG.SetShowHelp(this.txt_Mail, true);
            this.txt_Mail.Size = new System.Drawing.Size(220, 20);
            this.txt_Mail.TabIndex = 37;
            // 
            // lbl_MailCli
            // 
            this.lbl_MailCli.AutoSize = true;
            this.lbl_MailCli.Location = new System.Drawing.Point(13, 121);
            this.lbl_MailCli.Name = "lbl_MailCli";
            this.lbl_MailCli.Size = new System.Drawing.Size(32, 13);
            this.lbl_MailCli.TabIndex = 36;
            this.lbl_MailCli.Text = "Email";
            // 
            // txt_Tel
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_Tel, "ModificarHuesped.htm#lbl_TelCliente");
            this.HelpProviderHG.SetHelpNavigator(this.txt_Tel, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_Tel.Location = new System.Drawing.Point(136, 92);
            this.txt_Tel.Name = "txt_Tel";
            this.HelpProviderHG.SetShowHelp(this.txt_Tel, true);
            this.txt_Tel.Size = new System.Drawing.Size(220, 20);
            this.txt_Tel.TabIndex = 35;
            // 
            // lbl_TelCliente
            // 
            this.lbl_TelCliente.AutoSize = true;
            this.lbl_TelCliente.Location = new System.Drawing.Point(13, 95);
            this.lbl_TelCliente.Name = "lbl_TelCliente";
            this.lbl_TelCliente.Size = new System.Drawing.Size(49, 13);
            this.lbl_TelCliente.TabIndex = 34;
            this.lbl_TelCliente.Text = "Teléfono";
            // 
            // txt_NumDoc
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_NumDoc, "ModificarHuesped.htm#lbl_NumDocEmp");
            this.HelpProviderHG.SetHelpNavigator(this.txt_NumDoc, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_NumDoc.Location = new System.Drawing.Point(136, 66);
            this.txt_NumDoc.Name = "txt_NumDoc";
            this.HelpProviderHG.SetShowHelp(this.txt_NumDoc, true);
            this.txt_NumDoc.Size = new System.Drawing.Size(220, 20);
            this.txt_NumDoc.TabIndex = 33;
            // 
            // lbl_NumDocEmp
            // 
            this.lbl_NumDocEmp.AutoSize = true;
            this.lbl_NumDocEmp.Location = new System.Drawing.Point(13, 69);
            this.lbl_NumDocEmp.Name = "lbl_NumDocEmp";
            this.lbl_NumDocEmp.Size = new System.Drawing.Size(117, 13);
            this.lbl_NumDocEmp.TabIndex = 32;
            this.lbl_NumDocEmp.Text = "Numero de Documento";
            // 
            // txt_Nombre
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_Nombre, "ModificarHuesped.htm#label1");
            this.HelpProviderHG.SetHelpNavigator(this.txt_Nombre, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_Nombre.Location = new System.Drawing.Point(136, 12);
            this.txt_Nombre.Name = "txt_Nombre";
            this.HelpProviderHG.SetShowHelp(this.txt_Nombre, true);
            this.txt_Nombre.Size = new System.Drawing.Size(220, 20);
            this.txt_Nombre.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre";
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // ModificarHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 196);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_GuardarCliente);
            this.Controls.Add(this.btn_CancelarCliente);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.lbl_MailCli);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.lbl_TelCliente);
            this.Controls.Add(this.txt_NumDoc);
            this.Controls.Add(this.lbl_NumDocEmp);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label1);
            this.HelpProviderHG.SetHelpKeyword(this, "ModificarHuesped.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "ModificarHuesped";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "ModificarHuesped";
            this.Load += new System.EventHandler(this.ModificarHuesped_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_GuardarCliente;
        private System.Windows.Forms.Button btn_CancelarCliente;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label lbl_MailCli;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.Label lbl_TelCliente;
        private System.Windows.Forms.TextBox txt_NumDoc;
        private System.Windows.Forms.Label lbl_NumDocEmp;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}