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
    public partial class ModificarUsuario : Form
    {
        BE.Usuario usu_BE = new BE.Usuario();
        BLL.Usuario usu_BLL = new BLL.Usuario();

        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void btn_CancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            btn_BlanquearPass.Enabled = BLL.ConfigUsuario.ValidarAcceso("Blanquear Constraseña");
            btn_Bloquear.Enabled = BLL.ConfigUsuario.ValidarAcceso("Bloquear Usuario");
            btn_Desbloquear.Enabled = BLL.ConfigUsuario.ValidarAcceso("Desbloquear Usuario");
        }

        public void RetornarDatos(DataGridViewRow usu)
        {
            txt_NomUsu.Text = usu.Cells[2].Value.ToString();
            txt_Nombre.Text = usu.Cells[3].Value.ToString();
            txt_Apellido.Text = usu.Cells[4].Value.ToString();
            txt_NumDoc.Text = usu.Cells[5].Value.ToString();
            txt_Domicilio.Text = usu.Cells[6].Value.ToString();
            txt_Telefono.Text = usu.Cells[7].Value.ToString();
            txt_Email.Text = usu.Cells[8].Value.ToString();
            comboBox1.Text = usu.Cells[9].Value.ToString();   
        }

        private void btn_GuardarUsuario_Click(object sender, EventArgs e)
        {
            usu_BE.nom_usuario = txt_NomUsu.Text;
            usu_BE.nombre = txt_Nombre.Text;
            usu_BE.apellido = txt_Apellido.Text;
            usu_BE.documento = int.Parse(txt_NumDoc.Text);
            usu_BE.email = txt_Email.Text;
            usu_BE.telefono = txt_Telefono.Text;
            usu_BE.domicilio = txt_Domicilio.Text;
            usu_BE.area = comboBox1.Text;
            
            usu_BLL.Update(usu_BE);
        }
    }
}
