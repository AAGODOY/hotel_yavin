namespace Hotel_Yavin
{
    partial class AltaUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaUsuario));
            this.btn_GuardarUsuario = new System.Windows.Forms.Button();
            this.btn_CancelarUsuario = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgv_patentesAsociadas = new System.Windows.Forms.DataGridView();
            this.dgv_patentesDisponibles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_divider = new System.Windows.Forms.Label();
            this.btn_Negar = new System.Windows.Forms.Button();
            this.btn_DesasociarPatente = new System.Windows.Forms.Button();
            this.btn_AsociarPatente = new System.Windows.Forms.Button();
            this.lbl_PatentesAsociadas = new System.Windows.Forms.Label();
            this.lbl_PatentesDisponibles = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_FamiliasAsociadas = new System.Windows.Forms.DataGridView();
            this.dgv_FamiliasDisponibles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DesasociarFamilia = new System.Windows.Forms.Button();
            this.btn_AsociarFamilia = new System.Windows.Forms.Button();
            this.lbl_FamiliasAsociadas = new System.Windows.Forms.Label();
            this.lbl_familiasDisponibles = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patentesAsociadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patentesDisponibles)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FamiliasAsociadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FamiliasDisponibles)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GuardarUsuario
            // 
            this.btn_GuardarUsuario.Location = new System.Drawing.Point(477, 355);
            this.btn_GuardarUsuario.Name = "btn_GuardarUsuario";
            this.btn_GuardarUsuario.Size = new System.Drawing.Size(89, 29);
            this.btn_GuardarUsuario.TabIndex = 15;
            this.btn_GuardarUsuario.Text = "Aceptar";
            this.btn_GuardarUsuario.UseVisualStyleBackColor = true;
            this.btn_GuardarUsuario.Click += new System.EventHandler(this.btn_GuardarUsuario_Click);
            // 
            // btn_CancelarUsuario
            // 
            this.btn_CancelarUsuario.Location = new System.Drawing.Point(382, 355);
            this.btn_CancelarUsuario.Name = "btn_CancelarUsuario";
            this.btn_CancelarUsuario.Size = new System.Drawing.Size(89, 29);
            this.btn_CancelarUsuario.TabIndex = 14;
            this.btn_CancelarUsuario.Text = "Cancelar";
            this.btn_CancelarUsuario.UseVisualStyleBackColor = true;
            this.btn_CancelarUsuario.Click += new System.EventHandler(this.btn_CancelarUsuario_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage4.Controls.Add(this.dgv_patentesAsociadas);
            this.tabPage4.Controls.Add(this.dgv_patentesDisponibles);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.lbl_divider);
            this.tabPage4.Controls.Add(this.btn_Negar);
            this.tabPage4.Controls.Add(this.btn_DesasociarPatente);
            this.tabPage4.Controls.Add(this.btn_AsociarPatente);
            this.tabPage4.Controls.Add(this.lbl_PatentesAsociadas);
            this.tabPage4.Controls.Add(this.lbl_PatentesDisponibles);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(550, 315);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Patente";
            // 
            // dgv_patentesAsociadas
            // 
            this.dgv_patentesAsociadas.AllowUserToAddRows = false;
            this.dgv_patentesAsociadas.AllowUserToDeleteRows = false;
            this.dgv_patentesAsociadas.AllowUserToResizeColumns = false;
            this.dgv_patentesAsociadas.AllowUserToResizeRows = false;
            this.dgv_patentesAsociadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_patentesAsociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patentesAsociadas.Location = new System.Drawing.Point(337, 65);
            this.dgv_patentesAsociadas.Name = "dgv_patentesAsociadas";
            this.dgv_patentesAsociadas.RowHeadersVisible = false;
            this.dgv_patentesAsociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_patentesAsociadas.Size = new System.Drawing.Size(194, 210);
            this.dgv_patentesAsociadas.TabIndex = 18;
            this.dgv_patentesAsociadas.SelectionChanged += new System.EventHandler(this.Dgv_patentesAsociadas_SelectionChanged);
            // 
            // dgv_patentesDisponibles
            // 
            this.dgv_patentesDisponibles.AllowUserToAddRows = false;
            this.dgv_patentesDisponibles.AllowUserToDeleteRows = false;
            this.dgv_patentesDisponibles.AllowUserToResizeColumns = false;
            this.dgv_patentesDisponibles.AllowUserToResizeRows = false;
            this.dgv_patentesDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_patentesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patentesDisponibles.Location = new System.Drawing.Point(29, 65);
            this.dgv_patentesDisponibles.Name = "dgv_patentesDisponibles";
            this.dgv_patentesDisponibles.RowHeadersVisible = false;
            this.dgv_patentesDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_patentesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_patentesDisponibles.Size = new System.Drawing.Size(194, 210);
            this.dgv_patentesDisponibles.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(3, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 10);
            this.label1.TabIndex = 16;
            // 
            // lbl_divider
            // 
            this.lbl_divider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_divider.Location = new System.Drawing.Point(3, 3);
            this.lbl_divider.Name = "lbl_divider";
            this.lbl_divider.Size = new System.Drawing.Size(542, 10);
            this.lbl_divider.TabIndex = 15;
            // 
            // btn_Negar
            // 
            this.btn_Negar.Enabled = false;
            this.btn_Negar.Location = new System.Drawing.Point(249, 117);
            this.btn_Negar.Name = "btn_Negar";
            this.btn_Negar.Size = new System.Drawing.Size(55, 106);
            this.btn_Negar.TabIndex = 12;
            this.btn_Negar.Text = "Negar ✍";
            this.btn_Negar.UseVisualStyleBackColor = true;
            this.btn_Negar.Click += new System.EventHandler(this.btn_Negar_Click);
            // 
            // btn_DesasociarPatente
            // 
            this.btn_DesasociarPatente.Location = new System.Drawing.Point(249, 238);
            this.btn_DesasociarPatente.Name = "btn_DesasociarPatente";
            this.btn_DesasociarPatente.Size = new System.Drawing.Size(55, 37);
            this.btn_DesasociarPatente.TabIndex = 11;
            this.btn_DesasociarPatente.Text = "<";
            this.btn_DesasociarPatente.UseVisualStyleBackColor = true;
            this.btn_DesasociarPatente.Click += new System.EventHandler(this.Btn_DesasociarPatente_Click);
            // 
            // btn_AsociarPatente
            // 
            this.btn_AsociarPatente.Location = new System.Drawing.Point(249, 65);
            this.btn_AsociarPatente.Name = "btn_AsociarPatente";
            this.btn_AsociarPatente.Size = new System.Drawing.Size(55, 37);
            this.btn_AsociarPatente.TabIndex = 10;
            this.btn_AsociarPatente.Text = ">";
            this.btn_AsociarPatente.UseVisualStyleBackColor = true;
            this.btn_AsociarPatente.Click += new System.EventHandler(this.btn_AsociarPatente_Click);
            // 
            // lbl_PatentesAsociadas
            // 
            this.lbl_PatentesAsociadas.AutoSize = true;
            this.lbl_PatentesAsociadas.Location = new System.Drawing.Point(334, 36);
            this.lbl_PatentesAsociadas.Name = "lbl_PatentesAsociadas";
            this.lbl_PatentesAsociadas.Size = new System.Drawing.Size(149, 13);
            this.lbl_PatentesAsociadas.TabIndex = 7;
            this.lbl_PatentesAsociadas.Text = "Patentes Asociadas al usuario";
            // 
            // lbl_PatentesDisponibles
            // 
            this.lbl_PatentesDisponibles.AutoSize = true;
            this.lbl_PatentesDisponibles.Location = new System.Drawing.Point(26, 36);
            this.lbl_PatentesDisponibles.Name = "lbl_PatentesDisponibles";
            this.lbl_PatentesDisponibles.Size = new System.Drawing.Size(106, 13);
            this.lbl_PatentesDisponibles.TabIndex = 6;
            this.lbl_PatentesDisponibles.Text = "Patentes Disponibles";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage3.Controls.Add(this.dgv_FamiliasAsociadas);
            this.tabPage3.Controls.Add(this.dgv_FamiliasDisponibles);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btn_DesasociarFamilia);
            this.tabPage3.Controls.Add(this.btn_AsociarFamilia);
            this.tabPage3.Controls.Add(this.lbl_FamiliasAsociadas);
            this.tabPage3.Controls.Add(this.lbl_familiasDisponibles);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(550, 315);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Familia";
            // 
            // dgv_FamiliasAsociadas
            // 
            this.dgv_FamiliasAsociadas.AllowUserToAddRows = false;
            this.dgv_FamiliasAsociadas.AllowUserToDeleteRows = false;
            this.dgv_FamiliasAsociadas.AllowUserToResizeColumns = false;
            this.dgv_FamiliasAsociadas.AllowUserToResizeRows = false;
            this.dgv_FamiliasAsociadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_FamiliasAsociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FamiliasAsociadas.Location = new System.Drawing.Point(337, 65);
            this.dgv_FamiliasAsociadas.Name = "dgv_FamiliasAsociadas";
            this.dgv_FamiliasAsociadas.RowHeadersVisible = false;
            this.dgv_FamiliasAsociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FamiliasAsociadas.Size = new System.Drawing.Size(194, 210);
            this.dgv_FamiliasAsociadas.TabIndex = 26;
            // 
            // dgv_FamiliasDisponibles
            // 
            this.dgv_FamiliasDisponibles.AllowUserToAddRows = false;
            this.dgv_FamiliasDisponibles.AllowUserToDeleteRows = false;
            this.dgv_FamiliasDisponibles.AllowUserToResizeColumns = false;
            this.dgv_FamiliasDisponibles.AllowUserToResizeRows = false;
            this.dgv_FamiliasDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_FamiliasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FamiliasDisponibles.Location = new System.Drawing.Point(29, 65);
            this.dgv_FamiliasDisponibles.Name = "dgv_FamiliasDisponibles";
            this.dgv_FamiliasDisponibles.RowHeadersVisible = false;
            this.dgv_FamiliasDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_FamiliasDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FamiliasDisponibles.Size = new System.Drawing.Size(194, 210);
            this.dgv_FamiliasDisponibles.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(3, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 10);
            this.label2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(542, 10);
            this.label3.TabIndex = 23;
            // 
            // btn_DesasociarFamilia
            // 
            this.btn_DesasociarFamilia.Location = new System.Drawing.Point(255, 239);
            this.btn_DesasociarFamilia.Name = "btn_DesasociarFamilia";
            this.btn_DesasociarFamilia.Size = new System.Drawing.Size(46, 37);
            this.btn_DesasociarFamilia.TabIndex = 22;
            this.btn_DesasociarFamilia.Text = "<";
            this.btn_DesasociarFamilia.UseVisualStyleBackColor = true;
            this.btn_DesasociarFamilia.Click += new System.EventHandler(this.btn_DesasociarFamilia_Click);
            // 
            // btn_AsociarFamilia
            // 
            this.btn_AsociarFamilia.Location = new System.Drawing.Point(255, 66);
            this.btn_AsociarFamilia.Name = "btn_AsociarFamilia";
            this.btn_AsociarFamilia.Size = new System.Drawing.Size(46, 37);
            this.btn_AsociarFamilia.TabIndex = 21;
            this.btn_AsociarFamilia.Text = ">";
            this.btn_AsociarFamilia.UseVisualStyleBackColor = true;
            this.btn_AsociarFamilia.Click += new System.EventHandler(this.btn_AsociarFamilia_Click);
            // 
            // lbl_FamiliasAsociadas
            // 
            this.lbl_FamiliasAsociadas.AutoSize = true;
            this.lbl_FamiliasAsociadas.Location = new System.Drawing.Point(334, 36);
            this.lbl_FamiliasAsociadas.Name = "lbl_FamiliasAsociadas";
            this.lbl_FamiliasAsociadas.Size = new System.Drawing.Size(144, 13);
            this.lbl_FamiliasAsociadas.TabIndex = 20;
            this.lbl_FamiliasAsociadas.Text = "Familias Asociadas al usuario";
            // 
            // lbl_familiasDisponibles
            // 
            this.lbl_familiasDisponibles.AutoSize = true;
            this.lbl_familiasDisponibles.Location = new System.Drawing.Point(26, 36);
            this.lbl_familiasDisponibles.Name = "lbl_familiasDisponibles";
            this.lbl_familiasDisponibles.Size = new System.Drawing.Size(101, 13);
            this.lbl_familiasDisponibles.TabIndex = 19;
            this.lbl_familiasDisponibles.Text = "Familias Disponibles";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.pictureBox1);
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
            this.tabPage1.Size = new System.Drawing.Size(550, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos del Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Domicilio
            // 
            this.txt_Domicilio.Location = new System.Drawing.Point(134, 206);
            this.txt_Domicilio.Name = "txt_Domicilio";
            this.txt_Domicilio.Size = new System.Drawing.Size(179, 20);
            this.txt_Domicilio.TabIndex = 7;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(134, 180);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(179, 20);
            this.txt_Telefono.TabIndex = 6;
            // 
            // txt_NumDoc
            // 
            this.txt_NumDoc.Location = new System.Drawing.Point(134, 128);
            this.txt_NumDoc.Name = "txt_NumDoc";
            this.txt_NumDoc.Size = new System.Drawing.Size(179, 20);
            this.txt_NumDoc.TabIndex = 4;
            this.txt_NumDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumDoc_KeyPress);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(134, 102);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(179, 20);
            this.txt_Apellido.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(134, 154);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(179, 20);
            this.txt_Email.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(134, 72);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(179, 20);
            this.txt_Nombre.TabIndex = 2;
            // 
            // txt_NomUsu
            // 
            this.txt_NomUsu.Location = new System.Drawing.Point(134, 43);
            this.txt_NomUsu.Name = "txt_NomUsu";
            this.txt_NomUsu.Size = new System.Drawing.Size(179, 20);
            this.txt_NomUsu.TabIndex = 1;
            // 
            // lbl_Domicilio
            // 
            this.lbl_Domicilio.AutoSize = true;
            this.lbl_Domicilio.Location = new System.Drawing.Point(6, 209);
            this.lbl_Domicilio.Name = "lbl_Domicilio";
            this.lbl_Domicilio.Size = new System.Drawing.Size(49, 13);
            this.lbl_Domicilio.TabIndex = 16;
            this.lbl_Domicilio.Text = "Domicilio";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(6, 183);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefono.TabIndex = 14;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // lbl_NumDoc
            // 
            this.lbl_NumDoc.AutoSize = true;
            this.lbl_NumDoc.Location = new System.Drawing.Point(6, 131);
            this.lbl_NumDoc.Name = "lbl_NumDoc";
            this.lbl_NumDoc.Size = new System.Drawing.Size(117, 13);
            this.lbl_NumDoc.TabIndex = 12;
            this.lbl_NumDoc.Text = "Numero de Documento";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(6, 105);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido.TabIndex = 10;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(6, 157);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 75);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_NomUsu
            // 
            this.lbl_NomUsu.AutoSize = true;
            this.lbl_NomUsu.Location = new System.Drawing.Point(6, 46);
            this.lbl_NomUsu.Name = "lbl_NomUsu";
            this.lbl_NomUsu.Size = new System.Drawing.Size(98, 13);
            this.lbl_NomUsu.TabIndex = 0;
            this.lbl_NomUsu.Text = "Nombre del usuario";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 341);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 399);
            this.Controls.Add(this.btn_GuardarUsuario);
            this.Controls.Add(this.btn_CancelarUsuario);
            this.Controls.Add(this.tabControl1);
            this.Name = "AltaUsuario";
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patentesAsociadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patentesDisponibles)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FamiliasAsociadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FamiliasDisponibles)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GuardarUsuario;
        private System.Windows.Forms.Button btn_CancelarUsuario;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_DesasociarPatente;
        private System.Windows.Forms.Button btn_AsociarPatente;
        private System.Windows.Forms.Label lbl_PatentesAsociadas;
        private System.Windows.Forms.Label lbl_PatentesDisponibles;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_Negar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_divider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_patentesAsociadas;
        private System.Windows.Forms.DataGridView dgv_patentesDisponibles;
        private System.Windows.Forms.DataGridView dgv_FamiliasAsociadas;
        private System.Windows.Forms.DataGridView dgv_FamiliasDisponibles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_DesasociarFamilia;
        private System.Windows.Forms.Button btn_AsociarFamilia;
        private System.Windows.Forms.Label lbl_FamiliasAsociadas;
        private System.Windows.Forms.Label lbl_familiasDisponibles;
    }
}

