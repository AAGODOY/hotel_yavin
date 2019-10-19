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
    public partial class Restaurar_copia_de_seguridad : Form
    {
        public Restaurar_copia_de_seguridad()
        {
            InitializeComponent();
        }

        private void Restaurar_copia_de_seguridad_Load(object sender, EventArgs e)
        {
            btn_examinar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Examinar");
            btn_restaurar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Restaurar Back-Up");
        }
    }
}
