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
    public partial class ConsultaHabitaciones : Form
    {
        BLL.Habitacion habitacion_BLL = new BLL.Habitacion();
        BE.Habitacion habitacion_BE = new BE.Habitacion();

        public ConsultaHabitaciones()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ConsultaHabitaciones_Load(object sender, EventArgs e)
        {
            btn_Buscar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Buscar Habitacion");
            btn_alta.Enabled = BLL.ConfigUsuario.ValidarAcceso("Alta Habitacion");
            btn_modificar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Habitacion");
            btn_baja.Enabled = BLL.ConfigUsuario.ValidarAcceso("Inhabilitar Habitacion");
            btn_habilitar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Habilitar Habitacion");

            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = habitacion_BLL.SelectAll();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            AltaHabitacion alta_habitacion = new AltaHabitacion();
            alta_habitacion.Show();
            this.Hide();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarHabitacion mod_habitacion = new ModificarHabitacion(dataGridView1.CurrentRow);
            mod_habitacion.Show();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            habitacion_BE.id_habitacion = (int)dataGridView1.CurrentRow.Cells[0].Value;
            habitacion_BLL.Delete(habitacion_BE);
            MessageBox.Show("Se inhabilitó el registro");
            this.ActualizarGrilla();
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            habitacion_BE.id_habitacion = (int)dataGridView1.CurrentRow.Cells[0].Value;
            habitacion_BLL.Habilitar(habitacion_BE);
            MessageBox.Show("Se habilitó el registro");
            this.ActualizarGrilla();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            DateTime fecha_ingreso = Convert.ToDateTime(dtpIngreso.Value.Date);
            DateTime fecha_salida = Convert.ToDateTime(dtpSalida.Value.Date);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = habitacion_BLL.GetFiltros(fecha_ingreso, fecha_salida);
        }
    }
}
