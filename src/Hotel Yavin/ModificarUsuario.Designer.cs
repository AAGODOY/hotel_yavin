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
            this.dgv_familiasAsociadas = new System.Windows.Forms.DataGridView();
            this.dgv_familiasDisponibles = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_DesasociarFamilia = new System.Windows.Forms.Button();
            this.btn_AsociarFamilia = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_FamiliasDisponibles = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgv_patentesAsociadas = new System.Windows.Forms.DataGridView();
            this.dgv_patentesDisponibles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_NegarPatente = new System.Windows.Forms.Button();
            this.btn_DesasociarPatente = new System.Windows.Forms.Button();
            this.btn_AsociarPatente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_familiasAsociadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_familiasDisponibles)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patentesAsociadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patentesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GuardarUsuario
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_GuardarUsuario, "ModificarUsuario.htm#btn_GuardarUsuario");
            this.HelpProviderHG.SetHelpNavigator(this.btn_GuardarUsuario, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_GuardarUsuario.Location = new System.Drawing.Point(474, 359);
            this.btn_GuardarUsuario.Name = "btn_GuardarUsuario";
            this.HelpProviderHG.SetShowHelp(this.btn_GuardarUsuario, true);
            this.btn_GuardarUsuario.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarUsuario.TabIndex = 18;
            this.btn_GuardarUsuario.Text = "Aceptar";
            this.btn_GuardarUsuario.UseVisualStyleBackColor = true;
            this.btn_GuardarUsuario.Click += new System.EventHandler(this.btn_GuardarUsuario_Click);
            // 
            // btn_CancelarUsuario
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_CancelarUsuario, "ModificarUsuario.htm#btn_CancelarUsuario");
            this.HelpProviderHG.SetHelpNavigator(this.btn_CancelarUsuario, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_CancelarUsuario.Location = new System.Drawing.Point(380, 359);
            this.btn_CancelarUsuario.Name = "btn_CancelarUsuario";
            this.HelpProviderHG.SetShowHelp(this.btn_CancelarUsuario, true);
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
            this.HelpProviderHG.SetHelpKeyword(this.tabControl1, "ModificarUsuario.htm#tabControl1");
            this.HelpProviderHG.SetHelpNavigator(this.tabControl1, System.Windows.Forms.HelpNavigator.Topic);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.HelpProviderHG.SetShowHelp(this.tabControl1, true);
            this.tabControl1.Size = new System.Drawing.Size(554, 341);
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
            this.HelpProviderHG.SetHelpKeyword(this.tabPage1, "ModificarUsuario.htm#tabPage1_0");
            this.HelpProviderHG.SetHelpNavigator(this.tabPage1, System.Windows.Forms.HelpNavigator.Topic);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.HelpProviderHG.SetShowHelp(this.tabPage1, true);
            this.tabPage1.Size = new System.Drawing.Size(546, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos del Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_BlanquearPass);
            this.groupBox1.Location = new System.Drawing.Point(337, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 62);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones Adicionales";
            // 
            // btn_BlanquearPass
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_BlanquearPass, "ModificarUsuario.htm#btn_BlanquearPass");
            this.HelpProviderHG.SetHelpNavigator(this.btn_BlanquearPass, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_BlanquearPass.Location = new System.Drawing.Point(31, 23);
            this.btn_BlanquearPass.Name = "btn_BlanquearPass";
            this.HelpProviderHG.SetShowHelp(this.btn_BlanquearPass, true);
            this.btn_BlanquearPass.Size = new System.Drawing.Size(133, 23);
            this.btn_BlanquearPass.TabIndex = 18;
            this.btn_BlanquearPass.Text = "Blanqueo Contraseña";
            this.btn_BlanquearPass.UseVisualStyleBackColor = true;
            this.btn_BlanquearPass.Click += new System.EventHandler(this.btn_BlanquearPass_Click);
            // 
            // txt_Domicilio
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_Domicilio, "ModificarUsuario.htm#lbl_Domicilio");
            this.HelpProviderHG.SetHelpNavigator(this.txt_Domicilio, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_Domicilio.Location = new System.Drawing.Point(134, 184);
            this.txt_Domicilio.Name = "txt_Domicilio";
            this.HelpProviderHG.SetShowHelp(this.txt_Domicilio, true);
            this.txt_Domicilio.Size = new System.Drawing.Size(179, 20);
            this.txt_Domicilio.TabIndex = 17;
            // 
            // txt_Telefono
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_Telefono, "ModificarUsuario.htm#lbl_Telefono");
            this.HelpProviderHG.SetHelpNavigator(this.txt_Telefono, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_Telefono.Location = new System.Drawing.Point(134, 158);
            this.txt_Telefono.Name = "txt_Telefono";
            this.HelpProviderHG.SetShowHelp(this.txt_Telefono, true);
            this.txt_Telefono.Size = new System.Drawing.Size(179, 20);
            this.txt_Telefono.TabIndex = 15;
            // 
            // txt_NumDoc
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_NumDoc, "ModificarUsuario.htm#lbl_NumDoc");
            this.HelpProviderHG.SetHelpNavigator(this.txt_NumDoc, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_NumDoc.Location = new System.Drawing.Point(134, 106);
            this.txt_NumDoc.Name = "txt_NumDoc";
            this.HelpProviderHG.SetShowHelp(this.txt_NumDoc, true);
            this.txt_NumDoc.Size = new System.Drawing.Size(179, 20);
            this.txt_NumDoc.TabIndex = 13;
            this.txt_NumDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumDoc_KeyPress);
            // 
            // txt_Apellido
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_Apellido, "ModificarUsuario.htm#lbl_Apellido");
            this.HelpProviderHG.SetHelpNavigator(this.txt_Apellido, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_Apellido.Location = new System.Drawing.Point(134, 80);
            this.txt_Apellido.Name = "txt_Apellido";
            this.HelpProviderHG.SetShowHelp(this.txt_Apellido, true);
            this.txt_Apellido.Size = new System.Drawing.Size(179, 20);
            this.txt_Apellido.TabIndex = 11;
            // 
            // txt_Email
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_Email, "ModificarUsuario.htm#lbl_Email");
            this.HelpProviderHG.SetHelpNavigator(this.txt_Email, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_Email.Location = new System.Drawing.Point(134, 132);
            this.txt_Email.Name = "txt_Email";
            this.HelpProviderHG.SetShowHelp(this.txt_Email, true);
            this.txt_Email.Size = new System.Drawing.Size(179, 20);
            this.txt_Email.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.HelpProviderHG.SetHelpKeyword(this.txt_Nombre, "ModificarUsuario.htm#lbl_Nombre");
            this.HelpProviderHG.SetHelpNavigator(this.txt_Nombre, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_Nombre.Location = new System.Drawing.Point(134, 50);
            this.txt_Nombre.Name = "txt_Nombre";
            this.HelpProviderHG.SetShowHelp(this.txt_Nombre, true);
            this.txt_Nombre.Size = new System.Drawing.Size(179, 20);
            this.txt_Nombre.TabIndex = 3;
            // 
            // txt_NomUsu
            // 
            this.txt_NomUsu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_NomUsu.Enabled = false;
            this.HelpProviderHG.SetHelpKeyword(this.txt_NomUsu, "ModificarUsuario.htm#lbl_NomUsu");
            this.HelpProviderHG.SetHelpNavigator(this.txt_NomUsu, System.Windows.Forms.HelpNavigator.Topic);
            this.txt_NomUsu.Location = new System.Drawing.Point(134, 21);
            this.txt_NomUsu.Name = "txt_NomUsu";
            this.HelpProviderHG.SetShowHelp(this.txt_NomUsu, true);
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
            this.tabPage3.Controls.Add(this.dgv_familiasAsociadas);
            this.tabPage3.Controls.Add(this.dgv_familiasDisponibles);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.btn_DesasociarFamilia);
            this.tabPage3.Controls.Add(this.btn_AsociarFamilia);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.lbl_FamiliasDisponibles);
            this.HelpProviderHG.SetHelpKeyword(this.tabPage3, "ModificarUsuario.htm#tabPage3_1");
            this.HelpProviderHG.SetHelpNavigator(this.tabPage3, System.Windows.Forms.HelpNavigator.Topic);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.HelpProviderHG.SetShowHelp(this.tabPage3, true);
            this.tabPage3.Size = new System.Drawing.Size(546, 315);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Familia";
            // 
            // dgv_familiasAsociadas
            // 
            this.dgv_familiasAsociadas.AllowUserToAddRows = false;
            this.dgv_familiasAsociadas.AllowUserToDeleteRows = false;
            this.dgv_familiasAsociadas.AllowUserToResizeColumns = false;
            this.dgv_familiasAsociadas.AllowUserToResizeRows = false;
            this.dgv_familiasAsociadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_familiasAsociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HelpProviderHG.SetHelpKeyword(this.dgv_familiasAsociadas, "ModificarUsuario.htm#dgv_familiasAsociadas");
            this.HelpProviderHG.SetHelpNavigator(this.dgv_familiasAsociadas, System.Windows.Forms.HelpNavigator.Topic);
            this.dgv_familiasAsociadas.Location = new System.Drawing.Point(334, 65);
            this.dgv_familiasAsociadas.Name = "dgv_familiasAsociadas";
            this.dgv_familiasAsociadas.RowHeadersVisible = false;
            this.dgv_familiasAsociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HelpProviderHG.SetShowHelp(this.dgv_familiasAsociadas, true);
            this.dgv_familiasAsociadas.Size = new System.Drawing.Size(194, 210);
            this.dgv_familiasAsociadas.TabIndex = 27;
            // 
            // dgv_familiasDisponibles
            // 
            this.dgv_familiasDisponibles.AllowUserToAddRows = false;
            this.dgv_familiasDisponibles.AllowUserToDeleteRows = false;
            this.dgv_familiasDisponibles.AllowUserToResizeColumns = false;
            this.dgv_familiasDisponibles.AllowUserToResizeRows = false;
            this.dgv_familiasDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_familiasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HelpProviderHG.SetHelpKeyword(this.dgv_familiasDisponibles, "ModificarUsuario.htm#dgv_familiasDisponibles");
            this.HelpProviderHG.SetHelpNavigator(this.dgv_familiasDisponibles, System.Windows.Forms.HelpNavigator.Topic);
            this.dgv_familiasDisponibles.Location = new System.Drawing.Point(26, 65);
            this.dgv_familiasDisponibles.Name = "dgv_familiasDisponibles";
            this.dgv_familiasDisponibles.RowHeadersVisible = false;
            this.dgv_familiasDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_familiasDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HelpProviderHG.SetShowHelp(this.dgv_familiasDisponibles, true);
            this.dgv_familiasDisponibles.Size = new System.Drawing.Size(194, 210);
            this.dgv_familiasDisponibles.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(0, 302);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(544, 10);
            this.label15.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(0, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(542, 10);
            this.label16.TabIndex = 24;
            // 
            // btn_DesasociarFamilia
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_DesasociarFamilia, "ModificarUsuario.htm#btn_DesasociarFamilia");
            this.HelpProviderHG.SetHelpNavigator(this.btn_DesasociarFamilia, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_DesasociarFamilia.Location = new System.Drawing.Point(246, 238);
            this.btn_DesasociarFamilia.Name = "btn_DesasociarFamilia";
            this.HelpProviderHG.SetShowHelp(this.btn_DesasociarFamilia, true);
            this.btn_DesasociarFamilia.Size = new System.Drawing.Size(55, 37);
            this.btn_DesasociarFamilia.TabIndex = 22;
            this.btn_DesasociarFamilia.Text = "<";
            this.btn_DesasociarFamilia.UseVisualStyleBackColor = true;
            this.btn_DesasociarFamilia.Click += new System.EventHandler(this.btn_DesasociarFamilia_Click);
            // 
            // btn_AsociarFamilia
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_AsociarFamilia, "ModificarUsuario.htm#btn_AsociarFamilia");
            this.HelpProviderHG.SetHelpNavigator(this.btn_AsociarFamilia, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_AsociarFamilia.Location = new System.Drawing.Point(246, 65);
            this.btn_AsociarFamilia.Name = "btn_AsociarFamilia";
            this.HelpProviderHG.SetShowHelp(this.btn_AsociarFamilia, true);
            this.btn_AsociarFamilia.Size = new System.Drawing.Size(55, 37);
            this.btn_AsociarFamilia.TabIndex = 21;
            this.btn_AsociarFamilia.Text = ">";
            this.btn_AsociarFamilia.UseVisualStyleBackColor = true;
            this.btn_AsociarFamilia.Click += new System.EventHandler(this.btn_AsociarFamilia_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(331, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Familias Asociadas al usuario";
            // 
            // lbl_FamiliasDisponibles
            // 
            this.lbl_FamiliasDisponibles.AutoSize = true;
            this.lbl_FamiliasDisponibles.Location = new System.Drawing.Point(23, 36);
            this.lbl_FamiliasDisponibles.Name = "lbl_FamiliasDisponibles";
            this.lbl_FamiliasDisponibles.Size = new System.Drawing.Size(101, 13);
            this.lbl_FamiliasDisponibles.TabIndex = 19;
            this.lbl_FamiliasDisponibles.Text = "Familias Disponibles";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage4.Controls.Add(this.dgv_patentesAsociadas);
            this.tabPage4.Controls.Add(this.dgv_patentesDisponibles);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.btn_NegarPatente);
            this.tabPage4.Controls.Add(this.btn_DesasociarPatente);
            this.tabPage4.Controls.Add(this.btn_AsociarPatente);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label4);
            this.HelpProviderHG.SetHelpKeyword(this.tabPage4, "ModificarUsuario.htm#tabPage4_2");
            this.HelpProviderHG.SetHelpNavigator(this.tabPage4, System.Windows.Forms.HelpNavigator.Topic);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.HelpProviderHG.SetShowHelp(this.tabPage4, true);
            this.tabPage4.Size = new System.Drawing.Size(546, 315);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Patente";
            // 
            // dgv_patentesAsociadas
            // 
            this.dgv_patentesAsociadas.AllowUserToAddRows = false;
            this.dgv_patentesAsociadas.AllowUserToDeleteRows = false;
            this.dgv_patentesAsociadas.AllowUserToResizeRows = false;
            this.dgv_patentesAsociadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_patentesAsociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HelpProviderHG.SetHelpKeyword(this.dgv_patentesAsociadas, "ModificarUsuario.htm#dgv_patentesAsociadas");
            this.HelpProviderHG.SetHelpNavigator(this.dgv_patentesAsociadas, System.Windows.Forms.HelpNavigator.Topic);
            this.dgv_patentesAsociadas.Location = new System.Drawing.Point(335, 65);
            this.dgv_patentesAsociadas.Name = "dgv_patentesAsociadas";
            this.dgv_patentesAsociadas.RowHeadersVisible = false;
            this.dgv_patentesAsociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HelpProviderHG.SetShowHelp(this.dgv_patentesAsociadas, true);
            this.dgv_patentesAsociadas.Size = new System.Drawing.Size(194, 210);
            this.dgv_patentesAsociadas.TabIndex = 27;
            this.dgv_patentesAsociadas.SelectionChanged += new System.EventHandler(this.dgv_patentesAsociadas_SelectionChanged);
            // 
            // dgv_patentesDisponibles
            // 
            this.dgv_patentesDisponibles.AllowUserToAddRows = false;
            this.dgv_patentesDisponibles.AllowUserToDeleteRows = false;
            this.dgv_patentesDisponibles.AllowUserToResizeColumns = false;
            this.dgv_patentesDisponibles.AllowUserToResizeRows = false;
            this.dgv_patentesDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_patentesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HelpProviderHG.SetHelpKeyword(this.dgv_patentesDisponibles, "ModificarUsuario.htm#dgv_patentesDisponibles");
            this.HelpProviderHG.SetHelpNavigator(this.dgv_patentesDisponibles, System.Windows.Forms.HelpNavigator.Topic);
            this.dgv_patentesDisponibles.Location = new System.Drawing.Point(27, 65);
            this.dgv_patentesDisponibles.Name = "dgv_patentesDisponibles";
            this.dgv_patentesDisponibles.RowHeadersVisible = false;
            this.dgv_patentesDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_patentesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HelpProviderHG.SetShowHelp(this.dgv_patentesDisponibles, true);
            this.dgv_patentesDisponibles.Size = new System.Drawing.Size(194, 210);
            this.dgv_patentesDisponibles.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(1, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 10);
            this.label1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(1, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 10);
            this.label2.TabIndex = 24;
            // 
            // btn_NegarPatente
            // 
            this.btn_NegarPatente.Enabled = false;
            this.HelpProviderHG.SetHelpKeyword(this.btn_NegarPatente, "ModificarUsuario.htm#btn_NegarPatente");
            this.HelpProviderHG.SetHelpNavigator(this.btn_NegarPatente, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_NegarPatente.Location = new System.Drawing.Point(247, 117);
            this.btn_NegarPatente.Name = "btn_NegarPatente";
            this.HelpProviderHG.SetShowHelp(this.btn_NegarPatente, true);
            this.btn_NegarPatente.Size = new System.Drawing.Size(55, 106);
            this.btn_NegarPatente.TabIndex = 23;
            this.btn_NegarPatente.Text = "Negar ✍";
            this.btn_NegarPatente.UseVisualStyleBackColor = true;
            this.btn_NegarPatente.Click += new System.EventHandler(this.btn_NegarPatente_Click);
            // 
            // btn_DesasociarPatente
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_DesasociarPatente, "ModificarUsuario.htm#btn_DesasociarPatente");
            this.HelpProviderHG.SetHelpNavigator(this.btn_DesasociarPatente, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_DesasociarPatente.Location = new System.Drawing.Point(247, 238);
            this.btn_DesasociarPatente.Name = "btn_DesasociarPatente";
            this.HelpProviderHG.SetShowHelp(this.btn_DesasociarPatente, true);
            this.btn_DesasociarPatente.Size = new System.Drawing.Size(55, 37);
            this.btn_DesasociarPatente.TabIndex = 22;
            this.btn_DesasociarPatente.Text = "<";
            this.btn_DesasociarPatente.UseVisualStyleBackColor = true;
            this.btn_DesasociarPatente.Click += new System.EventHandler(this.btn_DesasociarPatente_Click);
            // 
            // btn_AsociarPatente
            // 
            this.HelpProviderHG.SetHelpKeyword(this.btn_AsociarPatente, "ModificarUsuario.htm#btn_AsociarPatente");
            this.HelpProviderHG.SetHelpNavigator(this.btn_AsociarPatente, System.Windows.Forms.HelpNavigator.Topic);
            this.btn_AsociarPatente.Location = new System.Drawing.Point(247, 65);
            this.btn_AsociarPatente.Name = "btn_AsociarPatente";
            this.HelpProviderHG.SetShowHelp(this.btn_AsociarPatente, true);
            this.btn_AsociarPatente.Size = new System.Drawing.Size(55, 37);
            this.btn_AsociarPatente.TabIndex = 21;
            this.btn_AsociarPatente.Text = ">";
            this.btn_AsociarPatente.UseVisualStyleBackColor = true;
            this.btn_AsociarPatente.Click += new System.EventHandler(this.btn_AsociarPatente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Patentes Asociadas al usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Patentes Disponibles";
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 408);
            this.Controls.Add(this.btn_GuardarUsuario);
            this.Controls.Add(this.btn_CancelarUsuario);
            this.Controls.Add(this.tabControl1);
            this.HelpProviderHG.SetHelpKeyword(this, "ModificarUsuario.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "ModificarUsuario";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.ModificarUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_familiasAsociadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_familiasDisponibles)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patentesAsociadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patentesDisponibles)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_BlanquearPass;
        private System.Windows.Forms.DataGridView dgv_familiasAsociadas;
        private System.Windows.Forms.DataGridView dgv_familiasDisponibles;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_DesasociarFamilia;
        private System.Windows.Forms.Button btn_AsociarFamilia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_FamiliasDisponibles;
        private System.Windows.Forms.DataGridView dgv_patentesAsociadas;
        private System.Windows.Forms.DataGridView dgv_patentesDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_NegarPatente;
        private System.Windows.Forms.Button btn_DesasociarPatente;
        private System.Windows.Forms.Button btn_AsociarPatente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}