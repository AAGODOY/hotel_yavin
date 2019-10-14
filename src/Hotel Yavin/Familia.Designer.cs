namespace Hotel_Yavin
{
    partial class Familia
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
            this.lbl_NomFam = new System.Windows.Forms.Label();
            this.txt_NomFam = new System.Windows.Forms.TextBox();
            this.btn_DesasociarPatAFam = new System.Windows.Forms.Button();
            this.btn_AsociarPatAFam = new System.Windows.Forms.Button();
            this.lst_FamiliasAsociadas = new System.Windows.Forms.ListBox();
            this.lst_FamiliasDisponibles = new System.Windows.Forms.ListBox();
            this.lbl_PatDisponibles = new System.Windows.Forms.Label();
            this.lbl_PatAsocFam = new System.Windows.Forms.Label();
            this.btn_GuardarFamilia = new System.Windows.Forms.Button();
            this.btn_CancelarFamilia = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_PatenteFamilia = new System.Windows.Forms.TabPage();
            this.tab_UsuarioFamilia = new System.Windows.Forms.TabPage();
            this.lst_UsuariosDisponibles = new System.Windows.Forms.ListBox();
            this.lbl_UsuAsocFam = new System.Windows.Forms.Label();
            this.lbl_UsuarioDisponibles = new System.Windows.Forms.Label();
            this.btn_DesasociarUsuAFam = new System.Windows.Forms.Button();
            this.lst_UsuariosAsociados = new System.Windows.Forms.ListBox();
            this.btn_AsociarUsuAFam = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_PatenteFamilia.SuspendLayout();
            this.tab_UsuarioFamilia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NomFam
            // 
            this.lbl_NomFam.AutoSize = true;
            this.lbl_NomFam.Location = new System.Drawing.Point(12, 16);
            this.lbl_NomFam.Name = "lbl_NomFam";
            this.lbl_NomFam.Size = new System.Drawing.Size(105, 13);
            this.lbl_NomFam.TabIndex = 0;
            this.lbl_NomFam.Text = "Nombre de la Familia";
            // 
            // txt_NomFam
            // 
            this.txt_NomFam.Location = new System.Drawing.Point(124, 13);
            this.txt_NomFam.Name = "txt_NomFam";
            this.txt_NomFam.Size = new System.Drawing.Size(218, 20);
            this.txt_NomFam.TabIndex = 1;
            // 
            // btn_DesasociarPatAFam
            // 
            this.btn_DesasociarPatAFam.Location = new System.Drawing.Point(237, 199);
            this.btn_DesasociarPatAFam.Name = "btn_DesasociarPatAFam";
            this.btn_DesasociarPatAFam.Size = new System.Drawing.Size(55, 32);
            this.btn_DesasociarPatAFam.TabIndex = 11;
            this.btn_DesasociarPatAFam.Text = "<";
            this.btn_DesasociarPatAFam.UseVisualStyleBackColor = true;
            // 
            // btn_AsociarPatAFam
            // 
            this.btn_AsociarPatAFam.Location = new System.Drawing.Point(237, 64);
            this.btn_AsociarPatAFam.Name = "btn_AsociarPatAFam";
            this.btn_AsociarPatAFam.Size = new System.Drawing.Size(55, 32);
            this.btn_AsociarPatAFam.TabIndex = 10;
            this.btn_AsociarPatAFam.Text = ">";
            this.btn_AsociarPatAFam.UseVisualStyleBackColor = true;
            // 
            // lst_FamiliasAsociadas
            // 
            this.lst_FamiliasAsociadas.FormattingEnabled = true;
            this.lst_FamiliasAsociadas.Location = new System.Drawing.Point(298, 41);
            this.lst_FamiliasAsociadas.Name = "lst_FamiliasAsociadas";
            this.lst_FamiliasAsociadas.Size = new System.Drawing.Size(219, 225);
            this.lst_FamiliasAsociadas.TabIndex = 9;
            // 
            // lst_FamiliasDisponibles
            // 
            this.lst_FamiliasDisponibles.FormattingEnabled = true;
            this.lst_FamiliasDisponibles.Location = new System.Drawing.Point(12, 41);
            this.lst_FamiliasDisponibles.Name = "lst_FamiliasDisponibles";
            this.lst_FamiliasDisponibles.Size = new System.Drawing.Size(219, 225);
            this.lst_FamiliasDisponibles.TabIndex = 8;
            // 
            // lbl_PatDisponibles
            // 
            this.lbl_PatDisponibles.AutoSize = true;
            this.lbl_PatDisponibles.Location = new System.Drawing.Point(9, 11);
            this.lbl_PatDisponibles.Name = "lbl_PatDisponibles";
            this.lbl_PatDisponibles.Size = new System.Drawing.Size(106, 13);
            this.lbl_PatDisponibles.TabIndex = 7;
            this.lbl_PatDisponibles.Text = "Patentes Disponibles";
            // 
            // lbl_PatAsocFam
            // 
            this.lbl_PatAsocFam.AutoSize = true;
            this.lbl_PatAsocFam.Location = new System.Drawing.Point(295, 11);
            this.lbl_PatAsocFam.Name = "lbl_PatAsocFam";
            this.lbl_PatAsocFam.Size = new System.Drawing.Size(155, 13);
            this.lbl_PatAsocFam.TabIndex = 6;
            this.lbl_PatAsocFam.Text = "Patentes asociadas a la Familia";
            // 
            // btn_GuardarFamilia
            // 
            this.btn_GuardarFamilia.Location = new System.Drawing.Point(464, 365);
            this.btn_GuardarFamilia.Name = "btn_GuardarFamilia";
            this.btn_GuardarFamilia.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarFamilia.TabIndex = 13;
            this.btn_GuardarFamilia.Text = "Aceptar";
            this.btn_GuardarFamilia.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarFamilia
            // 
            this.btn_CancelarFamilia.Location = new System.Drawing.Point(370, 365);
            this.btn_CancelarFamilia.Name = "btn_CancelarFamilia";
            this.btn_CancelarFamilia.Size = new System.Drawing.Size(89, 29);
            this.btn_CancelarFamilia.TabIndex = 12;
            this.btn_CancelarFamilia.Text = "Cancelar";
            this.btn_CancelarFamilia.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_PatenteFamilia);
            this.tabControl1.Controls.Add(this.tab_UsuarioFamilia);
            this.tabControl1.Location = new System.Drawing.Point(13, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 311);
            this.tabControl1.TabIndex = 14;
            // 
            // tab_PatenteFamilia
            // 
            this.tab_PatenteFamilia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab_PatenteFamilia.Controls.Add(this.button1);
            this.tab_PatenteFamilia.Controls.Add(this.lst_FamiliasDisponibles);
            this.tab_PatenteFamilia.Controls.Add(this.lbl_PatAsocFam);
            this.tab_PatenteFamilia.Controls.Add(this.lbl_PatDisponibles);
            this.tab_PatenteFamilia.Controls.Add(this.btn_DesasociarPatAFam);
            this.tab_PatenteFamilia.Controls.Add(this.lst_FamiliasAsociadas);
            this.tab_PatenteFamilia.Controls.Add(this.btn_AsociarPatAFam);
            this.tab_PatenteFamilia.Location = new System.Drawing.Point(4, 22);
            this.tab_PatenteFamilia.Name = "tab_PatenteFamilia";
            this.tab_PatenteFamilia.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PatenteFamilia.Size = new System.Drawing.Size(532, 285);
            this.tab_PatenteFamilia.TabIndex = 0;
            this.tab_PatenteFamilia.Text = "Patentes - Familia";
            this.tab_PatenteFamilia.Click += new System.EventHandler(this.tab_PatenteFamilia_Click);
            // 
            // tab_UsuarioFamilia
            // 
            this.tab_UsuarioFamilia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab_UsuarioFamilia.Controls.Add(this.lst_UsuariosDisponibles);
            this.tab_UsuarioFamilia.Controls.Add(this.lbl_UsuAsocFam);
            this.tab_UsuarioFamilia.Controls.Add(this.lbl_UsuarioDisponibles);
            this.tab_UsuarioFamilia.Controls.Add(this.btn_DesasociarUsuAFam);
            this.tab_UsuarioFamilia.Controls.Add(this.lst_UsuariosAsociados);
            this.tab_UsuarioFamilia.Controls.Add(this.btn_AsociarUsuAFam);
            this.tab_UsuarioFamilia.Location = new System.Drawing.Point(4, 22);
            this.tab_UsuarioFamilia.Name = "tab_UsuarioFamilia";
            this.tab_UsuarioFamilia.Padding = new System.Windows.Forms.Padding(3);
            this.tab_UsuarioFamilia.Size = new System.Drawing.Size(532, 285);
            this.tab_UsuarioFamilia.TabIndex = 1;
            this.tab_UsuarioFamilia.Text = "Usuario - Familia";
            // 
            // lst_UsuariosDisponibles
            // 
            this.lst_UsuariosDisponibles.FormattingEnabled = true;
            this.lst_UsuariosDisponibles.Location = new System.Drawing.Point(11, 40);
            this.lst_UsuariosDisponibles.Name = "lst_UsuariosDisponibles";
            this.lst_UsuariosDisponibles.Size = new System.Drawing.Size(219, 225);
            this.lst_UsuariosDisponibles.TabIndex = 14;
            // 
            // lbl_UsuAsocFam
            // 
            this.lbl_UsuAsocFam.AutoSize = true;
            this.lbl_UsuAsocFam.Location = new System.Drawing.Point(294, 10);
            this.lbl_UsuAsocFam.Name = "lbl_UsuAsocFam";
            this.lbl_UsuAsocFam.Size = new System.Drawing.Size(154, 13);
            this.lbl_UsuAsocFam.TabIndex = 12;
            this.lbl_UsuAsocFam.Text = "Usuarios asociados a la Familia";
            // 
            // lbl_UsuarioDisponibles
            // 
            this.lbl_UsuarioDisponibles.AutoSize = true;
            this.lbl_UsuarioDisponibles.Location = new System.Drawing.Point(8, 10);
            this.lbl_UsuarioDisponibles.Name = "lbl_UsuarioDisponibles";
            this.lbl_UsuarioDisponibles.Size = new System.Drawing.Size(105, 13);
            this.lbl_UsuarioDisponibles.TabIndex = 13;
            this.lbl_UsuarioDisponibles.Text = "Usuarios Disponibles";
            // 
            // btn_DesasociarUsuAFam
            // 
            this.btn_DesasociarUsuAFam.Location = new System.Drawing.Point(236, 198);
            this.btn_DesasociarUsuAFam.Name = "btn_DesasociarUsuAFam";
            this.btn_DesasociarUsuAFam.Size = new System.Drawing.Size(55, 32);
            this.btn_DesasociarUsuAFam.TabIndex = 17;
            this.btn_DesasociarUsuAFam.Text = "<";
            this.btn_DesasociarUsuAFam.UseVisualStyleBackColor = true;
            // 
            // lst_UsuariosAsociados
            // 
            this.lst_UsuariosAsociados.FormattingEnabled = true;
            this.lst_UsuariosAsociados.Location = new System.Drawing.Point(297, 40);
            this.lst_UsuariosAsociados.Name = "lst_UsuariosAsociados";
            this.lst_UsuariosAsociados.Size = new System.Drawing.Size(219, 225);
            this.lst_UsuariosAsociados.TabIndex = 15;
            // 
            // btn_AsociarUsuAFam
            // 
            this.btn_AsociarUsuAFam.Location = new System.Drawing.Point(236, 63);
            this.btn_AsociarUsuAFam.Name = "btn_AsociarUsuAFam";
            this.btn_AsociarUsuAFam.Size = new System.Drawing.Size(55, 32);
            this.btn_AsociarUsuAFam.TabIndex = 16;
            this.btn_AsociarUsuAFam.Text = ">";
            this.btn_AsociarUsuAFam.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Negar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Familia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 409);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_GuardarFamilia);
            this.Controls.Add(this.txt_NomFam);
            this.Controls.Add(this.btn_CancelarFamilia);
            this.Controls.Add(this.lbl_NomFam);
            this.Name = "Familia";
            this.Text = "Familias";
            this.tabControl1.ResumeLayout(false);
            this.tab_PatenteFamilia.ResumeLayout(false);
            this.tab_PatenteFamilia.PerformLayout();
            this.tab_UsuarioFamilia.ResumeLayout(false);
            this.tab_UsuarioFamilia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NomFam;
        private System.Windows.Forms.TextBox txt_NomFam;
        private System.Windows.Forms.Button btn_DesasociarPatAFam;
        private System.Windows.Forms.Button btn_AsociarPatAFam;
        private System.Windows.Forms.ListBox lst_FamiliasAsociadas;
        private System.Windows.Forms.ListBox lst_FamiliasDisponibles;
        private System.Windows.Forms.Label lbl_PatDisponibles;
        private System.Windows.Forms.Label lbl_PatAsocFam;
        private System.Windows.Forms.Button btn_GuardarFamilia;
        private System.Windows.Forms.Button btn_CancelarFamilia;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_PatenteFamilia;
        private System.Windows.Forms.TabPage tab_UsuarioFamilia;
        private System.Windows.Forms.ListBox lst_UsuariosDisponibles;
        private System.Windows.Forms.Label lbl_UsuAsocFam;
        private System.Windows.Forms.Label lbl_UsuarioDisponibles;
        private System.Windows.Forms.Button btn_DesasociarUsuAFam;
        private System.Windows.Forms.ListBox lst_UsuariosAsociados;
        private System.Windows.Forms.Button btn_AsociarUsuAFam;
        private System.Windows.Forms.Button button1;
    }
}