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
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            //lst_PatentesDisponibles.DataSource = null;
            //lst_PatentesDisponibles.DataSource = pat_BLL.SelectAll();
            foreach (var patente in pat_BLL.SelectAll())
            {
                lst_PatentesDisponibles.Items.Add(patente);
            }
            lst_PatentesDisponibles.DisplayMember = "descripcion";
        }

        private void lst_GruposAsociados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_DesasociarGrupo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

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
            var items = BLL.Services.GetPropertyValues("ObjectCollection", lst_PatentesAsociadas);
            foreach (BE.Patente item in items)
            {
                usuPat_BE.id_patente = item.id;
                usuPat_BE.id_usuario = idUsuario;
                //foreach (BE.UsuarioPatente patente in btn_Negar_Click(btn_Negar,e))
                //{

                //}
                //usuPat_BLL.Add(usuPat_BE);
            }        
            #endregion
        }

        private void btn_CancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AsociarPatente_Click(object sender, EventArgs e)
        {

            //lst_PatentesAsociadas.DataSource = lst_PatentesDisponibles.SelectedItems;
            foreach(var patente in lst_PatentesDisponibles.SelectedItems)
            {
                lst_PatentesAsociadas.Items.Add(patente);
            }
            lst_PatentesAsociadas.DisplayMember = "descripcion";

            while(lst_PatentesDisponibles.SelectedItems.Count > 0){
                lst_PatentesDisponibles.Items.Remove(lst_PatentesDisponibles.SelectedItem);
            }

        }

        private void btn_Negar_Click(object sender, EventArgs e)
        {
            //var items = BLL.Services.GetPropertyValues("ObjectCollection", lst_PatentesAsociadas.SelectedItems);
            List<BE.UsuarioPatente> usuarioPatente = new List<BE.UsuarioPatente>();
            List<BE.UsuarioPatente> patentesNegadas = new List<BE.UsuarioPatente>();
            List<BE.UsuarioPatente> patentesHabilitadas = new List<BE.UsuarioPatente>();
            for (int i = 0; i < lst_PatentesAsociadas.SelectedItems.Count; i++)
            {
                usuPat_BE.patenteNegada = true;
                patentesNegadas.Add(usuPat_BE);
                usuarioPatente.AddRange(patentesNegadas);
            }

            foreach (BE.Patente item in lst_PatentesAsociadas.Items)
            {
                if (usuPat_BE.patenteNegada != false)
                {
                    usuPat_BE.patenteNegada = false;
                    patentesHabilitadas.Add(usuPat_BE);
                    usuarioPatente.AddRange(patentesHabilitadas);
                }               
            }
        }

    }
}
