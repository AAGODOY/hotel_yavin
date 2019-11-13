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
    public partial class ModificarIdioma : Form
    {
        BE.Usuario usuario_logueado = new BE.Usuario();
        BE.Idioma idioma_BE = new BE.Idioma();
        BLL.Idioma idioma_BLL = new BLL.Idioma();

        public ModificarIdioma()
        {
            InitializeComponent();
        }

        public ModificarIdioma(BE.Usuario usu_logueado)
        {
            InitializeComponent();

            this.usuario_logueado = usu_logueado;
        }

        private void ModificarIdioma_Load(object sender, EventArgs e)
        {
            btn_Aceptar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Idioma");

            cmb_SeleccionIdioma.DataSource = null;
            List<BE.Idioma> idiomas = idioma_BLL.SelectAll();
            foreach (BE.Idioma idioma in idiomas)
            {
                cmb_SeleccionIdioma.Items.Add(idioma.descripcion);
            }

            cmb_SeleccionIdioma.SelectedIndex = 0;
        }

        private void cmb_SeleccionIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (cmb_SeleccionIdioma.Text == "ES")
            {
                idioma_BE.id_idioma = 1;
                idioma_BLL.UpdateIdioma(idioma_BE.id_idioma, usuario_logueado);
            }
            else
            {
                idioma_BE.id_idioma = 2;
                idioma_BLL.UpdateIdioma(idioma_BE.id_idioma, usuario_logueado);
            }

            MessageBox.Show("Se modificó el idioma de la aplicación. Iniciar sesion nuevamente para que se actualicen los cambios");
            this.Close();
        }
    }
}
