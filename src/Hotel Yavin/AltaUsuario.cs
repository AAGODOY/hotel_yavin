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
using System.IO;
using Microsoft.VisualBasic;

namespace Hotel_Yavin
{
    public partial class AltaUsuario : Form
    {
        BE.Usuario usuario_logueado = new BE.Usuario();
        BE.Usuario usu_BE = new BE.Usuario();
        BLL.Usuario usu_BLL = new BLL.Usuario();
        BLL.Patente pat_BLL = new BLL.Patente();
        BE.UsuarioPatente usuPat_BE = new BE.UsuarioPatente();
        BLL.UsuarioPatente usuPat_BLL = new BLL.UsuarioPatente();
        BLL.Familia familia_BLL = new BLL.Familia();
        BE.FamiliaUsuario famUsu_BE = new BE.FamiliaUsuario();
        BLL.FamiliaUsuario famUsu_BLL = new BLL.FamiliaUsuario();
        BLL.Bitacora.BAJA bitacora_BAJA = new BLL.Bitacora.BAJA(); 

        public AltaUsuario()
        {
            InitializeComponent();
        }

        public AltaUsuario(BE.Usuario usu_logueado)
        {
            InitializeComponent();
            this.usuario_logueado = usu_logueado;
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

            //DataGridView Patentes disponibles
            dgv_patentesDisponibles.DataSource = null;
            dgv_patentesDisponibles.Columns.Add("id", "Id");
            dgv_patentesDisponibles.Columns.Add("descripcion", "Descripción");
            //DataGridView Patentes asociadas
            dgv_patentesAsociadas.DataSource = null;
            dgv_patentesAsociadas.Columns.Add("id", "Id");
            dgv_patentesAsociadas.Columns.Add("descripcion", "Descripción");
            dgv_patentesAsociadas.Columns.Add("negada", "Negada");
            //DataGridView Familias disponibles
            dgv_FamiliasDisponibles.DataSource = null;
            dgv_FamiliasDisponibles.Columns.Add("id", "Id");
            dgv_FamiliasDisponibles.Columns.Add("descripcion", "Descripción");
            //DataGridView Familias asociadas
            dgv_FamiliasAsociadas.DataSource = null;
            dgv_FamiliasAsociadas.Columns.Add("id", "Id");
            dgv_FamiliasAsociadas.Columns.Add("descripcion", "Descripcion");

            //Configuracion de Idioma
            switch (BE.ConfigUsuario.idioma.descripcion)
            {
                case "ES":
                    dgv_patentesDisponibles.Columns[1].HeaderText = BLL.ConfigUsuario.Texto(47);
                    dgv_FamiliasDisponibles.Columns[1].HeaderText = BLL.ConfigUsuario.Texto(47);
                    dgv_FamiliasAsociadas.Columns[1].HeaderText = BLL.ConfigUsuario.Texto(47);
                    dgv_patentesAsociadas.Columns[1].HeaderText = BLL.ConfigUsuario.Texto(47);
                    dgv_patentesAsociadas.Columns[2].HeaderText = BLL.ConfigUsuario.Texto(49);
                    this.Text = BLL.ConfigUsuario.Texto(51);
                    tabPage1.Text = BLL.ConfigUsuario.Texto(53);
                    tabPage3.Text = BLL.ConfigUsuario.Texto(55);
                    tabPage4.Text = BLL.ConfigUsuario.Texto(57);                
                    lbl_NomUsu.Text = BLL.ConfigUsuario.Texto(59);
                    lbl_Nombre.Text = BLL.ConfigUsuario.Texto(61);
                    lbl_Apellido.Text = BLL.ConfigUsuario.Texto(63);
                    lbl_NumDoc.Text = BLL.ConfigUsuario.Texto(65);
                    lbl_Telefono.Text = BLL.ConfigUsuario.Texto(67);
                    lbl_Domicilio.Text = BLL.ConfigUsuario.Texto(69);
                    lbl_familiasDisponibles.Text = BLL.ConfigUsuario.Texto(72);
                    lbl_FamiliasAsociadas.Text = BLL.ConfigUsuario.Texto(74);
                    lbl_PatentesDisponibles.Text = BLL.ConfigUsuario.Texto(76);
                    lbl_PatentesAsociadas.Text = BLL.ConfigUsuario.Texto(78);
                    btn_Negar.Text = BLL.ConfigUsuario.Texto(80);
                    break;
                case "EN":
                    dgv_patentesDisponibles.Columns[1].HeaderText = BLL.ConfigUsuario.Texto(48);
                    dgv_FamiliasDisponibles.Columns[1].HeaderText = BLL.ConfigUsuario.Texto(48);
                    dgv_FamiliasAsociadas.Columns[1].HeaderText = BLL.ConfigUsuario.Texto(48);
                    dgv_patentesAsociadas.Columns[1].HeaderText = BLL.ConfigUsuario.Texto(48);
                    dgv_patentesAsociadas.Columns[2].HeaderText = BLL.ConfigUsuario.Texto(50);
                    this.Text = BLL.ConfigUsuario.Texto(52);
                    tabPage1.Text = BLL.ConfigUsuario.Texto(54);
                    tabPage3.Text = BLL.ConfigUsuario.Texto(56);
                    tabPage4.Text = BLL.ConfigUsuario.Texto(58);
                    lbl_NomUsu.Text = BLL.ConfigUsuario.Texto(60);
                    lbl_Nombre.Text = BLL.ConfigUsuario.Texto(62);
                    lbl_Apellido.Text = BLL.ConfigUsuario.Texto(64);
                    lbl_NumDoc.Text = BLL.ConfigUsuario.Texto(66);
                    lbl_Telefono.Text = BLL.ConfigUsuario.Texto(68);
                    lbl_Domicilio.Text = BLL.ConfigUsuario.Texto(71);
                    lbl_familiasDisponibles.Text = BLL.ConfigUsuario.Texto(73);
                    lbl_FamiliasAsociadas.Text = BLL.ConfigUsuario.Texto(75);
                    lbl_PatentesDisponibles.Text = BLL.ConfigUsuario.Texto(77);
                    lbl_PatentesAsociadas.Text = BLL.ConfigUsuario.Texto(79);
                    btn_Negar.Text = BLL.ConfigUsuario.Texto(81);
                    break;
            }

            ActualizarGrillas();
        }

