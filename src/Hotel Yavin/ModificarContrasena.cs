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
        BE.Usuario usuario_actual = new BE.Usuario();
        BLL.Bitacora.BAJA bitacora_BAJA = new BLL.Bitacora.BAJA();
        BLL.Bitacora.ALTA bitacora_ALTA = new BLL.Bitacora.ALTA();

        public Modificar_Contrasena()
        {
            InitializeComponent();
        }

        public Modificar_Contrasena(BE.Usuario usuario)
        {
            InitializeComponent();

            usuario_actual = usuario;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            usu_BE.contraseña = txt_ContraseñaActual.Text;

            if (txt_ContraseñaActual.Text != "" && txt_NuevaContraseña.Text != "" && txt_ConfirmarContraseña.Text != "")
            {
                if (txt_ContraseñaActual.Text == UTILITIES.Encriptador.Desencriptar(usuario_actual.contraseña))
                {
                    if (txt_NuevaContraseña.Text == txt_ConfirmarContraseña.Text)
	                {
                        usu_BLL.modificarContraseña(usuario_actual, usu_BE.contraseña, txt_ConfirmarContraseña.Text);                        
                        MessageBox.Show("Contraseña modificada. Por favor, iniciar sesion nuevamente");
                        if (usuario_actual.es_primer_login)
                        {
                            bitacora_BAJA.RegistrarEnBitacora(this.usuario_actual, DateTime.Now, "Se modificó contraseña por Primer Login");
                            Log_In logIn = new Log_In();
                            logIn.Show(); 
                        }
                        else
                        {
                            bitacora_ALTA.RegistrarEnBitacora(this.usuario_actual, DateTime.Now, "Se modificó contraseña");
                        }
                        this.Close();                       
	                }
                    else
	                {
                        MessageBox.Show("La nueva contraseña y su confirmación no son iguales");
	                }
                }
                else
	            {
                    MessageBox.Show("La contraseña actual no es correcta");
	            }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void Modificar_Contrasena_Load(object sender, EventArgs e)
        {
            btn_Aceptar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Contraseña");
        }
    }
}
