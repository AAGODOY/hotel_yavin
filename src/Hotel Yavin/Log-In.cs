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
        static BLL.FamiliaUsuario usuFam_BLL = new BLL.FamiliaUsuario();
        static BLL.Idioma idioma_BLL = new BLL.Idioma();
        static BLL.Traduccion traduccion_BLL = new BLL.Traduccion();
        BLL.Bitacora.ALTA Bitacora_ALTA = new BLL.Bitacora.ALTA();
        BLL.Bitacora.BAJA Bitacora_BAJA = new BLL.Bitacora.BAJA();
        BLL.Bitacora.MEDIA Bitacora_MEDIA = new BLL.Bitacora.MEDIA();

        public Log_In()
        {
            InitializeComponent();
        }

        private void Log_In_Load(object sender, EventArgs e)
        {
            ValidarVisibilidad();
        }

        private void ValidarVisibilidad()
        {
            if (ValidarConexion())
            {
                //TEST
                txt_NombreUsu.Text = "Alduuu";
                txt_contraseña.Text = "asd";
            }
            else
            {
                ConfiguradorConexion configConexion = new ConfiguradorConexion();
                configConexion.Show(this);
                this.Hide();
                
            }
        }

        private bool ValidarConexion()
        {
            string connString = BLL.Services.GetConnectionString();
            connString = UTILITIES.Encriptador.Desencriptar(connString);
            if (BLL.Services.ValidarConexion(connString))
            {
                Console.WriteLine(connString);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            usu_BE.nom_usuario = txt_NombreUsu.Text;
            usu_BE.contraseña = txt_contraseña.Text;
            //Menu menuPrincipal = new Menu(usu_BE);

            if (usu_BE.nom_usuario != "")
            {
                if (usu_BE.contraseña != "")
                {
                    usu_BE = usu_BLL.validarUsuario(usu_BE);
                    if (ValidarUsu(usu_BE))
                    {
                        Menu menuPrincipal = new Menu(usu_BE);
                        if (!usu_BE.activo)
                        {
                            MessageBox.Show("El usuario se encuentra inhabilitado. Por favor, comunicarse con el Administrador del sistema");
                        }
                        else
                        {
                            //CONFIGURACION GLOBAL DEL USUARIO DEL SISTEMA
                            this.FijarPermisos();
                            this.FijarIdioma();

                            if (usu_BE.es_primer_login)
                            {
                                Modificar_Contrasena mod_contraseña = new Modificar_Contrasena(usu_BE);
                                mod_contraseña.Show(this);
                                this.Hide();
                            }
                            else
                            {
                                List<string> listaErrores = BLL.DigitoVerificador.VerificarIntegridad();
                                if (listaErrores.Count == 0)
                                {
                                    MessageBox.Show("Se ingresó al sistema");
                                    Bitacora_BAJA.RegistrarEnBitacora(usu_BE, DateTime.Now, "Login exitoso");
                                    
                                    menuPrincipal.Show(this);
                                    //this.Owner.Hide();
                                    this.Hide();
                                }
                                else
                                {
                                    IntegridadBD formIntegridadBD = new IntegridadBD(listaErrores);
                                    formIntegridadBD.Show(this);
                                    this.Hide();
                                }
                            }
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
            BE.ConfigUsuario.usuarioLogueado = usu_BE;
            BLL.ConfigUsuario.FijarPermisos(
                usuPat_BLL.SelectByIdUser(usu_BE.id),
                usuPat_BLL.GetPatentesIndividuales(usu_BE.id),
                usuFam_BLL.GetFamilias(usu_BE.id));
        }

        private void FijarIdioma()
        {
            BE.ConfigUsuario.idioma = idioma_BLL.GetIdioma(usu_BE.id);
            BE.ConfigUsuario.traducciones = traduccion_BLL.GetTraduccion(usu_BE.id);
        }

        private Boolean ValidarUsu(BE.Usuario usu)
        {
            //usu = usu_BLL.validarUsuario(usu);
            if (usu.nom_usuario == txt_NombreUsu.Text)
            {
                if (usu.contraseña == UTILITIES.Encriptador.Encriptar(txt_contraseña.Text))
                {
                    return true;
                }
                else
                {
                    switch (usu.cant_ingresos_incorrectos)
                    {
                        case 0:
                            MessageBox.Show("Contraseña INVALIDA. Usted tiene 1 intento fallido");
                            Bitacora_BAJA.RegistrarEnBitacora(usu_BE, DateTime.Now, "Login: 1 intento fallido");
                            usu_BLL.IncrementarIngresosIncorrectos(usu);
                            break;
                        case 1:
                            MessageBox.Show("Contraseña INVALIDA. Usted tiene 2 intento fallido");
                            Bitacora_MEDIA.RegistrarEnBitacora(usu_BE, DateTime.Now, "Login: 2 intentos fallidos");
                            usu_BLL.IncrementarIngresosIncorrectos(usu);
                            break;
                        case 2:
                            MessageBox.Show("Se bloqueó su cuenta ya que superó la cantidad de ingresos fallidos");
                            Bitacora_ALTA.RegistrarEnBitacora(usu_BE, DateTime.Now, "Login: 3 intentos fallidos. Bloqueo de cuenta");
                            usu_BLL.IncrementarIngresosIncorrectos(usu);
                            break;
                        case 3:
                            MessageBox.Show("El usuario está bloqueado. Consulte con el administrador");
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
