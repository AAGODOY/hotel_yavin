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
            //TEST: para chequear (BORRAR !)
            txt_NomUsu.Text = "Aldo";
            txt_Nombre.Text = "Aldi";
            txt_Apellido.Text = "Gody";
            txt_NumDoc.Text = "38777554";
            txt_Email.Text = "aldi.god@gmail.com";
            txt_Telefono.Text = "4362223";
            txt_Domicilio.Text = "Italia 77";
            cbx_area.Text = "Algo más";


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
                dgv_patentesDisponibles.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value);
                //Patentes asociadas (-)
                dgv_patentesAsociadas.Rows.RemoveAt(fila.Index);
            }

            //CONDICION: inhabilitar botón de negar si no hay patentes asociadas
            if(dgv_patentesAsociadas.Rows.Count < 1)
            {
                this.btn_Negar.Enabled = false;
            }
        }

        private void btn_Negar_Click(object sender, EventArgs e)
        {
            //CONDICION: 1 o más patentes asociadas seleccionadas
            if (dgv_patentesAsociadas.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow fila in dgv_patentesAsociadas.SelectedRows) {
                    if((bool)fila.Cells[2].Value)
                        fila.Cells[2].Value = false;
                    else
                        fila.Cells[2].Value = true;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una patente asociada para negar");
            }
        }

        private void btn_GuardarUsuario_Click(object sender, EventArgs e)
        {
            //PASO 1: Creación de usuario
            usu_BE.nom_usuario = txt_NomUsu.Text;
            usu_BE.nombre = txt_Nombre.Text;
            usu_BE.apellido = txt_Apellido.Text;
            usu_BE.documento = int.Parse(txt_NumDoc.Text);
            usu_BE.email = txt_Email.Text;
            usu_BE.telefono = txt_Telefono.Text;
            usu_BE.domicilio = txt_Domicilio.Text;
            usu_BE.area = cbx_area.Text;

            int idUsuario = usu_BLL.Add(usu_BE);

            //PASO 2: Asociación de patentes a usuario
            foreach (DataGridViewRow fila in dgv_patentesAsociadas.Rows)
            {
                usuPat_BE.id_patente = (int)fila.Cells[0].Value;
                usuPat_BE.id_usuario = idUsuario;
                usuPat_BE.patenteNegada = (bool)fila.Cells[2].Value;
                usuPat_BLL.Add(usuPat_BE);
            }

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

        //CONDICION: para contralar el estado del botón negar
        private void Dgv_patentesAsociadas_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_patentesAsociadas.SelectedRows.Count >= 1)
            {
                this.btn_Negar.Enabled = true;
            }
        }
    }
}
