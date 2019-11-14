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
    public partial class Cliente : Form
    {
        BE.Cliente cliente_BE = new BE.Cliente();
        BLL.Cliente cliente_BLL = new BLL.Cliente();

        public Cliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_MailCli_Click(object sender, EventArgs e)
        {

        }

        private void btn_GuardarCliente_Click(object sender, EventArgs e)
        {
            if (txt_NombreCli.Text != "" && txt_ApellidoCli.Text != "" && txt_NumDocCli.Text != "" && txt_TelCli.Text != "" && txt_MailCli.Text != "")
            {
                cliente_BE.nombre = txt_NombreCli.Text;
                cliente_BE.apellido = txt_ApellidoCli.Text;
                cliente_BE.documento = int.Parse(txt_NumDocCli.Text);
                cliente_BE.telefono = txt_TelCli.Text;
                cliente_BE.email = txt_MailCli.Text;

                cliente_BLL.Add(cliente_BE);
                MessageBox.Show("Se creo un nuevo usuario");
            }

        }
    }
}
