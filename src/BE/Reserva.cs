using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Reserva
    {
        public int id_reserva { get; set; }
        public int id_usuario { get; set; }
        public int id_cliente { get; set; }
        public bool activo { get; set; }
        public int DVH { get; set; }
        public string estado { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_salida { get; set; }
    }
}
