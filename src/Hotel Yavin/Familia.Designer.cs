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
            this.btn_GuardarFamilia = new System.Windows.Forms.Button();
            this.btn_CancelarFamilia = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_PatenteFamilia = new System.Windows.Forms.TabPage();
            this.dgv_patentesAsociadasAfamilia = new System.Windows.Forms.DataGridView();
            this.dgv_patentesDisponibles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_divider = new System.Windows.Forms.Label();
            this.btn_DesasociarPatente = new System.Windows.Forms.Button();
            this.btn_AsociarPatente = new System.Windows.Forms.Button();
            this.lbl_PatentesAsociadas = new System.Windows.Forms.Label();
            this.lbl_PatentesDisponibles = new System.Windows.Forms.Label();
            this.tab_UsuarioFamilia = new System.Windows.Forms.TabPage();
            this.dgv_UsuariosAsociadosAfamilia = new System.Windows.Forms.DataGridView();
            this.dgv_UsuariosDisponibles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_UsuariosDisponibles = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_PatenteFamilia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patentesAsociadasAfamilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patentesDisponibles)).BeginInit();
            this.tab_UsuarioFamilia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsuariosAsociadosAfamilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsuariosDisponibles)).BeginInit();
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
            // btn_GuardarFamilia
            // 
            this.btn_GuardarFamilia.Location = new System.Drawing.Point(478, 390);
            this.btn_GuardarFamilia.Name = "btn_GuardarFamilia";
            this.btn_GuardarFamilia.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarFamilia.TabIndex = 13;
            this.btn_GuardarFamilia.Text = "Aceptar";
            this.btn_GuardarFamilia.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarFamilia
            // 
            this.btn_CancelarFamilia.Location = new System.Drawing.Point(384, 390);
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
            this.tabControl1.Size = new System.Drawing.Size(557, 340);
            this.tabControl1.TabIndex = 14;
            // 
            // tab_PatenteFamilia
            // 
            this.tab_PatenteFamilia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab_PatenteFamilia.Controls.Add(this.dgv_patentesAsociadasAfamilia);
            this.tab_PatenteFamilia.Controls.Add(this.dgv_patentesDisponibles);
            this.tab_PatenteFamilia.Controls.Add(this.label1);
            this.tab_PatenteFamilia.Controls.Add(this.lbl_divider);
            this.tab_PatenteFamilia.Controls.Add(this.btn_DesasociarPatente);
            this.tab_PatenteFamilia.Controls.Add(this.btn_AsociarPatente);
            this.tab_PatenteFamilia.Controls.Add(this.lbl_PatentesAsociadas);
            this.tab_PatenteFamilia.Controls.Add(this.lbl_PatentesDisponibles);
            this.tab_PatenteFamilia.Location = new System.Drawing.Point(4, 22);
            this.tab_PatenteFamilia.Name = "tab_PatenteFamilia";
            this.tab_PatenteFamilia.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PatenteFamilia.Size = new System.Drawing.Size(549, 314);
            this.tab_PatenteFamilia.TabIndex = 0;
            this.tab_PatenteFamilia.Text = "Patentes - Familia";
            this.tab_PatenteFamilia.Click += new System.EventHandler(this.tab_PatenteFamilia_Click);
            // 
            // dgv_patentesAsociadasAfamilia
            // 
            this.dgv_patentesAsociadasAfamilia.AllowUserToAddRows = false;
            this.dgv_patentesAsociadasAfamilia.AllowUserToDeleteRows = false;
            this.dgv_patentesAsociadasAfamilia.AllowUserToResizeColumns = false;
            this.dgv_patentesAsociadasAfamilia.AllowUserToResizeRows = false;
            this.dgv_patentesAsociadasAfamilia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_patentesAsociadasAfamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patentesAsociadasAfamilia.Location = new System.Drawing.Point(334, 65);
            this.dgv_patentesAsociadasAfamilia.Name = "dgv_patentesAsociadasAfamilia";
            this.dgv_patentesAsociadasAfamilia.RowHeadersVisible = false;
            this.dgv_patentesAsociadasAfamilia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_patentesAsociadasAfamilia.Size = new System.Drawing.Size(194, 210);
            this.dgv_patentesAsociadasAfamilia.TabIndex = 27;
            // 
            // dgv_patentesDisponibles
            // 
            this.dgv_patentesDisponibles.AllowUserToAddRows = false;
            this.dgv_patentesDisponibles.AllowUserToDeleteRows = false;
            this.dgv_patentesDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_patentesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patentesDisponibles.Location = new System.Drawing.Point(26, 65);
            this.dgv_patentesDisponibles.Name = "dgv_patentesDisponibles";
            this.dgv_patentesDisponibles.RowHeadersVisible = false;
            this.dgv_patentesDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_patentesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_patentesDisponibles.Size = new System.Drawing.Size(194, 210);
            this.dgv_patentesDisponibles.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 10);
            this.label1.TabIndex = 25;
            // 
            // lbl_divider
            // 
            this.lbl_divider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_divider.Location = new System.Drawing.Point(0, 3);
            this.lbl_divider.Name = "lbl_divider";
            this.lbl_divider.Size = new System.Drawing.Size(542, 10);
            this.lbl_divider.TabIndex = 24;
            // 
            // btn_DesasociarPatente
            // 
            this.btn_DesasociarPatente.Location = new System.Drawing.Point(252, 239);
            this.btn_DesasociarPatente.Name = "btn_DesasociarPatente";
            this.btn_DesasociarPatente.Size = new System.Drawing.Size(46, 37);
            this.btn_DesasociarPatente.TabIndex = 22;
            this.btn_DesasociarPatente.Text = "<";
            this.btn_DesasociarPatente.UseVisualStyleBackColor = true;
            // 
            // btn_AsociarPatente
            // 
            this.btn_AsociarPatente.Location = new System.Drawing.Point(252, 66);
            this.btn_AsociarPatente.Name = "btn_AsociarPatente";
            this.btn_AsociarPatente.Size = new System.Drawing.Size(46, 37);
            this.btn_AsociarPatente.TabIndex = 21;
            this.btn_AsociarPatente.Text = ">";
            this.btn_AsociarPatente.UseVisualStyleBackColor = true;
            // 
            // lbl_PatentesAsociadas
            // 
            this.lbl_PatentesAsociadas.AutoSize = true;
            this.lbl_PatentesAsociadas.Location = new System.Drawing.Point(331, 36);
            this.lbl_PatentesAsociadas.Name = "lbl_PatentesAsociadas";
            this.lbl_PatentesAsociadas.Size = new System.Drawing.Size(156, 13);
            this.lbl_PatentesAsociadas.TabIndex = 20;
            this.lbl_PatentesAsociadas.Text = "Patentes Asociadas a la Familia";
            // 
            // lbl_PatentesDisponibles
            // 
            this.lbl_PatentesDisponibles.AutoSize = true;
            this.lbl_PatentesDisponibles.Location = new System.Drawing.Point(23, 36);
            this.lbl_PatentesDisponibles.Name = "lbl_PatentesDisponibles";
            this.lbl_PatentesDisponibles.Size = new System.Drawing.Size(106, 13);
            this.lbl_PatentesDisponibles.TabIndex = 19;
            this.lbl_PatentesDisponibles.Text = "Patentes Disponibles";
            // 
            // tab_UsuarioFamilia
            // 
            this.tab_UsuarioFamilia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab_UsuarioFamilia.Controls.Add(this.dgv_UsuariosAsociadosAfamilia);
            this.tab_UsuarioFamilia.Controls.Add(this.dgv_UsuariosDisponibles);
            this.tab_UsuarioFamilia.Controls.Add(this.label2);
            this.tab_UsuarioFamilia.Controls.Add(this.label3);
            this.tab_UsuarioFamilia.Controls.Add(this.button2);
            this.tab_UsuarioFamilia.Controls.Add(this.button3);
            this.tab_UsuarioFamilia.Controls.Add(this.label4);
            this.tab_UsuarioFamilia.Controls.Add(this.lbl_UsuariosDisponibles);
            this.tab_UsuarioFamilia.Location = new System.Drawing.Point(4, 22);
            this.tab_UsuarioFamilia.Name = "tab_UsuarioFamilia";
            this.tab_UsuarioFamilia.Padding = new System.Windows.Forms.Padding(3);
            this.tab_UsuarioFamilia.Size = new System.Drawing.Size(549, 314);
            this.tab_UsuarioFamilia.TabIndex = 1;
            this.tab_UsuarioFamilia.Text = "Usuario - Familia";
            // 
            // dgv_UsuariosAsociadosAfamilia
            // 
            this.dgv_UsuariosAsociadosAfamilia.AllowUserToAddRows = false;
            this.dgv_UsuariosAsociadosAfamilia.AllowUserToDeleteRows = false;
            this.dgv_UsuariosAsociadosAfamilia.AllowUserToResizeColumns = false;
            this.dgv_UsuariosAsociadosAfamilia.AllowUserToResizeRows = false;
            this.dgv_UsuariosAsociadosAfamilia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UsuariosAsociadosAfamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UsuariosAsociadosAfamilia.Location = new System.Drawing.Point(335, 65);
            this.dgv_UsuariosAsociadosAfamilia.Name = "dgv_UsuariosAsociadosAfamilia";
            this.dgv_UsuariosAsociadosAfamilia.RowHeadersVisible = false;
            this.dgv_UsuariosAsociadosAfamilia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UsuariosAsociadosAfamilia.Size = new System.Drawing.Size(194, 210);
            this.dgv_UsuariosAsociadosAfamilia.TabIndex = 36;
            // 
            // dgv_UsuariosDisponibles
            // 
            this.dgv_UsuariosDisponibles.AllowUserToAddRows = false;
            this.dgv_UsuariosDisponibles.AllowUserToDeleteRows = false;
            this.dgv_UsuariosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UsuariosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UsuariosDisponibles.Location = new System.Drawing.Point(27, 65);
            this.dgv_UsuariosDisponibles.Name = "dgv_UsuariosDisponibles";
            this.dgv_UsuariosDisponibles.RowHeadersVisible = false;
            this.dgv_UsuariosDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_UsuariosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UsuariosDisponibles.Size = new System.Drawing.Size(194, 210);
            this.dgv_UsuariosDisponibles.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(1, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 10);
            this.label2.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(1, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(542, 10);
            this.label3.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 37);
            this.button2.TabIndex = 31;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(253, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 37);
            this.button3.TabIndex = 30;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Usuarios Asociados a la Familia";
            // 
            // lbl_UsuariosDisponibles
            // 
            this.lbl_UsuariosDisponibles.AutoSize = true;
            this.lbl_UsuariosDisponibles.Location = new System.Drawing.Point(24, 36);
            this.lbl_UsuariosDisponibles.Name = "lbl_UsuariosDisponibles";
            this.lbl_UsuariosDisponibles.Size = new System.Drawing.Size(105, 13);
            this.lbl_UsuariosDisponibles.TabIndex = 28;
            this.lbl_UsuariosDisponibles.Text = "Usuarios Disponibles";
            // 
            // Familia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 429);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_GuardarFamilia);
            this.Controls.Add(this.txt_NomFam);
            this.Controls.Add(this.btn_CancelarFamilia);
            this.Controls.Add(this.lbl_NomFam);
            this.Name = "Familia";
            this.Text = "Familias";
            this.Load += new System.EventHandler(this.Familia_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_PatenteFamilia.ResumeLayout(false);
            this.tab_PatenteFamilia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patentesAsociadasAfamilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patentesDisponibles)).EndInit();
            this.tab_UsuarioFamilia.ResumeLayout(false);
            this.tab_UsuarioFamilia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsuariosAsociadosAfamilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsuariosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NomFam;
        private System.Windows.Forms.TextBox txt_NomFam;
        private System.Windows.Forms.Button btn_GuardarFamilia;
        private System.Windows.Forms.Button btn_CancelarFamilia;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_PatenteFamilia;
        private System.Windows.Forms.TabPage tab_UsuarioFamilia;
        private System.Windows.Forms.DataGridView dgv_patentesAsociadasAfamilia;
        private System.Windows.Forms.DataGridView dgv_patentesDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_divider;
        private System.Windows.Forms.Button btn_DesasociarPatente;
        private System.Windows.Forms.Button btn_AsociarPatente;
        private System.Windows.Forms.Label lbl_PatentesAsociadas;
        private System.Windows.Forms.Label lbl_PatentesDisponibles;
        private System.Windows.Forms.DataGridView dgv_UsuariosAsociadosAfamilia;
        private System.Windows.Forms.DataGridView dgv_UsuariosDisponibles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_UsuariosDisponibles;
    }
}