using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hotel_Yavin
{
    public partial class Generar_Copia_de_Seguridad : Form
    {
        BE.Usuario usuario_logueado = new BE.Usuario();
        BLL.Bitacora.BAJA bitacora_BAJA = new BLL.Bitacora.BAJA();

        public Generar_Copia_de_Seguridad()
        {
            InitializeComponent();
        }

        public Generar_Copia_de_Seguridad(BE.Usuario usu_logueado)
        {
            InitializeComponent();

            this.usuario_logueado = usu_logueado;
        }

        private void Generar_Copia_de_Seguridad_Load(object sender, EventArgs e)
        {
            btn_examinar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Examinar");
            btn_generar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Generar Back-Up");
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openExplorer = new FolderBrowserDialog();
            openExplorer.ShowDialog();
            this.txt_ubicacion.Text = openExplorer.SelectedPath;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            BLL.Backup backup_BLL = new BLL.Backup();
            string fecha = DateTime.Now.ToShortDateString().Replace('/','-');

            if (this.txt_ubicacion.Text != "" && this.txt_nombreBackup.Text != "")
            {
                string fileNamefinal = this.txt_nombreBackup.Text + "-" + fecha;
                string pathFinal = this.txt_ubicacion.Text + "\\" + fileNamefinal;
                int cantidad_particiones = (int)this.nud_particiones.Value;
                if (backup_BLL.GenerarBackup(pathFinal, cantidad_particiones) == -1)
                {
                    BE.Backup backupGenerado = new BE.Backup();
                    backupGenerado.descripcion = fileNamefinal;
                    backupGenerado.ruta = this.txt_ubicacion.Text;
                    backupGenerado.nro_particiones = (int)this.nud_particiones.Value;

                    if (backup_BLL.AddBackup(backupGenerado) != -1)
                    {
                        MessageBox.Show("Se realizó el backup correctamente");
                        bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se creó una Copia de Seguridad");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al generar registro de backup en DB");
                    }
                }
                else
                {
                    MessageBox.Show("Error al generar backup. Vuelva a intentar más tarde");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para continuar");
            }
        }
    }
}
