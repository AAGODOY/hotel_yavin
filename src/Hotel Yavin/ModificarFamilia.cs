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
    public partial class ModificarFamilia : Form
    {
        List<BE.Usuario> familiaUsuariosDB = new List<BE.Usuario>();
        List<BE.Patente> familiaPatentesDB = new List<BE.Patente>();
        DataGridViewRow familia_seleccionada = new DataGridViewRow();
        BLL.Patente pat_BLL = new BLL.Patente();
        BLL.Usuario usu_BLL = new BLL.Usuario();
        BLL.FamiliaUsuario famUsu_BLL = new BLL.FamiliaUsuario();
        BLL.FamiliaPatente famPat_BLL = new BLL.FamiliaPatente();

        public ModificarFamilia()
        {
            InitializeComponent();
        }

        public ModificarFamilia(DataGridViewRow familia)
        {
            InitializeComponent();
            familia_seleccionada = familia;
            ConfiguracionGrillas();
            RetornarDatos();
        }

        private void ModificarFamilia_Load(object sender, EventArgs e)
        {

        }

        private void ConfiguracionGrillas()
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

        }

        private void RetornarDatos()
        {
            //Carga Descripcion de la familia

            txt_NomFam.Text = familia_seleccionada.Cells[1].Value.ToString();

            //Carga grillas de Patentes
            cargarGrillaPatentes(Convert.ToInt32(familia_seleccionada.Cells[0].Value));

            //Carga grillas de Usuarios
            cargarGrillaUsuarios(Convert.ToInt32(familia_seleccionada.Cells[0].Value));
        }

        private void cargarGrillaUsuarios(int id_familia)
        {
            dgv_UsuariosAsociadosAfamilia.DataSource = null;
            dgv_UsuariosDisponibles.DataSource = null;

            //CARGAR: Usuarios asociados a familias
            this.familiaUsuariosDB = famUsu_BLL.GetFamiliaUsuario(id_familia);

            foreach (BE.Usuario usuario in familiaUsuariosDB)
            {
                dgv_UsuariosAsociadosAfamilia.Rows.Add(usuario.id, usuario.activo, usuario.nom_usuario, usuario.nombre, usuario.apellido, usuario.documento, usuario.domicilio, usuario.telefono, usuario.email, usuario.contraseña, usuario.cant_ingresos_incorrectos, usuario.DVH, usuario.es_primer_login, usuario.id_idioma);
            }

            //CARGAR: Usuarios disponibles
            List<BE.Usuario> usuariosUI = new List<BE.Usuario>();
            //List<BE.Usuario> usuariosDB = usu_BLL.SelectAll();
            foreach (BE.Usuario usuDB in usu_BLL.SelectAll())
            {
                //(!) Validar si el usuario ya no fue agregado
                if (!usuariosUI.Any(u => u.id == usuDB.id))
                {
                    //(!) Validar que el usuario a agregar no la tenga la familia
                    if (!familiaUsuariosDB.Any(u => u.id == usuDB.id))
                    {
                        usuariosUI.Add(usuDB);
                    }
                }
            }

            foreach (BE.Usuario usuario in usuariosUI)
            {
                dgv_UsuariosDisponibles.Rows.Add(usuario.id, usuario.activo, usuario.nom_usuario, usuario.nombre, usuario.apellido, usuario.documento, usuario.domicilio, usuario.telefono, usuario.email, usuario.contraseña, usuario.cant_ingresos_incorrectos, usuario.DVH, usuario.es_primer_login, usuario.id_idioma);
            }
        }

        private void cargarGrillaPatentes(int id_familia)
        {
            dgv_patentesAsociadasAfamilia.DataSource = null;
            dgv_patentesDisponibles.DataSource = null;

            //CARGAR: patentes asociadas
            this.familiaPatentesDB = famPat_BLL.GetPatentesFamilia(id_familia);
            foreach (BE.Patente patente in familiaPatentesDB)
            {
                dgv_patentesAsociadasAfamilia.Rows.Add(patente.id, patente.descripcion, patente.activo);
            }

            //CARGAR: patentes disponibles
            List<BE.Patente> patentesUI = new List<BE.Patente>();
            List<BE.Patente> patentesDB = pat_BLL.SelectAll();
            foreach (BE.Patente patDB in patentesDB)
            {
                //(!) Validar si la patente ya no fue agregada
                if (!patentesUI.Any(f => f.id == patDB.id))
                {
                    //(!) Validar que la patente a agregar no la tenga el usuario
                    if (!familiaPatentesDB.Any(f => f.id == patDB.id))
                    {
                        patentesUI.Add(patDB);
                    }
                }
            }

            foreach (BE.Patente patente in patentesUI)
            {
                dgv_patentesDisponibles.Rows.Add(patente.id, patente.descripcion, patente.activo);
            }
        }

        private void btn_CancelarFamilia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GuardarFamilia_Click(object sender, EventArgs e)
        {

        }
    }
}
