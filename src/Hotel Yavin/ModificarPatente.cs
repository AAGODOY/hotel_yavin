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
    public partial class ModificarPatente : Form
    {
        BE.Usuario usuario_logueado = new BE.Usuario();
        DataGridViewRow patente_seleccionada = new DataGridViewRow();
        BE.Patente pat_BE = new BE.Patente();
        BLL.Patente pat_BLL = new BLL.Patente();
        BLL.Bitacora.MEDIA bitacora_MEDIA = new BLL.Bitacora.MEDIA();

        public ModificarPatente()
        {
            InitializeComponent();
        }

        public ModificarPatente(DataGridViewRow patente, BE.Usuario usu_logueado)
        {
            InitializeComponent();
            patente_seleccionada = patente;
            this.usuario_logueado = usu_logueado;
        }

        private void btn_CancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GuardarUsuario_Click(object sender, EventArgs e)
        {
            if (txt_descripcion.Text != "")
            {
                pat_BE.id = (int)patente_seleccionada.Cells[0].Value;
                pat_BE.descripcion = txt_descripcion.Text;

                pat_BLL.Update(pat_BE);
                bitacora_MEDIA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se modificó una patente");
                MessageBox.Show("Modificación realizada con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe completar el campo 'Decripción'");
            }
        }

        private void ModificarPatente_Load(object sender, EventArgs e)
        {
            txt_descripcion.Text = patente_seleccionada.Cells[1].Value.ToString();
        }
    }
}
