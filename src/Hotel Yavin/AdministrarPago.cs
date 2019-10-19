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
        public AdministrarPago()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {

        }

        private void AdministrarPago_Load(object sender, EventArgs e)
        {
            btn_alta.Enabled = BLL.ConfigUsuario.ValidarAcceso("Alta Pago");
            btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Pago");
            btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Pago");
            btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Pago");
        }
    }
}
