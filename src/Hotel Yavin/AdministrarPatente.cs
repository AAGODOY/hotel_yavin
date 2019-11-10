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
    public partial class AdministrarPatente : Form
    {
        BE.Usuario usuario_logueado = new BE.Usuario();
        BE.Patente pat_BE = new BE.Patente();
        BLL.Patente pat_BLL = new BLL.Patente();
        BLL.Bitacora.MEDIA bitacora_MEDIA = new BLL.Bitacora.MEDIA();

        public AdministrarPatente()
        {
            InitializeComponent();
        }

        public AdministrarPatente(BE.Usuario usu_logueado)
        {
            InitializeComponent();

            this.usuario_logueado = usu_logueado;
        }

        private void Patente_Load(object sender, EventArgs e)
        {
            btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Patente");
            btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Patente");
            btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Patente");
            ActualizarGrilla();
        }

        private void ConfigurarGrilla()
        {
            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("descripcion", "Descripcion");
            dataGridView1.Columns.Add("activo", "Activo");
        }

        public void ActualizarGrilla()
        {
            dataGridView1.Rows.Clear();

            foreach (BE.Patente row in pat_BLL.SelectAll())
            {
                dataGridView1.Rows.Add(row.id, UTILITIES.Encriptador.Desencriptar(row.descripcion), row.activo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow activo = dataGridView1.Rows[1];

            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.SelectedRows.Contains(activo) == true)
                {
                    ModificarPatente modif_patente = new ModificarPatente(dataGridView1.CurrentRow, this.usuario_logueado);
                    modif_patente.Show();
                }
                else
                {
                    MessageBox.Show("No se puede modificar una Patente Inhabilitada");
                }
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un registro a modificar");
            }
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {              
                BE.Patente patAinhabilitar = new BE.Patente();
                patAinhabilitar.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                pat_BLL.Delete(patAinhabilitar);
                MessageBox.Show("Se inhabilitó el registro seleccionado");
                this.ActualizarGrilla();
                bitacora_MEDIA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se inhabilitó una Patente");
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
                BE.Patente patAhabilitar = new BE.Patente();
                patAhabilitar.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                pat_BLL.Habilitar(patAhabilitar);
                MessageBox.Show("Se habilitó el registro seleccionado");
                this.ActualizarGrilla();
                bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se habilitó una Patente");
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un registro a habilitar");
            }
        }
    }
}
