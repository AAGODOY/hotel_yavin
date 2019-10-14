using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Hotel_Yavin
{
    public partial class AltaUsuario : Form
    {
        BE.Usuario usu_BE = new BE.Usuario();
        BLL.Usuario usu_BLL = new BLL.Usuario();
        BE.Patente pat_BE = new BE.Patente();
        BLL.Patente pat_BLL = new BLL.Patente();
        BE.UsuarioPatente usuPat_BE = new BE.UsuarioPatente();
        BLL.UsuarioPatente usuPat_BLL = new BLL.UsuarioPatente();

        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            //DataGridView Patentes disponibles
            dgv_patentesDisponibles.DataSource = null;
            dgv_patentesDisponibles.Columns.Add("id", "Id");
            dgv_patentesDisponibles.Columns.Add("descripcion", "Descripción");
            dgv_patentesDisponibles.Columns[0].Visible = false;
            //DataGridView Patentes asociadas
            dgv_patentesAsociadas.DataSource = null;
            dgv_patentesAsociadas.Columns.Add("id", "Id");
            dgv_patentesAsociadas.Columns.Add("descripcion", "Descripción");
            dgv_patentesAsociadas.Columns.Add("negada", "Negada");
            dgv_patentesAsociadas.Columns[0].Visible = false;
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            foreach (var patente in pat_BLL.SelectAll())
            {
                dgv_patentesDisponibles.Rows.Add(patente.id, patente.descripcion, patente.activo);
            }
        }

        private void btn_AsociarPatente_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv_patentesDisponibles.SelectedRows) {
                //Patentes asociadas (+)
                dgv_patentesAsociadas.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value, false);
                //Patentes disponibles (-)
                dgv_patentesDisponibles.Rows.RemoveAt(fila.Index);
            }
        }

        private void Btn_DesasociarPatente_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv_patentesAsociadas.SelectedRows)
            {
                //Patentes disponibles (+)
                dgv_patentesDisponibles.Rows.Add(fila);
                //Patentes asociadas (-)
                dgv_patentesAsociadas.Rows.RemoveAt(fila.Index);   
            }
            //Lista intermedia
            //this.refresh_usuarioPatentes();
            //this.refresh_patentesNegadas();
        }

        private void btn_Negar_Click(object sender, EventArgs e)
        {
            //Funciona sólo si hay 1 o más patentes asociadas seleccionadas
            //if (true)
            //{
               
            //}
            //else
            //{
            //    MessageBox.Show("Debe seleccionar al menos una patente asociada para negar");
            //}
            this.refresh_patentesNegadas();
        }

        private void refresh_usuarioPatentes() {
            //Refresh: patentes asociadas del usuario (no incluye descripcion)

        }
        private void refresh_patentesNegadas() {
            //Refresh: patentes asociadas negadas

        }

        private void btn_GuardarUsuario_Click(object sender, EventArgs e)
        {


            usu_BE.nom_usuario = txt_NomUsu.Text;
            usu_BE.nombre = txt_Nombre.Text;
            usu_BE.apellido = txt_Apellido.Text;
            usu_BE.documento = int.Parse(txt_NumDoc.Text);
            usu_BE.email = txt_Email.Text;
            usu_BE.telefono = txt_Telefono.Text;
            usu_BE.domicilio = txt_Domicilio.Text;
            usu_BE.area = comboBox1.Text;

            int idUsuario = usu_BLL.Add(usu_BE);

            #region REFLECTION: Implementación v2
            //var items = BLL.Services.GetPropertyValues("ObjectCollection", lst_PatentesAsociadas);
            //foreach (BE.Patente item in items)
            //{
            //    usuPat_BE.id_patente = item.id;
            //    usuPat_BE.id_usuario = idUsuario;
            //}
            #endregion
        }
        private void btn_CancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
