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
           dgv_familias.DataSource = familia_BLL.SelectAll();
        }
    }
}
