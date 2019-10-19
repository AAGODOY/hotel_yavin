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
    public partial class AdministrarCliente : Form
    {
        public AdministrarCliente()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarCliente mod_cliente = new ModificarCliente();
            mod_cliente.Show();
        }

        private void AdministrarCliente_Load(object sender, EventArgs e)
        {
            btn_alta.Enabled = BLL.ConfigUsuario.ValidarAcceso("Alta Cliente");
            btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Cliente");
            btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Cliente");
            btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Cliente");
        }
    }
}
