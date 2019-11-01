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
    public partial class IntegridadBD : Form
    {
        public List<string> lista { get; set; }

        public IntegridadBD()
        {
            InitializeComponent();
        }

        public IntegridadBD(List<string> listaErrores)
        {
            //lst_Errores.DataSource = null;
            lista = listaErrores;
            InitializeComponent();
            //lst_Errores.Items.Add(listaErrores);
        }

        private void IntegridadBD_Load(object sender, EventArgs e)
        {
            lst_Errores.DataSource = null;
            lst_Errores.DataSource = lista;
        }
    }
}
