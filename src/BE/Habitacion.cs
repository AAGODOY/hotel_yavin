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
        public bool activo { get; set; }
        public string tipo_habitacion { get; set; }
        public string descripcion { get; set; }
        public string Nro_habitacion { get; set; }
        public double precio { get; set; }
    }
}
