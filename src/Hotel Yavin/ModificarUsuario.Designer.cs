namespace Hotel_Yavin
{
    partial class ModificarUsuario
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
            this.btn_GuardarUsuario = new System.Windows.Forms.Button();
            this.btn_CancelarUsuario = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_BlanquearPass = new System.Windows.Forms.Button();
            this.btn_Desbloquear = new System.Windows.Forms.Button();
            this.btn_Bloquear = new System.Windows.Forms.Button();
            this.txt_Domicilio = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_NumDoc = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_NomUsu = new System.Windows.Forms.TextBox();
            this.lbl_Domicilio = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_NumDoc = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_NomUsu = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_DesasociarFamilias = new System.Windows.Forms.Button();
            this.btn_AsociarFamilias = new System.Windows.Forms.Button();
            this.lst_FamiliasAsociadas = new System.Windows.Forms.ListBox();
            this.lst_FamiliasDisponibles = new System.Windows.Forms.ListBox();
            this.lbl_FamiliasAsociadas = new System.Windows.Forms.Label();
            this.lbl_FamiliasDisponibles = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_DesasociarPatente = new System.Windows.Forms.Button();
            this.btn_AsociarPatente = new System.Windows.Forms.Button();
            this.lst_PatentesAsociadas = new System.Windows.Forms.ListBox();
            this.lst_PatentesDisponibles = new System.Windows.Forms.ListBox();
            this.lbl_PatentesAsociadas = new System.Windows.Forms.Label();
            this.lbl_PatentesDisponibles = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GuardarUsuario
            // 
            this.btn_GuardarUsuario.Location = new System.Drawing.Point(501, 359);
            this.btn_GuardarUsuario.Name = "btn_GuardarUsuario";
            this.btn_GuardarUsuario.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarUsuario.TabIndex = 18;
            this.btn_GuardarUsuario.Text = "Aceptar";
            this.btn_GuardarUsuario.UseVisualStyleBackColor = true;
            this.btn_GuardarUsuario.Click += new System.EventHandler(this.btn_GuardarUsuario_Click);
            // 
            // btn_CancelarUsuario
            // 
            this.btn_CancelarUsuario.Location = new System.Drawing.Point(407, 359);
            this.btn_CancelarUsuario.Name = "btn_CancelarUsuario";
            this.btn_CancelarUsuario.Size = new System.Drawing.Size(89, 29);
            this.btn_CancelarUsuario.TabIndex = 17;
            this.btn_CancelarUsuario.Text = "Cancelar";
            this.btn_CancelarUsuario.UseVisualStyleBackColor = true;
            this.btn_CancelarUsuario.Click += new System.EventHandler(this.btn_CancelarUsuario_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 341);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txt_Domicilio);
            this.tabPage1.Controls.Add(this.txt_Telefono);
            this.tabPage1.Controls.Add(this.txt_NumDoc);
            this.tabPage1.Controls.Add(this.txt_Apellido);
            this.tabPage1.Controls.Add(this.txt_Email);
            this.tabPage1.Controls.Add(this.txt_Nombre);
            this.tabPage1.Controls.Add(this.txt_NomUsu);
            this.tabPage1.Controls.Add(this.lbl_Domicilio);
            this.tabPage1.Controls.Add(this.lbl_Telefono);
            this.tabPage1.Controls.Add(this.lbl_NumDoc);
            this.tabPage1.Controls.Add(this.lbl_Apellido);
            this.tabPage1.Controls.Add(this.lbl_Email);
            this.tabPage1.Controls.Add(this.lbl_Nombre);
            this.tabPage1.Controls.Add(this.lbl_NomUsu);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos del Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_BlanquearPass);
            this.groupBox1.Controls.Add(this.btn_Desbloquear);
            this.groupBox1.Controls.Add(this.btn_Bloquear);
            this.groupBox1.Location = new System.Drawing.Point(350, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 124);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones Adicionales";
            // 
            // btn_BlanquearPass
            // 
            this.btn_BlanquearPass.Location = new System.Drawing.Point(31, 23);
            this.btn_BlanquearPass.Name = "btn_BlanquearPass";
            this.btn_BlanquearPass.Size = new System.Drawing.Size(133, 23);
            this.btn_BlanquearPass.TabIndex = 18;
            this.btn_BlanquearPass.Text = "Blanqueo Contraseña";
            this.btn_BlanquearPass.UseVisualStyleBackColor = true;
            // 
            // btn_Desbloquear
            // 
            this.btn_Desbloquear.Location = new System.Drawing.Point(31, 82);
            this.btn_Desbloquear.Name = "btn_Desbloquear";
            this.btn_Desbloquear.Size = new System.Drawing.Size(133, 23);
            this.btn_Desbloquear.TabIndex = 20;
            this.btn_Desbloquear.Text = "Desbloquear";
            this.btn_Desbloquear.UseVisualStyleBackColor = true;
            // 
            // btn_Bloquear
            // 
            this.btn_Bloquear.Location = new System.Drawing.Point(31, 52);
            this.btn_Bloquear.Name = "btn_Bloquear";
            this.btn_Bloquear.Size = new System.Drawing.Size(133, 23);
            this.btn_Bloquear.TabIndex = 19;
            this.btn_Bloquear.Text = "Bloquear";
            this.btn_Bloquear.UseVisualStyleBackColor = true;
            // 
            // txt_Domicilio
            // 
            this.txt_Domicilio.Location = new System.Drawing.Point(134, 184);
            this.txt_Domicilio.Name = "txt_Domicilio";
            this.txt_Domicilio.Size = new System.Drawing.Size(179, 20);
            this.txt_Domicilio.TabIndex = 17;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(134, 158);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(179, 20);
            this.txt_Telefono.TabIndex = 15;
            // 
            // txt_NumDoc
            // 
            this.txt_NumDoc.Location = new System.Drawing.Point(134, 106);
            this.txt_NumDoc.Name = "txt_NumDoc";
            this.txt_NumDoc.Size = new System.Drawing.Size(179, 20);
            this.txt_NumDoc.TabIndex = 13;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(134, 80);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(179, 20);
            this.txt_Apellido.TabIndex = 11;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(134, 132);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(179, 20);
            this.txt_Email.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(134, 50);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(179, 20);
            this.txt_Nombre.TabIndex = 3;
            // 
            // txt_NomUsu
            // 
            this.txt_NomUsu.Location = new System.Drawing.Point(134, 21);
            this.txt_NomUsu.Name = "txt_NomUsu";
            this.txt_NomUsu.Size = new System.Drawing.Size(179, 20);
            this.txt_NomUsu.TabIndex = 1;
            // 
            // lbl_Domicilio
            // 
            this.lbl_Domicilio.AutoSize = true;
            this.lbl_Domicilio.Location = new System.Drawing.Point(6, 187);
            this.lbl_Domicilio.Name = "lbl_Domicilio";
            this.lbl_Domicilio.Size = new System.Drawing.Size(49, 13);
            this.lbl_Domicilio.TabIndex = 16;
            this.lbl_Domicilio.Text = "Domicilio";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(6, 161);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefono.TabIndex = 14;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // lbl_NumDoc
            // 
            this.lbl_NumDoc.AutoSize = true;
            this.lbl_NumDoc.Location = new System.Drawing.Point(6, 109);
            this.lbl_NumDoc.Name = "lbl_NumDoc";
            this.lbl_NumDoc.Size = new System.Drawing.Size(117, 13);
            this.lbl_NumDoc.TabIndex = 12;
            this.lbl_NumDoc.Text = "Numero de Documento";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(6, 83);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido.TabIndex = 10;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(6, 135);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 53);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_NomUsu
            // 
            this.lbl_NomUsu.AutoSize = true;
            this.lbl_NomUsu.Location = new System.Drawing.Point(6, 24);
            this.lbl_NomUsu.Name = "lbl_NomUsu";
            this.lbl_NomUsu.Size = new System.Drawing.Size(98, 13);
            this.lbl_NomUsu.TabIndex = 0;
            this.lbl_NomUsu.Text = "Nombre del usuario";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage3.Controls.Add(this.btn_DesasociarFamilias);
            this.tabPage3.Controls.Add(this.btn_AsociarFamilias);
            this.tabPage3.Controls.Add(this.lst_FamiliasAsociadas);
            this.tabPage3.Controls.Add(this.lst_FamiliasDisponibles);
            this.tabPage3.Controls.Add(this.lbl_FamiliasAsociadas);
            this.tabPage3.Controls.Add(this.lbl_FamiliasDisponibles);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(574, 315);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Familia";
            // 
            // btn_DesasociarFamilias
            // 
            this.btn_DesasociarFamilias.Location = new System.Drawing.Point(265, 210);
            this.btn_DesasociarFamilias.Name = "btn_DesasociarFamilias";
            this.btn_DesasociarFamilias.Size = new System.Drawing.Size(46, 37);
            this.btn_DesasociarFamilias.TabIndex = 5;
            this.btn_DesasociarFamilias.Text = "<";
            this.btn_DesasociarFamilias.UseVisualStyleBackColor = true;
            // 
            // btn_AsociarFamilias
            // 
            this.btn_AsociarFamilias.Location = new System.Drawing.Point(265, 75);
            this.btn_AsociarFamilias.Name = "btn_AsociarFamilias";
            this.btn_AsociarFamilias.Size = new System.Drawing.Size(46, 37);
            this.btn_AsociarFamilias.TabIndex = 4;
            this.btn_AsociarFamilias.Text = ">";
            this.btn_AsociarFamilias.UseVisualStyleBackColor = true;
            // 
            // lst_FamiliasAsociadas
            // 
            this.lst_FamiliasAsociadas.FormattingEnabled = true;
            this.lst_FamiliasAsociadas.Location = new System.Drawing.Point(316, 52);
            this.lst_FamiliasAsociadas.Name = "lst_FamiliasAsociadas";
            this.lst_FamiliasAsociadas.Size = new System.Drawing.Size(231, 238);
            this.lst_FamiliasAsociadas.TabIndex = 3;
            // 
            // lst_FamiliasDisponibles
            // 
            this.lst_FamiliasDisponibles.FormattingEnabled = true;
            this.lst_FamiliasDisponibles.Location = new System.Drawing.Point(28, 52);
            this.lst_FamiliasDisponibles.Name = "lst_FamiliasDisponibles";
            this.lst_FamiliasDisponibles.Size = new System.Drawing.Size(231, 238);
            this.lst_FamiliasDisponibles.TabIndex = 2;
            // 
            // lbl_FamiliasAsociadas
            // 
            this.lbl_FamiliasAsociadas.AutoSize = true;
            this.lbl_FamiliasAsociadas.Location = new System.Drawing.Point(313, 25);
            this.lbl_FamiliasAsociadas.Name = "lbl_FamiliasAsociadas";
            this.lbl_FamiliasAsociadas.Size = new System.Drawing.Size(144, 13);
            this.lbl_FamiliasAsociadas.TabIndex = 1;
            this.lbl_FamiliasAsociadas.Text = "Familias Asociadas al usuario";
            // 
            // lbl_FamiliasDisponibles
            // 
            this.lbl_FamiliasDisponibles.AutoSize = true;
            this.lbl_FamiliasDisponibles.Location = new System.Drawing.Point(25, 25);
            this.lbl_FamiliasDisponibles.Name = "lbl_FamiliasDisponibles";
            this.lbl_FamiliasDisponibles.Size = new System.Drawing.Size(101, 13);
            this.lbl_FamiliasDisponibles.TabIndex = 0;
            this.lbl_FamiliasDisponibles.Text = "Familias Disponibles";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.btn_DesasociarPatente);
            this.tabPage4.Controls.Add(this.btn_AsociarPatente);
            this.tabPage4.Controls.Add(this.lst_PatentesAsociadas);
            this.tabPage4.Controls.Add(this.lst_PatentesDisponibles);
            this.tabPage4.Controls.Add(this.lbl_PatentesAsociadas);
            this.tabPage4.Controls.Add(this.lbl_PatentesDisponibles);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(574, 315);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Patente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Negar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_DesasociarPatente
            // 
            this.btn_DesasociarPatente.Location = new System.Drawing.Point(266, 210);
            this.btn_DesasociarPatente.Name = "btn_DesasociarPatente";
            this.btn_DesasociarPatente.Size = new System.Drawing.Size(46, 37);
            this.btn_DesasociarPatente.TabIndex = 11;
            this.btn_DesasociarPatente.Text = "<";
            this.btn_DesasociarPatente.UseVisualStyleBackColor = true;
            // 
            // btn_AsociarPatente
            // 
            this.btn_AsociarPatente.Location = new System.Drawing.Point(266, 75);
            this.btn_AsociarPatente.Name = "btn_AsociarPatente";
            this.btn_AsociarPatente.Size = new System.Drawing.Size(46, 37);
            this.btn_AsociarPatente.TabIndex = 10;
            this.btn_AsociarPatente.Text = ">";
            this.btn_AsociarPatente.UseVisualStyleBackColor = true;
            // 
            // lst_PatentesAsociadas
            // 
            this.lst_PatentesAsociadas.FormattingEnabled = true;
            this.lst_PatentesAsociadas.Location = new System.Drawing.Point(317, 52);
            this.lst_PatentesAsociadas.Name = "lst_PatentesAsociadas";
            this.lst_PatentesAsociadas.Size = new System.Drawing.Size(231, 238);
            this.lst_PatentesAsociadas.TabIndex = 9;
            // 
            // lst_PatentesDisponibles
            // 
            this.lst_PatentesDisponibles.FormattingEnabled = true;
            this.lst_PatentesDisponibles.Location = new System.Drawing.Point(29, 52);
            this.lst_PatentesDisponibles.Name = "lst_PatentesDisponibles";
            this.lst_PatentesDisponibles.Size = new System.Drawing.Size(231, 238);
            this.lst_PatentesDisponibles.TabIndex = 8;
            // 
            // lbl_PatentesAsociadas
            // 
            this.lbl_PatentesAsociadas.AutoSize = true;
            this.lbl_PatentesAsociadas.Location = new System.Drawing.Point(314, 25);
            this.lbl_PatentesAsociadas.Name = "lbl_PatentesAsociadas";
            this.lbl_PatentesAsociadas.Size = new System.Drawing.Size(149, 13);
            this.lbl_PatentesAsociadas.TabIndex = 7;
            this.lbl_PatentesAsociadas.Text = "Patentes Asociadas al usuario";
            // 
            // lbl_PatentesDisponibles
            // 
            this.lbl_PatentesDisponibles.AutoSize = true;
            this.lbl_PatentesDisponibles.Location = new System.Drawing.Point(26, 25);
            this.lbl_PatentesDisponibles.Name = "lbl_PatentesDisponibles";
            this.lbl_PatentesDisponibles.Size = new System.Drawing.Size(106, 13);
            this.lbl_PatentesDisponibles.TabIndex = 6;
            this.lbl_PatentesDisponibles.Text = "Patentes Disponibles";
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 408);
            this.Controls.Add(this.btn_GuardarUsuario);
            this.Controls.Add(this.btn_CancelarUsuario);
            this.Controls.Add(this.tabControl1);
            this.Name = "ModificarUsuario";
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.ModificarUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GuardarUsuario;
        private System.Windows.Forms.Button btn_CancelarUsuario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_Domicilio;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_NumDoc;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_NomUsu;
        private System.Windows.Forms.Label lbl_Domicilio;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_NumDoc;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_NomUsu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_DesasociarFamilias;
        private System.Windows.Forms.Button btn_AsociarFamilias;
        private System.Windows.Forms.ListBox lst_FamiliasAsociadas;
        private System.Windows.Forms.ListBox lst_FamiliasDisponibles;
        private System.Windows.Forms.Label lbl_FamiliasAsociadas;
        private System.Windows.Forms.Label lbl_FamiliasDisponibles;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_DesasociarPatente;
        private System.Windows.Forms.Button btn_AsociarPatente;
        private System.Windows.Forms.ListBox lst_PatentesAsociadas;
        private System.Windows.Forms.ListBox lst_PatentesDisponibles;
        private System.Windows.Forms.Label lbl_PatentesAsociadas;
        private System.Windows.Forms.Label lbl_PatentesDisponibles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_BlanquearPass;
        private System.Windows.Forms.Button btn_Desbloquear;
        private System.Windows.Forms.Button btn_Bloquear;
    }
}