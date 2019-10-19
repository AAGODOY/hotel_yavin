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
        public AdministrarReserva()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            reserva.Show();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarReserva mod_reserva = new ModificarReserva();
            mod_reserva.Show();
        }

        private void AdministrarReserva_Load(object sender, EventArgs e)
        {
            btn_alta.Enabled = BLL.ConfigUsuario.ValidarAcceso("Alta Reserva");
            btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Reserva");
            btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Reserva");
            btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Reserva");
        }
    }
}
