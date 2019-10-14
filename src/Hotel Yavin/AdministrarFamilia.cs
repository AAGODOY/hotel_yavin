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
        public AdministrarFamilia()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Familia familia = new Familia();
            familia.Show();
        }
    }
}
