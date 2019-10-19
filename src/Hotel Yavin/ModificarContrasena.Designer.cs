namespace Hotel_Yavin
{
    partial class Modificar_Contrasena
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
            this.txt_ContraseñaActual = new System.Windows.Forms.TextBox();
            this.txt_NuevaContraseña = new System.Windows.Forms.TextBox();
            this.txt_ConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Nueva Contraseña";
            // 
            // txt_ContraseñaActual
            // 
            this.txt_ContraseñaActual.Location = new System.Drawing.Point(35, 46);
            this.txt_ContraseñaActual.Name = "txt_ContraseñaActual";
            this.txt_ContraseñaActual.Size = new System.Drawing.Size(172, 20);
            this.txt_ContraseñaActual.TabIndex = 3;
            // 
            // txt_NuevaContraseña
            // 
            this.txt_NuevaContraseña.Location = new System.Drawing.Point(35, 101);
            this.txt_NuevaContraseña.Name = "txt_NuevaContraseña";
            this.txt_NuevaContraseña.Size = new System.Drawing.Size(172, 20);
            this.txt_NuevaContraseña.TabIndex = 4;
            // 
            // txt_ConfirmarContraseña
            // 
            this.txt_ConfirmarContraseña.Location = new System.Drawing.Point(35, 156);
            this.txt_ConfirmarContraseña.Name = "txt_ConfirmarContraseña";
            this.txt_ConfirmarContraseña.Size = new System.Drawing.Size(172, 20);
            this.txt_ConfirmarContraseña.TabIndex = 5;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(121, 201);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(86, 24);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "ACEPTAR";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // Modificar_Contrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 254);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_ConfirmarContraseña);
            this.Controls.Add(this.txt_NuevaContraseña);
            this.Controls.Add(this.txt_ContraseñaActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modificar_Contrasena";
            this.Text = "Modificar Contraseña";
            this.Load += new System.EventHandler(this.Modificar_Contrasena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ContraseñaActual;
        private System.Windows.Forms.TextBox txt_NuevaContraseña;
        private System.Windows.Forms.TextBox txt_ConfirmarContraseña;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}