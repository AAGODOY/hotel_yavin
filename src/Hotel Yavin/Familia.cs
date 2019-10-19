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
            dgv_UsuariosDisponibles.DataSource = null;
            dgv_UsuariosDisponibles.DataSource = usu_BLL.SelectAll();
            dgv_UsuariosDisponibles.Columns[0].Visible = false;
            //dgv_UsuariosDisponibles.Columns[1].Visible = false;
            dgv_UsuariosDisponibles.Columns[5].Visible = false;
            dgv_UsuariosDisponibles.Columns[6].Visible = false;
            dgv_UsuariosDisponibles.Columns[7].Visible = false;
            dgv_UsuariosDisponibles.Columns[8].Visible = false;
            dgv_UsuariosDisponibles.Columns[9].Visible = false;
            dgv_UsuariosDisponibles.Columns[10].Visible = false;
            dgv_UsuariosDisponibles.Columns[11].Visible = false;
            dgv_UsuariosDisponibles.Columns[12].Visible = false;
            dgv_UsuariosDisponibles.Columns[13].Visible = false;
            dgv_UsuariosDisponibles.Columns[14].Visible = false;
            dgv_patentesDisponibles.DataSource = null;
            dgv_patentesDisponibles.DataSource = pat_BLL.SelectAll();
            dgv_patentesDisponibles.Columns[0].Visible = false;

        }
    }
}
