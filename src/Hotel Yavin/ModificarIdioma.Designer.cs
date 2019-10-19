namespace Hotel_Yavin
{
    partial class ModificarIdioma
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
            this.cmb_SeleccionIdioma = new System.Windows.Forms.ComboBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Idioma";
            // 
            // cmb_SeleccionIdioma
            // 
            this.cmb_SeleccionIdioma.FormattingEnabled = true;
            this.cmb_SeleccionIdioma.Location = new System.Drawing.Point(44, 95);
            this.cmb_SeleccionIdioma.Name = "cmb_SeleccionIdioma";
            this.cmb_SeleccionIdioma.Size = new System.Drawing.Size(146, 21);
            this.cmb_SeleccionIdioma.TabIndex = 1;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(115, 136);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 2;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // ModificarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 219);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.cmb_SeleccionIdioma);
            this.Controls.Add(this.label1);
            this.Name = "ModificarIdioma";
            this.Text = "Modificar Idioma";
            this.Load += new System.EventHandler(this.ModificarIdioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_SeleccionIdioma;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}