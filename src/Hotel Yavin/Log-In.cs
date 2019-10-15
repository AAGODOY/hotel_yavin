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
    public partial class Log_In : Form
    {
        BE.Usuario usu_BE = new BE.Usuario();
        static BLL.Usuario usu_BLL = new BLL.Usuario();
        static BLL.UsuarioPatente usuPat_BLL = new BLL.UsuarioPatente();

        public Log_In()
        {
            InitializeComponent();
            //TEST
            txt_NombreUsu.Text = "aldana";
            txt_contraseña.Text = "asd";
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            usu_BE.nom_usuario = txt_NombreUsu.Text;
            usu_BE.contraseña = txt_contraseña.Text;
            Menu menuPrincipal = new Menu();
            Log_In logIn = new Log_In();

            if (usu_BE.nom_usuario != "")
            {
                if (usu_BE.contraseña != "")
                {
                    usu_BE = usu_BLL.validarUsuario(usu_BE);
                    if (ValidarUsu(usu_BE))
                    {
                        if (usu_BE.es_primer_login)
                        {
                            Modificar_Contrasena mod_contraseña = new Modificar_Contrasena();
                            mod_contraseña.Show(this);
                            this.Hide();
                        }
                        else
                        {
                            //ValidarPrimerLogin(usu_BE);
                            MessageBox.Show("Se ingresó al sistema");
                            //CONFIGURACION GLOBAL
                            this.FijarPermisos();

                            menuPrincipal.Show(this);
                            //this.Owner.Hide();
                            this.Hide();  
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar el campo 'Contraseña'", "Hotel Yavin", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Debe completar el campo 'Nombre de Usuario'", "Hotel Yavin", MessageBoxButtons.OK);
            }
        }

        private void FijarPermisos()
        {
            //CONFIGURACION GLOBAL
            BE.ConfigUsuario.patentes = usuPat_BLL.GetPatentes(usu_BE.id);
        }

        private Boolean ValidarUsu(BE.Usuario usu)
        {
            //usu = usu_BLL.validarUsuario(usu);
            if (usu.nom_usuario == txt_NombreUsu.Text) //(usu.id != 0)
            {
                if (usu.contraseña == BLL.Encriptador.Encriptar(txt_contraseña.Text))
	            {   
                    return true;
	            }
                else
	            {
                    switch (usu.cant_ingresos_incorrectos)
                    {
                    case 0: MessageBox.Show("Contraseña INVALIDA. Usted tiene 1 intento fallido");
                        usu_BLL.IncrementarIngresosIncorrectos(usu);
                        break;
                    case 1: MessageBox.Show("Contraseña INVALIDA. Usted tiene 2 intento fallido");
                        usu_BLL.IncrementarIngresosIncorrectos(usu);
                        break;
                    case 2: MessageBox.Show("Se bloqueó su cuenta ya que superó la cantidad de ingresos fallidos");
                        usu_BLL.IncrementarIngresosIncorrectos(usu);
                        break;
                    case 3: MessageBox.Show("El usuario está bloqueado. Consulte con el administrador");
                        break;
                    }
                    return false;
	            }
            }
            else
	        {
                MessageBox.Show("El usuario es incorrecto");
                return false;
	        }
        }
        
    }
 }
