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
           dgv_familias.DataSource = familia_BLL.SelectAll();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }
    }
}
