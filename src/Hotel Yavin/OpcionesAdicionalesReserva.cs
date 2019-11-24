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
    public partial class OpcionesAdicionalesReserva : Form
    {
        DataGridViewRow reserva_seleccionada = new DataGridViewRow();
        BLL.Reserva reserva_BLL = new BLL.Reserva();
        BE.Reserva reserva_BE = new BE.Reserva();
        BLL.Cobranza cobranza_BLL = new BLL.Cobranza();
        BE.Cobranza cobranza_BE = new BE.Cobranza();

        public OpcionesAdicionalesReserva(DataGridViewRow reserva)
        {
            InitializeComponent();

            this.reserva_seleccionada = reserva;
        }

        private void OpcionesAdicionalesReserva_Load(object sender, EventArgs e)
        {
            txt_id.Text = reserva_seleccionada.Cells[0].Value.ToString();
            reserva_BE.id_reserva = (int)reserva_seleccionada.Cells[0].Value;
            cobranza_BE.id_reserva = (int)reserva_seleccionada.Cells[0].Value;
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            if (reserva_seleccionada.Cells[6].Value.ToString() != "EN CURSO" && reserva_seleccionada.Cells[6].Value.ToString() != "CANCELADA")
	        {
		        reserva_BLL.Delete(reserva_BE);
                cobranza_BLL.Delete(cobranza_BE);
                MessageBox.Show("Se canceló la reserva");
                this.Close();
	        }
            else
	        {
                MessageBox.Show("No se puede realizar la acción debido al estado de la reserva");
	        }
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            if (reserva_seleccionada.Cells[6].Value.ToString() == "CANCELADA")
            {
                reserva_BLL.Habilitar(reserva_BE);
                cobranza_BLL.Habilitar(cobranza_BE);
                MessageBox.Show("Se habilitó la reserva");
                this.Close();
            }
            else
            {
                MessageBox.Show("Solo se pueden habilitar reservas canceladas");
            }
        }

        private void btn_EnCurso_Click(object sender, EventArgs e)
        {
            if (reserva_seleccionada.Cells[6].Value.ToString() == "PENDIENTE")
            {
                reserva_BLL.SetEnCurso(reserva_BE);
                MessageBox.Show("Se modificó el estado de la reserva a: EN CURSO");
                this.Close();
            }
            else
            {
                MessageBox.Show("Solo pueden estar 'En Curso' las reservas 'Pendientes'");
            }
        }

        private void btn_finalizada_Click(object sender, EventArgs e)
        {
            if (reserva_seleccionada.Cells[6].Value.ToString() == "EN CURSO")
            {
                reserva_BLL.SetFinalizada(reserva_BE);
                MessageBox.Show("Se modificó el estado de la reserva a: FINALIZADA");
                this.Close();
            }
            else
            {
                MessageBox.Show("Solo pueden estar 'Finalizadas' las reservas que se encuentran 'En Curso'");
            }
        }
    }
}
