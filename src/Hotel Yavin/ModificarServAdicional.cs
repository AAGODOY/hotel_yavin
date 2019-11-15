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
    public partial class ModificarServAdicional : Form
    {
        BE.ServAdicional servAdicional_BE = new BE.ServAdicional();
        BLL.ServAdicional servAdicional_BLL = new BLL.ServAdicional();

        DataGridViewRow servicio_actual = new DataGridViewRow();

        public ModificarServAdicional()
        {
            InitializeComponent();
        }

        public ModificarServAdicional(DataGridViewRow servicio)
        {
            InitializeComponent();

            this.servicio_actual = servicio;
        }

        private void ModificarServAdicional_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            txt_descripcion.Text = servicio_actual.Cells[2].Value.ToString();
            txt_precio.Text = servicio_actual.Cells[3].Value.ToString();
        }

        private void btn_GuardarCliente_Click(object sender, EventArgs e)
        {
            if (txt_descripcion.Text != "" && txt_precio.Text != "")
            {
                servAdicional_BE.id_servicio = (int)servicio_actual.Cells[0].Value;
                servAdicional_BE.descripcion = txt_descripcion.Text;
                servAdicional_BE.precio = Convert.ToDouble(txt_precio.Text);
                servAdicional_BLL.Update(servAdicional_BE);
                MessageBox.Show("Se modificó un nuevo Servicio");
                this.Close();
            }
        }

        private void btn_CancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
