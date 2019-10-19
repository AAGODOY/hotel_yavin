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
    public partial class ModificarIdioma : Form
    {
        public ModificarIdioma()
        {
            InitializeComponent();
        }

        private void ModificarIdioma_Load(object sender, EventArgs e)
        {
            btn_Aceptar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Modificar Idioma");
        }
    }
}
