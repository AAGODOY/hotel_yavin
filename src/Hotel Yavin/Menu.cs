﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Yavin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Tsmi_AdminReservas.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Reservas");
            //Tsmi_AdminCobranza.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Cobranza");
            //Tsmi_AdminCliente.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Cliente");
            //Tsmi_AdminHabitacion.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Habitacion");
            //Tsmi_AdminServAdicionales.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Serv. Adicionales");
            //Tsmi_AdminUsuario.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Usuario");
            //Tsmi_AdminPatente.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Patente");
            //Tsmi_AdminFamilia.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Familia");
            //Tsmi_Bitacora.Enabled = BLL.ConfigUsuario.ValidarAcceso("Ver Bitácora");
            //Tsmi_RestaurarBackUp.Enabled = BLL.ConfigUsuario.ValidarAcceso("Ver Restaurar Back-Up");
            //Tsmi_GenerarBackUp.Enabled = BLL.ConfigUsuario.ValidarAcceso("Ver Back-Up");
            //Tsmi_modContrasena.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Contraseña");
            //Tsmi_Idioma.Enabled = BLL.ConfigUsuario.ValidarAcceso("Ver Modificar Idioma");
            //Tsmi_DatosPersonales.Enabled = BLL.ConfigUsuario.ValidarAcceso("Ver Datos Personales");
        }

        private void administrarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarReserva adm_reserva = new AdministrarReserva();
            adm_reserva.Show();
        }

        private void administrarCobranzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarCobranza adm_cobranza = new AdministrarCobranza();
            adm_cobranza.Show();
        }

        private void administrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarCliente adm_cliente = new AdministrarCliente();
            adm_cliente.Show();
        }

        private void administrarHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaHabitaciones adm_habitacion = new ConsultaHabitaciones();
            adm_habitacion.Show();
        }

        private void administrarServAdicionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarServAdicionales adm_servicios = new AdministrarServAdicionales();
            adm_servicios.Show();
        }

        private void administrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarUsuario adm_usuario = new AdministrarUsuario();
            adm_usuario.Show();
        }

        private void administrarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarPatente adm_patente = new AdministrarPatente();
            adm_patente.Show();
        }

        private void administrarFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarFamilia adm_familia = new AdministrarFamilia();
            adm_familia.Show();
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora();
            bitacora.Show();
        }

        private void generarBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generar_Copia_de_Seguridad backup = new Generar_Copia_de_Seguridad();
            backup.Show();
        }

        private void restaurarBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restaurar_copia_de_seguridad restore = new Restaurar_copia_de_seguridad();
            restore.Show();
        }

        private void modificarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Contrasena modificarpass = new Modificar_Contrasena();
            modificarpass.Show();
        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarIdioma idioma = new ModificarIdioma();
            idioma.Show();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerDatosDeUsuario datosPersonales = new VerDatosDeUsuario();
            datosPersonales.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();

        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
