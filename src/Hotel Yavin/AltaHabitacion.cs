﻿using System;
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
    public partial class AltaHabitacion : Form
    {
        BE.Habitacion habitacion_BE = new BE.Habitacion();
        BLL.Habitacion habitacion_BLL = new BLL.Habitacion();

        public AltaHabitacion()
        {
            InitializeComponent();
        }

        private void AltaHabitacion_Load(object sender, EventArgs e)
        {

        }

        private void btn_GuardarCliente_Click(object sender, EventArgs e)
        {
            if (txt_numHabitacion.Text != "" && txt_descripcion.Text != "" && txt_numHabitacion.Text != "" && txt_precio.Text != "")
            {
                habitacion_BE.tipo_habitacion = txt_TipoHabitacion.Text;
                habitacion_BE.descripcion = txt_descripcion.Text;
                habitacion_BE.Nro_habitacion = txt_numHabitacion.Text;
                habitacion_BE.precio = float.Parse(txt_precio.Text);

                habitacion_BLL.Add(habitacion_BE);
                MessageBox.Show("Se creó una nueva habitación");
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }

        private void btn_CancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
