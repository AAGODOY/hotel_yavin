﻿using System;
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
    public partial class IntegridadBD : Form
    {
        public List<string> lista { get; set; }

        public IntegridadBD()
        {
            InitializeComponent();
        }

        public IntegridadBD(List<string> listaErrores)
        {
            //lst_Errores.DataSource = null;
            lista = listaErrores;
            InitializeComponent();
            //lst_Errores.Items.Add(listaErrores);
        }

        private void IntegridadBD_Load(object sender, EventArgs e)
        {
            lst_Errores.DataSource = null;
            lst_Errores.DataSource = lista;

            button1.Enabled = BLL.ConfigUsuario.ValidarAcceso("Recalcular Dígitos Verificadores");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RecalcularDigitosUsuario();
            this.RecalcularDigitosBitacora();
        }

        private void RecalcularDigitosUsuario()
        {
            //RECALCULO DVH Y DVV DE LA TABLA USUARIO
            BLL.Usuario usu_BLL = new BLL.Usuario();
            BE.Usuario usu_BE = new BE.Usuario();
            List<BE.Usuario> lista_usu = new List<BE.Usuario>();
            lista_usu = usu_BLL.SelectAll();
            foreach (BE.Usuario item in lista_usu)
            {
                string cadena = item.activo.ToString() + item.nom_usuario + item.nombre + item.apellido + item.documento.ToString() + item.domicilio + item.telefono + item.email + item.contraseña + item.cant_ingresos_incorrectos.ToString() + item.es_primer_login.ToString() + item.id_idioma.ToString();
                int valorDVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadena);
                usu_BLL.UpdateDVH(valorDVH, item.id);
            }

            BLL.DigitoVerificador.CalcularDVV("Usuario");
            MessageBox.Show("Se recalcularon los dígitos correctamente");
            this.Close();
        }

        private void RecalcularDigitosBitacora()
        {
            //RECALCULO DVH Y DVV DE LA TABLA BITACORA
            BLL.Bitacora.BAJA bitacora_BLL = new BLL.Bitacora.BAJA();
            BE.Bitacora bitacora_BE = new BE.Bitacora();
            List<BE.Bitacora> lista_bitacora = new List<BE.Bitacora>();
            lista_bitacora = bitacora_BLL.SelectAll();
            string cadena = "";
            foreach (BE.Bitacora item in lista_bitacora)
            {
                cadena = item.id_usuario.ToString() + item.nombre_usuario.ToString() + item.fecha.ToString("yyyy-MM-dd HH:mm:ss") + item.criticidad.ToString() + item.descripcion.ToString();
                int valorDVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadena);
                bitacora_BLL.UpdateDVH(valorDVH, item.id_log);
            }

            BLL.DigitoVerificador.CalcularDVV("Bitacora");
            MessageBox.Show("Se recalcularon los dígitos correctamente");
            this.Close();
        }
    }
}
