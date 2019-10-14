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
    public partial class Modificar_Contrasena : Form
    {
        BE.Usuario usu_BE = new BE.Usuario();
        BLL.Usuario usu_BLL = new BLL.Usuario();

        public Modificar_Contrasena()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            usu_BE.contraseña = txt_ContraseñaActual.Text;

            if (txt_ContraseñaActual.Text == "")
            {
                MessageBox.Show("Debe completar la contraseña actual");
            }
            else
            {
                if (txt_NuevaContraseña.Text == "")
                {
                    MessageBox.Show("Debe completar la nueva contraseña");
                }
                else if (txt_ConfirmarContraseña.Text == "")
                {
                    MessageBox.Show("Debe completar la confirmación de la nueva contraseña");
                }
                else
                {
                    if (txt_NuevaContraseña.Text != txt_ConfirmarContraseña.Text)
                    {
                        MessageBox.Show("La nueva contraseña y su confirmación no son iguales");
                    }
                }

                if (usu_BLL.modificarContraseña(usu_BE.contraseña, txt_ConfirmarContraseña.Text))
                {
                    MessageBox.Show("Contraseña modificada. Por favor, iniciar sesion nuevamente");
                    this.Close();
                    Log_In logIn = new Log_In();
                    logIn.Show();
                }
                else
                {
                    MessageBox.Show("La contraseña actual es inválida");
                }

            }
        }
    }
}
