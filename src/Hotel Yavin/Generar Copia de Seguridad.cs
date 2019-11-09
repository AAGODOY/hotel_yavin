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
        FolderBrowserDialog openExplorer = new FolderBrowserDialog();

        public Generar_Copia_de_Seguridad()
        {
            InitializeComponent();
        }

        private void Generar_Copia_de_Seguridad_Load(object sender, EventArgs e)
        {
            btn_examinar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Examinar");
            btn_generar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Generar Back-Up");
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            openExplorer.ShowDialog();
            this.txt_ubicacion.Text = openExplorer.SelectedPath;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {


        }
    }
}
