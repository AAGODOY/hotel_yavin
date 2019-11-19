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
    public partial class VerDatosDeUsuario : Form
    {
        BE.Usuario usuario_logueado = new BE.Usuario();
        BLL.Usuario usu_BLL = new BLL.Usuario();

        public VerDatosDeUsuario()
        {
            InitializeComponent();
        }

        public VerDatosDeUsuario(BE.Usuario usu_logueado)
        {
            InitializeComponent();

            this.usuario_logueado = usu_logueado;
        }

        private void VerDatosDeUsuario_Load(object sender, EventArgs e)
        {
            btn_Modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Datos Personales");

            this.CargarDatos();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            BE.Usuario usuModificado = new BE.Usuario();
            usuModificado = this.usuario_logueado;

            if (txt_Nombre.Text != "" && txt_Apellido.Text != "" && txt_NumDoc.Text != "" && txt_Email.Text != "" && txt_Telefono.Text != "" && txt_Domicilio.Text != "")
            {
                usuModificado.nombre = txt_Nombre.Text;
                usuModificado.apellido = txt_Apellido.Text;
                usuModificado.documento = Convert.ToInt32(txt_NumDoc.Text);
                usuModificado.email = txt_Email.Text;
                usuModificado.telefono = txt_Telefono.Text;
                usuModificado.domicilio = txt_Domicilio.Text;

                usu_BLL.Update(usuModificado);
                MessageBox.Show("Se modificó el usuario. Iniciar sesion nuevamente para que se actualicen los cambios");
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void CargarDatos()
        { 
            txt_NomUsu.Enabled = false;
            txt_NomUsu.Text = this.usuario_logueado.nom_usuario;
            txt_Nombre.Text = this.usuario_logueado.nombre;
            txt_Apellido.Text = this.usuario_logueado.apellido;
            txt_NumDoc.Text = this.usuario_logueado.documento.ToString();
            txt_Email.Text = this.usuario_logueado.email;
            txt_Telefono.Text = this.usuario_logueado.telefono;
            txt_Domicilio.Text = this.usuario_logueado.domicilio;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
