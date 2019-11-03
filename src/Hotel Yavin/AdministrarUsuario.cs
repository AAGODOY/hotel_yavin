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
        BLL.UsuarioPatente usuPat_BLL = new BLL.UsuarioPatente();

        private void AdministrarUsuario_Load(object sender, EventArgs e)
        {
            //btn_alta.Enabled = BLL.ConfigUsuario.ValidarAcceso("Alta Usuario");
            //btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Usuario");
            //btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Usuario");
            //btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Usuario");
            ActualizarGrilla();
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
                ModificarUsuario usuario = new ModificarUsuario(dataGridView1.CurrentRow);
                usuario.Show();
                //usuario.RetornarDatos(dataGridView1.CurrentRow);
            }
            else
            {
                MessageBox.Show("No se debe seleccionar un registro a modificar");
            }           
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            this.ActualizarGrilla();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id_usuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                List<BE.Patente> patentes_usuario = usuPat_BLL.GetPatentesUsuario(id_usuario);

                if (BLL.Services.VerificarUsoPatente(id_usuario, patentes_usuario) != 0)
                {
                    BE.Usuario usuAinhabilitar = new BE.Usuario();
                    usuAinhabilitar.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    usu_BLL.Delete(usuAinhabilitar);
                    MessageBox.Show("Se inhabilitó el usuario seleccionado");
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("La operación no se puede realizar ya que viola la regla de verificación de uso de patente");
                }
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un registro a inhabilitar");
            }
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                BE.Usuario usuHabilitar = new BE.Usuario();
                usuHabilitar.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                usu_BLL.Habilitar(usuHabilitar);
                MessageBox.Show("Se habilitó el usuario seleccionado");
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("No se debe seleccionar un registro a habilitar");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
