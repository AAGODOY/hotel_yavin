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
        public AdministrarServAdicionales()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            AltaServAdicionales servicios = new AltaServAdicionales();
            servicios.Show();
        }

        private void AdministrarServAdicionales_Load(object sender, EventArgs e)
        {
            btn_alta.Enabled = BLL.ConfigUsuario.ValidarAcceso("Alta Serv. Adicionales");
            btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Serv. Adicionales");
            btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Serv. Adicionales");
            btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Serv. Adicionales");
        }
    }
}
