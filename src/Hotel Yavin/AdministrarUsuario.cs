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
    public partial class AdministrarUsuario : Form
    {
        public AdministrarUsuario()
        {
            InitializeComponent();
        }

        BE.Usuario usu_BE = new BE.Usuario();
        BLL.Usuario usu_BLL = new BLL.Usuario();

        private void AdministrarUsuario_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btn_GuardarPatente_Click(object sender, EventArgs e)
        {

        }

        private void btn_CancelarPatente_Click(object sender, EventArgs e)
        {

        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            AltaUsuario alta_usu = new AltaUsuario();
            alta_usu.Show();
        }

        public void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usu_BLL.SelectAll();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                ModificarUsuario usuario = new ModificarUsuario();
                usuario.Show();
                //usu_BE = dataGridView1.SelectedRows;
                usuario.RetornarDatos(dataGridView1.CurrentRow);

            }
            else
            {
                MessageBox.Show("No se seleccionó ningun registro a modificar");
            }
            
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            this.ActualizarGrilla();
        }
    }
}
