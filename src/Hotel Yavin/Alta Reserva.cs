using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Hotel_Yavin
{
    public partial class Reserva : Form
    {
        BE.Usuario usuario_logueado = new BE.Usuario();
        BLL.Cliente cliente_BLL = new BLL.Cliente();
        BLL.Habitacion habitacion_BLL = new BLL.Habitacion();
        BLL.ServAdicional servicios_BLL = new BLL.ServAdicional();
        BLL.Huesped huesped_BLL = new BLL.Huesped();
        BE.Reserva reserva_BE = new BE.Reserva();
        BLL.Reserva reserva_BLL = new BLL.Reserva();
        BE.ServAdicionalReserva servAdicionalReserva_BE = new BE.ServAdicionalReserva();
        BLL.ServAdicionalReserva servAdicionalReserva_BLL = new BLL.ServAdicionalReserva();

        public Reserva(BE.Usuario usu)
        {
            InitializeComponent();
            this.lbl_errorCliente.Visible = false;
            this.lbl_errorHabitacion.Visible = false;
            this.usuario_logueado = usu;
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
            this.ActualizarGrilla();
        }

        private void CargarDatos()
        {
            //CARGA DE CLIENTES
            List<BE.Cliente> clientes = new List<BE.Cliente>();
            clientes = cliente_BLL.SelectAll();
            cmb_Cliente.Items.Add("Seleccionar");
            foreach (BE.Cliente cliente in clientes)
            {
                cmb_Cliente.Items.Add(cliente.id_cliente + " " + cliente.nombre + " " + cliente.apellido);
            }

            cmb_Cliente.SelectedIndex = 0;

            //CARGA DE HABITACIONES
            List<BE.Habitacion> habitaciones = new List<BE.Habitacion>();
            habitaciones = habitacion_BLL.SelectAll();
            foreach (BE.Habitacion habitacion in habitaciones)
            {
                clb_habitaciones.Items.Add(habitacion.id_habitacion + " " + habitacion.tipo_habitacion + " " + habitacion.descripcion);
            }

            //CARGA DE SERVICIOS ADICIONALES
            List<BE.ServAdicional> servicios = new List<BE.ServAdicional>();
            servicios = servicios_BLL.SelectAll();
            foreach (BE.ServAdicional servicio in servicios)
            {
               clb_servicios.Items.Add(servicio.id_servicio + " " + servicio.descripcion);
            }
        }

        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = huesped_BLL.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaHuesped huespedes = new AltaHuesped();
            huespedes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarHuesped mod_huesped = new ModificarHuesped();
            mod_huesped.Show();
        }

        private void btn_GuardarReserva_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                //Usuario
                reserva_BE.id_usuario = this.usuario_logueado.id;

                //Cliente
                reserva_BE.id_cliente = int.Parse(Regex.Match(cmb_Cliente.SelectedItem.ToString(), @"\d+").Value);

                //Habitacion
                reserva_BE.id_habitacion = int.Parse(Regex.Match(clb_habitaciones.SelectedItem.ToString(), @"\d+").Value);

                //Fechas
                reserva_BE.fecha_ingreso = Convert.ToDateTime(dtpIngreso.Value.Date);
                reserva_BE.fecha_salida = Convert.ToDateTime(dtpSalida.Value.Date);

                int id_NuevaReserva = reserva_BLL.Add(reserva_BE);

                MessageBox.Show("Se creó correctamente la reserva");

                //Servicios Adicionales
                if (clb_servicios.CheckedItems.Count >= 1)
                {
                    foreach (string item in clb_servicios.CheckedItems)
                    {
                        servAdicionalReserva_BE.id_servicio = int.Parse(Regex.Match(item.ToString(), @"\d+").Value);
                        servAdicionalReserva_BE.id_reserva = id_NuevaReserva;
                        servAdicionalReserva_BLL.Add(servAdicionalReserva_BE);
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Validar campos");
            }       
        }

        private bool validarCampos()
        {
            bool validacion = true;

            if (cmb_Cliente.SelectedItem == "Seleccionar")
            {
                this.lbl_errorCliente.Visible = true;
                validacion = false;
            }

            if (clb_habitaciones.CheckedItems.Count != 1)
            {
                this.lbl_errorHabitacion.Visible = true;
                validacion = false;
            }

            return validacion;
        }

        private void btn_CancelarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
