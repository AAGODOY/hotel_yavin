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
        }
    }
}
