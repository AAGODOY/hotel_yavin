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
    public partial class Restaurar_copia_de_seguridad : Form
    {
        BE.Usuario usuario_logueado = new BE.Usuario();
        BLL.Backup backup_BLL = new BLL.Backup();
        BLL.RestaurarBackup restaurarBackup_BLL = new BLL.RestaurarBackup();
        BLL.Bitacora.ALTA bitacora_ALTA = new BLL.Bitacora.ALTA();

        public Restaurar_copia_de_seguridad()
        {
            InitializeComponent();
        }

        public Restaurar_copia_de_seguridad(BE.Usuario usu_logueado)
        {
            InitializeComponent();

            this.usuario_logueado = usu_logueado;
        }

        private void Restaurar_copia_de_seguridad_Load(object sender, EventArgs e)
        {
            btn_restaurar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Restaurar Back-Up");
            this.cargarListaBackups();
        }

        private void cargarListaBackups()
        {
            this.dgv_listadoBackups.DataSource = null;
            this.dgv_listadoBackups.DataSource = backup_BLL.SelectAll();
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            BE.Backup backupSeleccionado = new BE.Backup();
            DataGridViewRow filaSelected = this.dgv_listadoBackups.SelectedRows[0];
            backupSeleccionado.id_Backup = (int)filaSelected.Cells[0].Value;
            backupSeleccionado.descripcion = (string)filaSelected.Cells[1].Value;
            backupSeleccionado.ruta = (string)filaSelected.Cells[2].Value;
            backupSeleccionado.nro_particiones = (int)filaSelected.Cells[3].Value;

            if (restaurarBackup_BLL.RestaurarBackupSeleccionado(backupSeleccionado) == -1)
            {
                MessageBox.Show("Se realizó la restauración correctamente");
                bitacora_ALTA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se generó una Restauración de una Copia de Seguridad");
                this.Close();
            }
            else
            {
                MessageBox.Show("Fallo la restauración de la copia de seguridad. Verifique por favor la existencia de la ruta y/o archivo");
            }
        }
    }
}
