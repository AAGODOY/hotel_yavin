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
    public partial class AdministrarCobranza : Form
    {
        public AdministrarCobranza()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            AdministrarPago admPago = new AdministrarPago();
            admPago.Show();
        }

        private void AdministrarCobranza_Load(object sender, EventArgs e)
        {
            btn_ver.Enabled = BLL.ConfigUsuario.ValidarAcceso("Administrar Pago");
        }
    }
}
