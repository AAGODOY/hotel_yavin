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

                if (Owner.Text == "Reserva")
                {
                    Reserva reserva = (Reserva)this.Owner;
                    reserva.ObtenerDatosHuesped(huesped_BE);
                    this.Hide();
                }
                else
                {
                    ModificarReserva mod_reserva = (ModificarReserva)this.Owner;
                    mod_reserva.ObtenerDatosHuesped(huesped_BE);
                    this.Hide();
                }

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
