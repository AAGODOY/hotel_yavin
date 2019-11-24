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
    public partial class ModificarPago : Form
    {
        DataGridViewRow pago_seleccionado = new DataGridViewRow();
        double totalApagar = 0;
        double totalSinRegSeleccionado = 0;
        BE.Pago pago_BE = new BE.Pago();
        BLL.Pago pago_BLL = new BLL.Pago();
        BLL.Cobranza cobranza_BLL = new BLL.Cobranza();
        int idReserva;

        public ModificarPago(DataGridViewRow pago, double totApagar, int id_reserva)
        {
            InitializeComponent();
            this.pago_seleccionado = pago;
            this.totalApagar = totApagar;
            this.CargarDatos();
            this.totalSinRegSeleccionado = Convert.ToDouble(txt_montoPagado.Text) + this.totalApagar;
            this.idReserva = id_reserva;
        }

        private void btn_GuardarCliente_Click(object sender, EventArgs e)
        {
            if (ValidarMonto())
            {
                pago_BE.id_pago = (int)this.pago_seleccionado.Cells[0].Value;
                pago_BE.id_cobro = (int)this.pago_seleccionado.Cells[1].Value;
                pago_BE.fecha_pago = Convert.ToDateTime(dtp_fechaPago.Value.Date);
                pago_BE.monto_pagado = Convert.ToDouble(txt_montoPagado.Text);

                pago_BLL.Update(pago_BE);
                MessageBox.Show("Se modificó el nuevo seleccionado");

                if (totalSinRegSeleccionado == pago_BE.monto_pagado)
                {
                    cobranza_BLL.SetPagado(idReserva);
                }

                this.Close();
            }
        }

        private bool ValidarMonto()
        {
            if (Convert.ToDouble(txt_montoPagado.Text) <= totalApagar)
            {
                return true;
            }
            else
            {
                if (totalSinRegSeleccionado >= Convert.ToDouble(txt_montoPagado.Text))
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

        private void btn_CancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos()
        {
            dtp_fechaPago.Text = this.pago_seleccionado.Cells[2].Value.ToString();
            txt_montoPagado.Text = this.pago_seleccionado.Cells[3].Value.ToString();
        }
    }
}
