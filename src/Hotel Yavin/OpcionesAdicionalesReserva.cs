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
    public partial class OpcionesAdicionalesReserva : Form
    {
        DataGridViewRow reserva_seleccionada = new DataGridViewRow();
        BLL.Reserva reserva_BLL = new BLL.Reserva();
        BE.Reserva reserva_BE = new BE.Reserva();

        public OpcionesAdicionalesReserva(DataGridViewRow reserva)
        {
            InitializeComponent();

            this.reserva_seleccionada = reserva;
        }

        private void OpcionesAdicionalesReserva_Load(object sender, EventArgs e)
        {
            txt_id.Text = reserva_seleccionada.Cells[0].Value.ToString();
            reserva_BE.id_reserva = (int)reserva_seleccionada.Cells[0].Value;
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            if (reserva_seleccionada.Cells[6].Value.ToString() != "EN CURSO" && reserva_seleccionada.Cells[6].Value.ToString() != "CANCELADA")
	        {
		        reserva_BLL.Delete(reserva_BE);
                MessageBox.Show("Se canceló la reserva");
                this.Close();
	        }
            else
	        {
                MessageBox.Show("No se puede realizar la acción debido al estado de la reserva");
	        }
        }
    }
}
