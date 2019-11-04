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
        BE.FamiliaUsuario famUsu_BE = new BE.FamiliaUsuario();
        BLL.FamiliaPatente famPat_BLL = new BLL.FamiliaPatente();
        BE.FamiliaPatente famPat_BE = new BE.FamiliaPatente();
        BE.Familia familia_BE = new BE.Familia();
        BLL.Familia familia_BLL = new BLL.Familia();

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
            if (txt_NomFam.Text != "")
            {
                //PASO 1: Update de la descripcion
                familia_BE.descripcion = txt_NomFam.Text;
                familia_BE.id = (int)familia_seleccionada.Cells[0].Value;

                familia_BLL.Update(familia_BE);

                //PASO 2 parte 1: Asociacion de patentes a familia
                foreach (DataGridViewRow fila in dgv_patentesAsociadasAfamilia.Rows)
                {
                    if (!this.familiaPatentesDB.Any(fp => fp.id == (int)fila.Cells[0].Value))
                    {
                        famPat_BE.id_Patente = (int)fila.Cells[0].Value;
                        famPat_BE.id_Familia = (int)familia_seleccionada.Cells[0].Value;
                        famPat_BLL.Add(famPat_BE);
                    }
                }

                //PASO 2 parte 2: Desasociacion de patente a familia
                foreach (DataGridViewRow fila in dgv_patentesDisponibles.Rows)
                {
                    if (this.familiaPatentesDB.Any(fp => fp.id == (int)fila.Cells[0].Value))
                    {
                        famPat_BE.id_Patente = (int)fila.Cells[0].Value;
                        famPat_BE.id_Familia = (int)familia_seleccionada.Cells[0].Value;
                        famPat_BLL.Delete(famPat_BE);
                    }
                }

                //PASO 3 parte 1: Asociacion de usuario a Familia
                foreach (DataGridViewRow fila in dgv_UsuariosAsociadosAfamilia.Rows)
                {
                    if (!this.familiaUsuariosDB.Any(fu => fu.id == (int)fila.Cells[0].Value))
                    {
                        famUsu_BE.id_usuario = (int)fila.Cells[0].Value;
                        famUsu_BE.id_familia = (int)familia_seleccionada.Cells[0].Value;
                        famUsu_BLL.Add(famUsu_BE);
                    }
                }

                //PASO 3 parte 2: Desasociacion de usuario a Familia
                foreach (DataGridViewRow fila in dgv_UsuariosDisponibles.Rows)
                {
                    if (this.familiaUsuariosDB.Any(fu => fu.id == (int)fila.Cells[0].Value))
                    {
                        famUsu_BE.id_usuario = (int)fila.Cells[0].Value;
                        famUsu_BE.id_familia = (int)familia_seleccionada.Cells[0].Value;
                        famUsu_BLL.Delete(famUsu_BE);
                    }
                }

                //PASO 3: Mensaje al usuario y volver atrás
                MessageBox.Show("Familia modificado con éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Se debe completar el campo Descripcion");
            }
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
            if (validarUsoPatentesPatSeleccionadas())
            {
            foreach (DataGridViewRow fila in dgv_patentesAsociadasAfamilia.SelectedRows)
            {
                //Patentes disponibles (+)
                dgv_patentesDisponibles.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value);
                //Patentes asociadas (-)
                dgv_patentesAsociadasAfamilia.Rows.RemoveAt(fila.Index);
            }
            }
            else
            {
                MessageBox.Show("La operación no se puede realizar ya que viola la regla de verificación de uso de patente");
            }
        }

        private void Btn_AsociarUsuario_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv_UsuariosDisponibles.SelectedRows)
            {
                //Usuarios asociadas (+)
                dgv_UsuariosAsociadosAfamilia.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value, fila.Cells[3].Value, fila.Cells[4].Value);
                //Usuarios disponibles (-)
                dgv_UsuariosDisponibles.Rows.RemoveAt(fila.Index);
            }
        }

        private void btn_DesasociarUsuario_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv_UsuariosAsociadosAfamilia.SelectedRows)
            {
                //Usuarios disponibles (+)
                dgv_UsuariosDisponibles.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value, fila.Cells[3].Value, fila.Cells[4].Value);
                //Usuarios asociadas (-)
                dgv_UsuariosAsociadosAfamilia.Rows.RemoveAt(fila.Index);
            }
        }

        ////private bool validarUsoFamiliasSeleccionadas()
        ////{
        ////    /*
        ////     * VALIDAR REGLA DE USO DE PATENTES
        ////     * Solo para las que el usuario ya tenía asignadas en la DB y fueron seleccionadas
        ////     */

        ////    bool validacionUsoPatente = false;
        ////    List<BE.Patente> patSeleccionadasAvalidar = new List<BE.Patente>();


        ////    foreach (DataGridViewRow fila in dgv_patentesAsociadas.SelectedRows)
        ////    {
        ////        if (this.patentesUsuarioDB.Any(pu => pu.id == (int)fila.Cells[0].Value))
        ////        {
        ////            BE.Patente patSeleccionada = (BE.Patente)this.patentesUsuarioDB.Where(pu => pu.id == (int)fila.Cells[0].Value).FirstOrDefault();
        ////            patSeleccionadasAvalidar.Add(patSeleccionada);
        ////        }
        ////    }

        ////    if (BLL.Services.VerificarUsoPatente((int)usuario_seleccionado.Cells[0].Value, patSeleccionadasAvalidar) != 0)
        ////    {
        ////        validacionUsoPatente = true;
        ////    }

        ////    return validacionUsoPatente;
        ////}

        private bool validarUsoPatentesPatSeleccionadas()
        {
            /*
             * VALIDAR REGLA DE USO DE PATENTES
             * Solo para las patentes que la familia ya tenía asignadas en la DB y fueron seleccionadas
             */

            bool validacionUsoPatente = false;

            //1) Patentes seleccionadas a validar
            List<BE.Patente> patSeleccionadasAValidar = new List<BE.Patente>();
            foreach (DataGridViewRow fila in dgv_patentesAsociadasAfamilia.SelectedRows)
            {
                if (this.familiaPatentesDB.Any(fp => fp.id == (int)fila.Cells[0].Value))
                {
                    BE.Patente patSeleccionada = (BE.Patente)this.familiaPatentesDB.Where(fu => fu.id == (int)fila.Cells[0].Value).FirstOrDefault();
                    if (patSeleccionada.activo)
                    {
                        patSeleccionadasAValidar.Add(patSeleccionada);
                    }
                }
            }

            //2) Patentes de la familia a validar
            List<BE.Patente> patentesAvalidar = new List<BE.Patente>();
            foreach (BE.Patente pat in famPat_BLL.GetPatentesFamilia((int)familia_seleccionada.Cells[0].Value))
            {
                if (!patentesAvalidar.Any(p => p.id == pat.id))
                {
                    patentesAvalidar.Add(pat);
                }
            }


            //3) Validacion de la regla de uso de las patentes
            if (BLL.Services.VerificarUsoPatente(patentesAvalidar) != 0)
            {
                validacionUsoPatente = true;
            }

            return validacionUsoPatente;
        }
    }
}
