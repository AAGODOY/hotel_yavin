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
    public partial class ReporteBitacora : Form
    {
        public ReporteBitacora()
        {
            InitializeComponent();
        }

        public ReporteBitacora(DataGridView origenDatos)
        {
            InitializeComponent();

            //GENERACION DE REPORTE...
            this.rpt_informBitacora = new InformeBitacora();
            this.cryrep_bitacora.ReportSource = this.rpt_informBitacora;
            this.rpt_informBitacora.SetDataSource(this.GenerarDatos(origenDatos));
        }

        private void ReporteBitacora_Load(object sender, EventArgs e)
        {

        }

        private DataTable GenerarDatos(DataGridView origen)
        {
            DataTable tablaDatos = new DataTable();
            tablaDatos.Columns.Add("ID_log");
            tablaDatos.Columns.Add("ID_usuario");
            tablaDatos.Columns.Add("Nombre_usuario");
            tablaDatos.Columns.Add("Fecha");
            tablaDatos.Columns.Add("Criticidad");
            tablaDatos.Columns.Add("Descripcion");
            tablaDatos.Columns.Add("DVH");

            foreach (DataGridViewRow item in origen.Rows)
            {
                DataRow itemFinal = tablaDatos.NewRow();
                itemFinal["ID_log"] = item.Cells[0].Value;
                itemFinal["ID_usuario"] = item.Cells[1].Value;
                itemFinal["Nombre_usuario"] = item.Cells[2].Value;
                itemFinal["Fecha"] = item.Cells[3].Value;
                itemFinal["Criticidad"] = item.Cells[4].Value;
                itemFinal["Descripcion"] = item.Cells[5].Value;
                itemFinal["DVH"] = item.Cells[6].Value;
                tablaDatos.Rows.Add(itemFinal);
            }
            return tablaDatos;
        }
    }
}
