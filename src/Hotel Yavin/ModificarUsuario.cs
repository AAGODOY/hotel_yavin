using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hotel_Yavin
{
    public partial class ModificarUsuario : Form
    {
        BE.Usuario usuario_logueado = new BE.Usuario();
        BE.Usuario usu_BE = new BE.Usuario();
        DataGridViewRow usuario_seleccionado = new DataGridViewRow();
        BLL.Usuario usu_BLL = new BLL.Usuario();
        BLL.UsuarioPatente usuPat_BLL = new BLL.UsuarioPatente();
        BE.UsuarioPatente usuPat_BE = new BE.UsuarioPatente();
        BLL.Familia fam_BLL = new BLL.Familia();
        BLL.FamiliaUsuario famUsu_BLL = new BLL.FamiliaUsuario();
        BE.FamiliaUsuario famUsu_BE = new BE.FamiliaUsuario();
        BLL.FamiliaPatente famPat_BLL = new BLL.FamiliaPatente();
        BLL.Patente pat_BLL = new BLL.Patente();
        BLL.Bitacora.BAJA bitacora_BAJA = new BLL.Bitacora.BAJA();
        //Asignaciones del usuario en DB
        List<BE.Familia> familiasUsuarioDB = new List<BE.Familia>();
        List<BE.Patente> patentesUsuarioDB = new List<BE.Patente>();

        public ModificarUsuario()
        {
            InitializeComponent();
        }

        public ModificarUsuario(DataGridViewRow usuario, BE.Usuario usu_logueado)
        {
            InitializeComponent();
            this.usuario_logueado = usu_logueado;
            ConfigurarGrilla();
            usuario_seleccionado = usuario;
            RetornarDatos();
        }

        private void btn_CancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            btn_BlanquearPass.Enabled = BLL.ConfigUsuario.ValidarAcceso("Blanquear Constraseña");
        }

        private void ConfigurarGrilla()
        {
            //DataGridView Patentes disponibles
            dgv_patentesDisponibles.DataSource = null;
            dgv_patentesDisponibles.Columns.Add("id", "Id");
            dgv_patentesDisponibles.Columns.Add("descripcion", "Descripción");
            dgv_patentesDisponibles.Columns.Add("activo", "activo");
            //dgv_patentesDisponibles.Columns[0].Visible = false;
            //DataGridView Patentes asociadas
            dgv_patentesAsociadas.DataSource = null;
            dgv_patentesAsociadas.Columns.Add("id", "Id");
            dgv_patentesAsociadas.Columns.Add("descripcion", "Descripción");
            dgv_patentesAsociadas.Columns.Add("activo", "Activo");
            dgv_patentesAsociadas.Columns.Add("negada", "Negada");
            //dgv_patentesAsociadas.Columns[0].Visible = false;
            //DataGridView Familias disponibles
            dgv_familiasDisponibles.DataSource = null;
            dgv_familiasDisponibles.Columns.Add("id", "Id");
            dgv_familiasDisponibles.Columns.Add("descripcion", "Descripción");
            dgv_familiasDisponibles.Columns.Add("activo", "Activo");
            //dgv_familiasDisponibles.Columns[0].Visible = false;
            //DataGridView Familias asociadas
            dgv_familiasAsociadas.DataSource = null;
            dgv_familiasAsociadas.Columns.Add("id", "Id");
            dgv_familiasAsociadas.Columns.Add("descripcion", "Descripcion");
            dgv_familiasAsociadas.Columns.Add("activo", "Activo");
            //dgv_familiasAsociadas.Columns[0].Visible = false;
        }

        private void RetornarDatos()
        {
            //Carga pestaña principal
            txt_NomUsu.Text = usuario_seleccionado.Cells[2].Value.ToString();
            txt_Nombre.Text = usuario_seleccionado.Cells[3].Value.ToString();
            txt_Apellido.Text = usuario_seleccionado.Cells[4].Value.ToString();
            txt_NumDoc.Text = usuario_seleccionado.Cells[5].Value.ToString();
            txt_Domicilio.Text = usuario_seleccionado.Cells[6].Value.ToString();
            txt_Telefono.Text = usuario_seleccionado.Cells[7].Value.ToString();
            txt_Email.Text = usuario_seleccionado.Cells[8].Value.ToString();

            //Carga grillas de Familias
            cargarGrillaFamilias(Convert.ToInt32(usuario_seleccionado.Cells[0].Value));

            //Carga grillas de Patentes
            cargarGrillaPatentes(Convert.ToInt32(usuario_seleccionado.Cells[0].Value));
        }

        private void cargarGrillaFamilias(int id_usuario)
        {
            dgv_familiasDisponibles.DataSource = null;
            dgv_familiasAsociadas.DataSource = null;

            //CARGAR: familias asociadas
            this.familiasUsuarioDB = famUsu_BLL.GetFamilias(id_usuario);

            foreach (BE.Familia familia in familiasUsuarioDB)
            {
                dgv_familiasAsociadas.Rows.Add(familia.id, UTILITIES.Encriptador.Desencriptar(familia.descripcion), familia.activo);
            }

            //CARGAR: familias disponibles
            List<BE.Familia> familiasUI = new List<BE.Familia>();
            List<BE.Familia> familiasDB = fam_BLL.SelectAll();
            foreach (BE.Familia famDB in fam_BLL.SelectAll())
            {
                //(!) Validar si la familia ya no fue agregada
                if (!familiasUI.Any(f => f.id == famDB.id))
                {
                    //(!) Validar que la familia a agregar no la tenga el usuario
                    if (!familiasUsuarioDB.Any(f => f.id == famDB.id))
                    {
                        familiasUI.Add(famDB);
                    }
                }
            }

            foreach (BE.Familia familia in familiasUI)
            {
                dgv_familiasDisponibles.Rows.Add(familia.id, UTILITIES.Encriptador.Desencriptar(familia.descripcion), familia.activo);
            }
        }

        private void cargarGrillaPatentes(int id_usuario)
        {
            dgv_patentesDisponibles.DataSource = null;
            dgv_patentesAsociadas.DataSource = null;

            //CARGAR: patentes asociadas
            this.patentesUsuarioDB = usuPat_BLL.GetPatentesIndividuales(id_usuario);
            foreach (BE.Patente patente in patentesUsuarioDB)
            {
                dgv_patentesAsociadas.Rows.Add(patente.id, UTILITIES.Encriptador.Desencriptar(patente.descripcion), patente.activo, usuPat_BLL.GetUsuarioPatente(id_usuario, patente.id).patenteNegada);
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
                    if (!patentesUsuarioDB.Any(f => f.id == patDB.id))
                    {
                        patentesUI.Add(patDB);
                    }
                }
            }

            foreach (BE.Patente patente in patentesUI)
            {
                dgv_patentesDisponibles.Rows.Add(patente.id, UTILITIES.Encriptador.Desencriptar(patente.descripcion), patente.activo);
            }
        }

        private void btn_GuardarUsuario_Click(object sender, EventArgs e)
        {
            if (txt_NomUsu.Text != "" && txt_Nombre.Text != "" && txt_Apellido.Text != "" && txt_NumDoc != null && txt_Email.Text != "" && txt_Telefono.Text != "" && txt_Domicilio.Text != "")
            {
                usu_BE.id = Convert.ToInt32(usuario_seleccionado.Cells[0].Value);
                usu_BE.activo = Convert.ToBoolean(usuario_seleccionado.Cells[1].Value);
                usu_BE.nom_usuario = txt_NomUsu.Text;
                usu_BE.nombre = txt_Nombre.Text;
                usu_BE.apellido = txt_Apellido.Text;
                usu_BE.documento = int.Parse(txt_NumDoc.Text);
                usu_BE.email = txt_Email.Text;
                usu_BE.telefono = txt_Telefono.Text;
                usu_BE.domicilio = txt_Domicilio.Text;
                usu_BE.contraseña = Convert.ToString(usuario_seleccionado.Cells[9].Value);
                usu_BE.cant_ingresos_incorrectos = Convert.ToInt32(usuario_seleccionado.Cells[10].Value);
                usu_BE.DVH = Convert.ToInt32(usuario_seleccionado.Cells[11].Value);
                usu_BE.es_primer_login = Convert.ToBoolean(usuario_seleccionado.Cells[12].Value);
                usu_BE.id_idioma = Convert.ToInt32(usuario_seleccionado.Cells[13].Value);

                usu_BLL.Update(usu_BE);

                //PASO 2 parte 1: Asociacion de patentes a usuario
                foreach (DataGridViewRow fila in dgv_patentesAsociadas.Rows)
                {
                    if (!this.patentesUsuarioDB.Any(pu => pu.id == (int)fila.Cells[0].Value))
                    {
                        usuPat_BE.id_patente = (int)fila.Cells[0].Value;
                        usuPat_BE.id_usuario = (int)usuario_seleccionado.Cells[0].Value;
                        usuPat_BE.patenteNegada = (bool)fila.Cells[3].Value;
                        usuPat_BLL.Add(usuPat_BE);
                        bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se asignó una patente a un usuario");
                    }
                }

                //PASO 2 parte 2: Desasociacion de patente a usuario
                foreach (DataGridViewRow fila in dgv_patentesDisponibles.Rows)
                {
                    if (this.patentesUsuarioDB.Any(pu => pu.id == (int)fila.Cells[0].Value))
                    {
                        usuPat_BE.id_patente = (int)fila.Cells[0].Value;
                        usuPat_BE.id_usuario = (int)usuario_seleccionado.Cells[0].Value;
                        usuPat_BLL.Delete(usuPat_BE);
                    }
                }

                //PASO 2 parte 3: Negar patente a un usuario
                foreach (DataGridViewRow fila in dgv_patentesAsociadas.Rows)
                {
                    BE.UsuarioPatente usuarioPatente = new BE.UsuarioPatente();
                    usuarioPatente = usuPat_BLL.GetUsuarioPatente((int)usuario_seleccionado.Cells[0].Value, (int)fila.Cells[0].Value);

                    if ((bool)fila.Cells[3].Value != usuarioPatente.patenteNegada)
                    {
                        usuPat_BE.id_patente = (int)fila.Cells[0].Value;
                        usuPat_BE.id_usuario = (int)usuario_seleccionado.Cells[0].Value;
                        usuPat_BE.patenteNegada = (bool)fila.Cells[3].Value;
                        usuPat_BLL.Update(usuPat_BE);
                        bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se negó una patente a un usuario");
                    }
                }

                //PASO 3 parte 1: Asociacion de familia a Usuario
                foreach (DataGridViewRow fila in dgv_familiasAsociadas.Rows)
                {
                    if (!this.familiasUsuarioDB.Any(fu => fu.id == (int)fila.Cells[0].Value))
                    {
                        famUsu_BE.id_usuario = (int)usuario_seleccionado.Cells[0].Value;
                        famUsu_BE.id_familia = (int)fila.Cells[0].Value;
                        famUsu_BLL.Add(famUsu_BE);
                        bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se asignó una familia a un usuario");
                    }
                }

                //PASO 3 parte 2: Desasociacion de familia a Usuario
                foreach (DataGridViewRow fila in dgv_familiasDisponibles.Rows)
                {
                    if (this.familiasUsuarioDB.Any(fu => fu.id == (int)fila.Cells[0].Value))
                    {
                        famUsu_BE.id_usuario = (int)usuario_seleccionado.Cells[0].Value;
                        famUsu_BE.id_familia = (int)fila.Cells[0].Value;
                        famUsu_BLL.Delete(famUsu_BE);
                        bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se desasignó una familia a un Usuario");
                    }
                }

                //PASO 3: Mensaje al usuario y volver atrás
                MessageBox.Show("Usuario modificado con éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos de la pestaña principal");
            }
        }

        private void txt_NumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida que se ingresen unicamente valores numericos
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;

            //no te permite ingresar mas del máximo
            txt_NumDoc.MaxLength = 8;
        }

        private void btn_AsociarFamilia_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv_familiasDisponibles.SelectedRows)
            {
                //Familias asociadas (+)
                dgv_familiasAsociadas.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value);
                //Familias disponibles (-)
                dgv_familiasDisponibles.Rows.RemoveAt(fila.Index);
            }
        }

        private void btn_DesasociarFamilia_Click(object sender, EventArgs e)
        {
            bool validacion_final = false;
            //¿Se cumple la regla general de patentes?
            if (validarUsoPatentesFamSeleccionadas())
            {
                validacion_final = true;
            }
            //¿Se trata del mismo usuario que tiene la patente asignada de forma directa + en familia?
            else
            {
                if (verificarRepeticionUsuarioPatente())
                    validacion_final = true;
            }

            if (validacion_final)
            {
                foreach (DataGridViewRow fila in dgv_familiasAsociadas.SelectedRows)
                {
                    //Familias disponibles (+)
                    dgv_familiasDisponibles.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value);

                    //Familias asociadas (-)
                    dgv_familiasAsociadas.Rows.RemoveAt(fila.Index);
                }
            }
            else
            {
                MessageBox.Show("La operación no se puede realizar ya que viola la regla de verificación de uso de patente");
            }

            //if (validarUsoPatentesFamSeleccionadas())
            //{
            //    foreach (DataGridViewRow fila in dgv_familiasAsociadas.SelectedRows)
            //    {
            //        //Familias disponibles (+)
            //        dgv_familiasDisponibles.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value);

            //        //Familias asociadas (-)
            //        dgv_familiasAsociadas.Rows.RemoveAt(fila.Index);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("La operación no se puede realizar ya que viola la regla de verificación de uso de patente");
            //}   
        }

        private void btn_AsociarPatente_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv_patentesDisponibles.SelectedRows)
            {
                //Patentes asociadas (+)
                dgv_patentesAsociadas.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value, false);

                //Patentes disponibles (-)
                dgv_patentesDisponibles.Rows.RemoveAt(fila.Index);
            }
        }

        private void btn_DesasociarPatente_Click(object sender, EventArgs e)
        {
            bool validacion_final = false;
            //¿Se cumple la regla general de patentes?
            if (validarUsoPatentesSeleccionadas())
            {
                validacion_final = true;
            }
            //¿Se trata del mismo usuario que tiene la patente asignada de forma directa + en familia?
            else
            {
                if (verificarRepeticionUsuarioPatente())
                    validacion_final = true;
            }

            if (validacion_final)
            {
                foreach (DataGridViewRow fila in dgv_patentesAsociadas.SelectedRows)
                {
                    //Patentes disponibles (+)
                    dgv_patentesDisponibles.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value);

                    //Patentes asociadas (-)
                    dgv_patentesAsociadas.Rows.RemoveAt(fila.Index);
                }
            }
            else
            {
                MessageBox.Show("La operación no se puede realizar ya que viola la regla de verificación de uso de patente");
            }

            //CONDICION UI: inhabilitar botón de negar si no hay patentes asociadas
            if (dgv_patentesAsociadas.Rows.Count < 1)
            {
                this.btn_NegarPatente.Enabled = false;
            }
        }

        private void dgv_patentesAsociadas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_patentesAsociadas.SelectedRows.Count >= 1)
            {
                this.btn_NegarPatente.Enabled = true;
            }
        }

        private void btn_NegarPatente_Click(object sender, EventArgs e)
        {
            //CONDICION: 1 o más patentes asociadas seleccionadas
            if (dgv_patentesAsociadas.SelectedRows.Count >= 1)
            {
                //CONDICION: se debe respetar la regla de uso de patentes
                if (validarUsoPatentesSeleccionadas())
                {
                    foreach (DataGridViewRow fila in dgv_patentesAsociadas.SelectedRows)
                    {
                        if ((bool)fila.Cells[3].Value)
                            fila.Cells[3].Value = false;
                        else
                            fila.Cells[3].Value = true;
                    }
                }
                else
                {
                    MessageBox.Show("La operación no se puede realizar ya que viola la regla de verificación de uso de patente");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una patente asociada para negar");
            }
        }

        private bool validarUsoPatentesSeleccionadas()
        {
            /*
             * VALIDAR REGLA DE USO DE PATENTES
             * Solo para las que el usuario ya tenía asignadas en la DB y fueron seleccionadas
             */

            bool validacionUsoPatente = false;
            List<BE.Patente> patSeleccionadasAvalidar = new List<BE.Patente>();
            

            foreach (DataGridViewRow fila in dgv_patentesAsociadas.SelectedRows)
            {
                if (this.patentesUsuarioDB.Any(pu => pu.id == (int)fila.Cells[0].Value))
                {
                    BE.Patente patSeleccionada = (BE.Patente)this.patentesUsuarioDB.Where(pu => pu.id == (int)fila.Cells[0].Value).FirstOrDefault();
                    patSeleccionadasAvalidar.Add(patSeleccionada);
                }
            }

            if (BLL.Services.VerificarUsoPatente((int)usuario_seleccionado.Cells[0].Value, patSeleccionadasAvalidar, 0) != 0)
            {
                validacionUsoPatente = true;
            }
            
            return validacionUsoPatente;
        }

        private bool validarUsoPatentesFamSeleccionadas()
        {
            /*
             * VALIDAR REGLA DE USO DE PATENTES
             * Solo para las familias que el usuario ya tenía asignadas en la DB y fueron seleccionadas
             */

            bool validacionUsoPatente = false;

            //1) Familias seleccionadas a validar
            List<BE.Familia> famSeleccionadasAValidar = new List<BE.Familia>();
            foreach (DataGridViewRow fila in dgv_familiasAsociadas.SelectedRows)
            {
                if (this.familiasUsuarioDB.Any(fu => fu.id == (int)fila.Cells[0].Value))
                {
                    BE.Familia famSeleccionada = (BE.Familia)this.familiasUsuarioDB.Where(fu => fu.id == (int)fila.Cells[0].Value).FirstOrDefault();
                    if (famSeleccionada.activo)
                    {
                        famSeleccionadasAValidar.Add(famSeleccionada);
                    }
                }
            }

            //2) Patentes de las familias a validar
            List<BE.Patente> patentesAvalidar = new List<BE.Patente>();
            foreach(BE.Familia fam in famSeleccionadasAValidar)
            {
                foreach (BE.Patente pat in famPat_BLL.GetPatentesFamilia(fam.id))
                {
                    if (!patentesAvalidar.Any(p => p.id == pat.id))
                    {
                        patentesAvalidar.Add(pat);
                    }
                }
            }

            //3) Validacion de la regla de uso de las patentes
            if (BLL.Services.VerificarUsoPatente((int)usuario_seleccionado.Cells[0].Value, patentesAvalidar, 0) != 0)
            {
                validacionUsoPatente = true;
            }

            return validacionUsoPatente;
        }

        private bool verificarRepeticionUsuarioPatente()
        {
            /*
             * VERIFICACION REGLA DE USO DE PATENTES
             * Validación extra para confirmar si el usuario tiene asignada x patente individualmente y por familia
             */

            bool validacionRepeticion = false;
            List<BE.Patente> patentesAvalidar = new List<BE.Patente>();

            //CONDICION: validación de repetición al desasociar patentes
            foreach (DataGridViewRow fila in dgv_patentesAsociadas.SelectedRows)
            {
                if (this.patentesUsuarioDB.Any(pu => pu.id == (int)fila.Cells[0].Value))
                {
                    BE.Patente patSeleccionada = (BE.Patente)this.patentesUsuarioDB.Where(pu => pu.id == (int)fila.Cells[0].Value).FirstOrDefault();
                    patentesAvalidar.Add(patSeleccionada);
                }
            }

            //CONDICION: validación de repetición al desasociar familia/s

            //1) Familias seleccionadas a validar
            List<BE.Familia> famSeleccionadasAValidar = new List<BE.Familia>();
            foreach (DataGridViewRow fila in dgv_familiasAsociadas.SelectedRows)
            {
                if (this.familiasUsuarioDB.Any(fu => fu.id == (int)fila.Cells[0].Value))
                {
                    BE.Familia famSeleccionada = (BE.Familia)this.familiasUsuarioDB.Where(fu => fu.id == (int)fila.Cells[0].Value).FirstOrDefault();
                    if (famSeleccionada.activo)
                    {
                        famSeleccionadasAValidar.Add(famSeleccionada);
                    }
                }
            }

            //2) Patentes de las familias a validar
            foreach (BE.Familia fam in famSeleccionadasAValidar)
            {
                foreach (BE.Patente pat in famPat_BLL.GetPatentesFamilia(fam.id))
                {
                    if (!patentesAvalidar.Any(p => p.id == pat.id))
                    {
                        patentesAvalidar.Add(pat);
                    }
                }
            }

            //VALIDACION DE REPETICIÓN
            if (BLL.Services.VerificarAsignacionRepetida((int)usuario_seleccionado.Cells[0].Value, patentesAvalidar))
            {
                validacionRepeticion = true;
            }

            return validacionRepeticion;
        }

        private void btn_BlanquearPass_Click(object sender, EventArgs e)
        {
            usu_BE.id = (int)usuario_seleccionado.Cells[0].Value;
            usu_BLL.BlanquearContraseña(usu_BE);

            SaveFileDialog savefileDialog = new SaveFileDialog();
            savefileDialog.ShowDialog();
            FileStream F = File.Create(savefileDialog.FileName);
            F.Close();
            StreamWriter sw = File.AppendText(savefileDialog.FileName);
            sw.WriteLine("Se blanqueó la contraseña del usuario " + txt_NomUsu.Text + ". Su nueva contraseña es: " + usu_BLL.GetContraseña(usu_BE.id));
            sw.Close();

            MessageBox.Show("Se envió la nueva contraseña al mail del usuario");
        }

    }
}
