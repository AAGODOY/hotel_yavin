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
        DataGridViewRow patente_seleccionada = new DataGridViewRow();
        BE.Patente pat_BE = new BE.Patente();
        BLL.Patente pat_BLL = new BLL.Patente();

        public ModificarPatente()
        {
            InitializeComponent();
        }

        public ModificarPatente(DataGridViewRow patente)
        {
            InitializeComponent();
            patente_seleccionada = patente;
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
