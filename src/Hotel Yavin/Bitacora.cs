using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;

namespace Hotel_Yavin
{
    public partial class Bitacora : Form
    {
        List<BE.Bitacora> lista_filtrada = new List<BE.Bitacora>();
        BLL.Bitacora.BAJA bitacora_BLL = new BLL.Bitacora.BAJA();
        BLL.Usuario usu_BLL = new BLL.Usuario();

        public Bitacora()
        {
            InitializeComponent();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            Btn_Buscar.Enabled = BLL.ConfigUsuario.ValidarAcceso("Buscar Bitácora");
            btn_GenerarReporte.Enabled = BLL.ConfigUsuario.ValidarAcceso("Generar Reporte Bitacora");

            this.ConfigurarGrilla();
            this.ActualizarGrilla();
            this.CargarCheckListBoxs();

        }

        private void ConfigurarGrilla()
        {
            dataGridView1.Columns.Add("id_log", "Id");
            dataGridView1.Columns.Add("id_usuario", "Id Usuario");
            dataGridView1.Columns.Add("nombre_Usuario", "Nombre Usuario");
            dataGridView1.Columns.Add("fecha", "Fecha");
            dataGridView1.Columns.Add("criticidad", "Cricitidad");
            dataGridView1.Columns.Add("descripcion", "Descripcion");
            dataGridView1.Columns.Add("DVH", "DVH");
        }

        private void ActualizarGrilla()
        {
            dataGridView1.Rows.Clear();
             List<BE.Bitacora> lista_logs = bitacora_BLL.SelectAll();
            foreach (BE.Bitacora row in lista_logs)
            {
                dataGridView1.Rows.Add(row.id_log, row.id_usuario, row.nombre_usuario, row.fecha, row.criticidad, UTILITIES.Encriptador.Desencriptar(row.descripcion), row.DVH);
            }
        }

        private void CargarCheckListBoxs()
        {
            //CARGA DE CRITICIDADES
            clb_criticidad.Items.Add("ALTA");
            clb_criticidad.Items.Add("MEDIA");
            clb_criticidad.Items.Add("BAJA");

            //CARGA DE USUARIOS
            List<BE.Usuario> lista_usu = new List<BE.Usuario>();
            lista_usu = usu_BLL.SelectAll();
            //List<string> lista_usuarios = new List<string>();
            string usuarios;
            foreach (BE.Usuario usuario in lista_usu)
            {
                usuarios = "" + usuario.id + " - " + UTILITIES.Encriptador.Desencriptar(usuario.nom_usuario) + ", " + usuario.apellido + "";
                clb_Usuarios.Items.Add(usuarios);
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string lista_criticidades = "";
            string lista_usuarios = "";

            if (clb_Usuarios.CheckedItems.Count > 0)
            {
                foreach (string item in clb_Usuarios.CheckedItems)
                {
                    string id = item.Split('-').FirstOrDefault();
                    lista_usuarios += "'" + id + "',";
                }
                lista_usuarios = lista_usuarios.Substring(0, lista_usuarios.Length - 1);
            }

            //CARGO LAS CRITICIDADES SELECCIONADAS
            if (clb_criticidad.CheckedItems.Count > 0)
            {
                foreach (string item in clb_criticidad.CheckedItems)
                {
                    lista_criticidades += "'" + item + "',";
                }
                lista_criticidades = lista_criticidades.Substring(0, lista_criticidades.Length -1);
            }

            DateTime fecha_desde = Convert.ToDateTime(dtp_fechaDesde.Value.Date);
            DateTime fecha_hasta = Convert.ToDateTime(dtp_fechaHasta.Value.Date.AddHours(23).AddMinutes(59));

            //bitacora_BLL.GetFiltros(Convert.ToDateTime(dtp_fechaDesde.Value), Convert.ToDateTime(dtp_fechaHasta.Value), lista_usuarios, lista_criticidades);
            lista_filtrada = bitacora_BLL.GetFiltros(fecha_desde, fecha_hasta, lista_usuarios, lista_criticidades);
            dataGridView1.Rows.Clear();
            foreach (BE.Bitacora row in lista_filtrada)
            {
                dataGridView1.Rows.Add(row.id_log, row.id_usuario, row.nombre_usuario, row.fecha, row.criticidad, UTILITIES.Encriptador.Desencriptar(row.descripcion), row.DVH);
            }
            
        }

        private void btn_GenerarReporte_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.RowCount > 0)
            //{
            //    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        printDocument1.Print();
            //    }
            //}


