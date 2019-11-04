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
    public partial class AdministrarFamilia : Form
    {
        BLL.Familia familia_BLL = new BLL.Familia();

        public AdministrarFamilia()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Familia familia = new Familia();
            familia.Show();
        }

        private void AdministrarFamilia_Load(object sender, EventArgs e)
        {
           btn_alta.Enabled = BLL.ConfigUsuario.ValidarAcceso("Alta Familia");
           btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Familia");
           btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Familia");
           btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Familia");

           ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dgv_familias.DataSource = null;
            dgv_familias.DataSource = familia_BLL.SelectAll();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_familias.SelectedRows.Count == 1)
            {
                ModificarFamilia familia = new ModificarFamilia(dgv_familias.CurrentRow);
                familia.Show();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un registro a modificar");
            } 
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            if (dgv_familias.SelectedRows.Count == 1)
            {
                BE.Familia famAinhabilitar = new BE.Familia();
                famAinhabilitar.id = Convert.ToInt32(dgv_familias.CurrentRow.Cells[0].Value);
                familia_BLL.Delete(famAinhabilitar);
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
            if (dgv_familias.SelectedRows.Count == 1)
            {
                BE.Familia famAhabilitar = new BE.Familia();
                famAhabilitar.id = Convert.ToInt32(dgv_familias.CurrentRow.Cells[0].Value);
                familia_BLL.Habilitar(famAhabilitar);
                MessageBox.Show("Se habilitó el registro seleccionado");
                this.ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un registro a inhabilitar");
            }
        }
    }
}
