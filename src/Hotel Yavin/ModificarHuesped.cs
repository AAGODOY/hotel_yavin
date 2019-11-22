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
    public partial class ModificarHuesped : Form
    {
        DataGridViewRow huesped_seleccionado = new DataGridViewRow();
        BE.Huesped huesped_BE = new BE.Huesped();

        public ModificarHuesped(DataGridViewRow huesped)
        {
            InitializeComponent();

            this.huesped_seleccionado = huesped;
        }

        private void ModificarHuesped_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void btn_GuardarCliente_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text != "" && txt_Apellido.Text != "" && txt_NumDoc.Text != "" && txt_Tel.Text != "" && txt_Mail.Text != "")
            {
                huesped_BE.nombre = txt_Nombre.Text;
                huesped_BE.apellido = txt_Apellido.Text;
                huesped_BE.documento = int.Parse(txt_NumDoc.Text);
                huesped_BE.telefono = txt_Tel.Text;
                huesped_BE.email = txt_Mail.Text;

                if (Owner.Text == "Reserva")
                {
                    Reserva reserva = (Reserva)this.Owner;
                    reserva.ModificarDatosHuesped(huesped_BE);
                    this.Hide();
                }
                else
                {
                    ModificarReserva mod_reserva = (ModificarReserva)this.Owner;
                    mod_reserva.ModificarDatosHuesped(huesped_BE);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Completar todos los campos");
            }
        }

        private void btn_CancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarDatos()
        {
            txt_Nombre.Text = huesped_seleccionado.Cells[2].Value.ToString();
            txt_Apellido.Text = huesped_seleccionado.Cells[3].Value.ToString();
            txt_NumDoc.Text = huesped_seleccionado.Cells[4].Value.ToString();
            txt_Tel.Text = huesped_seleccionado.Cells[5].Value.ToString();
            txt_Mail.Text = huesped_seleccionado.Cells[6].Value.ToString();
        }
    }
}
