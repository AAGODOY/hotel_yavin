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
        BLL.Cliente cliente_BLL = new BLL.Cliente();

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
            DataGridViewRow activo = dataGridView1.Rows[1];

            if (dataGridView1.SelectedRows.Count == 1)
            {
                if ((bool)dataGridView1.CurrentRow.Cells[1].Value)
                {
                    ModificarCliente mod_cliente = new ModificarCliente(dataGridView1.CurrentRow);
                    mod_cliente.Show();
                }
                else
                {
                    MessageBox.Show("No se puede modificar un Cliente Inhabilitado");
                }
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un registro a modificar");
            }
        }

        private void AdministrarCliente_Load(object sender, EventArgs e)
        {
            //btn_alta.Enabled = BLL.ConfigUsuario.ValidarAcceso("Alta Cliente");
            //btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Cliente");
            //btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Cliente");
            //btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Cliente");

            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cliente_BLL.SelectAll();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                BE.Cliente clienteAinhabilitar = new BE.Cliente();
                clienteAinhabilitar.id_cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                cliente_BLL.Delete(clienteAinhabilitar);
                ActualizarGrilla();
                MessageBox.Show("Se inhabilitó el cliente seleccionado");
                //bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se inhabilitó un Usuario");
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un registro a inhabilitar");
            }
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                BE.Cliente clienteHabilitar = new BE.Cliente();
                clienteHabilitar.id_cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                cliente_BLL.Habilitar(clienteHabilitar);
                ActualizarGrilla();
                MessageBox.Show("Se habilitó el cliente seleccionado");
                //bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se habilitó un Usuario");
            }
            else
            {
                MessageBox.Show("No se debe seleccionar un registro a habilitar");
            }
        }
    }
}