        public void ActualizarGrillas()
        {
            dgv_FamiliasDisponibles.DataSource = null;
            dgv_patentesDisponibles.DataSource = null;

            foreach (BE.Patente patente in pat_BLL.SelectAll())
            {
                dgv_patentesDisponibles.Rows.Add(patente.id, patente.descripcion, patente.activo);
            }

            foreach (BE.Familia familia in familia_BLL.SelectAll())
            {
                dgv_FamiliasDisponibles.Rows.Add(familia.id, UTILITIES.Encriptador.Desencriptar(familia.descripcion), familia.activo);
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
            if (txt_NomUsu.Text != "" && txt_Nombre.Text != "" && txt_Apellido.Text != "" && txt_NumDoc != null && txt_Email.Text != "" && txt_Telefono.Text != "" && txt_Domicilio.Text != "")
            {
                usu_BE.nom_usuario = txt_NomUsu.Text;
                usu_BE.nombre = txt_Nombre.Text;
                usu_BE.apellido = txt_Apellido.Text;
                usu_BE.documento = int.Parse(txt_NumDoc.Text);
                usu_BE.email = txt_Email.Text;
                usu_BE.telefono = txt_Telefono.Text;
                usu_BE.domicilio = txt_Domicilio.Text;

                int idUsuario = usu_BLL.Add(usu_BE);
                bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se creó de Usuario");

                //PASO 2: Asociación de patentes a usuario
                foreach (DataGridViewRow fila in dgv_patentesAsociadas.Rows)
                {
                    usuPat_BE.id_patente = (int)fila.Cells[0].Value;
                    usuPat_BE.id_usuario = idUsuario;
                    usuPat_BE.patenteNegada = (bool)fila.Cells[2].Value;
                    usuPat_BLL.Add(usuPat_BE);
                    bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se asignó una patente a un usuario");
                }

                foreach (DataGridViewRow fila in dgv_FamiliasAsociadas.Rows)
                {
                    famUsu_BE.id_usuario = idUsuario;
                    famUsu_BE.id_familia = (int)fila.Cells[0].Value;
                    famUsu_BLL.Add(famUsu_BE);
                    bitacora_BAJA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se asignó una familia a un usuario");
                }

                //PASO3: Guardar contraseña en txt
                SaveFileDialog savefileDialog = new SaveFileDialog();
                savefileDialog.ShowDialog();
                FileStream F = File.Create(savefileDialog.FileName);
                F.Close();
                StreamWriter sw = File.AppendText(savefileDialog.FileName);
                sw.WriteLine("Se creó su usuario " + txt_NomUsu.Text + " con la nueva contraseña: " + usu_BLL.GetContraseña(idUsuario));
                sw.Close();

                MessageBox.Show("Se envió la contraseña al mail del usuario");


                //PASO 4: Mensaje al usuario y volver atrás
                MessageBox.Show("Usuario generado con éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos de la pestaña principal");
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

        //CONDICION: para controlar el estado del botón negar
        private void Dgv_patentesAsociadas_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_patentesAsociadas.SelectedRows.Count >= 1)
            {
                this.btn_Negar.Enabled = true;
            }
        }

        private void btn_AsociarFamilia_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv_FamiliasDisponibles.SelectedRows)
            {
                //Familias asociadas (+)
                dgv_FamiliasAsociadas.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value);
                //Familias disponibles (-)
                dgv_FamiliasDisponibles.Rows.RemoveAt(fila.Index);
            }
        }

        private void btn_DesasociarFamilia_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv_FamiliasAsociadas.SelectedRows)
            {
                //Familias disponibles (+)
                dgv_FamiliasDisponibles.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value);
                //Familias asociadas (-)
                dgv_FamiliasAsociadas.Rows.RemoveAt(fila.Index);
            }
        }

        private void txt_NumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida que se ingresen unicamente valores numericos
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;

            //no te permite ingresar mas del máximo
            txt_NumDoc.MaxLength = 8;
        }
    }
}
