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
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            Btn_Buscar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Buscar Bitácora");
            btn_GenerarReporte.Enabled = BLL.ConfigUsuario.ValidarAcceso("Generar Reporte Bitacora");
        }
    }
}
