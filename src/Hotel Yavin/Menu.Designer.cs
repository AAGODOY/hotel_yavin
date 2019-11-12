namespace Hotel_Yavin
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_AdminReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.cobranzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_AdminCobranza = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_AdminCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_AdminHabitacion = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_AdminServAdicionales = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_AdminUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_AdminPatente = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_AdminFamilia = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Bitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_RestaurarBackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_GenerarBackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_modContrasena = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Idioma = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_DatosPersonales = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_CerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem,
            this.cobranzaToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.parametrizaciónToolStripMenuItem,
            this.administraciónSeguridadToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.cuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_AdminReservas});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // Tsmi_AdminReservas
            // 
            this.Tsmi_AdminReservas.Name = "Tsmi_AdminReservas";
            this.Tsmi_AdminReservas.Size = new System.Drawing.Size(184, 22);
            this.Tsmi_AdminReservas.Text = "Administrar Reservas";
            this.Tsmi_AdminReservas.Click += new System.EventHandler(this.administrarReservasToolStripMenuItem_Click);
            // 
            // cobranzaToolStripMenuItem
            // 
            this.cobranzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_AdminCobranza});
            this.cobranzaToolStripMenuItem.Name = "cobranzaToolStripMenuItem";
            this.cobranzaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cobranzaToolStripMenuItem.Text = "Cobranza";
            // 
            // Tsmi_AdminCobranza
            // 
            this.Tsmi_AdminCobranza.Name = "Tsmi_AdminCobranza";
            this.Tsmi_AdminCobranza.Size = new System.Drawing.Size(189, 22);
            this.Tsmi_AdminCobranza.Text = "Administrar Cobranza";
            this.Tsmi_AdminCobranza.Click += new System.EventHandler(this.administrarCobranzaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_AdminCliente});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // Tsmi_AdminCliente
            // 
            this.Tsmi_AdminCliente.Name = "Tsmi_AdminCliente";
            this.Tsmi_AdminCliente.Size = new System.Drawing.Size(176, 22);
            this.Tsmi_AdminCliente.Text = "Administrar Cliente";
            this.Tsmi_AdminCliente.Click += new System.EventHandler(this.administrarClienteToolStripMenuItem_Click);
            // 
            // parametrizaciónToolStripMenuItem
            // 
            this.parametrizaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_AdminHabitacion,
            this.Tsmi_AdminServAdicionales});
            this.parametrizaciónToolStripMenuItem.Name = "parametrizaciónToolStripMenuItem";
            this.parametrizaciónToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.parametrizaciónToolStripMenuItem.Text = "Parametrización";
            // 
            // Tsmi_AdminHabitacion
            // 
            this.Tsmi_AdminHabitacion.Name = "Tsmi_AdminHabitacion";
            this.Tsmi_AdminHabitacion.Size = new System.Drawing.Size(228, 22);
            this.Tsmi_AdminHabitacion.Text = "Administrar Habitación";
            this.Tsmi_AdminHabitacion.Click += new System.EventHandler(this.administrarHabitaciónToolStripMenuItem_Click);
            // 
            // Tsmi_AdminServAdicionales
            // 
            this.Tsmi_AdminServAdicionales.Name = "Tsmi_AdminServAdicionales";
            this.Tsmi_AdminServAdicionales.Size = new System.Drawing.Size(228, 22);
            this.Tsmi_AdminServAdicionales.Text = "Administrar Serv. Adicionales";
            this.Tsmi_AdminServAdicionales.Click += new System.EventHandler(this.administrarServAdicionalesToolStripMenuItem_Click);
            // 
            // administraciónSeguridadToolStripMenuItem
            // 
            this.administraciónSeguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_AdminUsuario,
            this.Tsmi_AdminPatente,
            this.Tsmi_AdminFamilia});
            this.administraciónSeguridadToolStripMenuItem.Name = "administraciónSeguridadToolStripMenuItem";
            this.administraciónSeguridadToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.administraciónSeguridadToolStripMenuItem.Text = "Administración Seguridad";
            // 
            // Tsmi_AdminUsuario
            // 
            this.Tsmi_AdminUsuario.Name = "Tsmi_AdminUsuario";
            this.Tsmi_AdminUsuario.Size = new System.Drawing.Size(179, 22);
            this.Tsmi_AdminUsuario.Text = "Administrar Usuario";
            this.Tsmi_AdminUsuario.Click += new System.EventHandler(this.administrarUsuarioToolStripMenuItem_Click);
            // 
            // Tsmi_AdminPatente
            // 
            this.Tsmi_AdminPatente.Name = "Tsmi_AdminPatente";
            this.Tsmi_AdminPatente.Size = new System.Drawing.Size(179, 22);
            this.Tsmi_AdminPatente.Text = "Administrar Patente";
            this.Tsmi_AdminPatente.Click += new System.EventHandler(this.administrarPatenteToolStripMenuItem_Click);
            // 
            // Tsmi_AdminFamilia
            // 
            this.Tsmi_AdminFamilia.Name = "Tsmi_AdminFamilia";
            this.Tsmi_AdminFamilia.Size = new System.Drawing.Size(179, 22);
            this.Tsmi_AdminFamilia.Text = "Administrar Familia";
            this.Tsmi_AdminFamilia.Click += new System.EventHandler(this.administrarFamiliaToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Bitacora,
            this.Tsmi_RestaurarBackUp,
            this.Tsmi_GenerarBackUp,
            this.Tsmi_modContrasena});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // Tsmi_Bitacora
            // 
            this.Tsmi_Bitacora.Name = "Tsmi_Bitacora";
            this.Tsmi_Bitacora.Size = new System.Drawing.Size(188, 22);
            this.Tsmi_Bitacora.Text = "Bitacora";
            this.Tsmi_Bitacora.Click += new System.EventHandler(this.bitácoraToolStripMenuItem_Click);
            // 
            // Tsmi_RestaurarBackUp
            // 
            this.Tsmi_RestaurarBackUp.Name = "Tsmi_RestaurarBackUp";
            this.Tsmi_RestaurarBackUp.Size = new System.Drawing.Size(188, 22);
            this.Tsmi_RestaurarBackUp.Text = "Restaurar Back-Up";
            this.Tsmi_RestaurarBackUp.Click += new System.EventHandler(this.restaurarBackUpToolStripMenuItem_Click);
            // 
            // Tsmi_GenerarBackUp
            // 
            this.Tsmi_GenerarBackUp.Name = "Tsmi_GenerarBackUp";
            this.Tsmi_GenerarBackUp.Size = new System.Drawing.Size(188, 22);
            this.Tsmi_GenerarBackUp.Text = "Generar Back-Up";
            this.Tsmi_GenerarBackUp.Click += new System.EventHandler(this.generarBackUpToolStripMenuItem_Click);
            // 
            // Tsmi_modContrasena
            // 
            this.Tsmi_modContrasena.Name = "Tsmi_modContrasena";
            this.Tsmi_modContrasena.Size = new System.Drawing.Size(188, 22);
            this.Tsmi_modContrasena.Text = "Modificar Contraseña";
            this.Tsmi_modContrasena.Click += new System.EventHandler(this.modificarContraseñaToolStripMenuItem_Click);
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Idioma,
            this.Tsmi_DatosPersonales,
            this.Tsmi_CerrarSesion});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.cuentaToolStripMenuItem.Text = "Mi Cuenta";
            // 
            // Tsmi_Idioma
            // 
            this.Tsmi_Idioma.Name = "Tsmi_Idioma";
            this.Tsmi_Idioma.Size = new System.Drawing.Size(163, 22);
            this.Tsmi_Idioma.Text = "Idioma";
            this.Tsmi_Idioma.Click += new System.EventHandler(this.idiomaToolStripMenuItem_Click);
            // 
            // Tsmi_DatosPersonales
            // 
            this.Tsmi_DatosPersonales.Name = "Tsmi_DatosPersonales";
            this.Tsmi_DatosPersonales.Size = new System.Drawing.Size(163, 22);
            this.Tsmi_DatosPersonales.Text = "Datos Personales";
            this.Tsmi_DatosPersonales.Click += new System.EventHandler(this.datosPersonalesToolStripMenuItem_Click);
            // 
            // Tsmi_CerrarSesion
            // 
            this.Tsmi_CerrarSesion.Name = "Tsmi_CerrarSesion";
            this.Tsmi_CerrarSesion.Size = new System.Drawing.Size(163, 22);
            this.Tsmi_CerrarSesion.Text = "Cerrar Sesión";
            this.Tsmi_CerrarSesion.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Hotel Yavin - Manual Operativo.chm";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(623, 229);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_AdminReservas;
        private System.Windows.Forms.ToolStripMenuItem cobranzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_AdminCobranza;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_AdminCliente;
        private System.Windows.Forms.ToolStripMenuItem parametrizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_AdminHabitacion;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_AdminServAdicionales;
        private System.Windows.Forms.ToolStripMenuItem administraciónSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_AdminUsuario;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_AdminPatente;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_AdminFamilia;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Bitacora;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_GenerarBackUp;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_RestaurarBackUp;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Idioma;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_modContrasena;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_DatosPersonales;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_CerrarSesion;
        private System.Windows.Forms.HelpProvider helpProvider1;

    }
}