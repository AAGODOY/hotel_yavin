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
    public partial class AdministrarCobranza : Form
    {
        BLL.Cobranza cobranza_BLL = new BLL.Cobranza();

        public AdministrarCobranza()
        {
            InitializeComponent();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                AdministrarPago admPago = new AdministrarPago(dataGridView1.CurrentRow);
                admPago.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void AdministrarCobranza_Load(object sender, EventArgs e)
        {
            btn_ver.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Pago");
            this.ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cobranza_BLL.SelectAll();
        }
    }
}
