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
    public partial class Reserva : Form
    {
        BLL.Cliente cliente_BLL = new BLL.Cliente();
        BLL.Habitacion habitacion_BLL = new BLL.Habitacion();

        public Reserva()
        {
            InitializeComponent();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            //PROBAR SI COMBIENE USAR ESTOS BOTONES
            clb_habitaciones.Items.Add(habitacion_BLL.SelectAll());

            //CARGA DE CLIENTES
            List<BE.Cliente> clientes = new List<BE.Cliente>();
            clientes = cliente_BLL.SelectAll();
            cmb_Cliente.Items.Add("Seleccionar");
            foreach (BE.Cliente cliente in clientes)
            {
                cmb_Cliente.Items.Add(cliente.nombre + " " + cliente.apellido);
            }

            cmb_Cliente.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaHuesped huespedes = new AltaHuesped();
            huespedes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarHuesped mod_huesped = new ModificarHuesped();
            mod_huesped.Show();
        }

        private void btn_GuardarEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}
