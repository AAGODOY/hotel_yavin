namespace Hotel_Yavin
{
    partial class Restaurar_copia_de_seguridad
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
            this.txt_copiaSeguridad = new System.Windows.Forms.TextBox();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Copia de Seguridad";
            // 
            // txt_copiaSeguridad
            // 
            this.txt_copiaSeguridad.Location = new System.Drawing.Point(40, 65);
            this.txt_copiaSeguridad.Name = "txt_copiaSeguridad";
            this.txt_copiaSeguridad.Size = new System.Drawing.Size(208, 20);
            this.txt_copiaSeguridad.TabIndex = 1;
            // 
            // btn_examinar
            // 
            this.btn_examinar.Location = new System.Drawing.Point(254, 65);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(75, 23);
            this.btn_examinar.TabIndex = 2;
            this.btn_examinar.Text = "Examinar";
            this.btn_examinar.UseVisualStyleBackColor = true;
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(121, 102);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(75, 23);
            this.btn_restaurar.TabIndex = 3;
            this.btn_restaurar.Text = "Restaurar";
            this.btn_restaurar.UseVisualStyleBackColor = true;
            // 
            // Restaurar_copia_de_seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 152);
            this.Controls.Add(this.btn_restaurar);
            this.Controls.Add(this.btn_examinar);
            this.Controls.Add(this.txt_copiaSeguridad);
            this.Controls.Add(this.label1);
            this.Name = "Restaurar_copia_de_seguridad";
            this.Text = "Restaurar copia de seguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_copiaSeguridad;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.Button btn_restaurar;
    }
}