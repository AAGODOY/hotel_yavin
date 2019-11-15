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
    public partial class AltaServAdicionales : Form
    {
        BE.ServAdicional servAdicional_BE = new BE.ServAdicional();
        BLL.ServAdicional servAdicional_BLL = new BLL.ServAdicional();

        public AltaServAdicionales()
        {
            InitializeComponent();
        }

        private void btn_GuardarServicio_Click(object sender, EventArgs e)
        {
            if (txt_descripcion.Text != "" && txt_precio.Text != "")
            {
                servAdicional_BE.descripcion = txt_descripcion.Text;
                servAdicional_BE.precio = Convert.ToDouble(txt_precio.Text);
                servAdicional_BLL.Add(servAdicional_BE);
                MessageBox.Show("Se creó un nuevo Servicio");
                this.Close();
            }
        }

        private void btn_CancelarServicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
