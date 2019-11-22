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
    public partial class ModificarReserva : Form
    {
        DataGridViewRow reserva_seleccionada = new DataGridViewRow();
        BE.Usuario usuario_logueado = new BE.Usuario();
        BLL.Cliente cliente_BLL = new BLL.Cliente();
        BLL.Habitacion habitacion_BLL = new BLL.Habitacion();
        BLL.ServAdicional servicio_BLL = new BLL.ServAdicional();
        BE.ServAdicionalReserva servAdicionalReserva_BE = new BE.ServAdicionalReserva();
        BLL.ServAdicionalReserva ServicioReserva_BLL = new BLL.ServAdicionalReserva();
        BE.Reserva reserva_BE = new BE.Reserva();
        BLL.Reserva reserva_BLL = new BLL.Reserva();
        List<BE.ServAdicional> serviciosReserva_lista = new List<BE.ServAdicional>();
        List<BE.ServAdicional> servicios = new List<BE.ServAdicional>();
        BLL.Huesped huesped_BLL = new BLL.Huesped();
        List<BE.Huesped> huespedes = new List<BE.Huesped>();
        BE.Huesped huesped_BE = new BE.Huesped();
        List<int> huespedesEliminados = new List<int>();

        public ModificarReserva()
        {
            InitializeComponent();
        }

        public ModificarReserva(DataGridViewRow reserva, BE.Usuario usu)
        {
            InitializeComponent();

            this.reserva_seleccionada = reserva;
            this.usuario_logueado = usu;
            this.lbl_errorCliente.Visible = false;
            this.lbl_errorHabitacion.Visible = false;
        }

        private void ModificarReserva_Load(object sender, EventArgs e)
        {
            this.ConfigurarGrilla();
            this.ObtenerDatos();
            this.validarCampos();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                reserva_BE.id_reserva = (int)this.reserva_seleccionada.Cells[0].Value;

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

                reserva_BLL.Update(reserva_BE);
                MessageBox.Show("Se modificó correctamente la reserva");

                //Servicios Adicionales       
                if (clb_servicios.CheckedItems.Count >= 1)
                {
                    //Se agregan servicios que no estaban antes
                    foreach (string itemSeleccionado in clb_servicios.CheckedItems)
                    {
                        if (!this.serviciosReserva_lista.Any(pu => pu.id_servicio == int.Parse(Regex.Match(itemSeleccionado.ToString(), @"\d+").Value)))
                        {
                            servAdicionalReserva_BE.id_servicio = int.Parse(Regex.Match(itemSeleccionado.ToString(), @"\d+").Value);
                            servAdicionalReserva_BE.id_reserva = (int)this.reserva_seleccionada.Cells[0].Value;
                            ServicioReserva_BLL.Add(servAdicionalReserva_BE);
                        }
                    }

                    //Se evaluan si se sacaron servicios
                    for (int i = 0; i < clb_servicios.Items.Count; i++)
			        {
			            if (!clb_servicios.GetItemChecked(i))
	                    {
                            if (this.serviciosReserva_lista.Any(pu => pu.id_servicio == int.Parse(Regex.Match(clb_servicios.Items[i].ToString(), @"\d+").Value)))
	                        {
                                servAdicionalReserva_BE.id_servicio = int.Parse(Regex.Match(clb_servicios.Items[i].ToString(), @"\d+").Value);
                                servAdicionalReserva_BE.id_reserva = (int)this.reserva_seleccionada.Cells[0].Value;
                                ServicioReserva_BLL.Delete(servAdicionalReserva_BE);
	                        }
	                    }
			        }
                }

                //Huesped
                BE.Huesped huespedAguardar = new BE.Huesped();
                BE.Huesped huespedAmodificar = new BE.Huesped();
                BE.Huesped huespedAeliminar = new BE.Huesped();
                
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    //si se repite verificar si se modificaron los campos
                    if (huespedes.Any(h => h.id_reserva == (int)item.Cells[1].Value))
                    {
                        if (huespedes.Any(h => h.nombre != item.Cells[2].Value.ToString() && h.apellido != item.Cells[3].Value.ToString() && h.documento != (int)item.Cells[4].Value && h.telefono != item.Cells[5].Value.ToString() && h.email != item.Cells[6].Value.ToString()))
                        {
                            huespedAmodificar.id_reserva = (int)this.reserva_seleccionada.Cells[0].Value;
                            huespedAmodificar.id_huesped = (int)item.Cells[0].Value;
                            huespedAmodificar.nombre = item.Cells[2].Value.ToString();
                            huespedAmodificar.apellido = item.Cells[3].Value.ToString();
                            huespedAmodificar.documento = (int)item.Cells[4].Value;
                            huespedAmodificar.telefono = item.Cells[5].Value.ToString();
                            huespedAmodificar.email = item.Cells[6].Value.ToString();

                            huesped_BLL.Update(huespedAmodificar);
                        }
                    }
                    
                    if (!huespedes.Any(h => h.id_reserva == (int)item.Cells[1].Value))
                    {
                        //si no se repite agregar los nuevos huespedes
                        huespedAguardar.id_reserva = (int)this.reserva_seleccionada.Cells[0].Value;
                        huespedAguardar.nombre = item.Cells[2].Value.ToString();
                        huespedAguardar.apellido = item.Cells[3].Value.ToString();
                        huespedAguardar.documento = (int)item.Cells[4].Value;
                        huespedAguardar.telefono = item.Cells[5].Value.ToString();
                        huespedAguardar.email = item.Cells[6].Value.ToString();
                        
                        huesped_BLL.Add(huespedAguardar);
                    }
                    else
                    {
                        foreach (int huesped in huespedesEliminados)
                        {
                            huespedAeliminar.id_huesped = huesped;
                            huesped_BLL.Delete(huespedAeliminar);
                        }
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Validar campos");
            } 
        }

        private void ObtenerDatos()
        {
            //CARGA DE FECHAS
            dtpIngreso.Text = this.reserva_seleccionada.Cells[7].Value.ToString();
            dtpSalida.Text = this.reserva_seleccionada.Cells[8].Value.ToString();

            //CARGA DE CLIENTES
            List<BE.Cliente> clientes = new List<BE.Cliente>();
            clientes = cliente_BLL.SelectAll();
            cmb_Cliente.Items.Add("Seleccionar");

            string clienteDeLaReserva = "";
            foreach (BE.Cliente cliente in clientes)
            {
                cmb_Cliente.Items.Add(cliente.id_cliente + " " + cliente.nombre + " " + cliente.apellido);

                if (cliente.id_cliente == (int)this.reserva_seleccionada.Cells[2].Value)
                {
                    clienteDeLaReserva = cliente.id_cliente + " " + cliente.nombre + " " + cliente.apellido;
                }
            }

            cmb_Cliente.Text = clienteDeLaReserva;

            //CARGA DE HABITACIONES
            List<BE.Habitacion> habitaciones = new List<BE.Habitacion>();
            habitaciones = habitacion_BLL.SelectAll();

            foreach (BE.Habitacion habitacion in habitaciones)
            {
                clb_habitaciones.Items.Add(habitacion.id_habitacion + " " + habitacion.tipo_habitacion + " " + habitacion.descripcion);

                if (habitacion.id_habitacion == (int)this.reserva_seleccionada.Cells[3].Value)
                {
                    clb_habitaciones.SetItemCheckState(clb_habitaciones.Items.Count - 1, CheckState.Checked);
                }
            }

            clb_habitaciones.CheckOnClick = true;

            //CARGA DE SERVICIOS ADICIONALES
            servicios = servicio_BLL.SelectAll();

            serviciosReserva_lista = ServicioReserva_BLL.GetServicioReserva((int)this.reserva_seleccionada.Cells[0].Value);

            foreach (BE.ServAdicional servicio in servicios)
            {
                clb_servicios.Items.Add(servicio.id_servicio + " " + servicio.descripcion);

                foreach (BE.ServAdicional servicioReserva in serviciosReserva_lista)
                {
                    if (servicio.id_servicio == servicioReserva.id_servicio)
                    {
                        clb_servicios.SetItemCheckState(clb_servicios.Items.Count - 1, CheckState.Checked);
                    }
                }
            }

            clb_servicios.CheckOnClick = true;

            //CARGA DE HUESPEDES
            huespedes = huesped_BLL.GetHuespedReserva((int)this.reserva_seleccionada.Cells[0].Value);

            foreach (BE.Huesped huesped in huespedes)
            {
                dataGridView1.Rows.Add(huesped.id_huesped, huesped.id_reserva, huesped.nombre, huesped.apellido, huesped.documento, huesped.telefono, huesped.email);
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AltaHuesped alta_huesped = new AltaHuesped();
            alta_huesped.Show(this);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarHuesped mod_huesped = new ModificarHuesped(dataGridView1.CurrentRow);
            mod_huesped.Show(this);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            huespedesEliminados.Add((int)dataGridView1.CurrentRow.Cells[0].Value);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

    }
}
