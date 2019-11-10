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
        BE.Usuario usuario_logueado = new BE.Usuario();
        BLL.Familia familia_BLL = new BLL.Familia();
        BLL.FamiliaPatente famPat_BLL = new BLL.FamiliaPatente();
        BLL.Bitacora.BAJA bitacora_BAJA = new BLL.Bitacora.BAJA();

        public AdministrarFamilia()
        {
            InitializeComponent();
        }

        public AdministrarFamilia(BE.Usuario usu_logueado)
        {
            InitializeComponent();
            this.usuario_logueado = usu_logueado;
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Familia familia = new Familia(this.usuario_logueado);
            familia.Show();
        }

        private void AdministrarFamilia_Load(object sender, EventArgs e)
        {
           btn_alta.Enabled = BLL.ConfigUsuario.ValidarAcceso("Alta Familia");
           btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Familia");
           btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Familia");
           btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Familia");

           this.ConfigurarGrilla();
           this.ActualizarGrilla();
        }

        private void ConfigurarGrilla()
        {
            dgv_familias.Columns.Add("id","Id");
            dgv_familias.Columns.Add("descripcion", "Descripcion");
            dgv_familias.Columns.Add("activo", "Activo");
        }

        public void ActualizarGrilla()
        {
            dgv_familias.Rows.Clear();

            foreach (BE.Familia row in familia_BLL.SelectAll())
            {
                dgv_familias.Rows.Add(row.id, UTILITIES.Encriptador.Desencriptar(row.descripcion), row.activo);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow activo = dgv_familias.Rows[1];

            if (dgv_familias.SelectedRows.Count == 1)
            {
                if (dgv_familias.SelectedRows.Contains(activo) == true)
                {
                    ModificarFamilia familia = new ModificarFamilia(dgv_familias.CurrentRow, this.usuario_logueado);
                    familia.Show();
                }
                else
                {
                    MessageBox.Show("No se puede modificar una Familia Inhabilitada");
                }

            }
            else
            {
                MessageBox.Show("Se debe seleccionar un registro a modificar");
            } 
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            if (dgv_familias.SelectedRows.Count == 1)
            {
                int id_familia = Convert.ToInt32(dgv_familias.CurrentRow.Cells[0].Value);
                List<BE.Patente> patentes_familia = famPat_BLL.GetPatentesFamilia(id_familia);

                if (BLL.Services.VerificarUsoPatente(0, patentes_familia, id_familia) != 0)
                {
                    BE.Familia famAinhabilitar = new BE.Familia();
                    famAinhabilitar.id = Convert.ToInt32(dgv_familias.CurrentRow.Cells[0].Value);
                    familia_BLL.Delete(famAinhabilitar);
                    MessageBox.Show("Se inhabilitó el registro seleccionado");
                    this.ActualizarGrilla();
                    bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se inhabilitó una Familia");
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
            if (dgv_familias.SelectedRows.Count == 1)
            {
                BE.Familia famAhabilitar = new BE.Familia();
                famAhabilitar.id = Convert.ToInt32(dgv_familias.CurrentRow.Cells[0].Value);
                familia_BLL.Habilitar(famAhabilitar);
                MessageBox.Show("Se habilitó el registro seleccionado");
                this.ActualizarGrilla();
                bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se habilitó una Familia");
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un registro a inhabilitar");
            }
        }
    }
}
