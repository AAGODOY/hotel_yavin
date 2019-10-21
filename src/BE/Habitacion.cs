using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Habitacion
    {
        public int id_habitacion { get; set; }
        public int id_reserva { get; set; }
        public string estado { get; set; }
        public string tipo_habitacion { get; set; }
        public string descripcion { get; set; }
        public string Nro_habitacion { get; set; }
        public float precio { get; set; }
    }
}
