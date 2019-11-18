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
    public partial class AltaHuesped : Form
    {
        BE.Huesped huesped_BE = new BE.Huesped();
        BLL.Huesped huesped_BLL = new BLL.Huesped();

        public AltaHuesped()
        {
            InitializeComponent();
        }

        private void AltaHuesped_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarGrilla()
        { 
            
        }

        private void btn_GuardarHuesped_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text != "" && txt_Apellido.Text != "" && txt_NumDoc.Text != "" && txt_Tel.Text != "" && txt_Mail.Text != "")
            {
                huesped_BE.nombre = txt_Nombre.Text;
                huesped_BE.apellido = txt_Apellido.Text;
                huesped_BE.documento = int.Parse(txt_NumDoc.Text);
                huesped_BE.telefono = txt_Tel.Text;
                huesped_BE.email = txt_Mail.Text;

                Reserva reserva = new Reserva();
                reserva.ObtenerDatosHuesped(huesped_BE);
                //reserva.Show(); con esto me muestra bien la grilla pero pierdo lo que ya tenia
                this.Hide();

                //huesped_BLL.Add(huesped_BE);
                //MessageBox.Show("Se creo un nuevo huesped");
            }
            else
            {
                MessageBox.Show("Completar todos los campos");
            }
        }

        private void btn_CancelarHuesped_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
