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
    }
}
