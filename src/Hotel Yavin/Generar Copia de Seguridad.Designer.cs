namespace Hotel_Yavin
{
    partial class Generar_Copia_de_Seguridad
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
            this.btn_generar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ubicacion = new System.Windows.Forms.TextBox();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.txt_nombreBackup = new System.Windows.Forms.TextBox();
            this.nud_particiones = new System.Windows.Forms.NumericUpDown();
            this.lbl_particiones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_particiones)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(245, 174);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 0;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar ubicacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la copia de seguridad";
            // 
            // txt_ubicacion
            // 
            this.txt_ubicacion.Location = new System.Drawing.Point(35, 58);
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.ReadOnly = true;
            this.txt_ubicacion.Size = new System.Drawing.Size(204, 20);
            this.txt_ubicacion.TabIndex = 3;
            // 
            // btn_examinar
            // 
            this.btn_examinar.Location = new System.Drawing.Point(245, 58);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(75, 23);
            this.btn_examinar.TabIndex = 4;
            this.btn_examinar.Text = "Examinar";
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // txt_nombreBackup
            // 
            this.txt_nombreBackup.Location = new System.Drawing.Point(35, 137);
            this.txt_nombreBackup.Name = "txt_nombreBackup";
            this.txt_nombreBackup.Size = new System.Drawing.Size(285, 20);
            this.txt_nombreBackup.TabIndex = 5;
            // 
            // nud_particiones
            // 
            this.nud_particiones.Location = new System.Drawing.Point(126, 174);
            this.nud_particiones.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_particiones.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_particiones.Name = "nud_particiones";
            this.nud_particiones.ReadOnly = true;
            this.nud_particiones.Size = new System.Drawing.Size(40, 20);
            this.nud_particiones.TabIndex = 6;
            this.nud_particiones.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbl_particiones
            // 
            this.lbl_particiones.AutoSize = true;
            this.lbl_particiones.Location = new System.Drawing.Point(32, 176);
            this.lbl_particiones.Name = "lbl_particiones";
            this.lbl_particiones.Size = new System.Drawing.Size(88, 13);
            this.lbl_particiones.TabIndex = 7;
            this.lbl_particiones.Text = "N° de particiones";
            // 
            // Generar_Copia_de_Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 209);
            this.Controls.Add(this.lbl_particiones);
            this.Controls.Add(this.nud_particiones);
            this.Controls.Add(this.txt_nombreBackup);
            this.Controls.Add(this.btn_examinar);
            this.Controls.Add(this.txt_ubicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_generar);
            this.Name = "Generar_Copia_de_Seguridad";
            this.Text = "Generar Copia de Seguridad";
            this.Load += new System.EventHandler(this.Generar_Copia_de_Seguridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_particiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ubicacion;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.TextBox txt_nombreBackup;
        private System.Windows.Forms.NumericUpDown nud_particiones;
        private System.Windows.Forms.Label lbl_particiones;
    }
}