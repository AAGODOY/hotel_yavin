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
        BE.Usuario usuario_logueado = new BE.Usuario();
        BE.Usuario usu_BE = new BE.Usuario();
        BLL.Usuario usu_BLL = new BLL.Usuario();
        BLL.UsuarioPatente usuPat_BLL = new BLL.UsuarioPatente();
        BLL.Bitacora.BAJA bitacora_BAJA = new BLL.Bitacora.BAJA();

        public AdministrarUsuario()
        {
            InitializeComponent();
        }

        public AdministrarUsuario(BE.Usuario usu_logueado)
        {
            InitializeComponent();
            this.usuario_logueado = usu_logueado;
        }

        private void AdministrarUsuario_Load(object sender, EventArgs e)
        {
            btn_alta.Enabled = BLL.ConfigUsuario.ValidarAcceso("Alta Usuario");
            btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Usuario");
            btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Usuario");
            btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Usuario");

            this.CongigurarGrilla();
            this.ActualizarGrilla();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            AltaUsuario alta_usu = new AltaUsuario(this.usuario_logueado);
            alta_usu.Show();
        }

        public void CongigurarGrilla()
        {
            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("activo", "Activo");
            dataGridView1.Columns.Add("nom_usuario", "Nombre Usuario");
            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("apellido", "Apellido");
            dataGridView1.Columns.Add("documento", "Documento");
            dataGridView1.Columns.Add("domicilio", "Domicilio");
            dataGridView1.Columns.Add("telefono", "Telefono");
            dataGridView1.Columns.Add("email", "Email");
            dataGridView1.Columns.Add("contraseña", "Contraseña");
            dataGridView1.Columns.Add("cant_ingresos_incorrectos", "Ingresos incorrectos");
            dataGridView1.Columns.Add("DVH", "DVH");
            dataGridView1.Columns.Add("es_primer_login", "Primer Login");
            dataGridView1.Columns.Add("id_idioma", "Id_idioma");

            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }

        public void ActualizarGrilla()
        {
            dataGridView1.Rows.Clear();

            foreach (BE.Usuario row in usu_BLL.SelectAll())
            {
                dataGridView1.Rows.Add(row.id, row.activo, UTILITIES.Encriptador.Desencriptar(row.nom_usuario), row.nombre, row.apellido, row.documento, row.domicilio, row.telefono, row.email, row.contraseña, row.cant_ingresos_incorrectos, row.DVH, row.es_primer_login, row.id_idioma);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow activo = dataGridView1.Rows[1];

            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.SelectedRows.Contains(activo) == true)
                {
                    ModificarUsuario usuario = new ModificarUsuario(dataGridView1.CurrentRow, this.usuario_logueado);
                    usuario.Show();
                }
                else
                {
                    MessageBox.Show("No se puede modificar un Usuario Inhabilitado");
                }
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un registro a modificar");
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

                if (BLL.Services.VerificarUsoPatente(id_usuario, patentes_usuario, 0) != 0)
                {
                    BE.Usuario usuAinhabilitar = new BE.Usuario();
                    usuAinhabilitar.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    usu_BLL.Delete(usuAinhabilitar);
                    ActualizarGrilla();
                    MessageBox.Show("Se inhabilitó el usuario seleccionado");
                    bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se inhabilitó un Usuario");
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
                bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se habilitó un Usuario");
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
