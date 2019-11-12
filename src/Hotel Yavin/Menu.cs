using System;
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
        //public override string HelpPage => "About.htm";

        BE.Usuario usuario_logueado = new BE.Usuario();
        BLL.Bitacora.BAJA bitacora_BAJA = new BLL.Bitacora.BAJA();

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(BE.Usuario usu)
        {
            InitializeComponent();

            usuario_logueado = usu;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Tsmi_AdminReservas.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Reservas");
            Tsmi_AdminCobranza.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Cobranza");
            Tsmi_AdminCliente.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Cliente");
            Tsmi_AdminHabitacion.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Habitacion");
            Tsmi_AdminServAdicionales.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Serv. Adicionales");
            Tsmi_AdminUsuario.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Usuario");
            Tsmi_AdminPatente.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Patente");
            Tsmi_AdminFamilia.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Familia");
            Tsmi_Bitacora.Enabled = BLL.ConfigUsuario.ValidarAcceso("Ver Bitácora");
            Tsmi_RestaurarBackUp.Enabled = BLL.ConfigUsuario.ValidarAcceso("Ver Restaurar Back-Up");
            Tsmi_GenerarBackUp.Enabled = BLL.ConfigUsuario.ValidarAcceso("Ver Back-Up");
            Tsmi_modContrasena.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Contraseña");
            Tsmi_Idioma.Enabled = BLL.ConfigUsuario.ValidarAcceso("Ver Modificar Idioma");
            Tsmi_DatosPersonales.Enabled = BLL.ConfigUsuario.ValidarAcceso("Ver Datos Personales");

            switch (BE.ConfigUsuario.idioma.descripcion)
            {
                case "ES":
                    reservasToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(1);
                    Tsmi_AdminReservas.Text = BLL.ConfigUsuario.Texto(3);
                    cobranzaToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(7);
                    Tsmi_AdminCobranza.Text = BLL.ConfigUsuario.Texto(9);
                    clienteToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(11);
                    Tsmi_AdminCliente.Text = BLL.ConfigUsuario.Texto(13);
                    parametrizaciónToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(15);
                    Tsmi_AdminHabitacion.Text = BLL.ConfigUsuario.Texto(17);
                    Tsmi_AdminServAdicionales.Text = BLL.ConfigUsuario.Texto(19);
                    administraciónSeguridadToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(21);
                    Tsmi_AdminUsuario.Text = BLL.ConfigUsuario.Texto(23);
                    Tsmi_AdminPatente.Text = BLL.ConfigUsuario.Texto(25);
                    Tsmi_AdminFamilia.Text = BLL.ConfigUsuario.Texto(27);
                    seguridadToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(29);
                    Tsmi_Bitacora.Text = BLL.ConfigUsuario.Texto(31);
                    Tsmi_RestaurarBackUp.Text = BLL.ConfigUsuario.Texto(33);
                    Tsmi_GenerarBackUp.Text = BLL.ConfigUsuario.Texto(35);
                    Tsmi_modContrasena.Text = BLL.ConfigUsuario.Texto(37);
                    cuentaToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(39);
                    Tsmi_Idioma.Text = BLL.ConfigUsuario.Texto(41);
                    Tsmi_DatosPersonales.Text = BLL.ConfigUsuario.Texto(43);
                    Tsmi_CerrarSesion.Text = BLL.ConfigUsuario.Texto(45);
                    this.Text = BLL.ConfigUsuario.Texto(5);
                    break;
                case "EN":
                    reservasToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(2);
                    Tsmi_AdminReservas.Text = BLL.ConfigUsuario.Texto(4);
                    cobranzaToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(8);
                    Tsmi_AdminCobranza.Text = BLL.ConfigUsuario.Texto(10);
                    clienteToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(12);
                    Tsmi_AdminCliente.Text = BLL.ConfigUsuario.Texto(14);
                    parametrizaciónToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(16);
                    Tsmi_AdminHabitacion.Text = BLL.ConfigUsuario.Texto(18);
                    Tsmi_AdminServAdicionales.Text = BLL.ConfigUsuario.Texto(20);
                    administraciónSeguridadToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(22);
                    Tsmi_AdminUsuario.Text = BLL.ConfigUsuario.Texto(24);
                    Tsmi_AdminPatente.Text = BLL.ConfigUsuario.Texto(26);
                    Tsmi_AdminFamilia.Text = BLL.ConfigUsuario.Texto(28);
                    seguridadToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(30);
                    Tsmi_Bitacora.Text = BLL.ConfigUsuario.Texto(32);
                    Tsmi_RestaurarBackUp.Text = BLL.ConfigUsuario.Texto(34);
                    Tsmi_GenerarBackUp.Text = BLL.ConfigUsuario.Texto(36);
                    Tsmi_modContrasena.Text = BLL.ConfigUsuario.Texto(38);
                    cuentaToolStripMenuItem.Text = BLL.ConfigUsuario.Texto(40);
                    Tsmi_Idioma.Text = BLL.ConfigUsuario.Texto(42);
                    Tsmi_DatosPersonales.Text = BLL.ConfigUsuario.Texto(44);
                    Tsmi_CerrarSesion.Text = BLL.ConfigUsuario.Texto(46);
                    this.Text = BLL.ConfigUsuario.Texto(6);
                    break;
            }
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
            AdministrarUsuario adm_usuario = new AdministrarUsuario(this.usuario_logueado);
            adm_usuario.Show();
        }

        private void administrarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarPatente adm_patente = new AdministrarPatente(this.usuario_logueado);
            adm_patente.Show();
        }

        private void administrarFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarFamilia adm_familia = new AdministrarFamilia(this.usuario_logueado);
            adm_familia.Show();
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora();
            bitacora.Show();
        }

        private void generarBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generar_Copia_de_Seguridad backup = new Generar_Copia_de_Seguridad(this.usuario_logueado);
            backup.Show();
        }

        private void restaurarBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restaurar_copia_de_seguridad restore = new Restaurar_copia_de_seguridad(this.usuario_logueado);
            restore.Show();
        }

        private void modificarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Contrasena modificarpass = new Modificar_Contrasena(usuario_logueado);
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
            bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "El usuario Cerró Sesion");
            this.Close();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, helpProvider1.HelpNamespace);

                //Hotel Yavin - Manual Operativo.chm
            }
        }
    }
}
