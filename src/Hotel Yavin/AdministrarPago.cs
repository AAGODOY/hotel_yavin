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
    public partial class AdministrarPago : Form
    {
        DataGridViewRow cobranza_seleccionada = new DataGridViewRow();
        BLL.Pago pago_BLL = new BLL.Pago();
        BE.Pago pago_BE = new BE.Pago();
        double pagado = 0;
        double totalApagar = 0;
        

        public AdministrarPago(DataGridViewRow cobranza)
        {
            InitializeComponent();

            this.cobranza_seleccionada = cobranza;
        }

        private void AdministrarPago_Load(object sender, EventArgs e)
        {
            btn_alta.Enabled = BLL.ConfigUsuario.ValidarAcceso("Alta Pago");
            btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Pago");
            btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Pago");

            this.ActualizarGrilla();
            this.TotalPagado();
            this.TotalApagar();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            AltaPago altaPago = new AltaPago(cobranza_seleccionada, this.totalApagar, (int)cobranza_seleccionada.Cells[1].Value);
            altaPago.Show();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                ModificarPago modPago = new ModificarPago(dataGridView1.CurrentRow, this.totalApagar, (int)cobranza_seleccionada.Cells[1].Value);
                modPago.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro a modificar");
            }
        }

        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pago_BLL.GetPagosCobranza((int)cobranza_seleccionada.Cells[0].Value);
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                pago_BE.id_cobro = (int)cobranza_seleccionada.Cells[0].Value;
                pago_BE.id_pago = (int)dataGridView1.CurrentRow.Cells[0].Value;
                pago_BLL.Delete(pago_BE);
                MessageBox.Show("Se eliminó el registro seleccionado");
                this.ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro a eliminar");
            }
        }

        private void TotalPagado()
        {
            foreach (DataGridViewRow pago in dataGridView1.Rows)
            {
                pagado += Convert.ToDouble(pago.Cells[3].Value);
            }

            lbl_totalPagado.Text = "$" + pagado.ToString();
        }

        private void TotalApagar()
        {
           totalApagar = Convert.ToDouble(this.cobranza_seleccionada.Cells[4].Value) - pagado;
           lbl_totalAPagar.Text = "$" + totalApagar;
        }
    }
}
