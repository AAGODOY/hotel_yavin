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
    public partial class AdministrarReserva : Form
    {
        BLL.Reserva reserva_BLL = new BLL.Reserva();
        BE.Usuario usuario_logueado = new BE.Usuario();

        public AdministrarReserva(BE.Usuario usu)
        {
            InitializeComponent();

            this.usuario_logueado = usu;
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva(this.usuario_logueado);
            reserva.Show();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarReserva mod_reserva = new ModificarReserva(dataGridView1.CurrentRow, this.usuario_logueado);
            mod_reserva.Show();
        }

        private void AdministrarReserva_Load(object sender, EventArgs e)
        {
            btn_alta.Enabled = BLL.ConfigUsuario.ValidarAcceso("Alta Reserva");
            btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Reserva");
            btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Reserva");
            btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Reserva");

            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reserva_BLL.SelectAll();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
