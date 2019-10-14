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
    }
}
