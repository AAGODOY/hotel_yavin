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
    public partial class ModificarHabitacion : Form
    {
        DataGridViewRow habitacion_seleccionada = new DataGridViewRow();
        BE.Habitacion habitacion_BE = new BE.Habitacion();
        BLL.Habitacion habitacion_BLL = new BLL.Habitacion();

        public ModificarHabitacion()
        {
            InitializeComponent();
        }

        public ModificarHabitacion(DataGridViewRow habitacion)
        {
            InitializeComponent();

            this.habitacion_seleccionada = habitacion;
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            txt_TipoHabitacion.Text = this.habitacion_seleccionada.Cells[3].Value.ToString();
            txt_descripcion.Text = this.habitacion_seleccionada.Cells[4].Value.ToString();
            txt_numHabitacion.Text = this.habitacion_seleccionada.Cells[5].Value.ToString();
            txt_precio.Text = this.habitacion_seleccionada.Cells[6].Value.ToString();
        }

        private void btn_GuardarCliente_Click(object sender, EventArgs e)
        {
            if (txt_numHabitacion.Text != "" && txt_descripcion.Text != "" && txt_numHabitacion.Text != "" && txt_precio.Text != "")
            {
                habitacion_BE.id_habitacion = (int)habitacion_seleccionada.Cells[0].Value;
                habitacion_BE.tipo_habitacion = txt_TipoHabitacion.Text;
                habitacion_BE.descripcion = txt_descripcion.Text;
                habitacion_BE.Nro_habitacion = txt_numHabitacion.Text;
                habitacion_BE.precio = float.Parse(txt_precio.Text);

                habitacion_BLL.Update(habitacion_BE);
                MessageBox.Show("Se modificó la habitación seleccionada");
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }
    }
}
