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
    }
}
