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
    public partial class ConfiguradorConexion : Form
    {
        
        public ConfiguradorConexion()
        {
            InitializeComponent();
        }

        private void ConfiguradorConexion_Load(object sender, EventArgs e)
        {
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            if (BLL.Services.ValidarConexion(txt_servidor.Text, txt_nombreBD.Text, false, txt_usuario.Text, txt_contraseña.Text))
            {
                BLL.Services.setConnectionString(txt_servidor.Text, txt_nombreBD.Text, true, txt_usuario.Text, txt_contraseña.Text);
                MessageBox.Show("Se ingresó correctamente a la Base de Datos");
                Log_In login = new Log_In();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al conectar a la Base de Datos. Verifique que los datos ingresados sean correctos");
            }
        }
    }
}
