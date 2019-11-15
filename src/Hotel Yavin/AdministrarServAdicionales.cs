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
    public partial class AdministrarServAdicionales : Form
    {
        BE.ServAdicional servAdicional_BE = new BE.ServAdicional();
        BLL.ServAdicional servAdicional_BLL = new BLL.ServAdicional();

        public AdministrarServAdicionales()
        {
            InitializeComponent();
        }

        private void AdministrarServAdicionales_Load(object sender, EventArgs e)
        {
            btn_alta.Enabled = BLL.ConfigUsuario.ValidarAcceso("Alta Serv. Adicionales");
            btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Serv. Adicionales");
            btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Serv. Adicionales");
            btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Serv. Adicionales");

            this.ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = servAdicional_BLL.SelectAll();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            AltaServAdicionales servicios = new AltaServAdicionales();
            servicios.Show();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarServAdicional mod_ServAdicional = new ModificarServAdicional(dataGridView1.CurrentRow);
            mod_ServAdicional.Show();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            servAdicional_BE.id_servicio = (int)dataGridView1.CurrentRow.Cells[0].Value;
            servAdicional_BLL.Delete(servAdicional_BE);
            MessageBox.Show("Se inhabilitó el servicio seleccionado");
            this.ActualizarGrilla();
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            servAdicional_BE.id_servicio = (int)dataGridView1.CurrentRow.Cells[0].Value;
            servAdicional_BLL.Habilitar(servAdicional_BE);
            MessageBox.Show("Se habilitó el servicio seleccionado");
            this.ActualizarGrilla();
        }
    }
}
