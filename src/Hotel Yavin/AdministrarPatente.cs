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
    public partial class AdministrarPatente : Form
    {
        BE.Patente pat_BE = new BE.Patente();
        BLL.Patente pat_BLL = new BLL.Patente();

        public AdministrarPatente()
        {
            InitializeComponent();
        }

        private void Patente_Load(object sender, EventArgs e)
        {
            btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Patente");
            btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Patente");
            btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Patente");
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pat_BLL.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                ModificarPatente modif_patente = new ModificarPatente(dataGridView1.CurrentRow);
                modif_patente.Show();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un registro a modificar");
            }
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {              
                BE.Patente patAinhabilitar = new BE.Patente();
                patAinhabilitar.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                pat_BLL.Delete(patAinhabilitar);
                MessageBox.Show("Se inhabilitó el registro seleccionado");
                this.ActualizarGrilla();
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
                BE.Patente patAhabilitar = new BE.Patente();
                patAhabilitar.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                pat_BLL.Habilitar(patAhabilitar);
                MessageBox.Show("Se habilitó el registro seleccionado");
                this.ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un registro a habilitar");
            }
        }
    }
}
