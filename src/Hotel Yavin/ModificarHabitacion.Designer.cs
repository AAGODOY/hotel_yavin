namespace Hotel_Yavin
{
    partial class ModificarHabitacion
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
            this.txt_numHabitacion = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_TipoHabitacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btn_GuardarCliente
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_GuardarCliente, "ModificarHabitacion.htm#btn_GuardarCliente");
            this.HelpProviderHG.SetHelpNavigator(this.btn_GuardarCliente, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_GuardarCliente.Location = new System.Drawing.Point(150, 146);
            this.btn_GuardarCliente.Name = "btn_GuardarCliente";
            this.HelpProviderHG.SetShowHelp(this.btn_GuardarCliente, true);
            this.btn_GuardarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarCliente.TabIndex = 41;
            this.btn_GuardarCliente.Text = "Aceptar";
            this.btn_GuardarCliente.UseVisualStyleBackColor = true;
            this.btn_GuardarCliente.Click += new System.EventHandler(this.btn_GuardarCliente_Click);
            // 
            // btn_CancelarCliente
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_CancelarCliente, "ModificarHabitacion.htm#btn_CancelarCliente");
            this.HelpProviderHG.SetHelpNavigator(this.btn_CancelarCliente, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_CancelarCliente.Location = new System.Drawing.Point(56, 146);
            this.btn_CancelarCliente.Name = "btn_CancelarCliente";
            this.HelpProviderHG.SetShowHelp(this.btn_CancelarCliente, true);
            this.btn_CancelarCliente.Size = new System.Drawing.Size(89, 29);
            this.btn_CancelarCliente.TabIndex = 40;
            this.btn_CancelarCliente.Text = "Cancelar";
            this.btn_CancelarCliente.UseVisualStyleBackColor = true;
            // 
            // txt_precio
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_precio, "ModificarHabitacion.htm#label4");
            this.HelpProviderHG.SetHelpNavigator(this.txt_precio, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_precio.Location = new System.Drawing.Point(116, 109);
            this.txt_precio.Name = "txt_precio";
            this.HelpProviderHG.SetShowHelp(this.txt_precio, true);
            this.txt_precio.Size = new System.Drawing.Size(123, 20);
            this.txt_precio.TabIndex = 39;
            // 
            // txt_numHabitacion
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_numHabitacion, "ModificarHabitacion.htm#label3");
            this.HelpProviderHG.SetHelpNavigator(this.txt_numHabitacion, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_numHabitacion.Location = new System.Drawing.Point(116, 78);
            this.txt_numHabitacion.Name = "txt_numHabitacion";
            this.HelpProviderHG.SetShowHelp(this.txt_numHabitacion, true);
            this.txt_numHabitacion.Size = new System.Drawing.Size(123, 20);
            this.txt_numHabitacion.TabIndex = 38;
            // 
            // txt_descripcion
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_descripcion, "ModificarHabitacion.htm#label2");
            this.HelpProviderHG.SetHelpNavigator(this.txt_descripcion, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_descripcion.Location = new System.Drawing.Point(116, 46);
            this.txt_descripcion.Name = "txt_descripcion";
            this.HelpProviderHG.SetShowHelp(this.txt_descripcion, true);
            this.txt_descripcion.Size = new System.Drawing.Size(123, 20);
            this.txt_descripcion.TabIndex = 37;
            // 
            // txt_TipoHabitacion
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_TipoHabitacion, "ModificarHabitacion.htm#label1");
            this.HelpProviderHG.SetHelpNavigator(this.txt_TipoHabitacion, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_TipoHabitacion.Location = new System.Drawing.Point(116, 15);
            this.txt_TipoHabitacion.Name = "txt_TipoHabitacion";
            this.HelpProviderHG.SetShowHelp(this.txt_TipoHabitacion, true);
            this.txt_TipoHabitacion.Size = new System.Drawing.Size(123, 20);
            this.txt_TipoHabitacion.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nro de Habitación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tipo de Habitación";
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // ModificarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 197);
            this.Controls.Add(this.btn_GuardarCliente);
            this.Controls.Add(this.btn_CancelarCliente);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_numHabitacion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_TipoHabitacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpProviderHG.SetHelpKeyword(this, "ModificarHabitacion.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "ModificarHabitacion";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "ModificarHabitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GuardarCliente;
        private System.Windows.Forms.Button btn_CancelarCliente;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_numHabitacion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_TipoHabitacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}