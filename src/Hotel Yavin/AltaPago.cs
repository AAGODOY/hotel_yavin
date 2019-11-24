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
    public partial class AltaPago : Form
    {
        BE.Pago pago_BE = new BE.Pago();
        BLL.Pago pago_BLL = new BLL.Pago();
        BLL.Cobranza cobranza_BLL = new BLL.Cobranza();
        DataGridViewRow cobranza_seleccionada = new DataGridViewRow();
        double totalApagar = 0;
        int idReserva;

        public AltaPago(DataGridViewRow cobranza, double totApagar, int id_reserva)
        {
            InitializeComponent();

            this.cobranza_seleccionada = cobranza;
            this.totalApagar = totApagar;
            this.idReserva = id_reserva;
        }

        private void btn_GuardarCliente_Click(object sender, EventArgs e)
        {
            if (ValidarMonto())
            {
                pago_BE.id_cobro = (int)this.cobranza_seleccionada.Cells[0].Value;
                pago_BE.fecha_pago = Convert.ToDateTime(dtp_fechaPago.Value.Date);
                pago_BE.monto_pagado = Convert.ToDouble(txt_montoPagado.Text);

                pago_BLL.Add(pago_BE);
                MessageBox.Show("Se creó un nuevo pago");

                if (totalApagar == pago_BE.monto_pagado)
                {
                    cobranza_BLL.SetPagado(idReserva);
                }

                this.Close();
            }
        }

        private void btn_CancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarMonto()
        {
            if (Convert.ToDouble(txt_montoPagado.Text) <= totalApagar)
            {
                return true;
            }
            else
            {
                MessageBox.Show("El monto a pagar debe ser menor a: $" + totalApagar);
                return false;
            }
        }
    }
}
