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
    public partial class Familia : Form
    {
        BE.Usuario usuario_logueado = new BE.Usuario();
        BLL.Usuario usu_BLL = new BLL.Usuario();
        BLL.Patente pat_BLL = new BLL.Patente();
        BE.Familia fam_BE = new BE.Familia();
        BLL.Familia fam_BLL = new BLL.Familia();
        BE.FamiliaPatente famPat_BE = new BE.FamiliaPatente();
        BLL.FamiliaPatente famPat_BLL = new BLL.FamiliaPatente();
        BE.FamiliaUsuario famUsu_BE = new BE.FamiliaUsuario();
        BLL.FamiliaUsuario famUsu_BLL = new BLL.FamiliaUsuario();
        BLL.Bitacora.BAJA bitacora_BAJA = new BLL.Bitacora.BAJA();

        public Familia()
        {
            InitializeComponent();
        }

        public Familia(BE.Usuario usu_logueado)
        {
            InitializeComponent();

            this.usuario_logueado = usu_logueado;
        }

        private void tab_PatenteFamilia_Click(object sender, EventArgs e)
        {

        }

        private void Familia_Load(object sender, EventArgs e)
        {
            //DataGridView Usuarios Disponibles
            dgv_UsuariosDisponibles.Columns.Add("id", "Id");
            dgv_UsuariosDisponibles.Columns.Add("activo", "Activo");
            dgv_UsuariosDisponibles.Columns.Add("nombre_usuario", "Nombre_usuario");
            dgv_UsuariosDisponibles.Columns.Add("nombre", "Nombre");
            dgv_UsuariosDisponibles.Columns.Add("apellido", "Apellido");
            dgv_UsuariosDisponibles.Columns[0].Visible = false;

            //DataGridView Usuarios asociadas
            dgv_UsuariosAsociadosAfamilia.Columns.Add("id", "Id");
            dgv_UsuariosAsociadosAfamilia.Columns.Add("activo", "Activo");
            dgv_UsuariosAsociadosAfamilia.Columns.Add("nombre_usuario", "Nombre_usuario");
            dgv_UsuariosAsociadosAfamilia.Columns.Add("nombre", "Nombre");
            dgv_UsuariosAsociadosAfamilia.Columns.Add("apellido", "Apellido");
            dgv_UsuariosAsociadosAfamilia.Columns[0].Visible = false;

            //DataGridView Patentes Disponibles
            dgv_patentesDisponibles.Columns.Add("id", "Id");
            dgv_patentesDisponibles.Columns.Add("descripcion", "Descripción");
            dgv_patentesDisponibles.Columns[0].Visible = false;

            //DataGridView Patentes asociadas
            dgv_patentesAsociadasAfamilia.Columns.Add("id", "Id");
            dgv_patentesAsociadasAfamilia.Columns.Add("descripcion", "Descripción");
            dgv_patentesAsociadasAfamilia.Columns[0].Visible = false;

            ActualizarGrillas();

        }

        public void ActualizarGrillas()
        {
            dgv_patentesDisponibles.DataSource = null;
            dgv_UsuariosDisponibles.DataSource = null;

            foreach (BE.Patente patente in pat_BLL.SelectAll())
            {
                dgv_patentesDisponibles.Rows.Add(patente.id, patente.descripcion, patente.activo);
            }

            foreach (BE.Usuario usuario in usu_BLL.SelectAll())
            {
                dgv_UsuariosDisponibles.Rows.Add(usuario.id, usuario.activo, UTILITIES.Encriptador.Desencriptar(usuario.nom_usuario), usuario.nombre, usuario.apellido, usuario.documento, usuario.domicilio, usuario.telefono, usuario.email, usuario.contraseña, usuario.cant_ingresos_incorrectos, usuario.DVH, usuario.es_primer_login, usuario.id_idioma);
            }
        }

        private void btn_GuardarFamilia_Click(object sender, EventArgs e)
        {
            //Insert en tabla Familia
            fam_BE.descripcion = txt_NomFam.Text;
            int id_familia = fam_BLL.Add(fam_BE);
            bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se creó una Familia");

            //Insert en tabla FamiliaPatente
            foreach (DataGridViewRow fila in dgv_patentesAsociadasAfamilia.Rows)
            {
                famPat_BE.id_Patente = (int)fila.Cells[0].Value;
                famPat_BE.id_Familia = id_familia;
                famPat_BLL.Add(famPat_BE);
                bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se agregó una patente a una Familia");
            }
            //Insert en tabla FamiliaUsuario
            foreach (DataGridViewRow fila in dgv_UsuariosAsociadosAfamilia.Rows)
            {
                famUsu_BE.id_usuario = (int)fila.Cells[0].Value;
                famUsu_BE.id_familia = id_familia;
                famUsu_BLL.Add(famUsu_BE);
            }

            MessageBox.Show("Se creó la familia");
            ActualizarGrillas();
        }

        private void btn_AsociarPatente_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv_patentesDisponibles.SelectedRows)
            {
                //Patentes asociadas (+)
                dgv_patentesAsociadasAfamilia.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value);
                //Patentes disponibles (-)
                dgv_patentesDisponibles.Rows.RemoveAt(fila.Index);
            }
        }

        private void btn_DesasociarPatente_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv_patentesAsociadasAfamilia.SelectedRows)
            {
                //Patentes disponibles (+)
                dgv_patentesDisponibles.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value);
                //Patentes asociadas (-)
                dgv_patentesAsociadasAfamilia.Rows.RemoveAt(fila.Index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            foreach (DataGridViewRow fila in dgv_UsuariosDisponibles.SelectedRows)
            {
                //Usuarios asociadas (+)
                dgv_UsuariosAsociadosAfamilia.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value, fila.Cells[3].Value, fila.Cells[4].Value);
                //Usuarios disponibles (-)
                dgv_UsuariosDisponibles.Rows.RemoveAt(fila.Index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv_patentesAsociadasAfamilia.SelectedRows)
            {
                //Usuarios disponibles (+)
                dgv_UsuariosDisponibles.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value, fila.Cells[3].Value, fila.Cells[4].Value);
                //Usuarios asociadas (-)
                dgv_UsuariosAsociadosAfamilia.Rows.RemoveAt(fila.Index);
            }
        }
    }
}
