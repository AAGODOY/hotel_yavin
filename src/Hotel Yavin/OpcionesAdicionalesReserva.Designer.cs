namespace Hotel_Yavin
{
    partial class OpcionesAdicionalesReserva
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_habilitar = new System.Windows.Forms.Button();
            this.btn_EnCurso = new System.Windows.Forms.Button();
            this.btn_finalizada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(130, 52);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Se realizará la acción deseada para la reserva seleccionada";
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(66, 99);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(164, 23);
            this.btn_Baja.TabIndex = 3;
            this.btn_Baja.Text = "Cancelar Reserva";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // btn_habilitar
            // 
            this.btn_habilitar.Location = new System.Drawing.Point(66, 137);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(164, 23);
            this.btn_habilitar.TabIndex = 4;
            this.btn_habilitar.Text = "Habilitar Reserva";
            this.btn_habilitar.UseVisualStyleBackColor = true;
            // 
            // btn_EnCurso
            // 
            this.btn_EnCurso.Location = new System.Drawing.Point(66, 175);
            this.btn_EnCurso.Name = "btn_EnCurso";
            this.btn_EnCurso.Size = new System.Drawing.Size(164, 23);
            this.btn_EnCurso.TabIndex = 5;
            this.btn_EnCurso.Text = "Reserva En Curso";
            this.btn_EnCurso.UseVisualStyleBackColor = true;
            // 
            // btn_finalizada
            // 
            this.btn_finalizada.Location = new System.Drawing.Point(66, 214);
            this.btn_finalizada.Name = "btn_finalizada";
            this.btn_finalizada.Size = new System.Drawing.Size(164, 23);
            this.btn_finalizada.TabIndex = 6;
            this.btn_finalizada.Text = "Reserva Finalizada";
            this.btn_finalizada.UseVisualStyleBackColor = true;
            // 
            // OpcionesAdicionalesReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.btn_finalizada);
            this.Controls.Add(this.btn_EnCurso);
            this.Controls.Add(this.btn_habilitar);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Name = "OpcionesAdicionalesReserva";
            this.Text = "OpcionesAdicionalesReserva";
            this.Load += new System.EventHandler(this.OpcionesAdicionalesReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_habilitar;
        private System.Windows.Forms.Button btn_EnCurso;
        private System.Windows.Forms.Button btn_finalizada;
    }
}