            //List<BE.Bitacora> listado_logs = new List<BE.Bitacora>();
            //BE.Bitacora bitacora_BE = new BE.Bitacora();

            //foreach (DataGridViewRow item in dataGridView1.Rows)
            //{
            //    //bitacora_BE.id_log = (int)item.Cells[0].Value;
            //    bitacora_BE.id_usuario = (int)item.Cells[1].Value;
            //    bitacora_BE.nombre_usuario = (string)item.Cells[2].Value;
            //    bitacora_BE.fecha = Convert.ToDateTime(item.Cells[3].Value);
            //    bitacora_BE.criticidad = (string)item.Cells[4].Value;
            //    bitacora_BE.descripcion = (string)item.Cells[5].Value;
            //    listado_logs.Add(bitacora_BE);
            //}

            //Hotel_Yavin.Reporte_Bitacora reporte_bitacora = new Reporte_Bitacora(listado_logs);
            //reporte_bitacora.Show();

            //SIRVE
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            //CON SpreadsheetLight PERO TENGO QUE CREAR UN EXCEL PREVIAMENTE
            //string pathFile = AppDomain.CurrentDomain.BaseDirectory + "ReporteBitacora.xlsx";
            //SLDocument document = new SLDocument();

            //DataTable dataTable = new DataTable();

            //dataTable.Columns.Add("ID");
            //dataTable.Columns.Add("ID Usuario");
            //dataTable.Columns.Add("Nombre Usuario");
            //dataTable.Columns.Add("Fecha");
            //dataTable.Columns.Add("Descripcion");
            //dataTable.Columns.Add("Criticidad");

            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    dataTable.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value);
            //}

            //document.ImportDataTable(1, 1, dataTable, true);
            //document.SaveAs(pathFile);

            //MessageBox.Show("Se creo el reporte");


            //printDocument1 = new System.Drawing.Printing.PrintDocument();
            //PrinterSettings ps = new PrinterSettings();
            //printDocument1.PrinterSettings = ps;
            //printDocument1.PrintPage += Imprimir;
            //printDocument1.Print();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //strFormat = new StringFormat();
            //strFormat.Alignment = StringAlignment.Near;
            //strFormat.LineAlignment = StringAlignment.Center;
            //strFormat.Trimming = StringTrimming.EllipsisCharacter;
            //arrColumnLefts.Clear();
            //arrColumnWidths.Clear();
            //iCellHeight = 0;
            //iRow = 0;
            //bFirstPage = true;
            //bNewPage = true;
            //// Calcular total de ancho
            //iTotalWidth = 0;
            //foreach (DataGridViewColumn item in dgv.Columns)
            //{
            //    iTotalWidth += item.Width;
            //}
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            //Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            //e.Graphics.DrawString("REPORTE BITACORA", font, Brushes.Black, new Rectangle(300, 100, 300, 300));

            //PaintEventArgs paint = new PaintEventArgs(e.Graphics, new Rectangle(100, 200, 200, 200));
            
            //this.InvokePaint(dataGridView1, paint);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap objMap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objMap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(objMap, 250, 120);
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            e.Graphics.DrawString("REPORTE BITACORA", font, Brushes.Black, new Rectangle(300, 100, 300, 300));

            //C# Tutorial - How to Print a DataGridView | FoxLearn
        }
    }
}
