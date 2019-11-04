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
    public partial class IntegridadBD : Form
    {
        public List<string> lista { get; set; }

        public IntegridadBD()
        {
            InitializeComponent();
        }

        public IntegridadBD(List<string> listaErrores)
        {
            //lst_Errores.DataSource = null;
            lista = listaErrores;
            InitializeComponent();
            //lst_Errores.Items.Add(listaErrores);
        }

        private void IntegridadBD_Load(object sender, EventArgs e)
        {
            lst_Errores.DataSource = null;
            lst_Errores.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RecalcularDigitosUsuario();
        }

        private void RecalcularDigitosUsuario()
        {
            //RECALCULO DVH Y DVV DE LA TABLA USUARIO
            BLL.Usuario usu_BLL = new BLL.Usuario();
            BE.Usuario usu_BE = new BE.Usuario();
            List<BE.Usuario> lista_usu = new List<BE.Usuario>();
            lista_usu = usu_BLL.SelectAll();
            foreach (BE.Usuario item in lista_usu)
            {
                string cadena = item.activo.ToString() + item.nom_usuario + item.nombre + item.apellido + item.documento.ToString() + item.domicilio + item.telefono + item.email + item.contraseña + item.cant_ingresos_incorrectos.ToString() + item.es_primer_login.ToString() + item.id_idioma.ToString();
                int valorDVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadena);
                usu_BLL.UpdateDVH(valorDVH, item.id);
            }

            BLL.DigitoVerificador.CalcularDVV("Usuario");
        }
    }
}
