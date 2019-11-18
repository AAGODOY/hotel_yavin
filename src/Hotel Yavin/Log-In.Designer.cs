namespace Hotel_Yavin
{
    partial class Log_In
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreUsu = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txt_NombreUsu
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_NombreUsu, "LogIn.htm#label1");
            this.HelpProviderHG.SetHelpNavigator(this.txt_NombreUsu, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_NombreUsu.Location = new System.Drawing.Point(12, 32);
            this.txt_NombreUsu.Name = "txt_NombreUsu";
            this.HelpProviderHG.SetShowHelp(this.txt_NombreUsu, true);
            this.txt_NombreUsu.Size = new System.Drawing.Size(196, 20);
            this.txt_NombreUsu.TabIndex = 1;
            // 
            // txt_contraseña
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_contraseña, "LogIn.htm#label2");
            this.HelpProviderHG.SetHelpNavigator(this.txt_contraseña, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_contraseña.Location = new System.Drawing.Point(12, 83);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.HelpProviderHG.SetShowHelp(this.txt_contraseña, true);
            this.txt_contraseña.Size = new System.Drawing.Size(196, 20);
            this.txt_contraseña.TabIndex = 2;
            // 
            // btn_Ingresar
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_Ingresar, "LogIn.htm#btn_Ingresar");
            this.HelpProviderHG.SetHelpNavigator(this.btn_Ingresar, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_Ingresar.Location = new System.Drawing.Point(76, 126);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.HelpProviderHG.SetShowHelp(this.btn_Ingresar, true);
            this.btn_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ingresar.TabIndex = 3;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 161);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_NombreUsu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpProviderHG.SetHelpKeyword(this, "LogIn.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "Log_In";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "Log_In";
            this.Load += new System.EventHandler(this.Log_In_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreUsu;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}