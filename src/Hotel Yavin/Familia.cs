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
    public partial class Familia : Form
    {
        BLL.Usuario usu_BLL = new BLL.Usuario();
        BLL.Patente pat_BLL = new BLL.Patente();

        public Familia()
        {
            InitializeComponent();
        }

        private void tab_PatenteFamilia_Click(object sender, EventArgs e)
        {

        }

        private void Familia_Load(object sender, EventArgs e)
        {
            dgv_patentesDisponibles.DataSource = pat_BLL.SelectAll();
            dgv_UsuariosDisponibles.DataSource = usu_BLL.SelectAll();

        }
    }
}
