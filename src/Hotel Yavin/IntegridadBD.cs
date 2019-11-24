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
    public partial class IntegridadBD : Form
    {
        public List<string> lista { get; set; }
        BLL.Bitacora.ALTA bitacora_ALTA = new BLL.Bitacora.ALTA();
        BE.Usuario usuario_logueado = new BE.Usuario();

        public IntegridadBD()
        {
            InitializeComponent();
        }

        public IntegridadBD(List<string> listaErrores, BE.Usuario usu_logueado)
        {
            //lst_Errores.DataSource = null;
            this.lista = listaErrores;
            this.usuario_logueado = usu_logueado;
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
            try
            {
                this.RecalcularDigitosUsuario();
                this.RecalcularDigitosBitacora();
                this.RecalcularDigitosFamiliaPatente();
                this.RecalcularDigitosUsuarioPatente();
                this.RecalcularDigitosReserva();
                this.RecalcularDigitosCliente();
                
                MessageBox.Show("Se recalcularon los dígitos correctamente");
                bitacora_ALTA.RegistrarEnBitacora(this.usuario_logueado, DateTime.Now, "Se recalcularon los Digitos Verificadores");
                Log_In login = new Log_In();
                login.Show();
                this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }

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
        }

        private void RecalcularDigitosFamiliaPatente()
        {
            //RECALCULO DVH Y DVV DE LA TABLA FAMILIAPATENTE
            BLL.FamiliaPatente famPat_BLL = new BLL.FamiliaPatente();
            BE.FamiliaPatente famPat_BE = new BE.FamiliaPatente();
            List<BE.FamiliaPatente> lista_famPat = new List<BE.FamiliaPatente>();
            lista_famPat = famPat_BLL.SelectAll();
            string cadena = "";
            foreach (BE.FamiliaPatente item in lista_famPat)
            {
                cadena = item.id_Patente.ToString() + item.id_Familia.ToString();
                int valorDVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadena);
                famPat_BLL.UpdateDVH(valorDVH, item.id_Patente, item.id_Familia);
            }

            BLL.DigitoVerificador.CalcularDVV("FamiliaPatente");
        }

        private void RecalcularDigitosUsuarioPatente()
        {
            //RECALCULO DVH Y DVV DE LA TABLA FAMILIAPATENTE
            BLL.UsuarioPatente usuPat_BLL = new BLL.UsuarioPatente();
            BE.UsuarioPatente usuPat_BE = new BE.UsuarioPatente();
            List<BE.UsuarioPatente> lista_usuPat = new List<BE.UsuarioPatente>();
            lista_usuPat = usuPat_BLL.SelectAll();
            string cadena = "";
            foreach (BE.UsuarioPatente item in lista_usuPat)
            {
                cadena = item.id_patente.ToString() + item.id_usuario.ToString() + item.patenteNegada.ToString();
                int valorDVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadena);
                usuPat_BLL.UpdateDVH(valorDVH, item.id_patente, item.id_usuario);
            }

            BLL.DigitoVerificador.CalcularDVV("UsuarioPatente");
        }

        private void RecalcularDigitosReserva()
        {
            //RECALCULO DVH Y DVV DE LA TABLA RESERVA
            BLL.Reserva reserva_BLL = new BLL.Reserva();
            BE.Reserva reserva_BE = new BE.Reserva();
            List<BE.Reserva> lista_reserva = new List<BE.Reserva>();
            lista_reserva = reserva_BLL.SelectAll();
            string cadena = "";
            foreach (BE.Reserva item in lista_reserva)
            {
                cadena = item.id_usuario.ToString() + item.id_cliente.ToString() + item.id_habitacion.ToString() + item.activo.ToString() + item.fecha_ingreso.ToString() + item.fecha_salida.ToString();
                int valorDVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadena);
                reserva_BLL.UpdateDVH(valorDVH, item.id_reserva);
            }

            BLL.DigitoVerificador.CalcularDVV("Reserva");
        }

        private void RecalcularDigitosCliente()
        {
            //RECALCULO DVH Y DVV DE LA TABLA CLIENTE
            BLL.Cliente cliente_BLL = new BLL.Cliente();
            BE.Cliente cliente_BE = new BE.Cliente();
            List<BE.Cliente> lista_cliente = new List<BE.Cliente>();
            lista_cliente = cliente_BLL.SelectAll();
            string cadena = "";
            foreach (BE.Cliente item in lista_cliente)
            {
                cadena = item.activo.ToString() + item.nombre.ToString() + item.apellido.ToString() + item.documento.ToString() + item.telefono.ToString() + item.email.ToString();
                int valorDVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadena);
                cliente_BLL.UpdateDVH(valorDVH, item.id_cliente);
            }

            BLL.DigitoVerificador.CalcularDVV("Cliente");
        }
    }
}
