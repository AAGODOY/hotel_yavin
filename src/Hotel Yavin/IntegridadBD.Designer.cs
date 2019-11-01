namespace Hotel_Yavin
{
    partial class IntegridadBD
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lst_Errores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Se detectaron inconsistencias en la integridad de la base de datos del sistema. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(525, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Por favor, comunicarse con el administrador del sistema para solucionar los error" +
    "es que se muestran en la grilla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione el botón \'Recalcular\' para recalcular los Dígitos Verificadores e ingr" +
    "esar a sistema";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "RECALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lst_Errores
            // 
            this.lst_Errores.FormattingEnabled = true;
            this.lst_Errores.Location = new System.Drawing.Point(12, 55);
            this.lst_Errores.Name = "lst_Errores";
            this.lst_Errores.Size = new System.Drawing.Size(522, 186);
            this.lst_Errores.TabIndex = 5;
            // 
            // IntegridadBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 334);
            this.Controls.Add(this.lst_Errores);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IntegridadBD";
            this.Text = "Integridad de la Base de Datos";
            this.Load += new System.EventHandler(this.IntegridadBD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lst_Errores;
    }
}