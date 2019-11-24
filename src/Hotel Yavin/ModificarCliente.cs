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
    public partial class ModificarCliente : Form
    {
        DataGridViewRow cliente_seleccionado = new DataGridViewRow();
        BE.Cliente cliente_BE = new BE.Cliente();
        BLL.Cliente cliente_BLL = new BLL.Cliente();

        public ModificarCliente()
        {
            InitializeComponent();
        }

        public ModificarCliente(DataGridViewRow clienteSeleccionado)
        {
            InitializeComponent();

            this.cliente_seleccionado = clienteSeleccionado;
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            this.RetornarDatos();
        }

        private void RetornarDatos()
        {
            //Cargar datos
            txt_NombreCli.Text = cliente_seleccionado.Cells[3].Value.ToString();
            txt_ApellidoCli.Text = cliente_seleccionado.Cells[4].Value.ToString();
            txt_NumDocCli.Text = cliente_seleccionado.Cells[5].Value.ToString();
            txt_TelCli.Text = cliente_seleccionado.Cells[6].Value.ToString();
            txt_MailCli.Text = cliente_seleccionado.Cells[7].Value.ToString();
        }

        private void btn_GuardarCliente_Click(object sender, EventArgs e)
        {
            if (txt_NombreCli.Text != "" && txt_ApellidoCli.Text != "" && txt_NumDocCli.Text != "" && txt_TelCli.Text != "" && txt_MailCli.Text != "")
            {
                cliente_BE.id_cliente = (int)cliente_seleccionado.Cells[0].Value;
                cliente_BE.activo = Convert.ToBoolean(cliente_seleccionado.Cells[1].Value);
                cliente_BE.DVH = Convert.ToInt32(cliente_seleccionado.Cells[2].Value);
                cliente_BE.nombre = txt_NombreCli.Text;
                cliente_BE.apellido = txt_ApellidoCli.Text;
                cliente_BE.documento = Convert.ToInt32(txt_NumDocCli.Text);
                cliente_BE.telefono = txt_TelCli.Text;
                cliente_BE.email = txt_MailCli.Text;

                cliente_BLL.Update(cliente_BE);
                MessageBox.Show("Se modifico el usuario seleccionado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }


        }

        private void btn_CancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_NumDocCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida que se ingresen unicamente valores numericos
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;

            //no te permite ingresar mas del máximo
            txt_NumDocCli.MaxLength = 8;
        }
    }
}
