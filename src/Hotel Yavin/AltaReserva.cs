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
        BE.Huesped huesped_BE = new BE.Huesped();
        BE.Reserva reserva_BE = new BE.Reserva();
        BLL.Reserva reserva_BLL = new BLL.Reserva();
        BE.ServAdicionalReserva servAdicionalReserva_BE = new BE.ServAdicionalReserva();
        BLL.ServAdicionalReserva servAdicionalReserva_BLL = new BLL.ServAdicionalReserva();
        BE.Cobranza Cobranza_BE = new BE.Cobranza();
        BLL.Cobranza Cobranza_BLL = new BLL.Cobranza();
        int id_NuevaReserva;

        public Reserva()
        {
            InitializeComponent();
        }

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
            this.ConfigurarGrilla();
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

        private void btn_GuardarReserva_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                //Usuario
                reserva_BE.id_usuario = this.usuario_logueado.id;

                //Cliente
                reserva_BE.id_cliente = int.Parse(Regex.Match(cmb_Cliente.SelectedItem.ToString(), @"\d+").Value);

                //Habitacion
                foreach (var itemSeleccionado in clb_habitaciones.CheckedItems)
                {
                    reserva_BE.id_habitacion = int.Parse(Regex.Match(itemSeleccionado.ToString(), @"\d+").Value);
                }

                //Fechas
                reserva_BE.fecha_ingreso = Convert.ToDateTime(dtpIngreso.Value.Date);
                reserva_BE.fecha_salida = Convert.ToDateTime(dtpSalida.Value.Date);

                id_NuevaReserva = reserva_BLL.Add(reserva_BE);
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

                //Huesped
                BE.Huesped huespedAguardar = new BE.Huesped();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    huespedAguardar.id_reserva = id_NuevaReserva;
                    huespedAguardar.nombre = item.Cells[2].Value.ToString();
                    huespedAguardar.apellido = item.Cells[3].Value.ToString();
                    huespedAguardar.documento = (int)item.Cells[4].Value;
                    huespedAguardar.telefono = item.Cells[5].Value.ToString();
                    huespedAguardar.email = item.Cells[6].Value.ToString();

                    huesped_BLL.Add(huespedAguardar);
                }

                //CREO UN REGISTRO EN COBRANZA ASOCIADO A LA RESERVA CREADA
                Cobranza_BE.id_reserva = id_NuevaReserva;
                TimeSpan cant_dias = reserva_BE.fecha_salida.Date - reserva_BE.fecha_ingreso.Date;
                int dias = cant_dias.Days;
                Cobranza_BLL.Add(Cobranza_BE, Convert.ToInt32(dias));

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

            if (cmb_Cliente.SelectedItem.ToString() == "Seleccionar")
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

        public void ObtenerDatosHuesped(BE.Huesped huesped)
        {
            huesped_BE.nombre = huesped.nombre;
            huesped_BE.apellido = huesped.apellido;
            huesped_BE.documento = huesped.documento;
            huesped_BE.telefono = huesped.telefono;
            huesped_BE.email = huesped.email;

            dataGridView1.Rows.Add(huesped_BE.id_huesped, huesped_BE.id_reserva, huesped_BE.nombre, huesped_BE.apellido, huesped_BE.documento, huesped_BE.telefono, huesped_BE.email);
        }

        public void ModificarDatosHuesped(BE.Huesped huesped)
        {
            dataGridView1.CurrentRow.Cells[2].Value = huesped.nombre;
            dataGridView1.CurrentRow.Cells[3].Value = huesped.apellido;
            dataGridView1.CurrentRow.Cells[4].Value = huesped.documento;
            dataGridView1.CurrentRow.Cells[5].Value = huesped.telefono;
            dataGridView1.CurrentRow.Cells[6].Value = huesped.email;
        }
    
        private void ConfigurarGrilla()
        {
            dataGridView1.Columns.Add("id_huesped", "ID_huesped");
            dataGridView1.Columns.Add("id_reserva", "ID_reserva");
            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("apellido", "Apellido");
            dataGridView1.Columns.Add("documento", "Documento");
            dataGridView1.Columns.Add("telefono", "Telefono");
            dataGridView1.Columns.Add("email", "Email");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
        }

        private void btn_CancelarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaHuesped huespedes = new AltaHuesped();
            huespedes.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarHuesped mod_huesped = new ModificarHuesped(dataGridView1.CurrentRow);
            mod_huesped.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
    }
}
