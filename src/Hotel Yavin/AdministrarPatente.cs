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
        public AdministrarPatente()
        {
            InitializeComponent();
        }

        BE.Patente pat_BE = new BE.Patente();
        BLL.Patente pat_BLL = new BLL.Patente();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void btn_CancelarPatente_Click(object sender, EventArgs e)
        {

        }

        private void btn_GuardarPatente_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DescPatente_Click(object sender, EventArgs e)
        {

        }

        private void lbl_PatenDisponibles_Click(object sender, EventArgs e)
        {

        }

        private void ckl_Patentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarPatente modif_patente = new ModificarPatente();
            modif_patente.Show();
        }
    }
}
