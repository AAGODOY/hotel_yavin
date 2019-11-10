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
    public partial class Bitacora : Form
    {
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
            dataGridView1.DataSource = null;
            foreach (BE.Bitacora row in bitacora_BLL.SelectAll())
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
            DateTime fecha_hasta = Convert.ToDateTime(dtp_fechaHasta.Value.Date);

            //bitacora_BLL.GetFiltros(Convert.ToDateTime(dtp_fechaDesde.Value), Convert.ToDateTime(dtp_fechaHasta.Value), lista_usuarios, lista_criticidades);
            List<BE.Bitacora> lista_filtrada = bitacora_BLL.GetFiltros(fecha_desde, fecha_hasta, lista_usuarios, lista_criticidades);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista_filtrada;
            
        }
    }
}
